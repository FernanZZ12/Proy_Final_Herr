Imports System.Data.SqlClient

Public Class Facturas
    Private Sub Buscarbtn_Click(sender As Object, e As EventArgs) Handles Buscarbtn.Click
        Dim temp As New DataSet
        Dim adaptador As New SqlDataAdapter("select ID_Orden,
                                                    ID_Producto,
                                                    Cantidad,
                                                    Descuento,
                                                    Cantidad*Precio as Subtotal
                                                    from Detalle
                                             where ID_Orden ='" & Facturatxtbox.Text & "'", gymbokuform.cn)
        adaptador.Fill(temp, "Detalles")
        If (temp.Tables("Detalles").Rows.Count > 0) Then
            DataGridView1.DataSource = temp.Tables("Detalles")
            Dim subtotal As Double = Sumar(temp.Tables("Detalles"))
            Dim descuent As Double = Math.Round(Sumar(temp.Tables("Detalles")) * Convert.ToDouble(temp.Tables("Detalles").Rows(0).Item(3)), 2)
            Subtotaltxtbox.Text = subtotal
            Desctxtbx.Text = descuent
            Totaltxtbx.Text = subtotal - descuent
        Else
            MsgBox("No existe la Factura")
        End If

    End Sub
    Function Sumar(detalles As DataTable) As Double
        Dim Total As New Double
        For i As Integer = 0 To detalles.Rows.Count - 1
            Total = Total + detalles.Rows(i).Item(4)
        Next
        Return Total
    End Function
End Class