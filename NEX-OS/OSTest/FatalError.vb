Public Class FatalError
    Private Sub FatalError_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Desktop.Close()
        Try
            DeskMenu.Close()
        Catch ex As Exception
            Debug.Print(ex.ToString)
        End Try
        Me.Cursor.Hide()
    End Sub
End Class