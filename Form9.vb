Public Class Form9
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PClbl.Text = Environ("COMPUTERNAME")
        Userlbl.Text = Environ("USERNAME")
    End Sub

    Private Sub Sigbtn_Click(sender As Object, e As EventArgs) Handles Sigbtn.Click
        Me.Hide()
        gymbokuform.Show()
    End Sub
End Class