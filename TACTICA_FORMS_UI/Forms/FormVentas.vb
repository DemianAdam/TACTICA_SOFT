Public Class FormVentas

    Public Sub New()
        InitializeComponent()
        Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent

    End Sub
    Private Sub FormVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFecha.Value = Date.Now
        dtpHora.Value = Date.Now
    End Sub
End Class