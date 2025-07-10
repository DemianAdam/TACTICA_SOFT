Imports System.ComponentModel

Public Class VentaItemsDTO
    Property Id As Integer
    Property Producto As ProductoDTO

    <Browsable(False)>
    Property Venta As VentaDTO
    Property PrecioUnitario As Decimal?
    Property Cantidad As Decimal?
    Property PrecioTotal As Decimal?
End Class
