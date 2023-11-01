Public Class Form6
    Dim contador As Byte = 0
    Dim resultado As Integer = 0
    Dim desplaza As Integer = 5
    Dim puntaje As Integer = 0
    Private Sub numeros()
        Dim N1, N2 As Byte
        N1 = Int((10 - 1 + 1) * Rnd() + 1)
        N2 = Int((10 - 1 + 1) * Rnd() + 1)

        Label1.Text = N1 & "*" & N2 & "="

        resultado = N1 * N2
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Timer1.Enabled = False Then
            numeros()
            Timer1.Enabled = True
            Button1.Image = System.Drawing.Image.FromFile(My.Application.Info.DirectoryPath & "\caer\2.png")
            Button1.Enabled = False
        Else
            Timer1.Enabled = False
            Button1.Image = System.Drawing.Image.FromFile(My.Application.Info.DirectoryPath & "\caer\1.png")
        End If
        Button2.Enabled = False



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        muestra()
        Me.Close()
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Focus()
        Randomize()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Label1.Top = Label1.Top + desplaza
        If Label1.Top > Me.Height Then
            Label1.Top = -50
            contador = contador + 1

            numeros()
        End If

        If contador = 5 Then
            Label1.Top = 30
            Timer1.Stop()
            Label1.Text = "Se Acabo"
            MessageBox.Show("termino")
            Button2.Enabled = True

        End If







    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        Label2.Text = HScrollBar1.Value
        desplaza = HScrollBar1.Value
        Label2.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = False
        Label1.Top = 30
        contador = 0
        Label1.Text = "Listo??"
        Button1.Enabled = True
        puntaje = 0
        TextBox1.Text = ""
        Label4.Text = "0"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If resultado = Val(TextBox1.Text) Then
                puntaje = puntaje + 5
                Label4.Text = puntaje
                resultado = 0
                Label1.Top = -50 : numeros() : contador = contador + 1 : TextBox1.SelectAll()
            End If
        End If
    End Sub
End Class