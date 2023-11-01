Imports System.Reflection.Emit

Public Class Form2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Numero As Integer

        Numero = Val(TextBox1.Text)
        If Numero > 0 Then
            Label2.Text = "El número es positivo"
        ElseIf Numero < 0 Then
            Label2.Text = "El número es negativo"
        Else Numero = 0
            Label2.Text = "El número es cero"


        End If
        Label2.Visible = True
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If InStr("-0123456789" & Chr(8), e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Numero1 As Integer

        Numero1 = Val(TextBox2.Text)
        Dim Resto As Byte
        Resto = Numero1 Mod 2
        If Resto = 0 Then
            Label4.Text = "El número es par"

        Else
            Label4.Text = "El número es impar"


        End If
        Label4.Visible = True
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox3.Text = "" Then
            MessageBox.Show("ingrese una edad...")
            TextBox3.Focus()
            Exit Sub
        End If


        Dim Edad As Byte
        Edad = Val(TextBox3.Text)

        If Edad >= 18 Then
            Label6.Text = "eres mayor de edad"
        Else
            Label6.Text = "eres menor de edad"

        End If
        Label6.Visible = True
        TextBox1.Focus()
        TextBox1.SelectAll()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click_1(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Letras As String
        Letras = TextBox4.Text

        If (TextBox4.Text = "a") Or (TextBox4.Text = "A") Or (TextBox4.Text = "e") Or
        (TextBox4.Text = "E") Or (TextBox4.Text = "i") Or (TextBox4.Text = "I") Or (TextBox4.Text = "o") Or
        (TextBox4.Text = "O") Or (TextBox4.Text = "u") Or (TextBox4.Text = "U") Then
            Label8.Text = "Es vocal"
        Else
            Label8.Text = "Es consonante"

        End If
        Label8.Visible = True
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If InStr("qwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNM" & Chr(8), e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        muestra()
        Me.Close()
    End Sub
End Class