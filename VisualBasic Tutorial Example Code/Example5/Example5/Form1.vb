
Public Class Form1
    Dim n As Integer
    Dim x As Double
    Dim i As Integer
    Dim s As Double
    Dim p As Double
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        n = Val(txtn.Text)
        x = Val(txtX.Text)
        s = 0
        p = 1
        For i = 1 To n
            s += Math.Sin(i * x)
            p *= Math.Sin(i * x)
        Next
        txtResult.Text = "         S = " + s.ToString("0.0000") + "        P = " + p.ToString("0.0000")
    End Sub
End Class
