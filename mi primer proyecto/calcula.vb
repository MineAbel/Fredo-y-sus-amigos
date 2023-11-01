Public Class calcula
    Dim resultado As Integer
    Dim punto As Integer = 1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ls As Integer = 1000
        Dim li As Integer = 1
        Dim numero1 As Integer = 0
        Dim numero2 As Integer = 0

        numero1 = Int((ls - li + 1) * Rnd() + li)

        lbl_nro1.Text = numero1.ToString


        numero2 = Int((ls - li + 1) * Rnd() + li)

        lbl_nro2.Text = numero2.ToString

        Select Case Int((4 - 1 + 1) * Rnd() + 1)
            Case 1
                lbl_signo.Text = "-"
                resultado = numero1 - numero2
            Case 2
                lbl_signo.Text = "+"
                resultado = numero1 + numero2
            Case 3
                lbl_signo.Text = "*"
                resultado = numero1 * numero2
            Case 4
                lbl_signo.Text = "/"
                numero1 = numero2 * Int((7 - 1 + 1) * Rnd() + 1)
                lbl_nro1.Text = numero1.ToString
                resultado = numero1 / numero2

        End Select

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_resultado.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_resultado.KeyPress
        If InStr("1234567890-" & Chr(8), e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If


        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Label1.Visible = True
            If Val(txt_resultado.Text) = resultado Then
                Label1.Text = "correcto"
                Button1_Click(Nothing, Nothing)
                Timer2.Enabled = False
            Else
                Label1.Text = "verifique..."
                Timer2.Enabled = True
            End If


        End If





    End Sub

    Private Sub calcula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        lbl_hora.Text = DateString & " " & TimeString
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_hora.Text = DateString & " " & TimeString

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Select Case punto
            Case 1
                Label1.Text = "verifique   "
                punto = 2
            Case 2
                Label1.Text = "verifique.  "
                punto = 3
            Case 3
                Label1.Text = "verifique.. "
                punto = 4
            Case 4
                Label1.Text = "verifique..."
                punto = 1

        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        muestra()
        Me.Close()
    End Sub
End Class