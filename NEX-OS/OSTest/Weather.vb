Imports System.IO
Imports System.Net

Public Class Weather
    Private Function UpdateWeather()
        Timer2.Enabled = True
        NEXAppLog.Log("app.weather", "Updating weather")
        NewProgressBar.Show()
        Dim tClient As WebClient = New WebClient
        Dim tImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData("https://dsx.weather.com/util/image/map/us_radar_plus_usen_1280x720.jpg")))
        PictureBox1.Image = tImage
        NewProgressBar.Hide()
        Timer2.Enabled = False
        NEXAppLog.Log("app.weather", "Finished")
        Return 0
    End Function

    Private Sub Weather_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateWeather()
        Timer1.Enabled = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ProgressBg.Location = New Point(ProgressBg.Location.X + 10, ProgressBg.Location.Y)
        If ProgressBg.Location.X > Me.Width Then
            ProgressBg.Location = New Point(0 - ProgressBg.Width, ProgressBg.Location.Y)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        UpdateWeather()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        UpdateWeather()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        NEXAppLog.Log("app.weather", "Openning online version")
        Internet.Show()
        Internet.WebBrowser1.Navigate("https://weather.com/maps/usdopplerradar")
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub
End Class