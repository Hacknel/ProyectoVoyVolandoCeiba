Imports System.Data.SqlClient
Public Class conexion
    Public conexion As SqlConnection = New SqlConnection("Data Source= DESKTOP-SRS9O5V\SQLSERVER;Initial Catalog= bd_VoyVolandoCeiba; Integrated Security= True")
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public comando As SqlCommand
    Public Sub conectar()
        Try
            conexion.Open()
            MessageBox.Show("Conectado")
        Catch ex As Exception
            MessageBox.Show("Error al conectar")
        Finally
            conexion.Close()
        End Try
    End Sub
    Public Sub consulta(ByVal sql, ByVal tabla)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
    End Sub

    Function insertar(ByVal sql)
        Dim con As SqlConnection = New SqlConnection("Data Source= DESKTOP-SRS9O5V\SQLSERVER;Initial Catalog= bd_VoyVolandoCeiba; Integrated Security= True")
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        Dim com As SqlCommand = New SqlCommand(sql, con)

        Dim i As Integer = com.ExecuteNonQuery()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Function eliminar(ByVal tabla, ByVal condicion)
        conexion.Open()
        Dim eliminarE As String = "delete from " + tabla + " where " + condicion
        comando = New SqlCommand(eliminarE, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    'Function insertar(ByVal idFactura As Integer, ByVal telefono As String, ByVal telefonoRecepcion As String, ByVal idMandado As Integer, ByVal idTrabajador As Integer, ByVal detallesMandado As String, ByVal fecha As String, ByVal estado As String, ByVal pago As Double)
    '    Dim mensaje As String = "Estudiante almacenado"
    '    Try
    '        comando = New SqlCommand("Insert into bd_VoyVolandoCeiba.REGISTROS_HISTORIAL(idFactura,telefono,telefonoRecepcion,idMandado,idTrabajador,detallesMandado,fecha,estado,pagoEnvio) values ('" & idFactura & "','" & telefono & "','" & telefonoRecepcion & "','" + idMandado + "','" & idTrabajador & "','" & detallesMandado & "','" & fecha & "', '" & estado & "', '" & pago & "')", conexion)
    '        comando.ExecuteNonQuery()
    '    Catch ex As Exception
    '        mensaje = "No se inserto por: " + ex.ToString
    '    End Try
    '    Return mensaje
    'End Function
    Function insertarPedidoDB(ByVal txt1 As TextBox, ByVal txt2 As TextBox, ByVal txt3 As TextBox, ByVal txt4 As TextBox, ByVal txt5 As TextBox, ByVal cmb2 As ComboBox, ByVal txt6 As TextBox)
        Try
            Dim comando As SqlCommand = conexion.CreateCommand()
            comando.CommandText = "insertarFactura"
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@telefonoEnvio", txt1.Text)
            comando.Parameters.AddWithValue("@telefonoRecep", txt2.Text)
            comando.Parameters.AddWithValue("@idMandado", txt3.Text)
            comando.Parameters.AddWithValue("@idTrabajador", txt4.Text)
            comando.Parameters.AddWithValue("@detallesMandado", txt5.Text)
            comando.Parameters.AddWithValue("@estado", cmb2.Text)
            comando.Parameters.AddWithValue("@pago", txt6.Text)
            conexion.Open()
            If comando.ExecuteNonQuery() Then
                MsgBox("Hay Pan")
                conexion.Close()
                Return 0
            Else
                MsgBox("Ya no hay pan")
                conexion.Close()
                Return 1
            End If
        Catch ex As Exception
            conexion.Close()
            MessageBox.Show("Error de Base de datos! " & vbCrLf + ex.ToString)
        End Try
    End Function

    Function modificar(ByVal tabla, ByVal campos, ByVal condicion)
        conexion.Open()
        Dim modificarE As String = "update " + tabla + " set " + campos + " where " + condicion
        comando = New SqlCommand(modificarE, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
