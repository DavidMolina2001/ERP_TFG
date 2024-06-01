﻿Imports Microsoft.Data.SqlClient

Public Class clsEnvios
    Inherits BDRecord

#Region "Atributos i Constantes"
    Public Shared Shadows ReadOnly NOM_TAULA As String = "Envios"
    Public Shared Shadows ReadOnly NOM_PK As String = "IdEnvio"

    Public Shared NOM_CLASSE_CAT = "Enviaments"
    Public Shared NOM_CLASSE_ES = "Envíos"

    'Public iIdPorte As Integer LA PK NO LA PONEMOS NO HACE FALTA
    Private sDireccionOrigen As String
    Private sPoblacionDestino As String
    Private sCodigoPostalDestino As String
    Private sNombreDestinatario As String
    Private cEstado As Byte
    Private sDireccionDestino As String
    Private fPeso As Double
    Private sDimensiones As String
    Private oCodigoCliente As Object
    Private iPorte As Decimal
    Private sCodigoSeguimiento As String
    Private sEmailDestinatario As String
    Dim iIdRuta As Integer
#End Region



#Region "Constructores"
    Public Sub New()
        MyBase.New(NOM_TAULA, NOM_PK)


        Me.sDireccionOrigen = String.Empty
        Me.sPoblacionDestino = String.Empty
        Me.sCodigoPostalDestino = String.Empty
        Me.sNombreDestinatario = String.Empty
        Me.Estado = 0
        Me.sDireccionDestino = String.Empty
        Me.fPeso = 0.0
        Me.sDimensiones = String.Empty
        Me.oCodigoCliente = DBNull.Value
        Me.iPorte = 0.0
        Me.sCodigoSeguimiento = String.Empty
        Me.iIdRuta = 0
    End Sub
#End Region

