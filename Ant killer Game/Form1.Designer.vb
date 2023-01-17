<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Ant1 = New System.Windows.Forms.PictureBox()
        Me.Ant2 = New System.Windows.Forms.PictureBox()
        Me.Ant3 = New System.Windows.Forms.PictureBox()
        Me.Ant4 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NameLb = New System.Windows.Forms.Label()
        Me.HighScoreLb = New System.Windows.Forms.Label()
        Me.LevelLb = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.PauseBtn = New System.Windows.Forms.Button()
        Me.StartBtn = New System.Windows.Forms.Button()
        Me.ScoreLb = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartNewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoundCheckMenu = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.Ant1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ant2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ant3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ant4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ant1
        '
        Me.Ant1.BackColor = System.Drawing.Color.Transparent
        Me.Ant1.Image = Global.Ant_killer_Game.My.Resources.Resources.first
        Me.Ant1.Location = New System.Drawing.Point(12, 291)
        Me.Ant1.Name = "Ant1"
        Me.Ant1.Size = New System.Drawing.Size(42, 64)
        Me.Ant1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Ant1.TabIndex = 0
        Me.Ant1.TabStop = False
        '
        'Ant2
        '
        Me.Ant2.BackColor = System.Drawing.Color.Transparent
        Me.Ant2.Image = Global.Ant_killer_Game.My.Resources.Resources.first
        Me.Ant2.Location = New System.Drawing.Point(110, 365)
        Me.Ant2.Name = "Ant2"
        Me.Ant2.Size = New System.Drawing.Size(42, 64)
        Me.Ant2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Ant2.TabIndex = 0
        Me.Ant2.TabStop = False
        '
        'Ant3
        '
        Me.Ant3.BackColor = System.Drawing.Color.Transparent
        Me.Ant3.Image = Global.Ant_killer_Game.My.Resources.Resources.first
        Me.Ant3.Location = New System.Drawing.Point(230, 403)
        Me.Ant3.Name = "Ant3"
        Me.Ant3.Size = New System.Drawing.Size(42, 64)
        Me.Ant3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Ant3.TabIndex = 0
        Me.Ant3.TabStop = False
        '
        'Ant4
        '
        Me.Ant4.BackColor = System.Drawing.Color.Transparent
        Me.Ant4.Image = Global.Ant_killer_Game.My.Resources.Resources.first
        Me.Ant4.Location = New System.Drawing.Point(352, 491)
        Me.Ant4.Name = "Ant4"
        Me.Ant4.Size = New System.Drawing.Size(42, 64)
        Me.Ant4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Ant4.TabIndex = 0
        Me.Ant4.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Ant_killer_Game.My.Resources.Resources.bgcorrect
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.ExitBtn)
        Me.Panel1.Controls.Add(Me.PauseBtn)
        Me.Panel1.Controls.Add(Me.StartBtn)
        Me.Panel1.Location = New System.Drawing.Point(-7, 492)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(427, 134)
        Me.Panel1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.NameLb)
        Me.GroupBox1.Controls.Add(Me.HighScoreLb)
        Me.GroupBox1.Controls.Add(Me.LevelLb)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(8, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 83)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Game Infomation"
        '
        'NameLb
        '
        Me.NameLb.AutoSize = True
        Me.NameLb.BackColor = System.Drawing.Color.Transparent
        Me.NameLb.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.NameLb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NameLb.Location = New System.Drawing.Point(45, 54)
        Me.NameLb.Name = "NameLb"
        Me.NameLb.Size = New System.Drawing.Size(0, 19)
        Me.NameLb.TabIndex = 1
        '
        'HighScoreLb
        '
        Me.HighScoreLb.AutoSize = True
        Me.HighScoreLb.BackColor = System.Drawing.Color.Transparent
        Me.HighScoreLb.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.HighScoreLb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.HighScoreLb.Location = New System.Drawing.Point(76, 25)
        Me.HighScoreLb.Name = "HighScoreLb"
        Me.HighScoreLb.Size = New System.Drawing.Size(0, 19)
        Me.HighScoreLb.TabIndex = 1
        '
        'LevelLb
        '
        Me.LevelLb.AutoSize = True
        Me.LevelLb.BackColor = System.Drawing.Color.Transparent
        Me.LevelLb.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LevelLb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LevelLb.Location = New System.Drawing.Point(310, 23)
        Me.LevelLb.Name = "LevelLb"
        Me.LevelLb.Size = New System.Drawing.Size(17, 19)
        Me.LevelLb.TabIndex = 1
        Me.LevelLb.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(262, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Level: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(1, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "High Score:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(0, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name:"
        '
        'ExitBtn
        '
        Me.ExitBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ExitBtn.FlatAppearance.BorderSize = 2
        Me.ExitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ExitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitBtn.Location = New System.Drawing.Point(306, 4)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(91, 35)
        Me.ExitBtn.TabIndex = 0
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'PauseBtn
        '
        Me.PauseBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PauseBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.PauseBtn.FlatAppearance.BorderSize = 2
        Me.PauseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PauseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PauseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PauseBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.PauseBtn.Location = New System.Drawing.Point(171, 4)
        Me.PauseBtn.Name = "PauseBtn"
        Me.PauseBtn.Size = New System.Drawing.Size(93, 35)
        Me.PauseBtn.TabIndex = 0
        Me.PauseBtn.Text = "Pause"
        Me.PauseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.PauseBtn.UseVisualStyleBackColor = False
        '
        'StartBtn
        '
        Me.StartBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.StartBtn.FlatAppearance.BorderSize = 2
        Me.StartBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.StartBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartBtn.Location = New System.Drawing.Point(37, 3)
        Me.StartBtn.Name = "StartBtn"
        Me.StartBtn.Size = New System.Drawing.Size(91, 35)
        Me.StartBtn.TabIndex = 0
        Me.StartBtn.Text = "Play"
        Me.StartBtn.UseVisualStyleBackColor = True
        '
        'ScoreLb
        '
        Me.ScoreLb.AutoSize = True
        Me.ScoreLb.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ScoreLb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ScoreLb.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ScoreLb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ScoreLb.Location = New System.Drawing.Point(354, 0)
        Me.ScoreLb.Name = "ScoreLb"
        Me.ScoreLb.Size = New System.Drawing.Size(22, 24)
        Me.ScoreLb.TabIndex = 2
        Me.ScoreLb.Text = "0"
        '
        'Timer1
        '
        Me.Timer1.Interval = 150
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkRed
        Me.MenuStrip1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(405, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartNewGameToolStripMenuItem, Me.SoundCheckMenu})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.FileToolStripMenuItem.Text = "Options"
        '
        'StartNewGameToolStripMenuItem
        '
        Me.StartNewGameToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.StartNewGameToolStripMenuItem.Name = "StartNewGameToolStripMenuItem"
        Me.StartNewGameToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.StartNewGameToolStripMenuItem.Text = "Start New Game"
        '
        'SoundCheckMenu
        '
        Me.SoundCheckMenu.Checked = True
        Me.SoundCheckMenu.CheckOnClick = True
        Me.SoundCheckMenu.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SoundCheckMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SoundCheckMenu.Name = "SoundCheckMenu"
        Me.SoundCheckMenu.Size = New System.Drawing.Size(161, 22)
        Me.SoundCheckMenu.Text = "Sound ON/OFF"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(405, 620)
        Me.Controls.Add(Me.ScoreLb)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Ant4)
        Me.Controls.Add(Me.Ant3)
        Me.Controls.Add(Me.Ant2)
        Me.Controls.Add(Me.Ant1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ant Killer by Olasquare"
        CType(Me.Ant1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ant2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ant3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ant4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Ant1 As PictureBox
    Friend WithEvents Ant2 As PictureBox
    Friend WithEvents Ant3 As PictureBox
    Friend WithEvents Ant4 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ExitBtn As Button
    Friend WithEvents PauseBtn As Button
    Friend WithEvents StartBtn As Button
    Friend WithEvents NameLb As Label
    Friend WithEvents HighScoreLb As Label
    Friend WithEvents LevelLb As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ScoreLb As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Public WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartNewGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SoundCheckMenu As ToolStripMenuItem
End Class
