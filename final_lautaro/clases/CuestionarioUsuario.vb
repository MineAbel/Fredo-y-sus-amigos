
Imports System.Data.OleDb
Imports System.IO
Imports System.Net.Mime.MediaTypeNames
Imports System.Runtime.CompilerServices
Public Class CuestionarioUsuario
    Dim ComandoSql As OleDbCommand
    Dim Sql As String
    'structure query language
    'LENGUAJE ESTRUCTURADO DE CONSULTAS 
    Dim arrImage() As Byte
    Dim mstream As New System.IO.MemoryStream()

    Function AgregaRespuesta(ByVal usuario As String, ByVal id_preg As String, ByVal resp_d As String, ByVal resp_v As String) As Boolean

        Try
            Dim con As New OleDbConnection(RutaDB_final) 'APUNTA A LA BASE DE DATOS..
            con.Open()



            Sql = "Insert into respuestas (usuario, id_preg, resp_d, resp_v) " _
                + "Values (@usuario,@id_preg,@resp_d,@resp_v)"


            '"SELECT Historias.Texto, Historias.imagen FROM Historias;" _
            '+ "Values (@historias,@foto)"

            ComandoSql = New OleDbCommand
            With ComandoSql
                .Connection = con
                .CommandText = Sql
                .Parameters.AddWithValue("@usuario", usuario.ToUpper)
                .Parameters.AddWithValue("@id_preg", id_preg.ToUpper)
                .Parameters.AddWithValue("@resp_d", resp_d.ToUpper)
                .Parameters.AddWithValue("@resp_v", resp_v.ToUpper)



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

End Class
