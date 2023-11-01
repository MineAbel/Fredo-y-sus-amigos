Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class list_view2
    Dim FILA_p_EDITAR As Byte


    Dim iva As Double
    Dim subtotal As Double = 0
    Dim total1 As Double
    Dim total As Double
    Dim a As Double 'ACUMULA CUANDO DISMINUIMOS LA BOLETA

    Private Sub bt_redondear_Click(sender As Object, e As EventArgs) Handles bt_redondear.Click
        Dim VALOR As Double
        VALOR = Val(txt_redondeo.Text)
        'MATH.ROUND   ...REDONDEA A CERO DECIMAL
        VALOR = Math.Round(VALOR, 0)
        lbl_redondeo.Text = Format(VALOR, "$u ##,##0.00")

    End Sub

    Private Sub bt_nuevo_Click(sender As Object, e As EventArgs) Handles bt_nuevo.Click
        ListView1.Items.Clear()
    End Sub

    Private Sub bt_eliminar_Click(sender As Object, e As EventArgs) Handles bt_eliminar.Click
        Dim p As Boolean = False
        Dim redondeo As Double = 0
        Dim lista As ListViewItem = New ListViewItem()

        For Each lista In ListView1.CheckedItems
            lista.Remove()
            p = True
        Next

        If p = False Then
            MsgBox("Elija elemento a eliminar")
            Exit Sub
        End If

        'a --- acumula el importe de las lineas a eliminar
        subtotal = subtotal - a
        iva = (subtotal * 22) / 100
        total1 = Math.Round(subtotal + iva, 2)
        total = Math.Round(subtotal + iva, 1)
        redondeo = total - total1

        lbl_subtotal.Text = Format(subtotal, "$u ##,##0.00")
        lbl_IVA.Text = Format(iva, "$u ##,##0.00")
        lbl_total.Text = Format(total, "$u ##,##0.00")
        lbl_red.Text = Format(redondeo, "$u ##,##0.00")
        lbl_subtotal1.Text = Format(total1, "$u ##,##0.00")
        a = 0

    End Sub
    Private Function CHEQUEA_CODIGO(ByVal CODIGO As String) As Boolean
        Dim fila As Byte = 0
        Dim lista As ListViewItem = New ListViewItem()

        For Each lista In ListView1.Items

            'VER SI EXISE ESE CODIGO
            Dim Elemento As ListViewItem = ListView1.Items(fila)
            Dim cod As String = Elemento.SubItems(0).Text
            If CODIGO = cod Then
                Return True
                Exit Function
            End If
            fila += 1
        Next

        Return False

    End Function

    Private Sub bt_agrega_Click(sender As Object, e As EventArgs) Handles bt_agrega.Click

        Dim total As Double = Val(txt_precio.Text) * Val(txt_cantidad.Text)
        Dim lista As ListViewItem = New ListViewItem(txt_codigo.Text)
        Dim iva As Double = (total * 22) / 100
        Dim dto As Double = 0
        Dim importe As Double = 0
        Dim redondeo As Double

        dto = (total * 10) / 100

        'validar precio, cant>0, nombre<>"", el codigo<>""
        If txt_codigo.Text = "" Then
            MsgBox("error en el codigo")
            txt_codigo.Focus()
            Exit Sub
        End If

        If Trim(txt_precio.Text) = "" Then 'valida q tenga precio
            MsgBox("error en el precio")
            txt_precio.Focus()
            Exit Sub
        End If

        If Trim(txt_cantidad.Text) = "" Then 'valida cantidad
            MsgBox("error en la cantidad")
            txt_cantidad.Focus()
            Exit Sub
        End If

        If Trim(txt_producto.Text) = "" Then 'valida nombre
            MsgBox("error en el producto..")
            txt_producto.Focus()

            Exit Sub
        End If

        If Val(txt_cantidad.Text) = 0 Then 'valida nombre
            MsgBox("error, la cantidad no puede ser cero...")
            txt_cantidad.Focus()
            txt_cantidad.SelectAll()
            Exit Sub
        End If


        'CHEQUEAR Q EL CÓDIGO YA NO ESTE INGRESADO......
        If CHEQUEA_CODIGO(txt_codigo.Text) = True Then
            MsgBox("EL CÓDIGO YA EXISTE")
            txt_codigo.Focus()
            txt_codigo.SelectAll()

            Exit Sub
        End If



        lista.SubItems.Add(txt_producto.Text)
        lista.SubItems.Add(txt_precio.Text)
        lista.SubItems.Add(txt_cantidad.Text)

        If Val(txt_cantidad.Text) > 5 Then
            lista.SubItems.Add(dto)
            importe = (Val(txt_precio.Text) * Val(txt_cantidad.Text)) - dto
        Else
            lista.SubItems.Add(0)
            importe = (Val(txt_precio.Text) * Val(txt_cantidad.Text))
        End If



        lista.SubItems.Add(UCase(importe.ToString))

        ListView1.Items.Add(lista)

        subtotal = subtotal + importe

        iva = (subtotal * 22) / 100
        '560.68  .....560.7

        total1 = Math.Round(subtotal + iva, 2)
        total = Math.Round(subtotal + iva, 0)

        redondeo = total - total1

        lbl_subtotal.Text = Format(subtotal, "$u ##,##0.00")
        lbl_IVA.Text = Format(iva, "$u ##,##0.00")
        lbl_total.Text = Format(total, "$u ##,##0.00")
        lbl_red.Text = Format(redondeo, "$u ##,##0.00")
        lbl_subtotal1.Text = Format(total1, "$u ##,##0.00")

        txt_codigo.Text = ""
        txt_producto.Text = ""
        txt_precio.Text = ""
        txt_cantidad.Text = ""
        txt_codigo.Focus()





    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        bt_eliminar_Click(Nothing, Nothing)

        bt_agrega_Click(Nothing, Nothing) 'BOTON AGREGA
        Button2.Enabled = False
        bt_agrega.Enabled = True

        ListView1.Enabled = True


    End Sub

    Private Sub txt_codigo_TextChanged(sender As Object, e As EventArgs) Handles txt_codigo.TextChanged

    End Sub

    Private Sub txt_codigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_codigo.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_producto_TextChanged(sender As Object, e As EventArgs) Handles txt_producto.TextChanged

    End Sub

    Private Sub txt_precio_TextChanged(sender As Object, e As EventArgs) Handles txt_precio.TextChanged

    End Sub

    Private Sub txt_precio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_precio.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cantidad_TextChanged(sender As Object, e As EventArgs) Handles txt_cantidad.TextChanged

    End Sub

    Private Sub txt_cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cantidad.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub


    Private Sub ListView1_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles ListView1.ItemCheck

        If (e.CurrentValue = CheckState.Unchecked) Then
            'subitem 5 es el importe
            a = a + Val(ListView1.Items(e.Index).SubItems(5).Text)
            FILA_p_EDITAR = e.Index

        ElseIf (e.CurrentValue = CheckState.Checked) Then
            a = a - Val(ListView1.Items(e.Index).SubItems(5).Text)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Elemento As ListViewItem = ListView1.Items(FILA_p_EDITAR)
        Dim p As Boolean = False
        Dim lista As ListViewItem = New ListViewItem()

        For Each lista In ListView1.CheckedItems
            p = True
        Next

        If p = False Then
            MsgBox("Elija elemento a EDITAR ")
            Exit Sub
        End If

        txt_codigo.Text = Elemento.SubItems(0).Text
        txt_producto.Text = Elemento.SubItems(1).Text
        txt_precio.Text = Elemento.SubItems(2).Text
        txt_cantidad.Text = Elemento.SubItems(3).Text
        bt_agrega.Enabled = False
        Button2.Enabled = True

        ListView1.Enabled = False

    End Sub
    Private Sub ListView1_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles ListView1.ItemChecked
        Dim lista As ListViewItem = New ListViewItem()
        Dim ELEMENTO_SELEC As Byte = 0

        For Each lista In ListView1.CheckedItems
            ELEMENTO_SELEC = ELEMENTO_SELEC + 1
        Next

        If ELEMENTO_SELEC > 1 Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If

    End Sub

    Private Sub btnfin_Click(sender As Object, e As EventArgs) Handles btnfin.Click
        muestra()
        Me.Close()
    End Sub
End Class