<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlarmSet
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
        Me.ConfirmButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.TextBoxHelper = New System.Windows.Forms.Label()
        Me.TextBoxBorder = New System.Windows.Forms.Panel()
        Me.HourLabel = New System.Windows.Forms.TextBox()
        Me.TextBoxTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxBorder2 = New System.Windows.Forms.Panel()
        Me.MinuteLabel = New System.Windows.Forms.TextBox()
        Me.TextBoxTitle2 = New System.Windows.Forms.Label()
        Me.AMBtn = New System.Windows.Forms.RadioButton()
        Me.PMBtn = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'ConfirmButton
        '
        Me.ConfirmButton.BackColor = System.Drawing.Color.DodgerBlue
        Me.ConfirmButton.FlatAppearance.BorderSize = 0
        Me.ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConfirmButton.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.ConfirmButton.ForeColor = System.Drawing.Color.White
        Me.ConfirmButton.Location = New System.Drawing.Point(125, 267)
        Me.ConfirmButton.Name = "ConfirmButton"
        Me.ConfirmButton.Size = New System.Drawing.Size(99, 40)
        Me.ConfirmButton.TabIndex = 13
        Me.ConfirmButton.Text = "Confirm"
        Me.ConfirmButton.UseVisualStyleBackColor = False
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.Gainsboro
        Me.CancelButton.FlatAppearance.BorderSize = 0
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelButton.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.CancelButton.ForeColor = System.Drawing.Color.Black
        Me.CancelButton.Location = New System.Drawing.Point(19, 267)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(99, 40)
        Me.CancelButton.TabIndex = 12
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'TextBoxHelper
        '
        Me.TextBoxHelper.AutoSize = True
        Me.TextBoxHelper.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.TextBoxHelper.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBoxHelper.Location = New System.Drawing.Point(20, 156)
        Me.TextBoxHelper.Name = "TextBoxHelper"
        Me.TextBoxHelper.Size = New System.Drawing.Size(106, 18)
        Me.TextBoxHelper.TabIndex = 11
        Me.TextBoxHelper.Text = "Choose a time"
        '
        'TextBoxBorder
        '
        Me.TextBoxBorder.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBoxBorder.Location = New System.Drawing.Point(24, 143)
        Me.TextBoxBorder.Name = "TextBoxBorder"
        Me.TextBoxBorder.Size = New System.Drawing.Size(66, 2)
        Me.TextBoxBorder.TabIndex = 10
        '
        'HourLabel
        '
        Me.HourLabel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.HourLabel.Font = New System.Drawing.Font("Roboto", 13.0!)
        Me.HourLabel.Location = New System.Drawing.Point(24, 115)
        Me.HourLabel.Name = "HourLabel"
        Me.HourLabel.Size = New System.Drawing.Size(66, 27)
        Me.HourLabel.TabIndex = 9
        '
        'TextBoxTitle
        '
        Me.TextBoxTitle.AutoSize = True
        Me.TextBoxTitle.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.TextBoxTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBoxTitle.Location = New System.Drawing.Point(20, 92)
        Me.TextBoxTitle.Name = "TextBoxTitle"
        Me.TextBoxTitle.Size = New System.Drawing.Size(46, 20)
        Me.TextBoxTitle.TabIndex = 8
        Me.TextBoxTitle.Text = "Hour"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 16.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 34)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Set an alarm"
        '
        'TextBoxBorder2
        '
        Me.TextBoxBorder2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBoxBorder2.Location = New System.Drawing.Point(111, 143)
        Me.TextBoxBorder2.Name = "TextBoxBorder2"
        Me.TextBoxBorder2.Size = New System.Drawing.Size(98, 2)
        Me.TextBoxBorder2.TabIndex = 13
        '
        'MinuteLabel
        '
        Me.MinuteLabel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MinuteLabel.Font = New System.Drawing.Font("Roboto", 13.0!)
        Me.MinuteLabel.Location = New System.Drawing.Point(111, 115)
        Me.MinuteLabel.Name = "MinuteLabel"
        Me.MinuteLabel.Size = New System.Drawing.Size(98, 27)
        Me.MinuteLabel.TabIndex = 12
        '
        'TextBoxTitle2
        '
        Me.TextBoxTitle2.AutoSize = True
        Me.TextBoxTitle2.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.TextBoxTitle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBoxTitle2.Location = New System.Drawing.Point(107, 92)
        Me.TextBoxTitle2.Name = "TextBoxTitle2"
        Me.TextBoxTitle2.Size = New System.Drawing.Size(61, 20)
        Me.TextBoxTitle2.TabIndex = 11
        Me.TextBoxTitle2.Text = "Minute"
        '
        'AMBtn
        '
        Me.AMBtn.AutoSize = True
        Me.AMBtn.Checked = True
        Me.AMBtn.FlatAppearance.BorderSize = 0
        Me.AMBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue
        Me.AMBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.AMBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AMBtn.Font = New System.Drawing.Font("Roboto", 9.5!)
        Me.AMBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AMBtn.Location = New System.Drawing.Point(24, 197)
        Me.AMBtn.Name = "AMBtn"
        Me.AMBtn.Size = New System.Drawing.Size(53, 23)
        Me.AMBtn.TabIndex = 14
        Me.AMBtn.TabStop = True
        Me.AMBtn.Text = "AM"
        Me.AMBtn.UseVisualStyleBackColor = True
        '
        'PMBtn
        '
        Me.PMBtn.AutoSize = True
        Me.PMBtn.FlatAppearance.BorderSize = 0
        Me.PMBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue
        Me.PMBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PMBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PMBtn.Font = New System.Drawing.Font("Roboto", 9.5!)
        Me.PMBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PMBtn.Location = New System.Drawing.Point(88, 197)
        Me.PMBtn.Name = "PMBtn"
        Me.PMBtn.Size = New System.Drawing.Size(53, 23)
        Me.PMBtn.TabIndex = 15
        Me.PMBtn.Text = "PM"
        Me.PMBtn.UseVisualStyleBackColor = True
        '
        'AlarmSet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(913, 574)
        Me.Controls.Add(Me.PMBtn)
        Me.Controls.Add(Me.AMBtn)
        Me.Controls.Add(Me.TextBoxBorder2)
        Me.Controls.Add(Me.MinuteLabel)
        Me.Controls.Add(Me.ConfirmButton)
        Me.Controls.Add(Me.TextBoxTitle2)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.TextBoxHelper)
        Me.Controls.Add(Me.TextBoxBorder)
        Me.Controls.Add(Me.HourLabel)
        Me.Controls.Add(Me.TextBoxTitle)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AlarmSet"
        Me.Text = "AlarmSet"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ConfirmButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents TextBoxHelper As Label
    Friend WithEvents TextBoxBorder As Panel
    Friend WithEvents HourLabel As TextBox
    Friend WithEvents TextBoxTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxBorder2 As Panel
    Friend WithEvents MinuteLabel As TextBox
    Friend WithEvents TextBoxTitle2 As Label
    Friend WithEvents AMBtn As RadioButton
    Friend WithEvents PMBtn As RadioButton
End Class
