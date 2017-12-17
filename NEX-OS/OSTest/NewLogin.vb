Public Class PowerOff
    Private Sub PowerOff_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Desktop.Show()
        Me.Close()
    End Sub
End Class