Public Class CoinFlip
    'variable for the players choice
    Private strChoice As String
    'variable for the toss result
    Private strFlip As String
    'variable for player to be displayed - either player 1 or player 2
    Private strPlayerName As String
    'boolean variable to be passed to fight screen
    Public Property blnPlayer1Turn As Boolean

    'close the form
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    'get the players choice and flip the coin
    Private Sub btnFlip_Click(sender As Object, e As EventArgs) Handles btnFlip.Click
        'check value of combo box and set the variable - then perform the flip
        If cmbChoice.SelectedItem = "Heads" Then
            strChoice = "heads"
            DoFlip()
        ElseIf cmbChoice.SelectedItem = "Tails" Then
            strChoice = "tails"
            DoFlip()
        Else
            'if no selection open warning window
            MessageBox.Show("Please call the coin")
        End If
    End Sub

    'sub for actual flip
    Private Sub DoFlip()
        'create new random object and variable to hold a number
        Dim ranFlip As New Random
        Dim intFlip As New Integer
        'generate a random integer- either 1 or 2 - depending on number set the flip variable
        intFlip = ranFlip.Next(1, 3)
        If intFlip = 1 Then
            strFlip = "heads"
        ElseIf intFlip = 2 Then
            strFlip = "tails"
        End If
        'if choose and flip variable match player 1 goes first
        If strChoice = strFlip Then
            strPlayerName = "Player 1"
            _blnPlayer1Turn = True
        Else
            'if they do not match, player 2 goes first
            strPlayerName = "Player 2"
            _blnPlayer1Turn = False
        End If
        'change the label text to reflect the results
        lblFlipResult.Text = strFlip
        lblPlayer.Text = strPlayerName
        'make flip results text visible and ok button enabled
        lbl1.Visible = True
        lblFlipResult.Visible = True
        lblPlayer.Visible = True
        lbl2.Visible = True
        btnOK.Enabled = True
        'disable combo box and flip button to stop do-overs
        cmbChoice.Enabled = False
        btnFlip.Enabled = False

    End Sub


End Class