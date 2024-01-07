<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.操作說明 = New System.Windows.Forms.Label()
        Me.back = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        '操作說明
        '
        Me.操作說明.AutoSize = True
        Me.操作說明.BackColor = System.Drawing.Color.Transparent
        Me.操作說明.Font = New System.Drawing.Font("標楷體", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.操作說明.Location = New System.Drawing.Point(290, 31)
        Me.操作說明.Name = "操作說明"
        Me.操作說明.Size = New System.Drawing.Size(216, 48)
        Me.操作說明.TabIndex = 0
        Me.操作說明.Text = "操作說明"
        '
        'back
        '
        Me.back.Font = New System.Drawing.Font("標楷體", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.back.Location = New System.Drawing.Point(605, 358)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(128, 47)
        Me.back.TabIndex = 1
        Me.back.Text = "返回"
        Me.back.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(219, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "方向鍵"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(300, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 30)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "→往右移動"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(88, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 30)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "往左移動← "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(232, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 60)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "跳躍" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  ↑ " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 273)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(278, 31)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "常按空白鍵蓄力發射子彈"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(490, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(243, 93)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "按a可使用道具紙飛機" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "可傳送到子彈的落點" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "每局限用三次"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.Location = New System.Drawing.Point(105, 358)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(494, 62)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "本遊戲卡頓程度較高，若遇移動時畫面卡住，" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "方向鍵不放，點一下↓即可恢復"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.操作說明)
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents 操作說明 As Label
    Friend WithEvents back As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
