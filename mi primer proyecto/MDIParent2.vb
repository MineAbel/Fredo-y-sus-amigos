Imports System.Windows.Forms

Public Class MDIParent2
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
        form.MdiParent = Me
        form.Show()

        'Indico apertura exitosa.
        Return True
    End Function



    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub MDIParent2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Carga_formulario(calcula)
    End Sub

    Private Sub FornextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FornextToolStripMenuItem.Click
        Carga_formulario(for_next)
    End Sub

    Private Sub JuegoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JuegoToolStripMenuItem.Click
        Carga_formulario(Form5)
    End Sub

    Private Sub SelectCaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectCaseToolStripMenuItem.Click
        Carga_formulario(select_case)
    End Sub

    Private Sub EjemploIfToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EjemploIfToolStripMenuItem.Click
        Carga_formulario(Form2)
    End Sub

    Private Sub LeftRightYMidToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeftRightYMidToolStripMenuItem.Click
        Carga_formulario(lef_right_y_mid)
    End Sub

    Private Sub CalculaIVAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculaIVAToolStripMenuItem.Click
        Carga_formulario(Form4)
    End Sub

    Private Sub ImporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImporteToolStripMenuItem.Click
        Carga_formulario(Form7)
    End Sub

    Private Sub SaludoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaludoToolStripMenuItem.Click
        Carga_formulario(Form1)
    End Sub

    Private Sub NumerosAleatoriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NumerosAleatoriosToolStripMenuItem.Click

    End Sub

    Private Sub EjemploIF2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EjemploIF2ToolStripMenuItem.Click
        Carga_formulario(Form3)
    End Sub

    Private Sub EjemploIF3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EjemploIF3ToolStripMenuItem.Click
        Carga_formulario(frm_ejemplo_if)
    End Sub

    Private Sub Juego2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Juego2ToolStripMenuItem.Click
        Carga_formulario(Form6)
    End Sub

    Private Sub CargaDeFormularioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargaDeFormularioToolStripMenuItem.Click
        Carga_formulario(form_primero)
    End Sub

    Private Sub ValidacionDeCedulaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ValidacionDeCedulaToolStripMenuItem.Click
        Carga_formulario(Validacion_de_Cedula)
    End Sub

    Private Sub PracticaValidaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PracticaValidaciónToolStripMenuItem.Click
        Carga_formulario(Form8)
    End Sub

    Private Sub ListViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListViewToolStripMenuItem.Click
        Carga_formulario(frm_listview)
    End Sub

    Private Sub ListView2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListView2ToolStripMenuItem.Click
        Carga_formulario(list_view2)
    End Sub

    Private Sub VisualizadorDeImagenesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisualizadorDeImagenesToolStripMenuItem.Click
        Carga_formulario(visualizador1)
    End Sub

    Private Sub MailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MailToolStripMenuItem.Click
        Carga_formulario(enviar_mail)
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Carga_formulario(frm_usuarios)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        oculta()
        Carga_formulario(calcula)



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        oculta
        Carga_formulario(for_next)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        oculta()
        Carga_formulario(Form5)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        oculta()
        Carga_formulario(Form6)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        oculta()
        Carga_formulario(select_case)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        oculta()
        Carga_formulario(Form2)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        oculta()
        Carga_formulario(Form3)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        oculta()
        Carga_formulario(frm_ejemplo_if)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        oculta()
        Carga_formulario(Numero_Aleatorios)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        oculta()
        Carga_formulario(lef_right_y_mid)

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        oculta()
        Carga_formulario(Form4)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        oculta()
        Carga_formulario(Form7)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        oculta()
        Carga_formulario(Form1)
    End Sub

    Private Sub button15_Click(sender As Object, e As EventArgs) Handles button15.Click
        oculta()
        Carga_formulario(form_primero)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        oculta()
        Carga_formulario(Validacion_de_Cedula)
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        oculta()
        Carga_formulario(Form8)
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        oculta()
        Carga_formulario(frm_listview)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        oculta()
        Carga_formulario(list_view2)
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        oculta()
        Carga_formulario(visualizador1)
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        oculta()
        Carga_formulario(enviar_mail)
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        oculta()
        Carga_formulario(frm_usuarios)
    End Sub


    Private Sub Button24_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button23_Click_1(sender As Object, e As EventArgs) Handles Button23.Click
        oculta()
        Carga_formulario(usuario_log)
    End Sub

    Private Sub Button24_Click_1(sender As Object, e As EventArgs) Handles Button24.Click
        oculta()
        Carga_formulario(consulta_mundo)
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        oculta()
        Carga_formulario(frm_pdf)
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        oculta()
        Carga_formulario(alimentos)
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        oculta()
        Carga_formulario(consulta_actualizacion)
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) 
        oculta()
    End Sub
End Class
