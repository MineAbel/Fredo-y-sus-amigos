Public Class Form7
    Dim total As Integer
    Dim c As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        total = 0
        For i = 1 To Len(TextBox1.Text)
            c = Mid(TextBox1.Text, i, 1)
            total = total + Val(c)
        Next
        Label2.Text = total

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        muestra()
        Me.Close()
    End Sub
End Class