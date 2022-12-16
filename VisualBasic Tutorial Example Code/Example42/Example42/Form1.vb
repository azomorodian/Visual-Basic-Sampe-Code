Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Add(TextBox1.Text.ToLower())

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        ListBox1.Items.Add(TextBox1.Text.ToUpper())
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim a() As String
        a = TextBox1.Text.Split(" ")
        For Each Str1 As String In a
            ListBox1.Items.Add(Str1)
        Next
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        For i = 0 To TextBox1.Text.Length - 1
            ListBox1.Items.Add(TextBox1.Text.Chars(i))
        Next
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        ListBox1.Items.Add("Len = " + TextBox1.Text.Length.ToString())
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        ListBox1.Items.Add("Index Of First Space = " + TextBox1.Text.IndexOf(" ").ToString())
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        ListBox1.Items.Add("Sub 5 2 = (" + TextBox1.Text.Substring(5, 2) + ")")
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        ListBox1.Items.Add(TextBox1.Text.StartsWith("is"))
    End Sub
End Class