#Region "Propiedades"

    Public Property DireccionOrigen As String
        Get
            Return sDireccionOrigen
        End Get
        Set(value As String)
            sDireccionOrigen = value
        End Set
    End Property

    Public Property PoblacionDestino As String
        Get
            Return sPoblacionDestino
        End Get
        Set(value As String)
            sPoblacionDestino = value
        End Set
    End Property

    Public Property CodigoPostalDestino As String
        Get
            Return sCodigoPostalDestino
        End Get
        Set(value As String)
            sCodigoPostalDestino = value
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

    Public Property Estado As Byte
        Get
            Return cEstado
        End Get
        Set(value As Byte)
            cEstado = value
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

    Public Property CodigoCliente As Object
        Get
            Return oCodigoCliente
        End Get
        Set(value As Object)
            oCodigoCliente = value
        End Set
    End Property

    Public Property Porte As Decimal
        Get
            Return iPorte
        End Get
        Set(value As Decimal)
            iPorte = value
        End Set
    End Property

    Public Property CodigoSeguimiento As String
        Get
            Return sCodigoSeguimiento
        End Get
        Set(value As String)
            sCodigoSeguimiento = value
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
        Me.sPoblacionDestino = Convert.ToString(reader("PoblacionDestino"))
        Me.sCodigoPostalDestino = Convert.ToString(reader("CodigoPostalDestino"))
        Me.sNombreDestinatario = Convert.ToString(reader("NombreDestinatario"))
        Me.cEstado = Convert.ToByte(reader("IdEstado"))
        Me.sDireccionDestino = Convert.ToString(reader("DireccionDestino"))
        Me.fPeso = Convert.ToDouble(reader("Peso"))
        Me.sDimensiones = Convert.ToString(reader("Dimensiones"))
        Me.oCodigoCliente = reader("CodigoCliente")
        Me.iPorte = Convert.ToDouble(reader("Porte"))
        Me.sCodigoSeguimiento = Convert.ToString(reader("CodigoSeguimiento"))
        Me.sEmailDestinatario = Convert.ToString(reader("EmailDestinatario"))
        Me.iIdRuta = Convert.ToInt32(reader("IdRuta"))


    End Sub

    Public Overrides Sub CopiarDatosADataRow(drw As DataRow)
        drw("DireccionOrigen") = Me.sDireccionOrigen
        drw("PoblacionDestino") = Me.sPoblacionDestino
        drw("CodigoPostalDestino") = Me.sCodigoPostalDestino
        drw("NombreDestinatario") = Me.sNombreDestinatario
        drw("IdEstado") = Me.cEstado
        drw("DireccionDestino") = Me.sDireccionDestino
        drw("Peso") = Me.fPeso
        drw("Dimensiones") = Me.sDimensiones
        drw("CodigoCliente") = Me.oCodigoCliente
        drw("Porte") = Me.iPorte
        drw("CodigoSeguimiento") = Me.sCodigoSeguimiento
        drw("EmailDestinatario") = Me.sEmailDestinatario
        drw("IdRuta") = Me.iIdRuta


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

    Public Shared Function ConsultaSelectTots()
        Return "SELECT Envios.IdEnvio, Envios.CodigoSeguimiento, Envios.DireccionOrigen, Envios.PoblacionDestino, Envios.CodigoPostalDestino, Envios.NombreDestinatario, " &
                         "Envios.DireccionDestino, Envios.Dimensiones, Envios.Peso, Envios.CodigoCliente, Envios.Porte, Envios_Estados." & fnTraductor.RetornaIdiomaSeleccionat("Nom_ES", "Nom_CA") &
             " FROM Envios INNER JOIN " &
            "Envios_Estados ON Envios.IdEstado = Envios_Estados.IdEstado"

    End Function

    Public Shared Function ConsultaSelectFecha(ByVal dDate As Date) As String
        Dim formattedDate As String = dDate.ToString("MM/dd/yyyy")
        Dim sRes As String = "SELECT e.IdEnvio, e.CodigoSeguimiento, e.DireccionOrigen, e.PoblacionDestino, e.CodigoPostalDestino, e.NombreDestinatario, e.DireccionDestino, e.Peso, e.Dimensiones, e.CodigoCliente, e.Porte, es." & fnTraductor.RetornaIdiomaSeleccionat("Nom_ES", "Nom_CA") & ", eh.Observaciones, eh.FechaEstado " &
                     "FROM dbo.Envios As e " &
                     "INNER JOIN dbo.Envios_Historico As eh On e.IdEnvio = eh.IdEnvio " &
                     "INNER JOIN dbo.Envios_Estados As es On e.IdEstado = es.IdEstado " &
                     "INNER JOIN (Select IdEnvio, MAX(FechaEstado) As MaxFechaEstado " &
                                 "FROM dbo.Envios_Historico " &
                                 "GROUP BY IdEnvio) As latest On eh.IdEnvio = latest.IdEnvio And eh.FechaEstado = latest.MaxFechaEstado " &
                     "WHERE Convert(Date, eh.FechaEstado) = '" & formattedDate & "'"

        Return sRes
    End Function




    Public Shared Function ConsultaSelectSegunCliente(IdCliente) As String
        Dim sRes As String

        sRes = "SELECT        dbo.Envios.CodigoSeguimiento, dbo.Envios.DireccionDestino, dbo.Envios.PoblacionDestino, dbo.Envios.CodigoPostalDestino, dbo.Envios.NombreDestinatario, dbo.Envios.Peso, dbo.Envios.Dimensiones, 
                                         dbo.Envios.EmailDestinatario, " & fnTraductor.RetornaIdiomaSeleccionat("Envios_Estados.Nom_ES", "Envios_Estados.Nom_CA") &
                " FROM            dbo.Envios INNER JOIN
                                         dbo.Envios_Estados ON dbo.Envios.IdEstado = dbo.Envios_Estados.IdEstado"
        Return sRes
    End Function




    Public Overrides Function NomCampMostrar(nombreAtributo As String) As String
        Dim nombreColumna As String = ""

        Select Case nombreAtributo
            Case "IdEnvio"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Id Envio", "Id Enviament")
            Case "DireccionOrigen"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Dirección Origen", "Direcció Origen")
            Case "PoblacionDestino"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Población Destino", "Població Destinació")
            Case "CodigoPostalDestino"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Código Postal Destino", "Codi Postal Destinació")
            Case "NombreDestinatario"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Nombre Destinatario", "Nom Destinatari")
            Case "IdEstado"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Estado", "Estat")
            Case "DireccionDestino"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Dirección Destino", "Direcció Destinació")
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
