'Name: Robo-War
'Programed by: Benjamin Liston - Frammisoft
'03/08/2016
'Robo-War is a turn based robot combat game

'load screen
Public Class frmLoadScreen
    'set initial values as to whether or not each of the 3 main robot types have been defeated
    'future rounds will bypass this screen if any of the below become true
    Public Property blnBeatLite As Boolean = False
    Public Property blnBeatMid As Boolean = False
    Public Property blnBeatHeavy As Boolean = False

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        'variable for player name
        Dim strName As String
        'on button click, take the name entered in the text box and assign to variable
        strName = txtName.Text
        'if the textbox stil contains the placeholder is empty display an error message
        If strName.ToUpper = "ENTER YOUR NAME" Or strName = "" Then
            MessageBox.Show("Please enter your name", "Missing Name", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtName.Text = "Enter Your Name"
            txtName.Focus()
        Else
            'if name check is good, create new window for robot select
            Dim SelectForm As New frmP1Select
            'pass player name to next form
            SelectForm.strP1Name = txtName.Text
            'pass win/loss booleans
            SelectForm.blnBeatLite = _blnBeatLite
            SelectForm.blnBeatMid = _blnBeatMid
            SelectForm.blnBeatHeavy = _blnBeatHeavy

            SelectForm.Show()
            Me.Close()

        End If





    End Sub
    'on load set focus to player name textbox
    Private Sub frmLoadScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        txtName.Focus()
        PictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "/images/load.jpg"

    End Sub
    'clear placeholder when textbox is clicked
    Private Sub txtName_Click(sender As Object, e As EventArgs) Handles txtName.Click
        'if the textbox holds the default placeholder then clear it
        If txtName.Text.ToUpper = "ENTER YOUR NAME" Then
            txtName.Text = String.Empty
        Else
            'if the textbox holds the username passed from another window do not clear it
            txtName.SelectAll()
        End If

    End Sub


End Class