Public Class Form1
    Function fact(ByVal d As ULong) As ULong
        Dim i As Integer
        Dim r As ULong = 1
        fact = 1
        If (d < 2) Then
            Exit Function
        Else
            For i = 1 To d
                r *= i
            Next
            fact = r
        End If
    End Function
    Function C(ByVal m As Integer, ByVal n As Integer) As Long
        If (m > n) Then
            C = -1
        Else
            C = fact(n) / (fact(m) * fact(n - m))
        End If
    End Function
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim cr As Long
        Dim a As Integer
        Dim b As Integer
        a = Val(txtm.Text)
        b = Val(txtn.Text)
        cr = C(a, b)
        If (cr = -1) Then
            MsgBox("m Must Be Smaller Than b")
        Else
            txtResult.Text = "C(" + a.ToString() + "," + b.ToString() + ")=" + cr.ToString()
        End If
    End Sub
End Class
