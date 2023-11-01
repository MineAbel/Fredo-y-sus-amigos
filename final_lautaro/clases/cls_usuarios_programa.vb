Imports System.Data.OleDb
Imports System.IO

Public Class cls_usuarios_programa

    Dim ComandoSql As OleDbCommand
    Dim Sql As String
    'structure query language
    'LENGUAJE ESTRUCTURADO DE CONSULTAS 
    Dim arrImage() As Byte
    Dim mstream As New System.IO.MemoryStream()

    Function AgregaUsuario(ByVal usuario As String, ByVal contra As String, ByVal tipo As String) As Boolean

        Try

            Dim con As New OleDbConnection(RutaDB_final) 'APUNTA A LA BASE DE DATOS..
            con.Open()


            Sql = "Insert into usuarios (usuario, contraseña, tipo) Values (@usuario,@contra,@tipo)"

            ComandoSql = New OleDbCommand
            With ComandoSql
                .Connection = con
                .Parameters.AddWithValue("@usuario", usuario.ToUpper)
                .Parameters.AddWithValue("@contraseña", contra.ToUpper)
                .Parameters.AddWithValue("@tipo", tipo.ToUpper)
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

    Function EliminaUsuarios(ByVal usuario As Integer) As Boolean
        Try
            Dim con As New OleDbConnection(RutaDB_final)
            con.Open()
            Sql = "DELETE * FROM usuarios WHERE usuario =" & usuario
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

    Function Modificausuario(ByVal contra As String, ByVal tipo As String, ByVal usuario As String) As Boolean


        Try
            Dim con As New OleDbConnection(RutaDB_final)
            Dim MS As New MemoryStream




            con.Open()
            'TOUPPER  MAYUSCULAS  TOLOWER MINUSCULAS
            Sql = "UPDATE usuarios_programa SET contraseña = '" & contra.ToUpper & "', tipo = '" & tipo & "' WHERE usuario ='" & usuario & "'"

            ComandoSql = New OleDbCommand(Sql, con)
            ComandoSql.Parameters.AddWithValue("@usuario", usuario)

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

