Public Class frmP1Select

    Public Property strP1Name As String
    Public Property blnBeatLite As Boolean
    Public Property blnBeatMid As Boolean
    Public Property blnBeatHeavy As Boolean
    Public Property blnP1Lite As Boolean = False
    Public Property blnP1Mid As Boolean = False
    Public Property blnP1Heavy As Boolean = False


    'display robot vitals when the button  is clicked
    Private Sub btnLiteDetails_Click(sender As Object, e As EventArgs) Handles btnLiteDetails.Click
        If txtLiteDetails.Visible = False Then
            txtLiteDetails.Visible = True
        Else
            txtLiteDetails.Visible = False

        End If


    End Sub

    Private Sub btnMidDetails_Click(sender As Object, e As MouseEventArgs) Handles btnMidDetails.Click
        If txtMidDetails.Visible = False Then
            txtMidDetails.Visible = True
        Else
            txtMidDetails.Visible = False
        End If
    End Sub

    Private Sub btnHeavyDetails_Click(sender As Object, e As EventArgs) Handles btnHeavyDetails.Click
        If txtHeavyDetails.Visible = False Then
            txtHeavyDetails.Visible = True
        Else
            txtHeavyDetails.Visible = False
        End If
    End Sub

    ' buttons for selecting a fighter
    Private Sub btnLite_Click(sender As Object, e As EventArgs) Handles btnLite.Click
        blnP1Lite = True
        Dim OpponentWindow = New frmOpponent
        OpponentWindow.blnP1Lite = _blnP1Lite
        OpponentWindow.blnP1Mid = _blnP1Mid
        OpponentWindow.blnP1Heavy = _blnP1Heavy
        OpponentWindow.strP1Name = strP1Name
        OpponentWindow.blnBeatLite = blnBeatLite
        OpponentWindow.blnBeatMid = blnBeatMid
        OpponentWindow.blnBeatHeavy = blnBeatHeavy
        OpponentWindow.Show()
        Me.Close()
    End Sub

    Private Sub btnMid_Click(sender As Object, e As EventArgs) Handles btnMid.Click
        blnP1Mid = True
        Dim OpponentWindow = New frmOpponent
        OpponentWindow.blnP1Lite = _blnP1Lite
        OpponentWindow.blnP1Mid = _blnP1Mid
        OpponentWindow.blnP1Heavy = _blnP1Heavy
        OpponentWindow.blnBeatLite = blnBeatLite
        OpponentWindow.blnBeatMid = blnBeatMid
        OpponentWindow.blnBeatHeavy = blnBeatHeavy
        OpponentWindow.strP1Name = strP1Name
        OpponentWindow.Show()
        Me.Close()
    End Sub

    Private Sub btnHeavy_Click(sender As Object, e As EventArgs) Handles btnHeavy.Click
        blnP1Heavy = True
        Dim OpponentWindow = New frmOpponent
        OpponentWindow.blnP1Lite = _blnP1Lite
        OpponentWindow.blnP1Mid = _blnP1Mid
        OpponentWindow.blnP1Heavy = _blnP1Heavy
        OpponentWindow.strP1Name = strP1Name
        OpponentWindow.blnBeatLite = blnBeatLite
        OpponentWindow.blnBeatMid = blnBeatMid
        OpponentWindow.blnBeatHeavy = blnBeatHeavy
        OpponentWindow.Show()
        Me.Close()
    End Sub

    Private Sub frmP1Select_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblName.Text = strP1Name

    End Sub

End Class