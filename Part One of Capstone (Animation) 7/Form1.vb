Public Class frmMain
    Private Sub btnRotate_Click(sender As Object, e As EventArgs) Handles btnRotate.Click
        Dim rotateim As Image = New Bitmap(PictureBox1.Image)

        rotateim.RotateFlip(RotateFlipType.Rotate90FlipNone)
        PictureBox1.Image = rotateim
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim color As Integer
        If color = 0 Then
            Label5
        End If
    End Sub
End Class
