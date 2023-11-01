Imports System.Data.OleDb
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class alimentos
    Private Sub alimentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carga_datos()
    End Sub
    Sub carga_datos()
        Dim SQL As String
        '                         0                   1
        SQL = "SELECT Categorías.NombreCategoría
FROM Categorías
ORDER BY Categorías.NombreCategoría;

"

        Dim da As New OleDbDataAdapter(SQL, RutaDB_product)
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim SQL As String
        Dim dato As String


        dato = ComboBox1.Text


        '                         0                   1
        SQL = "SELECT Productos.IdProducto as Código, Productos.NombreProducto as Descripción, Productos.PrecioUnidad as Precio, Proveedores.NombreCompañía as Proveedor
FROM Proveedores INNER JOIN (Categorías INNER JOIN Productos ON Categorías.IdCategoría = Productos.IdCategoría) ON Proveedores.IdProveedor = Productos.IdProveedor
WHERE (((Categorías.NombreCategoría)='" & dato & "'))
ORDER BY Productos.IdProducto;"




        Dim da As New OleDbDataAdapter(SQL, RutaDB_product)
        Dim dt As New DataTable

        da.Fill(dt)

        dgv_productos.DataSource = dt

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
            Dim datatable As New PdfPTable(dgv_productos.ColumnCount)
            'Se asignan algunas propiedades para el diseño del PDF.
            datatable.DefaultCell.Padding = 3
            Dim headerwidths As Single() = GetColumnasSize(dgv_productos)
            datatable.SetWidths(headerwidths)
            datatable.WidthPercentage = 100
            datatable.DefaultCell.BorderWidth = 2
            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT


            'Se crea el encabezado en el PDF.
            Dim encabezado As New Paragraph("Listado de productos por categoria: ", New iTextSharp.text.Font(Font.Name = "Tahoma", 20, Font.Bold))

            Dim texto1 As New Paragraph(ComboBox1.Text, New iTextSharp.text.Font(Font.Name = "Tahoma", 14, Font.Bold))

            'Se crea el texto abajo del encabezado.
            Dim texto As New Phrase("Ejemplo de: datos exportados a  pdf " + " - " + Now.Date(), New iTextSharp.text.Font(Font.Name = "Tahoma", 14, Font.Bold))

            'Se capturan los nombres de las columnas del DataGridView.
            For i As Integer = 0 To dgv_productos.ColumnCount - 1
                datatable.AddCell(dgv_productos.Columns(i).HeaderText)
            Next
            datatable.HeaderRows = 1
            datatable.DefaultCell.BorderWidth = 1

            'Se generan las columnas del DataGridView.
            For i As Integer = 0 To dgv_productos.RowCount - 2
                For j As Integer = 0 To dgv_productos.ColumnCount - 1

                    If j = 2 Then
                        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_RIGHT
                        datatable.AddCell(Math.Round(CDbl(dgv_productos(j, i).Value.ToString()), 0))



                    Else
                        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT
                        datatable.AddCell(dgv_productos(j, i).Value.ToString())


                    End If



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
        Me.Close()
    End Sub

    Private Sub dgv_productos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_productos.CellContentClick

    End Sub
End Class