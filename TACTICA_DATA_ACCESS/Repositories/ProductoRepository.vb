Imports System.Data.SqlClient

Friend Class ProductoRepository
    Implements IProductoRespository
    Private ReadOnly conexion As Connection
    Public Sub New(conexion As Connection)
        Me.conexion = conexion
    End Sub

    Public Function Add(entity As Producto) As Integer Implements IBaseRepository(Of Producto).Add
        Dim query As String = "INSERT INTO productos VALUES (@Nombre,@Precio,@Categoria);SELECT Id = SCOPE_IDENTITY()"
        Using connection As IDbConnection = conexion.CreateConnection()
            Using command As IDbCommand = connection.CreateCommand()
                command.CommandText = query

                Dim nombre As Object = RepositoryHelper.FormatNullableValue(entity.Nombre)
                Dim precio As Object = RepositoryHelper.FormatNullableValue(entity.Precio)
                Dim categoria As Object = RepositoryHelper.FormatNullableValue(entity.Categoria)

                command.Parameters.Add(New SqlParameter("@Nombre", nombre))
                command.Parameters.Add(New SqlParameter("@Precio", precio))
                command.Parameters.Add(New SqlParameter("@Categoria", categoria))
                Dim id As Integer = CType(command.ExecuteScalar(), Integer)
                Return id
            End Using
        End Using
    End Function
    Public Sub Update(entity As Producto) Implements IBaseRepository(Of Producto).Update
        Dim query As String = "UPDATE productos SET Nombre = @Nombre,Precio = @Precio,Categoria = @Categoria WHERE ID = @Id"
        Using connection As IDbConnection = conexion.CreateConnection()
            Using command As IDbCommand = connection.CreateCommand()
                command.CommandText = query
                Dim nombre As Object = RepositoryHelper.FormatNullableValue(entity.Nombre)
                Dim precio As Object = RepositoryHelper.FormatNullableValue(entity.Precio)
                Dim categoria As Object = RepositoryHelper.FormatNullableValue(entity.Categoria)
                command.Parameters.Add(New SqlParameter("@Id", entity.ID))
                command.Parameters.Add(New SqlParameter("@Nombre", nombre))
                command.Parameters.Add(New SqlParameter("@Precio", precio))
                command.Parameters.Add(New SqlParameter("@Categoria", categoria))
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub Delete(entity As Producto) Implements IBaseRepository(Of Producto).Delete
        Dim query As String = "DELETE FROM productos WHERE ID = @Id"
        Using connection As IDbConnection = conexion.CreateConnection()
            Using command As IDbCommand = connection.CreateCommand()
                command.CommandText = query
                command.Parameters.Add(New SqlParameter("@Id", entity.ID))
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function GetAllCategorias() As IEnumerable(Of String) Implements IProductoRespository.GetAllCategorias
        Dim query As String = "SELECT DISTINCT categoria from productos WHERE Categoria IS NOT NULL"
        Dim categorias As New List(Of String)()
        Using connection As IDbConnection = conexion.CreateConnection()
            Using command As IDbCommand = connection.CreateCommand()
                command.CommandText = query
                Using reader As IDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim categoria As String = Convert.ToString(reader("Categoria"))
                        categorias.Add(categoria)
                    End While
                End Using
            End Using
        End Using
        Return categorias
    End Function

    Public Function GetAll() As IEnumerable(Of Producto) Implements IBaseRepository(Of Producto).GetAll
        Dim query As String = "SELECT * FROM productos"
        Dim productos As New List(Of Producto)()
        Using connection As IDbConnection = conexion.CreateConnection()
            Using command As IDbCommand = connection.CreateCommand()
                command.CommandText = query
                Using reader As IDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim producto As New Producto() With {
                            .ID = Convert.ToInt32(reader("ID")),
                            .Nombre = Convert.ToString(reader("Nombre")),
                            .Precio = Convert.ToDecimal(RepositoryHelper.GetNullableValue(reader("Precio"))),
                            .Categoria = Convert.ToString(RepositoryHelper.GetNullableValue(reader("Categoria")))
                            }
                        productos.Add(producto)
                    End While
                End Using
            End Using
        End Using
        Return productos
    End Function
    Public Function GetById(id As Integer) As Producto Implements IBaseRepository(Of Producto).GetById
        Dim query As String = "SELECT * FROM productos WHERE ID = @Id"
        Using connection As IDbConnection = conexion.CreateConnection()
            Using command As IDbCommand = connection.CreateCommand()
                command.CommandText = query
                command.Parameters.Add(New SqlParameter("@Id", id))
                Using reader As IDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        Return New Producto() With {
                             .ID = Convert.ToInt32(reader("ID")),
                            .Nombre = Convert.ToString(reader("Nombre")),
                            .Precio = Convert.ToDecimal(RepositoryHelper.GetNullableValue(reader("Precio"))),
                            .Categoria = Convert.ToString(RepositoryHelper.GetNullableValue(reader("Categoria")))
                        }
                    End If
                End Using
            End Using
        End Using
        Return Nothing
    End Function



End Class
