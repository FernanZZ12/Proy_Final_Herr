Imports System.Data.SqlClient
Public Class Productos
    Private Sub BuscarBtn_Click(sender As Object, e As EventArgs) Handles BuscarBtn.Click
        'Boton de Buscar'
        Try
            If (Prodtxtbx.Text.Trim = "") Then 'Si textbox esta en blanco'
                MsgBox("No puede dejar el código de producto en blanco")
            Else
                Dim temp As New DataSet
                Dim adaptador As New SqlDataAdapter("Select *
                                                     from Producto where ID_Producto = '" & Prodtxtbx.Text & "'", gymbokuform.cn)

                adaptador.Fill(temp, "Suscripcion")
                ProdDGV.DataSource = temp.Tables("Suscripcion") 'Llenar DGV'

            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Private Sub ModificarProBtn_Click(sender As Object, e As EventArgs) Handles ModificarProBtn.Click
        Form6.Show()
    End Sub

    Private Sub AgregarProBtn_Click(sender As Object, e As EventArgs) Handles AgregarProBtn.Click
        Form7.Show()
    End Sub

    Private Sub EliminarProBtn_Click(sender As Object, e As EventArgs) Handles EliminarProBtn.Click
        Form8.Show()
    End Sub
End Class