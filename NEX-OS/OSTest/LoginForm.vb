Imports System.IO
Imports System.Net

Public Class LoginForm

    Private Function LoadUser()
        If My.Settings.Admin Then
            UserName.Text = "Administrator"
            AdminPanel.Show()
        Else
            AdminPanel.Hide()
            UserName.Text = Environment.UserName
        End If
    End Function

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUser()

    End Sub

    Private Sub Me_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If Not e.KeyCode = Keys.S And My.Computer.Keyboard.AltKeyDown Then
            Desktop.ProcessKeys(e)
        End If
        If e.KeyCode = Keys.OemMinus And My.Computer.Keyboard.AltKeyDown And My.Computer.Keyboard.CtrlKeyDown Then
            Me.Close()
        End If
        LoadUser()
    End Sub

    Private Sub LogIn(sender As Object, e As EventArgs) Handles Label1.Click
        Desktop.Show()
        For tmp = 0 To 40
            Me.Opacity = Me.Opacity - 2.5
            Application.DoEvents()
        Next
        Me.Close()
    End Sub

    Private Sub Shutdown(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Desktop.Close()
        Me.Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        FatalError.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        InfoDisplay.Show()
        Try
            Dim Client As WebClient = New WebClient()
            Dim Reader As StreamReader = New StreamReader(Client.OpenRead("https://httpbin.org/anything"))
            InfoDisplay.Content.Text = Reader.ReadToEnd()
        Catch ex As Exception
            FatalError.Show()
            FatalError.Stacktrace.Text = ex.ToString
            InfoDisplay.Close()
        End Try
        Me.Close()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim Log
        InfoDisplay.Show()
        Try
            Try
                File.Delete(Path.Combine(Directory.GetCurrentDirectory() & "\process.log"))
            Catch ex As Exception
                Debug.Print(ex.ToString)
                My.Application.Log.WriteEntry(ex.ToString)
            End Try
            Try
                File.Copy(My.Application.Log.DefaultFileLogWriter.FullLogFileName, Path.Combine(Directory.GetCurrentDirectory() & "\process.log"))
            Catch ex As Exception
                Debug.Print(ex.ToString)
                My.Application.Log.WriteEntry(ex.ToString)
            End Try
            Log = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory() & "\process.log"))
            InfoDisplay.Content.Text = Log.ToString
        Catch ex As Exception
            FatalError.Show()
            FatalError.Stacktrace.Text = ex.ToString
            Debug.Print(ex.ToString)
            My.Application.Log.WriteEntry(ex.ToString)
            InfoDisplay.Close()
        End Try
        Me.Close()
    End Sub
End Class