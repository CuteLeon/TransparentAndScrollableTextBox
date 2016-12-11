Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelPanel.BackColor = Color.FromArgb(50, Color.White)
        LabelTextBox.Parent = LabelPanel
        LabelScrollBar.Parent = LabelPanel
        LabelTextBox.Location = Point.Empty
        LabelScrollBar.Location = New Point(LabelPanel.Width - LabelScrollBar.Width, 0)

        For index As Integer = 0 To 10
            LabelTextBox.Text &= index & vbCrLf
        Next
    End Sub

    Private Sub LabelScrollBar_MouseDown(sender As Object, e As MouseEventArgs) Handles LabelScrollBar.MouseDown
        LabelPanel.Tag = MousePosition.Y : LabelScrollBar.Tag = LabelScrollBar.Top
        AddHandler LabelScrollBar.MouseMove, AddressOf LabelScrollBar_MouseMove
    End Sub

    Private Sub LabelScrollBar_MouseMove(sender As Object, e As MouseEventArgs)
        If LabelTextBox.Height <= LabelPanel.Height Then Exit Sub
        Dim TopPosition As Integer = MousePosition.Y - LabelPanel.Tag + LabelScrollBar.Tag
        If TopPosition < 0 Or TopPosition > LabelPanel.Height - LabelScrollBar.Height Then Exit Sub
        LabelScrollBar.Top = TopPosition
        LabelTextBox.Top = -(LabelTextBox.Height - LabelPanel.Height) * (LabelScrollBar.Top / (LabelPanel.Height - LabelScrollBar.Height))
    End Sub

    Private Sub LabelScrollBar_MouseUp(sender As Object, e As MouseEventArgs) Handles LabelScrollBar.MouseUp
        RemoveHandler LabelScrollBar.MouseMove, AddressOf LabelScrollBar_MouseMove
    End Sub

    Private Sub LabelTextBox_Resize(sender As Object, e As EventArgs) Handles LabelTextBox.Resize
        If LabelTextBox.Height > LabelPanel.Height Then
            If Not LabelScrollBar.Visible Then
                LabelScrollBar.Top = 0
                LabelScrollBar.Show()
            End If
        Else
            If LabelScrollBar.Visible Then
                LabelTextBox.Location = Point.Empty
                LabelScrollBar.Hide()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LabelTextBox.Text = TextBox1.Text
    End Sub

End Class
