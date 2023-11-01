Imports System.Data.OleDb
Imports System.Reflection.Emit

Public Class frm_usuarios
    Dim toco_foto As Boolean = False
    Dim ruta_imagen As String = My.Application.Info.DirectoryPath & "\fotos\usuario.png"

    Dim obj_usuario As New cls_usuarios
Dim modifico As Boolean
    'TODAS LAS CLASES COMIENZAN CON CLS

    Dim n As Integer
    Dim ini As Integer
    Dim f As Integer
    Dim id As Integer


    Private Sub frm_usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ini = 0
        ActualizarTabla(Me.DGV1, "usuarios", "", "APELLIDO")
        pinta_fila(ini)

        DGV1.Columns("fecha_creacion").DefaultCellStyle.Format = "dd/MM/yyyy"
        DGV1.Columns("fecha_creacion").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV1.Columns("foto").Visible = False
        DGV1.Columns("contraseña").Visible = False

        Label6.Text = "1"
        Label9.Text = n


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
            da = New OleDbDataAdapter(consulta, RutaDB)
            dt = New DataTable
            da.Fill(dt)
            n = dt.Rows.Count

            grilla.DataSource = dt
            grilla.ReadOnly = True 'SOLO DE LECTURA
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
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

    Private Sub DGV1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellContentClick

    End Sub

    Private Sub DGV1_MouseClick(sender As Object, e As MouseEventArgs) Handles DGV1.MouseClick
        If DGV1.SelectedRows.Count = 0 Then
            MsgBox("Debe seleccionar un usuario para poder editarlo", MsgBoxStyle.Critical, "Error")
            DGV1.Focus()
        Else
            Me.ModoModificacion()
            id = ObtenerCampo(Me.DGV1, 0)
            txt_nombre.Text = ObtenerCampo(Me.DGV1, 1)
            txt_apellido.Text = ObtenerCampo(Me.DGV1, 2)
            txt_usuario.Text = ObtenerCampo(Me.DGV1, 3)
            DTP1.Text = ObtenerCampo(Me.DGV1, 4)
            txt_pass.Text = ObtenerCampo(Me.DGV1, 6)

            PictureBox1.Image = DGV1.CurrentRow.Cells("foto").FormattedValue
            btnnuevo.Enabled = False
            ' txtNombre.Focus()
            Label6.Text = DGV1.CurrentRow.Index + 1
            'ini = dgv1.CurrentRow.Index



        End If

    End Sub
    Sub ModoModificacion()
        btnagregar.Enabled = False
        btneliminar.Enabled = True
        btnmodificar.Enabled = True
        btncancelar.Enabled = True
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

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click

        txt_nombre.Enabled = True
        txt_apellido.Enabled = True
        txt_pass.Enabled = True
        txt_usuario.Enabled = True

        Try
            btnagregar.Enabled = True
            btnnuevo.Enabled = False
            '  PictureBox1.Image = Nothing
            PictureBox1.Image = Drawing.Image.FromFile(ruta_imagen)
            LimpiarCampos()
            modifico = False

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
    Sub LimpiarCampos()
        txt_nombre.Text = ""
        txt_apellido.Text = ""
        txt_usuario.Text = ""
        txt_pass.Text = ""

        txt_nombre.Focus()
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Try
            If ValidarDatos() Then
                '  obj_usuario.AgregaUsuario()



                If obj_usuario.AgregaUsuario(txt_nombre.Text, txt_apellido.Text, txt_usuario.Text, DTP1.Value, PictureBox1, txt_pass.Text) = True Then

                    MsgBox("Registro ingresado satisfactoriamente", MsgBoxStyle.Information, "Confirmacion")
                    Me.LimpiarCampos()
                    ActualizarTabla(Me.DGV1, "usuarios", "", "apellido")

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
    Sub ModoInsercion()
        btncancelar.Enabled = True
        btnnuevo.Enabled = True
        btneliminar.Enabled = False
        btnmodificar.Enabled = False
        btnagregar.Enabled = True
    End Sub
    Function ValidarDatos() As Boolean

        If txt_nombre.Text.Trim = "" Then
            MsgBox("error en el nombre...")
            txt_nombre.Focus()
            Return False
            Exit Function
        End If

        If txt_apellido.Text.Trim = "" Then
            MsgBox("error en el apellido...")
            txt_apellido.Focus()
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
            MsgBox("error en el usuario...")
            txt_usuario.Focus()
            Return False
            Exit Function
        End If

        'preguntar por la foto...si tiene la foto del comienzo....le tengo q decir elija foto...

        If MODIFICO = False Then

            If toco_foto = False Then
                MsgBox("error no eligio una foto...")
                Return False
                Exit Function
            End If

        End If

        Return True

    End Function

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try

            With OpenFileDialog1
                'CHECK THE SELECTED FILE IF IT EXIST OTHERWISE THE DIALOG BOX WILL DISPLAY A WARNING.
                .CheckFileExists = True
                'CHECK THE SELECTED PATH IF IT EXIST OTHERWISE THE DIALOG BOX WILL DISPLAY A WARNING.
                .CheckPathExists = True
                'GET AND SET THE DEFAULT EXTENSION
                .DefaultExt = "jpg"
                'RETURN THE FILE LINKED TO THE LNK FILE
                .DereferenceLinks = True
                'SET THE FILE NAME TO EMPTY 
                .FileName = ""
                'FILTERING THE FILES
                .Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.bmp)|*.bmp|All files|*.*"
                'SET THIS FOR ONE FILE SELECTION ONLY.
                .Multiselect = False
                'SET THIS TO PUT THE CURRENT FOLDER BACK TO WHERE IT HAS STARTED.
                .RestoreDirectory = True
                'SET THE TITLE OF THE DIALOG BOX.
                .Title = "Seleccione una foto..."
                'ACCEPT ONLY THE VALID WIN32 FILE NAMES.
                .ValidateNames = True
                If .ShowDialog = DialogResult.OK Then
                    Try
                        PictureBox1.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
                        toco_foto = True

                    Catch fileException As Exception
                        Throw fileException
                    End Try
                End If
            End With


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try

    End Sub

    Private Sub txt_pass_TextChanged(sender As Object, e As EventArgs) Handles txt_pass.TextChanged

    End Sub

    Private Sub txt_pass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_pass.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        txt_nombre.Enabled = False
        txt_apellido.Enabled = False
        txt_pass.Enabled = False
        txt_usuario.Enabled = False

        btneliminar.Enabled = False
        btnmodificar.Enabled = False
        btnnuevo.Enabled = True
        btnagregar.Enabled = False

        pinta_fila(0)
        id = DGV1.Item(0, 0).Value

        ' Busca_usuario(id)

    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click

        Dim i = MsgBox("¿Desea eliminar este usuario?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Confirmación")
        If i = MsgBoxResult.Yes Then
            Try

                If obj_usuario.EliminaUsuarios(id) = True Then
                    MsgBox("Registro Eliminado satisfactoriamente", MsgBoxStyle.Information, "Confirmacion")
                    Me.LimpiarCampos()
                    ActualizarTabla(Me.DGV1, "usuarios", "", "id")
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

    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Try
            modifico = True

            Dim i = MsgBox("¿Desea modificar ese registro?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Confirmación")

            If i = MsgBoxResult.Yes Then

                If ValidarDatos() Then
                    If obj_usuario.Modificausuario(txt_nombre.Text, txt_apellido.Text, txt_usuario.Text, DTP1.Text, id, PictureBox1) = True Then
                        MsgBox("Registro actualizado satisfactoriamente", MsgBoxStyle.Information, "Confirmacion")
                        Me.LimpiarCampos()
                        ActualizarTabla(Me.DGV1, "usuarios", "", "id")
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

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox2_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseDown

        txt_pass.PasswordChar = ""
        PictureBox2.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\fotos\abierto.png")
    End Sub



    Private Sub PictureBox2_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseUp
        PictureBox2.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\fotos\94674.png")
        txt_pass.PasswordChar = "*"

    End Sub

    Private Sub btnfin_Click(sender As Object, e As EventArgs) Handles btnfin.Click
        muestra()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Val(Label6.Text) < DGV1.Rows.Count - 1 Then
            f = f + 1
            pinta_fila(f)
        Else
            pinta_fila(DGV1.Rows.Count - 1)
        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click




        Try

            If Val(Label6.Text) - 1 = 0 Then
                pinta_fila(0)
            ElseIf Val(Label6.Text) > 0 Then
                f = f - 1
                pinta_fila(f)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub DGV1_SelectionChanged(sender As Object, e As EventArgs) Handles DGV1.SelectionChanged
        Try

            If DGV1.SelectedCells.Count <> 0 Then

                Dim NFila As Integer = DGV1.SelectedCells(0).RowIndex

                'Con el N de Fila, me posiciono y recupero la Columna 'CodArt'
                Dim CodArt As String = DGV1.Rows(NFila).DataBoundItem("id").ToString

                id = DGV1.Rows(NFila).DataBoundItem("id").ToString
                txt_nombre.Text = DGV1.Rows(NFila).DataBoundItem("nombre").ToString
                txt_apellido.Text = DGV1.Rows(NFila).DataBoundItem("apellido").ToString
                txt_usuario.Text = DGV1.Rows(NFila).DataBoundItem("usuario").ToString
                DTP1.Text = DGV1.Rows(NFila).DataBoundItem("fecha_creacion").ToString
                PictureBox1.Image = DGV1.Rows(NFila).Cells("foto").FormattedValue
                ini = DGV1.CurrentRow.Index
                Label6.Text = DGV1.SelectedCells(0).RowIndex + 1
                'Label6.Text = f + 1
                f = NFila


            End If

        Catch ex As Exception


            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub txt_nombre_TextChanged(sender As Object, e As EventArgs) Handles txt_nombre.TextChanged

    End Sub
End Class