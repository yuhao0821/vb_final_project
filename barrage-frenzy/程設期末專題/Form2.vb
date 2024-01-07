Public Class Form2
    Dim currentImage As Integer = 1
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Form1.isMuted Then
            My.Computer.Audio.Play(My.Resources.GameMusic, AudioPlayMode.BackgroundLoop)
        End If
        PictureBox4.BackColor = Color.Transparent
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        '1 vs 1
        Form3.player_num = 2
        Form3.Show()
        Form3.Hide()
        Form4.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        '2 vs 2
        Form3.player_num = 4
        Form3.Show()
        Form3.Hide()
        Form5.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form1.Show()
        Me.Close()
    End Sub


    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If currentImage = 1 Then
            PictureBox4.Image = My.Resources.mute
            currentImage = 2
        Else
            PictureBox4.Image = My.Resources.music
            currentImage = 1
        End If

        Form1.isMuted = Not Form1.isMuted
        If Form1.isMuted Then
            My.Computer.Audio.Stop()
        Else
            My.Computer.Audio.Play(My.Resources.GameMusic, AudioPlayMode.BackgroundLoop)
        End If
    End Sub
End Class