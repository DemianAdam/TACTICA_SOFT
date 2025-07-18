﻿Public Module FormHelper
    Public Function GetSelected(Of T)(dgv As DataGridView) As T
        If dgv.CurrentRow Is Nothing Then
            Return Nothing
        End If
        Return DirectCast(dgv.CurrentRow.DataBoundItem, T)
    End Function

    Public Function GetSelected(Of T)(cmb As PlaceholderComboBox) As T
        If cmb.SelectedItem Is Nothing OrElse cmb.SelectedItem.ToString() = cmb.Placeholder Then
            Return Nothing
        End If
        Return DirectCast(cmb.SelectedItem, T)
    End Function
End Module
