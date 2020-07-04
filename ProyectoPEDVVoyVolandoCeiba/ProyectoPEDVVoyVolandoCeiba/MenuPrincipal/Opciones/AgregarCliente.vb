Imports System.ComponentModel

Public Class AgregarCliente
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        Try
            If Me.ValidateChildren And txtTelefono.Text <> String.Empty And txtPrimernombre.Text <> String.Empty And txtPrimerapellido.Text <> String.Empty And Val(txtEdad.Text) - Int(Val(txtEdad.Text)) = 0 And txtEdad.Text <> String.Empty And txtSegundonombre.Text <> String.Empty And txtSegundoapellido.Text <> String.Empty And txtIdentidad.Text <> String.Empty Then
                MessageBox.Show("Datos registrados correctamente", "Registrar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Ingrese correctamente los datos solicitados", "Registrar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtIdentidad.Clear()
                txtPrimernombre.Clear()
                txtPrimerapellido.Clear()
                txtEdad.Clear()
                txtTelefono.Clear()
                txtSegundonombre.Clear()
                txtSegundoapellido.Clear()

            End If
        Catch ex As Exception

        End Try
        txtIdentidad.Clear()
        txtPrimernombre.Clear()
        txtPrimerapellido.Clear()
        txtEdad.Clear()
        txtTelefono.Clear()
        txtSegundonombre.Clear()
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

    Private Sub txtPrimernombre_TextChanged(sender As Object, e As EventArgs) Handles txtPrimernombre.TextChanged

    End Sub

    Private Sub txtPrimernombre_Validating(sender As Object, e As CancelEventArgs) Handles txtPrimernombre.Validating
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

    Private Sub txtEdad_TextChanged(sender As Object, e As EventArgs) Handles txtEdad.TextChanged

    End Sub

    Private Sub txtEdad_Validating(sender As Object, e As CancelEventArgs) Handles txtEdad.Validating
        If ((Val(txtEdad.Text) - Int(Val(txtEdad.Text))) = 0) And (txtEdad.Text <> String.Empty) Then
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

    Private Sub txtSegundonombre_TextChanged(sender As Object, e As EventArgs) Handles txtSegundonombre.TextChanged

    End Sub

    Private Sub txtSegundonombre_Validating(sender As Object, e As CancelEventArgs) Handles txtSegundonombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese su Segundo nombre")
        End If
    End Sub

    Private Sub txtSegundoapellido_TextChanged(sender As Object, e As EventArgs) Handles txtSegundoapellido.TextChanged

    End Sub

    Private Sub txtSegundoapellido_Validating(sender As Object, e As CancelEventArgs) Handles txtSegundoapellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese su segundo apellido")
        End If
    End Sub

    Private Sub txtIdentidad_MouseHover(sender As Object, e As EventArgs) Handles txtIdentidad.MouseHover
        mensaje.SetToolTip(txtIdentidad, "Ingrese su numero de identidad")
        mensaje.ToolTipTitle = "Identidad"
        mensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtPrimernombre_MouseHover(sender As Object, e As EventArgs) Handles txtPrimernombre.MouseHover
        mensaje.SetToolTip(txtIdentidad, "Ingrese su primer nombre")
        mensaje.ToolTipTitle = "Primer Nombre"
        mensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtPrimerapellido_MouseHover(sender As Object, e As EventArgs) Handles txtPrimerapellido.MouseHover
        mensaje.SetToolTip(txtIdentidad, "Ingrese su primer apellido")
        mensaje.ToolTipTitle = "Primer apellido"
        mensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtEdad_MouseHover(sender As Object, e As EventArgs) Handles txtEdad.MouseHover
        mensaje.SetToolTip(txtIdentidad, "Ingrese su edad")
        mensaje.ToolTipTitle = "Edad"
        mensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_MouseHover(sender As Object, e As EventArgs) Handles ComboBox1.MouseHover
        mensaje.SetToolTip(txtIdentidad, "Seleccione su sexo")
        mensaje.ToolTipTitle = "Sexo"
        mensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtTelefono_MouseHover(sender As Object, e As EventArgs) Handles txtTelefono.MouseHover
        mensaje.SetToolTip(txtIdentidad, "Iingrese su numero de telefono")
        mensaje.ToolTipTitle = "Telefono"
        mensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtSegundonombre_MouseHover(sender As Object, e As EventArgs) Handles txtSegundonombre.MouseHover
        mensaje.SetToolTip(txtIdentidad, "Ingrese su segundo nombre")
        mensaje.ToolTipTitle = "Segundo nombre"
        mensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtSegundoapellido_MouseHover(sender As Object, e As EventArgs) Handles txtSegundoapellido.MouseHover
        mensaje.SetToolTip(txtIdentidad, "Ingrese su segundo apellido")
        mensaje.ToolTipTitle = "Segundo apellido"
        mensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class