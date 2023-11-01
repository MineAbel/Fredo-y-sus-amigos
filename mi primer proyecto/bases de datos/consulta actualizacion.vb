Imports System.Data.OleDb
Imports System.Drawing.Printing

Public Class consulta_actualizacion

    Dim paso As Boolean = False
    Dim esPreview As Boolean
    Private prtFont As System.Drawing.Font
    Private prtSettings As PrinterSettings
    Private prtDoc As PrintDocument
    Private lineaActual As Integer
    Dim linea As Integer = 0

    Private da As OleDbDataAdapter
    Private da1 As OleDbDataAdapter

    Private dt As DataTable
    Private dt1 As DataTable

    Private sql As String
    Dim id() As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
         'incrementa precios de los productos de una determinada  categoria.

        Dim aumento1 As Double

        Try
            '          1 + (10/100) = 1.1
            aumento1 = 1 + NumericUpDown1.Value / 100

            If ComboBox1.Text <> "Todos" Then

                'sql = "UPDATE Categorías INNER JOIN Productos ON Categorías.IdCategoría " _
                '    + "= Productos.IdCategoría Set Productos.PrecioUnidad = [Productos]![PrecioUnidad] " _
                '+ "*" & aumento1 & " WHERE (((Categorías.NombreCategoría)='” & ComboBox1.Text & ”'));”

                sql = "Update Categorías INNER JOIN Productos ON Categorías.IdCategoría = Productos.IdCategoría SET Productos.PrecioUnidad = [Productos]![PrecioUnidad]*" & aumento1 & "
WHERE(((Categorías.NombreCategoría) = '” & ComboBox1.Text & ”'))"



            Else
                sql = "UPDATE Productos SET PrecioUnidad = Productos.PrecioUnidad*" & aumento1 & ""

            End If

            Dim cs1 As New OleDbConnection(RutaDB_product)
            Dim cmdUpdate As New OleDbCommand(sql, cs1)
            cmdUpdate.Connection.Open()
            MsgBox("Actualizacion completa. Filas Afectadas ." & cmdUpdate.ExecuteNonQuery())

            carga_grilla()

        Catch ex As InvalidOperationException
            MsgBox("Error: {0" & ex.Message)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
          Dim dto As Double

        Try

            ' dto = (100 + NumericUpDown1.Value) / 100

            dto = 1 - (NumericUpDown1.Value) / 100

            If ComboBox1.Text <> "Todos" Then
                'UPDATE Categorías INNER JOIN Productos ON Categorías.IdCategoría = Productos.IdCategoría SET Productos.PrecioUnidad = [Productos]![PrecioUnidad]/1.1
                'WHERE (((Categorías.NombreCategoría)="bebidas"));

                sql = "UPDATE Productos SET PrecioUnidad = Productos.PrecioUnidad * " & dto & " " _
                + "WHERE IdCategoría=" & id(ComboBox1.SelectedIndex.ToString) & ";"
            Else
                sql = "UPDATE Productos SET PrecioUnidad = Productos.PrecioUnidad * " & dto & ""

            End If


            Dim cs1 As New OleDbConnection(RutaDB_product)

            Dim cmdUpdate As New OleDbCommand(sql, cs1)
            cmdUpdate.Connection.Open()
            MsgBox("Actualización completa. Filas Afectadas ." & cmdUpdate.ExecuteNonQuery())


            carga_grilla()

        Catch ex As InvalidOperationException
            MsgBox("Error: {0" & ex.Message)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub consulta_actualizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim sql As String = "SELECT * " _
            + "FROM Categorías " _
            + "ORDER BY NombreCategoría;"

            da = New OleDbDataAdapter(sql, RutaDB_product)
            dt = New DataTable
            da.Fill(dt)
            Dim dr As DataRow

            Dim i As Integer
            ReDim id(dt.Rows.Count - 1)

            For i = 0 To dt.Rows.Count - 1
                dr = dt.Rows(i)
                ComboBox1.Items.Add(dr("NombreCategoría").ToString)
                id(i) = dr("IdCategoría").ToString
            Next

            ComboBox1.Items.Add("Todos")


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub carga_grilla()


        '  Dim font As New Font(DataGridView1.DefaultCellStyle.Font.FontFamily, 10, FontStyle.Bold)

        Try

            If ComboBox1.Text <> "Todos" Then
                sql = "SELECT Productos.IdProducto, Productos.NombreProducto, Productos.PrecioUnidad, Proveedores.NombreCompañía " _
                        + "FROM Proveedores INNER JOIN (Categorías INNER JOIN Productos ON Categorías.IdCategoría = Productos.IdCategoría) ON Proveedores.IdProveedor = Productos.IdProveedor " _
                        + "WHERE Categorías.NombreCategoría='" & ComboBox1.Text & "';"
            Else
                sql = "SELECT  Productos.NombreProducto, Productos.PrecioUnidad " _
                        + "FROM Proveedores INNER JOIN Productos ON Proveedores.IdProveedor = Productos.IdProveedor;"
            End If


            '            sql = "Select  Productos.IdProducto As Código, Productos.NombreProducto As Descripción, Productos.PrecioUnidad, Proveedores.NombreCompañía
            'From Categorías INNER Join (Proveedores INNER Join Productos On Proveedores.IdProveedor = Productos.IdProveedor) ON Categorías.IdCategoría = Productos.IdCategoría
            'Where (((Categorías.NombreCategoría) = "bebidas"))
            'Order By Productos.NombreProducto;"



            da = New OleDbDataAdapter(sql, RutaDB_product)
            dt = New DataTable
            da.Fill(dt)


            With dgv_productos
                .MultiSelect = False
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .DataSource = dt
                .Columns("IdProducto").HeaderText = "Código"
                .Columns("NombreProducto").HeaderText = "Descripción"
                .Columns("PrecioUnidad").HeaderText = "Precio"
                .Columns("NombreCompañía").HeaderText = "Proveedor"
                .Columns("PrecioUnidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns("PrecioUnidad").DefaultCellStyle.Format = "$##,##0.00"
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
                .GridColor = Color.GreenYellow
                .DefaultCellStyle.BackColor = Color.LightSteelBlue
                '  .Columns("PrecioUnidad").DefaultCellStyle.Font = font

            End With



            'Try
            '    DataGridView1.Columns("Costo").DefaultCellStyle.Font = font
            '    'DataGridView1.Columns("costo").DefaultCellStyle.Format = "c"

            'Finally
            '    font.Dispose()
            'End Try

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        carga_grilla()
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged

    End Sub
End Class