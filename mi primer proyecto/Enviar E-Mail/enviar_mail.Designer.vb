<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class enviar_mail
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
        Me.txt_de = New System.Windows.Forms.TextBox()
        Me.txt_para = New System.Windows.Forms.TextBox()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.txt_cc = New System.Windows.Forms.TextBox()
        Me.txt_asunto = New System.Windows.Forms.TextBox()
        Me.txt_mensaje = New System.Windows.Forms.TextBox()
        Me.cbo_adjuntos = New System.Windows.Forms.ComboBox()
        Me.btn_adjuntos = New System.Windows.Forms.Button()
        Me.btn_enviar = New System.Windows.Forms.Button()
        Me.btn_cancela = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btn_fin = New System.Windows.Forms.Button()
        Me.lbl_de = New System.Windows.Forms.Label()
        Me.lbl_para = New System.Windows.Forms.Label()
        Me.lbl_asunto = New System.Windows.Forms.Label()
        Me.lbl_adjuntos = New System.Windows.Forms.Label()
        Me.lbl_pass = New System.Windows.Forms.Label()
        Me.lbl_cc = New System.Windows.Forms.Label()
        Me.lbl_mensaje = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lbl_enviando = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_de
        '
        Me.txt_de.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_de.Location = New System.Drawing.Point(142, 27)
        Me.txt_de.Name = "txt_de"
        Me.txt_de.Size = New System.Drawing.Size(273, 35)
        Me.txt_de.TabIndex = 0
        '
        'txt_para
        '
        Me.txt_para.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_para.Location = New System.Drawing.Point(142, 86)
        Me.txt_para.Name = "txt_para"
        Me.txt_para.Size = New System.Drawing.Size(273, 35)
        Me.txt_para.TabIndex = 1
        '
        'txt_pass
        '
        Me.txt_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pass.Location = New System.Drawing.Point(992, 27)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(122)
        Me.txt_pass.Size = New System.Drawing.Size(387, 35)
        Me.txt_pass.TabIndex = 2
        '
        'txt_cc
        '
        Me.txt_cc.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cc.Location = New System.Drawing.Point(992, 86)
        Me.txt_cc.Name = "txt_cc"
        Me.txt_cc.Size = New System.Drawing.Size(387, 35)
        Me.txt_cc.TabIndex = 3
        '
        'txt_asunto
        '
        Me.txt_asunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_asunto.Location = New System.Drawing.Point(142, 144)
        Me.txt_asunto.Name = "txt_asunto"
        Me.txt_asunto.Size = New System.Drawing.Size(1237, 35)
        Me.txt_asunto.TabIndex = 4
        '
        'txt_mensaje
        '
        Me.txt_mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mensaje.Location = New System.Drawing.Point(-1, 332)
        Me.txt_mensaje.Multiline = True
        Me.txt_mensaje.Name = "txt_mensaje"
        Me.txt_mensaje.Size = New System.Drawing.Size(1452, 445)
        Me.txt_mensaje.TabIndex = 5
        '
        'cbo_adjuntos
        '
        Me.cbo_adjuntos.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_adjuntos.FormattingEnabled = True
        Me.cbo_adjuntos.Location = New System.Drawing.Point(142, 198)
        Me.cbo_adjuntos.Name = "cbo_adjuntos"
        Me.cbo_adjuntos.Size = New System.Drawing.Size(528, 37)
        Me.cbo_adjuntos.TabIndex = 6
        '
        'btn_adjuntos
        '
        Me.btn_adjuntos.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_adjuntos.Location = New System.Drawing.Point(1298, 228)
        Me.btn_adjuntos.Name = "btn_adjuntos"
        Me.btn_adjuntos.Size = New System.Drawing.Size(153, 89)
        Me.btn_adjuntos.TabIndex = 7
        Me.btn_adjuntos.Text = "Agregar Adjuntos"
        Me.btn_adjuntos.UseVisualStyleBackColor = True
        '
        'btn_enviar
        '
        Me.btn_enviar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btn_enviar.Font = New System.Drawing.Font("Microsoft Tai Le", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enviar.Location = New System.Drawing.Point(692, 820)
        Me.btn_enviar.Name = "btn_enviar"
        Me.btn_enviar.Size = New System.Drawing.Size(210, 77)
        Me.btn_enviar.TabIndex = 8
        Me.btn_enviar.Text = "Enviar"
        Me.btn_enviar.UseVisualStyleBackColor = False
        '
        'btn_cancela
        '
        Me.btn_cancela.BackColor = System.Drawing.Color.Aquamarine
        Me.btn_cancela.Font = New System.Drawing.Font("Microsoft Tai Le", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancela.Location = New System.Drawing.Point(924, 820)
        Me.btn_cancela.Name = "btn_cancela"
        Me.btn_cancela.Size = New System.Drawing.Size(210, 77)
        Me.btn_cancela.TabIndex = 9
        Me.btn_cancela.Text = "Cancelar"
        Me.btn_cancela.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 881)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(388, 47)
        Me.ProgressBar1.TabIndex = 10
        '
        'btn_fin
        '
        Me.btn_fin.BackColor = System.Drawing.Color.IndianRed
        Me.btn_fin.Font = New System.Drawing.Font("Microsoft Tai Le", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fin.Location = New System.Drawing.Point(1155, 820)
        Me.btn_fin.Name = "btn_fin"
        Me.btn_fin.Size = New System.Drawing.Size(210, 77)
        Me.btn_fin.TabIndex = 11
        Me.btn_fin.Text = "Fin"
        Me.btn_fin.UseVisualStyleBackColor = False
        '
        'lbl_de
        '
        Me.lbl_de.AutoSize = True
        Me.lbl_de.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_de.ForeColor = System.Drawing.Color.IndianRed
        Me.lbl_de.Location = New System.Drawing.Point(79, 27)
        Me.lbl_de.Name = "lbl_de"
        Me.lbl_de.Size = New System.Drawing.Size(57, 31)
        Me.lbl_de.TabIndex = 12
        Me.lbl_de.Text = "De:"
        '
        'lbl_para
        '
        Me.lbl_para.AutoSize = True
        Me.lbl_para.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_para.ForeColor = System.Drawing.Color.IndianRed
        Me.lbl_para.Location = New System.Drawing.Point(57, 86)
        Me.lbl_para.Name = "lbl_para"
        Me.lbl_para.Size = New System.Drawing.Size(79, 31)
        Me.lbl_para.TabIndex = 13
        Me.lbl_para.Text = "Para:"
        '
        'lbl_asunto
        '
        Me.lbl_asunto.AutoSize = True
        Me.lbl_asunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_asunto.ForeColor = System.Drawing.Color.IndianRed
        Me.lbl_asunto.Location = New System.Drawing.Point(29, 144)
        Me.lbl_asunto.Name = "lbl_asunto"
        Me.lbl_asunto.Size = New System.Drawing.Size(107, 31)
        Me.lbl_asunto.TabIndex = 14
        Me.lbl_asunto.Text = "Asunto:"
        '
        'lbl_adjuntos
        '
        Me.lbl_adjuntos.AutoSize = True
        Me.lbl_adjuntos.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_adjuntos.ForeColor = System.Drawing.Color.IndianRed
        Me.lbl_adjuntos.Location = New System.Drawing.Point(-7, 199)
        Me.lbl_adjuntos.Name = "lbl_adjuntos"
        Me.lbl_adjuntos.Size = New System.Drawing.Size(128, 31)
        Me.lbl_adjuntos.TabIndex = 15
        Me.lbl_adjuntos.Text = "Adjuntos:"
        '
        'lbl_pass
        '
        Me.lbl_pass.AutoSize = True
        Me.lbl_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pass.ForeColor = System.Drawing.Color.IndianRed
        Me.lbl_pass.Location = New System.Drawing.Point(903, 27)
        Me.lbl_pass.Name = "lbl_pass"
        Me.lbl_pass.Size = New System.Drawing.Size(83, 31)
        Me.lbl_pass.TabIndex = 16
        Me.lbl_pass.Text = "Pass:"
        '
        'lbl_cc
        '
        Me.lbl_cc.AutoSize = True
        Me.lbl_cc.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cc.ForeColor = System.Drawing.Color.IndianRed
        Me.lbl_cc.Location = New System.Drawing.Point(924, 86)
        Me.lbl_cc.Name = "lbl_cc"
        Me.lbl_cc.Size = New System.Drawing.Size(62, 31)
        Me.lbl_cc.TabIndex = 17
        Me.lbl_cc.Text = "CC:"
        '
        'lbl_mensaje
        '
        Me.lbl_mensaje.AutoSize = True
        Me.lbl_mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mensaje.ForeColor = System.Drawing.Color.IndianRed
        Me.lbl_mensaje.Location = New System.Drawing.Point(29, 286)
        Me.lbl_mensaje.Name = "lbl_mensaje"
        Me.lbl_mensaje.Size = New System.Drawing.Size(124, 31)
        Me.lbl_mensaje.TabIndex = 18
        Me.lbl_mensaje.Text = "Mensaje:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lbl_enviando
        '
        Me.lbl_enviando.AutoSize = True
        Me.lbl_enviando.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_enviando.ForeColor = System.Drawing.Color.IndianRed
        Me.lbl_enviando.Location = New System.Drawing.Point(55, 834)
        Me.lbl_enviando.Name = "lbl_enviando"
        Me.lbl_enviando.Size = New System.Drawing.Size(302, 44)
        Me.lbl_enviando.TabIndex = 19
        Me.lbl_enviando.Text = "Enviando Mail...."
        '
        'enviar_mail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1463, 1061)
        Me.Controls.Add(Me.lbl_enviando)
        Me.Controls.Add(Me.lbl_mensaje)
        Me.Controls.Add(Me.lbl_cc)
        Me.Controls.Add(Me.lbl_pass)
        Me.Controls.Add(Me.lbl_adjuntos)
        Me.Controls.Add(Me.lbl_asunto)
        Me.Controls.Add(Me.lbl_para)
        Me.Controls.Add(Me.lbl_de)
        Me.Controls.Add(Me.btn_fin)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btn_cancela)
        Me.Controls.Add(Me.btn_enviar)
        Me.Controls.Add(Me.btn_adjuntos)
        Me.Controls.Add(Me.cbo_adjuntos)
        Me.Controls.Add(Me.txt_mensaje)
        Me.Controls.Add(Me.txt_asunto)
        Me.Controls.Add(Me.txt_cc)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_para)
        Me.Controls.Add(Me.txt_de)
        Me.Name = "enviar_mail"
        Me.Text = "enviar_mail"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_de As TextBox
    Friend WithEvents txt_para As TextBox
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents txt_cc As TextBox
    Friend WithEvents txt_asunto As TextBox
    Friend WithEvents txt_mensaje As TextBox
    Friend WithEvents cbo_adjuntos As ComboBox
    Friend WithEvents btn_adjuntos As Button
    Friend WithEvents btn_enviar As Button
    Friend WithEvents btn_cancela As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btn_fin As Button
    Friend WithEvents lbl_de As Label
    Friend WithEvents lbl_para As Label
    Friend WithEvents lbl_asunto As Label
    Friend WithEvents lbl_adjuntos As Label
    Friend WithEvents lbl_pass As Label
    Friend WithEvents lbl_cc As Label
    Friend WithEvents lbl_mensaje As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lbl_enviando As Label
End Class
