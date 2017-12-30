<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clock
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clock))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.ActiveMode = New System.Windows.Forms.Label()
        Me.InactiveModeRight = New System.Windows.Forms.Label()
        Me.InactiveModeLeft = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LastLap = New System.Windows.Forms.Label()
        Me.StopBtn = New System.Windows.Forms.PictureBox()
        Me.PauseBtn = New System.Windows.Forms.PictureBox()
        Me.RestartBtn = New System.Windows.Forms.PictureBox()
        Me.PlayBtn = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.SetAlarmBtn = New System.Windows.Forms.Button()
        Me.StopAlarmBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.StopBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PauseBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestartBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(788, 55)
        Me.Panel1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(702, -3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 67)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "_"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 47)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Clock"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(746, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "×"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TimeLabel
        '
        Me.TimeLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TimeLabel.Font = New System.Drawing.Font("Uni Sans Thin CAPS", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabel.Location = New System.Drawing.Point(12, 142)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(760, 85)
        Me.TimeLabel.TabIndex = 3
        Me.TimeLabel.Text = "0:00.00"
        Me.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ActiveMode
        '
        Me.ActiveMode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ActiveMode.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActiveMode.Location = New System.Drawing.Point(334, 227)
        Me.ActiveMode.Name = "ActiveMode"
        Me.ActiveMode.Size = New System.Drawing.Size(116, 30)
        Me.ActiveMode.TabIndex = 4
        Me.ActiveMode.Text = "CLOCK"
        Me.ActiveMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'InactiveModeRight
        '
        Me.InactiveModeRight.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.InactiveModeRight.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.InactiveModeRight.Location = New System.Drawing.Point(456, 227)
        Me.InactiveModeRight.Name = "InactiveModeRight"
        Me.InactiveModeRight.Size = New System.Drawing.Size(116, 30)
        Me.InactiveModeRight.TabIndex = 5
        Me.InactiveModeRight.Text = "STOPWATCH"
        Me.InactiveModeRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'InactiveModeLeft
        '
        Me.InactiveModeLeft.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.InactiveModeLeft.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.InactiveModeLeft.Location = New System.Drawing.Point(212, 227)
        Me.InactiveModeLeft.Name = "InactiveModeLeft"
        Me.InactiveModeLeft.Size = New System.Drawing.Size(116, 30)
        Me.InactiveModeLeft.TabIndex = 6
        Me.InactiveModeLeft.Text = "ALARM"
        Me.InactiveModeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(367, 254)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(50, 2)
        Me.Panel2.TabIndex = 7
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'LastLap
        '
        Me.LastLap.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LastLap.Font = New System.Drawing.Font("Roboto", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastLap.Location = New System.Drawing.Point(12, 104)
        Me.LastLap.Name = "LastLap"
        Me.LastLap.Size = New System.Drawing.Size(760, 38)
        Me.LastLap.TabIndex = 13
        Me.LastLap.Text = "LAST LAP" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0:00:00.000"
        Me.LastLap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StopBtn
        '
        Me.StopBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.StopBtn.Image = CType(resources.GetObject("StopBtn.Image"), System.Drawing.Image)
        Me.StopBtn.Location = New System.Drawing.Point(184, 23)
        Me.StopBtn.Name = "StopBtn"
        Me.StopBtn.Size = New System.Drawing.Size(48, 48)
        Me.StopBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.StopBtn.TabIndex = 12
        Me.StopBtn.TabStop = False
        '
        'PauseBtn
        '
        Me.PauseBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PauseBtn.Image = CType(resources.GetObject("PauseBtn.Image"), System.Drawing.Image)
        Me.PauseBtn.Location = New System.Drawing.Point(115, 23)
        Me.PauseBtn.Name = "PauseBtn"
        Me.PauseBtn.Size = New System.Drawing.Size(48, 48)
        Me.PauseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PauseBtn.TabIndex = 11
        Me.PauseBtn.TabStop = False
        '
        'RestartBtn
        '
        Me.RestartBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RestartBtn.Image = CType(resources.GetObject("RestartBtn.Image"), System.Drawing.Image)
        Me.RestartBtn.Location = New System.Drawing.Point(0, 28)
        Me.RestartBtn.Name = "RestartBtn"
        Me.RestartBtn.Size = New System.Drawing.Size(40, 40)
        Me.RestartBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.RestartBtn.TabIndex = 10
        Me.RestartBtn.TabStop = False
        '
        'PlayBtn
        '
        Me.PlayBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PlayBtn.Image = CType(resources.GetObject("PlayBtn.Image"), System.Drawing.Image)
        Me.PlayBtn.Location = New System.Drawing.Point(61, 23)
        Me.PlayBtn.Name = "PlayBtn"
        Me.PlayBtn.Size = New System.Drawing.Size(48, 48)
        Me.PlayBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PlayBtn.TabIndex = 8
        Me.PlayBtn.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.Controls.Add(Me.RestartBtn)
        Me.Panel3.Controls.Add(Me.PlayBtn)
        Me.Panel3.Controls.Add(Me.StopBtn)
        Me.Panel3.Controls.Add(Me.PauseBtn)
        Me.Panel3.Location = New System.Drawing.Point(276, 317)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(232, 100)
        Me.Panel3.TabIndex = 14
        '
        'SetAlarmBtn
        '
        Me.SetAlarmBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SetAlarmBtn.BackColor = System.Drawing.Color.Gainsboro
        Me.SetAlarmBtn.FlatAppearance.BorderSize = 0
        Me.SetAlarmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetAlarmBtn.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.SetAlarmBtn.ForeColor = System.Drawing.Color.Black
        Me.SetAlarmBtn.Location = New System.Drawing.Point(395, 423)
        Me.SetAlarmBtn.Name = "SetAlarmBtn"
        Me.SetAlarmBtn.Size = New System.Drawing.Size(113, 40)
        Me.SetAlarmBtn.TabIndex = 15
        Me.SetAlarmBtn.Text = "Set Alarm"
        Me.SetAlarmBtn.UseVisualStyleBackColor = False
        Me.SetAlarmBtn.Visible = False
        '
        'StopAlarmBtn
        '
        Me.StopAlarmBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.StopAlarmBtn.BackColor = System.Drawing.Color.Gainsboro
        Me.StopAlarmBtn.FlatAppearance.BorderSize = 0
        Me.StopAlarmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StopAlarmBtn.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.StopAlarmBtn.ForeColor = System.Drawing.Color.Black
        Me.StopAlarmBtn.Location = New System.Drawing.Point(276, 423)
        Me.StopAlarmBtn.Name = "StopAlarmBtn"
        Me.StopAlarmBtn.Size = New System.Drawing.Size(113, 40)
        Me.StopAlarmBtn.TabIndex = 16
        Me.StopAlarmBtn.Text = "Stop Alarm"
        Me.StopAlarmBtn.UseVisualStyleBackColor = False
        Me.StopAlarmBtn.Visible = False
        '
        'Clock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 540)
        Me.Controls.Add(Me.StopAlarmBtn)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.LastLap)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.InactiveModeLeft)
        Me.Controls.Add(Me.SetAlarmBtn)
        Me.Controls.Add(Me.InactiveModeRight)
        Me.Controls.Add(Me.ActiveMode)
        Me.Controls.Add(Me.TimeLabel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Clock"
        Me.Text = "t"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.StopBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PauseBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestartBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TimeLabel As Label
    Friend WithEvents ActiveMode As Label
    Friend WithEvents InactiveModeRight As Label
    Friend WithEvents InactiveModeLeft As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PlayBtn As PictureBox
    Friend WithEvents RestartBtn As PictureBox
    Friend WithEvents PauseBtn As PictureBox
    Friend WithEvents StopBtn As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents LastLap As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents SetAlarmBtn As Button
    Friend WithEvents StopAlarmBtn As Button
End Class
