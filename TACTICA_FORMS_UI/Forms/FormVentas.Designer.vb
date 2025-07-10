<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormVentas
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
        Me.btnAgregar = New TACTICA_FORMS_UI.CustomButton()
        Me.btnModificar = New TACTICA_FORMS_UI.CustomButton()
        Me.btnEliminar = New TACTICA_FORMS_UI.CustomButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.dtpHora = New System.Windows.Forms.DateTimePicker()
        Me.cmbCliente = New TACTICA_FORMS_UI.PlaceholderComboBox()
        Me.txtBuscar = New TACTICA_FORMS_UI.CustomTextBox()
        Me.txtCorreo = New TACTICA_FORMS_UI.CustomTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(11, 205)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(406, 36)
        Me.TableLayoutPanel1.TabIndex = 27
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(13, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 47)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Ventas"
        '
        'dgvVentas
        '
        Me.dgvVentas.AllowUserToAddRows = False
        Me.dgvVentas.AllowUserToDeleteRows = False
        Me.dgvVentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvVentas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.Location = New System.Drawing.Point(11, 247)
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.Size = New System.Drawing.Size(406, 215)
        Me.dgvVentas.TabIndex = 25
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = "dddd dd 'del' MM 'del' yyyy"
        Me.dtpFecha.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(14, 119)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(317, 35)
        Me.dtpFecha.TabIndex = 34
        '
        'dtpHora
        '
        Me.dtpHora.CustomFormat = "HH:mm"
        Me.dtpHora.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHora.Location = New System.Drawing.Point(337, 119)
        Me.dtpHora.Name = "dtpHora"
        Me.dtpHora.ShowUpDown = True
        Me.dtpHora.Size = New System.Drawing.Size(77, 35)
        Me.dtpHora.TabIndex = 35
        '
        'cmbCliente
        '
        Me.cmbCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.cmbCliente.DataSource = Nothing
        Me.cmbCliente.DisplayMember = ""
        Me.cmbCliente.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.cmbCliente.Location = New System.Drawing.Point(14, 72)
        Me.cmbCliente.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Placeholder = "Cliente"
        Me.cmbCliente.PlaceholderColor = System.Drawing.Color.Gray
        Me.cmbCliente.SelectedItem = "Cliente"
        Me.cmbCliente.Size = New System.Drawing.Size(400, 40)
        Me.cmbCliente.TabIndex = 33
        Me.cmbCliente.Text = "Cliente"
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscar.AutoSize = True
        Me.txtBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.txtBuscar.Location = New System.Drawing.Point(166, 17)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(0)
        Me.txtBuscar.Mask = ""
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.NumericOnly = False
        Me.txtBuscar.Padding = New System.Windows.Forms.Padding(5)
        Me.txtBuscar.Placeholder = "Buscar"
        Me.txtBuscar.PlaceholderColor = System.Drawing.Color.Gray
        Me.txtBuscar.Size = New System.Drawing.Size(248, 41)
        Me.txtBuscar.TabIndex = 31
        Me.txtBuscar.Text = "Buscar"
        '
        'txtCorreo
        '
        Me.txtCorreo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCorreo.AutoSize = True
        Me.txtCorreo.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCorreo.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.txtCorreo.Location = New System.Drawing.Point(14, 160)
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(0)
        Me.txtCorreo.Mask = ""
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.NumericOnly = True
        Me.txtCorreo.Padding = New System.Windows.Forms.Padding(5)
        Me.txtCorreo.Placeholder = "Precio"
        Me.txtCorreo.PlaceholderColor = System.Drawing.Color.Gray
        Me.txtCorreo.Size = New System.Drawing.Size(400, 41)
        Me.txtCorreo.TabIndex = 30
        Me.txtCorreo.Text = "Precio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 169)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 30)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Precio:"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblPrecio.ForeColor = System.Drawing.Color.White
        Me.lblPrecio.Location = New System.Drawing.Point(102, 169)
        Me.lblPrecio.Margin = New System.Windows.Forms.Padding(3)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(68, 30)
        Me.lblPrecio.TabIndex = 37
        Me.lblPrecio.Text = "xxxxx"
        '
        'FormVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(428, 472)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpHora)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.cmbCliente)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvVentas)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormVentas"
        Me.Text = "FormVentas"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBuscar As CustomTextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnAgregar As CustomButton
    Friend WithEvents btnModificar As CustomButton
    Friend WithEvents btnEliminar As CustomButton
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents cmbCliente As PlaceholderComboBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents dtpHora As DateTimePicker
    Friend WithEvents txtCorreo As CustomTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPrecio As Label
End Class
