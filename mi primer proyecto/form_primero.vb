Public Class form_primero
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        form_segundo.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        muestra()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        form_tercero.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        form_cuarto.ShowDialog()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        form_segundo.TextBox1.Text = dato.ToString

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        form_tercero.TextBox1.Text = dato.ToString
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        form_cuarto.TextBox2.Text = dato.ToString
    End Sub
End Class