<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class list_view2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.txt_producto = New System.Windows.Forms.TextBox()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.txt_redondeo = New System.Windows.Forms.TextBox()
        Me.lbl_codigo = New System.Windows.Forms.Label()
        Me.lbl_producto = New System.Windows.Forms.Label()
        Me.lbl_precio = New System.Windows.Forms.Label()
        Me.lbl_cantidad = New System.Windows.Forms.Label()
        Me.lbl_redondeo = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_subtotal = New System.Windows.Forms.Label()
        Me.lbl_IVA = New System.Windows.Forms.Label()
        Me.lbl_subtotal1 = New System.Windows.Forms.Label()
        Me.lbl_red = New System.Windows.Forms.Label()
        Me.bt_agrega = New System.Windows.Forms.Button()
        Me.bt_redondear = New System.Windows.Forms.Button()
        Me.bt_nuevo = New System.Windows.Forms.Button()
        Me.bt_eliminar = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Codigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Producto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Precio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cantidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Descuento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Importe = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnfin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_codigo
        '
        Me.txt_codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codigo.Location = New System.Drawing.Point(149, 34)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(176, 35)
        Me.txt_codigo.TabIndex = 0
        '
        'txt_producto
        '
        Me.txt_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_producto.Location = New System.Drawing.Point(487, 31)
        Me.txt_producto.Name = "txt_producto"
        Me.txt_producto.Size = New System.Drawing.Size(176, 35)
        Me.txt_producto.TabIndex = 1
        '
        'txt_precio
        '
        Me.txt_precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_precio.Location = New System.Drawing.Point(789, 31)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(176, 35)
        Me.txt_precio.TabIndex = 2
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cantidad.Location = New System.Drawing.Point(1120, 34)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(176, 35)
        Me.txt_cantidad.TabIndex = 3
        '
        'txt_redondeo
        '
        Me.txt_redondeo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_redondeo.Location = New System.Drawing.Point(237, 658)
        Me.txt_redondeo.Name = "txt_redondeo"
        Me.txt_redondeo.Size = New System.Drawing.Size(176, 35)
        Me.txt_redondeo.TabIndex = 4
        '
        'lbl_codigo
        '
        Me.lbl_codigo.AutoSize = True
        Me.lbl_codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_codigo.Location = New System.Drawing.Point(34, 34)
        Me.lbl_codigo.Name = "lbl_codigo"
        Me.lbl_codigo.Size = New System.Drawing.Size(113, 32)
        Me.lbl_codigo.TabIndex = 5
        Me.lbl_codigo.Text = "Codigo:"
        '
        'lbl_producto
        '
        Me.lbl_producto.AutoSize = True
        Me.lbl_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_producto.Location = New System.Drawing.Point(345, 34)
        Me.lbl_producto.Name = "lbl_producto"
        Me.lbl_producto.Size = New System.Drawing.Size(136, 32)
        Me.lbl_producto.TabIndex = 6
        Me.lbl_producto.Text = "Producto:"
        '
        'lbl_precio
        '
        Me.lbl_precio.AutoSize = True
        Me.lbl_precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_precio.Location = New System.Drawing.Point(680, 37)
        Me.lbl_precio.Name = "lbl_precio"
        Me.lbl_precio.Size = New System.Drawing.Size(103, 32)
        Me.lbl_precio.TabIndex = 7
        Me.lbl_precio.Text = "Precio:"
        '
        'lbl_cantidad
        '
        Me.lbl_cantidad.AutoSize = True
        Me.lbl_cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cantidad.Location = New System.Drawing.Point(986, 40)
        Me.lbl_cantidad.Name = "lbl_cantidad"
        Me.lbl_cantidad.Size = New System.Drawing.Size(137, 32)
        Me.lbl_cantidad.TabIndex = 8
        Me.lbl_cantidad.Text = "Cantidad:"
        '
        'lbl_redondeo
        '
        Me.lbl_redondeo.AutoSize = True
        Me.lbl_redondeo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_redondeo.Location = New System.Drawing.Point(429, 661)
        Me.lbl_redondeo.Name = "lbl_redondeo"
        Me.lbl_redondeo.Size = New System.Drawing.Size(109, 32)
        Me.lbl_redondeo.TabIndex = 9
        Me.lbl_redondeo.Text = "$u 0.00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1005, 538)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 32)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Subtotal:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1005, 576)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 32)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "IVA 22%:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1005, 613)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 32)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Subtotal1:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1005, 648)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(154, 32)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Redondeo:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(1005, 680)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 32)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Total:"
        '
        'lbl_subtotal
        '
        Me.lbl_subtotal.AutoSize = True
        Me.lbl_subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subtotal.Location = New System.Drawing.Point(1245, 538)
        Me.lbl_subtotal.Name = "lbl_subtotal"
        Me.lbl_subtotal.Size = New System.Drawing.Size(109, 32)
        Me.lbl_subtotal.TabIndex = 15
        Me.lbl_subtotal.Text = "$u 0.00"
        '
        'lbl_IVA
        '
        Me.lbl_IVA.AutoSize = True
        Me.lbl_IVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_IVA.Location = New System.Drawing.Point(1245, 576)
        Me.lbl_IVA.Name = "lbl_IVA"
        Me.lbl_IVA.Size = New System.Drawing.Size(109, 32)
        Me.lbl_IVA.TabIndex = 16
        Me.lbl_IVA.Text = "$u 0.00"
        '
        'lbl_subtotal1
        '
        Me.lbl_subtotal1.AutoSize = True
        Me.lbl_subtotal1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subtotal1.Location = New System.Drawing.Point(1245, 613)
        Me.lbl_subtotal1.Name = "lbl_subtotal1"
        Me.lbl_subtotal1.Size = New System.Drawing.Size(109, 32)
        Me.lbl_subtotal1.TabIndex = 17
        Me.lbl_subtotal1.Text = "$u 0.00"
        '
        'lbl_red
        '
        Me.lbl_red.AutoSize = True
        Me.lbl_red.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_red.Location = New System.Drawing.Point(1245, 648)
        Me.lbl_red.Name = "lbl_red"
        Me.lbl_red.Size = New System.Drawing.Size(109, 32)
        Me.lbl_red.TabIndex = 18
        Me.lbl_red.Text = "$u 0.00"
        '
        'bt_agrega
        '
        Me.bt_agrega.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bt_agrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_agrega.Location = New System.Drawing.Point(1347, 117)
        Me.bt_agrega.Name = "bt_agrega"
        Me.bt_agrega.Size = New System.Drawing.Size(151, 64)
        Me.bt_agrega.TabIndex = 19
        Me.bt_agrega.Text = "Agregar"
        Me.bt_agrega.UseVisualStyleBackColor = False
        '
        'bt_redondear
        '
        Me.bt_redondear.BackColor = System.Drawing.Color.YellowGreen
        Me.bt_redondear.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_redondear.Location = New System.Drawing.Point(38, 642)
        Me.bt_redondear.Name = "bt_redondear"
        Me.bt_redondear.Size = New System.Drawing.Size(175, 64)
        Me.bt_redondear.TabIndex = 20
        Me.bt_redondear.Text = "Redondear"
        Me.bt_redondear.UseVisualStyleBackColor = False
        '
        'bt_nuevo
        '
        Me.bt_nuevo.BackColor = System.Drawing.Color.YellowGreen
        Me.bt_nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_nuevo.Location = New System.Drawing.Point(38, 538)
        Me.bt_nuevo.Name = "bt_nuevo"
        Me.bt_nuevo.Size = New System.Drawing.Size(151, 64)
        Me.bt_nuevo.TabIndex = 21
        Me.bt_nuevo.Text = "Nuevo"
        Me.bt_nuevo.UseVisualStyleBackColor = False
        '
        'bt_eliminar
        '
        Me.bt_eliminar.BackColor = System.Drawing.Color.IndianRed
        Me.bt_eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_eliminar.Location = New System.Drawing.Point(211, 538)
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Size = New System.Drawing.Size(151, 64)
        Me.bt_eliminar.TabIndex = 22
        Me.bt_eliminar.Text = "Eliminar"
        Me.bt_eliminar.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Codigo, Me.Producto, Me.Precio, Me.Cantidad, Me.Descuento, Me.Importe})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(38, 81)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1292, 404)
        Me.ListView1.TabIndex = 23
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Codigo
        '
        Me.Codigo.Text = "Codigo"
        Me.Codigo.Width = 156
        '
        'Producto
        '
        Me.Producto.Text = "Producto"
        Me.Producto.Width = 191
        '
        'Precio
        '
        Me.Precio.Text = "Precio"
        Me.Precio.Width = 155
        '
        'Cantidad
        '
        Me.Cantidad.Text = "Cantidad"
        Me.Cantidad.Width = 196
        '
        'Descuento
        '
        Me.Descuento.Text = "Descuento"
        Me.Descuento.Width = 259
        '
        'Importe
        '
        Me.Importe.Text = "Importe"
        Me.Importe.Width = 330
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(1245, 680)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(109, 32)
        Me.lbl_total.TabIndex = 24
        Me.lbl_total.Text = "$u 0.00"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.YellowGreen
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(387, 538)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 64)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Edita"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.YellowGreen
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1359, 421)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(151, 64)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Modifica"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnfin
        '
        Me.btnfin.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfin.Location = New System.Drawing.Point(40, 776)
        Me.btnfin.Name = "btnfin"
        Me.btnfin.Size = New System.Drawing.Size(156, 77)
        Me.btnfin.TabIndex = 27
        Me.btnfin.Text = "Fin"
        Me.btnfin.UseVisualStyleBackColor = False
        '
        'list_view2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1550, 922)
        Me.Controls.Add(Me.btnfin)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.bt_eliminar)
        Me.Controls.Add(Me.bt_nuevo)
        Me.Controls.Add(Me.bt_redondear)
        Me.Controls.Add(Me.bt_agrega)
        Me.Controls.Add(Me.lbl_red)
        Me.Controls.Add(Me.lbl_subtotal1)
        Me.Controls.Add(Me.lbl_IVA)
        Me.Controls.Add(Me.lbl_subtotal)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl_redondeo)
        Me.Controls.Add(Me.lbl_cantidad)
        Me.Controls.Add(Me.lbl_precio)
        Me.Controls.Add(Me.lbl_producto)
        Me.Controls.Add(Me.lbl_codigo)
        Me.Controls.Add(Me.txt_redondeo)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Controls.Add(Me.txt_precio)
        Me.Controls.Add(Me.txt_producto)
        Me.Controls.Add(Me.txt_codigo)
        Me.Name = "list_view2"
        Me.Text = "list_view2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_codigo As TextBox
    Friend WithEvents txt_producto As TextBox
    Friend WithEvents txt_precio As TextBox
    Friend WithEvents txt_cantidad As TextBox
    Friend WithEvents txt_redondeo As TextBox
    Friend WithEvents lbl_codigo As Label
    Friend WithEvents lbl_producto As Label
    Friend WithEvents lbl_precio As Label
    Friend WithEvents lbl_cantidad As Label
    Friend WithEvents lbl_redondeo As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_subtotal As Label
    Friend WithEvents lbl_IVA As Label
    Friend WithEvents lbl_subtotal1 As Label
    Friend WithEvents lbl_red As Label
    Friend WithEvents bt_agrega As Button
    Friend WithEvents bt_redondear As Button
    Friend WithEvents bt_nuevo As Button
    Friend WithEvents bt_eliminar As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents lbl_total As Label
    Friend WithEvents Codigo As ColumnHeader
    Friend WithEvents Producto As ColumnHeader
    Friend WithEvents Precio As ColumnHeader
    Friend WithEvents Cantidad As ColumnHeader
    Friend WithEvents Descuento As ColumnHeader
    Friend WithEvents Importe As ColumnHeader
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnfin As Button
End Class
