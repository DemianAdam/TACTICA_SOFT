Option Strict On
Option Explicit On

Imports System.ComponentModel
Imports System.Drawing.Imaging
Imports TACTICA_BUSINESS_LOGIC

Public Class FormCliente
    Private ReadOnly clienteService As IClienteService
    Private ReadOnly listaClientes As BindingList(Of ClienteDTO)
    Public Sub New(clienteService As IClienteService)
        InitializeComponent()
        Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent
        Me.clienteService = clienteService
        listaClientes = New BindingList(Of ClienteDTO)(clienteService.GetAll().ToList())
        dgvClientes.DataSource = listaClientes
    End Sub

    Private Sub FormCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim cliente As New ClienteDTO With {
            .Cliente = txtCliente.Text,
            .Correo = txtCorreo.Text,
            .Telefono = txtTelefono.Text
            }
        Try
            clienteService.Add(cliente)
            listaClientes.Add(cliente)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

    End Sub


End Class