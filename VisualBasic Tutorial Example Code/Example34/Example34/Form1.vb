Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim m, n As Integer
        Dim r As Long
        n = TextBox1.Text
        m = TextBox2.Text
        If (m <= n) Then
            r = C_M_N(m, n)
            TextBox3.Text = r.ToString()
        Else
            MsgBox("M must be smaller than N or Equal To N")
        End If
    End Sub
    Private Function C_M_N(ByVal m As Integer, ByVal n As Integer)
        If m = 0 Or m = n Then
            C_M_N = 1
            Exit Function
        End If
        If m = 1 Then
            C_M_N = n
        Else
            C_M_N = C_M_N(m, n - 1) + C_M_N(m - 1, n - 1)
        End If
    End Function
End Class
