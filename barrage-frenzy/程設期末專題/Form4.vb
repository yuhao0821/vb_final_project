Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form3.player_name(0).Text = TextBox1.Text
        Form3.player_name(1).Text = TextBox2.Text

        Form8.Show()
        Me.Close()
    End Sub
End Class