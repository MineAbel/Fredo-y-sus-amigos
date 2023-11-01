Public Class login
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnfin_Click(sender As Object, e As EventArgs) Handles btnfin.Click
        Me.Close()
    End Sub

    Private Sub txt_pass_TextChanged(sender As Object, e As EventArgs) Handles txtpass.TextChanged

    End Sub

    Private Sub txt_pass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpass.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_usuario_TextChanged(sender As Object, e As EventArgs) Handles txtuser.TextChanged

    End Sub

    Private Sub txtuser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtuser.KeyPress
        If InStr("qwertyuiopasdfghjklñzxcvbnm" & Chr(8), e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox2_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseDown
        txtpass.PasswordChar = ""

        PictureBox2.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\fotos\abierto.png")

    End Sub

    Private Sub PictureBox2_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseUp
        PictureBox2.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\fotos\94674.png")

        txtpass.PasswordChar = "*"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

            If txtuser.Text = "" Or txtpass.Text = "" Then
                MsgBox("Ingrese nombre de usuario y contraseña")
                txtuser.Focus()
                Exit Sub
            Else
                Dim SQL1 As String
                ' Dim SQL2 As String
                ''                          0                     1                     2
                'SQL1 = "SELECT usuarios_PROGRAMA.usuario, usuarios_PROGRAMA.contraseña, usuarios_PROGRAMA.tipo " _
                '    + "FROM usuarios_PROGRAMA " _
                '    + "WHERE usuarios_PROGRAMA.usuario='" & txtuser.Text & "' AND usuarios_PROGRAMA.contraseña='" & txtpass.Text & "';"

                SQL1 = "SELECT Usuarios.usuario, Usuarios.contraseña, Usuarios.tipo
                  From Usuarios
                  Where Usuarios.usuario ='" & txtuser.Text & "' And Usuarios.contraseña ='" & txtpass.Text & "'"



                Dim da As New OleDb.OleDbDataAdapter(SQL1, RutaDB_final)
                Dim dt As New DataTable
                da.Fill(dt)

                If dt.Rows.Count = 0 Then
                    MsgBox("Usuario inexistente o contraseña incorrecta...")
                    txtuser.Focus()
                    Exit Sub
                Else
                    Dim dr As DataRow
                    dr = dt.Rows(0)
                    'MsgBox("Usuario autentificado correctamente, tipo de usuario: " & dr("tipo"), MsgBoxStyle.OkOnly, "Login")
                    'MDIParent1.Show()
                    usu = txtuser.Text
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class