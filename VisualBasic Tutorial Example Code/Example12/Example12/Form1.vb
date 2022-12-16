Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim G As Graphics
        PictureBox1.Image = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        G = Graphics.FromImage(PictureBox1.Image)
        G.FillRectangle(Brushes.White, 0, 0, PictureBox1.Width, PictureBox1.Height)
        Dim i, j As Integer
        For i = 1 To 10
            For j = 1 To 10
                G.DrawString((i * j).ToString(), New Font("Arial", 14), Brushes.Blue, New Point((i - 1) * 40 + 20, (j - 1) * 40 + 20))
            Next
        Next
    End Sub
End Class
