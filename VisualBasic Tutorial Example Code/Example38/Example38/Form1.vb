Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim n1, m1, r As Integer
        m1 = TextBox1.Text
        n1 = TextBox2.Text
        r = ackerman(m1, n1)
        TextBox3.Text = r
    End Sub
    Private Function ackerman(ByVal m As Integer, ByVal n As Integer)
        If m = 0 Then
            ackerman = n + 1
            Exit Function
        End If
        If n = 0 Then
            ackerman = ackerman(m - 1, 1)
            Exit Function
        End If
        ackerman = ackerman(m - 1, ackerman(m, n - 1))
    End Function
End Class
