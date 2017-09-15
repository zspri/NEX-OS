Public Class GetHelp
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        HelpTxt.Text = "Welcome to NEX OS!" & vbCrLf & vbCrLf & "This is a simple guide to help you get started with using NEX OS. Click on one of the topics on the right side to begin."
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        HelpTxt.Text = "This guide will show you how to navigate the desktop." & vbCrLf & vbCrLf & " - Search icon: Clicking this icon will open a quick access menu. To learn more, see Desk Menu on the right side." & vbCrLf & " - Program icons: This icons will open specific programs, such as Notes." & vbCrLf & " - Power icons: This icons close and restart NEX OS."
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        HelpTxt.Text = "Settings currently shows system information."
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        HelpTxt.Text = "This guide will show you how to use the Desk Menu." & vbCrLf & vbCrLf & " - Search: Searches Google with the requested query." & vbCrLf & " - News icons: Shows current date and important announcements for NEX OS." & vbCrLf & " - Settings icon: Shows settings for the Desk Menu."
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        HelpTxt.Text = "Enter the web address you want to go to in the top text box and press the 'Go' icon."
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        HelpTxt.Text = " - Saving: Your notes save when you close the Notes app." & vbCrLf & " - Settings: Shows option to switch between light and dark theme."
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Internet.Show()
        Internet.WebBrowser1.Navigate("https://github.com/Nanomotion/NEX-OS/issues")
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class