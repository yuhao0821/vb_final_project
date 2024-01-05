Public Class Form1
    Private Sub Game_start(sender As Object, e As EventArgs) Handles start.Click
        Form2.Show()
        Me.Hide()

    End Sub
    Private Sub Game_over(sender As Object, e As EventArgs) Handles over.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.GameMusic, AudioPlayMode.BackgroundLoop)
    End Sub

    Private isMuted As Boolean = False
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        isMuted = Not isMuted

        If isMuted Then
            My.Computer.Audio.Stop()
        Else
            My.Computer.Audio.Play(My.Resources.GameMusic, AudioPlayMode.BackgroundLoop)
        End If
    End Sub
End Class
