Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim a1, a2 As ULong
        Dim m As Integer
        Dim c As Integer
        a1 = 1
        a2 = 1
        m = txtNum.Text
        If m < 2 Then
            MsgBox("Please Enter a Number grater than 2")
        End If
        ListBox1.Items.Clear()
        ListBox1.Items.Add(a1.ToString())
        ListBox1.Items.Add(a2.ToString())
        Dim b As ULong
        For c = 3 To m
            b = a1
            a1 = a2
            a2 = b + a2
            ListBox1.Items.Add(a2.ToString())
        Next


    End Sub
End Class
