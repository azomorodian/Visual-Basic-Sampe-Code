Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim m() As Double
        Dim Num() As String
        Dim str1, str2 As String
        Dim s, e1 As Integer
        Dim r As Double
        Dim X As Double
        s = TextBox1.Text.IndexOf("[")
        e1 = TextBox1.Text.IndexOf("]")
        str1 = TextBox1.Text.Substring(s + 1, e1 - 1)
        Num = str1.Split(",")
        ReDim m(Num.Length)
        str2 = ""
        For i = 0 To Num.Length - 1
            m(i) = Val(Num(i))
            If (Num.Length - i) > 1 Then
                str2 += Num(i) + "*X^" + (Num.Length - i - 1).ToString() + " + "
            Else
                str2 += Num(i)
            End If
        Next
        X = TextBox2.Text
        ListBox1.Items.Add("P(X) = " + str2)
        ListBox1.Items.Add("X = " + X.ToString("0.00"))
        r = p_n(Num.Length - 1, X, m)
        ListBox1.Items.Add("P(X) = " + r.ToString("0.000"))
    End Sub
    Private Function p_n(ByVal n As Integer, ByVal x As Double, ByVal m() As Double) As Double
        If n = 0 Then
            p_n = m(0)
            Exit Function
        End If
        p_n = x * p_n(n - 1, x, m) + m(n)
    End Function
End Class
