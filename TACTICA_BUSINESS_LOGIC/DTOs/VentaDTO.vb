Public Class VentaDTO
    Property Id As Integer
    Property Cliente As ClienteDTO
    Property Fecha As DateTime
    Property Total As Decimal
    Property Items As List(Of VentaItemsDTO)
End Class
