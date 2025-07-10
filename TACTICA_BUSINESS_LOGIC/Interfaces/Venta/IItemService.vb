
Public Interface IItemService
    Function GetAll() As IEnumerable(Of VentaItemsDTO)
    Function GetAllByCliente(cliente As ClienteDTO) As IEnumerable(Of VentaItemsDTO)
    Function GetAllByVenta(cliente As VentaDTO) As IEnumerable(Of VentaItemsDTO)
End Interface
