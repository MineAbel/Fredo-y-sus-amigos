Imports System.Net.Mail
Imports System.Reflection.Emit
Imports System.Threading


Public Class enviar_mail
    'variable array para adjuntos
    Dim Adjuntos() As String

    'instanciar la hebra
    Dim oHebra As Threading.Thread
    'Objeto SMTP
    Dim SMPT As New SmtpClient


    Private Sub enviar_mail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_adjuntos_Click(sender As Object, e As EventArgs) Handles btn_adjuntos.Click
        'para obtener adjuntos
        'establecemos filtros para mostrar todos los archivos
        OpenFileDialog1.Filter = "Todos los archivos|*.*"
        'mostramos el dialogo
        OpenFileDialog1.ShowDialog()
        'agregamos la ruta del adjunto
        cbo_adjuntos.Items.Add(OpenFileDialog1.FileName)
        'visualizamos la ruta
        cbo_adjuntos.SelectedIndex = cbo_adjuntos.Items.Count - 1

    End Sub

    Private Sub btn_enviar_Click(sender As Object, e As EventArgs) Handles btn_enviar.Click
        Dim indice As Integer = 0
        Try
            ProgressBar1.Visible = True
            lbl_enviando.Visible = True 'enviando mail...
            Me.Cursor = Cursors.WaitCursor

            For i = 1 To 100
                ProgressBar1.Value = i
                Me.Refresh()
                My.Application.DoEvents()
            Next

            'obtenemos los adjuntos
            ReDim Preserve Adjuntos(0 To cbo_adjuntos.Items.Count - 1)
            For i As Integer = 0 To Adjuntos.Length - 1
                Adjuntos(i) = cbo_adjuntos.Items.Item(i).ToString
            Next

            btn_enviar.Enabled = False
            'poner en marcha la hebra

            oHebra = New Threading.Thread(AddressOf Envio)
            oHebra.Start()

            MsgBox("Listo...")
            ProgressBar1.Visible = False
            lbl_enviando.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Envio()
        'al finalizar el envío, abortar la hebra
        Control.CheckForIllegalCrossThreadCalls = False
        EnviarMail(txt_de.Text.Trim, txt_para.Text, txt_asunto.Text, Adjuntos, txt_mensaje.Text)
        oHebra.Abort()
    End Sub
    Private Sub EnviarMail(ByVal StrDe As String, ByVal StrPara As String,
                           ByVal StrAsunto As String, ByVal sAdjunto() As String,
                           ByVal StrMensaje As String)
        Try

            'variable tipo mensaje con parametros De: Para:
            Dim Msg As New MailMessage(New MailAddress(StrDe), New MailAddress(StrPara))
            'asunto
            Msg.Subject = StrAsunto
            'mensaje
            Msg.Body = StrMensaje

            Msg.CC.Add(txt_cc.Text)
            'Msg.Bcc.Add()

            'ADJUNTOS
            For Each FAdjunto As String In sAdjunto
                If Not FAdjunto = "" Then
                    'Objeto tipo attachment
                    Dim Adjunto As New Attachment(FAdjunto)
                    'agregar adjunto al objeto mensaje
                    Msg.Attachments.Add(Adjunto)
                End If
            Next

            'DATOS SMTP

            'Credenciales
            SMPT.Credentials = New System.Net.NetworkCredential(StrDe, txt_pass.Text)
            'Host, Puerto, autenticacion
            ' SMPT.Host = "smtp.gmail.com"
            SMPT.Host = "smtp.office365.com"
            SMPT.Port = 587
            SMPT.EnableSsl = True
            SMPT.Timeout = 500000
            'Enviar
            SMPT.Send(Msg)

            'regresar cursor y controles a modo normal
            Me.Cursor = Cursors.Default
            btn_enviar.Enabled = True


        Catch ex As Exception
            'regresar cursor y controles a modo normal
            Me.Cursor = Cursors.Default
            btn_enviar.Enabled = True

            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_cancela_Click(sender As Object, e As EventArgs) Handles btn_cancela.Click
        'cancelamos la operación
        SMPT.SendAsyncCancel()

    End Sub

    Private Sub btn_fin_Click(sender As Object, e As EventArgs) Handles btn_fin.Click
        muestra()
        Me.Close()
    End Sub
End Class