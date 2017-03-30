Public Class P1Tesla
    Public Property intDamage As Integer
    Public Property intSpash As Integer


    Private Sub Tesla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDmg.Text = intDamage.ToString
        lblSplashDmg.Text = intSpash.ToString
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()

    End Sub
End Class