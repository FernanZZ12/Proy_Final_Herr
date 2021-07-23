Imports System.Data.SqlClient
Public Class Form7
    Private Sub Agregarbtn_Click(sender As Object, e As EventArgs) Handles Agregarbtn.Click
        Try
            If IDCtxtbx.Text = "" Or IDPtxtbx.Text = "" Or Marcatxtbx.Text = "" Or Preciotxtbx.Text = "" Or Descriptxtbx.Text = "" Then
                MsgBox("No puede dejar espacios en blanco")
            Else
                Dim adaptador As New SqlCommand("insert into Producto values('" & IDPtxtbx.Text & "','" & IDCtxtbx.Text & "','" & Marcatxtbx.Text & "','" & Descriptxtbx.Text & "','" & Preciotxtbx.Text & "')", gymbokuform.cn)
                adaptador.ExecuteNonQuery()

                MsgBox("Se ha añadido exitosamente")
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Private Sub Regresarbtn_Click(sender As Object, e As EventArgs) Handles Regresarbtn.Click
        Me.Hide()
    End Sub
End Class