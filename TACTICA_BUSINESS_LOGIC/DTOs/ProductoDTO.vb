Public Class ProductoDTO
    Property Id As Integer
    Property Nombre As String
    Property Precio As Decimal?
    Property Categoria As String
    Property Items As List(Of VentaItemsDTO)

    Public Overrides Function ToString() As String
        Return Nombre
    End Function
End Class
