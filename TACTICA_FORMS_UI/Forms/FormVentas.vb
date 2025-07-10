Imports System.ComponentModel
Imports TACTICA_BUSINESS_LOGIC

Public Class FormVentas
    Implements IDataForm(Of VentaDTO)
    Private ReadOnly _ventaService As IVentaService
    Private ReadOnly _clienteService As IClienteService
    Private ReadOnly _formFactory As FormFactory
    Private ReadOnly _listaVentas As BindingList(Of VentaDTO)
    Private ReadOnly _listaClientes As List(Of ClienteDTO)
    Private _selectedVenta As VentaDTO
    Public Sub New(ventaService As IVentaService, clienteService As IClienteService, formFactory As FormFactory)
        InitializeComponent()
        Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent
        _ventaService = ventaService
        _clienteService = clienteService
        Me._formFactory = formFactory
        _listaVentas = New BindingList(Of VentaDTO)(_ventaService.GetAll().ToList())
        _listaClientes = clienteService.GetAll().ToList()
        cmbCliente.DataSource = _listaClientes
        dgvVentas.DataSource = _listaVentas
    End Sub

    Public Sub SetInputs(obj As VentaDTO) Implements IDataForm(Of VentaDTO).SetInputs
        dtpFecha.Value = If(obj.Fecha, DateTime.Now)
        dtpHora.Value = If(obj.Fecha, DateTime.Now)
        lblPrecio.Text = $"${obj.Total}"
        If obj.Cliente Is Nothing Then
            cmbCliente.SelectedItem = Nothing
        Else
            cmbCliente.SelectedItem = _listaClientes.FirstOrDefault(Function(x) x.Id = obj.Cliente.Id)
        End If
    End Sub

    Public Sub ClearInputs() Implements IDataForm(Of VentaDTO).ClearInputs
        SetInputs(New VentaDTO())
    End Sub

    Private Sub FormVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFecha.Value = Date.Now
        dtpHora.Value = Date.Now
        lblPrecio.Text = "No hay venta seleccionada"
    End Sub

    Public Function GetObjectFromInputs(Optional id As Integer = -1) As VentaDTO Implements IDataForm(Of VentaDTO).GetObjectFromInputs
        Dim cliente As ClienteDTO = FormHelper.GetSelected(Of ClienteDTO)(cmbCliente)
        Dim fechaDtp As DateTime = dtpFecha.Value
        Dim tiempoDtp As DateTime = dtpHora.Value
        Dim fecha As DateTime = New DateTime(
            fechaDtp.Year,
            fechaDtp.Month,
            fechaDtp.Day,
            fechaDtp.Day,
            tiempoDtp.Hour,
            tiempoDtp.Minute
            )
        Return New VentaDTO() With {
            .Cliente = cliente,
            .Fecha = fecha,
            .Id = id
            }
    End Function

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim venta As VentaDTO = GetObjectFromInputs()

        If venta.Cliente Is Nothing Then
            MessageBox.Show("El campo Cliente es Obligatorio", "Venta invalida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim form As FormVentaItems = _formFactory.CreateForm(Of FormVentaItems)(venta)
        If form.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        If Not Me.IsValid(venta) Then
            Return
        End If

        Try
            _ventaService.Add(venta)
            _listaVentas.Add(venta)
            ClearInputs()
        Catch ex As Exception
            MessageBox.Show("Error al Agregar la Venta: " + ex.Message)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim updatedVenta As VentaDTO = GetObjectFromInputs(_selectedVenta.Id)
        Dim form As FormVentaItems = _formFactory.CreateForm(Of FormVentaItems)(_selectedVenta, True)
        updatedVenta.Items = _selectedVenta.Items
        If _selectedVenta.Cliente Is Nothing Then
            MessageBox.Show("El campo Cliente es Obligatorio", "Venta invalida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If form.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        If Not Me.IsValid(updatedVenta) Then
            Return
        End If

        Try
            _ventaService.Update(updatedVenta)
            ClearInputs()
        Catch ex As Exception
            MessageBox.Show("Error al Agregar la Venta: " + ex.Message)
        End Try
    End Sub

    Public Function IsValid(obj As VentaDTO) As Boolean Implements IDataForm(Of VentaDTO).IsValid
        Dim buttons As MessageBoxButtons = MessageBoxButtons.OK
        Dim icon As MessageBoxIcon = MessageBoxIcon.Error
        Dim titulo As String = "Venta Invalida"

        If obj.Cliente Is Nothing Then
            MessageBox.Show("El campo Cliente es Obligatorio", titulo, buttons, icon)
            Return False
        End If

        If obj.Total <= 0 Then
            MessageBox.Show("El Total debe ser mayor a 0", titulo, buttons, icon)
            Return False
        End If

        If obj.Items.Count <= 0 Then
            MessageBox.Show("La venta tiene que tener items asociados", titulo, buttons, icon)
            Return False
        End If

        Return True
    End Function

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim result As DialogResult = MessageBox.Show("Se eliminaran todos los items asociados, esta seguro?", "Eliminar Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            Try
                _ventaService.Delete(_selectedVenta)
            Catch ex As Exception
                MessageBox.Show("Error al Eliminar la Venta: " + ex.Message)
            End Try
        End If
    End Sub

    Private Sub dgvVentas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVentas.CellClick
        _selectedVenta = FormHelper.GetSelected(Of VentaDTO)(dgvVentas)
        SetInputs(_selectedVenta)
    End Sub
End Class