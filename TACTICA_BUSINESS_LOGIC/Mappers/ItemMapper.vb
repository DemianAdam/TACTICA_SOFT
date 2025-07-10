Imports System.Runtime.CompilerServices
Imports TACTICA_DATA_ACCESS

Friend Module ItemMapper
    <Extension()>
    Public Function ToModel(item As VentaItemsDTO) As Item
        Return New Item With {
           .ID = item.Id,
           .Cantidad = item.Cantidad,
           .PrecioTotal = item.PrecioTotal,
           .PrecioUnitario = item.PrecioUnitario,
           .Producto = item.Producto.ToModel(),
           .Venta = item.Venta.ToModel()
            }
    End Function
    <Extension()>
    Public Function ToModel(items As IEnumerable(Of VentaItemsDTO)) As IEnumerable(Of Item)
        Return items.Select(Function(x) x.ToModel())
    End Function

    <Extension()>
    Public Function ToDTO(item As Item) As VentaItemsDTO
        Return New VentaItemsDTO With {
            .Id = item.ID,
            .Cantidad = item.Cantidad,
            .PrecioTotal = item.PrecioTotal,
            .PrecioUnitario = item.PrecioUnitario,
            .Producto = item.Producto.ToDTO(),
            .Venta = item.Venta.ToDTO()
            }
    End Function

    <Extension()>
    Public Function ToDTO(items As IEnumerable(Of Item)) As IEnumerable(Of VentaItemsDTO)
        Return items.Select(Function(x) x.ToDTO())
    End Function
End Module
