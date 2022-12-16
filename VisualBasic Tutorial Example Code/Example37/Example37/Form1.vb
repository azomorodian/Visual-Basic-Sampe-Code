Public Class Form1
    Const snvalue As Char = "A"
    Const invalue As Char = "B"
    Const dnvalue As Char = "C"


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim n As Integer
        n = TextBox1.Text
        ListBox1.Items.Clear()
        ListBox1.Items.Add("Towe Of Hanoi Problem With" + n.ToString() + " Disks")
        ListBox1.Items.Add("")
        hanoi(n, snvalue, invalue, dnvalue)

    End Sub
    Private Sub hanoi(ByVal n As UInteger, ByVal sndl As Char, ByVal indl As Char, ByVal dndl As Char)
        If n <> 0 Then
            hanoi(n - 1, sndl, dndl, indl)
            ListBox1.Items.Add(String.Format("Move Disk {0} From {1} To {2}", n, sndl, dndl))
            hanoi(n - 1, indl, sndl, dndl)
        End If
    End Sub
End Class
