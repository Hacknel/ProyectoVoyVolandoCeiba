<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Public Class fmVoy_volando
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
        Me.labIDFactura = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.labTelefono = New System.Windows.Forms.Label()
        Me.labRecepcion = New System.Windows.Forms.Label()
        Me.labMandado = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtRecepcion = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNueva = New System.Windows.Forms.Button()
        Me.dtgTablas = New System.Windows.Forms.DataGridView()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.labDetalles = New System.Windows.Forms.Label()
        Me.txtDetallesMandado = New System.Windows.Forms.TextBox()
        Me.labEstado = New System.Windows.Forms.Label()
        Me.labPagos = New System.Windows.Forms.Label()
        Me.cmbPrincipal = New System.Windows.Forms.ComboBox()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.labSector = New System.Windows.Forms.Label()
        Me.labFrecuencia = New System.Windows.Forms.Label()
        Me.txtSector = New System.Windows.Forms.TextBox()
        Me.txtFrecuencia = New System.Windows.Forms.TextBox()
        Me.txtPrimerApellido = New System.Windows.Forms.TextBox()
        Me.txtSegundoApellido = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.labFecha = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.labTrabajador = New System.Windows.Forms.Label()
        Me.txtTrabajador = New System.Windows.Forms.TextBox()
        CType(Me.dtgTablas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labIDFactura
        '
        Me.labIDFactura.AutoSize = True
        Me.labIDFactura.Location = New System.Drawing.Point(13, 104)
        Me.labIDFactura.Name = "labIDFactura"
        Me.labIDFactura.Size = New System.Drawing.Size(77, 17)
        Me.labIDFactura.TabIndex = 0
        Me.labIDFactura.Text = "ID Factura:"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(157, 104)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(192, 22)
        Me.txtId.TabIndex = 1
        '
        'labTelefono
        '
        Me.labTelefono.AutoSize = True
        Me.labTelefono.Location = New System.Drawing.Point(12, 149)
        Me.labTelefono.Name = "labTelefono"
        Me.labTelefono.Size = New System.Drawing.Size(68, 17)
        Me.labTelefono.TabIndex = 2
        Me.labTelefono.Text = "Telefono:"
        '
        'labRecepcion
        '
        Me.labRecepcion.AutoSize = True
        Me.labRecepcion.Location = New System.Drawing.Point(12, 177)
        Me.labRecepcion.Name = "labRecepcion"
        Me.labRecepcion.Size = New System.Drawing.Size(139, 17)
        Me.labRecepcion.TabIndex = 3
        Me.labRecepcion.Text = "Telefono Recepcion;"
        '
        'labMandado
        '
        Me.labMandado.AutoSize = True
        Me.labMandado.Location = New System.Drawing.Point(13, 210)
        Me.labMandado.Name = "labMandado"
        Me.labMandado.Size = New System.Drawing.Size(88, 17)
        Me.labMandado.TabIndex = 4
        Me.labMandado.Text = "ID Mandado:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(157, 144)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(192, 22)
        Me.txtTelefono.TabIndex = 5
        '
        'txtRecepcion
        '
        Me.txtRecepcion.Location = New System.Drawing.Point(157, 174)
        Me.txtRecepcion.Name = "txtRecepcion"
        Me.txtRecepcion.Size = New System.Drawing.Size(192, 22)
        Me.txtRecepcion.TabIndex = 6
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(880, 136)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(880, 88)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 9
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnNueva
        '
        Me.btnNueva.Location = New System.Drawing.Point(880, 35)
        Me.btnNueva.Name = "btnNueva"
        Me.btnNueva.Size = New System.Drawing.Size(75, 23)
        Me.btnNueva.TabIndex = 10
        Me.btnNueva.Text = "Nueva"
        Me.btnNueva.UseVisualStyleBackColor = True
        '
        'dtgTablas
        '
        Me.dtgTablas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgTablas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgTablas.Location = New System.Drawing.Point(15, 307)
        Me.dtgTablas.Name = "dtgTablas"
        Me.dtgTablas.RowHeadersWidth = 51
        Me.dtgTablas.RowTemplate.Height = 24
        Me.dtgTablas.Size = New System.Drawing.Size(940, 228)
        Me.dtgTablas.TabIndex = 11
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(880, 243)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(880, 189)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 13
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'labDetalles
        '
        Me.labDetalles.AutoSize = True
        Me.labDetalles.Location = New System.Drawing.Point(379, 174)
        Me.labDetalles.Name = "labDetalles"
        Me.labDetalles.Size = New System.Drawing.Size(126, 17)
        Me.labDetalles.TabIndex = 14
        Me.labDetalles.Text = "Detalles mandado:"
        '
        'txtDetallesMandado
        '
        Me.txtDetallesMandado.Location = New System.Drawing.Point(511, 174)
        Me.txtDetallesMandado.Multiline = True
        Me.txtDetallesMandado.Name = "txtDetallesMandado"
        Me.txtDetallesMandado.Size = New System.Drawing.Size(307, 122)
        Me.txtDetallesMandado.TabIndex = 15
        '
        'labEstado
        '
        Me.labEstado.AutoSize = True
        Me.labEstado.Location = New System.Drawing.Point(379, 106)
        Me.labEstado.Name = "labEstado"
        Me.labEstado.Size = New System.Drawing.Size(56, 17)
        Me.labEstado.TabIndex = 16
        Me.labEstado.Text = "Estado:"
        '
        'labPagos
        '
        Me.labPagos.AutoSize = True
        Me.labPagos.Location = New System.Drawing.Point(379, 141)
        Me.labPagos.Name = "labPagos"
        Me.labPagos.Size = New System.Drawing.Size(97, 17)
        Me.labPagos.TabIndex = 18
        Me.labPagos.Text = "Pagos envios:"
        '
        'cmbPrincipal
        '
        Me.cmbPrincipal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPrincipal.FormattingEnabled = True
        Me.cmbPrincipal.Items.AddRange(New Object() {"Facturar", "Clientes", "Consultar direcciones", "Consultar personal", "Consultar motos", "Tipos de mandado"})
        Me.cmbPrincipal.Location = New System.Drawing.Point(16, 58)
        Me.cmbPrincipal.Name = "cmbPrincipal"
        Me.cmbPrincipal.Size = New System.Drawing.Size(284, 24)
        Me.cmbPrincipal.TabIndex = 20
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Entregado", "En camino", "Pendiente"})
        Me.cmbEstado.Location = New System.Drawing.Point(511, 101)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(192, 24)
        Me.cmbEstado.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(13, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(243, 23)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Seleccione la operacion a realizar:"
        '
        'labSector
        '
        Me.labSector.AutoSize = True
        Me.labSector.Location = New System.Drawing.Point(379, 210)
        Me.labSector.Name = "labSector"
        Me.labSector.Size = New System.Drawing.Size(70, 17)
        Me.labSector.TabIndex = 24
        Me.labSector.Text = "ID Sector:"
        '
        'labFrecuencia
        '
        Me.labFrecuencia.AutoSize = True
        Me.labFrecuencia.Location = New System.Drawing.Point(379, 249)
        Me.labFrecuencia.Name = "labFrecuencia"
        Me.labFrecuencia.Size = New System.Drawing.Size(82, 17)
        Me.labFrecuencia.TabIndex = 25
        Me.labFrecuencia.Text = "Frecuencia:"
        '
        'txtSector
        '
        Me.txtSector.Location = New System.Drawing.Point(511, 205)
        Me.txtSector.Name = "txtSector"
        Me.txtSector.Size = New System.Drawing.Size(192, 22)
        Me.txtSector.TabIndex = 26
        '
        'txtFrecuencia
        '
        Me.txtFrecuencia.Location = New System.Drawing.Point(511, 249)
        Me.txtFrecuencia.Name = "txtFrecuencia"
        Me.txtFrecuencia.Size = New System.Drawing.Size(192, 22)
        Me.txtFrecuencia.TabIndex = 27
        '
        'txtPrimerApellido
        '
        Me.txtPrimerApellido.Location = New System.Drawing.Point(157, 210)
        Me.txtPrimerApellido.Name = "txtPrimerApellido"
        Me.txtPrimerApellido.Size = New System.Drawing.Size(192, 22)
        Me.txtPrimerApellido.TabIndex = 28
        '
        'txtSegundoApellido
        '
        Me.txtSegundoApellido.Location = New System.Drawing.Point(511, 110)
        Me.txtSegundoApellido.Name = "txtSegundoApellido"
        Me.txtSegundoApellido.Size = New System.Drawing.Size(192, 22)
        Me.txtSegundoApellido.TabIndex = 29
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(511, 138)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(192, 22)
        Me.txtEdad.TabIndex = 30
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(511, 171)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(192, 22)
        Me.txtCorreo.TabIndex = 31
        '
        'labFecha
        '
        Me.labFecha.AutoSize = True
        Me.labFecha.Location = New System.Drawing.Point(379, 65)
        Me.labFecha.Name = "labFecha"
        Me.labFecha.Size = New System.Drawing.Size(51, 17)
        Me.labFecha.TabIndex = 35
        Me.labFecha.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(511, 65)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 22)
        Me.dtpFecha.TabIndex = 37
        '
        'labTrabajador
        '
        Me.labTrabajador.AutoSize = True
        Me.labTrabajador.Location = New System.Drawing.Point(13, 246)
        Me.labTrabajador.Name = "labTrabajador"
        Me.labTrabajador.Size = New System.Drawing.Size(82, 17)
        Me.labTrabajador.TabIndex = 38
        Me.labTrabajador.Text = "Trabajador:"
        '
        'txtTrabajador
        '
        Me.txtTrabajador.Location = New System.Drawing.Point(157, 243)
        Me.txtTrabajador.Name = "txtTrabajador"
        Me.txtTrabajador.Size = New System.Drawing.Size(192, 22)
        Me.txtTrabajador.TabIndex = 41
        '
        'fmVoy_volando
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 547)
        Me.Controls.Add(Me.txtTrabajador)
        Me.Controls.Add(Me.labTrabajador)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.labFecha)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.txtEdad)
        Me.Controls.Add(Me.txtSegundoApellido)
        Me.Controls.Add(Me.txtPrimerApellido)
        Me.Controls.Add(Me.txtFrecuencia)
        Me.Controls.Add(Me.txtSector)
        Me.Controls.Add(Me.labFrecuencia)
        Me.Controls.Add(Me.labSector)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbEstado)
        Me.Controls.Add(Me.cmbPrincipal)
        Me.Controls.Add(Me.labPagos)
        Me.Controls.Add(Me.labEstado)
        Me.Controls.Add(Me.txtDetallesMandado)
        Me.Controls.Add(Me.labDetalles)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.dtgTablas)
        Me.Controls.Add(Me.btnNueva)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.txtRecepcion)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.labMandado)
        Me.Controls.Add(Me.labRecepcion)
        Me.Controls.Add(Me.labTelefono)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.labIDFactura)
        Me.Name = "fmVoy_volando"
        Me.Text = "Voy Volando"
        CType(Me.dtgTablas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labIDFactura As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents labTelefono As Label
    Friend WithEvents labRecepcion As Label
    Friend WithEvents labMandado As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtRecepcion As TextBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnNueva As Button
    Friend WithEvents dtgTablas As DataGridView
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents labDetalles As Label
    Friend WithEvents txtDetallesMandado As TextBox
    Friend WithEvents labEstado As Label
    Friend WithEvents labPagos As Label
    Friend WithEvents cmbPrincipal As ComboBox
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents labSector As Label
    Friend WithEvents labFrecuencia As Label
    Friend WithEvents txtSector As TextBox
    Friend WithEvents txtFrecuencia As TextBox
    Friend WithEvents txtPrimerApellido As TextBox
    Friend WithEvents txtSegundoApellido As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents labFecha As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents labTrabajador As Label
    Friend WithEvents txtTrabajador As TextBox
End Class
