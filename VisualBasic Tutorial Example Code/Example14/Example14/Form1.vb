Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim g As Graphics
        PictureBox1.Image = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        g = Graphics.FromImage(PictureBox1.Image)
        g.FillRectangle(Brushes.White, 0, 0, PictureBox1.Width, PictureBox1.Height)
        Dim i, j As Integer
        Dim t As Boolean
        For i = 1 To 8            
            For j = 1 To 8
                t = Not t
                If t Then
                    g.FillRectangle(Brushes.Black, (i - 1) * 50, (j - 1) * 50, 50, 50)
                Else
                    g.FillRectangle(Brushes.White, (i - 1) * 50, (j - 1) * 50, 50, 50)
                End If
            Next
            t = Not t
        Next
    End Sub
End Class
