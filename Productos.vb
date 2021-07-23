Imports System.Data.SqlClient
Public Class Productos
    Private Sub BuscarBtn_Click(sender As Object, e As EventArgs) Handles BuscarBtn.Click
        Try
            If (Prodtxtbx.Text.Trim = "") Then
                MsgBox("No puede dejar el código de producto en blanco")
            Else
                Dim temp As New DataSet
                Dim adaptador As New SqlDataAdapter("Select *
                                                     from Producto where ID_Producto = '" & Prodtxtbx.Text & "'", gymbokuform.cn)

                adaptador.Fill(temp, "Suscripcion")
                ProdDGV.DataSource = temp.Tables("Suscripcion")

            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub
End Class