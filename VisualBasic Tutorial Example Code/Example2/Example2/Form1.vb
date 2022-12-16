' نمايش عداد کامل 1 تا 1000
Public Class Form1
    Private Const MAX_NUMBER = 1000
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim i, a, s As Integer
        For i = 1 To MAX_NUMBER
            s = 0
            For a = 2 To i / 2
                If (i Mod a) = 0 Then
                    s += a
                End If
            Next
            If (i = s + 1) Then
                ListBox1.Items.Add("(" + i.ToString() + ")" + "    is perfect number")
            End If
        Next
    End Sub
End Class
