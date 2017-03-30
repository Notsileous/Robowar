'display window for scorpion drain attack
Public Class Drain
    'variable for incoming damage type (power, sheilds, or health)
    Public Property strDmgType As String
    'variable for incoming damage ammount
    Public Property intDmg As Integer


    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        'close the window
        Me.Close()
    End Sub

    Private Sub Drain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'on window call the damage type and amount are set by the attack module
        'add the variables to the window
        lblType.Text = _strDmgType
        lblDmg.Text = _intDmg.ToString
        lblP2Add.Text = _intDmg.ToString
    End Sub
End Class