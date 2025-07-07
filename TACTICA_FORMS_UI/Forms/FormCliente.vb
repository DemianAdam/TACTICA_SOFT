

Imports System.ComponentModel
Imports System.Drawing.Imaging
Imports TACTICA_BUSINESS_LOGIC
Imports TACTICA_DATA_ACCESS

Public Class FormCliente
    Implements IGetInput(Of ClienteDTO)
    Private ReadOnly clienteService As IClienteService
    Private ReadOnly listaClientes As BindingList(Of ClienteDTO)
    Private selectedCliente As ClienteDTO
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
        Dim cliente As ClienteDTO = GetObjectFromInputs()

        Try
            clienteService.Add(cliente)
            listaClientes.Add(cliente)
        Catch ex As Exception
            MessageBox.Show("Error al Agregar el Cliente: " + ex.Message)
        End Try

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim cliente As ClienteDTO = FormHelper.GetSelected(Of ClienteDTO)(dgvClientes)
        txtCliente.Text = cliente.Cliente
        txtCorreo.Text = cliente.Correo
        txtTelefono.Text = cliente.Telefono
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

    End Sub

    Private Sub txtTelefono_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Public Function GetObjectFromInputs(Optional id As Integer = -1) As ClienteDTO Implements IGetInput(Of ClienteDTO).GetObjectFromInputs
        Dim cliente As String = DirectCast(IIf(txtCliente.Text = txtCliente.Placeholder, String.Empty, txtCliente.Text), String)
        Dim telefono As String = DirectCast(IIf(txtTelefono.Text = txtTelefono.Placeholder, String.Empty, txtTelefono.Text), String)
        Dim correo As String = DirectCast(IIf(txtCorreo.Text = txtCorreo.Placeholder, String.Empty, txtCorreo.Text), String)
        Dim clienteObj As New ClienteDTO With {
            .Id = id,
            .Cliente = cliente,
            .Telefono = telefono,
            .Correo = correo
        }
        Return clienteObj
    End Function

    Private Sub FormCliente_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        dgvClientes.Focus()
    End Sub

    Private Sub dgvClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellClick
        selectedCliente = FormHelper.GetSelected(Of ClienteDTO)(dgvClientes)
        txtCliente.Text = selectedCliente.Cliente
        txtCorreo.Text = selectedCliente.Correo
        txtTelefono.Text = selectedCliente.Telefono
    End Sub
End Class