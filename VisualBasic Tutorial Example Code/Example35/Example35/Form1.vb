Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim n, r As UInt32
        n = TextBox1.Text
        r = StrReverse(n)
        TextBox2.Text = r
    End Sub
    Private Function inverse(ByVal x As UInt32) As UInt32
        Dim l As UInt32
        If (x < 10) Then
            inverse = x
        Else
            l = Math.Floor(Math.Log10(x) + 1)
            inverse = (x Mod 10) * Math.Pow(10, l - 1) + inverse(x / 10)
        End If
    End Function
End Class
