Imports System.ComponentModel
Imports TACTICA_BUSINESS_LOGIC

Public Class FormProducto
    Implements IGetInput(Of ProductoDTO)

    Private ReadOnly _productoService As IProductoService
    Private ReadOnly _listaProductos As BindingList(Of ProductoDTO)
    Private ReadOnly _listaCategorias As List(Of String)
    Private _selectedProducto As ProductoDTO

    Public Sub New(productoService As IProductoService)
        InitializeComponent()
        Me._productoService = productoService
        Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent
        _listaProductos = New BindingList(Of ProductoDTO)(_productoService.GetAll().ToList())
        _listaCategorias = New List(Of String)()
        _listaCategorias.Add(cmbCategoria.Placeholder)
        _listaCategorias.AddRange(_productoService.GetAllCategorias().ToList())
        dgvProductos.DataSource = _listaProductos
        cmbCategoria.Datasource = _listaCategorias
    End Sub

    Public Function GetObjectFromInputs(Optional id As Integer = -1) As ProductoDTO Implements IGetInput(Of ProductoDTO).GetObjectFromInputs
        Dim categoria As String = If(txtCategoria.Text = txtCategoria.Placeholder, Nothing, txtCategoria.Text)
        Dim nombre As String = If(txtNombre.Text = txtNombre.Placeholder, Nothing, txtNombre.Text)
        Dim precio As Decimal? = If(txtPrecio.Text = txtPrecio.Placeholder, Nothing, txtPrecio.Value)
        Dim producto As New ProductoDTO With {
            .Id = id,
            .Categoria = categoria,
            .Nombre = nombre,
            .Precio = precio
            }
        Return producto
    End Function

    Private Sub FormProducto_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        dgvProductos.Focus()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim producto As ProductoDTO = GetObjectFromInputs()
        Try
            _productoService.Add(producto)
            _listaProductos.Add(producto)
        Catch ex As Exception
            MessageBox.Show("Error al Agregar el Producto: " + ex.Message)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim producto As ProductoDTO = FormHelper.GetSelected(Of ProductoDTO)(dgvProductos)
        Dim updatedProducto As ProductoDTO = GetObjectFromInputs(producto.Id)
        Try
            _productoService.Update(updatedProducto)
            producto.Nombre = updatedProducto.Nombre
            producto.Precio = updatedProducto.Precio
            producto.Categoria = updatedProducto.Categoria
            dgvProductos.Refresh()
        Catch ex As Exception
            MessageBox.Show("Error al Modificar el Producto: " + ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim producto As ProductoDTO = FormHelper.GetSelected(Of ProductoDTO)(dgvProductos)
        Try
            _productoService.Delete(producto)
            _listaProductos.Remove(producto)
        Catch ex As Exception
            MessageBox.Show("Error al Eliminar el Producto: " + ex.Message)
        End Try
    End Sub

    Private Sub dgvProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellClick
        _selectedProducto = FormHelper.GetSelected(Of ProductoDTO)(dgvProductos)
        txtNombre.Text = _selectedProducto.Nombre
        txtPrecio.Value = _selectedProducto.Precio
        txtCategoria.Text = _selectedProducto.Categoria
    End Sub

    Private Sub txtBuscar_TextChangedPublic(sender As Object, e As EventArgs) Handles txtBuscar.TextChangedPublic
        Dim text As String = txtBuscar.Text

        If _listaProductos Is Nothing Then
            Return
        End If
        Dim filtered As List(Of ProductoDTO) = _listaProductos.ToList()
        If String.IsNullOrEmpty(text) OrElse text = txtBuscar.Placeholder Then
            dgvProductos.DataSource = _listaProductos
        Else
            filtered = filtered.Where(Function(x) x.Nombre Like $"*{text}*" OrElse x.Precio.ToString() Like $"*{text}*" OrElse x.Categoria Like $"*{text}*").ToList()
        End If
        If cmbCategoria.SelectedItem.ToString() <> cmbCategoria.Placeholder Then
            Dim categoria As String = cmbCategoria.SelectedItem.ToString()
            filtered = filtered.Where(Function(x) x.Categoria Like $"*{categoria}*").ToList()
        End If

        dgvProductos.DataSource = filtered


    End Sub

    Private Sub cmbCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategoria.SelectedIndexChanged
        If _listaProductos Is Nothing Then
            Return
        End If
        Dim text As String = txtBuscar.Text
        Dim filtered As List(Of ProductoDTO) = _listaProductos.ToList()
        If String.IsNullOrEmpty(text) OrElse text = txtBuscar.Placeholder Then
            dgvProductos.DataSource = _listaProductos
        Else
            filtered = filtered.Where(Function(x) x.Nombre Like $"*{text}*" OrElse x.Precio.ToString() Like $"*{text}*" OrElse x.Categoria Like $"*{text}*").ToList()
        End If
        If cmbCategoria.SelectedItem.ToString() <> cmbCategoria.Placeholder Then
            Dim categoria As String = cmbCategoria.SelectedItem.ToString()
            filtered = filtered.Where(Function(x) x.Categoria Like $"*{categoria}*").ToList()
        End If

        dgvProductos.DataSource = filtered
    End Sub
End Class