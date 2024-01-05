Public Class Form8
    Dim rand As New Random()
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form6.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Form7.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim randomNumber As Integer = rand.Next(1, 4) ' 生成 1 到 3 之間的隨機數

        ' 根據隨機數顯示對應的地圖Form
        Select Case randomNumber
            Case 1
                Form3.Show()
                Me.Close()
            Case 2
                Form6.Show()
                Me.Close()
            Case 3
                Form7.Show()
                Me.Close()
        End Select
    End Sub

    Private isMuted As Boolean = False
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        isMuted = Not isMuted

        If isMuted Then
            My.Computer.Audio.Stop()
        Else
            Dim soundFilePath As String = "D:\music\遊戲音樂.wav"
            ' 循环播放音效
            My.Computer.Audio.Play(soundFilePath, AudioPlayMode.BackgroundLoop)
        End If
    End Sub
End Class