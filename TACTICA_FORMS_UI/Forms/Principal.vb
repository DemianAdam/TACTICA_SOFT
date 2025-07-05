Option Strict On
Option Explicit On
Imports System.Runtime.InteropServices
Public Class Principal
    Inherits BaseForm


    Public Sub New()
        InitializeComponent()
        Me.FormBorderStyle = FormBorderStyle.None

    End Sub


    Private Sub panelTop_MouseDown(sender As Object, e As MouseEventArgs) Handles panelTop.MouseDown
        MoveForm(e)
    End Sub

    Private Sub pbMaximizar_Click(sender As Object, e As EventArgs)
        Dim state As FormWindowState = Me.WindowState
        If state = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub pbMinimizar_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
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
End Class