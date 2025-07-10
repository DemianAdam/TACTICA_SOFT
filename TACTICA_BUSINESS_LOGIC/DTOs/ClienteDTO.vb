Public Class ClienteDTO
    Property Id As Integer
    Property Cliente As String
    Property Telefono As String
    Property Correo As String
    Property Ventas As List(Of VentaDTO)

    Public Overrides Function ToString() As String
        Return Cliente
    End Function
End Class
