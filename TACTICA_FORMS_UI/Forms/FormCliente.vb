

Imports System.ComponentModel
Imports System.Drawing.Imaging
Imports TACTICA_BUSINESS_LOGIC
Imports TACTICA_DATA_ACCESS

Public Class FormCliente
    Implements IDataForm(Of ClienteDTO)
    Private ReadOnly _clienteService As IClienteService
    Private ReadOnly _listaClientes As BindingList(Of ClienteDTO)
    Private _selectedCliente As ClienteDTO
    Public Sub New(clienteService As IClienteService)
        InitializeComponent()
        Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent
        Me._clienteService = clienteService
        _listaClientes = New BindingList(Of ClienteDTO)(clienteService.GetAll().ToList())
        dgvClientes.DataSource = _listaClientes
    End Sub

    Private Sub FormCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim cliente As ClienteDTO = GetObjectFromInputs()
        Try
            _clienteService.Add(cliente)
            _listaClientes.Add(cliente)
            ClearInputs()
        Catch ex As Exception
            MessageBox.Show("Error al Agregar el Cliente: " + ex.Message)
        End Try

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim cliente As ClienteDTO = FormHelper.GetSelected(Of ClienteDTO)(dgvClientes)
        Dim updatedCliente As ClienteDTO = GetObjectFromInputs(cliente.Id)
        Try
            _clienteService.Update(updatedCliente)
            cliente.Cliente = updatedCliente.Cliente
            cliente.Telefono = updatedCliente.Telefono
            cliente.Correo = updatedCliente.Correo
            dgvClientes.Refresh()
            ClearInputs()
        Catch ex As Exception
            MessageBox.Show("Error al Modificar el Cliente: " + ex.Message)
        End Try

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim cliente As ClienteDTO = FormHelper.GetSelected(Of ClienteDTO)(dgvClientes)
        Try
            _clienteService.Delete(cliente)
            _listaClientes.Remove(cliente)
            ClearInputs()
        Catch ex As Exception
            MessageBox.Show("Error al Eliminar el Cliente: " + ex.Message)
        End Try
    End Sub

    Public Function GetObjectFromInputs(Optional id As Integer = -1) As ClienteDTO Implements IDataForm(Of ClienteDTO).GetObjectFromInputs
        Dim cliente As String = If(txtCliente.Text = txtCliente.Placeholder, Nothing, txtCliente.Text)
        Dim telefono As String = If(txtTelefono.Text = txtTelefono.Placeholder, Nothing, txtTelefono.Text)
        Dim correo As String = If(txtCorreo.Text = txtCorreo.Placeholder, Nothing, txtCorreo.Text)
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
        _selectedCliente = FormHelper.GetSelected(Of ClienteDTO)(dgvClientes)
        Me.SetInputs(_selectedCliente)
    End Sub

    Private Sub txtBuscar_TextChangedPublic(sender As Object, e As EventArgs) Handles txtBuscar.TextChangedPublic
        Dim text As String = txtBuscar.Text

        If _listaClientes Is Nothing Then
            Return
        End If

        If String.IsNullOrEmpty(text) OrElse text = txtBuscar.Placeholder Then
            dgvClientes.DataSource = _listaClientes
        Else
            Dim filtered As List(Of ClienteDTO) = _listaClientes.Where(Function(x) x.Correo Like $"*{text}*" OrElse x.Cliente Like $"*{text}*" OrElse x.Telefono Like $"*{text}*").ToList()
            dgvClientes.DataSource = filtered
        End If
    End Sub

    Public Sub SetInputs(obj As ClienteDTO) Implements IDataForm(Of ClienteDTO).SetInputs
        txtCliente.Text = obj.Cliente
        txtCorreo.Text = obj.Correo
        txtTelefono.Text = obj.Telefono
    End Sub

    Public Sub ClearInputs() Implements IDataForm(Of ClienteDTO).ClearInputs
        SetInputs(New ClienteDTO())
    End Sub
End Class