<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Files
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Files))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DirPath = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.FolderIcon2 = New System.Windows.Forms.PictureBox()
        Me.FolderIcon3 = New System.Windows.Forms.PictureBox()
        Me.SysFilesLabel = New System.Windows.Forms.Label()
        Me.UsrFilesLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FolderIcon2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FolderIcon3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DirPath)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-2, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(772, 110)
        Me.Panel1.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(15, 73)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(470, 31)
        Me.TextBox1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.2!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(523, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Click on a file to open it"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DirPath
        '
        Me.DirPath.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DirPath.BackColor = System.Drawing.Color.Transparent
        Me.DirPath.Font = New System.Drawing.Font("Segoe UI", 11.2!)
        Me.DirPath.ForeColor = System.Drawing.Color.White
        Me.DirPath.Location = New System.Drawing.Point(14, 73)
        Me.DirPath.Name = "DirPath"
        Me.DirPath.Size = New System.Drawing.Size(503, 28)
        Me.DirPath.TabIndex = 2
        Me.DirPath.Text = "Loading..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.DirPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(14, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(686, 50)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Files"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(706, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Controls.Add(Me.FolderIcon2)
        Me.Panel2.Controls.Add(Me.FolderIcon3)
        Me.Panel2.Controls.Add(Me.SysFilesLabel)
        Me.Panel2.Controls.Add(Me.UsrFilesLabel)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(-2, 102)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 348)
        Me.Panel2.TabIndex = 2
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(15, 9)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 8
        Me.PictureBox4.TabStop = False
        '
        'FolderIcon2
        '
        Me.FolderIcon2.Image = CType(resources.GetObject("FolderIcon2.Image"), System.Drawing.Image)
        Me.FolderIcon2.Location = New System.Drawing.Point(15, 37)
        Me.FolderIcon2.Name = "FolderIcon2"
        Me.FolderIcon2.Size = New System.Drawing.Size(28, 28)
        Me.FolderIcon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FolderIcon2.TabIndex = 7
        Me.FolderIcon2.TabStop = False
        '
        'FolderIcon3
        '
        Me.FolderIcon3.Image = CType(resources.GetObject("FolderIcon3.Image"), System.Drawing.Image)
        Me.FolderIcon3.Location = New System.Drawing.Point(15, 65)
        Me.FolderIcon3.Name = "FolderIcon3"
        Me.FolderIcon3.Size = New System.Drawing.Size(28, 28)
        Me.FolderIcon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FolderIcon3.TabIndex = 6
        Me.FolderIcon3.TabStop = False
        '
        'SysFilesLabel
        '
        Me.SysFilesLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SysFilesLabel.Font = New System.Drawing.Font("Segoe UI", 11.2!)
        Me.SysFilesLabel.ForeColor = System.Drawing.Color.White
        Me.SysFilesLabel.Location = New System.Drawing.Point(14, 65)
        Me.SysFilesLabel.Name = "SysFilesLabel"
        Me.SysFilesLabel.Size = New System.Drawing.Size(183, 28)
        Me.SysFilesLabel.TabIndex = 5
        Me.SysFilesLabel.Text = "System"
        Me.SysFilesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UsrFilesLabel
        '
        Me.UsrFilesLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UsrFilesLabel.Font = New System.Drawing.Font("Segoe UI", 11.2!)
        Me.UsrFilesLabel.ForeColor = System.Drawing.Color.White
        Me.UsrFilesLabel.Location = New System.Drawing.Point(14, 37)
        Me.UsrFilesLabel.Name = "UsrFilesLabel"
        Me.UsrFilesLabel.Size = New System.Drawing.Size(183, 28)
        Me.UsrFilesLabel.TabIndex = 4
        Me.UsrFilesLabel.Text = "User Files"
        Me.UsrFilesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.2!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(14, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 28)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "My Documents"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Files
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 445)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Files"
        Me.Text = "Files"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FolderIcon2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FolderIcon3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DirPath As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents FolderIcon2 As PictureBox
    Friend WithEvents FolderIcon3 As PictureBox
    Friend WithEvents SysFilesLabel As Label
    Friend WithEvents UsrFilesLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
