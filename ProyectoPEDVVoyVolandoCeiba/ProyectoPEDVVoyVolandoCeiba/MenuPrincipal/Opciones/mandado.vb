Public Class mandado
	Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
		comprobarYLlenarTel(txtTelefono, txtNombre, txtIdSector, txtDireccion, txtReferencias)

	End Sub

	Sub comprobarYLlenarTel(ByVal txt0 As TextBox, ByVal txt1 As TextBox, ByVal txt2 As TextBox, ByVal txt3 As TextBox, ByVal txt4 As TextBox)
		Dim resultado As Integer
		Dim cadena As String
		resultado = comprobarExistenciaTelefono(txt0.Text)
		cadena = txt0.Text
		If resultado = 1 Then
			llenarTextBox(txt1, "select nombres from ENTIDADES where telefono = '" & txt0.Text & "' ", "nombres")
			llenarTextBox(txt2, "select idSector from ENTIDADES where telefono = '" & txt0.Text & "' ", "idSector")
			llenarTextBox(txt3, "select barrio from DIRECCIONES d inner join ENTIDADES e on d.idSector = e.idSector where telefono = '" & txt0.Text & "' ", "barrio")
			llenarTextBox(txt4, "select referenciasDireccion from DIRECCIONES d inner join ENTIDADES e on d.idSector = e.idSector where telefono = '" & txt0.Text & "' ", "referenciasDireccion")

		ElseIf resultado = 2 Then
			If cadena.Length > 8 Then
				MessageBox.Show("Por favor ingrese un numero valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
				txt0.Clear()

			ElseIf MessageBox.Show("El numero ingresado no existe, ¿desea registrarlo?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
				MenuPrincipal.Hide()
				AgregarCliente.Show()
				txt0.Clear()

			Else
				txt0.Clear()
			End If
		End If
	End Sub

	Private Sub txtTelefono_TextChanged(sender As Object, e As EventArgs) Handles txtTelefono.TextChanged
		If txtTelefono.TextLength > 0 Then
			cmbEmpresas.Enabled = False
		Else
			cmbEmpresas.Enabled = True
		End If

	End Sub

	Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
		EstadoTrabajadores.Show()

	End Sub

	Private Sub btnConsultarMan_Click(sender As Object, e As EventArgs) Handles btnConsultarMan.Click
		comprobarYLlenarTel(txtTelefonoMan, txtNombreMan, txtIdSectorMan, txtDireccionMan, txtReferenciasMan)
	End Sub

	Private Sub cmbEmpresas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmpresas.SelectedIndexChanged
		comprobarYLlenarEmpre(txtNombre, txtIdSector, txtDireccion, txtReferencias, cmbEmpresas)

		If cmbEmpresas.Text <> "Ninguno" Then
			txtTelefono.ReadOnly = True
		End If
		If cmbEmpresas.Text = "Ninguno" Then
			txtTelefono.ReadOnly = False
			limpiar(Me)
		End If
	End Sub

	Sub comprobarYLlenarEmpre(ByVal txt1 As TextBox, ByVal txt2 As TextBox, ByVal txt3 As TextBox, ByVal txt4 As TextBox, cmb As ComboBox)
		llenarTextBox(txt1, "select nombres from ENTIDADES where nombres = '" & cmb.Text & "' ", "nombres")
		llenarTextBox(txt2, "select idSector from ENTIDADES where nombres = '" & cmb.Text & "' ", "idSector")
		llenarTextBox(txt3, "select barrio from DIRECCIONES d inner join ENTIDADES e on d.idSector = e.idSector where nombres = '" & cmb.Text & "' ", "barrio")
		llenarTextBox(txt4, "select referenciasDireccion from DIRECCIONES d inner join ENTIDADES e on d.idSector = e.idSector where nombres = '" & cmb.Text & "' ", "referenciasDireccion")
	End Sub

	Private Sub mandado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		abrirConexion()
		llenarComboBox(cmbEmpresas, "select nombres from ENTIDADES where telefono>=1 and telefono<=100", "nombres")
		llenarComboBox(cmbEmpresasMan, "select nombres from ENTIDADES where telefono>=1 and telefono<=100", "nombres")
		llenarComboBox(cmbEncargado, "select nombres from ENTIDADES e inner join PERSONAL p on e.telefono = p.telefonoTrabajador", "nombres")
		llenarComboBox(cmbTipoEnvio, "select detalle from MANDADOS", "detalle")
		cmbEmpresasMan.Items.Add("Ninguno")
		cmbEmpresas.Items.Add("Ninguno")
	End Sub

	Private Sub cmbEmpresasMan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmpresasMan.SelectedIndexChanged
		comprobarYLlenarEmpre(txtNombreMan, txtIdSectorMan, txtDireccionMan, txtReferenciasMan, cmbEmpresasMan)

		If cmbEmpresasMan.Text <> "Ninguno" Then
			txtTelefonoMan.ReadOnly = True
		End If
		If cmbEmpresasMan.Text = "Ninguno" Then
			txtTelefonoMan.ReadOnly = False
			limpiar(Me)
		End If
	End Sub

	Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

	End Sub

	Private Sub btnSolicitar_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click
		Dim codigoTrabajador As Integer = obtenerVariableEntera("select idTrabajador from PERSONAL p inner join ENTIDADES e on p.telefonoTrabajador = e.telefono where nombres = '" & cmbEncargado.Text & "' ", "idTrabajador")
		Dim codigoMandado As Integer = obtenerVariableEntera("select idMandado from MANDADOS where detalle = '" & cmbTipoEnvio.Text & "'", "idMandado")
		If cmbEmpresasMan.Enabled = True Then
			txtTelefonoMan.Text = obtenerVariableCadena("select telefono from ENTIDADES where nombres = '" & cmbEmpresasMan.Text & "' ", "telefono")
		End If

		If cmbEmpresas.Enabled = True Then
			txtTelefono.Text = obtenerVariableCadena("select telefono from ENTIDADES where nombres = '" & cmbEmpresas.Text & "' ", "telefono")
		End If

		Dim precioPagar As Double
		Dim valorKM1 As Double = obtenerVariableDecimal("select distancia from DIRECCIONES d inner join ENTIDADES e on d.idSector = e.idSector where e.Telefono = '" & txtTelefonoMan.Text & "'", "distancia")
		Dim valorKM2 As Double = obtenerVariableDecimal("select distancia from DIRECCIONES d inner join ENTIDADES e on d.idSector = e.idSector where e.Telefono = '" & txtTelefono.Text & "'", "distancia")
		Dim calculo As Double = valorKM1 + valorKM2
		If calculo >= 0 And calculo <= 3 Then
			precioPagar = 15.0
		End If
		If calculo >= 3.1 And calculo <= 5 Then
			precioPagar = 25.0
		End If
		If calculo >= 5.1 Then
			precioPagar = 45.0
		End If

		Dim sumador As Integer = obtenerVariableEntera("select frecuencia from ENTIDADES where telefono = '" & txtTelefono.Text & "' ", "frecuencia")

		If MessageBox.Show("El Precio a pagar es Lps. " + precioPagar.ToString + " ¿Desea confirmar pedido? ", "CONSULTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then

			If insertarPedidoDB(txtTelefonoMan, txtTelefono, txtDetalles, codigoMandado, cmbEstadoPaquete, codigoTrabajador, precioPagar) = 0 Then
				EjecutarComando("update PERSONAL set estado = '" & cmbEstadoPersona.Text & "' where idTrabajador = '" & codigoTrabajador & "' ")
				sumador += 1
				EjecutarComando("update ENTIDADES set frecuencia = '" & sumador & "' where telefono = '" & txtTelefono.Text & "'")
				MessageBox.Show("Pedido Procesado Correctamente", "PEDIDO", MessageBoxButtons.OK, MessageBoxIcon.Information)
			Else
				MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End If
		Else
			limpiar(Me)

		End If

		txtTelefonoMan.Clear()
		txtTelefono.Clear()
		cmbEmpresas.SelectedIndex = -1
		cmbEmpresasMan.SelectedIndex = -1
		txtNombre.Clear()
		txtIdSector.Clear()
		txtDireccion.Clear()
		txtReferencias.Clear()
		txtNombreMan.Clear()
		txtIdSectorMan.Clear()
		txtDireccionMan.Clear()
		txtReferenciasMan.Clear()
		cmbEncargado.SelectedIndex = -1
		cmbEstadoPersona.SelectedIndex = -1
		cmbEstadoPaquete.SelectedIndex = -1
		txtDetalles.Clear()

	End Sub
End Class