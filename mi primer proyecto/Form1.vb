Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'MessageBox.Show("HOLA " & TXT_nombre.Text & ", bienvenido/a a visual")
        lbl_nombre.Text = "Hola " & TXT_nombre.Text & ", bienvenido/a a visual"
        lbl_nombre.Visible = True
    End Sub

    Private Sub TXT_nombre_TextChanged(sender As Object, e As EventArgs) Handles TXT_nombre.TextChanged

    End Sub

    Private Sub TXT_nombre_Click(sender As Object, e As EventArgs) Handles TXT_nombre.Click
        TXT_nombre.Text = ""
        lbl_nombre.Visible = False
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbl_nombre.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        muestra()
        Me.Close()
    End Sub
End Class
