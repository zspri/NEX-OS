Imports System.IO
Imports System.Net

Public Class Desktop
    Private Function SpamRefresh(times As Integer)
        For tmp = 0 To times
            Me.Refresh()
        Next
        Return 0
    End Function

    Public Function ProcessKeys(e As KeyEventArgs)
        If e.KeyCode = Keys.F3 And My.Computer.Keyboard.ShiftKeyDown Then
            If My.Settings.Admin Then
                My.Settings.Admin = False
            Else
                My.Settings.Admin = True
            End If
        ElseIf e.KeyCode = Keys.OemMinus And My.Computer.Keyboard.AltKeyDown And My.Computer.Keyboard.CtrlKeyDown Then
            FatalError.Show()
        ElseIf e.KeyCode = Keys.S And My.Computer.Keyboard.AltKeyDown Then
            DeskMenu.Show()
        End If
        Return 0
    End Function
    Private Sub Desktop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DeskTime.Text = Date.Now.ToString("HH:mm")
        DeskDate.Text = MonthName(Month(DateTime.Now)) & Date.Now.ToString(" dd, yyyy")
        Timer1.Interval = 100
        Timer1.Enabled = True
        Try
            Dim Client As WebClient = New WebClient()
            Dim Reader As StreamReader = New StreamReader(Client.OpenRead("https://httpbin.org/get"))
        Catch ex As Exception
            NoInternet.Show()
            NoInternet.MoreInfo.Text = ex.ToString
        End Try
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
        Settings.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        DeskMenu.Show()
    End Sub

    Private Sub Me_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ProcessKeys(e)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DeskTime.Text = Date.Now.ToString("HH:mm")
        DeskDate.Text = MonthName(Month(DateTime.Now)) & Date.Now.ToString(" dd, yyyy")
    End Sub

    Private Sub GSearchBar_KeyDown(sender As Object, e As KeyEventArgs) Handles GSearchBar.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Return Then
            Internet.Show()
            Internet.WebBrowser1.Navigate("https://google.com/search?q=" + GSearchBar.Text)
            GSearchBar.Text = ""
            Try
                DeskMenu.Close()
            Catch ex As Exception
                Debug.Print(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub SettingsIcon_Click(sender As Object, e As EventArgs) Handles SettingsButton.Click
        Settings.Show()
    End Sub

    Private Sub PaintIcon_Click(sender As Object, e As EventArgs) Handles PaintIcon.Click
        My.Forms.Paint.Show()
    End Sub

    Private Sub FilesIcon_Click(sender As Object, e As EventArgs) Handles FilesIcon.Click
        Files.Show()
    End Sub

    Private Sub NotesIcon_Click(sender As Object, e As EventArgs) Handles NotesIcon.Click
        Notes.Show()
    End Sub

    Private Sub BrowserIcon_Click(sender As Object, e As EventArgs) Handles BrowserIcon.Click
        Internet.Show()
    End Sub
End Class