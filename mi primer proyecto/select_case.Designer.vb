<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class select_case
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TXT_PRECIO = New System.Windows.Forms.TextBox()
        Me.TXT_CANT = New System.Windows.Forms.TextBox()
        Me.CBO_CAT = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Salmon
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(841, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(206, 84)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Calcula"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Precio Unidad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 44)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cantidad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 44)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Categoria:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 63)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Label4"
        Me.Label4.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Salmon
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(841, 139)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(206, 84)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Nuevo"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Salmon
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(841, 245)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(206, 84)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Fin"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TXT_PRECIO
        '
        Me.TXT_PRECIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_PRECIO.Location = New System.Drawing.Point(273, 24)
        Me.TXT_PRECIO.Name = "TXT_PRECIO"
        Me.TXT_PRECIO.Size = New System.Drawing.Size(211, 38)
        Me.TXT_PRECIO.TabIndex = 7
        '
        'TXT_CANT
        '
        Me.TXT_CANT.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CANT.Location = New System.Drawing.Point(187, 78)
        Me.TXT_CANT.Name = "TXT_CANT"
        Me.TXT_CANT.Size = New System.Drawing.Size(211, 38)
        Me.TXT_CANT.TabIndex = 9
        '
        'CBO_CAT
        '
        Me.CBO_CAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBO_CAT.FormattingEnabled = True
        Me.CBO_CAT.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.CBO_CAT.Location = New System.Drawing.Point(199, 142)
        Me.CBO_CAT.Name = "CBO_CAT"
        Me.CBO_CAT.Size = New System.Drawing.Size(211, 39)
        Me.CBO_CAT.TabIndex = 10
        '
        'select_case
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1103, 672)
        Me.Controls.Add(Me.CBO_CAT)
        Me.Controls.Add(Me.TXT_CANT)
        Me.Controls.Add(Me.TXT_PRECIO)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "select_case"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TXT_PRECIO As TextBox
    Friend WithEvents TXT_CANT As TextBox
    Friend WithEvents CBO_CAT As ComboBox
End Class
