<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.panelVentanas = New System.Windows.Forms.Panel()
        Me.btnDesplegarMenu = New System.Windows.Forms.Button()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.panelIOpciones = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.btnEstadoMandado = New System.Windows.Forms.Button()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnMandado = New System.Windows.Forms.Button()
        Me.btnPersonal = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.panelForms = New System.Windows.Forms.Panel()
        Me.panelVentanas.SuspendLayout()
        Me.panelIOpciones.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelVentanas
        '
        Me.panelVentanas.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.panelVentanas.Controls.Add(Me.btnDesplegarMenu)
        Me.panelVentanas.Controls.Add(Me.btnRestaurar)
        Me.panelVentanas.Controls.Add(Me.btnMaximizar)
        Me.panelVentanas.Controls.Add(Me.btnMinimizar)
        Me.panelVentanas.Controls.Add(Me.btnCerrar)
        Me.panelVentanas.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelVentanas.Location = New System.Drawing.Point(0, 0)
        Me.panelVentanas.Name = "panelVentanas"
        Me.panelVentanas.Size = New System.Drawing.Size(1235, 51)
        Me.panelVentanas.TabIndex = 0
        '
        'btnDesplegarMenu
        '
        Me.btnDesplegarMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDesplegarMenu.BackgroundImage = Global.ProyectoPEDVVoyVolandoCeiba.My.Resources.Resources.Menu_48px
        Me.btnDesplegarMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDesplegarMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDesplegarMenu.FlatAppearance.BorderSize = 0
        Me.btnDesplegarMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnDesplegarMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDesplegarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDesplegarMenu.Location = New System.Drawing.Point(12, 10)
        Me.btnDesplegarMenu.Name = "btnDesplegarMenu"
        Me.btnDesplegarMenu.Size = New System.Drawing.Size(35, 35)
        Me.btnDesplegarMenu.TabIndex = 7
        Me.btnDesplegarMenu.UseVisualStyleBackColor = True
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
        Me.btnRestaurar.Location = New System.Drawing.Point(1140, 10)
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
        Me.btnMaximizar.Location = New System.Drawing.Point(1140, 10)
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
        Me.btnMinimizar.Location = New System.Drawing.Point(1085, 10)
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
        Me.btnCerrar.Location = New System.Drawing.Point(1188, 10)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(35, 35)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'panelIOpciones
        '
        Me.panelIOpciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.panelIOpciones.Controls.Add(Me.Panel2)
        Me.panelIOpciones.Controls.Add(Me.btnInicio)
        Me.panelIOpciones.Controls.Add(Me.btnEstadoMandado)
        Me.panelIOpciones.Controls.Add(Me.btnAdmin)
        Me.panelIOpciones.Controls.Add(Me.btnMandado)
        Me.panelIOpciones.Controls.Add(Me.btnPersonal)
        Me.panelIOpciones.Controls.Add(Me.Panel1)
        Me.panelIOpciones.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelIOpciones.Location = New System.Drawing.Point(0, 51)
        Me.panelIOpciones.Name = "panelIOpciones"
        Me.panelIOpciones.Size = New System.Drawing.Size(299, 824)
        Me.panelIOpciones.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, 15)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(299, 104)
        Me.Panel2.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-12, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(111, 93)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Fugaz One", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(104, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 82)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Voy volando " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     Ceiba"
        '
        'btnInicio
        '
        Me.btnInicio.BackColor = System.Drawing.Color.Transparent
        Me.btnInicio.BackgroundImage = CType(resources.GetObject("btnInicio.BackgroundImage"), System.Drawing.Image)
        Me.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInicio.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnInicio.FlatAppearance.BorderSize = 2
        Me.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicio.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicio.ForeColor = System.Drawing.Color.White
        Me.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInicio.Location = New System.Drawing.Point(0, 134)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(299, 64)
        Me.btnInicio.TabIndex = 4
        Me.btnInicio.Text = "Inicio"
        Me.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInicio.UseVisualStyleBackColor = False
        '
        'btnEstadoMandado
        '
        Me.btnEstadoMandado.BackColor = System.Drawing.Color.Transparent
        Me.btnEstadoMandado.BackgroundImage = Global.ProyectoPEDVVoyVolandoCeiba.My.Resources.Resources.icons8_data_quality_48
        Me.btnEstadoMandado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEstadoMandado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEstadoMandado.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnEstadoMandado.FlatAppearance.BorderSize = 2
        Me.btnEstadoMandado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEstadoMandado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnEstadoMandado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEstadoMandado.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEstadoMandado.ForeColor = System.Drawing.Color.White
        Me.btnEstadoMandado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEstadoMandado.Location = New System.Drawing.Point(0, 305)
        Me.btnEstadoMandado.Name = "btnEstadoMandado"
        Me.btnEstadoMandado.Size = New System.Drawing.Size(299, 64)
        Me.btnEstadoMandado.TabIndex = 3
        Me.btnEstadoMandado.Text = "          Estado del mandado"
        Me.btnEstadoMandado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEstadoMandado.UseVisualStyleBackColor = False
        '
        'btnAdmin
        '
        Me.btnAdmin.BackColor = System.Drawing.Color.Transparent
        Me.btnAdmin.BackgroundImage = Global.ProyectoPEDVVoyVolandoCeiba.My.Resources.Resources.icons8_database_administrator_48
        Me.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdmin.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnAdmin.FlatAppearance.BorderSize = 2
        Me.btnAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdmin.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin.ForeColor = System.Drawing.Color.White
        Me.btnAdmin.Location = New System.Drawing.Point(0, 388)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(299, 64)
        Me.btnAdmin.TabIndex = 5
        Me.btnAdmin.Text = "      Administración"
        Me.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdmin.UseVisualStyleBackColor = False
        '
        'btnMandado
        '
        Me.btnMandado.BackColor = System.Drawing.Color.Transparent
        Me.btnMandado.BackgroundImage = Global.ProyectoPEDVVoyVolandoCeiba.My.Resources.Resources.Producto_48px1
        Me.btnMandado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnMandado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMandado.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnMandado.FlatAppearance.BorderSize = 2
        Me.btnMandado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMandado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnMandado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMandado.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMandado.ForeColor = System.Drawing.Color.White
        Me.btnMandado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMandado.Location = New System.Drawing.Point(0, 220)
        Me.btnMandado.Name = "btnMandado"
        Me.btnMandado.Size = New System.Drawing.Size(299, 64)
        Me.btnMandado.TabIndex = 2
        Me.btnMandado.Text = "Mandado"
        Me.btnMandado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMandado.UseVisualStyleBackColor = False
        '
        'btnPersonal
        '
        Me.btnPersonal.BackColor = System.Drawing.Color.Transparent
        Me.btnPersonal.BackgroundImage = Global.ProyectoPEDVVoyVolandoCeiba.My.Resources.Resources.User_Groups_48px1
        Me.btnPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPersonal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPersonal.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnPersonal.FlatAppearance.BorderSize = 2
        Me.btnPersonal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPersonal.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPersonal.ForeColor = System.Drawing.Color.White
        Me.btnPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPersonal.Location = New System.Drawing.Point(0, 473)
        Me.btnPersonal.Name = "btnPersonal"
        Me.btnPersonal.Size = New System.Drawing.Size(299, 64)
        Me.btnPersonal.TabIndex = 7
        Me.btnPersonal.Text = "Personal"
        Me.btnPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPersonal.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(0, 723)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(299, 101)
        Me.Panel1.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Fugaz One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(98, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 29)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Administrador"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.ProyectoPEDVVoyVolandoCeiba.My.Resources.Resources.Businessman_48px
        Me.PictureBox2.Location = New System.Drawing.Point(12, 15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'panelForms
        '
        Me.panelForms.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.panelForms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelForms.Location = New System.Drawing.Point(299, 51)
        Me.panelForms.Name = "panelForms"
        Me.panelForms.Size = New System.Drawing.Size(936, 824)
        Me.panelForms.TabIndex = 2
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1235, 875)
        Me.Controls.Add(Me.panelForms)
        Me.Controls.Add(Me.panelIOpciones)
        Me.Controls.Add(Me.panelVentanas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuPrincipal"
        Me.panelVentanas.ResumeLayout(False)
        Me.panelIOpciones.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelVentanas As Panel
    Friend WithEvents panelIOpciones As Panel
    Friend WithEvents panelForms As Panel
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents btnEstadoMandado As Button
    Friend WithEvents btnMandado As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDesplegarMenu As Button
    Friend WithEvents btnPersonal As Button
    Friend WithEvents btnAdmin As Button
    Friend WithEvents btnInicio As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
End Class
