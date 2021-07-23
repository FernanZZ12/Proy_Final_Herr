Imports System.Data.SqlClient
Public Class Entrenadores
    Private Sub BuscarBtn_Click(sender As Object, e As EventArgs) Handles BuscarBtn.Click
        Try
            If (Codtxtbx.Text.Trim = "") Then
                MsgBox("No puede dejar el código de entrenador en blanco")
            Else
                Dim temp As New DataSet
                Dim adaptador As New SqlDataAdapter("Select *
                                                     from Entrenador where ID_Entrenador = '" & Codtxtbx.Text & "'", gymbokuform.cn)

                adaptador.Fill(temp, "Entrenador")
                EntrenaDGV.DataSource = temp.Tables("Entrenador")

            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Private Sub NuevoEntreBtn_Click(sender As Object, e As EventArgs) Handles NuevoEntreBtn.Click
        Form1.Show()
    End Sub

    Private Sub ElimEntreBtn_Click(sender As Object, e As EventArgs) Handles ElimEntreBtn.Click
        Try
            Dim adaptador As New SqlDataAdapter("Select * from Entrenador where ID_Entrenador = '" & Codtxtbx.Text.Trim & "'", gymbokuform.cn)
            Dim ds As New DataSet
            adaptador.Fill(ds, "Usuario")
            If (Codtxtbx.Text.Trim = "") Then
                MsgBox("No puede dejar el código de entrenador en blanco")
            Else
                If ds.Tables("Usuario").Rows.Count > 0 Then
                    Dim adaptador1 As New SqlCommand("Delete From Entrenador where ID_Entrenador ='" & Codtxtbx.Text & "'", gymbokuform.cn)
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
End Class