Public Class AlarmSet
    Private Sub AMBtn_CheckedChanged(sender As Object, e As EventArgs) Handles AMBtn.CheckedChanged
        If AMBtn.Checked Then
            PMBtn.Checked = False
        Else
            PMBtn.Checked = True
        End If
    End Sub

    Private Sub PMBtn_CheckedChanged(sender As Object, e As EventArgs) Handles PMBtn.CheckedChanged
        If PMBtn.Checked Then
            AMBtn.Checked = False
        Else
            AMBtn.Checked = True
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        If HourLabel.Text = "" Or MinuteLabel.Text = "" Or ((Not AMBtn.Checked) And (Not PMBtn.Checked)) Then
            TextBoxBorder.BackColor = Color.FromArgb(240, 71, 71)
            TextBoxBorder2.BackColor = Color.FromArgb(240, 71, 71)
            TextBoxTitle.ForeColor = Color.FromArgb(240, 71, 71)
            TextBoxTitle2.ForeColor = Color.FromArgb(240, 71, 71)
            TextBoxHelper.ForeColor = Color.FromArgb(240, 71, 71)
            TextBoxHelper.Text = "Please fill this in"
        ElseIf Convert.ToInt32(HourLabel.Text) > 12 Or Convert.ToInt32(HourLabel.Text) < 1 Then
            TextBoxBorder.BackColor = Color.FromArgb(240, 71, 71)
            TextBoxBorder2.BackColor = Color.FromArgb(240, 71, 71)
            TextBoxTitle.ForeColor = Color.FromArgb(240, 71, 71)
            TextBoxTitle2.ForeColor = Color.FromArgb(240, 71, 71)
            TextBoxHelper.ForeColor = Color.FromArgb(240, 71, 71)
            TextBoxHelper.Text = "Hour must be from 1 to 12"
        ElseIf Convert.ToInt32(HourLabel.Text) < 0 Or Convert.ToInt32(HourLabel.Text) > 59 Then
            TextBoxBorder.BackColor = Color.FromArgb(240, 71, 71)
            TextBoxBorder2.BackColor = Color.FromArgb(240, 71, 71)
            TextBoxTitle.ForeColor = Color.FromArgb(240, 71, 71)
            TextBoxTitle2.ForeColor = Color.FromArgb(240, 71, 71)
            TextBoxHelper.ForeColor = Color.FromArgb(240, 71, 71)
            TextBoxHelper.Text = "Minute must be from 0 to 59"
        Else
            Clock.SetAlarm(Convert.ToInt32(HourLabel.Text), Convert.ToInt32(MinuteLabel.Text), AMBtn.Checked)
            Me.Close()
        End If
    End Sub
End Class