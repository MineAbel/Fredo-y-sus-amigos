<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calcula
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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl_nro1 = New System.Windows.Forms.Label()
        Me.lbl_signo = New System.Windows.Forms.Label()
        Me.lbl_nro2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_resultado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_hora = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.IndianRed
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(525, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(246, 97)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Numeros"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lbl_nro1
        '
        Me.lbl_nro1.AutoSize = True
        Me.lbl_nro1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lbl_nro1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nro1.Location = New System.Drawing.Point(88, 217)
        Me.lbl_nro1.Name = "lbl_nro1"
        Me.lbl_nro1.Size = New System.Drawing.Size(95, 31)
        Me.lbl_nro1.TabIndex = 1
        Me.lbl_nro1.Text = "Label1"
        '
        'lbl_signo
        '
        Me.lbl_signo.AutoSize = True
        Me.lbl_signo.BackColor = System.Drawing.SystemColors.ControlText
        Me.lbl_signo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_signo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_signo.Location = New System.Drawing.Point(251, 217)
        Me.lbl_signo.Name = "lbl_signo"
        Me.lbl_signo.Size = New System.Drawing.Size(95, 31)
        Me.lbl_signo.TabIndex = 2
        Me.lbl_signo.Text = "Label2"
        '
        'lbl_nro2
        '
        Me.lbl_nro2.AutoSize = True
        Me.lbl_nro2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lbl_nro2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nro2.Location = New System.Drawing.Point(360, 217)
        Me.lbl_nro2.Name = "lbl_nro2"
        Me.lbl_nro2.Size = New System.Drawing.Size(95, 31)
        Me.lbl_nro2.TabIndex = 3
        Me.lbl_nro2.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(519, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 31)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "="
        '
        'txt_resultado
        '
        Me.txt_resultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_resultado.Location = New System.Drawing.Point(559, 217)
        Me.txt_resultado.MaxLength = 7
        Me.txt_resultado.Name = "txt_resultado"
        Me.txt_resultado.Size = New System.Drawing.Size(172, 36)
        Me.txt_resultado.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.IndianRed
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(179, 398)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 31)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'lbl_hora
        '
        Me.lbl_hora.AutoSize = True
        Me.lbl_hora.BackColor = System.Drawing.Color.IndianRed
        Me.lbl_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hora.Location = New System.Drawing.Point(436, 398)
        Me.lbl_hora.Name = "lbl_hora"
        Me.lbl_hora.Size = New System.Drawing.Size(95, 31)
        Me.lbl_hora.TabIndex = 7
        Me.lbl_hora.Text = "Label2"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(294, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(161, 93)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'calcula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lbl_hora)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_resultado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_nro2)
        Me.Controls.Add(Me.lbl_signo)
        Me.Controls.Add(Me.lbl_nro1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "calcula"
        Me.Text = "calcula"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents lbl_nro1 As Label
    Friend WithEvents lbl_signo As Label
    Friend WithEvents lbl_nro2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_resultado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_hora As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Button2 As Button
End Class
