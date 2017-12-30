Public Class Internet
    Private Sub WebBrowser1_NewWindow(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles WebBrowser1.NewWindow
        e.Cancel = True
        NEXAppLog.Log("app.web", "cancelled new window")
    End Sub

    Private Sub WebBrowser1_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs) Handles WebBrowser1.Navigated
        TextBox1.Text = WebBrowser1.Url.ToString
        If WebBrowser1.DocumentTitle = "" Then
            Label2.Text = WebBrowser1.Url.ToString
        Else
            Label2.Text = WebBrowser1.DocumentTitle
        End If
        ProgressBg.Hide()
        Timer1.Enabled = False
        NEXAppLog.Log("app.web", "Navigated to " & WebBrowser1.Url.ToString)
    End Sub

    Private Sub WebBrowser1_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles WebBrowser1.Navigating
        NEXAppLog.Log("app.web", "Navigating")
        ProgressBg.Location = New Point(ProgressBg.Width * -1, -1)
        Timer1.Enabled = True
        ProgressBg.Show()
        Label2.Text = "Please wait"
    End Sub

    Private Sub FormCloseButton(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        WebBrowser1.ShowPropertiesDialog()
    End Sub

    Private Sub Internet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.GoHome()
    End Sub

    Private Sub Me_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Desktop.ProcessKeys(e)
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter Then
            WebBrowser1.Navigate(TextBox1.Text)
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBg.Location = New Point(ProgressBg.Location.X + 5, -1)
        If ProgressBg.Location.X > NewProgressBar.Width Then
            ProgressBg.Location = New Point(ProgressBg.Width * -1, -1)
        End If
    End Sub
End Class