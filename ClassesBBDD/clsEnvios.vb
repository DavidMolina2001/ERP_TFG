﻿Imports Microsoft.Data.SqlClient

Public Class clsEnvios
    Inherits BDRecord

#Region "Atributos i Constantes"
    Public Shared Shadows ReadOnly NOM_TAULA As String = "Envios"
    Public Shared Shadows ReadOnly NOM_PK As String = "IdEnvio"

    Public Shared NOM_CLASSE_CAT = "Enviaments"
    Public Shared NOM_CLASSE_ES = "Envíos"

    'Public iIdPorte As Integer LA PK NO LA PONEMOS NO HACE FALTA
    Private sCodigoSeguimiento As String
    Private sDireccionOrigen As String
    Private sNombreRemitente As String
    Private oPoblacionOrigen As Object
    Private sMailRemitente As String
    Private sDireccionDestino As String
    Private sNombreDestinatario As String
    Private oPoblacionDestino As Object
    Private sEmailDestinatario As String
    Private cIdEstado As Byte
    Private fPeso As Double
    Private sDimensiones As String
    Private iCodigoCliente As Integer
    Private dPorte As Decimal
    Private iIdRuta As Integer
#End Region



#Region "Constructores"
    Public Sub New()
        MyBase.New(NOM_TAULA, NOM_PK)

        Me.sCodigoSeguimiento = String.Empty
        Me.sDireccionOrigen = String.Empty
        Me.sNombreRemitente = String.Empty
        Me.oPoblacionOrigen = 0
        Me.sMailRemitente = String.Empty
        Me.sDireccionDestino = String.Empty
        Me.sNombreDestinatario = String.Empty
        Me.oPoblacionDestino = 0
        Me.sEmailDestinatario = String.Empty
        Me.cIdEstado = 0
        Me.fPeso = 0.0
        Me.sDimensiones = String.Empty
        Me.iCodigoCliente = 0
        Me.dPorte = 0.0
        Me.iIdRuta = 0
    End Sub
#End Region

