Public Class Form1
    Dim MatA(,) As Integer
    Dim MatB(,) As Double

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        GetMetrixFromStr(TextBox1.Text, MatA)
        DisplayMatrix("A", MatA)
        Dim res As Boolean
        Dim RValue As Long
        res = Determinan(MatA, RValue)
        If res And RValue <> 0 Then
            Reverse(MatA, MatB)
            DisplayMatrix("A^(-1)", MatB)
        Else
            ListBox1.Items.Add("Can't Reverse Matrix")
        End If

    End Sub
    Sub Reverse(ByVal a(,) As Integer, ByRef b(,) As Double)
        Dim i, j, ii, jj, i_i, j_j As Integer
        Dim t(,) As Integer
        Dim a1(,) As Integer
        Dim det As Long
        Dim h As Double
        Dim N As Integer
        N = a.GetUpperBound(0) + 1
        ReDim t(N - 1, N - 1)
        ReDim b(N - 1, N - 1)
        ReDim a1(N - 1, N - 1)
        For i = 0 To N - 1
            For j = 0 To N - 1
                a1(i, j) = a(i, j)
            Next
        Next
        For i = 0 To N - 1
            For j = 0 To N - 1
                i_i = 0
                j_j = 0
                For ii = 0 To N - 1
                    For jj = 0 To N - 1
                        If ((jj <> j) And (ii <> i)) Then
                            t(i_i, j_j) = a1(ii, jj)
                            j_j += 1
                        End If                    
                    Next
                    If (ii <> i) Then
                        i_i += 1
                        j_j = 0
                    End If
                Next
                b(i, j) = ((-1) ^ (i + j)) * determination(t, N - 1, N - 1)
            Next
        Next
        det = determination(a, N, N)
        For i = 0 To N - 1
            For j = 0 To N - 1
                If j > i Then
                    h = b(i, j)
                    b(i, j) = b(j, i)
                    b(j, i) = h
                End If
            Next
        Next
        For i = 0 To N - 1
            For j = 0 To N - 1
                b(i, j) /= det
            Next
        Next

    End Sub
    Sub GetMetrixFromStr(ByVal StrA As String, ByRef Mat(,) As Integer)
        Dim s As Integer
        Dim e As Integer
        Dim Row(), Col() As String
        s = StrA.IndexOf("[")
        e = StrA.IndexOf("]")
        StrA = StrA.Substring(s + 1, e - 1)
        Row = StrA.Split(";")
        Col = Row(0).Split(",")
        ReDim Mat(Row.Length - 1, Col.Length - 1)
        For i = 0 To Row.Length - 1
            Col = Row(i).Split(",")

            For j = 0 To Col.Length - 1
                Mat(i, j) = Val(Col(j))
            Next
        Next
    End Sub
    Sub DisplayMatrix(ByVal mName As String, ByVal mat(,) As Integer)
        Dim str1 As String
        ListBox1.Items.Add(mName + "= [ ")
        For i = 0 To mat.GetUpperBound(0)
            str1 = "       "
            For j = 0 To mat.GetUpperBound(1)
                str1 += String.Format("{0,7}", mat(i, j).ToString())
            Next
            ListBox1.Items.Add(str1)
        Next
        str1 = "]"
        str1 = str1.PadLeft(mName.Length + 4)
        ListBox1.Items.Add(str1)
    End Sub
    Sub DisplayMatrix(ByVal mName As String, ByVal mat(,) As Double)
        Dim str1 As String
        ListBox1.Items.Add(mName + "= [ ")
        For i = 0 To mat.GetUpperBound(0)
            str1 = "       "
            For j = 0 To mat.GetUpperBound(1)
                str1 += mat(i, j).ToString("0.0") + "   "
            Next
            ListBox1.Items.Add(str1)
        Next
        str1 = "]"
        str1 = str1.PadLeft(mName.Length + 4)
        ListBox1.Items.Add(str1)
    End Sub
    Function Determinan(ByVal a(,) As Integer, ByRef R As Long) As Boolean
        Determinan = False
        If a.GetUpperBound(0) <> a.GetUpperBound(1) Then Exit Function
        R = determination(a, a.GetUpperBound(0) + 1, a.GetUpperBound(0) + 1)
        Determinan = True
    End Function
    Function determination(ByVal a(,) As Integer, ByVal m As Integer, ByVal n As Integer) As Long
        Dim i, j, ii, jj, i_i, j_j As Integer
        Dim tar(,) As Integer
        Dim a1(,) As Integer
        Dim S As Long = 0
        ReDim a1(n - 1, n - 1)
        For i = 0 To n - 1
            For j = 0 To n - 1
                a1(i, j) = a(i, j)
            Next
        Next
        determination = S
        If (m <> n) Then Exit Function
        If (m = 2) Then
            S = a1(0, 0) * a1(1, 1) - a1(0, 1) * a1(1, 0)
            determination = S
            Exit Function
        End If
        ReDim tar(m - 1, n - 1)
        For i = 0 To m - 1
            For j = 0 To n - 1
                tar(i, j) = a1(i, j)
            Next
        Next
        For j = 0 To n - 1
            j_j = 0
            i_i = 0
            For ii = 1 To m - 1
                For jj = 0 To n - 1
                    If jj <> j Then
                        a1(i_i, j_j) = tar(ii, jj)
                        j_j += 1
                    End If
                Next
                i_i += 1
                j_j = 0
            Next
            S += ((-1) ^ j) * tar(0, j) * determination(a1, m - 1, n - 1)
        Next
        determination = S
    End Function
End Class


