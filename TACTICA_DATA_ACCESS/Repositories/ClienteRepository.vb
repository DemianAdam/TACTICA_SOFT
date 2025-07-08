
Imports System.Configuration
Imports System.Data.SqlClient

Friend Class ClienteRepository
    Implements IClienteRepository

    Private ReadOnly conexion As Connection
    Public Sub New(conexion As Connection)
        Me.conexion = conexion
    End Sub

    Public Function Add(entity As Cliente) As Integer Implements IBaseRepository(Of Cliente).Add
        Dim query As String = "INSERT INTO clientes VALUES (@Cliente, @Telefono, @Correo);SELECT Id = SCOPE_IDENTITY()"
        Using connection As Connection = conexion.CreateConnection()
            Using command As IDbCommand = connection.CreateCommand()
                command.CommandText = query
                Dim telefono As Object = RepositoryHelper.FormatNullableValue(entity.Telefono)
                Dim correo As Object = RepositoryHelper.FormatNullableValue(entity.Correo)
                command.Parameters.Add(New SqlParameter("@Cliente", entity.Cliente))
                command.Parameters.Add(New SqlParameter("@Telefono", telefono))
                command.Parameters.Add(New SqlParameter("@Correo", correo))
                Dim id As Integer = CType(command.ExecuteScalar(), Integer)
                Return id
            End Using
        End Using
    End Function

    Public Sub Update(entity As Cliente) Implements IBaseRepository(Of Cliente).Update
        Dim query As String = "UPDATE clientes SET Cliente = @Cliente, Telefono = @Telefono, Correo = @Correo WHERE ID = @Id"
        Using connection As Connection = conexion.CreateConnection()
            Using command As IDbCommand = connection.CreateCommand()
                command.CommandText = query
                Dim telefono As Object = RepositoryHelper.FormatNullableValue(entity.Telefono)
                Dim correo As Object = RepositoryHelper.FormatNullableValue(entity.Correo)
                command.Parameters.Add(New SqlParameter("@Id", entity.ID))
                command.Parameters.Add(New SqlParameter("@Cliente", entity.Cliente))
                command.Parameters.Add(New SqlParameter("@Telefono", telefono))
                command.Parameters.Add(New SqlParameter("@Correo", correo))
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub Delete(entity As Cliente) Implements IBaseRepository(Of Cliente).Delete
        Dim query As String = "DELETE FROM clientes WHERE ID = @Id"
        Using connection As Connection = conexion.CreateConnection()
            Using command As IDbCommand = connection.CreateCommand()
                command.CommandText = query
                command.Parameters.Add(New SqlParameter("@Id", entity.ID))
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function GetAll() As IEnumerable(Of Cliente) Implements IBaseRepository(Of Cliente).GetAll
        Dim query As String = "SELECT * FROM clientes"
        Dim clientes As New List(Of Cliente)()
        Using connection As Connection = conexion.CreateConnection()
            Using command As IDbCommand = connection.CreateCommand()
                command.CommandText = query
                Using reader As IDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim cliente As New Cliente() With {
                            .ID = Convert.ToInt32(reader("Id")),
                            .Cliente = Convert.ToString(reader("Cliente")),
                            .Telefono = Convert.ToString(RepositoryHelper.GetNullableValue(reader("Telefono"))),
                            .Correo = Convert.ToString(RepositoryHelper.GetNullableValue(reader("Correo")))
                        }
                        clientes.Add(cliente)
                    End While
                End Using
            End Using
        End Using
        Return clientes
    End Function

    Public Function GetById(id As Integer) As Cliente Implements IBaseRepository(Of Cliente).GetById
        Dim query As String = "SELECT * FROM clientes WHERE ID = @Id"
        Using connection As Connection = conexion.CreateConnection()
            Using command As IDbCommand = connection.CreateCommand()
                command.CommandText = query
                command.Parameters.Add(New SqlParameter("@Id", id))
                Using reader As IDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        Return New Cliente() With {
                            .ID = Convert.ToInt32(reader("Id")),
                            .Cliente = Convert.ToString(reader("Cliente")),
                            .Telefono = Convert.ToString(RepositoryHelper.GetNullableValue(reader("Telefono"))),
                            .Correo = Convert.ToString(RepositoryHelper.GetNullableValue(reader("Correo")))
                        }
                    End If
                End Using
            End Using
        End Using
        Return Nothing
    End Function
End Class
