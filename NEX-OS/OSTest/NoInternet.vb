Imports System.Net

Public Class NoInternet
    Dim FirstInformationExpand As Boolean = True

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub NoInternet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MoreInfo.Hide()
    End Sub

    Private Sub ShowMore_Click(sender As Object, e As EventArgs) Handles ShowMore.Click
        If MoreInfo.Visible Then
            MoreInfo.Hide()
            ShowMore.Text = "Show more ➜"
        Else
            Dim PCName As String = Dns.GetHostName.ToString
            Dim myIPHost As System.Net.IPHostEntry = Dns.GetHostEntry(PCName)
            Dim myIP As System.Net.IPAddress = myIPHost.AddressList(0)
            If FirstInformationExpand Then
                MoreInfo.Text = MoreInfo.Text & vbCrLf & vbCrLf &
                "Debug information: " & vbCrLf &
                "Networking available? " & My.Computer.Network.IsAvailable.ToString & vbCrLf &
                "Network type: " & My.Computer.Network.GetType.ToString & vbCrLf &
                "Network entry: " & myIPHost.ToString & vbCrLf &
                "IP address: " & myIP.ToString & vbCrLf &
                "Machine name: " & PCName
                FirstInformationExpand = False
            End If
            MoreInfo.Show()
                ShowMore.Text = "Show less ➜"
            End If
    End Sub
End Class