Imports System.ComponentModel
Imports System.Runtime.InteropServices
Public Class AgregarCliente

#Region "Move form"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMs As Integer, wParam As Integer, lParam As Integer)

    End Sub

    Private Sub panelTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBotones.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)

    End Sub

    Private Sub PanelBotones_Paint(sender As Object, e As PaintEventArgs) Handles PanelBotones.Paint
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

#End Region

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        Try
            If Me.ValidateChildren And txtTelefono.Text <> String.Empty And txtNombres.Text <> String.Empty And txtPrimerapellido.Text <> String.Empty And Val(mtbEdad.Text) - Int(Val(mtbEdad.Text)) = 0 And mtbEdad.Text <> String.Empty And txtSegundoapellido.Text <> String.Empty And txtIdentidad.Text <> String.Empty Then
                abrirConexion()

                EjecutarComando("insert into ENTIDADES values('" & txtTelefono.Text & "', '" & txtIdentidad.Text & "', '" & txtNombres.Text & "',
                '" & txtPrimerapellido.Text & "', '" & txtSegundoapellido.Text & "', '" & mtbEdad.Text & "', '" & txtCorreo.Text & "' , '" & cmbSectores.SelectedItem & "', 0)")

                MessageBox.Show("Datos registrados correctamente", "Registrar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                MenuPrincipal.Show()

            Else
                MessageBox.Show("Ingrese correctamente los datos solicitados", "Registrar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtIdentidad.Clear()
                txtNombres.Clear()
                txtPrimerapellido.Clear()
                mtbEdad.Clear()
                txtTelefono.Clear()
                txtNombres.Clear()
                txtSegundoapellido.Clear()

            End If
        Catch ex As Exception
            MessageBox.Show("Error al intentar registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Try
        txtIdentidad.Clear()
        txtNombres.Clear()
        txtPrimerapellido.Clear()
        mtbEdad.Clear()
        txtTelefono.Clear()
        txtNombres.Clear()
        txtSegundoapellido.Clear()


    End Sub

    Private Sub txtIdentidad_TextChanged(sender As Object, e As EventArgs) Handles txtIdentidad.TextChanged

    End Sub

    Private Sub txtIdentidad_Validating(sender As Object, e As CancelEventArgs) Handles txtIdentidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese numero de identidad")
        End If
    End Sub

    Private Sub txtNombres_Validating(sender As Object, e As CancelEventArgs) Handles txtNombres.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese  su primer nombre")
        End If
    End Sub

    Private Sub txtPrimerapellido_TextChanged(sender As Object, e As EventArgs) Handles txtPrimerapellido.TextChanged

    End Sub

    Private Sub txtPrimerapellido_Validating(sender As Object, e As CancelEventArgs) Handles txtPrimerapellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese su primer apellido")
        End If
    End Sub

    Private Sub txtEdad_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtEdad_Validating(sender As Object, e As CancelEventArgs)
        If ((Val(mtbEdad.Text) - Int(Val(mtbEdad.Text))) = 0) And (mtbEdad.Text <> String.Empty) Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese su edad")
        End If
    End Sub

    Private Sub txtTelefono_TextChanged(sender As Object, e As EventArgs) Handles txtTelefono.TextChanged

    End Sub

    Private Sub txtTelefono_Validating(sender As Object, e As CancelEventArgs) Handles txtTelefono.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese su numero de telefono")
        End If
    End Sub

    Private Sub txtSegundoapellido_TextChanged(sender As Object, e As EventArgs) Handles txtSegundoapellido.TextChanged

    End Sub

    Private Sub txtIdentidad_MouseHover(sender As Object, e As EventArgs) Handles txtIdentidad.MouseHover
        mensaje.SetToolTip(txtIdentidad, "Ingrese su numero de identidad")
        mensaje.ToolTipTitle = "Identidad"
        mensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtNombres_MouseHover(sender As Object, e As EventArgs) Handles txtNombres.MouseHover
        mensaje.SetToolTip(txtIdentidad, "Ingrese su primer nombre")
        mensaje.ToolTipTitle = "Primer Nombre"
        mensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub mtbEdad_MouseHover(sender As Object, e As EventArgs)
        mensaje.SetToolTip(txtIdentidad, "Ingrese su edad")
        mensaje.ToolTipTitle = "Edad"
        mensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtTelefono_MouseHover(sender As Object, e As EventArgs) Handles txtTelefono.MouseHover
        mensaje.SetToolTip(txtIdentidad, "Iingrese su numero de telefono")
        mensaje.ToolTipTitle = "Telefono"
        mensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtSegundonombre_MouseHover(sender As Object, e As EventArgs)
        mensaje.SetToolTip(txtIdentidad, "Ingrese su segundo nombre")
        mensaje.ToolTipTitle = "Segundo nombre"
        mensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtSegundoapellido_MouseHover(sender As Object, e As EventArgs) Handles txtSegundoapellido.MouseHover
        mensaje.SetToolTip(txtIdentidad, "Ingrese su segundo apellido")
        mensaje.ToolTipTitle = "Segundo apellido"
        mensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub AgregarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrirConexion()
        llenarComboBox(cmbSectores, "select idSector from DIRECCIONES", "idSector")
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        MenuPrincipal.Show()

    End Sub

    Private Sub cmbSectores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSectores.SelectedIndexChanged
        Dim barr As String = obtenerVariableCadena("select barrio from DIRECCIONES where idSector = '" & cmbSectores.Text & "'", "barrio")
        txtBarrioMostrar.Text = barr

    End Sub
End Class