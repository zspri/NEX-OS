Imports System.IO

Public Class Files

    Dim DirFiles As New Collections.Generic.List(Of Label)

    Public Function RetrieveFilesIn(DirPath As String)
        NEXAppLog.Log("app.files", "Getting files in " & DirPath)
        Me.DirPath.Text = DirPath
        TextBox1.Text = DirPath
        Dim labelX = 205
        Dim labelY = 115
        Debug.Print("Deleting old labels")
        NEXAppLog.Log("app.files", "Removing old labels")
        Dim lb As Label
        For Each lb In DirFiles
            NEXAppLog.Log("app.files", "Iter label: " + lb.ToString)
            RemoveHandler lb.Click, AddressOf Me.Files_Click
            lb.Dispose()
        Next
        NEXAppLog.Log("app.files", "Actually retreiving file names now")
        Dim files As String() = Directory.GetFiles(DirPath)
        Debug.Print(files.ToString)
        Dim fname As String
        For Each fname In files
            NEXAppLog.Log("app.files", "Iter file: " & fname.ToString)
            Dim label As Label = New Label()
            label.Size = New Size(Me.Width - labelX, 20)
            label.Location = New Point(labelX, labelY)
            label.Text = Path.GetFileName(fname)
            Me.Controls.Add(label)
            AddHandler label.Click, AddressOf Me.Files_Click
            label.Show()
            label.Visible = True
            label.SendToBack()
            DirFiles.Add(label)
            labelY += 25
        Next
        Return 0
    End Function

    Private Sub UnauthFiles_Click(sender As Object, e As EventArgs) Handles SysFilesLabel.Click, FolderIcon3.Click
        ModalBox.ShowModal("Access Denied", "You don't have permissions to view this folder.", YesNoModal:=False)
        ModalBox.Close()
    End Sub

    Private Sub UsrFiles_Click(sender As Object, e As EventArgs) Handles UsrFilesLabel.Click, FolderIcon2.Click
        RetrieveFilesIn(My.Computer.FileSystem.SpecialDirectories.Desktop)
    End Sub

    Private Sub Files_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Hide()
        RetrieveFilesIn(My.Computer.FileSystem.SpecialDirectories.MyDocuments)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Files_Click(sender As Object, e As EventArgs)
        NEXAppLog.Log("app.files", "Opening file in notes")
        Notes.OpenNote(DirPath.Text & "\" & sender.Text)
    End Sub

    Private Sub Docs_Click(sender As Object, e As EventArgs) Handles Label3.Click, PictureBox4.Click
        RetrieveFilesIn(My.Computer.FileSystem.SpecialDirectories.MyDocuments)
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Return Then
            TextBox1.Hide()
            Try
                RetrieveFilesIn(TextBox1.Text)
            Catch ex As DirectoryNotFoundException
                NEXAppLog.Log("app.files", ex.ToString)
                NEXAppLog.Log("app.files", "it wasn't a directory")
                ModalBox.ShowModal("Directory Not Found", DirPath.Text & " is not a directory.", YesNoModal:=False)
                ModalBox.Close()
                RetrieveFilesIn(My.Computer.FileSystem.SpecialDirectories.MyDocuments)
            Catch ex As Exception
                NEXAppLog.Log("app.files", ex.ToString)
                FatalError.Show()
                FatalError.Stacktrace.Text = ex.ToString
                Me.Close()
            End Try
        End If
    End Sub

    Private Sub DirPath_Click(sender As Object, e As EventArgs) Handles DirPath.Click
        TextBox1.Show()
    End Sub

    Private Sub Me_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Desktop.ProcessKeys(e)
    End Sub
End Class