Imports System.Data.OleDb

Public Class login
    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Try

            If txtuser.Text = "" Or txtpass.Text = "" Then
                MsgBox("Ingrese nombre de usuario y contraseña")
                txtuser.Focus()
                Exit Sub
            Else
                Dim SQL1 As String
                ' Dim SQL2 As String
                '                          0                     1                     2
                SQL1 = "SELECT usuarios_PROGRAMA.usuario, usuarios_PROGRAMA.contraseña, usuarios_PROGRAMA.tipo " _
                    + "FROM usuarios_PROGRAMA " _
                    + "WHERE usuarios_PROGRAMA.usuario='" & txtuser.Text & "' AND usuarios_PROGRAMA.contraseña='" & txtpass.Text & "';"

                Dim da As New OleDbDataAdapter(SQL1, RutaDB)
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
                    MDIParent2.Show()
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class