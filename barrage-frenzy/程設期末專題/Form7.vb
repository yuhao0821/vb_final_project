Public Class Form7
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form3.player_num = 2 Then
            Me.BackgroundImage = My.Resources.結算1v1
            Me.BackgroundImageLayout = ImageLayout.Stretch
            'Dim player_name1 As Label = Label1
            'Dim player_name2 As Label = Label1
            'player_name1.Location = New Point(Label1.Location.X + 200, Label1.Location.Y)
            'player_name2.Location = New Point(Label1.Location.X + 400, Label1.Location.Y)
            'player_name1.Text = Form3.player_name(0).Text
            'player_name1.Text = Form3.player_name(1).Text

        Else
            Me.BackgroundImage = My.Resources.結算2v2
            Me.BackgroundImageLayout = ImageLayout.Stretch
        End If
    End Sub
End Class