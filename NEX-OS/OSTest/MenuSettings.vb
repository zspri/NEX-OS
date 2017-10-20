Public Class MenuSettings

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub MenuSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.SearchUrl
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        TextBox1.Enabled = False
        My.Settings.SearchUrl = TextBox1.Text
        TextBox1.Enabled = True
        Button1.Enabled = True
    End Sub
End Class