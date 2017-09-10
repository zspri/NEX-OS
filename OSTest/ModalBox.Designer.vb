<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModalBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModalBox))
        Me.YesBtn = New System.Windows.Forms.PictureBox()
        Me.NoBtn = New System.Windows.Forms.PictureBox()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.TextLabel = New System.Windows.Forms.Label()
        Me.OkBtn = New System.Windows.Forms.PictureBox()
        CType(Me.YesBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OkBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'YesBtn
        '
        Me.YesBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.YesBtn.Image = CType(resources.GetObject("YesBtn.Image"), System.Drawing.Image)
        Me.YesBtn.Location = New System.Drawing.Point(12, 436)
        Me.YesBtn.Name = "YesBtn"
        Me.YesBtn.Size = New System.Drawing.Size(200, 50)
        Me.YesBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.YesBtn.TabIndex = 0
        Me.YesBtn.TabStop = False
        '
        'NoBtn
        '
        Me.NoBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NoBtn.Image = CType(resources.GetObject("NoBtn.Image"), System.Drawing.Image)
        Me.NoBtn.Location = New System.Drawing.Point(502, 436)
        Me.NoBtn.Name = "NoBtn"
        Me.NoBtn.Size = New System.Drawing.Size(200, 50)
        Me.NoBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.NoBtn.TabIndex = 1
        Me.NoBtn.TabStop = False
        '
        'TitleLabel
        '
        Me.TitleLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(12, 9)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(690, 46)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextLabel
        '
        Me.TextLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TextLabel.Location = New System.Drawing.Point(12, 55)
        Me.TextLabel.Name = "TextLabel"
        Me.TextLabel.Size = New System.Drawing.Size(690, 376)
        Me.TextLabel.TabIndex = 3
        Me.TextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OkBtn
        '
        Me.OkBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.OkBtn.Image = CType(resources.GetObject("OkBtn.Image"), System.Drawing.Image)
        Me.OkBtn.Location = New System.Drawing.Point(251, 436)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(213, 50)
        Me.OkBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.OkBtn.TabIndex = 4
        Me.OkBtn.TabStop = False
        '
        'ModalBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(714, 496)
        Me.Controls.Add(Me.TextLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.NoBtn)
        Me.Controls.Add(Me.YesBtn)
        Me.Controls.Add(Me.OkBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ModalBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ShutdownModal"
        Me.TopMost = True
        CType(Me.YesBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OkBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents YesBtn As PictureBox
    Friend WithEvents NoBtn As PictureBox
    Friend WithEvents TitleLabel As Label
    Friend WithEvents TextLabel As Label
    Friend WithEvents OkBtn As PictureBox
End Class
