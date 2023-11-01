Public Class select_case
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub CBO_CAT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_CAT.SelectedIndexChanged
      

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim categoria As Char
        Dim cantidad As Integer
        Dim precioUnitario As Double
        Dim precioTotal As Double

        categoria = CBO_CAT.Text
        cantidad = Integer.Parse(TXT_CANT.Text)
        precioUnitario = Double.Parse(TXT_PRECIO.Text)

        Select Case categoria
            Case "A", "a"
                precioTotal = cantidad * precioUnitario
            Case "B", "b"
                precioTotal = cantidad * precioUnitario * 0.95
            Case "C", "c"
                precioTotal = cantidad * precioUnitario * 0.9
            Case "D", "d"
                precioTotal = cantidad * precioUnitario * 1.1
            Case Else
                MessageBox.Show("categ. erroneq...")
                Exit Sub


        End Select
        Label4.Text = ("El precio total es $" & precioTotal)
        Label4.Visible = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TXT_CANT.Text = ""
        TXT_PRECIO.Text = ""
        CBO_CAT.Text = ""
        Label4.Visible = False
    End Sub

    Private Sub TXT_PRECIO_TextChanged(sender As Object, e As EventArgs) Handles TXT_PRECIO.TextChanged

    End Sub

    Private Sub TXT_PRECIO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_PRECIO.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If

    End Sub

    Private Sub TXT_CANT_TextChanged(sender As Object, e As EventArgs) Handles TXT_CANT.TextChanged

    End Sub

    Private Sub TXT_CANT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_CANT.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub select_case_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class