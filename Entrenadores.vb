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
End Class