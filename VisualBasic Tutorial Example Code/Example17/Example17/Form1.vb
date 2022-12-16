Public Class Form1

    Const N As Integer = 20
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim x As Double
        Dim S As Double = 0
        x = TextBox1.Text
        For i = 0 To N
            S += (x ^ i) / Fact(i)
        Next
        TextBox2.Text = S
        TextBox3.Text = Math.Exp(x)


    End Sub
    Function Fact(ByVal n As Integer) As ULong
        Fact = 1
        Dim i As Integer
        For i = 1 To n
            Fact *= i
        Next
    End Function
End Class
