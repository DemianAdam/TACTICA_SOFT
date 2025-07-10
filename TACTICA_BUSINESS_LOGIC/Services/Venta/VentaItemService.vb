Imports TACTICA_DATA_ACCESS

Public Class VentaItemService
    Implements IItemService
    Private ReadOnly _ventaItemRepository As IItemRepository
    Public Sub New(ventaItemRepository As IItemRepository)
        _ventaItemRepository = ventaItemRepository
    End Sub

    Public Function GetAll() As IEnumerable(Of VentaItemsDTO) Implements IItemService.GetAll
        Return _ventaItemRepository.GetAll().ToDTO()
    End Function

    Public Function GetAllByCliente(cliente As ClienteDTO) As IEnumerable(Of VentaItemsDTO) Implements IItemService.GetAllByCliente
        Dim model As Cliente = cliente.ToModel()
        Return _ventaItemRepository.GetAllByCliente(model).ToDTO()
    End Function

    Public Function GetAllByVenta(venta As VentaDTO) As IEnumerable(Of VentaItemsDTO) Implements IItemService.GetAllByVenta
        Dim model As Venta = venta.ToModel()
        Return _ventaItemRepository.GetAllByVenta(model).ToDTO()
    End Function
End Class
