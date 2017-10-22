Imports System.Net
Imports newtonsoft.json

Public Class StartSplash
    Private Function SpamRefresh(times As Integer)
        For tmp = 0 To times
            Me.Refresh()
        Next
        Return 0
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor.Hide()
        Timer1.Interval = 7000
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LoginForm.Show()
        Me.BringToFront()
        Application.DoEvents()
        Me.Update()
        Me.Cursor.Show()
        Me.Close()
    End Sub
End Class
