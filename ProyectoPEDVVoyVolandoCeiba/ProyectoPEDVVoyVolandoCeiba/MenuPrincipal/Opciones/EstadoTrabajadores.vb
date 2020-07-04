Imports System.Runtime.InteropServices

Public Class EstadoTrabajadores

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

    Private Sub EstadoTrabajadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarDGVHistorial(dgvEstadoTraba, "select idTrabajador as 'Codigo Trabajador', nombres as 'Nombre', telefonoTrabajador as 'Numero Telefono', estado as 'Estado' from ENTIDADES e inner join PERSONAL p on e.telefono = p.telefonoTrabajador")

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class