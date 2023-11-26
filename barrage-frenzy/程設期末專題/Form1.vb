Public Class Form1
    Private Sub Game_start(sender As Object, e As EventArgs) Handles start.Click
        Form2.Show()
        Me.Hide()

    End Sub



    Private Sub Game_over(sender As Object, e As EventArgs) Handles over.Click
        Me.Close()
    End Sub


End Class
