Option Strict On
Option Explicit On
Imports System.Runtime.InteropServices
Public Class Principal
    Inherits BaseForm



    Public Sub New(formFactory As FormFactory)
        MyBase.New(formFactory)
        InitializeComponent()
        Me.FormBorderStyle = FormBorderStyle.None

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
End Class