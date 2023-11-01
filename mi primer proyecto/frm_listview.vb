Imports System.Reflection.Emit

Public Class frm_listview
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lista As ListViewItem = New ListViewItem(UCase(TextBox1.Text))
        lista.SubItems.Add(UCase(TextBox2.Text))
        lista.SubItems.Add(TextBox3.Text)

        If Val(TextBox3.Text) > 5 Then
            lista.SubItems.Add("Aprueba")
        Else
            lista.SubItems.Add("Recursa")
        End If
        If Val(TextBox3.Text) > 12 Or Val(TextBox3.Text) < 1 Then
            MessageBox.Show("ATENCION LAS NOTAS VAN ENTRE 1 Y 12")
            Exit Sub
        End If
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("ATENCION NOM O APELL ESTA VACIO..")
            Exit Sub
        End If
        ListView1.Items.Add(lista)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim lista As ListViewItem = New ListViewItem()
        For Each lista In ListView1.CheckedItems
            lista.Remove()
        Next

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListView1.Items.Clear()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        muestra()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim promedio As Double = 0
        Dim c As Byte = 0
        Dim fila As Byte = 0
        Dim lista As ListViewItem = New ListViewItem()
        For Each lista In ListView1.Items
            Dim primerElemento As ListViewItem = ListView1.Items(fila)
            Dim nota As Byte = primerElemento.SubItems(2).Text
            promedio = promedio + nota
            c = c + 1
            fila = fila + 1
        Next
        Label4.Text = Val(promedio / c).ToString

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class