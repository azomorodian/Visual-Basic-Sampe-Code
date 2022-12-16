Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
        Dim str1 As String = ""
        Dim n1 As String
        Dim padnum As Integer
        ListBox1.Items.Add("")
        ListBox1.Items.Add("")
        ListBox1.Items.Add("")
        ListBox1.Items.Add("")
        ListBox1.Items.Add("")


        For i = 1 To 15
            str1 = ""
            str1 = str1.PadLeft((15 - i) * 5, " ")
            For j = 1 To i
                n1 = npascal(i, j).ToString()
                padnum = (10 - n1.Length) / 2
                n1 = n1.PadLeft(padnum, " ")
                n1 = n1.PadRight(n1.Length + padnum + 1, " ")
                str1 += n1
            Next
            ListBox1.Items.Add(str1)
        Next

    End Sub
    Private Function npascal(ByVal i As Integer, ByVal j As Integer)
        If i = j Or j = 1 Then
            npascal = 1
        Else
            npascal = npascal(i - 1, j) + npascal(i - 1, j - 1)
        End If
    End Function
End Class
