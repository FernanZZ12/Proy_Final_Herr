Imports System.Data.SqlClient
Public Class gymbokuform
    Public cn As New SqlConnection
    Dim detalles As New DataTable

    'Al presionar el menustrip de Clientes se muestra la pantalla de Clientes'
    Private Sub ClientesItem_Click(sender As Object, e As EventArgs) Handles ClientesItem.Click
        Clientes.Show()
    End Sub

    'Al presionar el menustrip de Suscripciones se muestra la pantalla de Suscripciones'
    Private Sub SuscripcionesItem_Click(sender As Object, e As EventArgs) Handles SuscripcionesItem.Click
        Suscripciones.Show()
    End Sub

    'Al presionar el menustrip de Productos se muestra la pantalla de Productos'
    Private Sub ProductosItem_Click(sender As Object, e As EventArgs) Handles ProductosItem.Click
        Productos.Show()
    End Sub

    'Al presionar el menustrip de Entrenadores se muestra la pantalla de Entrenadores'
    Private Sub EntrenadoresItem_Click(sender As Object, e As EventArgs) Handles EntrenadoresItem.Click
        Entrenadores.Show()
    End Sub


    'Al iniciar la aplicacion se establece la conexion con la base de datos y se crea el datable para guardar'
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
            Cantidadtxtbx.Text = 1
            Dim temp As New DataSet
            Dim adaptador As New SqlDataAdapter("Select *
                                                 from Factura", cn)
            adaptador.Fill(temp, "Facturas")
            numlbl.Text = temp.Tables("Facturas").Rows.Count + 1
        Catch ex As Exception
            MsgBox("No se pudo establecer conexion con la base de datos")
        End Try
    End Sub

    'Se valida todos los paramentros necesario para agregar el producto a la table detalles'
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
                    If verifica() Then
                        Dim temp As New DataSet
                        Dim adaptador2 As New SqlDataAdapter("select u.ID_Usuario,
                                                                u.Nombre as Nombre_de_Usuario,
                                                                s.Nombre_Suscripcion as Suscripcion,
                                                                s.Descuento as Descuento_por_Suscripcion
                                                         from Usuario u inner join Suscripcion s on u.ID_Suscripcion = s.ID_Suscripcion
                                                         where u.ID_Usuario = '" & Idusutxtbx.Text & "'", cn)
                        adaptador2.Fill(temp, "Usuario")
                        If temp.Tables("Usuario").Rows.Count > 0 Then
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

                            Dim Subtotal As Double = Sumar()
                            Dim Descuento As Double = Math.Round(Subtotal * Convert.ToDouble(temp.Tables("Usuario").Rows(0).Item(3)), 2)
                            Subtotaltxtbox.Text = Subtotal
                            Desctxtbx.Text = Descuento
                            Totaltxtbx.Text = Subtotal - Descuento
                            Cantidadtxtbx.Text = 1
                            CodProtxtbx.Text = ""
                            FacturaDGV.DataSource = detalles
                        Else
                            MsgBox("El Cliente no existe")
                        End If
                    Else
                        MsgBox("No puede pagar mas de 1 suscripcion")
                    End If

                End If
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
    End Sub

    'una funcion el cual realiza sumas de la tabla detalle'
    Function Sumar() As Double
        Dim Total As New Double
        For i As Integer = 0 To detalles.Rows.Count - 1
            Total = Total + detalles.Rows(i).Item(4)
        Next
        Return Total
    End Function

    'funcion en el cual verificamos si el usuario esta comprando mas de una suscripcion'
    Function verifica() As Boolean
        Dim temp As New DataSet
        Dim adaptador2 As New SqlDataAdapter("select *
                                                From Producto
                                                where ID_Categoria = 'C02'", cn)
        adaptador2.Fill(temp, "Producto")
        For i As Integer = 0 To detalles.Rows.Count - 1
            For k As Integer = 0 To temp.Tables("Producto").Rows.Count - 1
                If (detalles.Rows(i).Item(0) = temp.Tables("Producto").Rows(k).Item(0)) Then
                    Return False
                End If
            Next
        Next
        Return True
    End Function

    'boton para agregar la factura a la base de datos validando tambien los parametros llenados'
    Private Sub AgregFactbttn_Click(sender As Object, e As EventArgs) Handles AgregFactbttn.Click
        If detalles.Rows.Count > 0 Then
            Dim temp As New DataSet
            If verifica() = False Then
                Dim adaptador4 As New SqlDataAdapter("select *
                                                         from Usuario
                                                         where ID_Usuario = '" & Idusutxtbx.Text & "'", cn)
                adaptador4.Fill(temp, "Usuarios")
                If (Convert.ToString(temp.Tables("Usuarios").Rows(0).Item(4)) = "1900-01-01") Then
                    Dim fecha As Date = System.DateTime.Now

                    Dim adaptador5 As New SqlCommand("update Usuario set Fecha_Expira ='" & fecha.AddMonths(1).ToString(" yyyy/MM/dd") & "' Where ID_Usuario = '" & Idusutxtbx.Text & "'", cn)
                    adaptador5.ExecuteNonQuery()
                Else
                    Dim fecha As Date = System.DateTime.Now
                    fecha.AddMonths(1)
                    Dim adaptador5 As New SqlCommand("update Usuario set Fecha_Expira ='" & fecha.AddMonths(1).ToString(" yyyy/MM/dd") & "' Where ID_Usuario = '" & Idusutxtbx.Text & "'", cn)
                    adaptador5.ExecuteNonQuery()
                End If
            End If
            Dim adaptador As New SqlCommand("insert into Factura values('" & numlbl.Text & "','" & Idusutxtbx.Text & "','" & System.DateTime.Now.ToString((" yyyy/MM/dd")) & "')", cn)
            adaptador.ExecuteNonQuery()

            For i As Integer = 0 To detalles.Rows.Count - 1
                Dim adaptador3 As New SqlCommand("insert into Detalle values('" & numlbl.Text & "','" & detalles.Rows(i).Item(0) & "','" & detalles.Rows(i).Item(2) & "','" & detalles.Rows(i).Item(3) & "','" & Convert.ToDouble(Desctxtbx.Text.ToString) / Convert.ToDouble(Subtotaltxtbox.Text.ToString) & "')", cn)
                adaptador3.ExecuteNonQuery()
            Next

            Dim adaptador2 As New SqlDataAdapter("Select *
                                                 from Factura", cn)
            adaptador2.Fill(temp, "Facturas")
            numlbl.Text = temp.Tables("Facturas").Rows.Count + 1

            Idusutxtbx.Text = ""
            detalles.Clear()
            FacturaDGV.DataSource = detalles
            Subtotaltxtbox.Text = ""
            Desctxtbx.Text = ""
            Totaltxtbx.Text = ""
        Else
            MsgBox("No hay factura para ingresar")
        End If
    End Sub

    'menustrip en donde muestra la pantalla de facturas'
    Private Sub FacturaItem_Click(sender As Object, e As EventArgs) Handles FacturaItem.Click
        Facturas.Show()
    End Sub

    'menustrip que al ser presionado muestra el planteamiento del problema'
    Private Sub PlanteamientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanteamientoToolStripMenuItem.Click
        Form10.Show()
    End Sub

    'menustrip que al ser presionado muestra la presentacion del grupo'
    Private Sub PresentacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PresentacionToolStripMenuItem.Click
        Form9.Show()
    End Sub
End Class
