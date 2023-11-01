Imports System.Data.OleDb

Public Class frm_historias

    Dim id As Integer
    Dim toco_foto As Boolean = False
    Dim modifico As Boolean
    Dim obj_usuario As New cls_historias
    Dim n As Integer
    Dim ini As Integer
    Dim ruta_imagen As String = My.Application.Info.DirectoryPath & "\fotos\usuario.png"


    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Try
            If ValidarDatos() Then
                'obj_usuario.AgregaHistorias()



                If obj_usuario.AgregaHistorias(txt_historias.Text, PictureBox1) = True Then

                    MsgBox("Registro ingresado satisfactoriamente", MsgBoxStyle.Information, "Confirmacion")
                    Me.LimpiarCampos()
                    ActualizarTabla(Me.dgv_1, "historias", "", "texto")

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
    Function ValidarDatos() As Boolean

        If txt_historias.Text.Trim = "" Then
            MsgBox("Se debe agregar una historia")
            txt_historias.Focus()
            Return False
            Exit Function
        End If

        'preguntar por la foto...si tiene la foto del comienzo....le tengo q decir elija foto...

        If modifico = False Then

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

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click

        Dim i = MsgBox("¿Desea eliminar esta historia?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Confirmación")
        If i = MsgBoxResult.Yes Then
            Try

                If obj_usuario.EliminaHistorias(id) = True Then
                    MsgBox("Registro Eliminado satisfactoriamente", MsgBoxStyle.Information, "Confirmacion")
                    Me.LimpiarCampos()
                    ActualizarTabla(Me.dgv_1, "historias", "", "texto")
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
    Sub LimpiarCampos()
        txt_historias.Text = ""
        txt_historias.Focus()
    End Sub
    Sub ModoInsercion()
        btn_eliminar.Enabled = False
        btn_modificar.Enabled = False
        btn_agregar.Enabled = True
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        Try
            modifico = True

            Dim i = MsgBox("¿Desea modificar esta historia?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Confirmación")

            If i = MsgBoxResult.Yes Then

                If ValidarDatos() Then
                    If obj_usuario.ModificaHistorias(txt_historias.Text, PictureBox1, id) = True Then
                        MsgBox("Registro actualizado satisfactoriamente", MsgBoxStyle.Information, "Confirmacion")
                        Me.LimpiarCampos()
                        ActualizarTabla(Me.dgv_1, "historias", "", "texto")
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

    Private Sub frm_historias_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ini = 0
        ActualizarTabla(Me.dgv_1, "historias", "", "texto")
        'Label6.Text = "1"
        'Label9.Text = n
        pinta_fila(ini)

        'dgv1.Columns("fecha_creacion").DefaultCellStyle.Format = "dd/MM/yyyy"
        'dgv1.Columns("fecha_creacion").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_1.Columns("foto").Visible = False

    End Sub
    Sub pinta_fila(ByVal nn As Integer)

        Try

            For i As Integer = 0 To dgv_1.Rows.Count - 1
                dgv_1.Rows(i).Selected = False
            Next

            dgv_1.Rows(nn).Selected = True

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub


    Private Sub btn_fin_Click(sender As Object, e As EventArgs) Handles btn_fin.Click
        Me.Close()
    End Sub

    Private Sub dgv_1_MouseClick(sender As Object, e As MouseEventArgs) Handles dgv_1.MouseClick
        If dgv_1.SelectedRows.Count = 0 Then
            MsgBox("Debe seleccionar una historia para poder editarla", MsgBoxStyle.Critical, "Error")
            dgv_1.Focus()
        Else
            Me.ModoModificacion()
            id = ObtenerCampo(Me.dgv_1, 0)
            txt_historias.Text = ObtenerCampo(Me.dgv_1, 1)


            PictureBox1.Image = dgv_1.CurrentRow.Cells("foto").FormattedValue
            'btnnuevo.Enabled = False
            ' txtNombre.Focus()
            'Label6.Text = DGV1.CurrentRow.Index + 1
            'ini = dgv1.CurrentRow.Index

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
    Sub ModoModificacion()
        btn_agregar.Enabled = False
        btn_eliminar.Enabled = True
        btn_modificar.Enabled = True
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub dgv_1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_1.CellContentClick

    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Try
            btn_agregar.Enabled = True
            btn_nuevo.Enabled = False
            '  PictureBox1.Image = Nothing
            PictureBox1.Image = Drawing.Image.FromFile(ruta_imagen)
            LimpiarCampos()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
End Class