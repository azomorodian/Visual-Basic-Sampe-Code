Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim N As Integer
        N = TextBox1.Text
        For i = 1 To N
            ListBox1.Items.Add(fibo(i).ToString())
        Next
    End Sub
    Private Function fibo(ByVal n As Integer) As ULong
        If (n = 1) Or (n = 2) Then
            fibo = 1
        Else
            fibo = fibo(n - 1) + fibo(n - 2)
        End If
    End Function
End Class
