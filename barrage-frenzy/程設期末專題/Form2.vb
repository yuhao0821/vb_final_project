Public Class Form2
    '單機表單
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '1 vs 1
        Form3.player_num = 2
        Form3.Show()
        Form3.Hide()
        Form4.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '2 vs 2
        Form3.player_num = 4
        Form3.Show()
        Form3.Hide()
        Form4.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Close()

    End Sub
End Class