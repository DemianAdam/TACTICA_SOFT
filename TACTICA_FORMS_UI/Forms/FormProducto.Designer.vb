<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormProducto
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.cmbCategoria = New TACTICA_FORMS_UI.PlaceholderComboBox()
        Me.txtBuscar = New TACTICA_FORMS_UI.CustomTextBox()
        Me.txtCategoria = New TACTICA_FORMS_UI.CustomTextBox()
        Me.txtPrecio = New TACTICA_FORMS_UI.CustomTextBox()
        Me.txtNombre = New TACTICA_FORMS_UI.CustomTextBox()
        Me.btnAgregar = New TACTICA_FORMS_UI.CustomButton()
        Me.btnModificar = New TACTICA_FORMS_UI.CustomButton()
        Me.btnEliminar = New TACTICA_FORMS_UI.CustomButton()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 203)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(406, 36)
        Me.TableLayoutPanel1.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 47)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Productos"
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.AllowUserToDeleteRows = False
        Me.dgvProductos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Location = New System.Drawing.Point(10, 245)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(406, 215)
        Me.dgvProductos.TabIndex = 25
        '
        'cmbCategoria
        '
        Me.cmbCategoria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.cmbCategoria.DataSource = Nothing
        Me.cmbCategoria.DisplayMember = ""
        Me.cmbCategoria.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.cmbCategoria.ForeColor = System.Drawing.Color.White
        Me.cmbCategoria.Location = New System.Drawing.Point(291, 16)
        Me.cmbCategoria.Margin = New System.Windows.Forms.Padding(0)
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.Placeholder = "Categoria"
        Me.cmbCategoria.PlaceholderColor = System.Drawing.Color.Gray
        Me.cmbCategoria.SelectedItem = "Categoria"
        Me.cmbCategoria.Size = New System.Drawing.Size(122, 40)
        Me.cmbCategoria.TabIndex = 32
        Me.cmbCategoria.Text = "Categoria"
        '
        'txtBuscar
        '
        Me.txtBuscar.AutoSize = True
        Me.txtBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.txtBuscar.ForeColor = System.Drawing.Color.White
        Me.txtBuscar.Location = New System.Drawing.Point(193, 15)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(0)
        Me.txtBuscar.Mask = ""
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.NumericOnly = False
        Me.txtBuscar.Padding = New System.Windows.Forms.Padding(5)
        Me.txtBuscar.Placeholder = "Buscar"
        Me.txtBuscar.PlaceholderColor = System.Drawing.Color.Gray
        Me.txtBuscar.Size = New System.Drawing.Size(91, 41)
        Me.txtBuscar.TabIndex = 31
        Me.txtBuscar.Text = "Buscar"
        '
        'txtCategoria
        '
        Me.txtCategoria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCategoria.AutoSize = True
        Me.txtCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCategoria.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.txtCategoria.ForeColor = System.Drawing.Color.White
        Me.txtCategoria.Location = New System.Drawing.Point(13, 158)
        Me.txtCategoria.Margin = New System.Windows.Forms.Padding(0)
        Me.txtCategoria.Mask = ""
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.NumericOnly = False
        Me.txtCategoria.Padding = New System.Windows.Forms.Padding(5)
        Me.txtCategoria.Placeholder = "Categoria"
        Me.txtCategoria.PlaceholderColor = System.Drawing.Color.Gray
        Me.txtCategoria.Size = New System.Drawing.Size(400, 41)
        Me.txtCategoria.TabIndex = 30
        Me.txtCategoria.Text = "Categoria"
        '
        'txtPrecio
        '
        Me.txtPrecio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPrecio.AutoSize = True
        Me.txtPrecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrecio.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.txtPrecio.ForeColor = System.Drawing.Color.White
        Me.txtPrecio.Location = New System.Drawing.Point(13, 113)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(0)
        Me.txtPrecio.Mask = ""
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.NumericOnly = True
        Me.txtPrecio.Padding = New System.Windows.Forms.Padding(5)
        Me.txtPrecio.Placeholder = "Precio"
        Me.txtPrecio.PlaceholderColor = System.Drawing.Color.Gray
        Me.txtPrecio.Size = New System.Drawing.Size(400, 41)
        Me.txtPrecio.TabIndex = 29
        Me.txtPrecio.Text = "Precio"
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.AutoSize = True
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.txtNombre.ForeColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(13, 68)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(0)
        Me.txtNombre.Mask = ""
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.NumericOnly = False
        Me.txtNombre.Padding = New System.Windows.Forms.Padding(5)
        Me.txtNombre.Placeholder = "Nombre"
        Me.txtNombre.PlaceholderColor = System.Drawing.Color.Gray
        Me.txtNombre.Size = New System.Drawing.Size(400, 41)
        Me.txtNombre.TabIndex = 28
        Me.txtNombre.Text = "Nombre"
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
        'FormProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(428, 472)
        Me.Controls.Add(Me.cmbCategoria)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.txtCategoria)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvProductos)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormProducto"
        Me.Text = "FormProducto"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBuscar As CustomTextBox
    Friend WithEvents txtCategoria As CustomTextBox
    Friend WithEvents txtPrecio As CustomTextBox
    Friend WithEvents txtNombre As CustomTextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnAgregar As CustomButton
    Friend WithEvents btnModificar As CustomButton
    Friend WithEvents btnEliminar As CustomButton
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents cmbCategoria As PlaceholderComboBox
End Class
