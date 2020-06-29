Imports System.Runtime.InteropServices
Public Class MenuPrincipal

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True

        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        End

    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        btnRestaurar.Visible = False
        btnMaximizar.Visible = True

        Me.WindowState = FormWindowState.Normal

    End Sub
#Region "Move form"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMs As Integer, wParam As Integer, lParam As Integer)

    End Sub

    Private Sub panelTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles panelVentanas.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)

    End Sub

    Private Sub panelVentanas_Paint(sender As Object, e As PaintEventArgs) Handles panelVentanas.Paint
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub ventanaInicio_Click(sender As Object, e As EventArgs) Handles ventanaInicio.Click

    End Sub

    Private Sub ventanaAdministracion_Click(sender As Object, e As EventArgs) Handles ventanaAdministracion.Click

    End Sub

    Private Sub ventanaClientes_Click(sender As Object, e As EventArgs) Handles ventanaClientes.Click
        abrirFormulario(ventanaClientes)
    End Sub

    Private Sub ventanaPersonal_Click(sender As Object, e As EventArgs) Handles ventanaPersonal.Click

    End Sub
#End Region
    Private Sub abrirFormulario(ByVal formHijo As Object)

        If panelForms.Controls.Count > 0 Then

            Me.panelForms.Controls.RemoveAt(0)
        End If

        Dim frm As Form = TryCast(formHijo, Form)

        frm.TopLevel = False
        frm.Dock = DockStyle.Fill

        Me.panelForms.Controls.Add(frm)
        Me.panelForms.Tag = frm

        frm.Show()
    End Sub

End Class