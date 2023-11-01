﻿Imports System.Data.OleDb
Imports GMap.NET
Imports GMap.NET.MapProviders

Public Class consulta_mundo
    Private Sub consulta_mundo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carga_datos()

    End Sub
    Sub carga_datos()
        Dim SQL As String
        '                         0                   1
        SQL = "SELECT Countries.Country, Countries.Capital FROM Countries order by Countries.Country"

        Dim da As New OleDbDataAdapter(SQL, RutaDB_mundo)
        Dim dt As New DataTable

        da.Fill(dt)

        ListBox1.Items.Clear()

        For i = 0 To dt.Rows.Count - 1
            Dim dr As DataRow 'dr datarow
            dr = dt.Rows(i)
            ListBox1.Items.Add(dr(0) & " - " & dr(1))
            ' ComboBox1.Items.Add(dr(0)) 'CARGA LOS PAISES EN EL COMBO
        Next

        Carga_paises()


    End Sub
    Private Sub Carga_paises()
        Dim continente As String
        Dim sql As String

        continente = "South America"

        sql = "Select  Countries.Country, Countries.MapReference " _
        + "From Countries " _
        + "Where (((Countries.MapReference) ='" & continente & "')) " _
        + "Order By Countries.Country;"

        Dim da As New OleDbDataAdapter(sql, RutaDB_mundo)
        Dim dt As New DataTable
        da.Fill(dt)
        ComboBox1.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim dr As DataRow 'dr datarow
            dr = dt.Rows(i)
            ComboBox1.Items.Add(dr(0))
        Next

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim SQL As String
        Dim DATO As String

        DATO = TextBox1.Text & "%"  '%comodin
        '                   0                  1
        SQL = "Select Countries.Country, Countries.Capital " _
        + "FROM Countries " _
        + "WHERE Countries.Country Like '" & DATO & "' " _
        + "ORDER BY Countries.Country;"

        Dim da As New OleDbDataAdapter(SQL, RutaDB_mundo)
        Dim dt As New DataTable
        da.Fill(dt)
        ListBox1.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim dr As DataRow
            dr = dt.Rows(i)
            ListBox1.Items.Add(UCase(dr(0)) & " - " & dr(1))
            'ucase()   Mayusculas...
        Next

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim SQL As String
        SQL = "Select Countries.Country, Cities.City " _
+ "From Countries INNER Join Cities On Countries.CountryId = Cities.CountryId " _
+ "Where Countries.Country = '" & ComboBox1.Text & "' " _
+ "Order By Cities.City;"

        Dim da As New OleDbDataAdapter(SQL, RutaDB_mundo)
        Dim dt As New DataTable
        da.Fill(dt)
        ListBox2.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim dr As DataRow
            dr = dt.Rows(i)
            ListBox2.Items.Add(UCase(dr(1)))
            'ucase()   Mayusculas...
        Next

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        Dim sql As String
        '                 0                   1              2                3
        sql = "Select Countries.Country, Cities.City, Cities.Latitude, Cities.Longitude " _
        + "From Countries INNER Join Cities On Countries.CountryId = Cities.CountryId " _
        + "Where (((Countries.Country) = '" & ComboBox1.Text & "') And ((Cities.City) = '" & ListBox2.SelectedItem & "'));"

        Dim da As New OleDbDataAdapter(sql, RutaDB_mundo)
        Dim dt As New DataTable
        da.Fill(dt)

        Dim dr As DataRow 'dr datarow
        dr = dt.Rows(0)
        Label7.Text = dr(2) 'latitud
        Label5.Text = dr(3) 'longitud

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim latitud As Double = Val(Label7.Text)
        Dim longitud As Double = Val(Label5.Text)

        GMapControl1.DragButton = Windows.Forms.MouseButtons.Left
        GMapControl1.CanDragMap = True
        GMapControl1.MapProvider = GMapProviders.GoogleMap
        GMapControl1.Position = New PointLatLng(latitud, longitud)
        GMapControl1.MinZoom = 0
        GMapControl1.MaxZoom = 24
        GMapControl1.Zoom = 9
        GMapControl1.AutoScroll = True


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class