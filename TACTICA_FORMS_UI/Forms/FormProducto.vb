Imports TACTICA_BUSINESS_LOGIC

Public Class FormProducto
    Implements IGetInput(Of ProductoDTO)

    Public Sub New()
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Function GetObjectFromInputs(Optional id As Integer = -1) As ProductoDTO Implements IGetInput(Of ProductoDTO).GetObjectFromInputs
        Throw New NotImplementedException()
    End Function
End Class