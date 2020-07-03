Public Class mandado
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        If txttelefono.Text = "" Then
            MsgBox("Escriba un numero de telefono", vbInformation)
        Else
            AgregarCliente.Show()
        End If
    End Sub
End Class