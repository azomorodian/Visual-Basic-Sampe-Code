Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim num As ULong
        num = Reverse(Val(txtNum.Text))
        txtResult.Text = num.ToString()
    End Sub
    Function Reverse(ByVal n As UInteger) As ULong
        Dim num_no As UInteger = Math.Log10(n)
        Dim result As ULong = 0
        Dim i As Integer
        For i = num_no - 1 To 0 Step -1
            result += Int(Math.Pow(10, num_no - 1 - i)) * Int((n / (10 ^ i)))
            n -= int(n / (10 ^ i)) * (10 ^ i)
        Next
        Reverse = result
    End Function
End Class
