Public Class Form1
    Private Const MAX_NUMBER = 100
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim s, i As Integer
        s = 0
        For i = 1 To MAX_NUMBER
            s += i
        Next
        TextBox1.Text = s.ToString()
    End Sub
End Class
