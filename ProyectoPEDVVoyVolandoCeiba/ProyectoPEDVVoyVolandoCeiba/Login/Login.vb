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
    <DLLImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DLLImport("user32.DLL", EntryPoint:="SendMessage")>
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
        Me.Hide()
        MenuPrincipal.Show()


    End Sub
#End Region

End Class
