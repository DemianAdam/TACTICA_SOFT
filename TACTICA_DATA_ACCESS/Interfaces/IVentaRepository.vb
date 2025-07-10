Public Interface IVentaRepository
    Function GetAll() As IEnumerable(Of Venta)
    Function GetById(id As Integer) As Venta
    Function Add(entity As Venta, command As IDbCommand) As Integer
    Sub Update(entity As Venta, command As IDbCommand)
    Sub Delete(entity As Venta, command As IDbCommand)
    Function GetAllByCliente(cliente As Cliente) As IEnumerable(Of Venta)
End Interface
