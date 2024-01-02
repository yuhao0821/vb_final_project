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
    Dim scenes() As PictureBox
    Dim scene_num As Integer = 28

    Public player_num As Integer
    Dim zero As Integer = 0
    Dim count As Integer = 0
    Dim check_count As Integer = -1
    Dim power As Integer = 0 '0~25
    Dim real_round As Integer = -1
    Dim round As Integer
    Dim pressing_time As Integer
    Dim pressing_counter As Integer
    Dim temp As Integer
    Dim jump_counter As Integer = 0
    Dim jumping_player As Integer
    Dim y As Integer
    Dim x As Integer




    Dim IsKeyPressing As Boolean = False
    Dim move_direaction As Boolean
    Dim airplane As Boolean
    Dim movable As Boolean
    Dim jumping As Boolean


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
            player(i).BackColor = Color.Transparent
            player(i).SizeMode = PictureBoxSizeMode.StretchImage

            player_name(i).AutoSize = True

            player_health_graph(i).Width = 50
            player_health_graph(i).Height = 13
            player_health_graph(i).Location = New Point(player(i).Location.X, player(i).Location.Y - 15)
            player_health_graph(i).Text = "100 / 100"

            player_health(i) = 100

            face_direaction(i) = player(i).Tag + 1

        Next i

        Scenes_create()
        Me.Controls.Add(ground)
        ground.Image = My.Resources.土地
        ground.SizeMode = PictureBoxSizeMode.StretchImage
        ground.Location = New Point(0, 370)
        ground.Width = 800
        ground.Height = 80

        Initialization()

    End Sub
    Sub Scenes_create()
        ReDim scenes(scene_num)
        While temp < scene_num
            scenes(temp) = New PictureBox
            If temp < 4 Then '第一層空島
                scenes(temp).Location = New Point(35 * (temp Mod 4) + 30, 60)
            ElseIf temp < 8 Then
                scenes(temp).Location = New Point(35 * (temp Mod 4) + 230, 60)
            ElseIf temp < 12 Then
                scenes(temp).Location = New Point(35 * (temp Mod 4) + 430, 60)
            ElseIf temp < 16 Then
                scenes(temp).Location = New Point(35 * (temp Mod 4) + 630, 60)
            ElseIf temp < 20 Then '第二層空島
                scenes(temp).Location = New Point(35 * (temp Mod 4) + 30, 200)
            ElseIf temp < 24 Then
                scenes(temp).Location = New Point(35 * (temp Mod 4) + 330, 200)
            ElseIf temp < 28 Then
                scenes(temp).Location = New Point(35 * (temp Mod 4) + 630, 200)
            End If
            scenes(temp).Size = New Size(35, 60)
            scenes(temp).SizeMode = PictureBoxSizeMode.StretchImage
            Select Case temp Mod 4
                Case 0
                    scenes(temp).Image = My.Resources.空島1
                Case 1
                    scenes(temp).Image = My.Resources.空島2
                Case 2
                    scenes(temp).Image = My.Resources.空島3
                Case 3
                    scenes(temp).Image = My.Resources.空島4
            End Select
            scenes(temp).BackColor = Color.Transparent
            Me.Controls.Add(scenes(temp))
            temp += 1
        End While

    End Sub
    Function GameBody()
        If count = 0 Then
            Initialization()
            If Winning_check() Then
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
        pressing_counter = 0
        fire_timer.Enabled = False
        show_power.Size = New Size(0, 10)
        show_power.BackColor = Color.Transparent
        show_power.Location = New Point(85.2)
        jumping = False
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
        'MsgBox(bullet.Location.X.ToString + " , " + bullet.Location.Y.ToString)
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
                        player(round).Location = New Point(bullet.Location.X, PictureBox_temp.Location.Y - 50)
                        player_name(round).Location = New Point(player(round).Location.X, player(round).Location.Y - 30)
                        player_health_graph(round).Location = New Point(player(round).Location.X, player(round).Location.Y - 15)
                    End If
                    fire_timer.Enabled = False
                    GameBody()
                    check_count += 1
                    count += 1

                End If
                For j As Integer = 0 To scene_num - 1
                    PictureBox_temp = scenes(j)
                    maxX2 = PictureBox_temp.Location.X + PictureBox_temp.Width
                    minX2 = PictureBox_temp.Location.X
                    'maxY2 = PictureBox_temp.Location.Y + PictureBox_temp.Height + 8
                    maxY2 = PictureBox_temp.Location.Y + 15
                    minY2 = PictureBox_temp.Location.Y
                    If maxX1 > minX2 And maxX2 > minX1 And maxY1 > minY2 And maxY2 > minY1 And y < bullet.Location.Y Then
                        If airplane Then
                            player(round).Location = New Point(bullet.Location.X, PictureBox_temp.Location.Y - 45)
                            player_name(round).Location = New Point(player(round).Location.X, player(round).Location.Y - 30)
                            player_health_graph(round).Location = New Point(player(round).Location.X, player(round).Location.Y - 15)
                        End If
                        fire_timer.Enabled = False
                        GameBody()
                        check_count += 1
                        count += 1

                    End If
                Next j
            End If
        Next i
        If bullet.Location.X > 800 OrElse bullet.Location.X < 0 OrElse bullet.Location.Y > 400 OrElse bullet.Location.Y < -150 Then
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
            bullet.Location = New Point(player(round).Location.X + 25 + x, Route(x, pressing_time) - player(round).Height - (320 - player(round).Location.Y))
            x += 5
        Else
            bullet.Location = New Point(player(round).Location.X + 25 - x, Route(x, pressing_time) - player(round).Height - (320 - player(round).Location.Y))
            x += 5
        End If
        If check_count Mod 5 = 0 Then
            Bullet_check()
        End If
        check_count += 1
        y = bullet.Location.Y
    End Sub


    Private Sub Move_timer_Tick(sender As Object, e As EventArgs) Handles move_timer.Tick
        If move_direaction Then
            player(round).Location = New Point(player(round).Location.X + 8, player(round).Location.Y)
            player_name(round).Location = New Point(player_name(round).Location.X + 8, player_name(round).Location.Y)
            player_health_graph(round).Location = New Point(player_health_graph(round).Location.X + 8, player_health_graph(round).Location.Y)
        Else
            player(round).Location = New Point(player(round).Location.X - 8, player(round).Location.Y)
            player_name(round).Location = New Point(player_name(round).Location.X - 8, player_name(round).Location.Y)
            player_health_graph(round).Location = New Point(player_health_graph(round).Location.X - 8, player_health_graph(round).Location.Y)
        End If
    End Sub

    Private Sub Counting_Timer_Tick(sender As Object, e As EventArgs) Handles Counting_Timer.Tick
        If pressing_time > 0 And movable Then
            If pressing_time >= 20 Then
                If pressing_counter Mod 3 = 0 Then
                    pressing_time -= 1
                End If
            ElseIf pressing_time >= 15 Then
                If pressing_counter Mod 2 = 0 Then
                    pressing_time -= 1
                End If
            Else
                pressing_time -= 1
            End If
        End If
            If pressing_counter < 100 Then
            pressing_counter += 1
        End If
        show_power.Size = New Size((26 - pressing_time) * 25, 10)
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

        If e.KeyCode = 38 And jumping = False Then '上 跳
            If movable And jumping = False Then
                jumping_player = round
                jump_counter = 0
                jump_Timer.Start()
                jumping = True
            End If
        End If

        If e.KeyCode = 32 Then '空白鍵
            Counting_Timer.Start()
            show_power.BackColor = Color.OrangeRed
            IsKeyPressing = True
        End If
        If e.KeyCode = 65 Then 'a 紙飛機
            airplane_Button_Click(airplane_Button, New EventArgs)
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

    Private Sub jump_timer_Tick(sender As Object, e As EventArgs) Handles jump_timer.Tick

        If jump_counter < 8 Then
            player(jumping_player).Location = New Point(player(jumping_player).Location.X, player(jumping_player).Location.Y - 8)
            player_name(jumping_player).Location = New Point(player_name(jumping_player).Location.X, player_name(jumping_player).Location.Y - 8)
            player_health_graph(jumping_player).Location = New Point(player_health_graph(jumping_player).Location.X, player_health_graph(jumping_player).Location.Y - 8)
        ElseIf jump_counter < 16 Then
            player(jumping_player).Location = New Point(player(jumping_player).Location.X, player(jumping_player).Location.Y + 8)
            player_name(jumping_player).Location = New Point(player_name(jumping_player).Location.X, player_name(jumping_player).Location.Y + 8)
            player_health_graph(jumping_player).Location = New Point(player_health_graph(jumping_player).Location.X, player_health_graph(jumping_player).Location.Y + 8)
        Else
            jump_counter = 0
            jump_timer.Stop()
            jumping = False
        End If
        jump_counter += 1
    End Sub

    Public Sub Form3_close(sender As Object, e As EventArgs) Handles MyBase.Closed
        Form1.Close()

    End Sub
End Class