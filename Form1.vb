Imports System.Data.SqlClient
Public Class Form1
    Private Sub RegresarBtn_Click(sender As Object, e As EventArgs) Handles RegresarBtn.Click
        Me.Hide()
    End Sub

    Private Sub AñadirBtn_Click(sender As Object, e As EventArgs) Handles AñadirBtn.Click
        'Boton de Añadir'
        Try
            If IDtxtbx.Text = "" Or Nombretxtbx.Text = "" Or Correotxtbx.Text = "" Then 'Espacio en Blanco'
                MsgBox("No puede dejar espacios en blanco")
            Else
                Dim adaptador As New SqlCommand("insert into Entrenador values('" & IDtxtbx.Text & "','" & Nombretxtbx.Text & "','" & Correotxtbx.Text & "')", gymbokuform.cn) ''Insercion a la BD
                adaptador.ExecuteNonQuery()

                MsgBox("Se ha añadido exitosamente")
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try

    End Sub
End Class