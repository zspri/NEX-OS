<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Desktop
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Desktop))
        Me.DeskBar = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GSearchBar = New System.Windows.Forms.TextBox()
        Me.DeskTime = New System.Windows.Forms.Label()
        Me.DeskDate = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BrowserIcon = New System.Windows.Forms.PictureBox()
        Me.SettingsIcon = New System.Windows.Forms.PictureBox()
        Me.PaintIcon = New System.Windows.Forms.PictureBox()
        Me.NotesIcon = New System.Windows.Forms.PictureBox()
        Me.FilesIcon = New System.Windows.Forms.PictureBox()
        Me.DeskBar.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.BrowserIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SettingsIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaintIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotesIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FilesIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DeskBar
        '
        Me.DeskBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DeskBar.BackColor = System.Drawing.Color.Transparent
        Me.DeskBar.Controls.Add(Me.PictureBox3)
        Me.DeskBar.Controls.Add(Me.PictureBox2)
        Me.DeskBar.Controls.Add(Me.PictureBox1)
        Me.DeskBar.Location = New System.Drawing.Point(-1, -1)
        Me.DeskBar.Name = "DeskBar"
        Me.DeskBar.Size = New System.Drawing.Size(66, 564)
        Me.DeskBar.TabIndex = 0
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(33, 520)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1, 520)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Controls.Add(Me.GSearchBar)
        Me.Panel1.Location = New System.Drawing.Point(215, 241)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(477, 76)
        Me.Panel1.TabIndex = 3
        '
        'GSearchBar
        '
        Me.GSearchBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GSearchBar.Font = New System.Drawing.Font("Segoe UI Semilight", 9.5!)
        Me.GSearchBar.Location = New System.Drawing.Point(52, 27)
        Me.GSearchBar.Name = "GSearchBar"
        Me.GSearchBar.Size = New System.Drawing.Size(405, 22)
        Me.GSearchBar.TabIndex = 0
        '
        'DeskTime
        '
        Me.DeskTime.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DeskTime.BackColor = System.Drawing.Color.Transparent
        Me.DeskTime.Font = New System.Drawing.Font("Segoe UI Light", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeskTime.ForeColor = System.Drawing.Color.White
        Me.DeskTime.Location = New System.Drawing.Point(231, 75)
        Me.DeskTime.Name = "DeskTime"
        Me.DeskTime.Size = New System.Drawing.Size(444, 107)
        Me.DeskTime.TabIndex = 5
        Me.DeskTime.Text = "12:00"
        Me.DeskTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'DeskDate
        '
        Me.DeskDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DeskDate.BackColor = System.Drawing.Color.Transparent
        Me.DeskDate.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.DeskDate.ForeColor = System.Drawing.Color.White
        Me.DeskDate.Location = New System.Drawing.Point(228, 182)
        Me.DeskDate.Name = "DeskDate"
        Me.DeskDate.Size = New System.Drawing.Size(444, 29)
        Me.DeskDate.TabIndex = 6
        Me.DeskDate.Text = "January 1, 1969"
        Me.DeskDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.BrowserIcon)
        Me.Panel2.Controls.Add(Me.SettingsIcon)
        Me.Panel2.Controls.Add(Me.PaintIcon)
        Me.Panel2.Controls.Add(Me.NotesIcon)
        Me.Panel2.Controls.Add(Me.FilesIcon)
        Me.Panel2.Location = New System.Drawing.Point(159, 345)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(588, 168)
        Me.Panel2.TabIndex = 7
        '
        'BrowserIcon
        '
        Me.BrowserIcon.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BrowserIcon.Image = CType(resources.GetObject("BrowserIcon.Image"), System.Drawing.Image)
        Me.BrowserIcon.Location = New System.Drawing.Point(454, 8)
        Me.BrowserIcon.Name = "BrowserIcon"
        Me.BrowserIcon.Size = New System.Drawing.Size(72, 72)
        Me.BrowserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BrowserIcon.TabIndex = 4
        Me.BrowserIcon.TabStop = False
        '
        'SettingsIcon
        '
        Me.SettingsIcon.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SettingsIcon.Image = CType(resources.GetObject("SettingsIcon.Image"), System.Drawing.Image)
        Me.SettingsIcon.Location = New System.Drawing.Point(62, 8)
        Me.SettingsIcon.Name = "SettingsIcon"
        Me.SettingsIcon.Size = New System.Drawing.Size(72, 72)
        Me.SettingsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SettingsIcon.TabIndex = 3
        Me.SettingsIcon.TabStop = False
        '
        'PaintIcon
        '
        Me.PaintIcon.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PaintIcon.Image = CType(resources.GetObject("PaintIcon.Image"), System.Drawing.Image)
        Me.PaintIcon.Location = New System.Drawing.Point(160, 8)
        Me.PaintIcon.Name = "PaintIcon"
        Me.PaintIcon.Size = New System.Drawing.Size(72, 72)
        Me.PaintIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PaintIcon.TabIndex = 2
        Me.PaintIcon.TabStop = False
        '
        'NotesIcon
        '
        Me.NotesIcon.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.NotesIcon.Image = CType(resources.GetObject("NotesIcon.Image"), System.Drawing.Image)
        Me.NotesIcon.Location = New System.Drawing.Point(356, 8)
        Me.NotesIcon.Name = "NotesIcon"
        Me.NotesIcon.Size = New System.Drawing.Size(72, 72)
        Me.NotesIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.NotesIcon.TabIndex = 1
        Me.NotesIcon.TabStop = False
        '
        'FilesIcon
        '
        Me.FilesIcon.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.FilesIcon.Image = CType(resources.GetObject("FilesIcon.Image"), System.Drawing.Image)
        Me.FilesIcon.Location = New System.Drawing.Point(258, 8)
        Me.FilesIcon.Name = "FilesIcon"
        Me.FilesIcon.Size = New System.Drawing.Size(72, 72)
        Me.FilesIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FilesIcon.TabIndex = 0
        Me.FilesIcon.TabStop = False
        '
        'Desktop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(841, 557)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DeskDate)
        Me.Controls.Add(Me.DeskTime)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DeskBar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Desktop"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.DeskBar.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.BrowserIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SettingsIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaintIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotesIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FilesIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DeskBar As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GSearchBar As TextBox
    Friend WithEvents DeskTime As Label
    Friend WithEvents DeskDate As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FilesIcon As PictureBox
    Friend WithEvents BrowserIcon As PictureBox
    Friend WithEvents SettingsIcon As PictureBox
    Friend WithEvents PaintIcon As PictureBox
    Friend WithEvents NotesIcon As PictureBox
End Class
