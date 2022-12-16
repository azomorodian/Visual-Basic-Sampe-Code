﻿Public Class Form1
    Dim MatA(,) As Integer
    Dim MatB(,) As Integer    
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        GetMetrixFromStr(TextBox1.Text, MatA)
        DisplayMatrix("A", MatA)
        Transpos_Marices(MatA, MatB)
        DisplayMatrix("A'", MatB)

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
    Sub Transpos_Marices(ByVal a(,) As Integer, ByRef b(,) As Integer)
        ReDim b(a.GetUpperBound(1), a.GetUpperBound(0))
        For i = 0 To a.GetUpperBound(0)
            For j = 0 To a.GetUpperBound(1)
                b(j, i) = a(i, j)
            Next
        Next
    End Sub
End Class

