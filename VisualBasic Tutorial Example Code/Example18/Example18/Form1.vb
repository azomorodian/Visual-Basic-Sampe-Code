Public Class Form1
    Const N As Integer = 10
    Dim ar() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Shift_To_Right(ar)
        Dim str1 As String = ""
        For i = 0 To N - 1
            str1 += String.Format("{0,5}", ar(i))
        Next
        ListBox1.Items.Add(str1)
    End Sub
    Private Sub Shift_To_Right(ByRef arr() As Integer)
        Dim a, b As Integer
        b = arr(N - 1)
        For a = N - 1 To 1 Step -1
            arr(a) = arr(a - 1)
        Next
        arr(0) = b
    End Sub
End Class
