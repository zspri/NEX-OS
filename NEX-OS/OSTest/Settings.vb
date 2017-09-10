Public Class Settings
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub BottomLabel_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click, PictureBox4.Click, Label4.Click
        Internet.Show()
        Internet.WebBrowser1.Navigate("https://github.com/Nanomotion/nex-os")
        Me.Close()
    End Sub
End Class