Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form3.player_name(0).Text = TextBox1.Text
        Form3.player_name(1).Text = TextBox2.Text
        Form3.player_name(2).Text = TextBox3.Text
        Form3.player_name(3).Text = TextBox4.Text

        Form3.Show()
        Me.Close()
    End Sub
End Class