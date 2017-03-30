'show window for scorpion taser attack
Public Class frmTaser
    'variables for incomming damage and number of strikes
    Public Property intDamage As Integer
    Public Property intTimes As Integer

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        'close the form
        Me.Close()

    End Sub

    Private Sub frmTaser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'take the variables and add to form
        lblDamage.Text = _intDamage.ToString
        lblMulti.Text = _intTimes.ToString
        If intTimes = 1 Then
            lblTimes.Text = "time"
        Else
            lblTimes.Text = "times"

        End If
    End Sub
End Class