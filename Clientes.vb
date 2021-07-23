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
        Dim temp As New DataSet

        Try
            If (BuscarTxtbx.Text.Trim = "") Then
                MsgBox("No puede dejar el código de producto en blanco")
            Else
                If (BuscarCB.SelectedIndex = 0) Then
                    Dim adaptador As New SqlDataAdapter("Select *
                                                     from Usuario where ID_Usuario = '" & BuscarTxtbx.Text & "'", gymbokuform.cn)
                    adaptador.Fill(temp, "Usuario")
                    ClienteDGV.DataSource = temp.Tables("Usuario")
                ElseIf (BuscarCB.SelectedIndex = 1) Then
                    Dim adaptador As New SqlDataAdapter("Select *
                                                     from Usuario where Nombre = '" & BuscarTxtbx.Text & "'", gymbokuform.cn)
                    adaptador.Fill(temp, "Usuario")
                    ClienteDGV.DataSource = temp.Tables("Usuario")
                ElseIf (BuscarCB.SelectedIndex = 2) Then
                    Dim adaptador As New SqlDataAdapter("Select *
                                                     from Usuario where Email = '" & BuscarTxtbx.Text & "'", gymbokuform.cn)
                    adaptador.Fill(temp, "Usuario")
                    ClienteDGV.DataSource = temp.Tables("Usuario")
                ElseIf (BuscarCB.SelectedIndex = 3) Then
                    Dim adaptador As New SqlDataAdapter("Select *
                                                     from Usuario where ID_Suscripcion = '" & BuscarTxtbx.Text & "'", gymbokuform.cn)
                    adaptador.Fill(temp, "Usuario")
                    ClienteDGV.DataSource = temp.Tables("Usuario")
                Else
                    Dim adaptador As New SqlDataAdapter("Select *
                                                     from Usuario where ID_Entrenador = '" & BuscarTxtbx.Text & "'", gymbokuform.cn)
                    adaptador.Fill(temp, "Usuario")
                    ClienteDGV.DataSource = temp.Tables("Usuario")
                End If




            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub
End Class