Imports System.Data.Odbc
Imports System.Reflection

Public Class Form5
    Dim posicion As Byte = 2
    Dim contador As Byte = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label3.Text = "ganaste!!"
        Label3.Visible = True

    End Sub

    Private Sub Button1_MouseMove(sender As Object, e As MouseEventArgs) Handles Button1.MouseMove
        ' If Button1.Top < 15 Then
        'Button1.Top = 200
        'Button1.Left = 200
        'Else
        'Button1.Top = 10
        'Button1.Left = 10
        'End If
        contador = contador + 1
        If contador = 10 Then
            posicion = 6
        End If

        Select Case posicion
            Case 1
                Button1.Top = 10
                Button1.Left = 10
                Button1.Text = " Si Presionas te ganas un jugo de anana"
                posicion = 2
            Case 2
                Button1.Top = 10
                Button1.Left = 800
                Button1.Text = "sigue intentando"
                posicion = 3
            Case 3
                Button1.Top = 800
                Button1.Left = 800
                Button1.Text = "no quieres ganar el jugo?"
                posicion = 4
            Case 4
                Button1.Top = 800
                Button1.Left = 10
                Button1.Text = "muy lentoooo"
                posicion = 5
            Case 5
                Button1.Top = 400
                Button1.Left = 400
                Button1.Text = "hasta mi abuela es mas rapida"
                posicion = 1

            Case 6
                Button1.Text = "perdiste la oportunidad.."
                Button1.Top = 500
                Button1.Left = 500
        End Select


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        muestra()
        Me.Close()
    End Sub
End Class