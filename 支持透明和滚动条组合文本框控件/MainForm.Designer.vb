<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.LabelPanel = New System.Windows.Forms.Label()
        Me.LabelScrollBar = New System.Windows.Forms.Label()
        Me.LabelTextBox = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelPanel
        '
        Me.LabelPanel.BackColor = System.Drawing.Color.Transparent
        Me.LabelPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelPanel.Location = New System.Drawing.Point(349, 9)
        Me.LabelPanel.Name = "LabelPanel"
        Me.LabelPanel.Size = New System.Drawing.Size(275, 360)
        Me.LabelPanel.TabIndex = 1
        '
        'LabelScrollBar
        '
        Me.LabelScrollBar.BackColor = System.Drawing.Color.Transparent
        Me.LabelScrollBar.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelScrollBar.ForeColor = System.Drawing.Color.White
        Me.LabelScrollBar.Image = CType(resources.GetObject("LabelScrollBar.Image"), System.Drawing.Image)
        Me.LabelScrollBar.Location = New System.Drawing.Point(565, 51)
        Me.LabelScrollBar.Name = "LabelScrollBar"
        Me.LabelScrollBar.Size = New System.Drawing.Size(20, 36)
        Me.LabelScrollBar.TabIndex = 3
        Me.LabelScrollBar.Visible = False
        '
        'LabelTextBox
        '
        Me.LabelTextBox.AutoSize = True
        Me.LabelTextBox.BackColor = System.Drawing.Color.Transparent
        Me.LabelTextBox.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelTextBox.ForeColor = System.Drawing.Color.White
        Me.LabelTextBox.Location = New System.Drawing.Point(318, 179)
        Me.LabelTextBox.Name = "LabelTextBox"
        Me.LabelTextBox.Size = New System.Drawing.Size(0, 20)
        Me.LabelTextBox.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(13, 9)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(330, 329)
        Me.TextBox1.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 345)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(330, 24)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.支持透明和滚动条组合文本框控件.My.Resources.UnityResource.GBI
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(636, 378)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LabelTextBox)
        Me.Controls.Add(Me.LabelScrollBar)
        Me.Controls.Add(Me.LabelPanel)
        Me.DoubleBuffered = True
        Me.Name = "MainForm"
        Me.Text = "支持透明和滚动条组合文本框控件"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelPanel As Label
    Friend WithEvents LabelScrollBar As Label
    Friend WithEvents LabelTextBox As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
End Class
