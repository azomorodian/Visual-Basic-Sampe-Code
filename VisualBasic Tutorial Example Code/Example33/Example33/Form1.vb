Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim n1, n2, g, l As Integer
        n1 = TextBox1.Text
        n2 = TextBox2.Text
        g = gcd(n1, n2)
        l = n1 * n2 / g
        TextBox3.Text = g
        TextBox4.Text = l

    End Sub
    Private Function gcd(ByVal n1 As Integer, ByVal n2 As Integer)
        If (n2 > n1) Then
            gcd = gcd(n2, n1)
        Else
            If n1 Mod n2 = 0 Then
                gcd = n2
            Else
                gcd = gcd(n2, n1 Mod n2)
            End If
        End If
    End Function
End Class
