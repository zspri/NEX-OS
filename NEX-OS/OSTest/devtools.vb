Public Class devtools
    Private Sub AppLogSend_Click(sender As Object, e As EventArgs) Handles AppLogSend.Click
        NEXAppLog.Log("nex.dev", AppLogBox.Text)
        AppLogBox.Text = ""
    End Sub

    Private Sub ConsoleLogSend_Click(sender As Object, e As EventArgs) Handles ConsoleLogSend.Click

    End Sub

    Private Sub AppInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim t As Type = GetType(SimpleListener)
        AppInfo.Text = t.FullName & ", " & t.Assembly.FullName
        MsgBox(AppInfo.Text)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub
End Class

Public Class SimpleListener
    Inherits System.Diagnostics.TraceListener

    <Security.Permissions.HostProtection(Synchronization:=True)>
    Public Overloads Overrides Sub Write(ByVal message As String)
        devtools.AppLog.Items.Add(message)
    End Sub

    <Security.Permissions.HostProtection(Synchronization:=True)>
    Public Overloads Overrides Sub WriteLine(ByVal message As String)
        devtools.AppLog.Items.Add(message)
    End Sub
End Class

Public Class NEXAppLog
    Public Shared Sub Log(ByVal sender As String, ByVal message As String)
        devtools.AppLog.Items.Add("[" & sender & "] " & message)
    End Sub
End Class