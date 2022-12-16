'            نمايش تمامي اعداد اول 1 تا 1000
' لازم به ذکر است که اعداد اول ، اعدادي بزرگتر از 1 که بجر
'                .خودشان و يک مسوم عليه ديگري نداشته باشند
Public Class Form1

    Private Const MAX_NUMBER = 1000
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim chk_frist As Boolean

        For i = 2 To MAX_NUMBER
            chk_frist = True
            For a = 2 To i / 2
                If (i Mod a = 0) Then
                    chk_frist = False
                    Exit For
                End If
            Next
            If (chk_frist) Then
                ListBox1.Items.Add(i.ToString())
            End If
        Next
    End Sub
End Class
