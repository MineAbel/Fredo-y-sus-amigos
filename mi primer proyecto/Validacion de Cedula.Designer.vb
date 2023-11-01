<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Validacion_de_Cedula
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
        Me.txtci = New System.Windows.Forms.MaskedTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtci
        '
        Me.txtci.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtci.Location = New System.Drawing.Point(33, 89)
        Me.txtci.Mask = "0.000.000-0"
        Me.txtci.Name = "txtci"
        Me.txtci.Size = New System.Drawing.Size(235, 42)
        Me.txtci.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(490, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(201, 96)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Valida"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtp1
        '
        Me.dtp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1.Location = New System.Drawing.Point(33, 213)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(173, 38)
        Me.dtp1.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(490, 182)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(201, 105)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Valida Fecha de Nacimiento"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(33, 323)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(237, 45)
        Me.txtemail.TabIndex = 4
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(490, 323)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(201, 64)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Valida Mail"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 31)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Cedula"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(270, 31)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Fecha de Nacimiento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 289)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(239, 31)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Correo Electronico"
        '
        'Validacion_de_Cedula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dtp1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtci)
        Me.Name = "Validacion_de_Cedula"
        Me.Text = "Validacion_de_Cedula"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtci As MaskedTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents dtp1 As DateTimePicker
    Friend WithEvents Button2 As Button
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
