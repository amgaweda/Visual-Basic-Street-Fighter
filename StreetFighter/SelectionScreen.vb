Public Class StreetFighterScreen
    ' Each character has a move forward/backwards animation, punching, kicking, and 1 special move
    ' Ryu's Special Move is activated by clicking Down, Right, Punch
    ' Guile's Special Move is activated by clicking Left, Left, Punch
    ' Chun-Li's Special Move is activated by clicking Kick, Kick, Kick
    ' Each character has a sound effect that occurs as well (once).

    ' Due to VB's handling of GIF animations, each animation will loop forever.
    ' This can be stopped by using code like this: http://www.vbforums.com/showthread.php?626072-Loop-Once-Through-an-Animated-GIF
    ' However, the technique's  shown there are beyond the scope of the class.

    ' Yes, these are global. Be sure to explain why globals are bad.
    Dim charSelected As String = ""
    Dim bgSelected As String = ""
    Dim specialMove1 As Boolean = False
    Dim specialMove2 As Boolean = False
    Dim specialMove3 As Boolean = False

    Private Sub cancelSpecial()
        ' Resets all of the steps in special move sequence.
        specialMove1 = False
        specialMove2 = False
        specialMove3 = False
    End Sub

    Private Sub PlaySound()
        ' Plays the sound effect for the special move.
        Dim sfx
        Select Case charSelected
            Case "ryu"
                sfx = My.Resources.hadoken
            Case "guile"
                sfx = My.Resources.sonicboom
            Case "chunli"
                sfx = My.Resources.lightningkicks
        End Select
        My.Computer.Audio.Play(sfx, AudioPlayMode.Background)
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        Dim character
        Dim background
        cancelSpecial()

        If radRyu.Checked Then
            'Ryu
            character = My.Resources.ryu
            charSelected = "ryu"
        ElseIf radGuile.Checked Then
            'Guile
            character = My.Resources.guile
            charSelected = "guile"
        ElseIf radChunLi.Checked Then
            'Chun-Li
            character = My.Resources.chunli
            charSelected = "chunli"
        Else
            'Do Nothing
            character = ""
            charSelected = ""
        End If

        If radBGBison.Checked Then
            'Bison
            background = My.Resources.bg_bison
            bgSelected = "bison"
        ElseIf radBGSagat.Checked Then
            'Sagat
            background = My.Resources.bg_sagat
            bgSelected = "sagat"
        ElseIf radBGBlanka.Checked Then
            'Blanka
            background = My.Resources.bg_blanka
            bgSelected = "blanka"
        Else
            'Do Nothing
            background = ""
            bgSelected = ""
        End If

        ' Load Character, BG, and Controls
        ' This section makes sure a character and a BG are selected
        ' Also shows off MsgBoxStyle's
        If charSelected <> "" And bgSelected <> "" Then
            panelControls.Enabled = True
            picCharacter.Image = character
            panelStage.BackgroundImage = background
        Else
            MsgBox("Please Select a Character And a Stage", MsgBoxStyle.Critical, "Improper Selection")
        End If
    End Sub


    Private Sub btnRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRight.Click
        Select Case charSelected
            Case "ryu"
                picCharacter.Image = My.Resources.ryu_walkf
                If specialMove1 = True And specialMove2 = False Then
                    specialMove2 = True
                Else
                    cancelSpecial()
                End If
            Case "guile"
                picCharacter.Image = My.Resources.guile_walkf
                If specialMove1 = True And specialMove2 = False Then
                    specialMove2 = True
                Else
                    cancelSpecial()
                End If
            Case "chunli"
                picCharacter.Image = My.Resources.chunli_walkf
                cancelSpecial()
        End Select
        picCharacter.Left += 20
    End Sub

    Private Sub btnLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeft.Click
        Select Case charSelected
            Case "ryu"
                picCharacter.Image = My.Resources.ryu_walkb
                cancelSpecial()
            Case "guile"
                picCharacter.Image = My.Resources.guile_walkb
                specialMove1 = True
                specialMove2 = False
                specialMove3 = False
            Case "chunli"
                picCharacter.Image = My.Resources.chunli_walkb
                cancelSpecial()
        End Select
        picCharacter.Left -= 20
    End Sub

    Private Sub btnPunch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPunch.Click
        Select Case charSelected
            Case "ryu"
                picCharacter.Image = My.Resources.ryu_punch
                If specialMove1 = True And specialMove2 = True Then
                    picCharacter.Image = My.Resources.ryu_hadouken
                    PlaySound()
                    cancelSpecial()
                Else
                    cancelSpecial()
                End If
            Case "guile"
                picCharacter.Image = My.Resources.guile_punch
                If specialMove1 = True And specialMove2 = True Then
                    picCharacter.Image = My.Resources.guile_sonicboom
                    PlaySound()
                    cancelSpecial()
                Else
                    cancelSpecial()
                End If
            Case "chunli"
                picCharacter.Image = My.Resources.chunli_punch
                cancelSpecial()
        End Select
    End Sub

    Private Sub btnKick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKick.Click
        Select Case charSelected
            Case "ryu"
                picCharacter.Image = My.Resources.ryu_kick
                cancelSpecial()
            Case "guile"
                picCharacter.Image = My.Resources.guile_kick
                cancelSpecial()
            Case "chunli"
                picCharacter.Image = My.Resources.chunli_kick
                If specialMove1 = False Then
                    specialMove1 = True
                Else
                    If specialMove2 = False Then
                        specialMove2 = True
                    Else
                        picCharacter.Image = My.Resources.chunli_kicks
                        PlaySound()
                        cancelSpecial()
                    End If
                End If
        End Select
    End Sub

    Private Sub btnDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDown.Click
        ' Crounching animations were not added because I couldn't find one for everyone that matched their other sprites.
        Select Case charSelected
            Case "ryu"
                specialMove1 = True
                specialMove2 = False
                specialMove3 = False
            Case "guile"
                cancelSpecial()
            Case "chunli"
                cancelSpecial()
        End Select
    End Sub
End Class
