Public Class visualizador




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If visualizador1.ListBox1.SelectedIndex < visualizador1.ListBox1.Items.Count - 1 Then
            visualizador1.ListBox1.SelectedIndex = visualizador1.ListBox1.SelectedIndex + 1
        Else
            visualizador1.ListBox1.SelectedIndex = 0
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If visualizador1.ListBox1.SelectedIndex = 0 Then
            visualizador1.ListBox1.SelectedIndex = visualizador1.ListBox1.Items.Count - 1
        Else
            visualizador1.ListBox1.SelectedIndex = visualizador1.ListBox1.SelectedIndex - 1
        End If

    End Sub
    Sub nombre_archivo()
        Dim c As String = ""
        Dim p As Byte
        Dim largo As Byte

        Dim n As String
        'alt izq+92 \   c:\fotos\cara.jpg

        largo = Len(Label1.Text)

        Do While largo > 1
            c = Mid(Label1.Text, largo, 1)
            If c = "\" Then
                p = largo
                largo = 1
            Else
                largo = largo - 1
            End If
        Loop

        p = Len(Label1.Text) - p
        'extrae n caracteres de la la parte derecha
        n = Microsoft.VisualBasic.Right(Label1.Text, p)
        Label1.Text = n

    End Sub

    Private Sub visualizador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nombre_archivo()
    End Sub
    Private Sub Label1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.TextChanged

        nombre_archivo()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class