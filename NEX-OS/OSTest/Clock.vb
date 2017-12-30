Imports System.Media

Public Class Clock
    Dim Mode As String = "clock"
    Dim StopWatch As Stopwatch = New Stopwatch()
    Dim TimeStr As String = "0:00 AM"

    Public Function SetAlarm(Hour As Integer, Minute As Integer, AM As Boolean)
        Dim AmPm As String
        If AM Then
            AmPm = " AM"
        Else
            AmPm = " PM"
        End If
        TimeStr = Hour.ToString & ":" & Minute.ToString & AmPm
        Timer1.Enabled = True
        NEXAppLog.Log("app.clock", "Alarm set for " & TimeStr)
        Return 0
    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        NEXAppLog.Log("app.clock", "Closing clock app")
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Mode = "clock" Then
            TimeLabel.Text = Date.Now.ToString("h:mm.ss tt")
        ElseIf Mode = "stopwatch" Then
            TimeLabel.Text = String.Format("{0:0}:{1:00}:{2:00}.{3:00}", StopWatch.Elapsed.Hours, StopWatch.Elapsed.Minutes, StopWatch.Elapsed.Seconds, StopWatch.Elapsed.Milliseconds / 10)
        ElseIf Mode = "alarm" Then
            LastLap.Show()
            LastLap.Text = "ALARM SET" & vbCrLf & TimeStr
            TimeLabel.Text = Date.Now.ToString("h:mm.ss tt")
            If TimeStr = Date.Now.ToString("h:m tt") Then
                Timer1.Enabled = False
                Dim soundPlayer As New SoundPlayer(My.Resources.alarm)
                LastLap.Text = "ALARM EXPIRED" & vbCrLf & TimeStr
                NEXAppLog.Log("app.", "Alarm expired")
                soundPlayer.Play()
                NEXAppLog.Log("app.", "Played ringtone")
            End If
        End If
    End Sub

    Private Sub PlayBtn_Click(sender As Object, e As EventArgs) Handles PlayBtn.Click
        If Mode = "clock" Then
        ElseIf Mode = "stopwatch" Then
            StopWatch.Start()
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub PauseBtn_Click(sender As Object, e As EventArgs) Handles PauseBtn.Click
        If Mode = "clock" Then
        ElseIf Mode = "stopwatch" Then
            StopWatch.Stop()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub InactiveModeLeft_Click(sender As Object, e As EventArgs) Handles InactiveModeLeft.Click
        If InactiveModeLeft.Text.ToLower() = "clock" Then
            Mode = "clock"
            Timer1.Enabled = True
        Else
            Mode = InactiveModeLeft.Text.ToLower()
            Timer1.Enabled = False
            TimeLabel.Text = "0:00:00.00"
        End If
        If Not Mode = "stopwatch" Then
            LastLap.Hide()
        End If
        If Mode = "alarm" Then
            SetAlarmBtn.Show()
            StopAlarmBtn.Show()
        Else
            SetAlarmBtn.Hide()
            StopAlarmBtn.Hide()
        End If
        InactiveModeLeft.Text = ActiveMode.Text.ToUpper()
        ActiveMode.Text = Mode.ToUpper()
        Debug.WriteLine(Mode)
    End Sub

    Private Sub InactiveModeRight_Click(sender As Object, e As EventArgs) Handles InactiveModeRight.Click
        If InactiveModeRight.Text.ToLower() = "clock" Then
            Mode = "clock"
            Timer1.Enabled = True
        Else
            Mode = InactiveModeRight.Text.ToLower()
            Timer1.Enabled = False
            TimeLabel.Text = "0:00:00.00"
        End If
        If Not Mode = "stopwatch" Then
            LastLap.Hide()
        End If
        If Mode = "alarm" Then
            SetAlarmBtn.Show()
            StopAlarmBtn.Show()
        Else
            SetAlarmBtn.Hide()
            StopAlarmBtn.Hide()
        End If
        InactiveModeRight.Text = ActiveMode.Text.ToUpper()
        ActiveMode.Text = Mode.ToUpper()
        Debug.WriteLine(Mode)
    End Sub

    Private Sub StopBtn_Click(sender As Object, e As EventArgs) Handles StopBtn.Click
        If Mode = "clock" Then
        ElseIf Mode = "stopwatch" Then
            StopWatch.Stop()
            Timer1.Enabled = False
            StopWatch = New Stopwatch()
        End If
    End Sub

    Private Sub Clock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        If Not Mode = "stopwatch" Then
            LastLap.Hide()
        End If
    End Sub

    Private Sub RestartBtn_Click(sender As Object, e As EventArgs) Handles RestartBtn.Click
        If Mode = "stopwatch" Then
            StopWatch.Stop()
            TimeLabel.Text = "0:00:00.00"
            LastLap.Show()
            LastLap.Text = "LAST LAP" & vbCrLf & String.Format("{0:0}:{1:00}:{2:00}.{3:000}", StopWatch.Elapsed.Hours, StopWatch.Elapsed.Minutes, StopWatch.Elapsed.Seconds, StopWatch.Elapsed.Milliseconds)
            StopWatch = New Stopwatch()
            StopWatch.Start()
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Desktop.BringToFront()
        NEXAppLog.Log("app.", "Minimizing window")
    End Sub

    Private Sub SetAlarmBtn_Click(sender As Object, e As EventArgs) Handles SetAlarmBtn.Click
        AlarmSet.Show()
        NEXAppLog.Log("app.", "Showing app.clock.alarmset")
    End Sub

    Private Sub StopAlarmBtn_Click(sender As Object, e As EventArgs) Handles StopAlarmBtn.Click
        Timer1.Enabled = False
        LastLap.Text = "ALARM CANCELLED" & vbCrLf & TimeStr
        NEXAppLog.Log("app.", "Alarm cancelled")
    End Sub
End Class