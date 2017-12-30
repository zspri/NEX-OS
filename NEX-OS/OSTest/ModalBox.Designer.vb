<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModalBox
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModalBox))
        Me.TextLabel = New System.Windows.Forms.Label()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.YesBtn = New System.Windows.Forms.Button()
        Me.NoBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextLabel
        '
        Me.TextLabel.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.TextLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextLabel.Location = New System.Drawing.Point(74, 113)
        Me.TextLabel.Name = "TextLabel"
        Me.TextLabel.Size = New System.Drawing.Size(463, 197)
        Me.TextLabel.TabIndex = 3
        Me.TextLabel.Text = "Modal Text"
        '
        'TitleLabel
        '
        Me.TitleLabel.Font = New System.Drawing.Font("Roboto", 16.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(72, 65)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(465, 34)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "Modal Title"
        '
        'YesBtn
        '
        Me.YesBtn.BackColor = System.Drawing.Color.DodgerBlue
        Me.YesBtn.FlatAppearance.BorderSize = 0
        Me.YesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.YesBtn.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.YesBtn.ForeColor = System.Drawing.Color.White
        Me.YesBtn.Location = New System.Drawing.Point(438, 313)
        Me.YesBtn.Name = "YesBtn"
        Me.YesBtn.Size = New System.Drawing.Size(99, 40)
        Me.YesBtn.TabIndex = 8
        Me.YesBtn.Text = "Confirm"
        Me.YesBtn.UseVisualStyleBackColor = False
        '
        'NoBtn
        '
        Me.NoBtn.BackColor = System.Drawing.Color.Gainsboro
        Me.NoBtn.FlatAppearance.BorderSize = 0
        Me.NoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NoBtn.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.NoBtn.ForeColor = System.Drawing.Color.Black
        Me.NoBtn.Location = New System.Drawing.Point(333, 313)
        Me.NoBtn.Name = "NoBtn"
        Me.NoBtn.Size = New System.Drawing.Size(99, 40)
        Me.NoBtn.TabIndex = 7
        Me.NoBtn.Text = "Cancel"
        Me.NoBtn.UseVisualStyleBackColor = False
        '
        'ModalBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(611, 419)
        Me.Controls.Add(Me.YesBtn)
        Me.Controls.Add(Me.NoBtn)
        Me.Controls.Add(Me.TextLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ModalBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ShutdownModal"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextLabel As Label
    Friend WithEvents TitleLabel As Label
    Friend WithEvents YesBtn As Button
    Friend WithEvents NoBtn As Button
End Class
