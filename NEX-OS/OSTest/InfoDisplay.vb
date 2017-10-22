Public Class InfoDisplay
    Private Sub InfoDisplay_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            LoginForm.Show()
            Me.Close()
        End If
    End Sub
End Class
