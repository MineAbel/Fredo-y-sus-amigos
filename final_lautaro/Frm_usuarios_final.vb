Imports System.Data.OleDb
Imports System.IO
Public Class Form1

    Dim obj_usuario As New cls_usuarios
    Dim modifico As Boolean
    'TODAS LAS CLASES COMIENZAN CON CLS

    Dim n As Integer
    Dim ini As Integer
    Dim f As Integer
    Dim id As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Button1.Enabled = False

        carga_datos()

        ini = 0
        ActualizarTabla(Me.DGV1, "usuarios", "", "tipo")
        pinta_fila(ini)


        DGV1.Columns("contraseña").Visible = False
    End Sub
    Sub carga_datos()
        Dim SQL As String
        '                         0                   1
        SQL = "SELECT Usuarios.tipo
FROM Usuarios
GROUP BY Usuarios.tipo
ORDER BY Usuarios.tipo
;"



        Dim da As New OleDbDataAdapter(SQL, RutaDB_final)
        Dim dt As New DataTable

        da.Fill(dt)

        ComboBox1.Items.Clear()

        For i = 0 To dt.Rows.Count - 1
            Dim dr As DataRow 'dr datarow
            dr = dt.Rows(i)
            ComboBox1.Items.Add(dr(0))

            ' ComboBox1.Items.Add(dr(0)) 'CARGA LOS PAISES EN EL COMBO
        Next



    End Sub
    Sub ActualizarTabla(ByVal grilla As DataGridView, ByVal nombre_tabla As String,
                        ByVal campoSql As String, ByVal C_ORDEN As String)
        Try
            Dim da As OleDbDataAdapter 'DATAADPTER
            Dim dt As DataTable
            Dim consulta As String 'f9
            consulta = "Select "
            If campoSql = "" Then
                consulta += "*"
            Else
                consulta += campoSql
            End If
            consulta += " From " & nombre_tabla & " ORDER BY " & C_ORDEN
            da = New OleDbDataAdapter(consulta, RutaDB_final)
            dt = New DataTable
            da.Fill(dt)
            n = dt.Rows.Count

            grilla.DataSource = dt
            grilla.ReadOnly = True 'SOLO DE LECTURA
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnnuevo2_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        txt_pass.Enabled = True
        txt_usuario.Enabled = True
        ComboBox1.Enabled = True
        TextBox1.Enabled = True

        btnagregar.Enabled = True
        btncancelar.Enabled = True
        btnfin.Enabled = False
        btnmodificar.Enabled = False
        btneliminar.Enabled = False
        DGV1.Enabled = False

        Try
            btnagregar.Enabled = True
            btnnuevo.Enabled = False
            '  PictureBox1.Image = Nothing

            LimpiarCampos()
            modifico = False

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
    Sub ModoModificacion()
        btnagregar.Enabled = False
        btneliminar.Enabled = True
        btnmodificar.Enabled = True
        btncancelar.Enabled = True
    End Sub
    Sub LimpiarCampos()

        txt_usuario.Text = ""
        txt_pass.Text = ""
        ComboBox1.Text = ""
        TextBox1.Text = ""

        txt_usuario.Focus()
    End Sub
    Sub ModoInsercion()
        btncancelar.Enabled = True
        btnnuevo.Enabled = True
        btneliminar.Enabled = False
        btnmodificar.Enabled = False
        btnagregar.Enabled = True
    End Sub
    Function ValidarDatos() As Boolean


        If ComboBox1.Text.Trim = "" Then
            MsgBox("error en el tipo...")
            ComboBox1.Focus()
            Return False
            Exit Function
        End If

        If txt_usuario.Text.Trim = "" Then
            MsgBox("error en el usuario...")
            txt_usuario.Focus()
            Return False
            Exit Function
        End If
        If txt_pass.Text.Trim = "" Then
            MsgBox("error en la contraseña...")
            txt_pass.Focus()
            Return False
            Exit Function
        End If

        If txt_pass.Text <> TextBox1.Text Then
            MsgBox("la contraseña debe ser iguales")
            txt_pass.Focus()
            Return False
            Exit Function
        End If

        'preguntar por la foto...si tiene la foto del comienzo....le tengo q decir elija foto...
        Return True


    End Function
    Private Sub txt_pass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_pass.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If
    End Sub
    Function ObtenerCampo(ByVal grilla As DataGridView, ByVal indice_columna As Byte)
        Try
            If Not IsDBNull(grilla.Item(indice_columna, grilla.CurrentCell.RowIndex).Value) Then
                Return CStr(grilla.Item(indice_columna, grilla.CurrentCell.RowIndex).Value)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function
    Sub pinta_fila(ByVal nn As Integer)

        Try

            For i As Integer = 0 To DGV1.Rows.Count - 1
                DGV1.Rows(i).Selected = False
            Next

            DGV1.Rows(nn).Selected = True

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnagregar2_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        btnagregar.Enabled = False

        Try

            If ValidarDatos() Then
                '  obj_usuario.AgregaUsuario()



                If obj_usuario.AgregaUsuario(txt_usuario.Text, ComboBox1.Text, txt_pass.Text) = True Then

                    MsgBox("Registro ingresado satisfactoriamente", MsgBoxStyle.Information, "Confirmacion")
                    Me.LimpiarCampos()
                    ActualizarTabla(Me.DGV1, "usuarios", "", "tipo")

                Else
                    MsgBox("Error al ingresar el registro, reintente la accion", MsgBoxStyle.Critical, "Error")
                    Exit Sub

                End If

            End If

            PictureBox1.Image = Nothing
            Me.ModoInsercion()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de Validación de datos")
        End Try



    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox2_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseDown

        txt_pass.PasswordChar = ""
        TextBox1.PasswordChar = ""
        PictureBox2.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\fotos\abierto.png")
        PictureBox1.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\fotos\abierto.png")
    End Sub

    Private Sub txt_usuario_TextChanged(sender As Object, e As EventArgs) Handles txt_usuario.TextChanged

    End Sub

    Private Sub txt_usuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_usuario.KeyPress
        If InStr("qwertyuiopasdfghjklñzxcvbnm" & Chr(8), e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        If InStr("" & Chr(8), e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

        If InStr("0123456789" & Chr(8), e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub PictureBox2_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseUp
        PictureBox2.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\fotos\94674.png")
        PictureBox1.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\fotos\94674.png")
        txt_pass.PasswordChar = "*"
        TextBox1.PasswordChar = "*"
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        PictureBox2.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\fotos\94674.png")
        PictureBox1.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\fotos\94674.png")
        txt_pass.PasswordChar = "*"
        TextBox1.PasswordChar = "*"
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        txt_pass.PasswordChar = ""
        TextBox1.PasswordChar = ""
        PictureBox2.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\fotos\abierto.png")
        PictureBox1.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\fotos\abierto.png")
    End Sub

    Private Sub btncancelar2_Click(sender As Object, e As EventArgs) Handles btncancelar.Click

        txt_pass.Enabled = False
        txt_usuario.Enabled = False
        ComboBox1.Enabled = False
        TextBox1.Enabled = False

        btneliminar.Enabled = True
        btnmodificar.Enabled = True
        btnnuevo.Enabled = True
        btnagregar.Enabled = False
        btnfin.Enabled = True
        DGV1.Enabled = True
        id = DGV1.Item(0, 0).Value

        pinta_fila(0)



    End Sub

    Private Sub btnfin2_Click(sender As Object, e As EventArgs) Handles btnfin.Click

        Me.Close()
    End Sub

    Private Sub btneliminar2_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim i = MsgBox("¿Desea eliminar este usuario?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Confirmación")
        If i = MsgBoxResult.Yes Then
            Try

                If obj_usuario.EliminaUsuarios(id) = True Then
                    MsgBox("Registro Eliminado satisfactoriamente", MsgBoxStyle.Information, "Confirmacion")
                    Me.LimpiarCampos()
                    ActualizarTabla(Me.DGV1, "usuarios", "", "tipo")
                    Me.ModoInsercion()
                    Me.LimpiarCampos()
                Else
                    MsgBox("Error al eliminar el registro, reintente la accion", MsgBoxStyle.Critical, "Error")
                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de Validación de datos")
            End Try

        Else

        End If

        btnagregar.Enabled = False

    End Sub

    Private Sub DGV1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellContentClick

    End Sub

    Private Sub DGV1_MouseClick(sender As Object, e As MouseEventArgs) Handles DGV1.MouseClick
        If DGV1.SelectedRows.Count = 0 Then
            MsgBox("Debe seleccionar un usuario para poder editarlo", MsgBoxStyle.Critical, "Error")
            DGV1.Focus()
        Else
            Me.ModoModificacion()



            txt_usuario.Text = ObtenerCampo(Me.DGV1, 0)
            ComboBox1.Text = ObtenerCampo(Me.DGV1, 1)
            TextBox1.Text = ObtenerCampo(Me.DGV1, 2)
            txt_pass.Text = ObtenerCampo(Me.DGV1, 2)
            id = ObtenerCampo(Me.DGV1, 0)

            txt_pass.Enabled = True
            ComboBox1.Enabled = True
            TextBox1.Enabled = True

            btnnuevo.Enabled = False
            ' txtNombre.Focus()
            'Label6.Text = DGV1.CurrentRow.Index + 1
            'ini = dgv1.CurrentRow.Index

        End If
    End Sub

    Private Sub btnmodificar2_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Try
            modifico = True

            Dim i = MsgBox("¿Desea modificar ese registro?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Confirmación")

            If i = MsgBoxResult.Yes Then

                If ValidarDatos() Then
                    If obj_usuario.Modificausuario(txt_usuario.Text, ComboBox1.Text, txt_pass.Text) = True Then
                        MsgBox("Registro actualizado satisfactoriamente", MsgBoxStyle.Information, "Confirmacion")
                        Me.LimpiarCampos()
                        ActualizarTabla(Me.DGV1, "usuarios", "", "usuario")
                        Me.ModoInsercion()
                    Else
                        MsgBox("Error al modificar el registro, reintente la acción", MsgBoxStyle.Critical, "Error")
                    End If
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de Validación de datos")
        End Try
    End Sub





    Private Sub btnnuevo2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnagregar_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnmodificar_Click_1(sender As Object, e As EventArgs)
        Try
            modifico = True

            Dim i = MsgBox("¿Desea modificar ese registro?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Confirmación")

            If i = MsgBoxResult.Yes Then

                If ValidarDatos() Then
                    If obj_usuario.Modificausuario(txt_usuario.Text, ComboBox1.Text, txt_pass.Text) = True Then
                        MsgBox("Registro actualizado satisfactoriamente", MsgBoxStyle.Information, "Confirmacion")
                        Me.LimpiarCampos()
                        ActualizarTabla(Me.DGV1, "usuarios", "", "usuario")
                        Me.ModoInsercion()
                    Else
                        MsgBox("Error al modificar el registro, reintente la acción", MsgBoxStyle.Critical, "Error")
                    End If
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de Validación de datos")
        End Try
    End Sub

    Private Sub btncancelar_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btneliminar_Click_1(sender As Object, e As EventArgs)
        Dim i = MsgBox("¿Desea eliminar este usuario?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Confirmación")
        If i = MsgBoxResult.Yes Then
            Try

                If obj_usuario.EliminaUsuarios(id) = True Then
                    MsgBox("Registro Eliminado satisfactoriamente", MsgBoxStyle.Information, "Confirmacion")
                    Me.LimpiarCampos()
                    ActualizarTabla(Me.DGV1, "usuarios", "", "tipo")
                    Me.ModoInsercion()
                    Me.LimpiarCampos()
                Else
                    MsgBox("Error al eliminar el registro, reintente la accion", MsgBoxStyle.Critical, "Error")
                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de Validación de datos")
            End Try

        Else

        End If

        btnagregar.Enabled = False
    End Sub

    Private Sub DGV1_Click(sender As Object, e As EventArgs) Handles DGV1.Click

    End Sub
End Class
