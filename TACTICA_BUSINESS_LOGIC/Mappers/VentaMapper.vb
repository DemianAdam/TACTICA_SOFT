Imports System.Runtime.CompilerServices
Imports TACTICA_DATA_ACCESS

Friend Module VentaMapper

    <Extension()>
    Public Function ToModel(venta As VentaDTO) As Venta
        Return New Venta With {
            .ID = venta.Id,
            .Cliente = venta.Cliente.ToModel(),
            .Fecha = venta.Fecha,
            .Total = venta.Total
            }
    End Function

    <Extension()>
    Public Function ToDTO(venta As Venta) As VentaDTO
        Return New VentaDTO With {
        .Id = venta.ID,
        .Fecha = venta.Fecha,
        .Total = venta.Total,
        .Cliente = venta.Cliente.ToDTO()
        }
    End Function

    <Extension()>
    Public Function ToDTO(ventas As IEnumerable(Of Venta)) As IEnumerable(Of VentaDTO)
        Return ventas.Select(Function(x) x.ToDTO())
    End Function
End Module
