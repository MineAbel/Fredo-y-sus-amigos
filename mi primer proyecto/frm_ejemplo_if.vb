Imports System.Net.NetworkInformation

Public Class frm_ejemplo_if
    Private Sub frm_ejemplo_if_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        muestra()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        If TextBox1.Text = "" Then
            MessageBox.Show("ingrese una edad...")
            TextBox1.Focus()
            Exit Sub
        End If


        Dim Edad As Byte
        Edad = Val(TextBox1.Text)

        If Edad >= 22 Then
            MessageBox.Show("en cana...")
        Else
            MessageBox.Show("llamar al tutor...")

        End If
        TextBox1.Focus()
        TextBox1.SelectAll()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Edad As Byte
        Edad = Val(TextBox1.Text)
        If Edad <= 12 Then
            Label3.Text = "NIño"
        ElseIf Edad < 18 Then
            Label3.Text = "Adolecente"
        Else
            Label3.Text = "Adulto"


        End If
    End Sub
End Class