#Region "Propiedades"

    Public Property CodigoSeguimiento As String
        Get
            Return sCodigoSeguimiento
        End Get
        Set(value As String)
            sCodigoSeguimiento = value
        End Set
    End Property

    Public Property DireccionOrigen As String
        Get
            Return sDireccionOrigen
        End Get
        Set(value As String)
            sDireccionOrigen = value
        End Set
    End Property

    Public Property NombreRemitente As String
        Get
            Return sNombreRemitente
        End Get
        Set(value As String)
            sNombreRemitente = value
        End Set
    End Property

    Public Property PoblacionOrigen As Object
        Get
            Return oPoblacionOrigen
        End Get
        Set(value As Object)
            oPoblacionOrigen = value
        End Set
    End Property

    Public Property MailRemitente As String
        Get
            Return sMailRemitente
        End Get
        Set(value As String)
            sMailRemitente = value
        End Set
    End Property

    Public Property DireccionDestino As String
        Get
            Return sDireccionDestino
        End Get
        Set(value As String)
            sDireccionDestino = value
        End Set
    End Property

    Public Property NombreDestinatario As String
        Get
            Return sNombreDestinatario
        End Get
        Set(value As String)
            sNombreDestinatario = value
        End Set
    End Property

    Public Property PoblacionDestino As Object
        Get
            Return oPoblacionDestino
        End Get
        Set(value As Object)
            oPoblacionDestino = value
        End Set
    End Property

    Public Property EmailDestinatario As String
        Get
            Return sEmailDestinatario
        End Get
        Set(value As String)
            sEmailDestinatario = value
        End Set
    End Property

    Public Property IdEstado As Byte
        Get
            Return cIdEstado
        End Get
        Set(value As Byte)
            cIdEstado = value
        End Set
    End Property

    Public Property Peso As Double
        Get
            Return fPeso
        End Get
        Set(value As Double)
            fPeso = value
        End Set
    End Property

    Public Property Dimensiones As String
        Get
            Return sDimensiones
        End Get
        Set(value As String)
            sDimensiones = value
        End Set
    End Property

    Public Property CodigoCliente As Integer
        Get
            Return iCodigoCliente
        End Get
        Set(value As Integer)
            iCodigoCliente = value
        End Set
    End Property

    Public Property Porte As Decimal
        Get
            Return dPorte
        End Get
        Set(value As Decimal)
            dPorte = value
        End Set
    End Property

    Public Property IdRuta As Integer
        Get
            Return iIdRuta
        End Get
        Set(value As Integer)
            iIdRuta = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Overrides Sub CopiarDatosDesdeDataReader(reader As SqlDataReader)
        Me.sDireccionOrigen = Convert.ToString(reader("DireccionOrigen"))
        Me.sNombreRemitente = Convert.ToString(reader("NombreRemitente"))
        Me.oPoblacionOrigen = reader("PoblacionOrigen")
        Me.sMailRemitente = Convert.ToString(reader("MailRemitente"))
        Me.sDireccionDestino = Convert.ToString(reader("DireccionDestino"))
        Me.sNombreDestinatario = Convert.ToString(reader("NombreDestinatario"))
        Me.oPoblacionDestino = reader("PoblacionDestino")
        Me.sEmailDestinatario = Convert.ToString(reader("EmailDestinatario"))
        Me.cIdEstado = Convert.ToByte(reader("IdEstado"))
        Me.fPeso = Convert.ToDouble(reader("Peso"))
        Me.sDimensiones = Convert.ToString(reader("Dimensiones"))
        Me.iCodigoCliente = Convert.ToInt32(reader("CodigoCliente"))
        Me.dPorte = Convert.ToDecimal(reader("Porte"))
        Me.sCodigoSeguimiento = Convert.ToString(reader("CodigoSeguimiento"))
        Me.iIdRuta = Convert.ToInt32(reader("IdRuta"))
    End Sub

    Public Overrides Sub CopiarDatosADataRow(drw As DataRow)
        drw("DireccionOrigen") = Me.sDireccionOrigen
        drw("NombreRemitente") = Me.sNombreRemitente
        drw("PoblacionOrigen") = Me.oPoblacionOrigen
        drw("MailRemitente") = Me.sMailRemitente
        drw("DireccionDestino") = Me.sDireccionDestino
        drw("NombreDestinatario") = Me.sNombreDestinatario
        drw("PoblacionDestino") = Me.oPoblacionDestino
        drw("EmailDestinatario") = Me.sEmailDestinatario
        drw("IdEstado") = Me.cIdEstado
        drw("Peso") = Me.fPeso
        drw("Dimensiones") = Me.sDimensiones
        drw("CodigoCliente") = Me.iCodigoCliente
        drw("Porte") = Me.dPorte
        drw("CodigoSeguimiento") = Me.sCodigoSeguimiento
        drw("IdRuta") = Me.iIdRuta
    End Sub

    Public Sub CopiarDataRowADatos(drw As DataRow)
        Me.sDireccionOrigen = Convert.ToString(drw("DireccionOrigen"))
        Me.sNombreRemitente = Convert.ToString(drw("NombreRemitente"))
        Me.oPoblacionOrigen = Convert.ToInt32(drw("PoblacionOrigen"))
        Me.sMailRemitente = Convert.ToString(drw("MailRemitente"))
        Me.sDireccionDestino = Convert.ToString(drw("DireccionDestino"))
        Me.sNombreDestinatario = Convert.ToString(drw("NombreDestinatario"))
        Me.oPoblacionDestino = Convert.ToInt32(drw("PoblacionDestino"))
        Me.sEmailDestinatario = Convert.ToString(drw("EmailDestinatario"))
        Me.cIdEstado = Convert.ToByte(drw("IdEstado"))
        Me.fPeso = Convert.ToDouble(drw("Peso"))
        Me.sDimensiones = Convert.ToString(drw("Dimensiones"))
        Me.iCodigoCliente = Convert.ToInt32(drw("CodigoCliente"))
        Me.dPorte = Convert.ToDecimal(drw("Porte"))
        Me.sCodigoSeguimiento = Convert.ToString(drw("CodigoSeguimiento"))
        Me.iIdRuta = Convert.ToInt32(drw("IdRuta"))
    End Sub


    Public Overrides Function FormulariManteniment() As Type
        Return GetType(frmEnvios)
    End Function
