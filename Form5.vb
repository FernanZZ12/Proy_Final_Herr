Imports System.Data.SqlClient
Public Class Form5
    Private Sub RegresarBtn_Click(sender As Object, e As EventArgs) Handles RegresarBtn.Click
        Me.Hide()
    End Sub

    Private Sub ModificarBtn_Click(sender As Object, e As EventArgs) Handles ModificarBtn.Click
        'Boton de Modificar'
        Dim adaptador As New SqlDataAdapter("Select * from Usuario where ID_Usuario = '" & IDUtxtbx.Text & "'", gymbokuform.cn)   'Usuario'
        Dim adaptador1 As New SqlDataAdapter("Select * from Usuario where ID_Entrenador = '" & IDEtxtbx.Text & "'", gymbokuform.cn) 'Entrenador'
        Dim ds As New DataSet
            Dim ds1 As New DataSet
            adaptador.Fill(ds, "Usuario")
            adaptador1.Fill(ds1, "Usuario")
        If (IDUtxtbx.Text = "" Or IDEtxtbx.Text = "") Then  ''Espacio en Blanco
            MsgBox("No puede dejar espacios en blanco")
        Else
            If ds.Tables("Usuario").Rows.Count > 0 And ds1.Tables("Usuario").Rows.Count > 0 Then ''Si existe alguno de los dos
                Dim adaptador2 As New SqlCommand("update Usuario set ID_Entrenador ='" & IDEtxtbx.Text & "' Where ID_Usuario = '" & IDUtxtbx.Text & "'", gymbokuform.cn) 'Actualiza BD'
                adaptador2.ExecuteNonQuery()
                MsgBox("Se ha cambiado exitosamente")
            Else
                MsgBox("No existe este usuario o entrenador.")
                End If
            End If

    End Sub

End Class