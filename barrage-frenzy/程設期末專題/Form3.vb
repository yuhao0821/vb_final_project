Imports System.Drawing.Drawing2D
Imports System.Net.NetworkInformation
Imports System.Net.Security
Imports System.Reflection
Imports System.Windows.Forms.VisualStyles
Imports Microsoft

Public Class Form3

    Public player() As PictureBox
    Public player_name() As Label
    Public player_health_graph() As Label
    Public player_health() As Integer
    Dim face_direaction() As Boolean

    Public player_num As Integer
    Dim zero As Integer = 0
    Dim count As Integer = 0
    Dim check_count As Integer = -1
    Dim power As Integer = 0 '0~25
    Dim real_round As Integer = -1
    Dim round As Integer
    Dim pressing_time As Integer
    Dim temp As Integer
    Dim x As Integer



    Dim IsKeyPressing As Boolean = False
    Dim move_direaction As Boolean
    Dim airplane As Boolean
    Dim movable As Boolean

    Dim ground As New PictureBox
    Dim PictureBox_temp As PictureBox

    Dim maxX1 As Integer
    Dim minX1 As Integer
    Dim maxY1 As Integer
    Dim minY1 As Integer
    Dim maxX2 As Integer
    Dim minX2 As Integer
    Dim maxY2 As Integer
    Dim minY2 As Integer

    Public Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReDim player(player_num - 1)
        ReDim player_name(player_num - 1)
        ReDim player_health(player_num - 1)
        ReDim player_health_graph(player_num - 1)
        ReDim face_direaction(player_num - 1)

        For i As Integer = 0 To player_num - 1
            player(i) = New PictureBox
            player_name(i) = New Label
            player_health_graph(i) = New Label
            Me.Controls.Add(player(i))
            Me.Controls.Add(player_name(i))
            Me.Controls.Add(player_health_graph(i))
            If i Mod 2 = 0 Then
                player(i).Image = CType(My.Resources.ResourceManager.GetObject("藍_拿槍"), Image)
                player(i).Location = New Point(i * 100 + 50, 320)
                player_name(i).Location = New Point(player(i).Location.X, player(i).Location.Y - 30)
                player(i).Tag = 1
            Else
                player(i).Image = My.Resources.紅_拿槍
                player(i).Location = New Point(ClientSize.Width - (i) * 100, 320)
                player_name(i).Location = New Point(player(i).Location.X, player(i).Location.Y - 30)
                player(i).Tag = -1
            End If
            player(i).Width = 50
            player(i).Height = 50
            player(i).SizeMode = PictureBoxSizeMode.StretchImage

            player_name(i).AutoSize = True

            player_health_graph(i).Width = 50
            player_health_graph(i).Height = 13
            player_health_graph(i).Location = New Point(player(i).Location.X, player(i).Location.Y - 15)
            player_health_graph(i).Text = "100 / 100"

            player_health(i) = 100

            face_direaction(i) = player(i).Tag + 1

        Next i

        Me.Controls.Add(ground)
        ground.Image = My.Resources.土地
        ground.SizeMode = PictureBoxSizeMode.StretchImage
        ground.Location = New Point(0, 370)
        ground.Width = 800
        ground.Height = 80

        Initialization()

    End Sub

    Function GameBody()
        If count = 0 Then
            Initialization()
            If winning_check() Then
                If MsgBox("是否再來一局?", 4, "遊戲結束") = 6 Then
                    Form2.Show()
                    Me.Close()
                Else
                    Form1.Close()
                End If
            End If
        End If
        Return 0
    End Function

    Function Route(route_x As Integer, power As Integer) As Integer
        temp = 0
        While temp ^ 2 < (375 - power * 15) / 0.002
            temp += 1
        End While
        Dim route_y As Integer = (((route_x - temp) ^ 2) / 500) + (power * 15)
        Return route_y
    End Function
    '計算彈道的二次函數 輸入power以及x值 return y

    Function Initialization()
        count = 0
        check_count = 0
        fire_timer.Enabled = False
        airplane = False
        IsKeyPressing = False
        movable = True
        real_round += 1
        real_round = real_round Mod player_num
        If player_health(real_round) = 0 Then
            round = (real_round + 2) Mod player_num
        Else
            round = real_round
        End If
        For i As Integer = 0 To player_num - 1
            If player_health(i) <= zero Then
                player(i).Visible = False
                player_name(i).Visible = False
                player_health_graph(i).Visible = False
            End If
        Next

        x = 0
        pressing_time = 26
        bullet.Location = New Point(-1, -1)

        Return Nothing
    End Function


    Function Winning_check() As Boolean
        If player_num = 2 Then
            If player_health(0) = 0 Then
                MsgBox("red win")
                Return True
            ElseIf player_health(1) = 0 Then
                MsgBox("blue win")
                Return True
            End If
        ElseIf player_health(0) = 0 And player_health(2) = 0 Then
            MsgBox("red win")
            Return True
        ElseIf player_health(1) = 0 And player_health(3) = 0 Then
            MsgBox("blue win")
            Return True
        End If
        Return False
    End Function
    Function Bullet_check()
        maxX1 = bullet.Location.X + bullet.Width
        minX1 = bullet.Location.X
        maxY1 = bullet.Location.Y + bullet.Height
        minY1 = bullet.Location.Y

        For i As Integer = 0 To player_num - 1
            If i <> round Then
                PictureBox_temp = player(i)
                maxX2 = PictureBox_temp.Location.X + PictureBox_temp.Width
                minX2 = PictureBox_temp.Location.X
                maxY2 = PictureBox_temp.Location.Y + PictureBox_temp.Height
                minY2 = PictureBox_temp.Location.Y

                If maxX1 > minX2 And maxX2 > minX1 And maxY1 > minY2 And maxY2 > minY1 And player(round).Tag <> player(i).Tag And player_health(i) > 0 Then
                    If airplane Then
                        player(round).Location = New Point(bullet.Location.X, player(i).Location.Y)
                        player_name(round).Location = New Point(player(round).Location.X, player(round).Location.Y - 30)
                        player_health_graph(round).Location = New Point(player(round).Location.X, player(round).Location.Y - 15)
                    ElseIf player_health(i) > 0 Then
                        player_health(i) -= 25
                            player_health_graph(i).Text = player_health(i).ToString + " / 100"
                        End If

                        fire_timer.Enabled = False
                        GameBody()
                        check_count += 1
                        count += 1
                    End If

                    PictureBox_temp = ground
                maxX2 = PictureBox_temp.Location.X + PictureBox_temp.Width
                minX2 = PictureBox_temp.Location.X
                maxY2 = PictureBox_temp.Location.Y + PictureBox_temp.Height + 8
                minY2 = PictureBox_temp.Location.Y
                If maxX1 > minX2 And maxX2 > minX1 And maxY1 > minY2 And maxY2 > minY1 Then
                    If airplane Then
                        player(round).Location = New Point(bullet.Location.X, ground.Location.Y - 50)
                        player_name(round).Location = New Point(player(round).Location.X, player(round).Location.Y - 30)
                        player_health_graph(round).Location = New Point(player(round).Location.X, player(round).Location.Y - 15)
                    End If
                    fire_timer.Enabled = False
                    GameBody()
                        check_count += 1
                        count += 1

                End If
            End If
        Next i
        If bullet.Location.X > 800 OrElse bullet.Location.X < 0 OrElse bullet.Location.Y > 400 OrElse bullet.Location.Y < 0 Then
            fire_timer.Enabled = False
            GameBody()
            count += 1
        End If
        Return Nothing
    End Function
    '射擊處理
    Private Sub Fire_timer_Tick(sender As Object, e As EventArgs) Handles fire_timer.Tick
        'If round Mod 2 Then
        If face_direaction(round) Then
            bullet.Location = New Point(player(round).Location.X + 33 + x, Route(x, pressing_time) - player(round).Height)
            x += 5
        Else
            bullet.Location = New Point(player(round).Location.X - 33 - x, Route(x, pressing_time) - player(round).Height)
            x += 5
        End If
        If check_count Mod 5 = 0 Then
            Bullet_check()
        End If
        check_count += 1
    End Sub


    Private Sub Move_timer_Tick(sender As Object, e As EventArgs) Handles move_timer.Tick
        If move_direaction Then
            player(round).Location = New Point(player(round).Location.X + 3, player(round).Location.Y)
            player_name(round).Location = New Point(player_name(round).Location.X + 3, player_name(round).Location.Y)
            player_health_graph(round).Location = New Point(player_health_graph(round).Location.X + 3, player_health_graph(round).Location.Y)
        Else
            player(round).Location = New Point(player(round).Location.X - 3, player(round).Location.Y)
            player_name(round).Location = New Point(player_name(round).Location.X - 3, player_name(round).Location.Y)
            player_health_graph(round).Location = New Point(player_health_graph(round).Location.X - 3, player_health_graph(round).Location.Y)
        End If
    End Sub

    Private Sub Counting_Timer_Tick(sender As Object, e As EventArgs) Handles Counting_Timer.Tick
        If pressing_time > 0 And movable Then
            pressing_time -= 1
        End If
        Label1.Text = pressing_time
    End Sub

    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = 37 Then '左
            move_direaction = False
            IsKeyPressing = True
            If movable Then
                face_direaction(round) = False
                If player(round).Tag = 1 Then
                    player(round).Image = My.Resources.藍_拿槍_翻轉
                Else
                    player(round).Image = My.Resources.紅_拿槍
                End If
                move_timer.Start()
            End If


        ElseIf e.KeyCode = 39 Then '右
            move_direaction = True
            IsKeyPressing = True
            If movable Then
                face_direaction(round) = True
                If player(round).Tag = 1 Then
                    player(round).Image = My.Resources.藍_拿槍
                Else
                    player(round).Image = My.Resources.紅_拿槍_翻轉
                End If
                move_timer.Start()
            End If
        End If

        If e.KeyCode = 32 Then '空白鍵
            Counting_Timer.Start()
            IsKeyPressing = True
        End If

    End Sub

    Private Sub Form3_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = 37 Then '左
            IsKeyPressing = False
            move_timer.Stop()

        ElseIf e.KeyCode = 39 Then '右
            IsKeyPressing = False
            move_timer.Stop()

        End If

        If e.KeyCode = 32 Then '空白鍵
            IsKeyPressing = False
            power = pressing_time
            Counting_Timer.Stop()
            move_timer.Stop()
            count = 0
            check_count = 0
            fire_timer.Enabled = True
            movable = False
        End If

    End Sub
    Private Sub airplane_Button_Click(sender As Object, e As EventArgs) Handles airplane_Button.Click
        If movable Then
            airplane = True
        End If
    End Sub


End Class