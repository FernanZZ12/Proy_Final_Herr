﻿Imports System.Data.SqlClient
Public Class Entrenadores
    Private Sub BuscarBtn_Click(sender As Object, e As EventArgs) Handles BuscarBtn.Click
        'Boton de Buscar'
        Try
            If (Codtxtbx.Text.Trim = "") Then  'Si textbox esta en blanco'
                MsgBox("No puede dejar el código de entrenador en blanco")
            Else
                Dim temp As New DataSet
                Dim adaptador As New SqlDataAdapter("Select *
                                                     from Entrenador where ID_Entrenador = '" & Codtxtbx.Text & "'", gymbokuform.cn)

                adaptador.Fill(temp, "Entrenador")
                EntrenaDGV.DataSource = temp.Tables("Entrenador") 'Carga de DGV'

            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Private Sub NuevoEntreBtn_Click(sender As Object, e As EventArgs) Handles NuevoEntreBtn.Click
        Form1.Show()
    End Sub

    Private Sub ElimEntreBtn_Click(sender As Object, e As EventArgs) Handles ElimEntreBtn.Click
        'Boton de Eliminar'
        Try
            Dim adaptador As New SqlDataAdapter("Select * from Entrenador where ID_Entrenador = '" & Codtxtbx.Text.Trim & "'", gymbokuform.cn)
            Dim ds As New DataSet
            adaptador.Fill(ds, "Usuario")
            If (Codtxtbx.Text.Trim = "") Then 'Si textbox esta en blanco'
                MsgBox("No puede dejar el código de entrenador en blanco")
            Else
                If ds.Tables("Usuario").Rows.Count > 0 Then  'Si existe, entra'
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

    Private Sub Entrenadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim temp As New DataSet
        Dim adaptador As New SqlDataAdapter("Select *
                                                     from Entrenador", gymbokuform.cn)

        adaptador.Fill(temp, "Entrenador")
        EntrenaDGV.DataSource = temp.Tables("Entrenador") 'Carga de DGV'
    End Sub
End Class