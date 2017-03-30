Public Class frmMGunP1
    Public Property intDamage As Integer = 0
    Public Property intMulti As Integer = 0

    Private Sub MGun_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblDmg.Text = intDamage.ToString
        lblMulti.Text = intMulti.ToString
        'change the text for proper wording
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