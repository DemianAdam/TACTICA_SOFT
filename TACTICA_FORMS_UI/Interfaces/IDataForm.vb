Public Interface IDataForm(Of T)
    Function IsValid(obj As T) As Boolean
    Function GetObjectFromInputs(Optional id As Integer = -1) As T
    Sub SetInputs(obj As T)
    Sub ClearInputs()
End Interface
