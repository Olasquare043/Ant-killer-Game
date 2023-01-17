Module Module1
    'procedure to check if the ant collide
    Public Sub CheckAntCollide(ant As PictureBox)
        Form1.intersectTime = 0
        If ant.Bounds.IntersectsWith(Form1.Ant1.Bounds) Then
            Form1.intersectTime += 1
        End If
        If ant.Bounds.IntersectsWith(Form1.Ant2.Bounds) Then
            Form1.intersectTime += 1
        End If
        If ant.Bounds.IntersectsWith(Form1.Ant3.Bounds) Then
            Form1.intersectTime += 1
        End If
        If ant.Bounds.IntersectsWith(Form1.Ant4.Bounds) Then
            Form1.intersectTime += 1
        End If
    End Sub
    'procedure to generate new loocation of the ant
    Public Sub RandAntLocation()
        Randomize()
        Form1.x = CInt((Math.Floor((365 - (-10) + 1) * Rnd())) + (-10))
        Form1.y = CInt((Math.Floor((520 - 435 + 1) * Rnd())) + 435)
    End Sub
    'procedure to chech player level
    Public Function CheckLevel(score As Integer)
        Dim level = score \ 50
        If (score Mod 3 = 0) Then
            Form1.Timer1.Interval -= 1
        End If
        Return level
    End Function
    Public Sub CheckSpeed(score As Integer)
        Dim level = CheckLevel(score)
        Form1.Timer1.Interval -= (level * 20)
    End Sub
    Public Sub RestGame()
        Form1.ScoreLb.Text = "0"
        Form1.Score = 0
        Form1.LevelLb.Text = "0"
        Form1.Timer1.Interval = 100
        Form1.Timer1.Stop()
        Form1.Timer2.Stop()
        'reset Ant1 location
        RandAntLocation()
        Form1.Ant1.Location = New Point(Form1.x, Form1.y)
        checkAntCollide(Form1.Ant1)
        While Form1.intersectTime > 1
            RandAntLocation()
            Form1.Ant1.Location = New Point(Form1.x, Form1.y)
            checkAntCollide(Form1.Ant1)
        End While
        'reset Ant2 location
        RandAntLocation()
        Form1.Ant2.Location = New Point(Form1.x, Form1.y)
        While Form1.intersectTime > 1
            RandAntLocation()
            Form1.Ant2.Location = New Point(Form1.x, Form1.y)
            checkAntCollide(Form1.Ant2)
        End While
        'reset Ant3 location
        RandAntLocation()
        Form1.Ant3.Location = New Point(Form1.x, Form1.y)
        While Form1.intersectTime > 1
            RandAntLocation()
            Form1.Ant3.Location = New Point(Form1.x, Form1.y)
            checkAntCollide(Form1.Ant3)
        End While
        'reset Ant4 location
        RandAntLocation()
        Form1.Ant4.Location = New Point(Form1.x, Form1.y)
        While Form1.intersectTime > 1
            RandAntLocation()
            Form1.Ant4.Location = New Point(Form1.x, Form1.y)
            checkAntCollide(Form1.Ant4)
        End While
    End Sub
    Sub PlayBackgroundSoundFile()
        Randomize()
        Dim soundnum = CInt((Math.Floor((3 - (1) + 1) * Rnd())) + (1))
        If soundnum = 1 Then
            My.Computer.Audio.Play(My.Resources.gamesound1, AudioPlayMode.BackgroundLoop)
        ElseIf soundnum = 2 Then
            My.Computer.Audio.Play(My.Resources.gamesound2, AudioPlayMode.BackgroundLoop)
        ElseIf soundnum = 3 Then
            My.Computer.Audio.Play(My.Resources.gamesound3, AudioPlayMode.BackgroundLoop)
        End If
    End Sub
    Sub StopBackgroundSound()
        My.Computer.Audio.Stop()
    End Sub
End Module
