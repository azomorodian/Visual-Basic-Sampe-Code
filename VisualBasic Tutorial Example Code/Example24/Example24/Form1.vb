Public Class Form1
    Dim r As New Random
    Dim Arr(10) As Integer
    Dim SeriesNo As Integer = 0
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Randomize()
        For i = 0 To 9
            Arr(i) = r.Next(100)
        Next
        SeriesNo += 1
        DisplayArray(Arr)
    End Sub
    Private Sub DisplayArray(ByVal disparr() As Integer)
        ListBox1.Items.Add("Series " + SeriesNo.ToString())
        Dim str1 As String = ""

        For i = 0 To 9
            str1 += String.Format("{0,5}", disparr(i))
        Next
        ListBox1.Items.Add(str1)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        For i = 0 To 9
            Arr(i) = r.Next(100)
        Next
        SeriesNo += 1
        DisplayArray(Arr)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim item As Integer
        Dim idx As Integer
        item = TextBox1.Text
        idx = Linear_Search(Arr, item)
        If (idx = -1) Then
            ListBox1.Items.Add(String.Format("Number {0} is not found in Array", item))
        Else
            ListBox1.Items.Add(String.Format("Number {0} is found in Array and its Index equal {1}", item, idx))
        End If

    End Sub
    Private Function Linear_Search(ByVal A() As Integer, ByVal item As Integer)
        Linear_Search = -1
        For c = 0 To 9
            If A(c) = item Then
                Linear_Search = c
                Exit Function
            End If
        Next
    End Function
End Class
