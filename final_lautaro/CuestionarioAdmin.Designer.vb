<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CuestionarioAdmin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_respuesta_c = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_respuesta_4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_respuesta_3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_respuesta_2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_respuesta_1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_preguntas = New System.Windows.Forms.Label()
        Me.txt_preguntas = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_fin = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.dgv_1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_respuesta_c)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_respuesta_4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_respuesta_3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_respuesta_2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_respuesta_1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lbl_preguntas)
        Me.GroupBox1.Controls.Add(Me.txt_preguntas)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(33, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(445, 316)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'txt_respuesta_c
        '
        Me.txt_respuesta_c.Enabled = False
        Me.txt_respuesta_c.Location = New System.Drawing.Point(171, 259)
        Me.txt_respuesta_c.Multiline = True
        Me.txt_respuesta_c.Name = "txt_respuesta_c"
        Me.txt_respuesta_c.Size = New System.Drawing.Size(240, 32)
        Me.txt_respuesta_c.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 259)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Respuesta correcta:"
        '
        'txt_respuesta_4
        '
        Me.txt_respuesta_4.Enabled = False
        Me.txt_respuesta_4.Location = New System.Drawing.Point(122, 210)
        Me.txt_respuesta_4.Multiline = True
        Me.txt_respuesta_4.Name = "txt_respuesta_4"
        Me.txt_respuesta_4.Size = New System.Drawing.Size(289, 32)
        Me.txt_respuesta_4.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Respuesta 4:"
        '
        'txt_respuesta_3
        '
        Me.txt_respuesta_3.Enabled = False
        Me.txt_respuesta_3.Location = New System.Drawing.Point(122, 167)
        Me.txt_respuesta_3.Multiline = True
        Me.txt_respuesta_3.Name = "txt_respuesta_3"
        Me.txt_respuesta_3.Size = New System.Drawing.Size(289, 32)
        Me.txt_respuesta_3.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Respuesta 3:"
        '
        'txt_respuesta_2
        '
        Me.txt_respuesta_2.Enabled = False
        Me.txt_respuesta_2.Location = New System.Drawing.Point(122, 125)
        Me.txt_respuesta_2.Multiline = True
        Me.txt_respuesta_2.Name = "txt_respuesta_2"
        Me.txt_respuesta_2.Size = New System.Drawing.Size(289, 32)
        Me.txt_respuesta_2.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Respuesta 2:"
        '
        'txt_respuesta_1
        '
        Me.txt_respuesta_1.Enabled = False
        Me.txt_respuesta_1.Location = New System.Drawing.Point(122, 83)
        Me.txt_respuesta_1.Multiline = True
        Me.txt_respuesta_1.Name = "txt_respuesta_1"
        Me.txt_respuesta_1.Size = New System.Drawing.Size(289, 32)
        Me.txt_respuesta_1.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Respuesta 1:"
        '
        'lbl_preguntas
        '
        Me.lbl_preguntas.AutoSize = True
        Me.lbl_preguntas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_preguntas.Location = New System.Drawing.Point(34, 41)
        Me.lbl_preguntas.Name = "lbl_preguntas"
        Me.lbl_preguntas.Size = New System.Drawing.Size(82, 16)
        Me.lbl_preguntas.TabIndex = 5
        Me.lbl_preguntas.Text = "Preguntas:"
        '
        'txt_preguntas
        '
        Me.txt_preguntas.Enabled = False
        Me.txt_preguntas.Location = New System.Drawing.Point(122, 38)
        Me.txt_preguntas.Multiline = True
        Me.txt_preguntas.Name = "txt_preguntas"
        Me.txt_preguntas.Size = New System.Drawing.Size(289, 32)
        Me.txt_preguntas.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_cancelar)
        Me.GroupBox2.Controls.Add(Me.btn_nuevo)
        Me.GroupBox2.Controls.Add(Me.btn_fin)
        Me.GroupBox2.Controls.Add(Me.btn_eliminar)
        Me.GroupBox2.Controls.Add(Me.btn_modificar)
        Me.GroupBox2.Controls.Add(Me.btn_agregar)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(544, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(171, 316)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.Sienna
        Me.btn_cancelar.Enabled = False
        Me.btn_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.Location = New System.Drawing.Point(51, 63)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(87, 30)
        Me.btn_cancelar.TabIndex = 7
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackColor = System.Drawing.Color.Sienna
        Me.btn_nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nuevo.Location = New System.Drawing.Point(51, 21)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(87, 30)
        Me.btn_nuevo.TabIndex = 6
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.UseVisualStyleBackColor = False
        '
        'btn_fin
        '
        Me.btn_fin.BackColor = System.Drawing.Color.Sienna
        Me.btn_fin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fin.Location = New System.Drawing.Point(51, 250)
        Me.btn_fin.Name = "btn_fin"
        Me.btn_fin.Size = New System.Drawing.Size(87, 30)
        Me.btn_fin.TabIndex = 5
        Me.btn_fin.Text = "Fin"
        Me.btn_fin.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.Sienna
        Me.btn_eliminar.Enabled = False
        Me.btn_eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.Location = New System.Drawing.Point(51, 201)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(87, 30)
        Me.btn_eliminar.TabIndex = 4
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_modificar
        '
        Me.btn_modificar.BackColor = System.Drawing.Color.Sienna
        Me.btn_modificar.Enabled = False
        Me.btn_modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar.Location = New System.Drawing.Point(51, 154)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(87, 30)
        Me.btn_modificar.TabIndex = 2
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = False
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.Sienna
        Me.btn_agregar.Enabled = False
        Me.btn_agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar.Location = New System.Drawing.Point(51, 107)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(87, 30)
        Me.btn_agregar.TabIndex = 1
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'dgv_1
        '
        Me.dgv_1.AllowUserToAddRows = False
        Me.dgv_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_1.Location = New System.Drawing.Point(33, 369)
        Me.dgv_1.Name = "dgv_1"
        Me.dgv_1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_1.Size = New System.Drawing.Size(682, 260)
        Me.dgv_1.TabIndex = 11
        '
        'CuestionarioAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 733)
        Me.Controls.Add(Me.dgv_1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CuestionarioAdmin"
        Me.Text = "CuestionarioAdmin"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgv_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_preguntas As Label
    Friend WithEvents txt_preguntas As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents btn_fin As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_modificar As Button
    Friend WithEvents btn_agregar As Button
    Friend WithEvents dgv_1 As DataGridView
    Friend WithEvents txt_respuesta_c As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_respuesta_4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_respuesta_3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_respuesta_2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_respuesta_1 As TextBox
    Friend WithEvents btn_cancelar As Button
End Class
