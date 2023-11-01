Public Class Numero_Aleatorios
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ls As Byte = 6
        Dim li As Byte = 1
        Dim numero As Byte = 0

        numero = Int((ls - li + 1) * Rnd() + li)
        lbl_numero.Text = numero.ToString

        Select Case numero
            Case 1
                PictureBox1.Image = System.Drawing.Image.FromFile(My.Application.Info.DirectoryPath & "\dado\1.jpg")
            Case 2
                PictureBox1.Image = System.Drawing.Image.FromFile(My.Application.Info.DirectoryPath & "\dado\2.jpg")
            Case 3
                PictureBox1.Image = System.Drawing.Image.FromFile(My.Application.Info.DirectoryPath & "\dado\3.jpg")
            Case 4
                PictureBox1.Image = System.Drawing.Image.FromFile(My.Application.Info.DirectoryPath & "\dado\4.jpg")
            Case 5
                PictureBox1.Image = System.Drawing.Image.FromFile(My.Application.Info.DirectoryPath & "\dado\5.jpg")
            Case 6
                PictureBox1.Image = System.Drawing.Image.FromFile(My.Application.Info.DirectoryPath & "\dado\6.jpg")
        End Select


    End Sub

    Private Sub Numero_Aleatorios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class