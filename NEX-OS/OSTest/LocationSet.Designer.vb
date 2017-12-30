<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LocationSet
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxTitle = New System.Windows.Forms.Label()
        Me.PromptBox = New System.Windows.Forms.TextBox()
        Me.TextBoxBorder = New System.Windows.Forms.Panel()
        Me.TextBoxHelper = New System.Windows.Forms.Label()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.ConfirmButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 16.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Set your location"
        '
        'TextBoxTitle
        '
        Me.TextBoxTitle.AutoSize = True
        Me.TextBoxTitle.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.TextBoxTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBoxTitle.Location = New System.Drawing.Point(20, 92)
        Me.TextBoxTitle.Name = "TextBoxTitle"
        Me.TextBoxTitle.Size = New System.Drawing.Size(75, 20)
        Me.TextBoxTitle.TabIndex = 1
        Me.TextBoxTitle.Text = "Location"
        '
        'PromptBox
        '
        Me.PromptBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PromptBox.Font = New System.Drawing.Font("Roboto", 13.0!)
        Me.PromptBox.Location = New System.Drawing.Point(24, 115)
        Me.PromptBox.Name = "PromptBox"
        Me.PromptBox.Size = New System.Drawing.Size(200, 27)
        Me.PromptBox.TabIndex = 2
        '
        'TextBoxBorder
        '
        Me.TextBoxBorder.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBoxBorder.Location = New System.Drawing.Point(24, 143)
        Me.TextBoxBorder.Name = "TextBoxBorder"
        Me.TextBoxBorder.Size = New System.Drawing.Size(200, 2)
        Me.TextBoxBorder.TabIndex = 3
        '
        'TextBoxHelper
        '
        Me.TextBoxHelper.AutoSize = True
        Me.TextBoxHelper.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.TextBoxHelper.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBoxHelper.Location = New System.Drawing.Point(20, 156)
        Me.TextBoxHelper.Name = "TextBoxHelper"
        Me.TextBoxHelper.Size = New System.Drawing.Size(189, 18)
        Me.TextBoxHelper.TabIndex = 4
        Me.TextBoxHelper.Text = "This is used to get weather"
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.Gainsboro
        Me.CancelButton.FlatAppearance.BorderSize = 0
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelButton.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.CancelButton.ForeColor = System.Drawing.Color.Black
        Me.CancelButton.Location = New System.Drawing.Point(19, 205)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(99, 40)
        Me.CancelButton.TabIndex = 5
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'ConfirmButton
        '
        Me.ConfirmButton.BackColor = System.Drawing.Color.DodgerBlue
        Me.ConfirmButton.FlatAppearance.BorderSize = 0
        Me.ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConfirmButton.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.ConfirmButton.ForeColor = System.Drawing.Color.White
        Me.ConfirmButton.Location = New System.Drawing.Point(125, 205)
        Me.ConfirmButton.Name = "ConfirmButton"
        Me.ConfirmButton.Size = New System.Drawing.Size(99, 40)
        Me.ConfirmButton.TabIndex = 6
        Me.ConfirmButton.Text = "Confirm"
        Me.ConfirmButton.UseVisualStyleBackColor = False
        '
        'LocationSet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(956, 559)
        Me.Controls.Add(Me.ConfirmButton)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.TextBoxHelper)
        Me.Controls.Add(Me.TextBoxBorder)
        Me.Controls.Add(Me.PromptBox)
        Me.Controls.Add(Me.TextBoxTitle)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Roboto", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "LocationSet"
        Me.Text = "LocationSet"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxTitle As Label
    Friend WithEvents PromptBox As TextBox
    Friend WithEvents TextBoxBorder As Panel
    Friend WithEvents TextBoxHelper As Label
    Friend WithEvents CancelButton As Button
    Friend WithEvents ConfirmButton As Button
End Class
