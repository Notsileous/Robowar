Public Class frmDroneP1
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()

    End Sub

    Private Sub frmDroneP1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "/images/drone.png"
    End Sub
End Class