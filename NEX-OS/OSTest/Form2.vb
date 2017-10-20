Imports System.IO
Imports System.Net
Imports System.Management
Imports System.Runtime.InteropServices
Imports System.Net.NetworkInformation

Public Class Form2
    Private Function SpamRefresh(times As Integer)
        For tmp = 0 To times
            Me.Refresh()
        Next
        Return 0
    End Function

    Public Function ProcessKeys(e As KeyEventArgs)
        If e.KeyCode = Keys.F3 And My.Computer.Keyboard.ShiftKeyDown Then
            If My.Settings.Admin Then
                My.Settings.Admin = False
                AdminIcon.Hide()
            Else
                My.Settings.Admin = True
                AdminIcon.Show()
            End If
        ElseIf e.KeyCode = Keys.OemMinus And My.Computer.Keyboard.AltKeyDown And My.Computer.Keyboard.CtrlKeyDown Then
            FatalError.Show()
        ElseIf e.KeyCode = Keys.S And My.Computer.Keyboard.AltKeyDown Then
            DeskMenu.Show()
        End If
        Return 0
    End Function
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AdminIcon.Hide()
        Form1.Close()
        Me.Cursor.Show()
        VersionLabel.Text = "NEX OS Version " + My.Application.Info.Version.ToString
        Try
            Dim Client As WebClient = New WebClient()
            Dim Reader As StreamReader = New StreamReader(Client.OpenRead("http://nanomotion.xyz/api/index"))
        Catch ex As Exception
            NoInternet.Show()
            NoInternet.MoreInfo.Text = ex.ToString
        End Try
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Settings.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Internet.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Debug.Print("Modal started")
        Dim modalResult = ModalBox.ShowModal("Shutdown", "Are you sure that you want to close NEX OS?")
        ModalBox.Close()
        Debug.Print("Modal finished // " & modalResult.ToString)
        If modalResult = 1 Then
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Form1.Show()
        SpamRefresh(1000)
        Form1.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        DeskMenu.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Notes.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Files.Show()
    End Sub

    Private Sub AdminIcon_Click(sender As Object, e As EventArgs) Handles AdminIcon.Click
        ModalBox.ShowModal("Administrator", "You're using the administrator account. To revert back to the normal user, press Shift+F3.", YesNoModal:=False)
        ModalBox.Close()
    End Sub

    Private Sub Me_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ProcessKeys(e)
    End Sub
End Class