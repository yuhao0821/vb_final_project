Public Class Form4

    Dim player_name() As TextBox
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReDim player_name(Form3.player_num - 1)
        For i As Integer = 0 To Form3.player_num - 1
            player_name(i) = New TextBox
            player_name(i).Text = "Player" + (i + 1).ToString
            If i Mod 2 Then
                player_name(i).Location = New Point(25, (i - 1) * 25 + 100)

            Else
                player_name(i).Location = New Point(25, i * 25 + 200)
            End If
            Me.Controls.Add(player_name(i))
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i As Integer = 0 To Form3.player_num - 1
            Form3.player_name(i).Text = player_name(i).Text
        Next
        Form3.Show()
        Me.Close()
    End Sub
End Class