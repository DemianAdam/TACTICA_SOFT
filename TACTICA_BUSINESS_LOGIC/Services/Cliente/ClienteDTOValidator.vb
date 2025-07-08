
Public Class ClienteDTOValidator
    Implements IValidator(Of ClienteDTO)

    Public Sub Validate(entity As ClienteDTO) Implements IValidator(Of ClienteDTO).Validate
        Dim noTieneCliente As Boolean = String.IsNullOrEmpty(entity.Cliente)

        If noTieneCliente Then
            Throw New InvalidClienteException("El cliente es obligatorio")
        End If

    End Sub
End Class
