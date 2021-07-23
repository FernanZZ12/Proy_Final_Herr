Imports System.Data.SqlClient
Public Class gymbokuform
    Public cn As New SqlConnection
    Dim detalles As New DataTable
    Private Sub ClientesItem_Click(sender As Object, e As EventArgs) Handles ClientesItem.Click
        Clientes.Show()
    End Sub

    Private Sub SuscripcionesItem_Click(sender As Object, e As EventArgs) Handles SuscripcionesItem.Click
        Suscripciones.Show()
    End Sub

    Private Sub ProductosItem_Click(sender As Object, e As EventArgs) Handles ProductosItem.Click
        Productos.Show()
    End Sub

    Private Sub EntrenadoresItem_Click(sender As Object, e As EventArgs) Handles EntrenadoresItem.Click
        Entrenadores.Show()
    End Sub

    Private Sub gymbokuform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim conexion As String
            conexion = "Server=tcp:bdfinal.database.windows.net,1433;Initial Catalog=Gimnasio;Persist Security Info=False;User ID=fadmin;Password=71188416Zh@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
            cn.ConnectionString = conexion
            cn.Open()
            With detalles
                .Columns.Add("ID_Producto", System.Type.GetType("System.String"))
                .Columns.Add("Descripcion", System.Type.GetType("System.String"))
                .Columns.Add("Cantidad", System.Type.GetType("System.Single"))
                .Columns.Add("Precio", System.Type.GetType("System.Double"))
                .Columns.Add("Subtotal", System.Type.GetType("System.Double"))
            End With
        Catch ex As Exception
            MsgBox("No se pudo establecer conexion con la base de datos")
        End Try
    End Sub

    Private Sub Agregarbttn_Click(sender As Object, e As EventArgs) Handles Agregarbttn.Click
        If (Idusutxtbx.Text.Trim = "") Then
            MsgBox("No puede dejar el ID de Usuario en blanco")
        ElseIf (Cantidadtxtbx.Text.Trim = "" Or Cantidadtxtbx.Text = "0" And CodProtxtbx.Text.Trim = "") Then
            MsgBox("Error en datos suministrados para ingresar productos")
        Else
            Try
                If (Idusutxtbx.Text.Trim = "") Then
                    MsgBox("No puede dejar el ID de Usuario en blanco")
                ElseIf (Cantidadtxtbx.Text.Trim = "" Or Cantidadtxtbx.Text = "0" And CodProtxtbx.Text.Trim = "") Then
                    MsgBox("Error en datos suministrados para ingresar productos")
                Else
                    Dim temp As New DataSet
                    Dim adaptador As New SqlDataAdapter("Select ID_Producto,
                                                                Descripcion,
                                                                Precio
                                                         from Producto where ID_Producto = '" & CodProtxtbx.Text & "'", cn)
                    adaptador.Fill(temp, "Producto")
                    Dim newrow As DataRow = detalles.NewRow
                    newrow("ID_Producto") = temp.Tables("Producto").Rows(0).Item(0)
                    newrow("Descripcion") = temp.Tables("Producto").Rows(0).Item(1)
                    newrow("Cantidad") = Convert.ToSingle(Cantidadtxtbx.Text.ToString)
                    newrow("Precio") = temp.Tables("Producto").Rows(0).Item(2)
                    newrow("Subtotal") = Math.Round(Convert.ToSingle(Cantidadtxtbx.Text.ToString) * temp.Tables("Producto").Rows(0).Item(2), 2)
                    detalles.Rows.Add(newrow)

                    Dim adaptador2 As New SqlDataAdapter("select u.ID_Usuario,
                                                                u.Nombre as Nombre_de_Usuario,
                                                                s.Nombre_Suscripcion as Suscripcion,
                                                                s.Descuento as Descuento_por_Suscripcion
                                                         from Usuario u inner join Suscripcion s on u.ID_Suscripcion = s.ID_Suscripcion
                                                         where u.ID_Usuario = '" & Idusutxtbx.Text & "'", cn)
                    adaptador2.Fill(temp, "Usuario")
                    Dim Subtotal As Double = Sumar()
                    Dim Descuento As Double = Math.Round(Subtotal * Convert.ToDouble(temp.Tables("Usuario").Rows(0).Item(3)), 2)
                    Subtotaltxtbox.Text = Subtotal
                    Desctxtbx.Text = Descuento
                    Totaltxtbx.Text = Subtotal - Descuento
                    Cantidadtxtbx.Text = 1
                    CodProtxtbx.Text = ""
                    FacturaDGV.DataSource = detalles
                End If
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
    End Sub

    Function Sumar() As Double
        Dim Total As New Double
        For i As Integer = 0 To detalles.Rows.Count - 1
            Total = Total + detalles.Rows(i).Item(4)
        Next
        Return Total
    End Function
End Class
