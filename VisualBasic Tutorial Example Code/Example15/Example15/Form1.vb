Public Class Form1
    Dim g As Graphics
    Dim Position(8) As Integer
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Image = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        g = Graphics.FromImage(PictureBox1.Image)
        g.FillRectangle(Brushes.White, 0, 0, PictureBox1.Width, PictureBox1.Height)
        DrawChessBoard()
        Solve(1)
        Dim i As Integer
        For i = 1 To 8
            If ((-1) ^ (i + Position(i)) = 1) Then
                g.DrawImage(My.Resources.Queen2, (i - 1) * 50, (Position(i) - 1) * 50, 50, 50)
            Else
                g.DrawImage(My.Resources.Queen1, (i - 1) * 50, (Position(i) - 1) * 50, 50, 50)
            End If

        Next
    End Sub
    Private Function IsSafe(ByVal k As Integer, ByVal p As Integer) As Boolean
        Dim i As Integer
        Dim other As Integer
        For i = 0 To k
            other = Position(k - i)
            If ((other = p) Or (other = (p - i)) Or (other = p + i)) Then
                IsSafe = False
                Exit Function
            End If
        Next
        IsSafe = True
    End Function

    Private Function Solve(ByVal k As Integer) As Boolean
        Solve = False
        If k = 9 Then
            Solve = True
            Exit Function
        End If

        Dim p As Integer
        Dim t As Boolean
        For p = 1 To 8
            If IsSafe(k, p) Then
                Position(k) = p
                t = Solve(k + 1)
                If t Then
                    Solve = True
                    Exit Function
                End If
            End If
        Next

    End Function
    Private Sub DrawChessBoard()
        Dim i, j As Integer
        Dim t As Boolean
        For i = 1 To 8
            t = Not t
            For j = 1 To 8
                If t Then
                    g.FillRectangle(Brushes.Black, (j - 1) * 50, (i - 1) * 50, 50, 50)
                Else
                    g.FillRectangle(Brushes.White, (j - 1) * 50, (i - 1) * 50, 50, 50)
                End If
                t = Not t
            Next

        Next
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        g.DrawImage(My.Resources.Queen1, 0, 0)
        PictureBox1.Refresh()
    End Sub
End Class
