Imports System.Data.OleDb
Imports System.Drawing.Printing
Imports System.IO


Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class frm_pdf
    Private Sub frm_pdf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carga_datos()
    End Sub

    Sub carga_datos()
        Dim SQL As String
        '                         0                   1
        SQL = "SELECT CURSOS.NOMBRE FROM CURSOS ORDER BY CURSOS.NOMBRE;
"

        Dim da As New OleDbDataAdapter(SQL, RutaDB_pdf)
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_alumnos.CellContentClick

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim SQL As String
        Dim dato As String


        dato = ComboBox1.Text


        '                         0                   1
        SQL = "SELECT CURSOS.NOMBRE, ALUMNOS.NOMBRE, ALUMNOS.APELLIDO, ALUMNOS.EMAIL, ALUMNOS.CEDULA
FROM CURSOS INNER JOIN ALUMNOS ON CURSOS.CODIGO_CURSO = ALUMNOS.CODIGO_CURSO
WHERE (((CURSOS.NOMBRE)='" & dato & "'))
ORDER BY ALUMNOS.NOMBRE;

"

        Dim da As New OleDbDataAdapter(SQL, RutaDB_pdf)
        Dim dt As New DataTable

        da.Fill(dt)

        dgv_alumnos.DataSource = dt
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'Intentar generar el documento.
            Dim doc As New Document(PageSize.A4, 10, 10, 10, 10)
            Dim filename As String ' = My.Application.Info.DirectoryPath + "\datos.pdf"
            Dim ruta As String


            FolderBrowserDialog1.ShowDialog()
            ruta = FolderBrowserDialog1.SelectedPath()
            filename = ruta + "\datos.pdf"
            Dim f As String = Format(Now.Date, "dd-MM-yy")
            'filename = ruta + "\" + ComboBox1.Text + "-" + f + ".pdf"

            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            Dim pdfwrite As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite))

            'PdfWriter.GetInstance(doc, file)
            doc.Open()
            ExportarDatosPDF(doc)
            doc.Close()

            MsgBox("Terminó todo bien...!!")

            Shell("rundll32.exe url.dll,FileProtocolHandler " & (filename))



        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox.
            MessageBox.Show("No se puede generar el documento PDF.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub ExportarDatosPDF(ByVal document As Document)
        Try

            'Se crea un objeto PDFTable con el numero de columnas del DataGridView.
            Dim datatable As New PdfPTable(dgv_alumnos.ColumnCount)
            'Se asignan algunas propiedades para el diseño del PDF.
            datatable.DefaultCell.Padding = 3
            Dim headerwidths As Single() = GetColumnasSize(dgv_alumnos)
            datatable.SetWidths(headerwidths)
            datatable.WidthPercentage = 100
            datatable.DefaultCell.BorderWidth = 2
            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
            'Se crea el encabezado en el PDF.
            Dim encabezado As New Paragraph("Listado de alumnos del curso de: ", New iTextSharp.text.Font(Font.Name = "Tahoma", 20, Font.Bold))

            Dim texto1 As New Paragraph(ComboBox1.Text, New iTextSharp.text.Font(Font.Name = "Tahoma", 14, Font.Bold))

            'Se crea el texto abajo del encabezado.
            Dim texto As New Phrase("Ejemplo de: datos exportados a  pdf " + " - " + Now.Date(), New iTextSharp.text.Font(Font.Name = "Tahoma", 14, Font.Bold))

            'Se capturan los nombres de las columnas del DataGridView.
            For i As Integer = 0 To dgv_alumnos.ColumnCount - 1
                datatable.AddCell(dgv_alumnos.Columns(i).HeaderText)
            Next
            datatable.HeaderRows = 1
            datatable.DefaultCell.BorderWidth = 1

            'Se generan las columnas del DataGridView.
            For i As Integer = 0 To dgv_alumnos.RowCount - 2
                For j As Integer = 0 To dgv_alumnos.ColumnCount - 1
                    datatable.AddCell(dgv_alumnos(j, i).Value.ToString())
                Next
                datatable.CompleteRow()
            Next
            'Se agrega el PDFTable al documento.

            document.Add(encabezado)
            document.Add(texto1)
            document.Add(texto)
            document.Add(datatable)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Sub

    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim v_imagen As String = "C:\Users\LAUTARO CARDOZO\source\repos\mi primer proyecto\mi primer proyecto\bin\Debug\fotos\jose.jpg"
        Dim v_archivo As String = "C:\Users\LAUTARO CARDOZO\source\repos\mi primer proyecto\mi primer proyecto\bin\Debug\fotos\archivo.pdf"

        Try
            Using crea_archi = New iTextSharp.text.Document
                iTextSharp.text.pdf.PdfWriter.GetInstance(crea_archi, New FileStream(v_archivo, FileMode.Create))
                crea_archi.Open()
                Dim image As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(v_imagen)

                Dim texto As New Phrase("Ejemplo de imagen a  pdf " + " - " + Now.Date(), New iTextSharp.text.Font(Font.Name = "Tahoma", 14, Font.Bold))

                Dim text1 As iTextSharp.text.Phrase = texto

                crea_archi.Add(image)
                crea_archi.Add(text1)

                MessageBox.Show("imagen exportada con éxito a la carpeta descarga..")
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class