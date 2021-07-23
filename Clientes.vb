Imports System.Data.SqlClient
Public Class Clientes
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuscarCB.SelectedIndex = 0
        Dim temp As New DataSet
        Dim adaptador As New SqlDataAdapter("Select *
                                                     from Usuario", gymbokuform.cn)

        adaptador.Fill(temp, "Usuario")
        ClienteDGV.DataSource = temp.Tables("Usuario")
    End Sub

    Private Sub BuscarBtn_Click(sender As Object, e As EventArgs) Handles BuscarBtn.Click
        Try
            If (BuscarTxtbx.Text.Trim = "") Then
                MsgBox("No puede dejar el código de producto en blanco")
            Else

                Dim adaptador As New SqlDataAdapter("Select *
                                                     from Producto where ID_Producto = '" & BuscarTxtbx.Text & "'", gymbokuform.cn)



            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub
End Class