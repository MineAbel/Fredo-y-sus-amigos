<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cuestionario
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_siguiente = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_puntaje = New System.Windows.Forms.Button()
        Me.btn_reiniciar = New System.Windows.Forms.Button()
        Me.DGV_1 = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_puntos = New System.Windows.Forms.Label()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Chocolate
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1497, 702)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(213, 108)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 38.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(528, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 44)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Responde"
        '
        'btn_siguiente
        '
        Me.btn_siguiente.BackColor = System.Drawing.Color.Chocolate
        Me.btn_siguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_siguiente.Location = New System.Drawing.Point(895, 276)
        Me.btn_siguiente.Name = "btn_siguiente"
        Me.btn_siguiente.Size = New System.Drawing.Size(262, 108)
        Me.btn_siguiente.TabIndex = 4
        Me.btn_siguiente.Text = "Siguiente"
        Me.btn_siguiente.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 31
        Me.ListBox1.Location = New System.Drawing.Point(526, 276)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(344, 345)
        Me.ListBox1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 38.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(859, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 44)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 38.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(982, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 44)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "de"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 38.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1052, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 44)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "label4"
        '
        'DGV1
        '
        Me.DGV1.AllowUserToAddRows = False
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(553, 391)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.Size = New System.Drawing.Size(106, 124)
        Me.DGV1.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 38.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(730, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(182, 44)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Pregunta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.LightCoral
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 38.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(607, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 44)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Label6"
        '
        'btn_puntaje
        '
        Me.btn_puntaje.BackColor = System.Drawing.Color.Chocolate
        Me.btn_puntaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_puntaje.Location = New System.Drawing.Point(895, 393)
        Me.btn_puntaje.Name = "btn_puntaje"
        Me.btn_puntaje.Size = New System.Drawing.Size(262, 108)
        Me.btn_puntaje.TabIndex = 12
        Me.btn_puntaje.Text = "Ver Puntaje"
        Me.btn_puntaje.UseVisualStyleBackColor = False
        Me.btn_puntaje.Visible = False
        '
        'btn_reiniciar
        '
        Me.btn_reiniciar.BackColor = System.Drawing.Color.Chocolate
        Me.btn_reiniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reiniciar.Location = New System.Drawing.Point(895, 507)
        Me.btn_reiniciar.Name = "btn_reiniciar"
        Me.btn_reiniciar.Size = New System.Drawing.Size(262, 108)
        Me.btn_reiniciar.TabIndex = 13
        Me.btn_reiniciar.Text = "Reiniciar"
        Me.btn_reiniciar.UseVisualStyleBackColor = False
        Me.btn_reiniciar.Visible = False
        '
        'DGV_1
        '
        Me.DGV_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_1.Location = New System.Drawing.Point(70, 78)
        Me.DGV_1.Name = "DGV_1"
        Me.DGV_1.Size = New System.Drawing.Size(375, 339)
        Me.DGV_1.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.LightCoral
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Label7"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.LightCoral
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 38.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 458)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(422, 44)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Arregla el validardatos"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(522, 650)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 20)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = ". . ."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(164, 527)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(179, 29)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Tu puntaje es:"
        Me.Label10.Visible = False
        '
        'lbl_puntos
        '
        Me.lbl_puntos.AutoSize = True
        Me.lbl_puntos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_puntos.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_puntos.Location = New System.Drawing.Point(231, 573)
        Me.lbl_puntos.Name = "lbl_puntos"
        Me.lbl_puntos.Size = New System.Drawing.Size(27, 29)
        Me.lbl_puntos.TabIndex = 19
        Me.lbl_puntos.Text = "0"
        Me.lbl_puntos.Visible = False
        '
        'Cuestionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 729)
        Me.Controls.Add(Me.lbl_puntos)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DGV_1)
        Me.Controls.Add(Me.btn_reiniciar)
        Me.Controls.Add(Me.btn_puntaje)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btn_siguiente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DGV1)
        Me.Name = "Cuestionario"
        Me.Text = "Cuestionario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_siguiente As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_puntaje As Button
    Friend WithEvents btn_reiniciar As Button
    Friend WithEvents DGV_1 As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_puntos As Label
End Class
