Imports System.Data.SqlClient

Friend Class ItemRepository
    Implements IItemRepository
    Private ReadOnly conexion As Connection
    Public Sub New(conexion As Connection)
        Me.conexion = conexion
    End Sub

    Public Sub Delete(entity As Item, command As IDbCommand) Implements IItemRepository.Delete
        Dim query As String = "DELETE FROM ventasitems WHERE ID = @Id"
        command.CommandText = query
        command.Parameters.Add(New SqlParameter("@Id", entity.ID))
        command.ExecuteNonQuery()
        command.Parameters.Clear()
    End Sub

    Public Sub DeleteByVenta(entity As Venta, command As IDbCommand) Implements IItemRepository.DeleteByVenta
        Dim query As String = "DELETE FROM ventasitems WHERE IDVenta = @Id"
        command.CommandText = query
        command.Parameters.Add(New SqlParameter("@Id", entity.ID))
        command.ExecuteNonQuery()
        command.Parameters.Clear()
    End Sub

    Public Function GetAll() As IEnumerable(Of Item) Implements IItemRepository.GetAll
        Dim query As String = "SELECT vi.ID,vi.PrecioUnitario,vi.Cantidad,vi.PrecioTotal,vi.IDProducto,vi.IDVenta,p.Nombre,p.Precio,p.Categoria,v.Fecha,v.Total,v.IDCliente,c.Cliente,c.Correo,c.Telefono FROM ventasitems AS vi LEFT JOIN productos AS p ON p.ID = vi.IDProducto LEFT JOIN ventas AS v ON v.ID = vi.IDVenta LEFT JOIN clientes AS c ON c.ID = v.IDCliente"
        Dim items As New List(Of Item)
        Using connection As IDbConnection = conexion.CreateConnection()
            Using command As IDbCommand = connection.CreateCommand()
                command.CommandText = query
                Using reader As IDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim producto As New Producto() With {
                            .ID = Convert.ToInt32(reader("IDProducto")),
                            .Categoria = Convert.ToString(RepositoryHelper.GetNullableValue(reader("Categoria"))),
                            .Nombre = Convert.ToString(reader("Nombre")),
                            .Precio = Convert.ToDecimal(RepositoryHelper.GetNullableValue(reader("Precio")))
                            }
                        Dim cliente As New Cliente() With {
                            .ID = Convert.ToInt32(reader("IDCliente")),
                            .Cliente = Convert.ToString(reader("Cliente")),
                            .Correo = Convert.ToString(RepositoryHelper.GetNullableValue(reader("Correo"))),
                            .Telefono = Convert.ToString(RepositoryHelper.GetNullableValue(reader("Telefono")))
                            }
                        Dim venta As New Venta() With {
                            .ID = Convert.ToInt32(reader("IDVenta")),
                            .Cliente = cliente,
                            .Fecha = Convert.ToDateTime(RepositoryHelper.GetNullableValue(reader("Fecha"))),
                            .Total = Convert.ToDecimal(RepositoryHelper.GetNullableValue(reader("Total")))
                            }
                        Dim item As New Item() With {
                            .ID = Convert.ToInt32(reader("ID")),
                            .Venta = venta,
                            .Producto = producto,
                            .Cantidad = Convert.ToDecimal(RepositoryHelper.GetNullableValue(reader("Cantidad"))),
                            .PrecioUnitario = Convert.ToDecimal(RepositoryHelper.GetNullableValue(reader("PrecioUnitario"))),
                            .PrecioTotal = Convert.ToDecimal(RepositoryHelper.GetNullableValue(reader("PrecioTotal")))
                            }
                        items.Add(item)
                    End While
                End Using
            End Using
        End Using
        Return items
    End Function

    Public Function GetById(id As Integer) As Item Implements IItemRepository.GetById
        Dim query As String = "SELECT vi.ID,vi.PrecioUnitario,vi.Cantidad,vi.PrecioTotal,vi.IDProducto,vi.IDVenta,p.Nombre,p.Precio,p.Categoria,v.Fecha,v.Total,v.IDCliente,c.Cliente,c.Correo,c.Telefono FROM ventasitems AS vi LEFT JOIN productos AS p ON p.ID = vi.IDProducto LEFT JOIN ventas AS v ON v.ID = vi.IDVenta LEFT JOIN clientes AS c ON c.ID = v.IDCliente WHERE ID = @Id"
        Using connection As IDbConnection = conexion.CreateConnection()
            Using command As IDbCommand = connection.CreateCommand()
                command.CommandText = query
                command.Parameters.Add(New SqlParameter("@Id", id))
                Using reader As IDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        Dim producto As New Producto() With {
                            .ID = Convert.ToInt32(reader("IDProducto")),
                            .Categoria = Convert.ToString(RepositoryHelper.GetNullableValue(reader("Categoria"))),
                            .Nombre = Convert.ToString(reader("Nombre")),
                            .Precio = Convert.ToDecimal(RepositoryHelper.GetNullableValue(reader("Precio")))
                            }
                        Dim cliente As New Cliente() With {
                            .ID = Convert.ToInt32(reader("IDCliente")),
                            .Cliente = Convert.ToString(reader("Cliente")),
                            .Correo = Convert.ToString(RepositoryHelper.GetNullableValue(reader("Correo"))),
                            .Telefono = Convert.ToString(RepositoryHelper.GetNullableValue(reader("Telefono")))
                            }
                        Dim venta As New Venta() With {
                            .ID = Convert.ToInt32(reader("IDVenta")),
                            .Cliente = cliente,
                            .Fecha = Convert.ToDateTime(RepositoryHelper.GetNullableValue(reader("Fecha"))),
                            .Total = Convert.ToDecimal(RepositoryHelper.GetNullableValue(reader("Total")))
                            }
                        Return New Item() With {
                            .ID = Convert.ToInt32(reader("ID")),
                            .Venta = venta,
                            .Producto = producto,
                            .Cantidad = Convert.ToDecimal(RepositoryHelper.GetNullableValue(reader("Cantidad"))),
                            .PrecioUnitario = Convert.ToDecimal(RepositoryHelper.GetNullableValue(reader("PrecioUnitario"))),
                            .PrecioTotal = Convert.ToDecimal(RepositoryHelper.GetNullableValue(reader("PrecioTotal")))
                        }
                    End If
                End Using
            End Using
        End Using
        Return Nothing
    End Function

    Public Function Add(entity As Item, command As IDbCommand) As Integer Implements IItemRepository.Add
        Dim query As String = "INSERT INTO ventasitems VALUES (@IDVenta,@IDProducto,@PrecioUnitario,@Cantidad,@PrecioTotal)"
        command.CommandText = query

        Dim precioUnitario As Object = RepositoryHelper.FormatNullableValue(entity.PrecioUnitario)
        Dim cantidad As Object = RepositoryHelper.FormatNullableValue(entity.Cantidad)
        Dim precioTotal As Object = RepositoryHelper.FormatNullableValue(entity.PrecioTotal)

        command.Parameters.Add(New SqlParameter("@IDVenta", entity.Venta.ID))
        command.Parameters.Add(New SqlParameter("@IDProducto", entity.Producto.ID))
        command.Parameters.Add(New SqlParameter("@PrecioUnitario", precioUnitario))
        command.Parameters.Add(New SqlParameter("@Cantidad", cantidad))
        command.Parameters.Add(New SqlParameter("@PrecioTotal", precioTotal))

        Dim id As Integer = CType(command.ExecuteScalar(), Integer)
        command.Parameters.Clear()
        Return id
    End Function

    Public Function GetAllByCliente(cliente As Cliente) As IEnumerable(Of Item) Implements IItemRepository.GetAllByCliente
        Dim query As String = "SELECT vi.ID,vi.PrecioUnitario,vi.Cantidad,vi.PrecioTotal,vi.IDProducto,vi.IDVenta,p.Nombre,p.Precio,p.Categoria,v.Fecha,v.Total FROM ventasitems AS vi LEFT JOIN productos AS p ON p.ID = vi.IDProducto LEFT JOIN ventas AS v ON v.ID = vi.IDVenta LEFT JOIN clientes AS c ON c.ID = v.IDClienteWHERE v.IDCliente = @Id"
        Dim items As New List(Of Item)
        Using connection As IDbConnection = conexion.CreateConnection()
            Using command As IDbCommand = connection.CreateCommand()
                command.CommandText = query
                command.Parameters.Add(New SqlParameter("@Id", cliente.ID))
                Using reader As IDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim producto As New Producto() With {
                            .ID = Convert.ToInt32(reader("IDProducto")),
                            .Categoria = Convert.ToString(RepositoryHelper.GetNullableValue(reader("Categoria"))),
                            .Nombre = Convert.ToString(reader("Nombre")),
                            .Precio = Convert.ToDecimal(RepositoryHelper.GetNullableValue(reader("Precio")))
                            }
                        Dim venta As New Venta() With {
                            .ID = Convert.ToInt32(reader("IDVenta")),
                            .Cliente = cliente,
                            .Fecha = Convert.ToDateTime(RepositoryHelper.GetNullableValue(reader("Fecha"))),
                            .Total = Convert.ToDecimal(RepositoryHelper.GetNullableValue(reader("Total")))
                            }
                        Dim item As New Item() With {
                            .ID = Convert.ToInt32(reader("ID")),
                            .Venta = venta,
                            .Producto = producto,
                            .Cantidad = Convert.ToDecimal(RepositoryHelper.GetNullableValue(reader("Cantidad"))),
                            .PrecioUnitario = Convert.ToDecimal(RepositoryHelper.GetNullableValue(reader("PrecioUnitario"))),
                            .PrecioTotal = Convert.ToDecimal(RepositoryHelper.GetNullableValue(reader("PrecioTotal")))
                            }
                        items.Add(item)
                    End While
                End Using
            End Using
        End Using
        Return items
    End Function

    Public Function GetAllByVenta(venta As Venta) As IEnumerable(Of Item) Implements IItemRepository.GetAllByVenta
        Dim query As String = "SELECT vi.ID,vi.PrecioUnitario,vi.Cantidad,vi.PrecioTotal,vi.IDProducto,vi.IDVenta,p.Nombre,p.Precio,p.Categoria FROM ventasitems AS vi LEFT JOIN productos AS p ON p.ID = vi.IDProducto LEFT JOIN ventas AS v ON v.ID = vi.IDVenta WHERE vi.IDVenta = @Id"
        Dim items As New List(Of Item)
        Using connection As IDbConnection = conexion.CreateConnection()
            Using command As IDbCommand = connection.CreateCommand()
                command.CommandText = query
                command.Parameters.Add(New SqlParameter("@Id", venta.ID))
                Using reader As IDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim producto As New Producto() With {
                            .ID = Convert.ToInt32(reader("IDProducto")),
                            .Categoria = Convert.ToString(RepositoryHelper.GetNullableValue(reader("Categoria"))),
                            .Nombre = Convert.ToString(reader("Nombre")),
                            .Precio = Convert.ToDecimal(RepositoryHelper.GetNullableValue(reader("Precio")))
                            }
                        Dim item As New Item() With {
                            .ID = Convert.ToInt32(reader("ID")),
                            .Venta = venta,
                            .Producto = producto,
                            .Cantidad = Convert.ToDecimal(RepositoryHelper.GetNullableValue(reader("Cantidad"))),
                            .PrecioUnitario = Convert.ToDecimal(RepositoryHelper.GetNullableValue(reader("PrecioUnitario"))),
                            .PrecioTotal = Convert.ToDecimal(RepositoryHelper.GetNullableValue(reader("PrecioTotal")))
                            }
                        items.Add(item)
                    End While
                End Using
            End Using
        End Using
        Return items
    End Function
End Class
