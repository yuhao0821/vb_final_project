<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.fire_timer = New System.Windows.Forms.Timer(Me.components)
        Me.aim_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.global_timer = New System.Windows.Forms.Timer(Me.components)
        Me.move_timer = New System.Windows.Forms.Timer(Me.components)
        Me.Counting_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.check_timer = New System.Windows.Forms.Timer(Me.components)
        Me.bullet = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.airplane_Button = New System.Windows.Forms.Label()
        Me.jump_Timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.bullet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fire_timer
        '
        Me.fire_timer.Interval = 30
        '
        'move_timer
        '
        Me.move_timer.Interval = 50
        '
        'Counting_Timer
        '
        '
        'check_timer
        '
        Me.check_timer.Interval = 200
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
        Me.Label1.Location = New System.Drawing.Point(393, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'airplane_Button
        '
        Me.airplane_Button.AutoSize = True
        Me.airplane_Button.Location = New System.Drawing.Point(336, 108)
        Me.airplane_Button.Name = "airplane_Button"
        Me.airplane_Button.Size = New System.Drawing.Size(41, 12)
        Me.airplane_Button.TabIndex = 4
        Me.airplane_Button.Text = "紙飛機"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.程設期末專題.My.Resources.Resources.背景
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.airplane_Button)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bullet)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.bullet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fire_timer As Timer
    Friend WithEvents aim_Timer As Timer
    Friend WithEvents global_timer As Timer
    Friend WithEvents move_timer As Timer
    Friend WithEvents Counting_Timer As Timer
    Friend WithEvents check_timer As Timer
    Friend WithEvents bullet As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents airplane_Button As Label
    Friend WithEvents jump_Timer As Timer
End Class