#End Region

#Region "Consultes"

    Public Enum Consultas
        Defecte = 0
        Incidencias = 1
        Fecha = 2
        IncidenciasFecha = 3
    End Enum

    Public Overrides Function Seleccionar_Consulta(IdConsulta As Integer, Optional oParams As Object() = Nothing) As String
        Dim sRes As String = String.Empty
        Select Case IdConsulta
            Case Consultas.Defecte
                sRes = ConsultaSelectTots()
            Case Consultas.Incidencias
                sRes = ConsultaSelectTots() & " WHERE Envios.IdEstado = 6"

            Case Consultas.Fecha
                sRes = ConsultaSelectFecha(oParams(0))

            Case Consultas.IncidenciasFecha
                sRes = ConsultaSelectFecha(oParams(0)) & " AND e.IdEstado = 6"

        End Select
        Return sRes
    End Function

    Public Shared Function ConsultaSelectTots() As String
        Return "SELECT Envios.IdEnvio, Envios.CodigoSeguimiento, Envios.DireccionOrigen, Envios.NombreRemitente, " &
           "PobOrigen.NomPoblacio AS PoblacionOrigen, Envios.MailRemitente, " &
           "Envios.DireccionDestino, Envios.NombreDestinatario, " &
           "PobDestino.NomPoblacio AS PoblacionDestino, Envios.EmailDestinatario, Envios.Dimensiones, Envios.Peso, " &
           "Envios.CodigoCliente, Envios.Porte, Envios_Estados." & fnTraductor.RetornaIdiomaSeleccionat("Nom_ES", "Nom_CA") &
           " FROM Envios WITH (NOLOCK) " &
           " INNER JOIN Envios_Estados ON Envios.IdEstado = Envios_Estados.IdEstado " &
           " INNER JOIN Poblacions AS PobOrigen ON Envios.PoblacionOrigen = PobOrigen.IdPoblacio " &
           " INNER JOIN Poblacions AS PobDestino ON Envios.PoblacionDestino = PobDestino.IdPoblacio"
    End Function


    Public Shared Function ConsultaSelectFecha(ByVal dDate As Date) As String
        Dim formattedDate As String = dDate.ToString("MM/dd/yyyy")
        Return "SELECT e.IdEnvio, e.CodigoSeguimiento, e.DireccionOrigen, e.NombreRemitente, e.PoblacionOrigen, e.MailRemitente, " &
           "e.DireccionDestino, e.NombreDestinatario, e.PoblacionDestino, e.EmailDestinatario, e.Dimensiones, e.Peso, e.CodigoCliente, e.Porte, " &
           "es." & fnTraductor.RetornaIdiomaSeleccionat("Nom_ES", "Nom_CA") & ", eh.Observaciones, eh.FechaEstado " &
           "FROM Envios As e WITH (NOLOCK) " &
           "INNER JOIN Envios_Historico As eh WITH (NOLOCK) On e.IdEnvio = eh.IdEnvio " &
           "INNER JOIN Envios_Estados As es WITH (NOLOCK) On e.IdEstado = es.IdEstado " &
           "INNER JOIN (Select IdEnvio, MAX(FechaEstado) As MaxFechaEstado " &
           "FROM Envios_Historico WITH (NOLOCK) GROUP BY IdEnvio) As latest On eh.IdEnvio = latest.IdEnvio And eh.FechaEstado = latest.MaxFechaEstado " &
           "WHERE Convert(Date, eh.FechaEstado) = '" & formattedDate & "'"
    End Function

    Public Shared Function ConsultaSelect_EntreDosFechas(ByVal dDateInicio As Date, ByVal dDateFinal As Date) As String
        Dim formattedDateInicio As String = dDateInicio.ToString("yyyy/MM/dd")
        Dim formattedDateFinal As String = dDateFinal.ToString("yyyy/MM/dd")
        Return "Select        e.IdEnvio, e.CodigoSeguimiento, e.DireccionOrigen, e.NombreRemitente, e.MailRemitente, e.DireccionDestino, e.NombreDestinatario, " &
    " e.EmailDestinatario, e.Dimensiones, e.Peso, e.CodigoCliente, e.Porte, es." & fnTraductor.RetornaIdiomaSeleccionat("Nom_ES", "Nom_CA") & ", 
        eh.Observaciones, eh.FechaEstado, Poblacions_1.NomPoblacio As PoblacioOrigen, dbo.Poblacions.NomPoblacio AS PoblacioDesti, latest.MaxFechaEstado 
        From dbo.Envios AS e WITH (NOLOCK) INNER Join
        dbo.Envios_Historico AS eh WITH (NOLOCK) ON e.IdEnvio = eh.IdEnvio INNER Join
        dbo.Envios_Estados AS es WITH (NOLOCK) ON e.IdEstado = es.IdEstado INNER Join
            (Select IdEnvio, MAX(FechaEstado) As MaxFechaEstado
            From dbo.Envios_Historico WITH (NOLOCK)
            Group By IdEnvio) AS latest ON eh.IdEnvio = latest.IdEnvio And eh.FechaEstado = latest.MaxFechaEstado INNER Join
        dbo.Poblacions AS Poblacions_1 ON e.PoblacionOrigen = Poblacions_1.IdPoblacio INNER Join
        dbo.Poblacions ON e.PoblacionDestino = dbo.Poblacions.IdPoblacio " &
           "WHERE Convert(Date, eh.FechaEstado) >= '" & formattedDateInicio & "' AND Convert(Date, eh.FechaEstado) <= '" & formattedDateFinal & "'"
    End Function





    'Public Shared Function ConsultaSelect_EntreDosFechas(ByVal dDateInicio As Date, ByVal dDateFinal As Date) As String
    '    Dim formattedDateInicio As String = dDateInicio.ToString("yyyy/MM/dd")
    '    Dim formattedDateFinal As String = dDateFinal.ToString("yyyy/MM/dd")
    '    Return "SELECT e.IdEnvio, e.CodigoSeguimiento, e.DireccionOrigen, e.NombreRemitente, " &
    '       "pDestino.NomPoblacio AS PoblacionDestino, e.MailRemitente, " &
    '       "e.DireccionDestino, e.NombreDestinatario, " &
    '       "pOrigen.NomPoblacio AS PoblacionOrigen, e.EmailDestinatario, e.Dimensiones, e.Peso, e.CodigoCliente, e.Porte, " &
    '       "es." & fnTraductor.RetornaIdiomaSeleccionat("Nom_ES", "Nom_CA") & " AS EstadoEnvio, eh.Observaciones, eh.FechaEstado, " &
    '       "pDestino.CodPostal AS CodPostalDestino, pOrigen.CodPostal AS CodPostalOrigen " &
    '       "FROM Envios e WITH (NOLOCK) " &
    '       "INNER JOIN Envios_Historico eh WITH (NOLOCK) ON e.IdEnvio = eh.IdEnvio " &
    '       "INNER JOIN Envios_Estados es WITH (NOLOCK) ON e.IdEstado = es.IdEstado " &
    '       "INNER JOIN (SELECT IdEnvio, MAX(FechaEstado) AS MaxFechaEstado FROM Envios_Historico WITH (NOLOCK) GROUP BY IdEnvio) AS latest ON eh.IdEnvio = latest.IdEnvio AND eh.FechaEstado = latest.MaxFechaEstado " &
    '       "INNER JOIN Poblacions pDestino WITH (NOLOCK) ON e.PoblacionDestino = pDestino.NomPoblacio " &
    '       "INNER JOIN Poblacions pOrigen WITH (NOLOCK) ON e.PoblacionOrigen = pOrigen.NomPoblacio " &
    '       "WHERE Convert(Date, eh.FechaEstado) >= '" & formattedDateInicio & "' AND Convert(Date, eh.FechaEstado) <= '" & formattedDateFinal & "'"
    'End Function



    Public Shared Function ConsultaSelect_EntreDosFechas_Estados(ByVal dDateInicio As Date, ByVal dDateFinal As Date) As String
        Dim formattedDateInicio As String = dDateInicio.ToString("yyyy/MM/dd")
        Dim formattedDateFinal As String = dDateFinal.ToString("yyyy/MM/dd")
        Return "SELECT e.IdEnvio, e.CodigoSeguimiento, e.DireccionOrigen, e.NombreRemitente, e.PoblacionOrigen, e.MailRemitente, " &
           "e.DireccionDestino, e.NombreDestinatario, e.PoblacionDestino, e.EmailDestinatario, e.Dimensiones, e.Peso, e.CodigoCliente, e.Porte, " &
           "es." & fnTraductor.RetornaIdiomaSeleccionat("Nom_ES", "Nom_CA") & ", eh.Observaciones, eh.FechaEstado " &
           "FROM Envios As e WITH (NOLOCK) " &
           "INNER JOIN Envios_Historico As eh WITH (NOLOCK) On e.IdEnvio = eh.IdEnvio " &
           "INNER JOIN Envios_Estados As es WITH (NOLOCK) On e.IdEstado = es.IdEstado " &
           "WHERE Convert(Date, eh.FechaEstado) >= '" & formattedDateInicio & "' AND Convert(Date, eh.FechaEstado) <= '" & formattedDateFinal & "' " &
           "AND es.IdEstado = 6"
    End Function

    Public Shared Function ConsultaSelectSegunCliente(ByVal IdCliente As Integer) As String
        Return "SELECT Envios.CodigoSeguimiento, Envios.DireccionDestino, Envios.NombreDestinatario, " &
           "PobDestino.NomPoblacio AS PoblacionDestino, Envios.EmailDestinatario, Envios.Dimensiones, Envios.Peso, " &
           fnTraductor.RetornaIdiomaSeleccionat("Envios_Estados.Nom_ES", "Envios_Estados.Nom_CA") & " " &
           "FROM Envios WITH (NOLOCK) " &
           "INNER JOIN Envios_Estados ON Envios.IdEstado = Envios_Estados.IdEstado " &
           "INNER JOIN Poblacions AS PobDestino ON Envios.PoblacionDestino = PobDestino.IdPoblacio " &
           "WHERE Envios.CodigoCliente = " & IdCliente
    End Function



    Public Overrides Function NomCampMostrar(nombreAtributo As String) As String
        Dim nombreColumna As String = ""

        Select Case nombreAtributo
            Case "IdEnvio"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Id Envio", "Id Enviament")
            Case "DireccionOrigen"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Dirección Origen", "Direcció Origen")
            Case "NombreRemitente"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Nombre Remitente", "Nom Remitent")
            Case "PoblacionOrigen"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Población Origen", "Població Origen")
            Case "MailRemitente"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Email Remitente", "Email Remitent")
            Case "PoblacionDestino"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Población Destino", "Població Destí")
            Case "CodigoPostalDestino"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Código Postal Destino", "Codi Postal Destí")
            Case "NombreDestinatario"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Nombre Destinatario", "Nom Destinatari")
            Case "IdEstado"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Estado", "Estat")
            Case "DireccionDestino"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Dirección Destino", "Direcció Destí")
            Case "Peso"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Peso", "Pes")
            Case "Dimensiones"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Dimensiones", "Dimensions")
            Case "CodigoCliente"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Código Cliente", "Codi Client")
            Case "Porte"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Porte", "Porte")
            Case "CodigoSeguimiento"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Código Seguimiento", "Codi Seguiment")
            Case "Nom_CA", "Nom_ES"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Estado", "Estat")
            Case "EmailDestinatario"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Email Destinatario", "Email Destinatari")
            Case "FechaEstado"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Fecha Estado", "Data Estat")
            Case "IdRuta"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Ruta", "Ruta")
            Case Else
                nombreColumna = nombreAtributo
        End Select

        Return nombreColumna
    End Function



#End Region


End Class
