Public Class CustomButton
    Inherits Button

    Public Sub New()
        Me.FlatStyle = FlatStyle.Flat
        Me.FlatAppearance.BorderColor = Color.Firebrick
        Me.FlatAppearance.BorderSize = 0
        Me.FlatAppearance.MouseDownBackColor = Color.FromArgb(18, 18, 22)
        Me.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 37, 45)
        Me.Font = New Font("Segoe UI Semibold", 12.0!, FontStyle.Bold)
        Me.UseVisualStyleBackColor = False
        Me.ForeColor = Color.White
        Me.BackColor = Color.FromArgb(28, 28, 34)
    End Sub

    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        Me.FlatAppearance.BorderSize = 1
    End Sub


    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        Me.FlatAppearance.BorderSize = 0
    End Sub
End Class
