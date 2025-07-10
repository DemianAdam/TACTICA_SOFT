Imports System.Data.SqlClient

Friend Class VentaRespository
    Implements IVentaRepository
    Private ReadOnly conexion As Connection
    Public Sub New(conexion As Connection)
        Me.conexion = conexion
    End Sub
    Public Function Add(entity As Venta, command As IDbCommand) As Integer Implements IVentaRepository.Add
        Dim query As String = "INSERT INTO ventas VALUES (@IDCliente,@Fecha,@Total);SELECT Id = SCOPE_IDENTITY()"
        command.CommandText = query
        Dim fecha As Object = RepositoryHelper.FormatNullableValue(entity.Fecha)
        Dim total As Object = RepositoryHelper.FormatNullableValue(entity.Total)

        command.Parameters.Add(New SqlParameter("@IDCliente", entity.Cliente.ID))
        command.Parameters.Add(New SqlParameter("@Fecha", fecha))
        command.Parameters.Add(New SqlParameter("@Total", total))

        Dim id As Integer = CType(command.ExecuteScalar(), Integer)
        command.Parameters.Clear()
        Return id
    End Function

    Public Sub Update(entity As Venta, command As IDbCommand) Implements IVentaRepository.Update
        Dim query As String = "UPDATE ventas SET IDCliente = @IDCliente, Fecha = @Fecha, Precio = @Precio WHERE ID = @Id"
        command.CommandText = query
        Dim fecha As Object = RepositoryHelper.FormatNullableValue(entity.Fecha)
        Dim total As Object = RepositoryHelper.FormatNullableValue(entity.Total)
        command.Parameters.Add(New SqlParameter("@Id", entity.ID))
        command.Parameters.Add(New SqlParameter("@IDCliente", entity.Cliente.ID))
        command.Parameters.Add(New SqlParameter("@Fecha", fecha))
        command.Parameters.Add(New SqlParameter("@Total", total))
        command.ExecuteNonQuery()
        command.Parameters.Clear()
    End Sub

    Public Sub Delete(entity As Venta, command As IDbCommand) Implements IVentaRepository.Delete
        Dim query As String = "DELETE FROM ventas WHERE ID = @Id"
        command.CommandText = query
        command.Parameters.Add(New SqlParameter("@Id", entity.ID))
        command.ExecuteNonQuery()
    End Sub

    Public Function GetAll() As IEnumerable(Of Venta) Implements IVentaRepository.GetAll
        Dim query As String = "SELECT v.ID,v.Fecha,v.Total,c.ID AS ClienteId,c.Cliente,c.Correo,c.Telefono FROM ventas AS v LEFT JOIN clientes AS c ON c.ID = v.IDCliente"
        Dim ventas As New List(Of Venta)
        Using connection As IDbConnection = conexion.CreateConnection()
            Using command As IDbCommand = connection.CreateCommand()
                command.CommandText = query
                Using reader As IDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim cliente As New Cliente() With {
                            .ID = Convert.ToInt32(reader("ClienteId")),
                            .Cliente = Convert.ToString(reader("Cliente")),
                            .Correo = Convert.ToString(RepositoryHelper.GetNullableValue(reader("Correo"))),
                            .Telefono = Convert.ToString(RepositoryHelper.GetNullableValue(reader("Telefono")))
                            }
                        Dim venta As New Venta() With {
                            .ID = Convert.ToInt32(reader("ID")),
                            .Cliente = cliente,
                            .Fecha = Convert.ToDateTime(RepositoryHelper.GetNullableValue(reader("Fecha"))),
                            .Total = Convert.ToDecimal(RepositoryHelper.GetNullableValue(reader("Total")))
                            }
                        ventas.Add(venta)
                    End While
                End Using
            End Using
        End Using
        Return ventas
    End Function

    Public Function GetById(id As Integer) As Venta Implements IVentaRepository.GetById
        Dim query As String = "SELECT v.ID,v.Fecha,v.Total,c.ID AS ClienteId,c.Cliente,c.Correo,c.Telefono FROM ventas AS v LEFT JOIN clientes AS c ON c.ID = v.IDCliente WHERE ID = @Id"
        Using connection As IDbConnection = conexion.CreateConnection()
            Using command As IDbCommand = connection.CreateCommand()
                command.CommandText = query
                command.Parameters.Add(New SqlParameter("@Id", id))
                Using reader As IDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        Dim cliente As New Cliente() With {
                            .ID = Convert.ToInt32(reader("ClienteId")),
                            .Cliente = Convert.ToString(reader("Cliente")),
                            .Correo = Convert.ToString(RepositoryHelper.GetNullableValue(reader("Correo"))),
                            .Telefono = Convert.ToString(RepositoryHelper.GetNullableValue(reader("Telefono")))
                            }
                        Return New Venta() With {
                             .ID = Convert.ToInt32(reader("ID")),
                            .Cliente = cliente,
                            .Fecha = Convert.ToDateTime(RepositoryHelper.GetNullableValue(reader("Precio"))),
                            .Total = Convert.ToDecimal(RepositoryHelper.GetNullableValue(reader("Categoria")))
                        }
                    End If
                End Using
            End Using
        End Using
        Return Nothing
    End Function


    Public Function GetAllByCliente(cliente As Cliente) As IEnumerable(Of Venta) Implements IVentaRepository.GetAllByCliente
        Dim query As String = "SELECT * FROM ventas WHERE IDCliente = @Id"
        Dim ventas As New List(Of Venta)
        Using connection As IDbConnection = conexion.CreateConnection()
            Using command As IDbCommand = connection.CreateCommand()
                command.CommandText = query
                command.Parameters.Add(New SqlParameter("@Id", cliente.ID))
                Using reader As IDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim venta As New Venta() With {
                            .ID = Convert.ToInt32(reader("ID")),
                            .Cliente = cliente,
                            .Fecha = Convert.ToDateTime(RepositoryHelper.GetNullableValue(reader("Fecha"))),
                            .Total = Convert.ToDecimal(RepositoryHelper.GetNullableValue(reader("Total")))
                            }
                        ventas.Add(venta)
                    End While
                End Using
            End Using
        End Using
        Return ventas
    End Function
End Class
