Imports System.Text.RegularExpressions

Public Class Form8
    Dim ruta As String = My.Application.Info.DirectoryPath & "\textos"

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_nombre.TextChanged

    End Sub
    Private Function validar_mail(ByVal smail As String) As Boolean
        Return Regex.IsMatch(smail, "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dbledad As Double = DateTime.Now.Subtract(dtp1.Text).TotalDays / 365.25
        If txt_nombre.Text = "" Then
            MessageBox.Show("ingrese nombre")
            txt_nombre.Focus()
            Exit Sub
        End If
        If txt_apellido.Text = "" Then
            MessageBox.Show("ingrese apellido")
            txt_apellido.Focus()
            Exit Sub
        End If
        If txt_tel.Text = "" Then
            MessageBox.Show("ingrese telefono")
            txt_tel.Focus()
            Exit Sub
        End If


        If dbledad < 18 Or dbledad > 70 Then
            MsgBox("La Edad debe estar entre 18 y 70 años", MsgBoxStyle.Exclamation, "Error")
            dtp1.Focus()

            Exit Sub
        End If
        If txtci.Text = "_.___.___-_" Then
            MessageBox.Show("ingrese cedula")
            txtci.Focus()
            Exit Sub
        End If


        txtci.TextMaskFormat = MaskFormat.IncludePromptAndLiterals
        If txt_email.Text = "" Then
            MessageBox.Show("ingrese E-Mail")
            txt_email.Focus()
            Exit Sub
        End If
        Dim smail As String
        txt_email.Text = Trim(txt_email.Text)
        smail = txt_email.Text
        If Len(smail) > 0 Then
            If validar_mail(smail) = False Then
                MsgBox("Dirección e-mail incorrecta", MsgBoxStyle.Exclamation, "Error")
                txt_email.Focus()
                txt_email.SelectAll()
                Exit Sub
            Else

                MsgBox("Dirección e-mail correcto")
            End If
        Else
            MsgBox("Escriba la dirección e-mail", MsgBoxStyle.Exclamation, "Error")
            txt_email.Focus()
            Exit Sub
        End If




    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtp1.ValueChanged

    End Sub

    Private Sub txt_tel_TextChanged(sender As Object, e As EventArgs) Handles txt_tel.TextChanged

    End Sub

    Private Sub txt_tel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_tel.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombre.KeyPress
        If InStr("qwertyuiopasdfghjklñzxcvbnm" & Chr(8), e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_apellido_TextChanged(sender As Object, e As EventArgs) Handles txt_apellido.TextChanged

    End Sub

    Private Sub txt_apellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_apellido.KeyPress
        If InStr("qwertyuiopasdfghjklñzxcvbnm" & Chr(8), e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        muestra()
        Me.Close()
    End Sub
End Class