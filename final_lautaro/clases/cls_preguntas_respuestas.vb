Imports System.Data.OleDb
Imports System.IO
Imports System.Net.Mime.MediaTypeNames
Imports System.Runtime.CompilerServices
Public Class cls_preguntas_respuestas
    Dim ComandoSql As OleDbCommand
    Dim Sql As String
    'structure query language
    'LENGUAJE ESTRUCTURADO DE CONSULTAS 
    'Dim arrImage() As Byte
    Dim mstream As New System.IO.MemoryStream()


    Function AgregaPreguntas(ByVal preguntas As String, ByVal r1 As String,
                           ByVal r2 As String, ByVal r3 As String, ByVal r4 As String, ByVal rv As String
                          ) As Boolean
        Try
            Dim con As New OleDbConnection(RutaDB_final) 'APUNTA A LA BASE DE DATOS..
            con.Open()

            Dim FileSize As UInt32


            Try

                FileSize = mstream.Length
                mstream.Close()
            Catch
                FileSize = 0
            End Try


            Sql = "Insert into cuestionario (preguntas, r1, r2, r3, r4, rv) " _
                + "Values (@preguntas,@r1,@r2,@r3,@r4,@rv)"

            ComandoSql = New OleDbCommand
            With ComandoSql
                .Connection = con
                .CommandText = Sql
                .Parameters.AddWithValue("@preguntas", preguntas.ToUpper)
                .Parameters.AddWithValue("@r1", r1.ToUpper)
                .Parameters.AddWithValue("@r2", r2.ToUpper)
                .Parameters.AddWithValue("@r3", r3.ToUpper)
                .Parameters.AddWithValue("@r4", r4.ToUpper)
                .Parameters.AddWithValue("@rv", rv.ToUpper)
                '.Parameters.AddWithValue("@foto", arrImage)
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

    Function Modificapregunta(ByVal preguntas As String, ByVal r1 As String, ByVal r2 As String, ByVal r3 As String, ByVal r4 As String, ByVal rv As String, ByVal id As Integer) As Boolean


        Try
            Dim con As New OleDbConnection(RutaDB_final)
            Dim MS As New MemoryStream




            con.Open()
            'TOUPPER  MAYUSCULAS  TOLOWER MINUSCULAS
            Sql = "UPDATE cuestionario SET preguntas ='" & preguntas.ToUpper & "', r1 ='" & r1.ToUpper & "', r2 ='" & r2.ToUpper & "', r3 ='" & r3.ToUpper & "', r4 ='" & r4.ToUpper & "', rv ='" & rv.ToUpper & "' WHERE id =" & id & ""



            ComandoSql = New OleDbCommand(Sql, con)


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

    Function EliminaPregunta(ByVal id As String) As Boolean
        Try
            Dim con As New OleDbConnection(RutaDB_final)
            con.Open()
            Sql = "DELETE * FROM cuestionario WHERE id =" & id & ""
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
