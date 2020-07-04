Public Class mandado
	Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
		comprobarYLlenarTel(txtTelefono, txtNombre, txtIdSector, txtDireccion, txtReferencias)
	End Sub

	Sub comprobarYLlenarTel(ByVal txt0 As TextBox, ByVal txt1 As TextBox, ByVal txt2 As TextBox, ByVal txt3 As TextBox, ByVal txt4 As TextBox)
		Dim resultado As Integer
		resultado = comprobarExistenciaTelefono(txt0.Text)

		If resultado = 1 Then
			llenarTextBox(txt1, "select nombres from ENTIDADES where telefono = '" & txt0.Text & "' ", "nombres")
			llenarTextBox(txt2, "select idSector from ENTIDADES where telefono = '" & txt0.Text & "' ", "idSector")
			llenarTextBox(txt3, "select barrio from DIRECCIONES d inner join ENTIDADES e on d.idSector = e.idSector where telefono = '" & txt0.Text & "' ", "barrio")
			llenarTextBox(txt4, "select referenciasDireccion from DIRECCIONES d inner join ENTIDADES e on d.idSector = e.idSector where telefono = '" & txt0.Text & "' ", "referenciasDireccion")

		ElseIf resultado = 2 Then
			MessageBox.Show("El numero o localización ingresada no existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
			txt0.Clear()

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
End Class