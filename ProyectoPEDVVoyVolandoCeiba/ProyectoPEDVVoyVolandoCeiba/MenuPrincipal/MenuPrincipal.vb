Imports System.Runtime.InteropServices
Public Class MenuPrincipal

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True

        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        If MessageBox.Show("¿Esta seguro que desea salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
            End

        Else

        End If

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

#End Region
    Private Sub abrirFormulario(ByVal formHijo As Form)

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
    Private Sub btnDesplegarMenu_Click(sender As Object, e As EventArgs) Handles btnDesplegarMenu.Click

        If panelIOpciones.Width = 225 Then
            panelIOpciones.Width = 65

        Else
            panelIOpciones.Width = 225
        End If
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        PanelIni.Visible = True
        btnInicio.BackColor = Color.DimGray

        PanelManda.Visible = False
        btnMandado.BackColor = Color.Transparent

        PanelEsta.Visible = False
        btnEstadoMandado.BackColor = Color.Transparent

        PanelAdmin.Visible = False
        btnAdmin.BackColor = Color.Transparent

        abrirFormulario(bienvenidaInicio)
    End Sub

    Private Sub btnMandado_Click(sender As Object, e As EventArgs) Handles btnMandado.Click
        PanelIni.Visible = False
        btnInicio.BackColor = Color.Transparent

        PanelManda.Visible = True
        btnMandado.BackColor = Color.DimGray

        PanelEsta.Visible = False
        btnEstadoMandado.BackColor = Color.Transparent

        PanelAdmin.Visible = False
        btnAdmin.BackColor = Color.Transparent

        abrirFormulario(mandado)

    End Sub

    Private Sub btnEstadoMandado_Click(sender As Object, e As EventArgs) Handles btnEstadoMandado.Click
        PanelIni.Visible = False
        btnInicio.BackColor = Color.Transparent
        PanelManda.Visible = False
        btnMandado.BackColor = Color.Transparent
        PanelEsta.Visible = True
        btnEstadoMandado.BackColor = Color.DimGray
        PanelAdmin.Visible = False
        btnAdmin.BackColor = Color.Transparent

    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        PanelIni.Visible = False
        btnInicio.BackColor = Color.Transparent
        PanelManda.Visible = False
        btnMandado.BackColor = Color.Transparent
        PanelEsta.Visible = False
        btnEstadoMandado.BackColor = Color.Transparent
        PanelAdmin.Visible = True
        btnAdmin.BackColor = Color.DimGray

    End Sub

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelIni.Visible = True
        btnInicio.BackColor = Color.DimGray

        abrirFormulario(bienvenidaInicio)
    End Sub
End Class