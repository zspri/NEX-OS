Public Class FirstRun
    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        My.Settings.FirstRun = False
        Me.Close()
    End Sub
End Class