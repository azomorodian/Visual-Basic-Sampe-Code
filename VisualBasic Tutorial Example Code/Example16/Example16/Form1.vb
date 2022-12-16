Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim a, b, c As Double
        a = TextBox1.Text
        b = TextBox2.Text
        c = TextBox3.Text
        If (a * a = b * b + c * c) Or (b * b = a * a + c * c) Or (c * c = a * a + b * b) Then
            MsgBox("اين اعداد مي توانند اظلاع يک مثلت قائم الزاويه باشند")
        Else
            MsgBox("اين اعداد نمي توانند اظلاع يک مثلت قائم الزاويه باشند")
        End If
    End Sub
End Class
