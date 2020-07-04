<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarCliente
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarCliente))
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSegundoapellido = New System.Windows.Forms.TextBox()
        Me.txtSegundonombre = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtPrimerapellido = New System.Windows.Forms.TextBox()
        Me.txtPrimernombre = New System.Windows.Forms.TextBox()
        Me.txtIdentidad = New System.Windows.Forms.TextBox()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.mensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.moverPanel = New System.Windows.Forms.Panel()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.moverPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnRegistrar.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.ForeColor = System.Drawing.Color.White
        Me.btnRegistrar.Location = New System.Drawing.Point(629, 412)
        Me.btnRegistrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(251, 59)
        Me.btnRegistrar.TabIndex = 0
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(28, 154)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Primer Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(487, 156)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Segundo Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Impact", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(76, 427)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 29)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Edad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Impact", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(28, 246)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 29)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Primer Apellido"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Impact", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(487, 246)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(181, 29)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Segundo Apellido"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Impact", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(51, 62)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 29)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Identidad"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Impact", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(525, 69)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 29)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Telefono"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.moverPanel)
        Me.GroupBox1.Controls.Add(Me.txtSegundoapellido)
        Me.GroupBox1.Controls.Add(Me.btnRegistrar)
        Me.GroupBox1.Controls.Add(Me.txtSegundonombre)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.txtEdad)
        Me.GroupBox1.Controls.Add(Me.txtPrimerapellido)
        Me.GroupBox1.Controls.Add(Me.txtPrimernombre)
        Me.GroupBox1.Controls.Add(Me.txtIdentidad)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Fugaz One", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(913, 513)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registrar"
        '
        'txtSegundoapellido
        '
        Me.txtSegundoapellido.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSegundoapellido.Location = New System.Drawing.Point(686, 247)
        Me.txtSegundoapellido.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSegundoapellido.Name = "txtSegundoapellido"
        Me.txtSegundoapellido.Size = New System.Drawing.Size(194, 31)
        Me.txtSegundoapellido.TabIndex = 16
        '
        'txtSegundonombre
        '
        Me.txtSegundonombre.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSegundonombre.Location = New System.Drawing.Point(686, 158)
        Me.txtSegundonombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSegundonombre.Name = "txtSegundonombre"
        Me.txtSegundonombre.Size = New System.Drawing.Size(194, 31)
        Me.txtSegundonombre.TabIndex = 15
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(686, 70)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(194, 31)
        Me.txtTelefono.TabIndex = 14
        '
        'txtEdad
        '
        Me.txtEdad.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdad.Location = New System.Drawing.Point(208, 427)
        Me.txtEdad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(193, 31)
        Me.txtEdad.TabIndex = 13
        '
        'txtPrimerapellido
        '
        Me.txtPrimerapellido.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimerapellido.Location = New System.Drawing.Point(208, 246)
        Me.txtPrimerapellido.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrimerapellido.Name = "txtPrimerapellido"
        Me.txtPrimerapellido.Size = New System.Drawing.Size(193, 31)
        Me.txtPrimerapellido.TabIndex = 12
        '
        'txtPrimernombre
        '
        Me.txtPrimernombre.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimernombre.Location = New System.Drawing.Point(208, 149)
        Me.txtPrimernombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrimernombre.Name = "txtPrimernombre"
        Me.txtPrimernombre.Size = New System.Drawing.Size(193, 31)
        Me.txtPrimernombre.TabIndex = 11
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdentidad.Location = New System.Drawing.Point(208, 58)
        Me.txtIdentidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(193, 31)
        Me.txtIdentidad.TabIndex = 10
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'moverPanel
        '
        Me.moverPanel.BackColor = System.Drawing.Color.Transparent
        Me.moverPanel.Controls.Add(Me.btnMinimizar)
        Me.moverPanel.Controls.Add(Me.btnCerrar)
        Me.moverPanel.Location = New System.Drawing.Point(0, 0)
        Me.moverPanel.Name = "moverPanel"
        Me.moverPanel.Size = New System.Drawing.Size(913, 25)
        Me.moverPanel.TabIndex = 17
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
        Me.btnMinimizar.Location = New System.Drawing.Point(856, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(24, 22)
        Me.btnMinimizar.TabIndex = 19
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
        Me.btnCerrar.Location = New System.Drawing.Point(886, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(24, 22)
        Me.btnCerrar.TabIndex = 18
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.ComboBox1.Location = New System.Drawing.Point(208, 345)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(193, 32)
        Me.ComboBox1.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(57, 344)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 29)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Id Sector"
        '
        'AgregarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(913, 513)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AgregarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AgregarCliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.moverPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnRegistrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtSegundoapellido As TextBox
    Friend WithEvents txtSegundonombre As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents txtPrimerapellido As TextBox
    Friend WithEvents txtPrimernombre As TextBox
    Friend WithEvents txtIdentidad As TextBox
    Friend WithEvents erroricono As ErrorProvider
    Friend WithEvents mensaje As ToolTip
    Friend WithEvents moverPanel As Panel
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
End Class
