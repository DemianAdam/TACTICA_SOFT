

Imports System.Drawing.Imaging
Imports TACTICA_BUSINESS_LOGIC

Public Class FormCliente
    Private ReadOnly clienteService As IClienteService

    Public Sub New(clienteService As IClienteService)
        InitializeComponent()
        Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent
        Me.clienteService = clienteService

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim cliente As New ClienteDTO With {
            .Cliente = txtCliente.Text,
            .Correo = txtCorreo.Text,
            .Telefono = txtTelefono.Text
            }
        clienteService.Add(cliente)
    End Sub
End Class