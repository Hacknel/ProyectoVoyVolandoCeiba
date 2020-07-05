Public Class fmVoy_volando
    Dim conexion As conexion = New conexion()
    Private Caso As Integer
    Private mandado, trabajador As Integer
    Private pago As Double

    Private Sub fmVoy_volando_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        btnModificar.Enabled = True
        btnEliminar.Enabled = False
        cmbPrincipal.SelectedIndex = 1
    End Sub
    Public Sub Limpiar()
        txtId.Enabled = True
        txtId.Clear()
        txtRecepcion.Clear()
        txtTelefono.Clear()
        txtCorreo.Clear()
        txtDetallesMandado.Clear()
        txtEdad.Clear()
        txtFrecuencia.Clear()
        txtPrimerApellido.Clear()
        txtSegundoApellido.Clear()
        txtRecepcion.Clear()
        txtSector.Clear()
        cmbEstado.SelectedIndex = -1
        btnEliminar.Enabled = False
        btnModificar.Enabled = False
        btnNueva.Enabled = True
        conexion.conexion.Close()
    End Sub
    Private Sub mostrarDatos()
        Select Case Caso
            Case 1
                conexion.consulta("select idFactura, telefono, telefonoRecepcion, idMandado, idTrabajador, detallesMandado, fecha, estado, pagoEnvio from REGISTROS_HISTORIAL", "bd_VoyVolandoCeiba.REGISTROS_HISTORIAL")
                dtgTablas.DataSource = conexion.ds.Tables("bd_VoyVolandoCeiba.REGISTROS_HISTORIAL")
            Case 2
                conexion.consulta("select * from ENTIDADES", "bd_VoyVolandoCeiba.ENTIDADES")
                dtgTablas.DataSource = conexion.ds.Tables("bd_VoyVolandoCeiba.ENTIDADES")
            Case 3
                conexion.consulta("select idSector, barrio, referenciasDireccion, ciudad, distancia from DIRECCIONES", "bd_VoyVolandoCeiba.DIRECCIONES")
                dtgTablas.DataSource = conexion.ds.Tables("bd_VoyVolandoCeiba.DIRECCIONES")
            Case 4
                conexion.consulta("select idTrabajador, telefonoTrabajador, idTransporte, sueldo, estado from PERSONAL", "bd_VoyVolandoCeiba.PERSONAL")
                dtgTablas.DataSource = conexion.ds.Tables("bd_VoyVolandoCeiba.PERSONAL")
            Case 5
                conexion.consulta("select idTransporte, matricula, modelo from MOTO", "bd_VoyVolandoCeiba.MOTO")
                dtgTablas.DataSource = conexion.ds.Tables("bd_VoyVolandoCeiba.MOTO")
            Case 6
                conexion.consulta("select idMandado, detalle from MANDADOS", "bd_VoyVolandoCeiba.MANDADOS")
                dtgTablas.DataSource = conexion.ds.Tables("bd_VoyVolandoCeiba.MANDADOS")
        End Select
    End Sub
    Private Sub dtgTablas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgTablas.CellContentClick
        btnNueva.Enabled = False
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        txtId.Enabled = False
        llenarCampos(e)
    End Sub
    Private Sub btnNueva_Click(sender As Object, e As EventArgs) Handles btnNueva.Click
        Dim cadena As String = String.Format("insert into ENTIDADES(telefono, identidad, nombres, primerApellido,segundoApellido, edad, correo, idSector, frecuencia)
        values('{0}','{1}', '{2}', '{3}', '{4}', {5}, '{6}', {7}, {8});", txtId.Text, txtTelefono.Text, txtRecepcion.Text, txtPrimerApellido.Text, txtSegundoApellido.Text, txtEdad.Text, txtCorreo.Text, txtSector.Text, txtFrecuencia.Text)
        conexion.insertar(cadena)
        '
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Try

            Dim modificar As String =
           " identidad='" + txtTelefono.Text + "', nombres='" + txtRecepcion.Text + "', primerApellido='" + txtPrimerApellido.Text + "', edad='" + txtEdad.Text + "', correo='" + txtCorreo.Text + "', idSector= '" + txtSector.Text + "', frecuencia= '" + txtFrecuencia.Text + "'"
            If (conexion.modificar("ENTIDADES", modificar, " telefono=" + txtId.Text)) Then
                MessageBox.Show("Actualizado")
                mostrarDatos()
                Limpiar()
                conexion.conexion.Close()
            Else
                MessageBox.Show("Error al actualizar")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If (conexion.eliminar("ENTIDADES", "telefono=" + txtId.Text)) Then
                MessageBox.Show("Eliminado")
                mostrarDatos()
                Limpiar()
                conexion.conexion.Close()
            Else
                MessageBox.Show("Error al Eliminar")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub llenarCampos(e As DataGridViewCellEventArgs)
        Try
            Dim dtg As DataGridViewRow = dtgTablas.Rows(e.RowIndex)
            txtId.Text = dtg.Cells(0).Value.ToString()
            txtTelefono.Text = dtg.Cells(1).Value.ToString()
            txtRecepcion.Text = dtg.Cells(2).Value.ToString()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub cmbPrincipal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPrincipal.SelectedIndexChanged
        If cmbPrincipal.SelectedIndex = 0 Then
            txtId.Visible = True
            txtTelefono.Visible = True
            txtTrabajador.Visible = True
            txtRecepcion.Visible = True
            labIDFactura.Visible = True
            btnNueva.Visible = True
            btnModificar.Visible = True
            btnLimpiar.Visible = True
            btnModificar.Visible = True
            btnEliminar.Visible = True
            labIDFactura.Visible = True
            labTelefono.Visible = True
            labRecepcion.Visible = True
            labMandado.Visible = True
            labEstado.Visible = True
            labPagos.Visible = True
            labDetalles.Visible = True
            labIDFactura.Text = "ID Factura:"
            labTelefono.Text = "Telefono:"
            labRecepcion.Text = "Telefono Recepcion:"
            labMandado.Text = "ID Mandado:"
            labEstado.Text = "Estado:"
            labPagos.Text = "Pago Envio:"
            labDetalles.Text = "Detalles Mandado:"
            txtDetallesMandado.Visible = True
            labSector.Visible = False
            labFrecuencia.Visible = False
            txtCorreo.Visible = False
            txtEdad.Visible = True
            txtPrimerApellido.Visible = True
            txtSegundoApellido.Visible = False
            cmbEstado.Visible = True
            labTrabajador.Visible = True
            labSector.Visible = False
            labFrecuencia.Visible = False
            txtSector.Visible = False
            txtFrecuencia.Visible = False
            labFecha.Visible = True
            dtpFecha.Visible = True
            Caso = 1
            mostrarDatos()
        ElseIf cmbPrincipal.SelectedIndex = 1 Then
            Caso = 2
            txtTrabajador.Visible = False
            labTrabajador.Visible = False
            labFecha.Visible = False
            dtpFecha.Visible = False
            txtId.Visible = True
            txtTelefono.Visible = True
            txtRecepcion.Visible = True
            labIDFactura.Visible = True
            btnNueva.Visible = True
            btnModificar.Visible = True
            btnLimpiar.Visible = True
            btnModificar.Visible = True
            btnEliminar.Visible = True
            labIDFactura.Visible = True
            labTelefono.Visible = True
            labRecepcion.Visible = True
            labMandado.Visible = True
            labEstado.Visible = True
            labPagos.Visible = True
            labDetalles.Visible = True
            labIDFactura.Text = "Telefono:"
            labTelefono.Text = "Identidad:"
            labRecepcion.Text = "Nombres:"
            labMandado.Text = "Primer apellido:"
            labEstado.Text = "Segundo apellido:"
            labPagos.Text = "Edad:"
            labDetalles.Text = "Correo:"
            cmbEstado.Visible = False
            txtEdad.Visible = False
            txtDetallesMandado.Visible = False
            txtCorreo.Visible = True
            txtEdad.Visible = True
            txtPrimerApellido.Visible = True
            txtSegundoApellido.Visible = True
            labSector.Visible = True
            labFrecuencia.Visible = True
            txtSector.Visible = True
            txtFrecuencia.Visible = True
            mostrarDatos()
        ElseIf cmbPrincipal.SelectedIndex = 2 Then
            txtTrabajador.Visible = False
            labTrabajador.Visible = False
            labFecha.Visible = False
            dtpFecha.Visible = False
            txtId.Visible = False
            txtTelefono.Visible = False
            txtRecepcion.Visible = False
            labIDFactura.Visible = False
            btnNueva.Visible = False
            btnModificar.Visible = False
            btnLimpiar.Visible = False
            btnModificar.Visible = False
            btnEliminar.Visible = False
            labTelefono.Visible = False
            labRecepcion.Visible = False
            labMandado.Visible = False
            labEstado.Visible = False
            labPagos.Visible = False
            labDetalles.Visible = False
            txtDetallesMandado.Visible = False
            labSector.Visible = False
            labFrecuencia.Visible = False
            txtCorreo.Visible = False
            txtEdad.Visible = False
            txtPrimerApellido.Visible = False
            txtSegundoApellido.Visible = False
            cmbEstado.Visible = False
            txtEdad.Visible = True
            labSector.Visible = False
            labFrecuencia.Visible = False
            txtSector.Visible = False
            txtFrecuencia.Visible = False
            txtCorreo.Visible = False
            txtEdad.Visible = False
            txtPrimerApellido.Visible = False
            txtSegundoApellido.Visible = False
            labSector.Visible = False
            labFrecuencia.Visible = False
            txtSector.Visible = False
            txtFrecuencia.Visible = False
            Caso = 3
            mostrarDatos()
        ElseIf cmbPrincipal.SelectedIndex = 3 Then
            txtTrabajador.Visible = False
            labTrabajador.Visible = False
            labFecha.Visible = False
            dtpFecha.Visible = False
            txtId.Visible = False
            txtTelefono.Visible = False
            txtRecepcion.Visible = False
            labIDFactura.Visible = False
            btnNueva.Visible = False
            btnModificar.Visible = False
            btnLimpiar.Visible = False
            btnModificar.Visible = False
            btnEliminar.Visible = False
            labTelefono.Visible = False
            labRecepcion.Visible = False
            labMandado.Visible = False
            labEstado.Visible = False
            labPagos.Visible = False
            labDetalles.Visible = False
            txtDetallesMandado.Visible = False
            labSector.Visible = False
            labFrecuencia.Visible = False
            txtCorreo.Visible = False
            txtEdad.Visible = False
            txtPrimerApellido.Visible = False
            txtSegundoApellido.Visible = False
            cmbEstado.Visible = False
            txtEdad.Visible = True
            labSector.Visible = False
            labFrecuencia.Visible = False
            txtSector.Visible = False
            txtFrecuencia.Visible = False
            txtCorreo.Visible = False
            txtEdad.Visible = False
            txtPrimerApellido.Visible = False
            txtSegundoApellido.Visible = False
            labSector.Visible = False
            labFrecuencia.Visible = False
            txtSector.Visible = False
            txtFrecuencia.Visible = False
            Caso = 4
            mostrarDatos()
        ElseIf cmbPrincipal.SelectedIndex = 4 Then
            txtTrabajador.Visible = False
            labTrabajador.Visible = False
            labFecha.Visible = False
            dtpFecha.Visible = False
            txtId.Visible = False
            txtTelefono.Visible = False
            txtRecepcion.Visible = False
            labIDFactura.Visible = False
            btnNueva.Visible = False
            btnModificar.Visible = False
            btnLimpiar.Visible = False
            btnModificar.Visible = False
            btnEliminar.Visible = False
            labTelefono.Visible = False
            labRecepcion.Visible = False
            labMandado.Visible = False
            labEstado.Visible = False
            labPagos.Visible = False
            labDetalles.Visible = False
            txtDetallesMandado.Visible = False
            labSector.Visible = False
            labFrecuencia.Visible = False
            txtCorreo.Visible = False
            txtEdad.Visible = False
            txtPrimerApellido.Visible = False
            txtSegundoApellido.Visible = False
            cmbEstado.Visible = False
            txtEdad.Visible = True
            labSector.Visible = False
            labFrecuencia.Visible = False
            txtSector.Visible = False
            txtFrecuencia.Visible = False
            txtCorreo.Visible = False
            txtEdad.Visible = False
            txtPrimerApellido.Visible = False
            txtSegundoApellido.Visible = False
            labSector.Visible = False
            labFrecuencia.Visible = False
            txtSector.Visible = False
            txtFrecuencia.Visible = False
            Caso = 5
            mostrarDatos()
        ElseIf cmbPrincipal.SelectedIndex = 5 Then
            txtTrabajador.Visible = False
            labTrabajador.Visible = False
            labFecha.Visible = False
            dtpFecha.Visible = False
            txtId.Visible = False
            txtTelefono.Visible = False
            txtRecepcion.Visible = False
            labIDFactura.Visible = False
            btnNueva.Visible = False
            btnModificar.Visible = False
            btnLimpiar.Visible = False
            btnModificar.Visible = False
            btnEliminar.Visible = False
            labTelefono.Visible = False
            labRecepcion.Visible = False
            labMandado.Visible = False
            labEstado.Visible = False
            labPagos.Visible = False
            labDetalles.Visible = False
            txtDetallesMandado.Visible = False
            labSector.Visible = False
            labFrecuencia.Visible = False
            txtCorreo.Visible = False
            txtEdad.Visible = False
            txtPrimerApellido.Visible = False
            txtSegundoApellido.Visible = False
            cmbEstado.Visible = False
            txtEdad.Visible = True
            labSector.Visible = False
            labFrecuencia.Visible = False
            txtSector.Visible = False
            txtFrecuencia.Visible = False
            txtCorreo.Visible = False
            txtEdad.Visible = False
            txtPrimerApellido.Visible = False
            txtSegundoApellido.Visible = False
            labSector.Visible = False
            labFrecuencia.Visible = False
            txtSector.Visible = False
            txtFrecuencia.Visible = False
            Caso = 6
            mostrarDatos()
        End If
    End Sub
End Class