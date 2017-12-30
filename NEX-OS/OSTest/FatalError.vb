Public Class FatalError
    Private Sub FatalError_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NEXAppLog.Log("nex.err", "Looks like something really bad happened...")
        Desktop.Close()
        Try
            DeskMenu.Close()
        Catch ex As Exception
            Debug.Print(ex.ToString)
        End Try
        Me.Cursor.Hide()
    End Sub

    Private Sub FatalError_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class