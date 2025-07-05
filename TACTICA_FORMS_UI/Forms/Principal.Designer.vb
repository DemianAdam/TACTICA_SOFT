<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
    Inherits BaseForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelBottom = New System.Windows.Forms.Panel()
        Me.panelContainer = New System.Windows.Forms.Panel()
        Me.pbLogoCentral = New System.Windows.Forms.PictureBox()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.pbIcono = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.panelMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelContainer.SuspendLayout()
        CType(Me.pbLogoCentral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTop.SuspendLayout()
        CType(Me.pbIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.panelMenu.Controls.Add(Me.btnClientes)
        Me.panelMenu.Controls.Add(Me.PictureBox1)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Location = New System.Drawing.Point(3, 38)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Padding = New System.Windows.Forms.Padding(10, 15, 10, 0)
        Me.panelMenu.Size = New System.Drawing.Size(179, 359)
        Me.panelMenu.TabIndex = 1
        '
        'btnClientes
        '
        Me.btnClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Nunito", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.Color.White
        Me.btnClientes.Location = New System.Drawing.Point(5, 76)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(164, 46)
        Me.btnClientes.TabIndex = 1
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.TACTICA_FORMS_UI.My.Resources.Resources.TACTICASOFT_nombre
        Me.PictureBox1.Location = New System.Drawing.Point(10, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(159, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'panelBottom
        '
        Me.panelBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelBottom.Location = New System.Drawing.Point(182, 360)
        Me.panelBottom.Name = "panelBottom"
        Me.panelBottom.Size = New System.Drawing.Size(515, 37)
        Me.panelBottom.TabIndex = 2
        '
        'panelContainer
        '
        Me.panelContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.panelContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.panelContainer.Controls.Add(Me.pbLogoCentral)
        Me.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContainer.Location = New System.Drawing.Point(182, 38)
        Me.panelContainer.Name = "panelContainer"
        Me.panelContainer.Size = New System.Drawing.Size(515, 322)
        Me.panelContainer.TabIndex = 3
        '
        'pbLogoCentral
        '
        Me.pbLogoCentral.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbLogoCentral.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pbLogoCentral.Enabled = False
        Me.pbLogoCentral.Image = Global.TACTICA_FORMS_UI.My.Resources.Resources.logocentral
        Me.pbLogoCentral.Location = New System.Drawing.Point(174, 67)
        Me.pbLogoCentral.Name = "pbLogoCentral"
        Me.pbLogoCentral.Size = New System.Drawing.Size(183, 182)
        Me.pbLogoCentral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLogoCentral.TabIndex = 0
        Me.pbLogoCentral.TabStop = False
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.panelTop.Controls.Add(Me.btnMinimizar)
        Me.panelTop.Controls.Add(Me.btnMaximizar)
        Me.panelTop.Controls.Add(Me.pbIcono)
        Me.panelTop.Controls.Add(Me.btnCerrar)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(3, 3)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.panelTop.Size = New System.Drawing.Size(694, 35)
        Me.panelTop.TabIndex = 4
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
        Me.btnMinimizar.Location = New System.Drawing.Point(604, 0)
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
        Me.btnMaximizar.Location = New System.Drawing.Point(634, 0)
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
        Me.btnCerrar.Location = New System.Drawing.Point(664, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(30, 35)
        Me.btnCerrar.TabIndex = 6
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(700, 400)
        Me.Controls.Add(Me.panelContainer)
        Me.Controls.Add(Me.panelBottom)
        Me.Controls.Add(Me.panelMenu)
        Me.Controls.Add(Me.panelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(700, 400)
        Me.Name = "Principal"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Text = "Tactica"
        Me.panelMenu.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelContainer.ResumeLayout(False)
        CType(Me.pbLogoCentral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelTop.ResumeLayout(False)
        CType(Me.pbIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelMenu As Panel
    Friend WithEvents pbLogoCentral As PictureBox
    Friend WithEvents panelBottom As Panel
    Friend WithEvents panelContainer As Panel
    Friend WithEvents panelTop As Panel
    Friend WithEvents pbIcono As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnClientes As Button
End Class
