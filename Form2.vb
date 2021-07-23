Imports System.Data.SqlClient
Public Class Form2
    Private Sub Regresarbtn_Click(sender As Object, e As EventArgs) Handles Regresarbtn.Click
        Me.Hide()
    End Sub

    Private Sub Añadirbtn_Click(sender As Object, e As EventArgs) Handles Añadirbtn.Click
        Try
            If IDtxtbx.Text = "" Or Nombretxtbx.Text = "" Or Emailtxtbx.Text = "" Or Entrenatxtbx.Text = "" Then
                MsgBox("No puede dejar espacios en blanco")
            Else
                Dim adaptador As New SqlCommand("insert into Usuario values('" & IDtxtbx.Text & "','" & Nombretxtbx.Text & "','" & Emailtxtbx.Text & "','" & "NA" & "','" & Nothing & "','" & Entrenatxtbx.Text & "')", gymbokuform.cn)
                adaptador.ExecuteNonQuery()

                MsgBox("Se ha añadido exitosamente")
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub
End Class