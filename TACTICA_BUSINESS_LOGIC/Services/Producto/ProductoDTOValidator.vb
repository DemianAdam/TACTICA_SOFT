Public Class ProductoDTOValidator
    Implements IValidator(Of ProductoDTO)

    Public Sub Validate(entity As ProductoDTO) Implements IValidator(Of ProductoDTO).Validate
        Dim noTieneNombre As Boolean = String.IsNullOrEmpty(entity.Nombre)

        If noTieneNombre Then
            Throw New InvalidProductoException("El nombre es obligatorio")
        End If
    End Sub
End Class
