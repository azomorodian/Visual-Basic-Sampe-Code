Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim m As ULong
        Dim n As ULong
        Dim s1 As ULong = 0
        Dim s2 As ULong
        Dim i, j As Integer
        m = Val(txtm.Text)
        n = Val(txtn.Text)
        For j = 1 To m
            s1 += m
        Next
        For i = 1 To n - 2
            For j = 1 To m
                s2 += s1
            Next
            s1 = s2
            s2 = 0
        Next
        TextBox3.Text = s1.ToString()
    End Sub
End Class
