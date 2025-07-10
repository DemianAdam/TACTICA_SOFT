Public Class VentaDTOValidator
    Implements IValidator(Of VentaDTO)

    Public Sub Validate(entity As VentaDTO) Implements IValidator(Of VentaDTO).Validate
        Dim noTieneCliente As Boolean = entity.Cliente Is Nothing
        Dim totalCeroONegativo As Boolean = If(entity.Total <= 0, False)
        Dim noTienePorLoMenosUnItem As Boolean = entity.Items.Count <= 0

        If noTieneCliente Then
            Throw New InvalidProductoException("El cliente es obligatorio.")
        End If

        If totalCeroONegativo Then
            Throw New InvalidProductoException("El total no puede ser 0 o menor")
        End If

        If noTienePorLoMenosUnItem Then
            Throw New InvalidProductoException("Debe tener mas de un item")
        End If
    End Sub
End Class
