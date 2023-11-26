<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.over = New System.Windows.Forms.Button()
        Me.start = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'over
        '
        Me.over.AutoSize = True
        Me.over.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.over.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.over.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.over.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.over.Image = CType(resources.GetObject("over.Image"), System.Drawing.Image)
        Me.over.Location = New System.Drawing.Point(276, 281)
        Me.over.Name = "over"
        Me.over.Size = New System.Drawing.Size(206, 56)
        Me.over.TabIndex = 4
        Me.over.UseVisualStyleBackColor = False
        '
        'start
        '
        Me.start.AutoSize = True
        Me.start.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.start.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.start.Image = CType(resources.GetObject("start.Image"), System.Drawing.Image)
        Me.start.Location = New System.Drawing.Point(276, 198)
        Me.start.Margin = New System.Windows.Forms.Padding(0)
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(206, 56)
        Me.start.TabIndex = 3
        Me.start.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.start)
        Me.Controls.Add(Me.over)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents over As Button
    Friend WithEvents start As Button
End Class
