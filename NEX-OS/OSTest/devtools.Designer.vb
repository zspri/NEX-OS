<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class devtools
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AppLog = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ConsoleLog = New System.Windows.Forms.ListBox()
        Me.ConsoleLogBox = New System.Windows.Forms.TextBox()
        Me.ConsoleLogSend = New System.Windows.Forms.Button()
        Me.AppLogSend = New System.Windows.Forms.Button()
        Me.AppLogBox = New System.Windows.Forms.TextBox()
        Me.AppInfo = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(935, 57)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 47)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Developer Tools"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(893, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "×"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'AppLog
        '
        Me.AppLog.FormattingEnabled = True
        Me.AppLog.ItemHeight = 22
        Me.AppLog.Items.AddRange(New Object() {" "})
        Me.AppLog.Location = New System.Drawing.Point(17, 129)
        Me.AppLog.Name = "AppLog"
        Me.AppLog.ScrollAlwaysVisible = True
        Me.AppLog.Size = New System.Drawing.Size(388, 202)
        Me.AppLog.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(12, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(393, 47)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "App log"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(456, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(263, 47)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Console"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ConsoleLog
        '
        Me.ConsoleLog.FormattingEnabled = True
        Me.ConsoleLog.ItemHeight = 22
        Me.ConsoleLog.Items.AddRange(New Object() {" "})
        Me.ConsoleLog.Location = New System.Drawing.Point(461, 129)
        Me.ConsoleLog.Name = "ConsoleLog"
        Me.ConsoleLog.ScrollAlwaysVisible = True
        Me.ConsoleLog.Size = New System.Drawing.Size(388, 202)
        Me.ConsoleLog.TabIndex = 6
        '
        'ConsoleLogBox
        '
        Me.ConsoleLogBox.Location = New System.Drawing.Point(461, 346)
        Me.ConsoleLogBox.Name = "ConsoleLogBox"
        Me.ConsoleLogBox.Size = New System.Drawing.Size(282, 29)
        Me.ConsoleLogBox.TabIndex = 7
        '
        'ConsoleLogSend
        '
        Me.ConsoleLogSend.Location = New System.Drawing.Point(749, 346)
        Me.ConsoleLogSend.Name = "ConsoleLogSend"
        Me.ConsoleLogSend.Size = New System.Drawing.Size(100, 29)
        Me.ConsoleLogSend.TabIndex = 10
        Me.ConsoleLogSend.Text = "Send"
        Me.ConsoleLogSend.UseVisualStyleBackColor = True
        '
        'AppLogSend
        '
        Me.AppLogSend.Location = New System.Drawing.Point(305, 346)
        Me.AppLogSend.Name = "AppLogSend"
        Me.AppLogSend.Size = New System.Drawing.Size(100, 29)
        Me.AppLogSend.TabIndex = 12
        Me.AppLogSend.Text = "Send"
        Me.AppLogSend.UseVisualStyleBackColor = True
        '
        'AppLogBox
        '
        Me.AppLogBox.Location = New System.Drawing.Point(17, 346)
        Me.AppLogBox.Name = "AppLogBox"
        Me.AppLogBox.Size = New System.Drawing.Size(282, 29)
        Me.AppLogBox.TabIndex = 11
        '
        'AppInfo
        '
        Me.AppInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AppInfo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AppInfo.Location = New System.Drawing.Point(12, 435)
        Me.AppInfo.Name = "AppInfo"
        Me.AppInfo.Size = New System.Drawing.Size(906, 133)
        Me.AppInfo.TabIndex = 13
        Me.AppInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'devtools
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 577)
        Me.Controls.Add(Me.AppInfo)
        Me.Controls.Add(Me.AppLogSend)
        Me.Controls.Add(Me.AppLogBox)
        Me.Controls.Add(Me.ConsoleLogSend)
        Me.Controls.Add(Me.ConsoleLogBox)
        Me.Controls.Add(Me.ConsoleLog)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.AppLog)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Roboto", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "devtools"
        Me.Text = "devtools"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents AppLog As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ConsoleLog As ListBox
    Friend WithEvents ConsoleLogBox As TextBox
    Friend WithEvents ConsoleLogSend As Button
    Friend WithEvents AppLogSend As Button
    Friend WithEvents AppLogBox As TextBox
    Friend WithEvents AppInfo As Label
End Class
