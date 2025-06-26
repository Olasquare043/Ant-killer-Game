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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Ant1 = New PictureBox()
        Ant2 = New PictureBox()
        Ant3 = New PictureBox()
        Ant4 = New PictureBox()
        Panel1 = New Panel()
        GroupBox1 = New GroupBox()
        NameLb = New Label()
        HighScoreLb = New Label()
        LevelLb = New Label()
        Label3 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        ExitBtn = New Button()
        PauseBtn = New Button()
        StartBtn = New Button()
        ScoreLb = New Label()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        StartNewGameToolStripMenuItem = New ToolStripMenuItem()
        SoundCheckMenu = New ToolStripMenuItem()
        CType(Ant1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Ant2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Ant3, ComponentModel.ISupportInitialize).BeginInit()
        CType(Ant4, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Ant1
        ' 
        Ant1.BackColor = Color.Transparent
        Ant1.Image = My.Resources.Resources.first
        Ant1.Location = New Point(12, 291)
        Ant1.Name = "Ant1"
        Ant1.Size = New Size(42, 64)
        Ant1.SizeMode = PictureBoxSizeMode.StretchImage
        Ant1.TabIndex = 0
        Ant1.TabStop = False
        ' 
        ' Ant2
        ' 
        Ant2.BackColor = Color.Transparent
        Ant2.Image = My.Resources.Resources.first
        Ant2.Location = New Point(110, 365)
        Ant2.Name = "Ant2"
        Ant2.Size = New Size(42, 64)
        Ant2.SizeMode = PictureBoxSizeMode.StretchImage
        Ant2.TabIndex = 0
        Ant2.TabStop = False
        ' 
        ' Ant3
        ' 
        Ant3.BackColor = Color.Transparent
        Ant3.Image = My.Resources.Resources.first
        Ant3.Location = New Point(230, 403)
        Ant3.Name = "Ant3"
        Ant3.Size = New Size(42, 64)
        Ant3.SizeMode = PictureBoxSizeMode.StretchImage
        Ant3.TabIndex = 0
        Ant3.TabStop = False
        ' 
        ' Ant4
        ' 
        Ant4.BackColor = Color.Transparent
        Ant4.Image = My.Resources.Resources.first
        Ant4.Location = New Point(352, 491)
        Ant4.Name = "Ant4"
        Ant4.Size = New Size(42, 64)
        Ant4.SizeMode = PictureBoxSizeMode.StretchImage
        Ant4.TabIndex = 0
        Ant4.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.bgcorrect
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(GroupBox1)
        Panel1.Controls.Add(ExitBtn)
        Panel1.Controls.Add(PauseBtn)
        Panel1.Controls.Add(StartBtn)
        Panel1.Location = New Point(-7, 492)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(427, 134)
        Panel1.TabIndex = 1
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(NameLb)
        GroupBox1.Controls.Add(HighScoreLb)
        GroupBox1.Controls.Add(LevelLb)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.ForeColor = SystemColors.ButtonHighlight
        GroupBox1.Location = New Point(8, 41)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(400, 83)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Game Infomation"
        ' 
        ' NameLb
        ' 
        NameLb.AutoSize = True
        NameLb.BackColor = Color.Transparent
        NameLb.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        NameLb.ForeColor = SystemColors.ButtonHighlight
        NameLb.Location = New Point(48, 54)
        NameLb.Name = "NameLb"
        NameLb.Size = New Size(0, 19)
        NameLb.TabIndex = 1
        ' 
        ' HighScoreLb
        ' 
        HighScoreLb.AutoSize = True
        HighScoreLb.BackColor = Color.Transparent
        HighScoreLb.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        HighScoreLb.ForeColor = SystemColors.ButtonHighlight
        HighScoreLb.Location = New Point(81, 25)
        HighScoreLb.Name = "HighScoreLb"
        HighScoreLb.Size = New Size(0, 19)
        HighScoreLb.TabIndex = 1
        ' 
        ' LevelLb
        ' 
        LevelLb.AutoSize = True
        LevelLb.BackColor = Color.Transparent
        LevelLb.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LevelLb.ForeColor = SystemColors.ButtonHighlight
        LevelLb.Location = New Point(310, 23)
        LevelLb.Name = "LevelLb"
        LevelLb.Size = New Size(17, 19)
        LevelLb.TabIndex = 1
        LevelLb.Text = "0"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(262, 23)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 19)
        Label3.TabIndex = 1
        Label3.Text = "Level: "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(1, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 19)
        Label1.TabIndex = 1
        Label1.Text = "High Score:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(0, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 19)
        Label2.TabIndex = 1
        Label2.Text = "Name:"
        ' 
        ' ExitBtn
        ' 
        ExitBtn.FlatAppearance.BorderColor = Color.Red
        ExitBtn.FlatAppearance.BorderSize = 2
        ExitBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        ExitBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        ExitBtn.FlatStyle = FlatStyle.Flat
        ExitBtn.Location = New Point(306, 4)
        ExitBtn.Name = "ExitBtn"
        ExitBtn.Size = New Size(91, 35)
        ExitBtn.TabIndex = 0
        ExitBtn.Text = "Exit"
        ExitBtn.UseVisualStyleBackColor = True
        ' 
        ' PauseBtn
        ' 
        PauseBtn.BackColor = SystemColors.ButtonHighlight
        PauseBtn.FlatAppearance.BorderColor = Color.Red
        PauseBtn.FlatAppearance.BorderSize = 2
        PauseBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        PauseBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        PauseBtn.FlatStyle = FlatStyle.Flat
        PauseBtn.ImageAlign = ContentAlignment.TopLeft
        PauseBtn.Location = New Point(171, 4)
        PauseBtn.Name = "PauseBtn"
        PauseBtn.Size = New Size(93, 35)
        PauseBtn.TabIndex = 0
        PauseBtn.Text = "Pause"
        PauseBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        PauseBtn.UseVisualStyleBackColor = False
        ' 
        ' StartBtn
        ' 
        StartBtn.FlatAppearance.BorderColor = Color.Red
        StartBtn.FlatAppearance.BorderSize = 2
        StartBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        StartBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        StartBtn.FlatStyle = FlatStyle.Flat
        StartBtn.Location = New Point(37, 3)
        StartBtn.Name = "StartBtn"
        StartBtn.Size = New Size(91, 35)
        StartBtn.TabIndex = 0
        StartBtn.Text = "Play"
        StartBtn.UseVisualStyleBackColor = True
        ' 
        ' ScoreLb
        ' 
        ScoreLb.AutoSize = True
        ScoreLb.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        ScoreLb.BorderStyle = BorderStyle.Fixed3D
        ScoreLb.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        ScoreLb.ForeColor = SystemColors.ButtonHighlight
        ScoreLb.Location = New Point(354, 0)
        ScoreLb.Name = "ScoreLb"
        ScoreLb.Size = New Size(22, 24)
        ScoreLb.TabIndex = 2
        ScoreLb.Text = "0"
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 150
        ' 
        ' Timer2
        ' 
        Timer2.Enabled = True
        Timer2.Interval = 1
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.DarkRed
        MenuStrip1.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        MenuStrip1.GripStyle = ToolStripGripStyle.Visible
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(405, 24)
        MenuStrip1.TabIndex = 4
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {StartNewGameToolStripMenuItem, SoundCheckMenu})
        FileToolStripMenuItem.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point)
        FileToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(61, 20)
        FileToolStripMenuItem.Text = "Options"
        ' 
        ' StartNewGameToolStripMenuItem
        ' 
        StartNewGameToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text
        StartNewGameToolStripMenuItem.Name = "StartNewGameToolStripMenuItem"
        StartNewGameToolStripMenuItem.Size = New Size(180, 22)
        StartNewGameToolStripMenuItem.Text = "Start New Game"
        ' 
        ' SoundCheckMenu
        ' 
        SoundCheckMenu.Checked = True
        SoundCheckMenu.CheckOnClick = True
        SoundCheckMenu.CheckState = CheckState.Checked
        SoundCheckMenu.DisplayStyle = ToolStripItemDisplayStyle.Text
        SoundCheckMenu.Name = "SoundCheckMenu"
        SoundCheckMenu.Size = New Size(180, 22)
        SoundCheckMenu.Text = "Sound ON/OFF"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(405, 620)
        Controls.Add(ScoreLb)
        Controls.Add(MenuStrip1)
        Controls.Add(Panel1)
        Controls.Add(Ant4)
        Controls.Add(Ant3)
        Controls.Add(Ant2)
        Controls.Add(Ant1)
        Cursor = Cursors.Hand
        Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Ant Killer by Olasquare"
        CType(Ant1, ComponentModel.ISupportInitialize).EndInit()
        CType(Ant2, ComponentModel.ISupportInitialize).EndInit()
        CType(Ant3, ComponentModel.ISupportInitialize).EndInit()
        CType(Ant4, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

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
