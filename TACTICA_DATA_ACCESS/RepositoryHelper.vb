Module RepositoryHelper
    Public Function FormatNullableValue(value As Object) As Object
        If value Is Nothing Then
            Return DBNull.Value
        End If

        Return value
    End Function

    Public Function GetNullableValue(value As Object) As Object
        If value Is DBNull.Value Then
            Return Nothing
        End If

        Return value
    End Function
End Module
