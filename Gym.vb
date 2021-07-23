Imports System.Data.SqlClient
Public Class gymbokuform
    Public cn As New SqlConnection
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
        Catch ex As Exception
            MsgBox("No se pudo establecer conexion con la base de datos")
        End Try
    End Sub
End Class
