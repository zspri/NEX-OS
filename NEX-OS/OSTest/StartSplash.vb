Public Class StartSplash
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor.Hide()
        Timer1.Interval = 7500
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PowerOff.Show()
        Me.BringToFront()
        Application.DoEvents()
        Me.Update()
        Me.Cursor.Show()
        Me.Close()
    End Sub
End Class
