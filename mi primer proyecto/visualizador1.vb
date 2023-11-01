Imports System.IO

Public Class visualizador1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_examina.Click
        Try
            FolderBrowserDialog1.ShowDialog()
            Label1.Text = FolderBrowserDialog1.SelectedPath

            If Label1.Text = "" Then Label1.Text = "..."

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dirtemp As DirectoryInfo
        Dim ruta As String = My.Application.Info.DirectoryPath & "\dado"

        Try
            ListBox1.Items.Clear()
            If Label1.Text = "..." Then
                dirtemp = New DirectoryInfo(ruta)
            Else
                dirtemp = New DirectoryInfo(Label1.Text)
            End If
            Call BUSCAIMAGENES(dirtemp) ' llamo el procedimiento findpictures con el directorio especificado
            dirtemp = Nothing
            'selecciona el primero

            If ListBox1.Items.Count = 0 Then
                MsgBox("sin imagenes...")
            Else
                ListBox1.SelectedIndex = 0
            End If


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub BUSCAIMAGENES(ByVal fsitemp As FileSystemInfo) 'fsitemp es una variable
        Try
            If fsitemp.GetType Is GetType(FileInfo) Then 'si lo que le pase en el procedimiento es el nombre de un archivo

                If fsitemp.Extension.ToUpper = ".JPG" Or fsitemp.Extension.ToUpper = ".PNG" Or fsitemp.Extension.ToUpper = ".gif" Then ' si la extension del archivo en mayusculas...
                    ListBox1.Items.Add(fsitemp.FullName) 'agrega el nombre completo del archivo en el listbox
                End If
            Else
                Dim dirtemp As New DirectoryInfo(fsitemp.FullName)
                Dim fsinew As FileSystemInfo
                Me.Text = "Buscando " & dirtemp.Name
                For Each fsinew In dirtemp.GetFileSystemInfos
                    Call BUSCAIMAGENES(fsinew)
                Next
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Try
            Pict.Image = Image.FromFile(ListBox1.SelectedItem.ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListBox1.SelectedIndex = 0 Then
            ListBox1.SelectedIndex = ListBox1.Items.Count - 1
        Else
            ListBox1.SelectedIndex = ListBox1.SelectedIndex - 1
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If ListBox1.SelectedIndex < ListBox1.Items.Count - 1 Then
            ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
        Else
            ListBox1.SelectedIndex = 0
        End If

    End Sub

    Private Sub Pict_Click(sender As Object, e As EventArgs) Handles Pict.Click

    End Sub

    Private Sub Pict_DoubleClick(sender As Object, e As EventArgs) Handles Pict.DoubleClick

        visualizador.PictureBox1.Image = Me.Pict.Image
        visualizador.ShowDialog()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()

    End Sub

    Private Sub Pict_Paint(sender As Object, e As PaintEventArgs) Handles Pict.Paint
        visualizador.PictureBox1.Image = Me.Pict.Image
        visualizador.Label1.Text = ListBox1.GetItemText(ListBox1.SelectedItem)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label1_TextChanged(sender As Object, e As EventArgs) Handles Label1.TextChanged
        'boton buscar
        Button2_Click(Nothing, Nothing)
        ListBox1.Focus()

    End Sub

End Class