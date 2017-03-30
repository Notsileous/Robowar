'window for picking player 2 robot type
Public Class frmOpponent

    Public Property blnP1Lite As Boolean
    Public Property blnP1Mid As Boolean
    Public Property blnP1Heavy As Boolean
    Public Property blnP2Lite As Boolean
    Public Property blnP2Mid As Boolean
    Public Property blnP2Heavy As Boolean
    Public Property blnBeatLite As Boolean
    Public Property blnBeatMid As Boolean
    Public Property blnBeatHeavy As Boolean
    Public Property strP1Name As String







    'display robot vitals when the button  is clicked
    Private Sub btnLiteDetails_Click(sender As Object, e As EventArgs) Handles btnLiteDetails.Click
        If txtLiteDetails.Visible = False Then
            txtLiteDetails.Visible = True
        Else
            txtLiteDetails.Visible = False

        End If


    End Sub
    'display robot vitals when the button  is clicked
    Private Sub btnMidDetails_Click(sender As Object, e As MouseEventArgs) Handles btnMidDetails.Click
        If txtMidDetails.Visible = False Then
            txtMidDetails.Visible = True
        Else
            txtMidDetails.Visible = False
        End If
    End Sub
    'display robot vitals when the button  is clicked
    Private Sub btnHeavyDetails_Click(sender As Object, e As EventArgs) Handles btnHeavyDetails.Click
        If txtHeavyDetails.Visible = False Then
            txtHeavyDetails.Visible = True
        Else
            txtHeavyDetails.Visible = False
        End If
    End Sub

    Private Sub btnLite_Click(sender As Object, e As EventArgs) Handles btnLite.Click
        Me.Hide()
        'set the boolean for this robot type to true
        blnP2Lite = True
        'create new object for main fight window
        Dim FightWindow As New frmMainFight
        'pass player 1 choice
        FightWindow.blnP1Lite = _blnP1Lite
        FightWindow.blnP1Mid = _blnP1Mid
        FightWindow.blnP1Heavy = _blnP1Heavy
        'pass player 2 choice
        FightWindow.blnP2Lite = _blnP2Lite
        FightWindow.blnP2Mid = _blnP2Mid
        FightWindow.blnP2Heavy = _blnP2Heavy
        'pass player 1 name
        FightWindow.strP1Name = _strP1Name
        'pass which robot typs have been defeated
        FightWindow.blnBeatLite = _blnBeatLite
        FightWindow.blnBeatMid = _blnBeatMid
        FightWindow.blnBeatHeavy = _blnBeatHeavy
        'show window
        FightWindow.Show()
        'close current window
        Me.Close()

    End Sub

    Private Sub btnMid_Click(sender As Object, e As EventArgs) Handles btnMid.Click
        Me.Hide()
        'set the boolean for this robot type to true
        blnP2Mid = True
        'create new object for main fight window
        Dim FightWindow As New frmMainFight
        'pass player 1 choice
        FightWindow.blnP1Lite = _blnP1Lite
        FightWindow.blnP1Mid = _blnP1Mid
        FightWindow.blnP1Heavy = _blnP1Heavy
        'pass player 2 choice
        FightWindow.blnP2Lite = _blnP2Lite
        FightWindow.blnP2Mid = _blnP2Mid
        FightWindow.blnP2Heavy = _blnP2Heavy
        'pass player 1 name
        FightWindow.strP1Name = _strP1Name
        'pass which robot typs have been defeated
        FightWindow.blnBeatLite = _blnBeatLite
        FightWindow.blnBeatMid = _blnBeatMid
        FightWindow.blnBeatHeavy = _blnBeatHeavy
        'show window
        FightWindow.Show()
        'close current window
        Me.Close()
    End Sub

    Private Sub btnHeavy_Click(sender As Object, e As EventArgs) Handles btnHeavy.Click
        Me.Hide()
        'set the boolean for this robot type to true
        blnP2Heavy = True
        'create new object for main fight window
        Dim FightWindow As New frmMainFight
        'pass player 1 choice
        FightWindow.blnP1Lite = _blnP1Lite
        FightWindow.blnP1Mid = _blnP1Mid
        FightWindow.blnP1Heavy = _blnP1Heavy
        'pass player 2 choice
        FightWindow.blnP2Lite = _blnP2Lite
        FightWindow.blnP2Mid = _blnP2Mid
        FightWindow.blnP2Heavy = _blnP2Heavy
        'pass player 1 name
        FightWindow.strP1Name = _strP1Name
        'pass which robot typs have been defeated
        FightWindow.blnBeatLite = _blnBeatLite
        FightWindow.blnBeatMid = _blnBeatMid
        FightWindow.blnBeatHeavy = _blnBeatHeavy
        'show window
        FightWindow.Show()
        'close current window
        Me.Close()
    End Sub

    Private Sub frmOpponent_Load(sender As Object, e As EventArgs) Handles Me.Load
        'on load check to see which robots have been defeated - disable their buttons - display picture with them x'd out
        If blnBeatLite Then
            btnLite.Enabled = False
            btnLiteDetails.Enabled = False
            pBoxRipper.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "/images/ripper_red_beaten.gif"
        End If
        If blnBeatMid Then
            btnMid.Enabled = False
            btnMidDetails.Enabled = False
            pBoxStatic.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "/images/static_red_beaten.gif"
        End If
        If blnBeatHeavy Then
            btnHeavy.Enabled = False
            btnHeavyDetails.Enabled = False
            pBoxHardcase.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "/images/hardcase_red_beaten.gif"
        End If
        'if all 3 are beaten reveal the hidden robot and enable buttons
        If blnBeatLite And blnBeatMid And blnBeatHeavy Then
            picLocked.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "/images/scorpion.gif"
            btnDetails.Enabled = True
            btnDetails.Text = "Toggle Details"
            btnChoose.Enabled = True
            btnChoose.Text = "Choose Scorpion"
        End If

    End Sub
    Private Sub btnDetails_Click(sender As Object, e As EventArgs) Handles btnDetails.Click
        'show details for scorpion
        If txtScorp.Visible = True Then
            txtScorp.Visible = False
        Else
            txtScorp.Visible = True

        End If
    End Sub
    'choose hidden robot (scorpion)
    Private Sub btnChoose_Click(sender As Object, e As EventArgs) Handles btnChoose.Click
        Me.Hide()
        Dim NGPlus As New NewGamePlus
        NGPlus.blnP1Lite = _blnP1Lite
        NGPlus.blnP1Mid = _blnP1Mid
        NGPlus.blnP1Heavy = _blnP1Heavy
        NGPlus.blnP2Lite = False
        NGPlus.blnP2Mid = False
        NGPlus.blnP2Heavy = False
        NGPlus.strP1Name = _strP1Name
        NGPlus.Show()
        Me.Close()

    End Sub

End Class