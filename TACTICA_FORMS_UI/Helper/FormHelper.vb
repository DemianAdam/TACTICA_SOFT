Public Module FormHelper
    Public Function GetSelected(Of T)(dgv As DataGridView) As T
        Return DirectCast(dgv.CurrentRow.DataBoundItem, T)
    End Function
End Module
