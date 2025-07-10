<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVentaItems
    Inherits BaseForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvVentaItems = New System.Windows.Forms.DataGridView()
        Me.cmbProductos = New TACTICA_FORMS_UI.PlaceholderComboBox()
        Me.txtCantidad = New TACTICA_FORMS_UI.CustomTextBox()
        Me.txtPrecioUnitario = New TACTICA_FORMS_UI.CustomTextBox()
        Me.txtPrecioTotal = New TACTICA_FORMS_UI.CustomTextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAgregar = New TACTICA_FORMS_UI.CustomButton()
        Me.btnModificar = New TACTICA_FORMS_UI.CustomButton()
        Me.btnEliminar = New TACTICA_FORMS_UI.CustomButton()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAceptar = New TACTICA_FORMS_UI.CustomButton()
        Me.btnCancelar = New TACTICA_FORMS_UI.CustomButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.pbIcono = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        CType(Me.dgvVentaItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.panelTop.SuspendLayout()
        CType(Me.pbIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(5, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 47)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Items"
        '
        'dgvVentaItems
        '
        Me.dgvVentaItems.AllowUserToAddRows = False
        Me.dgvVentaItems.AllowUserToDeleteRows = False
        Me.dgvVentaItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvVentaItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvVentaItems.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.dgvVentaItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentaItems.Location = New System.Drawing.Point(10, 283)
        Me.dgvVentaItems.Name = "dgvVentaItems"
        Me.dgvVentaItems.Size = New System.Drawing.Size(406, 141)
        Me.dgvVentaItems.TabIndex = 28
        '
        'cmbProductos
        '
        Me.cmbProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.cmbProductos.DataSource = Nothing
        Me.cmbProductos.DisplayMember = ""
        Me.cmbProductos.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.cmbProductos.Location = New System.Drawing.Point(10, 97)
        Me.cmbProductos.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.cmbProductos.Name = "cmbProductos"
        Me.cmbProductos.Placeholder = "Productos"
        Me.cmbProductos.PlaceholderColor = System.Drawing.Color.Gray
        Me.cmbProductos.SelectedItem = "Productos"
        Me.cmbProductos.Size = New System.Drawing.Size(406, 40)
        Me.cmbProductos.TabIndex = 34
        Me.cmbProductos.Text = "Productos"
        '
        'txtCantidad
        '
        Me.txtCantidad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCantidad.AutoSize = True
        Me.txtCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidad.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.txtCantidad.ForeColor = System.Drawing.Color.White
        Me.txtCantidad.Location = New System.Drawing.Point(10, 147)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.txtCantidad.Mask = ""
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.NumericOnly = True
        Me.txtCantidad.Padding = New System.Windows.Forms.Padding(5)
        Me.txtCantidad.Placeholder = "Cantidad"
        Me.txtCantidad.PlaceholderColor = System.Drawing.Color.Gray
        Me.txtCantidad.Size = New System.Drawing.Size(406, 41)
        Me.txtCantidad.TabIndex = 35
        Me.txtCantidad.Text = "Cantidad"
        '
        'txtPrecioUnitario
        '
        Me.txtPrecioUnitario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPrecioUnitario.AutoSize = True
        Me.txtPrecioUnitario.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtPrecioUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrecioUnitario.Enabled = False
        Me.txtPrecioUnitario.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.txtPrecioUnitario.ForeColor = System.Drawing.Color.White
        Me.txtPrecioUnitario.Location = New System.Drawing.Point(10, 194)
        Me.txtPrecioUnitario.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.txtPrecioUnitario.Mask = ""
        Me.txtPrecioUnitario.Name = "txtPrecioUnitario"
        Me.txtPrecioUnitario.NumericOnly = True
        Me.txtPrecioUnitario.Padding = New System.Windows.Forms.Padding(5)
        Me.txtPrecioUnitario.Placeholder = "Precio Unitario"
        Me.txtPrecioUnitario.PlaceholderColor = System.Drawing.Color.Gray
        Me.txtPrecioUnitario.Size = New System.Drawing.Size(197, 41)
        Me.txtPrecioUnitario.TabIndex = 36
        Me.txtPrecioUnitario.Text = "Precio Unitario"
        '
        'txtPrecioTotal
        '
        Me.txtPrecioTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPrecioTotal.AutoSize = True
        Me.txtPrecioTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtPrecioTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrecioTotal.Enabled = False
        Me.txtPrecioTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.txtPrecioTotal.ForeColor = System.Drawing.Color.White
        Me.txtPrecioTotal.Location = New System.Drawing.Point(219, 194)
        Me.txtPrecioTotal.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.txtPrecioTotal.Mask = ""
        Me.txtPrecioTotal.Name = "txtPrecioTotal"
        Me.txtPrecioTotal.NumericOnly = True
        Me.txtPrecioTotal.Padding = New System.Windows.Forms.Padding(5)
        Me.txtPrecioTotal.Placeholder = "Precio Total"
        Me.txtPrecioTotal.PlaceholderColor = System.Drawing.Color.Gray
        Me.txtPrecioTotal.Size = New System.Drawing.Size(197, 41)
        Me.txtPrecioTotal.TabIndex = 37
        Me.txtPrecioTotal.Text = "Precio Total"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnAgregar, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnModificar, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnEliminar, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 241)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(406, 36)
        Me.TableLayoutPanel1.TabIndex = 38
        '
        'btnAgregar
        '
        Me.btnAgregar.AutoSize = True
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.btnAgregar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(3, 3)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(129, 30)
        Me.btnAgregar.TabIndex = 8
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.AutoSize = True
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.btnModificar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(138, 3)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(129, 30)
        Me.btnModificar.TabIndex = 9
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.AutoSize = True
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.btnEliminar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(273, 3)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(130, 30)
        Me.btnEliminar.TabIndex = 10
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnAceptar, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnCancelar, 2, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(10, 430)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(406, 36)
        Me.TableLayoutPanel2.TabIndex = 39
        '
        'btnAceptar
        '
        Me.btnAceptar.AutoSize = True
        Me.btnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAceptar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.Location = New System.Drawing.Point(138, 3)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(129, 30)
        Me.btnAceptar.TabIndex = 9
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.AutoSize = True
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(273, 3)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(130, 30)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(166, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 47)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Total:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTotal.Location = New System.Drawing.Point(275, 38)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(115, 47)
        Me.lblTotal.TabIndex = 41
        Me.lblTotal.Text = "xxxxx"
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.panelTop.Controls.Add(Me.Label3)
        Me.panelTop.Controls.Add(Me.btnMinimizar)
        Me.panelTop.Controls.Add(Me.btnMaximizar)
        Me.panelTop.Controls.Add(Me.pbIcono)
        Me.panelTop.Controls.Add(Me.btnCerrar)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.panelTop.Size = New System.Drawing.Size(428, 35)
        Me.panelTop.TabIndex = 42
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(23, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 35)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Tactica Software"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMinimizar
        '
        Me.btnMinimizar.BackgroundImage = Global.TACTICA_FORMS_UI.My.Resources.Resources.minimize_icon
        Me.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.btnMinimizar.Location = New System.Drawing.Point(338, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(30, 35)
        Me.btnMinimizar.TabIndex = 4
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnMaximizar
        '
        Me.btnMaximizar.BackgroundImage = Global.TACTICA_FORMS_UI.My.Resources.Resources.maximize_icon
        Me.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMaximizar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMaximizar.FlatAppearance.BorderSize = 0
        Me.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximizar.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.btnMaximizar.Location = New System.Drawing.Point(368, 0)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(30, 35)
        Me.btnMaximizar.TabIndex = 5
        Me.btnMaximizar.UseVisualStyleBackColor = True
        '
        'pbIcono
        '
        Me.pbIcono.Dock = System.Windows.Forms.DockStyle.Left
        Me.pbIcono.Image = Global.TACTICA_FORMS_UI.My.Resources.Resources.tacticalsoft_logo_
        Me.pbIcono.Location = New System.Drawing.Point(5, 0)
        Me.pbIcono.Name = "pbIcono"
        Me.pbIcono.Size = New System.Drawing.Size(18, 35)
        Me.pbIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbIcono.TabIndex = 3
        Me.pbIcono.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackgroundImage = Global.TACTICA_FORMS_UI.My.Resources.Resources.close_icon
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.btnCerrar.Location = New System.Drawing.Point(398, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(30, 35)
        Me.btnCerrar.TabIndex = 6
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'FormVentaItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(428, 472)
        Me.Controls.Add(Me.panelTop)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.txtPrecioTotal)
        Me.Controls.Add(Me.txtPrecioUnitario)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.cmbProductos)
        Me.Controls.Add(Me.dgvVentaItems)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormVentaItems"
        Me.Text = "FormVentaItems"
        CType(Me.dgvVentaItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.panelTop.ResumeLayout(False)
        CType(Me.pbIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvVentaItems As DataGridView
    Friend WithEvents cmbProductos As PlaceholderComboBox
    Friend WithEvents txtCantidad As CustomTextBox
    Friend WithEvents txtPrecioUnitario As CustomTextBox
    Friend WithEvents txtPrecioTotal As CustomTextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnAgregar As CustomButton
    Friend WithEvents btnModificar As CustomButton
    Friend WithEvents btnEliminar As CustomButton
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnAceptar As CustomButton
    Friend WithEvents btnCancelar As CustomButton
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents panelTop As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents pbIcono As PictureBox
    Friend WithEvents btnCerrar As Button
End Class
