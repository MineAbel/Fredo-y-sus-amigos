Imports System.Data.OleDb
Imports System.IO
Imports System.Net.Mime.MediaTypeNames
Imports System.Runtime.CompilerServices

Public Class cls_historias
    Dim ComandoSql As OleDbCommand
    Dim Sql As String
    'structure query language
    'LENGUAJE ESTRUCTURADO DE CONSULTAS 
    Dim arrImage() As Byte
    Dim mstream As New System.IO.MemoryStream()
    Function AgregaHistorias(ByVal historias As String,
                           ByVal pic As PictureBox) As Boolean

        Try
            Dim con As New OleDbConnection(RutaDB_final) 'APUNTA A LA BASE DE DATOS..
            con.Open()

            Dim FileSize As UInt32
            If pic.ImageLocation = Nothing Then
                FileSize = 0
            Else
                FileSize = mstream.Length
            End If

            Try
                pic.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                arrImage = mstream.GetBuffer()
                FileSize = mstream.Length
                mstream.Close()
            Catch
                FileSize = 0
            End Try


            Sql = "Insert into historias (texto, foto) " _
                + "Values (@historias,@pic)"


            '"SELECT Historias.Texto, Historias.imagen FROM Historias;" _
            '+ "Values (@historias,@foto)"

            ComandoSql = New OleDbCommand
            With ComandoSql
                .Connection = con
                .CommandText = Sql
                .Parameters.AddWithValue("@historias", historias.ToUpper)
                .Parameters.AddWithValue("@pic", arrImage)

                .ExecuteNonQuery()
            End With

            ComandoSql.Dispose()
            Sql = String.Empty
            con.Close()
            Return True

        Catch exsql As OleDbException
            MsgBox(exsql.Message)
            Return False

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function
    Function ModificaHistorias(ByVal historias As String, ByVal foto As PictureBox, ByVal id As Integer) As Boolean


        Try
            Dim con As New OleDbConnection(RutaDB_final)
            Dim MS As New MemoryStream


            foto.Image.Save(MS, foto.Image.RawFormat)

            Dim Imagenes() As Byte = MS.GetBuffer

            con.Open()
            'TOUPPER  MAYUSCULAS  TOLOWER MINUSCULAS
            Sql = "UPDATE historias SET Texto = '" & historias.ToUpper & "', foto=@foto WHERE id =" & id

            '"SELECT Historias.Texto, Historias.imagen
            'From Historias;"


            ComandoSql = New OleDbCommand(Sql, con)

            ComandoSql.Parameters.AddWithValue("@foto", Imagenes)

            ComandoSql.ExecuteNonQuery() 'EJECUTA LOS CAMBIOS
            ComandoSql.Dispose() 'LIMPIA LA VARIABLE 
            Sql = String.Empty 'EMPTY  LIMPIA LA VARIABLE
            con.Close()
            Return True

        Catch exsql As OleDbException
            Return False

        Catch ex As Exception
            Return False
        End Try



    End Function
    Function EliminaHistorias(ByVal id As Integer) As Boolean
        Try
            Dim con As New OleDbConnection(RutaDB_final)
            con.Open()
            Sql = "DELETE * FROM historias WHERE id =" & id & ""
            ComandoSql = New OleDbCommand(Sql, con)
            ComandoSql.ExecuteNonQuery()
            ComandoSql.Dispose()
            Sql = String.Empty
            con.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
