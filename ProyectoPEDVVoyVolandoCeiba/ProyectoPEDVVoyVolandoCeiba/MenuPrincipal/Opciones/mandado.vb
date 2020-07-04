Public Class mandado
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        comprobarYLlenarTel(txtTelefono, txtNombre, txtIdSector, txtDireccion, txtReferencia)
    End Sub

    Private Sub consultaPers_Click(sender As Object, e As EventArgs) Handles consultaPers.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

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
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll

    End Sub
End Class