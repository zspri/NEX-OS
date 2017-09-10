﻿Imports System.IO

Public Class Notes

    Dim EditMode = True
    Dim fpath = ""

    Public Function OpenNote(Optional FilePath As String = "")
        If Not (FilePath = "") Then
            Me.Show()
            EditMode = False
            fpath = FilePath
            Label1.Text = Path.GetFileName(FilePath) & " - Notes"
            Try
                TextBox1.Text = My.Computer.FileSystem.ReadAllText(FilePath)
            Catch ex As Exception
                ModalBox.ShowModal("An Error Occurred", "An unexpected error occurred while reading this file." & vbCrLf & vbCrLf & ex.ToString, YesNoModal:=False)
                ModalBox.Close()
                Me.Close()
            End Try
        Else
            EditMode = True
            TextBox1.Text = My.Settings.Note
        End If
        Return 0
    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If EditMode Then
            My.Settings.Note = TextBox1.Text
        End If
    End Sub

    Private Sub Notes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If EditMode Then
            OpenNote()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If EditMode Then
            My.Settings.Save()
        Else
            Dim modalResult = ModalBox.ShowModal("Save changes?", "You have unsaved changes. Would you like to save them?")
            ModalBox.Close()
            If modalResult = 1 Then
                Try
                    My.Computer.FileSystem.WriteAllText(fpath, TextBox1.Text, False)
                Catch ex As Exception
                    ModalBox.ShowModal("An Error Occurred", "An unexpected error occurred while writing to this file." & vbCrLf & vbCrLf & ex.ToString, YesNoModal:=False)
                    ModalBox.Close()
                    Me.Close()
                End Try
            End If
        End If
        Me.Close()
        EditMode = True
    End Sub
End Class