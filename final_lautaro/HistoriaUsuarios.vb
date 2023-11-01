Imports System.Data.OleDb

Public Class HistoriaUsuarios

    Dim toco_foto As Boolean = False
    Dim ruta_imagen As String = My.Application.Info.DirectoryPath & "\fotos\usuario.png"

    Dim obj_usuario As New cls_usuarios
    Dim modifico As Boolean
    'TODAS LAS CLASES COMIENZAN CON CLS

    Dim n As Integer
    Dim ini As Integer
    Dim f As Integer
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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub HistoriaUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ini = 0
        ActualizarTabla(Me.DGV1, "historias", "", "texto")
        pinta_fila(ini)

        'DGV1.Columns("fecha_creacion").DefaultCellStyle.Format = "dd/MM/yyyy"
        'DGV1.Columns("fecha_creacion").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV1.Columns("foto").Visible = False
        'DGV1.Columns("contraseña").Visible = False

        Label1.Text = "1"
        Label2.Text = n
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
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click



        Try

            If Val(Label1.Text) - 1 = 0 Then
                pinta_fila(0)
            ElseIf Val(Label1.Text) > 0 Then
                f = f - 1
                pinta_fila(f)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Val(Label1.Text) < DGV1.Rows.Count - 1 Then
            f = f + 1
            pinta_fila(f)
        Else
            pinta_fila(DGV1.Rows.Count - 1)
        End If
    End Sub

    Private Sub DGV1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellContentClick

    End Sub

    Private Sub DGV1_SelectionChanged(sender As Object, e As EventArgs) Handles DGV1.SelectionChanged
        Try

            If DGV1.SelectedCells.Count <> 0 Then

                Dim NFila As Integer = DGV1.SelectedCells(0).RowIndex

                'Con el N de Fila, me posiciono y recupero la Columna 'CodArt'
                Dim CodArt As String = DGV1.Rows(NFila).DataBoundItem("id").ToString

                id = DGV1.Rows(NFila).DataBoundItem("id").ToString
                RTB1.Text = DGV1.Rows(NFila).DataBoundItem("texto").ToString

                PictureBox1.Image = DGV1.Rows(NFila).Cells("foto").FormattedValue
                ini = DGV1.CurrentRow.Index
                Label1.Text = DGV1.SelectedCells(0).RowIndex + 1
                'Label6.Text = f + 1
                f = NFila


            End If

        Catch ex As Exception


            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RTB1.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Carga_formulario(Menu1)


        Me.Close()


    End Sub

    Private Sub txt_historia_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class