Public Class ModalBox

    Dim yesBtnClicked = False
    Dim noBtnClicked = False
    Dim okBtnClicked = False

    Public Function ShowModal(Title As String, Text As String, Optional YesNoModal As Boolean = True)
        TitleLabel.Text = Title
        TextLabel.Text = Text
        yesBtnClicked = False
        noBtnClicked = False
        okBtnClicked = False
        Dim toReturn = -1
        Me.Show()
        Debug.Print("Not clicked")
        If YesNoModal Then
            OkBtn.Hide()
            YesBtn.Show()
            NoBtn.Show()
            Debug.Print("While loop started")
            While (yesBtnClicked = False) And (noBtnClicked = False)
                Me.BringToFront()
                Me.Activate()
                Application.DoEvents()
            End While
            Debug.Print("While loop finished")
            If yesBtnClicked Then
                toReturn = 1
            ElseIf noBtnClicked Then
                toReturn = 0
            End If
        Else
            OkBtn.Show()
            YesBtn.Hide()
            NoBtn.Hide()
            While okBtnClicked = False
                Application.DoEvents()
            End While
            Debug.Print("While loop finished")
            toReturn = 0
        End If
        Return toReturn
    End Function

    Private Sub YesBtn_Click(sender As Object, e As EventArgs) Handles YesBtn.Click
        Debug.Print("Clicked yes button")
        yesBtnClicked = True
    End Sub

    Private Sub NoBtn_Click(sender As Object, e As EventArgs) Handles NoBtn.Click
        Debug.Print("Clicked no button")
        noBtnClicked = True
    End Sub

    Private Sub OkBtn_Click(sender As Object, e As EventArgs) Handles OkBtn.Click
        Debug.Print("Clicked ok button")
        okBtnClicked = True
    End Sub
End Class