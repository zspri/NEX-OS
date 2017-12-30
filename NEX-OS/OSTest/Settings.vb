Public Class Settings
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub BottomLabel_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click, PictureBox4.Click, Label4.Click
        Internet.Show()
        Internet.WebBrowser1.Navigate("https://github.com/Nanomotion/nex-os")
        Me.Close()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        LocationSet.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ModalBox.ShowModal("Reset user data?", "This includes Notes data, location, and all other configuration items. This setting is for advanced users.") Then
            My.Settings.Note = "Welcome to the note-taking app! Your notes will save automatically."
            My.Settings.SearchUrl = "https://google.com/search?q="
            My.Settings.UseNotesDarkTheme = False
            My.Settings.Location = "New York"
            My.Settings.FirstRun = True
            Desktop.UpdateWeather()
            NEXAppLog.Log("nex.settings", "Reset user data")
        End If
        ModalBox.Close()
    End Sub
End Class