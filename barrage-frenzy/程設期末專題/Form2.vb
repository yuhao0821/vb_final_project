﻿Public Class Form2
    '單機表單
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        Form4.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form1.Show()
        Me.Close()
    End Sub

End Class