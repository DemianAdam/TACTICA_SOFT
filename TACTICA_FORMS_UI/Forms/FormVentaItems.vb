Imports System.ComponentModel
Imports TACTICA_BUSINESS_LOGIC

Public Class FormVentaItems
    Inherits BaseForm
    Implements IDataForm(Of VentaItemsDTO)
    Private ReadOnly _productoService As IProductoService
    Private ReadOnly _itemService As IItemService
    Private ReadOnly _listaProductos As List(Of ProductoDTO)
    Private ReadOnly _listaItems As BindingList(Of VentaItemsDTO)
    Private ReadOnly _venta As VentaDTO
    Private _selectedItem As VentaItemsDTO
    Public Sub New(productoService As IProductoService, itemService As IItemService, venta As VentaDTO, Optional editable As Boolean = False)
        InitializeComponent()
        _productoService = productoService
        _itemService = itemService
        _listaProductos = New List(Of ProductoDTO)(productoService.GetAll())
        cmbProductos.DataSource = _listaProductos
        cmbProductos.DisplayMember = "Nombre"
        _venta = venta
        If editable AndAlso venta.Items Is Nothing Then
            venta.Items = _itemService.GetAllByVenta(venta).ToList()
        End If
        _listaItems = New BindingList(Of VentaItemsDTO)(If(venta.Items, New List(Of VentaItemsDTO)()))
        dgvVentaItems.DataSource = _listaItems
        txtPrecioUnitario.Enabled = editable
        txtPrecioTotal.Enabled = editable
    End Sub

    Public Sub SetInputs(obj As VentaItemsDTO) Implements IDataForm(Of VentaItemsDTO).SetInputs

        If obj.Producto Is Nothing Then
            cmbProductos.SelectedItem = Nothing
        Else
            cmbProductos.SelectedItem = _listaProductos.Find(Function(x) x.Id = obj.Producto.Id)
        End If
        txtCantidad.Text = obj.Cantidad.ToString()
        txtPrecioUnitario.Text = obj.PrecioUnitario.ToString()
        txtPrecioTotal.Text = obj.PrecioTotal.ToString()
    End Sub

    Public Sub ClearInputs() Implements IDataForm(Of VentaItemsDTO).ClearInputs
        SetInputs(New VentaItemsDTO())
        lblTotal.Text = "$" + _listaItems.Sum(Function(x) x.PrecioTotal).ToString()
    End Sub

    Private Sub cmbProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductos.SelectedIndexChanged
        CalcularPrecios()
    End Sub

    Private Sub txtCantidad_TextChangedPublic(sender As Object, e As EventArgs) Handles txtCantidad.TextChangedPublic
        CalcularPrecios()
    End Sub

    Private Sub CalcularPrecios()
        Dim producto As ProductoDTO = FormHelper.GetSelected(Of ProductoDTO)(cmbProductos)
        Dim cantidad As Decimal = txtCantidad.Value
        If producto Is Nothing OrElse cantidad = 0 Then
            Return
        End If
        txtPrecioUnitario.Text = producto.Precio.ToString()
        txtPrecioTotal.Text = (producto.Precio * cantidad).ToString()
    End Sub

    Public Function GetObjectFromInputs(Optional id As Integer = -1) As VentaItemsDTO Implements IDataForm(Of VentaItemsDTO).GetObjectFromInputs
        Dim cantidad As Decimal = txtCantidad.Value
        Dim producto As ProductoDTO = FormHelper.GetSelected(Of ProductoDTO)(cmbProductos)
        Return New VentaItemsDTO With {
        .Id = id,
        .Cantidad = cantidad,
        .Producto = producto,
        .Venta = _venta,
        .PrecioTotal = txtPrecioTotal.Value,
        .PrecioUnitario = txtPrecioUnitario.Value
        }
    End Function

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim item As VentaItemsDTO = GetObjectFromInputs()
        If Not Me.IsValid(item) Then
            Return
        End If
        item.Id = _listaItems.Count + 1
        _listaItems.Add(item)
        ClearInputs()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim item As VentaItemsDTO = FormHelper.GetSelected(Of VentaItemsDTO)(dgvVentaItems)
        Dim updatedItem As VentaItemsDTO = GetObjectFromInputs(item.Id)

        If Not Me.IsValid(updatedItem) Then
            Return
        End If

        item.PrecioUnitario = updatedItem.PrecioUnitario
        item.PrecioTotal = updatedItem.PrecioTotal
        item.Cantidad = updatedItem.Cantidad
        item.Producto = updatedItem.Producto
        dgvVentaItems.Refresh()
        ClearInputs()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim item As VentaItemsDTO = FormHelper.GetSelected(Of VentaItemsDTO)(dgvVentaItems)
        _listaItems.Remove(item)
        ClearInputs()
    End Sub

    Private Sub dgvVentaItems_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVentaItems.CellClick
        _selectedItem = FormHelper.GetSelected(Of VentaItemsDTO)(dgvVentaItems)
        SetInputs(_selectedItem)
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        _venta.Items = _listaItems.ToList()
        _venta.Total = _listaItems.Sum(Function(x) x.PrecioTotal)
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
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

    End Sub

    Public Function IsValid(obj As VentaItemsDTO) As Boolean Implements IDataForm(Of VentaItemsDTO).IsValid
        Dim buttons As MessageBoxButtons = MessageBoxButtons.OK
        Dim icon As MessageBoxIcon = MessageBoxIcon.Error
        Dim titulo As String = "Item Invalido"

        If obj.Cantidad <= 0 Then
            MessageBox.Show("La cantidad debe ser mayor a 0", titulo, buttons, icon)
            Return False
        End If

        If obj.PrecioUnitario <= 0 OrElse obj.PrecioTotal <= 0 Then
            MessageBox.Show("El precio debe ser mayor a 0", titulo, buttons, icon)
            Return False
        End If

        If obj.Producto Is Nothing Then
            MessageBox.Show("El Producto es obligatorio", titulo, buttons, icon)
            Return False
        End If

        Return True
    End Function
End Class