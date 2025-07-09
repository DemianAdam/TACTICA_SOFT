Public Module FormHelper
    Public Function GetSelected(Of T)(dgv As DataGridView) As T
        If dgv.CurrentRow Is Nothing Then
            Return Nothing
        End If
        Return DirectCast(dgv.CurrentRow.DataBoundItem, T)
    End Function
End Module
