﻿Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim soundFilePath As String = "D:\music\遊戲音樂.wav"
        ' 播放音效
        My.Computer.Audio.Play(soundFilePath, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form3.player_name(0).Text = TextBox1.Text
        Form3.player_name(1).Text = TextBox2.Text
        Form3.player_name(2).Text = TextBox3.Text
        Form3.player_name(3).Text = TextBox4.Text

        Form8.Show()
        Me.Close()
    End Sub

    Private isMuted As Boolean = False
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
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