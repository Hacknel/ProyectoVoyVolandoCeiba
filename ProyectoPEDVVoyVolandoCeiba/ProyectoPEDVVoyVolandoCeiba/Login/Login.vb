Imports System.ComponentModel
Imports System.Runtime.InteropServices

Public Class Login
#Region "Form behaviors"
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        End

    End Sub
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub
#End Region

#Region "Move form"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMs As Integer, wParam As Integer, lParam As Integer)

    End Sub

    Private Sub panelTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles panelTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)

    End Sub

    Private Sub btnMostrarContra_Click(sender As Object, e As EventArgs) Handles btnMostrarContra.Click

        If txtContraseña.UseSystemPasswordChar = True Then
            txtContraseña.UseSystemPasswordChar = False

        Else
            txtContraseña.UseSystemPasswordChar = True

        End If

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtContraseña.UseSystemPasswordChar = True

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim name, password As String

        name = txtNombre.Text
        password = txtContraseña.Text

        If name = "" Then
            name = " "
        Else
            name = name.ToLower
        End If

        If name = "administrador" And password = "contraseña" Then
            MessageBox.Show("Cargando menu principal...", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            MenuPrincipal.Show()

        ElseIf name = "administrador" Then
            MessageBox.Show("Contraseña incorrecta, vuelva a intentarlo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtContraseña.Clear()

        ElseIf name = " " And password = "" Then
            MessageBox.Show("Por favor ingrese un usuario y contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf name = " " Then
            MessageBox.Show("Por favor ingrese un nombre de usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf password = "" Then
            MessageBox.Show("Por favor ingrese una contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            MessageBox.Show("Usted no es un usuario administrador", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNombre.Clear()
            txtContraseña.Clear()

        End If
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtContraseña_TextChanged(sender As Object, e As EventArgs) Handles txtContraseña.TextChanged

    End Sub

    Private Sub txtContraseña_Validating(sender As Object, e As CancelEventArgs) Handles txtContraseña.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        toolTip.SetToolTip(txtNombre, "Ingrese su nombre de usuario")
        toolTip.ToolTipTitle = "Nombre"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtContraseña_MouseHover(sender As Object, e As EventArgs) Handles txtContraseña.MouseHover
        toolTip.SetToolTip(txtContraseña, "Ingrese su contraseña")
        toolTip.ToolTipTitle = "Contraseña"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
#End Region

End Class
