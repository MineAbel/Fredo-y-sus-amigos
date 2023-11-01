Imports System.Data.OleDb

Public Class CuestionarioAdmin
    Dim n As Integer
    Dim modifico As Boolean
    Dim obj_pyr As New cls_preguntas_respuestas
    Dim ini As Integer
    Dim f As Integer
    Dim id As Integer

    Private Sub CuestionarioAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ini = 0
        ActualizarTabla(Me.dgv_1, "cuestionario", "", "id")
        'Label6.Text = "1"
        'Label9.Text = n
        pinta_fila(ini)

        'dgv1.Columns("fecha_creacion").DefaultCellStyle.Format = "dd/MM/yyyy"
        'dgv1.Columns("fecha_creacion").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dgv1.Columns("foto").Visible = False

    End Sub
    Private Function Carga_formulario(ByVal form As Form) As Boolean
        'Chequeo si ya está abierto.
        For Each f As Form In Application.OpenForms
            'Si está abierto devuelvo False (no se puede abrir).
            If f.Name = form.Name Then
                form.Select()
                Return False
            End If
        Next
        'Si se llega a este punto es porque no está abierto.
        'Abro el formulario.

        form.Show()

        'Indico apertura exitosa.
        Return True
    End Function
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

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Try
            btn_cancelar.Enabled = True
            btn_agregar.Enabled = True
            btn_nuevo.Enabled = False
            btn_modificar.Enabled = False
            btn_eliminar.Enabled = False

            txt_preguntas.Enabled = True
            txt_respuesta_1.Enabled = True
            txt_respuesta_2.Enabled = True
            txt_respuesta_3.Enabled = True
            txt_respuesta_4.Enabled = True
            txt_respuesta_c.Enabled = True

            dgv_1.Enabled = False

            '  PictureBox1.Image = Nothing
            'PictureBox1.Image = Drawing.Image.FromFile(ruta_imagen)
            LimpiarCampos()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Sub LimpiarCampos()
        txt_preguntas.Text = ""
        txt_respuesta_1.Text = ""
        txt_respuesta_2.Text = ""
        txt_respuesta_3.Text = ""
        txt_respuesta_4.Text = ""
        txt_respuesta_c.Text = ""
        txt_preguntas.Focus()
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Try
            If ValidarDatos() Then
                '  obj_usuario.AgregaUsuario()

                If obj_pyr.AgregaPreguntas(txt_preguntas.Text, txt_respuesta_1.Text, txt_respuesta_2.Text, txt_respuesta_3.Text, txt_respuesta_4.Text, txt_respuesta_c.Text) = True Then

                    MsgBox("Registro ingresado satisfactoriamente", MsgBoxStyle.Information, "Confirmacion")
                    Me.LimpiarCampos()
                    ActualizarTabla(Me.dgv_1, "cuestionario", "", "id")

                Else
                    MsgBox("Error al ingresar el registro, reintente la accion", MsgBoxStyle.Critical, "Error")
                End If

            End If

            'PictureBox1.Image = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de Validación de datos")
        End Try
        Me.ModoInsercion()

    End Sub
    Function ValidarDatos() As Boolean

        If txt_preguntas.Text.Trim = "" Then
            MsgBox("Se debe agregar una pregunta...")
            txt_preguntas.Focus()
            Return False
            Exit Function
        End If

        If txt_respuesta_1.Text.Trim = "" Then
            MsgBox("Se debe agregar al menos 4 respuestas...")
            txt_respuesta_1.Focus()
            Return False
            Exit Function
        End If

        If txt_respuesta_2.Text.Trim = "" Then
            MsgBox("Se debe agregar al menos 4 respuestas...")
            txt_respuesta_2.Focus()
            Return False
            Exit Function
        End If

        If txt_respuesta_3.Text.Trim = "" Then
            MsgBox("Se debe agregar al menos 4 respuestas...")
            txt_respuesta_3.Focus()
            Return False
            Exit Function
        End If

        If txt_respuesta_4.Text.Trim = "" Then
            MsgBox("Se debe agregar al menos 4 respuestas...")
            txt_respuesta_4.Focus()
            Return False
            Exit Function
        End If

        If txt_respuesta_c.Text.Trim = "" Then
            MsgBox("Se debe agregar una respuesta correcta...")
            txt_respuesta_c.Focus()
            Return False
            Exit Function
        End If

        Return True

    End Function
    Sub ModoInsercion()
        btn_eliminar.Enabled = False
        btn_modificar.Enabled = False
        btn_agregar.Enabled = True
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

    Private Sub btn_fin_Click(sender As Object, e As EventArgs) Handles btn_fin.Click

        Carga_formulario(Menu1)

        Me.Close()

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim i = MsgBox("¿Desea eliminar este usuario?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Confirmación")
        If i = MsgBoxResult.Yes Then
            Try

                If obj_pyr.EliminaPregunta(id) = True Then
                    MsgBox("Registro Eliminado satisfactoriamente", MsgBoxStyle.Information, "Confirmacion")
                    Me.LimpiarCampos()
                    ActualizarTabla(Me.dgv_1, "cuestionario", "", "id")
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

        btn_agregar.Enabled = False

    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        Try
            modifico = True

            btn_nuevo.Enabled = True
            btn_agregar.Enabled = False
            Dim i = MsgBox("¿Desea modificar ese registro?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Confirmación")

            If i = MsgBoxResult.Yes Then

                If ValidarDatos() Then
                    If obj_pyr.Modificapregunta(txt_preguntas.Text, txt_respuesta_1.Text, txt_respuesta_2.Text, txt_respuesta_3.Text, txt_respuesta_4.Text, txt_respuesta_c.Text, id) = True Then
                        MsgBox("Registro actualizado satisfactoriamente", MsgBoxStyle.Information, "Confirmacion")
                        Me.LimpiarCampos()
                        ActualizarTabla(Me.dgv_1, "cuestionario", "", "id")
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

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Try
            btn_cancelar.Enabled = False
            btn_agregar.Enabled = False
            btn_nuevo.Enabled = True
            btn_modificar.Enabled = True
            btn_eliminar.Enabled = True

            txt_preguntas.Enabled = False
            txt_respuesta_1.Enabled = False
            txt_respuesta_2.Enabled = False
            txt_respuesta_3.Enabled = False
            txt_respuesta_4.Enabled = False
            txt_respuesta_c.Enabled = False

            dgv_1.Enabled = True

            '  PictureBox1.Image = Nothing
            'PictureBox1.Image = Drawing.Image.FromFile(ruta_imagen)
            LimpiarCampos()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub dgv_1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_1.CellContentClick

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
        btn_cancelar.Enabled = True
    End Sub

    Private Sub dgv_1_MouseClick(sender As Object, e As MouseEventArgs) Handles dgv_1.MouseClick


        If dgv_1.SelectedRows.Count = 0 Then
            MsgBox("Debe seleccionar un usuario para poder editarlo", MsgBoxStyle.Critical, "Error")
            dgv_1.Focus()
        Else
            Me.ModoModificacion()



            txt_preguntas.Text = ObtenerCampo(Me.dgv_1, 1)
            txt_respuesta_1.Text = ObtenerCampo(Me.dgv_1, 2)
            txt_respuesta_2.Text = ObtenerCampo(Me.dgv_1, 3)
            txt_respuesta_3.Text = ObtenerCampo(Me.dgv_1, 4)
            txt_respuesta_4.Text = ObtenerCampo(Me.dgv_1, 5)
            txt_respuesta_c.Text = ObtenerCampo(Me.dgv_1, 6)
            id = ObtenerCampo(Me.dgv_1, 0)

            txt_preguntas.Enabled = True
            txt_respuesta_1.Enabled = True
            txt_respuesta_2.Enabled = True
            txt_respuesta_3.Enabled = True
            txt_respuesta_4.Enabled = True
            txt_respuesta_c.Enabled = True


            btn_nuevo.Enabled = False
            btn_cancelar.Enabled = False
            btn_eliminar.Enabled = True
            btn_modificar.Enabled = True
            ' txtNombre.Focus()
            'Label6.Text = DGV1.CurrentRow.Index + 1
            'ini = dgv1.CurrentRow.Index

        End If
    End Sub
End Class