﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.global_timer = New System.Windows.Forms.Timer(Me.components)
        Me.bullet = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.airplane_label = New System.Windows.Forms.Label()
        Me.show_power = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.now_player = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.fire_timer = New System.Windows.Forms.Timer(Me.components)
        Me.airplane_picturebox = New System.Windows.Forms.PictureBox()
        CType(Me.bullet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.show_power, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.now_player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.airplane_picturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'global_timer
        '
        '
        'bullet
        '
        Me.bullet.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bullet.Location = New System.Drawing.Point(-1, -1)
        Me.bullet.Name = "bullet"
        Me.bullet.Size = New System.Drawing.Size(8, 8)
        Me.bullet.TabIndex = 1
        Me.bullet.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'airplane_label
        '
        Me.airplane_label.BackColor = System.Drawing.Color.Transparent
        Me.airplane_label.Location = New System.Drawing.Point(747, 181)
        Me.airplane_label.Name = "airplane_label"
        Me.airplane_label.Size = New System.Drawing.Size(42, 25)
        Me.airplane_label.TabIndex = 4
        Me.airplane_label.Text = "紙飛機"
        Me.airplane_label.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'show_power
        '
        Me.show_power.BackColor = System.Drawing.Color.Transparent
        Me.show_power.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.show_power.Location = New System.Drawing.Point(130, 400)
        Me.show_power.Name = "show_power"
        Me.show_power.Size = New System.Drawing.Size(1, 20)
        Me.show_power.TabIndex = 5
        Me.show_power.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, -1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "power"
        '
        'now_player
        '
        Me.now_player.BackColor = System.Drawing.Color.Transparent
        Me.now_player.Enabled = False
        Me.now_player.Image = CType(resources.GetObject("now_player.Image"), System.Drawing.Image)
        Me.now_player.Location = New System.Drawing.Point(-1, -1)
        Me.now_player.Margin = New System.Windows.Forms.Padding(2)
        Me.now_player.Name = "now_player"
        Me.now_player.Size = New System.Drawing.Size(22, 24)
        Me.now_player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.now_player.TabIndex = 7
        Me.now_player.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 11)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'fire_timer
        '
        Me.fire_timer.Interval = 30
        '
        'airplane_picturebox
        '
        Me.airplane_picturebox.BackColor = System.Drawing.Color.Transparent
        Me.airplane_picturebox.Image = CType(resources.GetObject("airplane_picturebox.Image"), System.Drawing.Image)
        Me.airplane_picturebox.Location = New System.Drawing.Point(749, 128)
        Me.airplane_picturebox.Name = "airplane_picturebox"
        Me.airplane_picturebox.Size = New System.Drawing.Size(50, 50)
        Me.airplane_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.airplane_picturebox.TabIndex = 11
        Me.airplane_picturebox.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.airplane_picturebox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.now_player)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.show_power)
        Me.Controls.Add(Me.airplane_label)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bullet)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.bullet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.show_power, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.now_player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.airplane_picturebox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bullet As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents airplane_label As Label
    Friend WithEvents show_power As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents now_player As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents fire_timer As Timer
    Friend WithEvents airplane_picturebox As PictureBox
    Friend WithEvents global_timer As Timer
End Class
