
Public Interface IItemRepository
    Function GetAll() As IEnumerable(Of Item)
    Function GetById(id As Integer) As Item
    Function Add(entity As Item, command As IDbCommand) As Integer
    Sub Delete(entity As Item, command As IDbCommand)
    Sub DeleteByVenta(entity As Venta, command As IDbCommand)
    Function GetAllByCliente(cliente As Cliente) As IEnumerable(Of Item)
    Function GetAllByVenta(cliente As Venta) As IEnumerable(Of Item)
End Interface
