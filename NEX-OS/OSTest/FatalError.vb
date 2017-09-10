Public Class FatalError
    Private Sub FatalError_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Close()
        Me.Cursor.Hide()
    End Sub
End Class