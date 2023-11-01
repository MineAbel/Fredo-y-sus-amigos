Imports System.Data.OleDb

Public Class Cuestionario
    Dim obj_pyv As New CuestionarioUsuario
    Dim modifico As Boolean
    'TODAS LAS CLASES COMIENZAN CON CLS
    Dim yo As Integer
    Dim con = 1
    Dim n As Integer
    Dim ini As Integer
    Dim f As Integer
    Dim puntaje As Integer

    Dim id As Integer

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



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Carga_formulario(Menu1)


        Me.Close()

    End Sub

    Private Sub Cuestionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ini = 0
        ActualizarTabla(Me.DGV_1, "Cuestionario", "", "id")

        pinta_fila(ini)

        ' ActualizarTabla(Me.dgv2, "Cuestionario", "", "id")

        'DGV1.Columns("fecha_creacion").DefaultCellStyle.Format = "dd/MM/yyyy"
        'DGV1.Columns("fecha_creacion").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'DGV1.Columns("contraseña").Visible = False

        Label2.Text = "1"
        Label4.Text = n
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

    Sub carga_datos()
        Dim SQL As String
        '                         0                   1
        '  SQL = "SELECT Categorías.NombreCategoría
        '  FROM Categorías
        '  ORDER BY Categorías.NombreCategoría;
        '   "


        'SQL = "SELECT Cuestionario.r1, Cuestionario.r2, Cuestionario.r3, Cuestionario.r4
        '      From Cuestionario
        '      Where (((Cuestionario.Preguntas) Like "¿De que color son los simpsons?"));"

        SQL = " Select Cuestionario.Preguntas, Cuestionario.r1, Cuestionario.r2, Cuestionario.r3, Cuestionario.r4 From Cuestionario Where (((Cuestionario.Id) = 1));"


        Dim da As New OleDbDataAdapter(SQL, RutaDB_final)
        Dim dt As New DataTable

        da.Fill(dt)

        ListBox1.Items.Clear()
        Dim dr As DataRow 'dr datarow
        dr = dt.Rows(0)
        Label6.Text = dr(0)
        For i = 0 To 3 ' dt.Rows.Count - 1

            ListBox1.Items.Add(dr(i + 1))

            ' ComboBox1.Items.Add(dr(0)) 'CARGA LOS PAISES EN EL COMBO
        Next



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_siguiente.Click

        If ListBox1.SelectedIndex = -1 Then

            MessageBox.Show("Debes elegir una opcion")
            yo = False
            Exit Sub

        Else
            yo = True
        End If


        If yo = True Then
            If Label2.Text = 6 Then
                btn_siguiente.Text = "Finalizo!!!"

                btn_puntaje.Visible = True
                btn_reiniciar.Visible = True

                btn_siguiente.Enabled = False
                ListBox1.Enabled = False


                ' Exit Sub
            End If
            con = con + 1


        End If

        Try

            usu = "ana"
            'obj_usuario.AgregaHistorias()

            If ValidarDatos() Then
                If obj_pyv.AgregaRespuesta(usu, id.ToString, Label9.Text, Label7.Text) = True Then

                    If Label9.Text = Label7.Text Then
                        puntaje += 1
                    End If


                    If Val(Label2.Text) < DGV_1.Rows.Count - 1 Then
                        f = f + 1
                        pinta_fila(f)
                    Else

                        'Label10.Visible = True
                        'lbl_puntos.Visible = True
                        'lbl_puntos.Text = puntaje

                        Exit Sub
                        '  pinta_fila(DGV_1.Rows.Count - 1)
                    End If


                Else
                    MsgBox("Error al ingresar el registro, reintente la accion", MsgBoxStyle.Critical, "Error")
                    Exit Sub

                End If

            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de Validación de datos")
        End Try


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Label9.Text = ListBox1.Text

    End Sub

    Sub pinta_fila(ByVal nn As Integer)

        Try

            For i As Integer = 0 To DGV_1.Rows.Count - 1
                DGV_1.Rows(i).Selected = False
            Next

            DGV_1.Rows(nn).Selected = True

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Function ValidarDatos() As Boolean

        If Label9.Text = "" Then
            'MsgBox("error en el nombre...")
            ListBox1.Focus()
            Return False
            Exit Function
        End If

        'If ListBox1.SelectedItem.Trim = False Then

        '    ListBox1.Focus()
        '    Return False
        '    Exit Function
        'End If
        Return True


    End Function

    Private Sub DGV_1_SelectionChanged(sender As Object, e As EventArgs) Handles DGV_1.SelectionChanged


        Try

            If DGV_1.SelectedCells.Count <> 0 Then

                Dim NFila As Integer = DGV_1.SelectedCells(0).RowIndex

                'Con el N de Fila, me posiciono y recupero la Columna 'CodArt'
                Dim CodArt As String = DGV_1.Rows(NFila).DataBoundItem("id").ToString

                id = DGV_1.Rows(NFila).DataBoundItem("id").ToString
                Label6.Text = DGV_1.Rows(NFila).DataBoundItem("preguntas").ToString
                ListBox1.Items.Clear()
                ListBox1.Items.Add(DGV_1.Rows(NFila).DataBoundItem("r1").ToString)
                ListBox1.Items.Add(DGV_1.Rows(NFila).DataBoundItem("r2").ToString)
                ListBox1.Items.Add(DGV_1.Rows(NFila).DataBoundItem("r3").ToString)
                ListBox1.Items.Add(DGV_1.Rows(NFila).DataBoundItem("r4").ToString)
                Label7.Text = DGV_1.Rows(NFila).DataBoundItem("rv").ToString


                ini = DGV_1.CurrentRow.Index
                Label2.Text = DGV_1.SelectedCells(0).RowIndex + 1
                'Label6.Text = f + 1
                f = NFila


            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
    Private Sub btn_puntaje_Click(sender As Object, e As EventArgs) Handles btn_puntaje.Click

        Label10.Visible = True
        lbl_puntos.Visible = True
        lbl_puntos.Text = puntaje

    End Sub

    Private Sub btn_reiniciar_Click(sender As Object, e As EventArgs) Handles btn_reiniciar.Click

        Label10.Visible = False
        lbl_puntos.Text = "0"
        lbl_puntos.Visible = False
        Label9.Text = ""


        'btn_siguiente.Text = "Siguiente"
        'btn_siguiente.Enabled = True
        'ListBox1.Enabled = True


    End Sub
End Class