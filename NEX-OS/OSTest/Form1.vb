Public Class Form1
    Private Function SpamRefresh(times As Integer)
        For tmp = 0 To times
            Me.Refresh()
        Next
        Return 0
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor.Hide()
        SpamRefresh(1000)
        Form2.Show()
        Me.BringToFront()
    End Sub
End Class
