Imports System.Net
Imports System.Net.Mail
Public Class clsMail

    Private Const PASSWD As String = "gplp aawq jjyb kynx"
    Private Const MAILTO As String = "transportstfg@gmail.com"

    Friend Shared Sub EnviarMailCliente(sMailCliente As String, sCodigoSeguimiento As String, iEstado As Integer)

        Dim smtpCliente As SmtpClient = Nothing
        Dim correo As MailMessage = Nothing

        Try

            smtpCliente = New SmtpClient("smtp.gmail.com")
            smtpCliente.Port = 587
            smtpCliente.Credentials = New NetworkCredential(MAILTO, PASSWD)
            smtpCliente.EnableSsl = True

            ' Missatge
            correo = New MailMessage()
            correo.From = New MailAddress(MAILTO)
            correo.To.Add(sMailCliente)

            correo.Subject = getAsuntoSegunEstado(iEstado, sCodigoSeguimiento)

            correo.Body = getCuerpoSegunEstado(iEstado, sCodigoSeguimiento)

            smtpCliente.Send(correo)

        Catch ex As Exception
            Throw New Exception("Error clsMail.EnviarTicket")
        Finally
            If smtpCliente IsNot Nothing Then
                smtpCliente.Dispose()
                smtpCliente = Nothing
            End If

            If correo IsNot Nothing Then
                correo.Dispose()
                correo = Nothing
            End If
        End Try

    End Sub

    Friend Shared Sub EnviarTicket(iTicket As Integer, sExplicacio As String, sMissatgeEX As String)

        Dim smtpCliente As SmtpClient = Nothing
        Dim correo As MailMessage = Nothing

        Try

            smtpCliente = New SmtpClient("smtp.gmail.com")
            smtpCliente.Port = 587
            smtpCliente.Credentials = New NetworkCredential(MAILTO, PASSWD)
            smtpCliente.EnableSsl = True

            ' Missatge
            correo = New MailMessage()
            correo.From = New MailAddress(MAILTO)
            correo.To.Add(MAILTO)

            correo.Subject = "Ticket " & iTicket & " USUARI: " & clsSeguretat.Usuari

            correo.Body = "Explicació: " & sExplicacio & vbCrLf & "Excepció: " & sMissatgeEX

            smtpCliente.Send(correo)

        Catch ex As Exception
            Throw New Exception("Error clsMail.EnviarTicket")
        Finally
            If smtpCliente IsNot Nothing Then
                smtpCliente.Dispose()
                smtpCliente = Nothing
            End If

            If correo IsNot Nothing Then
                correo.Dispose()
                correo = Nothing
            End If
        End Try


    End Sub

    Private Shared Function getCuerpoSegunEstado(iEstado As Integer, sCodigoSeguimiento As String) As String
        Dim sRes As String = String.Empty

        Select Case iEstado
            Case EstadosEnvios.Estados.Recibido
                sRes = "Estimado cliente, le informamos que su paquete con el código de seguimiento " & sCodigoSeguimiento & " ha sido recibido en nuestras instalaciones. Estamos procesando su envío y le mantendremos informado sobre su estado."
            Case EstadosEnvios.Estados.Reparto
                sRes = "Estimado cliente, nos complace informarle que su paquete con el código de seguimiento " & sCodigoSeguimiento & " está en proceso de entrega. Nuestro equipo de reparto se encargará de llevarlo hasta su dirección."
            Case EstadosEnvios.Estados.Entregado
                sRes = "Estimado cliente, le informamos que su paquete con el código de seguimiento " & sCodigoSeguimiento & " ha sido entregado con éxito en la dirección indicada. Esperamos que disfrute de su compra y estamos a su disposición para cualquier consulta adicional."
            Case EstadosEnvios.Estados.Incidencia
                sRes = "Estimado cliente, lamentamos informarle que hemos encontrado una incidencia con su envío con el código de seguimiento " & sCodigoSeguimiento & ". Nuestro equipo está trabajando para resolver esta situación lo antes posible. Le pedimos disculpas por cualquier inconveniente que esto pueda causarle."
            Case Else
                Throw New Exception("clsMail.getCuerpoSegunEstado: Caso no contemplado")
        End Select

        Return sRes
    End Function

    Private Shared Function getAsuntoSegunEstado(iEstado As Integer, sCodigoSeguimiento As String) As String
        Dim sRes As String = String.Empty

        Select Case iEstado
            Case EstadosEnvios.Estados.Recibido
                sRes = "Notificación de recepción de paquete - Código: " & sCodigoSeguimiento
            Case EstadosEnvios.Estados.Reparto
                sRes = "Actualización de estado de entrega - Código: " & sCodigoSeguimiento
            Case EstadosEnvios.Estados.Entregado
                sRes = "Confirmación de entrega de paquete - Código: " & sCodigoSeguimiento
            Case EstadosEnvios.Estados.Incidencia
                sRes = "Aviso de incidencia con paquete - Código: " & sCodigoSeguimiento
            Case Else
                Throw New Exception("clsMail.getAsuntoSegunEstado: Caso no contemplado")
        End Select

        Return sRes
    End Function


End Class
