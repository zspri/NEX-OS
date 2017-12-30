Public Class ModalBox

    Dim yesBtnClicked = False
    Dim noBtnClicked = False
    Dim okBtnClicked = False

    Public Function ShowModal(Title As String, Text As String, Optional YesNoModal As Boolean = True)
        NEXAppLog.Log("desk.modal", "Showing modal")
        TitleLabel.Text = Title
        TextLabel.Text = Text
        yesBtnClicked = False
        noBtnClicked = False
        Dim toReturn = -1
        Me.Show()
        NEXAppLog.Log("desk.modal", "Not clicked")
        If YesNoModal Then
            YesBtn.Text = "Confirm"
            NoBtn.Show()
            NEXAppLog.Log("desk.modal", "Started loop")
            Do Until yesBtnClicked Or noBtnClicked
                Application.DoEvents()
            Loop
            NEXAppLog.Log("desk.modal", "Finished loop")
            If yesBtnClicked Then
                toReturn = True
            ElseIf noBtnClicked Then
                toReturn = False
            End If
        Else
            YesBtn.Text = "OK"
            NoBtn.Hide()
            NEXAppLog.Log("desk.modal", "Started loop")
            Do Until yesBtnClicked
                Application.DoEvents()
            Loop
            NEXAppLog.Log("desk.modal", "Finished loop")
            toReturn = True
        End If
        Return toReturn
    End Function

    Private Sub YesBtn_Click(sender As Object, e As EventArgs) Handles YesBtn.Click
        yesBtnClicked = True
        NEXAppLog.Log("desk.modal", "Button clicked")
    End Sub

    Private Sub NoBtn_Click(sender As Object, e As EventArgs) Handles NoBtn.Click
        noBtnClicked = True
        NEXAppLog.Log("desk.modal", "Button clicked")
    End Sub
End Class