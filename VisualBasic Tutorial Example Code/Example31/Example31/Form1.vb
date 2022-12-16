Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim n As Integer
        n = TextBox1.Text
        MsgBox(String.Format("Factorial({0}) = {1}", n, Factorial(n)))

    End Sub
    Private Function Factorial(ByVal n As Integer) As ULong
        If n <= 1 Then
            Factorial = 1
        Else
            Factorial = n * Factorial(n - 1)
        End If
    End Function
End Class
