Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim G As Graphics
        PictureBox1.Image = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        G = Graphics.FromImage(PictureBox1.Image)
        Dim x, y As Double
        Dim PX, PY As Integer
        For x = 0 To PictureBox1.Width
            y = 100 * Math.Sin(x / 30) + 200
            If x = 0 Then
                PX = x
                PY = y
            End If
            G.DrawLine(Pens.Black, New Point(PX, PY), New Point(Int(x), Int(y)))
            PX = x
            PY = y

        Next




    End Sub
End Class
