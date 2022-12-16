Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim N As UInt32
        N = Convert.ToInt32(TextBox1.Text, 16)
        TextBox2.Text = Convert.ToString(N, 2) + "b"

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim N As UInt32
        N = Convert.ToInt32(TextBox1.Text, 16)

        TextBox2.Text = N.ToString()

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim N As UInt32
        N = Convert.ToInt32(TextBox1.Text, 16)
        TextBox2.Text = Convert.ToString(N, 8) + " Oct"

    End Sub
End Class
