Imports System.IO
Imports System.Net
Imports System.Net.NetworkInformation

Public Class DeskMenu
    Private Function GetNetworkName()
        NEXAppLog.Log("desk.menu", "Getting network interfaces")
        Dim ni As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
        If ni Is Nothing OrElse ni.Length < 1 Then
            NEXAppLog.Log("desk.menu", "Failed...")
            Throw New WebException("No internet connection detected.")
        End If
        NEXAppLog.Log("desk.menu", "Success")
        For Each adapter As NetworkInterface In ni
            Return adapter.Name
        Next
        Return 0
    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        NEXAppLog.Log("desk.menu", "Closing app...")
        For tmp = 0 To 390 / 10
            Me.Width = Me.Width - 10
            Application.DoEvents()
        Next
        Me.Close()
    End Sub

    Private Sub DeskMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NEXAppLog.Log("desk.menu", "Initalizing")
        Me.Height = My.Computer.Screen.Bounds.Size.Height
        Me.Width = 0
        Me.Location = New Point(0, 0)
        Me.Show()
        Application.DoEvents()
        TimeLabel.Text = "Today is " + MonthName(Month(DateTime.Now)) + " " + DateTime.Now.ToString("dd") + "."
        Dim PwrStatus = SystemInformation.PowerStatus
        Dim BatteryStatus = PwrStatus.BatteryChargeStatus.ToString
        Dim BtPercent = PwrStatus.BatteryLifePercent * 100
        If BatteryStatus = "Charging" Then
            BtLabel.Text = "Charging (" + BtPercent.ToString + "%)"
        ElseIf BatteryStatus = "NoSystemBattery" Then
            BtLabel.Text = "No battery detected"
        ElseIf BatteryStatus = "Unknown" Then
            BtLabel.Text = ""
        Else
            If BtPercent < 20 Then
                BtIcon.Image = My.Resources.NoBattery
                BtLabel.Text = "Very low battery life - " + BtPercent.ToString + "% remaining"
            ElseIf BtPercent < 34 Then
                BtIcon.Image = My.Resources.BatteryLow
                BtLabel.Text = "Low battery life - " + BtPercent.ToString + "% remaining"
            ElseIf BtPercent < 68 Then
                BtIcon.Image = My.Resources.BatteryMed
                BtLabel.Text = BtPercent.ToString + "% remaining"
            ElseIf BtPercent < 100 Then
                BtIcon.Image = My.Resources.BatteryHigh
                BtLabel.Text = BtPercent.ToString + "% remaining"
            Else
                BtIcon.Image = My.Resources.BatteryFull
                BtLabel.Text = BtPercent.ToString + "% remaining"
            End If
        End If
        NEXAppLog.Log("desk.menu", "Got power status")
        Try
            Dim Client As WebClient = New WebClient()
            Dim Reader As StreamReader = New StreamReader(Client.OpenRead("http://nanomotion.xyz/api/news"))
            News.Text = Reader.ReadToEnd
            NEXAppLog.Log("desk.menu", "Got news")
        Catch ex As Exception
            News.Text = "Failed to fetch news. Try again later."
            NEXAppLog.Log("desk.menu", ex.ToString)
        End Try
        ' Slide open animation
        ' ref: max 390
        NEXAppLog.Log("desk.menu", "Beginning UI animation")
        For tmp = 0 To 270 / 7.5
            Me.Width = Me.Width + 7.5
            Application.DoEvents()
        Next
        For tmp = 0 To 60 / 4
            Me.Width = Me.Width + 4
            Application.DoEvents()
        Next
        For tmp = 0 To 40 / 2
            Me.Width = Me.Width + 2
            Application.DoEvents()
        Next
        For tmp = 0 To 20
            Me.Width = Me.Width + 1
            Application.DoEvents()
        Next
        NEXAppLog.Log("desk.menu", "Finished")
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter Then
            NEXAppLog.Log("desk.menu", "Searching query " + TextBox1.Text)
            My.Forms.Internet.Show()
            My.Forms.Internet.WebBrowser1.Navigate(My.Settings.SearchUrl + TextBox1.Text)
            TextBox1.Text = ""
            Me.Close()
        End If
    End Sub

    Private Sub MenuSettings_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        NEXAppLog.Log("desk.menu", "Open app triggered")
        MenuSettings.Show()
        Me.Close()
    End Sub

    Private Sub HelpIcon_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        NEXAppLog.Log("desk.menu", "Open app triggered")
        GetHelp.Show()
        Me.Close()
    End Sub

    Private Sub Browser_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click, Label6.Click
        NEXAppLog.Log("desk.menu", "Open app triggered")
        Internet.Show()
        Me.Close()
    End Sub

    Private Sub Notes_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click, Label5.Click
        NEXAppLog.Log("desk.menu", "Open app triggered")
        Notes.Show()
        Me.Close()
    End Sub

    Private Sub Files_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click, Label7.Click
        NEXAppLog.Log("desk.menu", "Open app triggered")
        Files.Show()
        Me.Close()
    End Sub

    Private Sub Settings_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click, Label8.Click
        NEXAppLog.Log("desk.menu", "Open app triggered")
        Settings.Show()
        Me.Close()
    End Sub

    Private Sub Time_Click(sender As Object, e As EventArgs) Handles TimeLabel.Click, PictureBox2.Click
        NEXAppLog.Log("desk.menu", "Open app triggered")
        My.Forms.Internet.Show()
        My.Forms.Internet.WebBrowser1.Navigate(My.Settings.SearchUrl + "what time is it")
        Me.Close()
    End Sub

    Private Sub Paint_Click(sender As Object, e As EventArgs) Handles Label9.Click, PictureBox9.Click
        NEXAppLog.Log("desk.menu", "Open app triggered")
        My.Forms.Paint.Show()
        Me.Close()
    End Sub

    Private Sub Weather_Click(sender As Object, e As PaintEventArgs) Handles Panel11.Click, PictureBox11.Click, Label11.Click
        NEXAppLog.Log("desk.menu", "Open app triggered")
        My.Forms.Weather.Show()
        Me.Close()
    End Sub

    Private Sub YouTube_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click, Label10.Click, Panel10.Click
        NEXAppLog.Log("desk.menu", "Open app triggered")
        Internet.Show()
        Internet.WebBrowser1.Navigate("https://youtube.com")
    End Sub

    Private Sub Clock_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click, Label13.Click, Panel13.Click
        NEXAppLog.Log("desk.menu", "Open app triggered")
        Clock.Show()
        Clock.BringToFront()
    End Sub
End Class