Public Class NotesSettings
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        My.Settings.UseNotesDarkTheme = CheckBox1.Checked
        Notes.Close()
        Notes.Show()
        Me.BringToFront()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub NotesSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBox1.Checked = My.Settings.UseNotesDarkTheme
    End Sub
End Class