Public Class Form1
    Dim r As New Random
    Dim SeriesNo As Integer = 0
    'N = 10
    Dim Arr(10) As Integer
    Private Sub DisplayArray(ByVal disparr() As Integer)
        ListBox1.Items.Add("Series " + SeriesNo.ToString())
        Dim str1 As String = ""

        For i = 0 To 9
            str1 += String.Format("{0,5}", disparr(i))
        Next
        ListBox1.Items.Add(str1)
    End Sub
    Private Sub Selection_Sort(ByRef SortArr() As Integer)
        'Array.Sort(SortArr)
        Dim pass, min_index, temp, i As Integer
        For pass = 0 To 8
            min_index = pass
            For i = pass + 1 To 9
                If SortArr(i) < SortArr(min_index) Then
                    min_index = i
                End If
                If (min_index <> pass) Then
                    temp = SortArr(pass)
                    SortArr(pass) = SortArr(min_index)
                    SortArr(min_index) = temp
                End If
            Next
        Next
        Dim chk As Boolean = True
        For a = 0 To 8 'N-2
            chk = True
            For b = 0 To 8 - a 'N-2-a
                If SortArr(b) < SortArr(b + 1) Then
                    temp = SortArr(b)
                    SortArr(b) = SortArr(b + 1)
                    SortArr(b + 1) = temp
                    chk = False
                End If
            Next
            If chk = True Then Exit For
        Next


    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Selection_Sort(Arr)
        DisplayArray(Arr)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Randomize()
        For i = 0 To 9
            Arr(i) = r.Next(100)
        Next
        SeriesNo += 1
        DisplayArray(Arr)
    End Sub
End Class
