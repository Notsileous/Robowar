'display window for end game
'variables are set when called
Public Class EndGame
    'variable for picture location to be displayed
    Public Property Picture As String
    'booleans for passing win/loss data between forms
    Public Property blnBeatLite As Boolean
    Public Property blnBeatMid As Boolean
    Public Property blnBeatHeavy As Boolean
    'boolean for player 1 winning, used for verification purposes
    Public Property blnP1Win As Boolean = False
    'variable to hold player 1 name
    Public Property strP1Name As String
    'booleans for player 1 robot choice to pass along
    Public Property blnP1Lite As Boolean
    Public Property blnP1Mid As Boolean
    Public Property blnP1Heavy As Boolean



    Private Sub EndGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'set the picture based on the variable sent
        pBox.ImageLocation = _Picture
        If _blnP1Win Then
            'alow the user to use the "next round" button if they had won this round
            btnNext.Enabled = True
        Else
            btnNext.Enabled = False


        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close the form
        Me.Close()

    End Sub

    Private Sub btnStartOver_Click(sender As Object, e As EventArgs) Handles btnStartOver.Click
        'start a new game from the begining with no wins
        Dim newGame As New frmLoadScreen
        'pass player 1 name to textbox
        newGame.txtName.Text = _strP1Name
        newGame.Show()
        Me.Close()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'continue the game after a win and face the remaining enemies
        Dim NewGamePlus As New frmOpponent
        'new round starts from the opponent selection screen
        'pass win/loss variables to new form
        NewGamePlus.blnBeatLite = _blnBeatLite
        NewGamePlus.blnBeatMid = _blnBeatMid
        NewGamePlus.blnBeatHeavy = _blnBeatHeavy
        'pass current player 1 robot
        NewGamePlus.blnP1Lite = blnP1Lite
        NewGamePlus.blnP1Mid = _blnP1Mid
        NewGamePlus.blnP1Heavy = _blnP1Heavy
        'pass player 1 name
        NewGamePlus.strP1Name = _strP1Name
        NewGamePlus.Show()
        Me.Close()

    End Sub


End Class