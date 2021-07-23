Imports System.Data.SqlClient
Public Class Form3
    Private Sub Eliminarbtn_Click(sender As Object, e As EventArgs) Handles Eliminarbtn.Click

        Try
            Dim adaptador As New SqlDataAdapter("Select * from Usuario where ID_Usuario = '" & IDtxtbx.Text & "'", gymbokuform.cn)
            Dim ds As New DataSet
            adaptador.Fill(ds, "Usuario")
            If (IDtxtbx.Text = "") Then
                MsgBox("No puede dejar el ID del usuario en blanco")
            Else
                If ds.Tables("Usuario").Rows.Count > 0 Then
                    Dim adaptador1 As New SqlCommand("Delete From Usuario where ID_Usuario ='" & IDtxtbx.Text & "'", gymbokuform.cn)
                    adaptador1.ExecuteNonQuery()
                    MsgBox("Se ha eliminado exitosamente")
                Else
                    MsgBox("No existe este usuario.")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Private Sub RegresarBtn_Click(sender As Object, e As EventArgs) Handles RegresarBtn.Click
        Me.Hide()
    End Sub
End Class