Imports System.Data.SqlClient
Public Class Form4
    Private Sub RegresarBtn_Click(sender As Object, e As EventArgs) Handles RegresarBtn.Click
        Me.Hide()
    End Sub

    Private Sub CambiarBtn_Click(sender As Object, e As EventArgs) Handles CambiarBtn.Click
        Try
            Dim adaptador As New SqlDataAdapter("Select * from Usuario where ID_Usuario = '" & IDtxtbx.Text & "'", gymbokuform.cn)
            Dim ds As New DataSet
            adaptador.Fill(ds, "Usuario")
            If (IDtxtbx.Text.Trim = "") Then
                MsgBox("No puede dejar el ID del usuario en blanco")
            Else
                If ds.Tables("Usuario").Rows.Count > 0 Then
                    If (SuscripCB.SelectedIndex = 0) Then
                        Dim adaptador1 As New SqlCommand("update Usuario set ID_Suscripcion ='" & "SI" & "' Where ID_Usuario = '" & IDtxtbx.Text & "'", gymbokuform.cn)
                        adaptador1.ExecuteNonQuery()
                        MsgBox("Se ha actualizado exitosamente")
                    ElseIf (SuscripCB.SelectedIndex = 1) Then
                        Dim adaptador1 As New SqlCommand("update Usuario set ID_Suscripcion ='" & "GD" & "' Where ID_Usuario = '" & IDtxtbx.Text & "'", gymbokuform.cn)
                        adaptador1.ExecuteNonQuery()
                        MsgBox("Se ha actualizado exitosamente")
                    Else
                        Dim adaptador1 As New SqlCommand("update Usuario set ID_Suscripcion ='" & "PL" & "' Where ID_Usuario = '" & IDtxtbx.Text & "'", gymbokuform.cn)
                        adaptador1.ExecuteNonQuery()
                        MsgBox("Se ha actualizado exitosamente")
                    End If

                Else
                    MsgBox("No existe este usuario.")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SuscripCB.SelectedIndex = 0
    End Sub
End Class