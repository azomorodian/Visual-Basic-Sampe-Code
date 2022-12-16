Public Class Form1
    Dim i As Integer = 1
    Dim max, min, s, l As Integer

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click    
        If (i = 1) Then
            txtNumCount.Enabled = False
            max = Val(txtNum.Text)
            min = Val(txtNum.Text)
            s = Val(txtNum.Text)
        Else
            l = Val(txtNum.Text)
            s += l
            If (l > max) Then
                max = l
            End If
            If (l < min) Then
                min = l
            End If
        End If

        If i = Val(txtNumCount.Text) Then
            ListBox1.Items.Add("تعداد اعداد=" + Val(txtNumCount.Text).ToString())
            ListBox1.Items.Add("حداکثر=" + max.ToString())
            ListBox1.Items.Add("حداقل=" + min.ToString())
            ListBox1.Items.Add("ميانگين=" + (s / Val(txtNumCount.Text)).ToString())
            i = 1
            txtNumCount.Text = 5
            txtNumCount.Enabled = True
            txtNum.Text = 0
        End If
        i += 1
        Label1.Text = "عدد شماره " + i.ToString()

    End Sub
End Class
