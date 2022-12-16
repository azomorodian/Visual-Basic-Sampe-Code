Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        Dim str1 As String = ""
        For i = 0 To 255
            str1 += String.Format("{0,5} - {1}", i, Chr(i))
            If (i Mod 10 = 0) Then
                ListBox1.Items.Add(str1)
                str1 = ""
            End If
        Next
    End Sub
End Class
