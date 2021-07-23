Imports System.Data.SqlClient
Public Class Form6
    Private Sub Regresarbtn_Click(sender As Object, e As EventArgs) Handles Regresarbtn.Click
        Me.Hide()
    End Sub

    Private Sub Cambiarbtn_Click(sender As Object, e As EventArgs) Handles Cambiarbtn.Click
        'Boton de Cambiar'
        Dim adaptador As New SqlDataAdapter("Select * from Producto where ID_Producto = '" & IDPtxtbx.Text & "'", gymbokuform.cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "Producto")

        If (IDPtxtbx.Text = "" Or IDCtxtbx.Text = "" Or Marcatxtbx.Text = "" Or Descriptxtbx.Text = "" Or Preciotxtbx.Text = "") Then 'Espacio en Blanco'
            MsgBox("No puede dejar espacios en blanco")
        Else
            If ds.Tables("Producto").Rows.Count > 0 Then  'Si existe'
                Dim adaptador1 As New SqlCommand("update Producto set ID_Categoria ='" & IDCtxtbx.Text & "', Marca ='" & Marcatxtbx.Text & "',  Descripcion ='" & Descriptxtbx.Text & "',  Precio ='" & Preciotxtbx.Text & "' Where ID_Producto = '" & IDPtxtbx.Text & "'", gymbokuform.cn) 'Actualizar BD'
                adaptador1.ExecuteNonQuery()
                MsgBox("Se ha cambiado exitosamente")
            Else
                MsgBox("No existe este producto.")
            End If
        End If
    End Sub
End Class