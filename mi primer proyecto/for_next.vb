Public Class for_next
    Dim a As Byte
    Dim b As Byte
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()


        For i = 1 To 80000
            My.Application.DoEvents()

        Next



        If TextBox1.Text = "" And TextBox2.Text = "" Then
            For i = 1 To 10
                ListBox1.Items.Add(i)
            Next
        ElseIf TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("Agega inicio y final")
            Exit Sub
        Else
            a = Val(TextBox1.Text)
            b = Val(TextBox2.Text)
            For i = a To b
                ListBox1.Items.Add(i)
            Next
        End If
    End Sub


    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If InStr("1234567890" & Chr(8), e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If InStr("1234567890" & Chr(8), e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        muestra()

    End Sub

    Private Sub for_next_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class