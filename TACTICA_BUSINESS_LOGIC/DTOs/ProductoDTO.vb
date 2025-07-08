Public Class ProductoDTO
    Property Id As Integer
    Property Nombre As String
    Property Precio As Decimal?
    Property Categoria As String
    Property Items As List(Of VentaItemsDTO)
End Class
