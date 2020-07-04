<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mandado
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbEstadoPaquete = New System.Windows.Forms.ComboBox()
        Me.cmbTipoEnvio = New System.Windows.Forms.ComboBox()
        Me.txtDetalles = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbEstadoPersona = New System.Windows.Forms.ComboBox()
        Me.cmbEncargado = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnSolicitar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtReferenciasMan = New System.Windows.Forms.TextBox()
        Me.txtNombreMan = New System.Windows.Forms.TextBox()
        Me.txtIdSectorMan = New System.Windows.Forms.TextBox()
        Me.txtDireccionMan = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTelefonoMan = New System.Windows.Forms.TextBox()
        Me.btnConsultarMan = New System.Windows.Forms.Button()
        Me.cmbEmpresasMan = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnVerificar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtReferencias = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtIdSector = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.cmbEmpresas = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.GroupBox8)
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Fugaz One", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(13, 2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(895, 1101)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mandado"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label17)
        Me.GroupBox8.Controls.Add(Me.Label16)
        Me.GroupBox8.Controls.Add(Me.Label15)
        Me.GroupBox8.Controls.Add(Me.cmbEstadoPaquete)
        Me.GroupBox8.Controls.Add(Me.cmbTipoEnvio)
        Me.GroupBox8.Controls.Add(Me.txtDetalles)
        Me.GroupBox8.Font = New System.Drawing.Font("Fugaz One", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.ForeColor = System.Drawing.Color.White
        Me.GroupBox8.Location = New System.Drawing.Point(411, 879)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(438, 209)
        Me.GroupBox8.TabIndex = 32
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Paquete"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(24, 129)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(102, 29)
        Me.Label17.TabIndex = 38
        Me.Label17.Text = "Detalles"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(209, 33)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(154, 29)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Tipo de envío"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(30, 33)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 29)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "Estado"
        '
        'cmbEstadoPaquete
        '
        Me.cmbEstadoPaquete.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstadoPaquete.FormattingEnabled = True
        Me.cmbEstadoPaquete.Items.AddRange(New Object() {"Espera", "Ejecucion"})
        Me.cmbEstadoPaquete.Location = New System.Drawing.Point(52, 66)
        Me.cmbEstadoPaquete.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbEstadoPaquete.Name = "cmbEstadoPaquete"
        Me.cmbEstadoPaquete.Size = New System.Drawing.Size(131, 32)
        Me.cmbEstadoPaquete.TabIndex = 35
        '
        'cmbTipoEnvio
        '
        Me.cmbTipoEnvio.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoEnvio.FormattingEnabled = True
        Me.cmbTipoEnvio.Location = New System.Drawing.Point(256, 66)
        Me.cmbTipoEnvio.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTipoEnvio.Name = "cmbTipoEnvio"
        Me.cmbTipoEnvio.Size = New System.Drawing.Size(169, 32)
        Me.cmbTipoEnvio.TabIndex = 34
        '
        'txtDetalles
        '
        Me.txtDetalles.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalles.Location = New System.Drawing.Point(133, 128)
        Me.txtDetalles.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDetalles.Multiline = True
        Me.txtDetalles.Name = "txtDetalles"
        Me.txtDetalles.Size = New System.Drawing.Size(272, 74)
        Me.txtDetalles.TabIndex = 33
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label14)
        Me.GroupBox7.Controls.Add(Me.Label13)
        Me.GroupBox7.Controls.Add(Me.cmbEstadoPersona)
        Me.GroupBox7.Controls.Add(Me.cmbEncargado)
        Me.GroupBox7.Font = New System.Drawing.Font("Fugaz One", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.White
        Me.GroupBox7.Location = New System.Drawing.Point(53, 912)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(333, 153)
        Me.GroupBox7.TabIndex = 31
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Encargado"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(175, 52)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 29)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Estado"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(21, 52)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 29)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Nombre"
        '
        'cmbEstadoPersona
        '
        Me.cmbEstadoPersona.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstadoPersona.FormattingEnabled = True
        Me.cmbEstadoPersona.Items.AddRange(New Object() {"Libre", "Ocupado"})
        Me.cmbEstadoPersona.Location = New System.Drawing.Point(198, 85)
        Me.cmbEstadoPersona.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbEstadoPersona.Name = "cmbEstadoPersona"
        Me.cmbEstadoPersona.Size = New System.Drawing.Size(105, 32)
        Me.cmbEstadoPersona.TabIndex = 23
        '
        'cmbEncargado
        '
        Me.cmbEncargado.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEncargado.FormattingEnabled = True
        Me.cmbEncargado.Location = New System.Drawing.Point(26, 85)
        Me.cmbEncargado.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbEncargado.Name = "cmbEncargado"
        Me.cmbEncargado.Size = New System.Drawing.Size(131, 32)
        Me.cmbEncargado.TabIndex = 22
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnSolicitar)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.txtReferenciasMan)
        Me.GroupBox5.Controls.Add(Me.txtNombreMan)
        Me.GroupBox5.Controls.Add(Me.txtIdSectorMan)
        Me.GroupBox5.Controls.Add(Me.txtDireccionMan)
        Me.GroupBox5.Font = New System.Drawing.Font("Fugaz One", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(53, 671)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(796, 202)
        Me.GroupBox5.TabIndex = 30
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Información mandado"
        '
        'btnSolicitar
        '
        Me.btnSolicitar.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnSolicitar.Location = New System.Drawing.Point(589, 41)
        Me.btnSolicitar.Name = "btnSolicitar"
        Me.btnSolicitar.Size = New System.Drawing.Size(194, 56)
        Me.btnSolicitar.TabIndex = 28
        Me.btnSolicitar.Text = "Solicitar"
        Me.btnSolicitar.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(364, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 29)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Referencias"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(33, 108)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 29)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Dirección"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(364, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 29)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Id Sector"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(21, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 29)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Nombre"
        '
        'txtReferenciasMan
        '
        Me.txtReferenciasMan.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferenciasMan.Location = New System.Drawing.Point(420, 132)
        Me.txtReferenciasMan.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReferenciasMan.Multiline = True
        Me.txtReferenciasMan.Name = "txtReferenciasMan"
        Me.txtReferenciasMan.Size = New System.Drawing.Size(268, 55)
        Me.txtReferenciasMan.TabIndex = 26
        '
        'txtNombreMan
        '
        Me.txtNombreMan.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreMan.Location = New System.Drawing.Point(55, 66)
        Me.txtNombreMan.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreMan.Name = "txtNombreMan"
        Me.txtNombreMan.Size = New System.Drawing.Size(223, 31)
        Me.txtNombreMan.TabIndex = 23
        '
        'txtIdSectorMan
        '
        Me.txtIdSectorMan.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdSectorMan.Location = New System.Drawing.Point(420, 57)
        Me.txtIdSectorMan.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdSectorMan.Name = "txtIdSectorMan"
        Me.txtIdSectorMan.Size = New System.Drawing.Size(155, 31)
        Me.txtIdSectorMan.TabIndex = 22
        '
        'txtDireccionMan
        '
        Me.txtDireccionMan.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccionMan.Location = New System.Drawing.Point(54, 141)
        Me.txtDireccionMan.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDireccionMan.Name = "txtDireccionMan"
        Me.txtDireccionMan.Size = New System.Drawing.Size(224, 31)
        Me.txtDireccionMan.TabIndex = 21
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.txtTelefonoMan)
        Me.GroupBox4.Controls.Add(Me.btnConsultarMan)
        Me.GroupBox4.Controls.Add(Me.cmbEmpresasMan)
        Me.GroupBox4.Font = New System.Drawing.Font("Fugaz One", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox4.Location = New System.Drawing.Point(53, 499)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(796, 155)
        Me.GroupBox4.TabIndex = 29
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Especificaciones mandado"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(446, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 29)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Nombre"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(66, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 29)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Numero"
        '
        'txtTelefonoMan
        '
        Me.txtTelefonoMan.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoMan.Location = New System.Drawing.Point(85, 67)
        Me.txtTelefonoMan.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelefonoMan.Name = "txtTelefonoMan"
        Me.txtTelefonoMan.Size = New System.Drawing.Size(191, 31)
        Me.txtTelefonoMan.TabIndex = 20
        '
        'btnConsultarMan
        '
        Me.btnConsultarMan.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnConsultarMan.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultarMan.ForeColor = System.Drawing.Color.White
        Me.btnConsultarMan.Location = New System.Drawing.Point(284, 96)
        Me.btnConsultarMan.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConsultarMan.Name = "btnConsultarMan"
        Me.btnConsultarMan.Size = New System.Drawing.Size(177, 49)
        Me.btnConsultarMan.TabIndex = 25
        Me.btnConsultarMan.Text = "Consultar"
        Me.btnConsultarMan.UseVisualStyleBackColor = False
        '
        'cmbEmpresasMan
        '
        Me.cmbEmpresasMan.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEmpresasMan.FormattingEnabled = True
        Me.cmbEmpresasMan.Location = New System.Drawing.Point(491, 66)
        Me.cmbEmpresasMan.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbEmpresasMan.Name = "cmbEmpresasMan"
        Me.cmbEmpresasMan.Size = New System.Drawing.Size(206, 32)
        Me.cmbEmpresasMan.TabIndex = 24
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtReferencias)
        Me.GroupBox3.Controls.Add(Me.txtNombre)
        Me.GroupBox3.Controls.Add(Me.txtIdSector)
        Me.GroupBox3.Controls.Add(Me.txtDireccion)
        Me.GroupBox3.Font = New System.Drawing.Font("Fugaz One", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(53, 248)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(796, 244)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Información solicitante"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.GroupBox6.Controls.Add(Me.btnVerificar)
        Me.GroupBox6.ForeColor = System.Drawing.Color.White
        Me.GroupBox6.Location = New System.Drawing.Point(554, 36)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(210, 106)
        Me.GroupBox6.TabIndex = 31
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Personal"
        '
        'btnVerificar
        '
        Me.btnVerificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnVerificar.Font = New System.Drawing.Font("Fugaz One", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerificar.ForeColor = System.Drawing.Color.White
        Me.btnVerificar.Location = New System.Drawing.Point(35, 42)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(147, 40)
        Me.btnVerificar.TabIndex = 0
        Me.btnVerificar.Text = "Verificar"
        Me.btnVerificar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(334, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 29)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Referencias"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 29)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Dirección"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(313, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 29)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Id Sector"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 29)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Nombre"
        '
        'txtReferencias
        '
        Me.txtReferencias.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferencias.Location = New System.Drawing.Point(390, 176)
        Me.txtReferencias.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReferencias.Multiline = True
        Me.txtReferencias.Name = "txtReferencias"
        Me.txtReferencias.Size = New System.Drawing.Size(268, 55)
        Me.txtReferencias.TabIndex = 26
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(54, 78)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(255, 31)
        Me.txtNombre.TabIndex = 23
        '
        'txtIdSector
        '
        Me.txtIdSector.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdSector.Location = New System.Drawing.Point(369, 78)
        Me.txtIdSector.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdSector.Name = "txtIdSector"
        Me.txtIdSector.Size = New System.Drawing.Size(155, 31)
        Me.txtIdSector.TabIndex = 22
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(55, 176)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(248, 31)
        Me.txtDireccion.TabIndex = 21
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtTelefono)
        Me.GroupBox2.Controls.Add(Me.btnConsultar)
        Me.GroupBox2.Controls.Add(Me.cmbEmpresas)
        Me.GroupBox2.Font = New System.Drawing.Font("Fugaz One", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(53, 48)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(796, 193)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Especificaciones solicitante"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(429, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 29)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 29)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Numero"
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(69, 84)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(191, 31)
        Me.txtTelefono.TabIndex = 20
        '
        'btnConsultar
        '
        Me.btnConsultar.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnConsultar.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.ForeColor = System.Drawing.Color.White
        Me.btnConsultar.Location = New System.Drawing.Point(277, 126)
        Me.btnConsultar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(184, 50)
        Me.btnConsultar.TabIndex = 25
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = False
        '
        'cmbEmpresas
        '
        Me.cmbEmpresas.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEmpresas.FormattingEnabled = True
        Me.cmbEmpresas.Location = New System.Drawing.Point(474, 83)
        Me.cmbEmpresas.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbEmpresas.Name = "cmbEmpresas"
        Me.cmbEmpresas.Size = New System.Drawing.Size(309, 32)
        Me.cmbEmpresas.TabIndex = 24
        '
        'mandado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(951, 1102)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "mandado"
        Me.Text = "mandado"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtReferencias As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtIdSector As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents btnConsultar As Button
    Friend WithEvents cmbEmpresas As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTelefonoMan As TextBox
    Friend WithEvents btnConsultarMan As Button
    Friend WithEvents cmbEmpresasMan As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtReferenciasMan As TextBox
    Friend WithEvents txtNombreMan As TextBox
    Friend WithEvents txtIdSectorMan As TextBox
    Friend WithEvents txtDireccionMan As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents btnVerificar As Button
    Friend WithEvents btnSolicitar As Button
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents cmbEstadoPersona As ComboBox
    Friend WithEvents cmbEncargado As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents cmbEstadoPaquete As ComboBox
    Friend WithEvents cmbTipoEnvio As ComboBox
    Friend WithEvents txtDetalles As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
End Class
