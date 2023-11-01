Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Numero As Byte
        Numero = Val(Numero1.Text)
        Dim Numeros As Byte
        Numeros = Val(Numero2.Text)
        Dim Numeross As Byte
        Numeross = Val(Numero3.Text)

        If Numero > Numeros Then
            If Numero > Numeross Then
                Label2.Text = ("el numero mayor es " & Numero)
            Else
                Label2.Text = ("el numero mayor es " & Numeross)

            End If
        Else
            If Numeros > Numero Then
                If Numeros > Numeross Then
                    Label2.Text = ("el numero mayor es " & Numeros)
                Else
                    Label2.Text = ("el numero mayor es " & Numeross)
                End If
            End If


        End If

        Label2.Visible = True

    End Sub

    Private Sub Numero1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("ingrese un nombre...")
            TextBox1.Focus()
            Exit Sub
        End If

        If TextBox2.Text = "" Then
            MessageBox.Show("ingrese una edad...")
            TextBox2.Focus()
            Exit Sub
        End If

        Dim Nombre As String
        Nombre = TextBox1.Text

        Dim Edad As Byte
        Edad = Val(TextBox2.Text)

        If Edad > 18 Then
            Label7.Text = "Bienvenido/a " & Nombre
        Else
            Label7.Text = "Lo siento, " & Nombre & ", eres menor de edad y no puedes acceder"
        End If

        Label7.Visible = True


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox3.Text = "" Then
            MessageBox.Show("ingrese un nombre...")
            TextBox3.Focus()
            Exit Sub
        End If

        If TextBox4.Text = "" Then
            MessageBox.Show("ingrese una contraseña...")
            TextBox4.Focus()
            Exit Sub
        End If

        Dim Nombre As String
        Nombre = TextBox3.Text

        Dim Contraseña As String
        Contraseña = (TextBox4.Text)

        If Nombre = "Lautaro" Then
            If Contraseña = "Diciembre" Then
                Label10.Text = "Bienvenida/o " & Nombre
            End If
        Else
            Label10.Text = "Lo siento, la contraseña o el usuario es incorrecto"
        End If

        Label10.Visible = True

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox5.Text = "" Then
            MessageBox.Show("ingrese el primer numero")
            TextBox5.Focus()
            Exit Sub
        End If

        If TextBox6.Text = "" Then
            MessageBox.Show("ingrese otro numero")
            TextBox6.Focus()
            Exit Sub
        End If

        Dim Numero1 As Byte
        Numero1 = Val(TextBox5.Text)
        Dim Numero2 As Byte
        Numero2 = Val(TextBox6.Text)

        If TextBox5.Text = TextBox6.Text Then
            Label13.Text = "Los numeros son iguales"
        Else
            Label13.Text = "Los numero son diferentes"

        End If

        Label13.Visible = True

    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If

    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If
    End Sub


    Private Sub TextBox6_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        muestra()
        Me.Close()
    End Sub
End Class