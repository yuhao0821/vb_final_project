Public Class Form4
    Dim currentImage As Integer = 1
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Form1.isMuted Then
            My.Computer.Audio.Play(My.Resources.GameMusic, AudioPlayMode.BackgroundLoop)
        End If
        PictureBox1.BackColor = Color.Transparent
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form3.player_name(0).Text = TextBox1.Text
        Form3.player_name(1).Text = TextBox2.Text

        Form8.Show()
        Me.Close()
    End Sub

    Private isMuted As Boolean = False
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If currentImage = 1 Then
            PictureBox1.Image = My.Resources.mute
            currentImage = 2
        Else
            PictureBox1.Image = My.Resources.music
            currentImage = 1
        End If

        isMuted = Not isMuted

        If isMuted Then
            My.Computer.Audio.Stop()
        Else
            My.Computer.Audio.Play(My.Resources.GameMusic, AudioPlayMode.BackgroundLoop)
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form2.Show()
        Me.Close()
    End Sub
End Class