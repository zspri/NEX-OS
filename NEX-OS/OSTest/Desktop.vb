Imports System.IO
Imports System.Net
Imports Newtonsoft.Json

Public Class Desktop
    Private Function SpamRefresh(times As Integer)
        For tmp = 0 To times
            Me.Refresh()
        Next
        Return 0
    End Function

    Public Function ProcessKeys(e As KeyEventArgs)
        NEXAppLog.Log("desk.main", "Handling key event")
        If e.KeyCode = Keys.F3 And My.Computer.Keyboard.ShiftKeyDown Then
            NEXAppLog.Log("desk.main", "Set admin: " & (Not My.Settings.Admin).ToString())
            If My.Settings.Admin Then
                My.Settings.Admin = False
            Else
                My.Settings.Admin = True
            End If
        ElseIf e.KeyCode = Keys.OemMinus And My.Computer.Keyboard.AltKeyDown And My.Computer.Keyboard.CtrlKeyDown Then
            NEXAppLog.Log("desk.main", "Trigger manual crash")
            FatalError.Show()
        ElseIf e.KeyCode = Keys.S And My.Computer.Keyboard.AltKeyDown Then
            NEXAppLog.Log("desk.main", "Start desk.menu")
            DeskMenu.Show()
        End If
        Return 0
    End Function

    Public Function UpdateWeather()
        NEXAppLog.Log("desk.main", "Updating weather")
        Dim Client As WebClient = New WebClient()
        Dim Reader As StreamReader = New StreamReader(Client.OpenRead("http://api.openweathermap.org/data/2.5/weather?q=" + My.Settings.Location + "&appid=47307ec7bb8ba1da945a0aa6c7949892"))
        Dim WeatherObj As WeatherObject = JsonConvert.DeserializeObject(Of WeatherObject)(Reader.ReadToEnd)
        Dim Temperature = Math.Round(WeatherObj.main.temp * 1.8 - 459.67)
        Dim Location = WeatherObj.name + ", " + WeatherObj.sys.country
        WeatherLabel.Text = Location & vbCrLf & Temperature & "°F"
        NEXAppLog.Log("desk.main", "Finished")
        Return 0
    End Function

    Private Sub Desktop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NEXAppLog.Log("desk.main", "Loading desktop")
        DeskTime.Text = Date.Now.ToString("h:mm")
        DeskDate.Text = MonthName(Month(DateTime.Now)) & Date.Now.ToString(" dd, yyyy")
        Timer1.Interval = 100
        Timer1.Enabled = True
        Timer2.Interval = 1
        Timer2.Enabled = True
        Try
            NEXAppLog.Log("desk.main", "Testing internet connection")
            Dim Client As WebClient = New WebClient()
            Dim Reader As StreamReader = New StreamReader(Client.OpenRead("https://httpbin.org/get"))
            InternetConnection.Image = My.Resources.icons8_signal_32
        Catch ex As Exception
            NEXAppLog.Log("desk.main", ex.ToString)
            NoInternet.Show()
            NoInternet.MoreInfo.Text = ex.ToString
            InternetConnection.Image = My.Resources.icons8_no_connection_32
        End Try
        StartSplash.Close()
        If My.Settings.FirstRun Then
            FirstRun.Show()
        ElseIf My.Settings.Location = "" Then
            LocationSet.Show()
        End If
        NEXAppLog.Log("desk.main", "Finished")
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
        Settings.Show()
        NEXAppLog.Log("desk.main", "Open app triggered")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        NEXAppLog.Log("desk.main", "Exiting NEX OS")
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        NEXAppLog.Log("desk.main", "Opening desk menu")
        Try
            DeskMenu.Show()
        Catch ex As Exception
            Dim st = ex.ToString
            Try
                DeskMenu.Close()
            Catch exc As Exception
                st = st & vbCrLf & vbCrLf & exc.ToString
                NEXAppLog.Log("desk.main", ex.ToString)
            End Try
            FatalError.Show()
            FatalError.Stacktrace.Text = st
            Me.Close()
        End Try
    End Sub

    Private Sub Me_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        NEXAppLog.Log("desk.main", "Key down triggered")
        ProcessKeys(e)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DeskTime.Text = Date.Now.ToString("h:mm")
        DeskDate.Text = MonthName(Month(DateTime.Now)) & Date.Now.ToString(" dd, yyyy")
        Dim power = SystemInformation.PowerStatus
        Dim percent = power.BatteryLifePercent * 100
        PowerLabel.Text = percent.ToString + "%"
        'Debug.WriteLine("[1] Tick!")
    End Sub

    Private Sub GSearchBar_KeyDown(sender As Object, e As KeyEventArgs) Handles GSearchBar.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Return Then
            NEXAppLog.Log("desk.main", "Searching query " + GSearchBar.Text)
            Internet.Show()
            Internet.WebBrowser1.Navigate("https://google.com/search?q=" + GSearchBar.Text)
            GSearchBar.Text = ""
            Try
                DeskMenu.Close()
            Catch ex As Exception
                NEXAppLog.Log("desk.main", ex.ToString)
            End Try
        End If
    End Sub

    Private Sub SettingsIcon_Click(sender As Object, e As EventArgs) Handles SettingsButton.Click
        NEXAppLog.Log("desk.main", "Open app triggered")
        Settings.Show()
    End Sub

    Private Sub PaintIcon_Click(sender As Object, e As EventArgs) Handles PaintIcon.Click
        NEXAppLog.Log("desk.main", "Open app triggered")
        My.Forms.Paint.Show()
    End Sub

    Private Sub FilesIcon_Click(sender As Object, e As EventArgs) Handles FilesIcon.Click
        NEXAppLog.Log("desk.main", "Open app triggered")
        Files.Show()
    End Sub

    Private Sub NotesIcon_Click(sender As Object, e As EventArgs) Handles NotesIcon.Click
        NEXAppLog.Log("desk.main", "Open app triggered")
        Notes.Show()
    End Sub

    Private Sub BrowserIcon_Click(sender As Object, e As EventArgs) Handles BrowserIcon.Click
        NEXAppLog.Log("desk.main", "Open app triggered")
        Internet.Show()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Interval = 3000000
        Try
            UpdateWeather()
        Catch ex As Exception
            NEXAppLog.Log("desk.main", ex.ToString)
            NoInternet.Show()
            NoInternet.MoreInfo.Text = ex.ToString
        End Try
        Try
            NEXAppLog.Log("desk.main", "Testing internet connection")
            My.Computer.Network.Ping("httpbin.org")
            InternetConnection.Image = My.Resources.icons8_signal_32
        Catch ex As Exception
            NEXAppLog.Log("desk.main", ex.ToString)
            InternetConnection.Image = My.Resources.icons8_no_connection_32
        End Try
        'Debug.WriteLine("[2] Tick!")
    End Sub

    Private Sub Weather_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        NEXAppLog.Log("desk.main", "Open app triggered")
        Weather.Show()
    End Sub

    Private Sub Clock_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        NEXAppLog.Log("desk.main", "Open app triggered")
        Clock.Show()
        Clock.BringToFront()
    End Sub

    Private Sub YouTube_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        NEXAppLog.Log("desk.main", "Open app triggered")
        Internet.Show()
        Internet.WebBrowser1.Navigate("https://youtube.com")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        NEXAppLog.Log("desk.main", "Open app triggered")
        devtools.Show()
    End Sub
End Class

Public Class Main
    Public Property temp As Decimal
    Public Property pressure As Decimal
    Public Property humidity As Decimal
    Public Property temp_min As Decimal
    Public Property temp_max As Decimal
End Class

Public Class Sys
    Public Property type As Integer
    Public Property id As Integer
    Public Property message As Double
    Public Property country As String
    Public Property sunrise As Integer
    Public Property sunset As Integer
End Class

Public Class WeatherObject
    Public Property base As String
    Public Property main As Main
    Public Property visibility As Integer
    Public Property dt As Decimal
    Public Property sys As Sys
    Public Property id As Decimal
    Public Property name As String
    Public Property cod As Decimal
End Class