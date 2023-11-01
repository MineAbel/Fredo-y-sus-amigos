Public Class lef_right_y_mid
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As String
        a = Microsoft.VisualBasic.Left(TextBox1.Text, nro_carac.Value)
        MsgBox(a)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a As String
        a = Microsoft.VisualBasic.Right(TextBox1.Text, nro_carac.Value)
        MsgBox(a)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim c As String = ""
        Dim p As Byte
        Dim largo As Byte = Len(TextBox1.Text)
        Dim n As String

        'alt izq+92 \   c:\fotos\cara.jpg
        Try

            Do While c <> "\"
                'mid...extrae n caracteres de una cadena
                c = Mid(TextBox1.Text, largo, 1)
                If c = "\" Then
                    p = largo
                Else
                    largo = largo - 1
                End If
            Loop

            p = Len(TextBox1.Text) - p

            'extrae n caracteres de la la parte derecha
            n = Microsoft.VisualBasic.Right(TextBox1.Text, p)
            MsgBox(n)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub btnfin_Click(sender As Object, e As EventArgs) Handles btnfin.Click
        muestra()
        Me.Close()
    End Sub
End Class