Public Class P2DroneStrike
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()

    End Sub

    Private Sub P2DroneStrike_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "/images/drone.png"
    End Sub
End Class