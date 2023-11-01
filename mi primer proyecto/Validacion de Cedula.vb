Imports System.Text.RegularExpressions

Public Class Validacion_de_Cedula
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'EXCLUYA LA MASCARA... (3.258.698-7)  CEDULA SIN MASCARA (32586987)
        txtci.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals

        If valida_ci(txtci.Text) = True Then
            MsgBox("ci correcta")
        Else
            MsgBox("ci incorrecta...")
            Exit Sub
        End If


        txtci.TextMaskFormat = MaskFormat.IncludePromptAndLiterals

    End Sub
    Private Function valida_ci(ByVal cedula As String) As Boolean
        'ARRAY()
        Dim clave(7) As Byte
        Dim a As String
        Dim b As String
        Dim c As Double
        Dim d As Byte
        Dim i As Byte
        'txtci.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
        If cedula.Length < 8 Then
            MsgBox("Cédula incompleta", MsgBoxStyle.Exclamation, "Error")
            txtci.Focus() : txtci.SelectAll()
            Return False
            Exit Function
        Else
            clave(1) = 2
            clave(2) = 9
            clave(3) = 8
            clave(4) = 7
            clave(5) = 6
            clave(6) = 3
            clave(7) = 4
            c = 0
            For i = 1 To 7
                'txtci.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
                'extrae 1 caracter de una cadena de caracteres
                a = Mid(cedula, i, 1)
                b = a * clave(i)
                c = c + Val(Mid(b, Len(b), 1))
            Next i

            If Val(Mid(c, 2, 1)) = 0 Then
                d = 0
            Else
                d = 10 - Val(Mid(c, 2, 1))
            End If

            If d <> Mid(cedula, 8, 1) Then
                Return False
                MsgBox("Cédula incorrecta", MsgBoxStyle.Exclamation, "Error")
                txtci.Focus()
                txtci.Select(10, 1)
                Exit Function
            End If

            Return True

        End If

    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dbledad As Double = DateTime.Now.Subtract(dtp1.Text).TotalDays / 365.25

        If dbledad < 0 Or dbledad > 120 Then
            MsgBox("Fecha de nacimiento incorrecta", MsgBoxStyle.Exclamation, "Error")
            dtp1.Focus()

            Exit Sub
        Else
            MsgBox("Fecha de nacimiento correcta")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim smail As String
        TXTEMAIL.Text = Trim(TXTEMAIL.Text)
        smail = TXTEMAIL.Text
        If Len(smail) > 0 Then
            If validar_mail(smail) = False Then
                MsgBox("Dirección e-mail incorrecta", MsgBoxStyle.Exclamation, "Error")
                TXTEMAIL.Focus()
                TXTEMAIL.SelectAll()
                Exit Sub
            Else

                MsgBox("Dirección e-mail correcto")
            End If
        Else
            MsgBox("Escriba la dirección e-mail", MsgBoxStyle.Exclamation, "Error")
            TXTEMAIL.Focus()
            Exit Sub
        End If





    End Sub
    Private Function validar_mail(ByVal smail As String) As Boolean
        Return Regex.IsMatch(smail, "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")
    End Function

    Private Sub dtp1_ValueChanged(sender As Object, e As EventArgs) Handles dtp1.ValueChanged

    End Sub
End Class