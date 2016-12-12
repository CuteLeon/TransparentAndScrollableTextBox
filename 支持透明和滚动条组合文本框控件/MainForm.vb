Public Class MainForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim S As String, SL As Integer
        S = Space(Rnd() * 50).Replace(" ", vbCrLf)
        SL = S.Length
        For Index As Integer = SL - 1 To 0 Step -1
            S = S.Insert(Index, Space(Rnd() * 20).Replace(" ", "+"))
        Next
        LeonTextBox1.ScrollBar.BackColor = Color.FromArgb(150, VBMath.Rnd * 255, VBMath.Rnd * 255, VBMath.Rnd * 255)
        LeonTextBox1.TextBox.Text = S
    End Sub

End Class
