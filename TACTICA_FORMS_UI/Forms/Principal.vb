
Imports System.Runtime.InteropServices
Public Class Principal
    Inherits BaseForm

    Private lastClickedButton As Button
    Private displayedForm As Form
    Private ReadOnly _formFactory As FormFactory
    Public Sub New(formFactory As FormFactory)
        InitializeComponent()
        Me.FormBorderStyle = FormBorderStyle.None
        _formFactory = formFactory
    End Sub

    Private Sub panelTop_MouseDown(sender As Object, e As MouseEventArgs) Handles panelTop.MouseDown
        MoveForm(e)
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        Dim state As FormWindowState = Me.WindowState
        If state = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        OpenForm(Of FormCliente)(panelContainer)
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        OpenForm(Of FormProducto)(panelContainer)
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        OpenForm(Of FormVentas)(panelContainer)
    End Sub
    Private Sub BaseClick(sender As Object, e As EventArgs) Handles btnClientes.Click, btnProductos.Click, btnVentas.MouseClick
        Dim button As Button = DirectCast(sender, Button)
        If lastClickedButton IsNot Nothing AndAlso button IsNot lastClickedButton Then
            lastClickedButton.FlatAppearance.BorderSize = 0
        End If
        lastClickedButton = button
    End Sub

    Private Sub Btn_MouseEnter(sender As Object, e As EventArgs) Handles btnClientes.MouseEnter, btnProductos.MouseEnter, btnVentas.MouseEnter
        Dim button As Button = DirectCast(sender, Button)
        button.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub Btn_MouseLeave(sender As Object, e As EventArgs) Handles btnClientes.MouseLeave, btnProductos.MouseLeave, btnVentas.MouseLeave
        Dim button As Button = DirectCast(sender, Button)
        If lastClickedButton IsNot button Then
            button.FlatAppearance.BorderSize = 0
        End If
    End Sub

    Protected Sub OpenForm(Of T As Form)(panel As Panel)
        If TypeOf displayedForm IsNot T Then
            displayedForm?.Close()
            Dim form As Form = _formFactory.CreateForm(Of T)()
            displayedForm = form
            form.TopLevel = False
            form.FormBorderStyle = FormBorderStyle.None
            form.BackgroundImage = ChangeOpacity(My.Resources.tacticalsoft_logo_, 0.01)
            form.BackgroundImageLayout = ImageLayout.Zoom
            form.Dock = DockStyle.Fill
            panel.Controls.Add(form)
            form.BringToFront()
            form.Show()
        End If
    End Sub


End Class