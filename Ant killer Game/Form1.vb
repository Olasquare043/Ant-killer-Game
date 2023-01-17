Public Class Form1
    Public Score As Integer = 0
    Public x As Integer
    Public y As Integer
    Public level As Integer
    Public intersectTime As Integer = 0
    Dim NewBoss As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SoundCheckMenu.Checked = True Then
            My.Computer.Audio.Play(My.Resources.gamesound4, AudioPlayMode.BackgroundLoop)
        End If
        ScoreLb.Text = 0
        Timer1.Interval = 100
        HighScoreLb.Text = My.Settings.PlayScore
        NameLb.Text = My.Settings.PlayerName


    End Sub
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Dim x = MsgBox("You about to close the Game, Are you Sure?", vbYesNo + vbQuestion, "Existing Game")
        If x = vbYes Then
            Close()
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Ant1.Top -= 5
        Ant2.Top -= 5
        Ant3.Top -= 5
        Ant4.Top -= 5

    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        If Ant1.Location.Y <= -60 Or Ant2.Location.Y <= -60 Or Ant3.Location.Y <= -60 Or Ant4.Location.Y <= -60 Then
            Timer1.Enabled = False
            Timer2.Enabled = False
            Score = ScoreLb.Text
            MsgBox("Game Over", vbOKOnly, "Ant_killer_Game")
            Dim highscore = My.Settings.PlayScore
            If Val(highscore) < Score Then
                NewBoss = InputBox("Enter your Name, You have beat the High score", "Ant Killer Boss", My.Settings.PlayerName)
                My.Settings.PlayerName = NewBoss
                My.Settings.PlayScore = Score
                My.Settings.Save()
            End If
            ScoreLb.Text = 0
            HighScoreLb.Text = My.Settings.PlayScore
            NameLb.Text = My.Settings.PlayerName
            RestGame()
        End If
    End Sub
    Private Sub StartBtn_Click(sender As Object, e As EventArgs) Handles StartBtn.Click
        PlayBackgroundSoundFile()
        Timer1.Start()
        Timer2.Start()
        PauseBtn.BackColor = DefaultBackColor
    End Sub
    Private Sub Ant1_Click(sender As Object, e As EventArgs) Handles Ant1.Click

        If Timer1.Enabled = True Then
            intersectTime = 0
            RandAntLocation()
            Ant1.Location = New Point(x, y)
            checkAntCollide(Ant1)
            While intersectTime > 1
                RandAntLocation()
                Ant1.Location = New Point(x, y)
                checkAntCollide(Ant1)
            End While
            ScoreLb.Text += 1
            LevelLb.Text = checkLevel(ScoreLb.Text)

        End If

    End Sub
    Private Sub Ant2_Click(sender As Object, e As EventArgs) Handles Ant2.Click
        If Timer1.Enabled = True Then
            intersectTime = 0
            RandAntLocation()
            Ant2.Location = New Point(x, y)
            checkAntCollide(Ant2)
            While intersectTime > 1
                RandAntLocation()
                Ant2.Location = New Point(x, y)
                checkAntCollide(Ant2)
            End While
            ScoreLb.Text += 1
            LevelLb.Text = checkLevel(ScoreLb.Text)

        End If
    End Sub
    Private Sub Ant3_Click(sender As Object, e As EventArgs) Handles Ant3.Click
        If Timer1.Enabled = True Then
            intersectTime = 0
            RandAntLocation()
            Ant3.Location = New Point(x, y)
            checkAntCollide(Ant3)
            While intersectTime > 1
                RandAntLocation()
                Ant3.Location = New Point(x, y)
                checkAntCollide(Ant3)
            End While
            ScoreLb.Text += 1
            LevelLb.Text = checkLevel(ScoreLb.Text)

        End If
    End Sub

    Private Sub Ant4_Click(sender As Object, e As EventArgs) Handles Ant4.Click
        If Timer1.Enabled = True Then
            intersectTime = 0
            RandAntLocation()
            Ant4.Location = New Point(x, y)
            checkAntCollide(Ant4)
            While intersectTime > 1
                RandAntLocation()
                Ant4.Location = New Point(x, y)
                checkAntCollide(Ant4)
            End While
            ScoreLb.Text += 1
            LevelLb.Text = checkLevel(ScoreLb.Text)

        End If
    End Sub

    Private Sub PauseBtn_Click(sender As Object, e As EventArgs) Handles PauseBtn.Click
        Timer1.Stop()
        Timer2.Stop()
        PauseBtn.BackColor = Color.DarkGray
    End Sub

    Private Sub StartNewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartNewGameToolStripMenuItem.Click
        Dim selectedOption = MsgBox("Your will lost the current game score! Are you sure you want to Start New Game?", vbYesNo + vbQuestion, "Starting New Game")
        If selectedOption = vbYes Then
            RestGame()
        End If

    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click
        Timer1.Stop()
    End Sub

    Private Sub SoundCheckMenu_Click(sender As Object, e As EventArgs) Handles SoundCheckMenu.Click
        If SoundCheckMenu.Checked = True Then
            My.Computer.Audio.Play(My.Resources.gamesound4, AudioPlayMode.BackgroundLoop)
        Else
            StopBackgroundSound()
        End If
    End Sub
End Class
