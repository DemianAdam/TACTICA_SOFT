Public Interface IVentaUnitOfWork
    Sub Add(venta As Venta, items As List(Of Item))
    Sub Update(venta As Venta, items As List(Of Item))
    Sub Delete(venta As Venta)

    Function GetAll() As IEnumerable(Of Venta)
    Function GetById(id As Integer) As Venta
    Function GetAllByCliente(cliente As Cliente) As IEnumerable(Of Venta)
End Interface
