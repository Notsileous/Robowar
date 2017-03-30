Public Class P2Missile
    Public Property intDamage As Integer = 0
    Public Property intMulti As Integer = 0
    Private Sub P2Missile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDmg.Text = intDamage.ToString
        lblStrikes.Text = intMulti.ToString
        If intMulti = 1 Then
            lblTimes.Text = "time"
        Else
            lblTimes.Text = "times"
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()

    End Sub
End Class