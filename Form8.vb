Imports System.Data.SqlClient
Public Class Form8
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Regresarbtn.Click
        Me.Hide()
    End Sub

    Private Sub Eliminarbtn_Click(sender As Object, e As EventArgs) Handles Eliminarbtn.Click
        Try
            Dim adaptador As New SqlDataAdapter("Select * from Producto where ID_Producto = '" & IDPtxtbx.Text & "'", gymbokuform.cn)
            Dim ds As New DataSet
            adaptador.Fill(ds, "Producto")
            If (IDPtxtbx.Text = "") Then
                MsgBox("No puede dejar el ID del usuario en blanco")
            Else
                If ds.Tables("Producto").Rows.Count > 0 Then
                    Dim adaptador1 As New SqlCommand("Delete From Producto where ID_Producto ='" & IDPtxtbx.Text & "'", gymbokuform.cn)
                    adaptador1.ExecuteNonQuery()
                    MsgBox("Se ha eliminado exitosamente")
                Else
                    MsgBox("No existe este producto.")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub
End Class