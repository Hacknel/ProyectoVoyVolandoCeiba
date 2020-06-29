<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.panelVentanas = New System.Windows.Forms.Panel()
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ventanaInicio = New System.Windows.Forms.ToolStripMenuItem()
        Me.ventanaAdministracion = New System.Windows.Forms.ToolStripMenuItem()
        Me.ventanaClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ventanaPersonal = New System.Windows.Forms.ToolStripMenuItem()
        Me.panelIOpciones = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelForms = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.panelVentanas.SuspendLayout()
        Me.panelMenu.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.panelIOpciones.SuspendLayout()
        Me.panelForms.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelVentanas
        '
        Me.panelVentanas.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.panelVentanas.Controls.Add(Me.panelMenu)
        Me.panelVentanas.Controls.Add(Me.btnRestaurar)
        Me.panelVentanas.Controls.Add(Me.btnMaximizar)
        Me.panelVentanas.Controls.Add(Me.btnMinimizar)
        Me.panelVentanas.Controls.Add(Me.btnCerrar)
        Me.panelVentanas.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelVentanas.Location = New System.Drawing.Point(0, 0)
        Me.panelVentanas.Name = "panelVentanas"
        Me.panelVentanas.Size = New System.Drawing.Size(1144, 51)
        Me.panelVentanas.TabIndex = 0
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.panelMenu.Controls.Add(Me.MenuStrip1)
        Me.panelMenu.Location = New System.Drawing.Point(0, 0)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(611, 51)
        Me.panelMenu.TabIndex = 6
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(51, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ventanaInicio, Me.ventanaAdministracion, Me.ventanaClientes, Me.ventanaPersonal})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(611, 51)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ventanaInicio
        '
        Me.ventanaInicio.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ventanaInicio.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ventanaInicio.ForeColor = System.Drawing.Color.White
        Me.ventanaInicio.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.ventanaInicio.Name = "ventanaInicio"
        Me.ventanaInicio.Size = New System.Drawing.Size(65, 47)
        Me.ventanaInicio.Text = "Inicio"
        '
        'ventanaAdministracion
        '
        Me.ventanaAdministracion.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ventanaAdministracion.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ventanaAdministracion.ForeColor = System.Drawing.Color.White
        Me.ventanaAdministracion.Name = "ventanaAdministracion"
        Me.ventanaAdministracion.Size = New System.Drawing.Size(133, 47)
        Me.ventanaAdministracion.Text = "Administración"
        '
        'ventanaClientes
        '
        Me.ventanaClientes.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ventanaClientes.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ventanaClientes.ForeColor = System.Drawing.Color.White
        Me.ventanaClientes.Name = "ventanaClientes"
        Me.ventanaClientes.Size = New System.Drawing.Size(83, 47)
        Me.ventanaClientes.Text = "Clientes"
        '
        'ventanaPersonal
        '
        Me.ventanaPersonal.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ventanaPersonal.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ventanaPersonal.ForeColor = System.Drawing.Color.White
        Me.ventanaPersonal.Name = "ventanaPersonal"
        Me.ventanaPersonal.Size = New System.Drawing.Size(88, 47)
        Me.ventanaPersonal.Text = "Personal"
        '
        'panelIOpciones
        '
        Me.panelIOpciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.panelIOpciones.Controls.Add(Me.Button2)
        Me.panelIOpciones.Controls.Add(Me.Button1)
        Me.panelIOpciones.Controls.Add(Me.PictureBox1)
        Me.panelIOpciones.Controls.Add(Me.Label1)
        Me.panelIOpciones.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelIOpciones.Location = New System.Drawing.Point(0, 51)
        Me.panelIOpciones.Name = "panelIOpciones"
        Me.panelIOpciones.Size = New System.Drawing.Size(247, 740)
        Me.panelIOpciones.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(0, 272)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(249, 59)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Estado del mandado"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(0, 185)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(249, 59)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Mandado"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(79, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 58)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Voy volando " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     Ceiba"
        '
        'panelForms
        '
        Me.panelForms.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.panelForms.Controls.Add(Me.Label3)
        Me.panelForms.Controls.Add(Me.Label2)
        Me.panelForms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelForms.Location = New System.Drawing.Point(247, 51)
        Me.panelForms.Name = "panelForms"
        Me.panelForms.Size = New System.Drawing.Size(897, 740)
        Me.panelForms.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sigmar One", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(40, 314)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(773, 297)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Al servicio delivery" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       más veloz de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "           la Ceiba"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sigmar One", 42.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(156, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(577, 116)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "¡Bienvenido!"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 79)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.BackgroundImage = Global.ProyectoPEDVVoyVolandoCeiba.My.Resources.Resources.Restore_Window_2_48px
        Me.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurar.FlatAppearance.BorderSize = 0
        Me.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.Location = New System.Drawing.Point(1049, 10)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(35, 35)
        Me.btnRestaurar.TabIndex = 5
        Me.btnRestaurar.UseVisualStyleBackColor = True
        Me.btnRestaurar.Visible = False
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.BackgroundImage = Global.ProyectoPEDVVoyVolandoCeiba.My.Resources.Resources.Maximize_Window_2_48px
        Me.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximizar.FlatAppearance.BorderSize = 0
        Me.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximizar.Location = New System.Drawing.Point(1049, 10)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(35, 35)
        Me.btnMaximizar.TabIndex = 4
        Me.btnMaximizar.UseVisualStyleBackColor = True
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.BackgroundImage = CType(resources.GetObject("btnMinimizar.BackgroundImage"), System.Drawing.Image)
        Me.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Location = New System.Drawing.Point(994, 10)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(35, 35)
        Me.btnMinimizar.TabIndex = 3
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), System.Drawing.Image)
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Location = New System.Drawing.Point(1097, 10)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(35, 35)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1144, 791)
        Me.Controls.Add(Me.panelForms)
        Me.Controls.Add(Me.panelIOpciones)
        Me.Controls.Add(Me.panelVentanas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuPrincipal"
        Me.panelVentanas.ResumeLayout(False)
        Me.panelMenu.ResumeLayout(False)
        Me.panelMenu.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.panelIOpciones.ResumeLayout(False)
        Me.panelIOpciones.PerformLayout()
        Me.panelForms.ResumeLayout(False)
        Me.panelForms.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelVentanas As Panel
    Friend WithEvents panelIOpciones As Panel
    Friend WithEvents panelForms As Panel
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents panelMenu As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ventanaInicio As ToolStripMenuItem
    Friend WithEvents ventanaClientes As ToolStripMenuItem
    Friend WithEvents ventanaAdministracion As ToolStripMenuItem
    Friend WithEvents ventanaPersonal As ToolStripMenuItem
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
