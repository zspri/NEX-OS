Public Class LocationSet
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        If PromptBox.Text = "" Then
            TextBoxBorder.BackColor = Color.FromArgb(240, 71, 71)
            TextBoxHelper.ForeColor = Color.FromArgb(240, 71, 71)
            TextBoxHelper.Text = "Please fill out this field"
        Else
            Dim PrevLocation = My.Settings.Location
            My.Settings.Location = PromptBox.Text
            Try
                Desktop.UpdateWeather()
                Me.Close()
            Catch ex As Exception
                NEXAppLog.Log("app.location", ex.ToString)
                My.Settings.Location = PrevLocation
                TextBoxBorder.BackColor = Color.FromArgb(240, 71, 71)
                TextBoxHelper.ForeColor = Color.FromArgb(240, 71, 71)
                TextBoxHelper.Text = "Something went wrong"
            End Try
        End If
    End Sub
End Class