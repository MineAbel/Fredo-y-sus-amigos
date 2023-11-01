Imports System.Data.OleDb
Imports System.IO
Imports System.Net.Mime.MediaTypeNames
Imports System.Runtime.CompilerServices

Public Class cls_usuarios
    Dim ComandoSql As OleDbCommand
    Dim Sql As String
    'structure query language
    'LENGUAJE ESTRUCTURADO DE CONSULTAS 
    Dim arrImage() As Byte
    Dim mstream As New System.IO.MemoryStream()

    Function AgregaUsuario(ByVal usuario As String, ByVal tipo As String, ByVal contra As String) As Boolean



        Try
            Dim con As New OleDbConnection(RutaDB_final) 'APUNTA A LA BASE DE DATOS..
            con.Open()



            Sql = "Insert into usuarios (usuario,tipo,contraseña) " _
                + "Values (@usuario,@tipo,@contra)"

            ComandoSql = New OleDbCommand
            With ComandoSql
                .Connection = con
                .CommandText = Sql


                .Parameters.AddWithValue("@usuario", usuario.ToUpper)
                .Parameters.AddWithValue("@tipo", tipo.ToUpper)
                .Parameters.AddWithValue("@contra", contra.ToUpper)

                .ExecuteNonQuery()
            End With

            ComandoSql.Dispose()
            Sql = String.Empty
            con.Close()
            Return True

        Catch exsql As OleDbException
            '  MsgBox(exsql.Message)

            'MsgBox("verifique el usuario, ese ya existe")
            MessageBox.Show("verifique el usuario, ese ya existe", "Atención", MessageBoxButtons.OK)


            Return False

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

    Function EliminaUsuarios(ByVal id As String) As Boolean
        Try
            Dim con As New OleDbConnection(RutaDB_final)
            con.Open()
            Sql = "DELETE * FROM usuarios WHERE usuario ='" & id & "'"
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

    Function Modificausuario(ByVal usuario As String, ByVal tipo As String, ByVal contra As String
                             ) As Boolean


        Try
            Dim con As New OleDbConnection(RutaDB_final)
            Dim MS As New MemoryStream




            con.Open()
            'TOUPPER  MAYUSCULAS  TOLOWER MINUSCULAS
            Sql = "UPDATE usuarios SET Tipo ='" & tipo.ToUpper & "', contraseña ='" & contra.ToUpper & "' WHERE usuario ='" & usuario & "'"



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



End Class

