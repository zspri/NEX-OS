Imports System.IO
Imports System.Text
Imports System.Net
Imports System.Management
Imports System.Runtime.InteropServices
Imports System.Net.NetworkInformation

Public Class DeskMenu
    Private Function GetNetworkName()
        Dim ni As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
        If ni Is Nothing OrElse ni.Length < 1 Then
            Throw New WebException("No internet connection detected.")
        End If
        For Each adapter As NetworkInterface In ni
            Return adapter.Name
        Next
        Return 0
    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        For tmp = 0 To 390 / 10
            Me.Width = Me.Width - 10
            Application.DoEvents()
        Next
        Me.Close()
    End Sub

    Private Sub DeskMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = My.Computer.Screen.Bounds.Size.Height
        Me.Width = 0
        Me.Location = New Point(0, 0)
        Me.Show()
        Application.DoEvents()
        TimeLabel.Text = "Today is " + MonthName(Month(DateTime.Now)) + " " + DateTime.Now.ToString("dd") + "."
        Dim PwrStatus = SystemInformation.PowerStatus
        Dim BatteryStatus = PwrStatus.BatteryChargeStatus.ToString
        Dim BtPercent As Integer = PwrStatus.BatteryLifePercent
        If BatteryStatus = "Charging" Then
            BtLabel.Text = "Charging (" + BtPercent.ToString + "%)"
        ElseIf BatteryStatus = "NoSystemBattery" Then
            BtLabel.Text = "No battery detected"
        ElseIf BatteryStatus = "Unknown" Then
            BtLabel.Text = ""
        Else
            If BtPercent < 20 Then
                BtIcon.Image = My.Resources.NoBattery
                BtLabel.Text = "Battery critical (" + BtPercent.ToString + ")"
            ElseIf BtPercent < 34 Then
                BtIcon.Image = My.Resources.BatteryLow
                BtLabel.Text = "Low charge (" + BtPercent.ToString + ")"
            ElseIf BtPercent < 68 Then
                BtIcon.Image = My.Resources.BatteryMed
                BtLabel.Text = "Medium charge (" + BtPercent.ToString + ")"
            ElseIf BtPercent < 100 Then
                BtIcon.Image = My.Resources.BatteryHigh
                BtLabel.Text = "High charge (" + BtPercent.ToString + ")"
            Else
                BtIcon.Image = My.Resources.BatteryFull
                BtLabel.Text = "Full charge (" + BtPercent.ToString + ")"
            End If
        End If
        Try
            Dim Client As WebClient = New WebClient()
            Dim Reader As StreamReader = New StreamReader(Client.OpenRead("http://nanomotion.xyz/api/news"))
            News.Text = Reader.ReadToEnd
        Catch ex As Exception
            News.Text = "Failed to fetch news. Try again later."
            Debug.Print(ex.ToString)
        End Try
        ' Slide open animation
        ' ref: max 390
        For tmp = 0 To 190 / 10
            Me.Width = Me.Width + 10
            Application.DoEvents()
        Next
        For tmp = 0 To 80 / 10
            Me.Width = Me.Width + 7.5
            Application.DoEvents()
        Next
        For tmp = 0 To 60 / 10
            Me.Width = Me.Width + 5
            Application.DoEvents()
        Next
        For tmp = 0 To 40
            Me.Width = Me.Width + 2.5
            Application.DoEvents()
        Next
        For tmp = 0 To 20
            Me.Width = Me.Width + 1
            Application.DoEvents()
        Next
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter Then
            My.Forms.Internet.Show()
            My.Forms.Internet.WebBrowser1.Navigate(My.Settings.SearchUrl + TextBox1.Text)
            TextBox1.Text = ""
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        MenuSettings.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        GetHelp.Show()
        Me.Close()
    End Sub
End Class