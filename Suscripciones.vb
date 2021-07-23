Imports System.Data.SqlClient
Public Class Suscripciones
    Private Sub BuscarBtn_Click(sender As Object, e As EventArgs) Handles BuscarBtn.Click
        Try
            If (CodigoTxtBx.Text.Trim = "") Then
                MsgBox("No puede dejar el código de suscripción en blanco")
            Else
                Dim temp As New DataSet
                Dim adaptador As New SqlDataAdapter("Select *
                                                     from Suscripcion where ID_Suscripcion = '" & CodigoTxtBx.Text & "'", gymbokuform.cn)

                adaptador.Fill(temp, "Suscripcion")
                SuscripcionDGV.DataSource = temp.Tables("Suscripcion")

            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub
End Class