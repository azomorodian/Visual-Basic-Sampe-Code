Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim a As Integer
        Dim b As Integer
        Dim aa As Integer
        Dim bb As Integer
        a = Val(txtNum1.Text)
        b = Val(txtNum2.Text)
        If (a < b) Then
            aa = b
            bb = a
        Else
            aa = a
            bb = b
        End If
        While (aa Mod bb <> 0)
            bb = aa Mod bb
            aa = bb
        End While
        txtBMM.Text = bb.ToString()
        txtKMM.Text = (a * b / bb).ToString()
    End Sub
End Class
