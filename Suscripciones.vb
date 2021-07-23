Imports System.Data.SqlClient
Public Class Suscripciones
    Private Sub BuscarBtn_Click(sender As Object, e As EventArgs) Handles BuscarBtn.Click
        'Boton Buscar'
        Try
            If (CodigoTxtBx.Text.Trim = "") Then      'Suscripcion en blanco (textbox)'
                MsgBox("No puede dejar el código de suscripción en blanco")
            Else
                Dim temp As New DataSet
                Dim adaptador As New SqlDataAdapter("Select *
                                                     from Suscripcion where ID_Suscripcion = '" & CodigoTxtBx.Text & "'", gymbokuform.cn)

                adaptador.Fill(temp, "Suscripcion")
                SuscripcionDGV.DataSource = temp.Tables("Suscripcion") 'Llenar DGV'

            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Private Sub ModificarSusBtn_Click(sender As Object, e As EventArgs) Handles ModificarSusBtn.Click
        'Modificar Suscripcion'
        Dim adaptador As New SqlDataAdapter("Select * from Suscripcion where ID_Suscripcion = '" & CodigoTxtBx.Text & "'", gymbokuform.cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "Suscripcion")

        If (Suscripciontxtbx.Text = "" Or Descripciontxtbx.Text = "" Or Descuentotxtbx.Text = "") Then ''Espacio en Blanco
            MsgBox("No puede dejar espacios en blanco")
        Else
            If ds.Tables("Suscripcion").Rows.Count > 0 Then  ''Si existe
                Dim adaptador1 As New SqlCommand("update Suscripcion set Nombre_Suscripcion ='" & Suscripciontxtbx.Text & "', Descripcion ='" & Descripciontxtbx.Text & "',  Descuento ='" & Descuentotxtbx.Text & "' Where ID_Suscripcion = '" & CodigoTxtBx.Text & "'", gymbokuform.cn) ''Actualiza
                adaptador1.ExecuteNonQuery()
                MsgBox("Se ha cambiado exitosamente")
            Else
                MsgBox("No existe este producto.")
            End If
        End If
    End Sub

    Private Sub Suscripciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim temp As New DataSet
        Dim adaptador As New SqlDataAdapter("Select *
                                                     from Suscripcion", gymbokuform.cn)

        adaptador.Fill(temp, "Suscripcion")
        SuscripcionDGV.DataSource = temp.Tables("Suscripcion") 'Llenar DGV'
    End Sub
End Class