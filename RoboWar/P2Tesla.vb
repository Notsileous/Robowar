Public Class P2Tesla
    Public Property intDamage As Integer
    Public Property intSpash As Integer

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()

    End Sub

    Private Sub P2Tesla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDmg.Text = intDamage.ToString
        lblSplashDmg.Text = intSpash.ToString
    End Sub


End Class