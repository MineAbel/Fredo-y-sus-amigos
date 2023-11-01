Imports System.Data.OleDb

Public Class usuario_log



    Dim obj_usuario As New cls_usuarios_programa
    Dim modifico As Boolean
    'TODAS LAS CLASES COMIENZAN CON CLS

    Dim n As Integer











    Dim ini As Integer
    Dim f As Integer
    Dim id As Integer

    Private Sub frm_usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ini = 0
        ActualizarTabla(Me.DGV1, "usuario_programa", "", "Usuario")
        pinta_fila(ini)


        DGV1.Columns("Contraseña").Visible = False

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
            txt_usuario.Text = ObtenerCampo(Me.DGV1, 1)
            txt_pass.Text = ObtenerCampo(Me.DGV1, 2)
            ComboBox1.Text = ObtenerCampo(Me.DGV1, 3)


            PictureBox1.Image = DGV1.CurrentRow.Cells("foto").FormattedValue
            btnnuevo.Enabled = False
            ' txtNombre.Focus()
            'Label6.Text = DGV1.CurrentRow.Index + 1
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

        txt_usuario.Enabled = True
        txt_pass.Enabled = True
        txt_pass2.Enabled = True
        ComboBox1.Enabled = True

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
    Sub LimpiarCampos()
        txt_usuario.Text = ""
        txt_pass.Text = ""
        txt_pass2.Text = ""
        ComboBox1.Text = ""

        txt_usuario.Focus()
    End Sub
    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Try
            If ValidarDatos() Then
                '  obj_usuario.AgregaUsuario()



                If obj_usuario.AgregaUsuario(txt_usuario.Text, txt_pass.Text, ComboBox1.Text) = True Then

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


        If txt_usuario.Text.Trim = "" Then
            MsgBox("error en el usuario...")
            txt_usuario.Focus()
            Return False
            Exit Function
        End If

        If txt_pass.Text.Trim = "" Then
            MsgBox("error en la contraseña, agregar contraseña")
            txt_usuario.Focus()
            Return False
            Exit Function
        End If

        If txt_pass2.Text.Trim = "" Then
            MsgBox("error en la contraseña, agregar contraseña")
            txt_usuario.Focus()
            Return False
            Exit Function
        End If

        If ComboBox1.Text.Trim = "" Then
            MsgBox("error en el tipo, agregar tipo")
            txt_usuario.Focus()
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

    Private Sub txt_pass2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_pass.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If
    End Sub
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        txt_pass.Enabled = False
        txt_usuario.Enabled = False
        ComboBox1.Enabled = False


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
                    If obj_usuario.Modificausuario(txt_pass.Text, id, ComboBox1.Text) = True Then
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
    Private Sub btnfin_Click(sender As Object, e As EventArgs) Handles btnfin.Click
        muestra()
        Me.Close()
    End Sub

End Class