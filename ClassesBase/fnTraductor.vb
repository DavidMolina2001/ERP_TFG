﻿Public Class fnTraductor
    Public Shared Function RetornaIdiomaSeleccionat(sTextESP As String, sTextCAT As String)

        If clsConstants.Idioma Is Nothing Then
            clsConstants.Idioma = "E"
        End If

        If clsConstants.Idioma.StartsWith("E") Then
            Return sTextESP
        Else
            Return sTextCAT
        End If
    End Function

    Public Shared Function RetornaIdiomaSeleccionat(sTextESP As String, sTextCAT As String, sCodiIdioma As String)
        If sCodiIdioma.StartsWith("E") Then
            Return sTextESP
        Else
            Return sTextCAT
        End If
    End Function
End Class
