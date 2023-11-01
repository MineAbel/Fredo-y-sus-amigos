Public Class Form4
    Dim PrecioconIVA As Double = 0
    Dim IVA As Double = 0
    Dim PreciosinIVA As Double = 0
    Dim pago As Double = 0
    Dim sobrante As Double = 0
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PreciosinIVA = Val(TextBox1.Text)
        IVA = (PreciosinIVA * Val(TextBox2.Text))/100
        pago = Val(TextBox3.Text)

        PrecioconIVA = PreciosinIVA + IVA

        sobrante = pago - PrecioconIVA
        Label6.Text = PrecioconIVA
        Label7.Text = sobrante

        If sobrante < 0 Then
            Label7.Text = "no se puede realizar el pago"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        IVA = 0
        sobrante = 0
        PrecioconIVA = 0
        PreciosinIVA = 0
        pago = 0
        Label6.Text = "0"
        Label7.Text = "0"
        TextBox1.Text = "0"
        TextBox2.Text = "0"
        TextBox3.Text = "0"


    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If
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
        muestra()
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox2.Text = ComboBox1.Text

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList

    End Sub
End Class