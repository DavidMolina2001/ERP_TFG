﻿Imports Microsoft.Data.SqlClient

Public Class clsMantenimiento
    Inherits BDRecord

#Region "Atributos y Constantes"

    Public Shared Shadows ReadOnly NOM_TAULA As String = "Mantenimiento"
    Public Shared Shadows ReadOnly NOM_PK As String = "IdMantenimiento"

    Public Shared NOM_CLASSE_CAT = "Manteniment"
    Public Shared NOM_CLASSE_ES = "Mantenimiento"

    Private iIdFurgoneta As Integer
    Private sObservaciones As String
    Private dtFechaMantenimiento As DateTime

#End Region

#Region "Constructores"

    Public Sub New()
        MyBase.New(NOM_TAULA, NOM_PK)

        iIdFurgoneta = 0
        sObservaciones = String.Empty
        dtFechaMantenimiento = DateTime.Now
    End Sub

#End Region

#Region "Propiedades"

    Public Property IdFurgoneta As Integer
        Get
            Return iIdFurgoneta
        End Get
        Set(value As Integer)
            iIdFurgoneta = value
        End Set
    End Property

    Public Property Observaciones As String
        Get
            Return sObservaciones
        End Get
        Set(value As String)
            sObservaciones = value
        End Set
    End Property

    Public Property FechaMantenimiento As DateTime
        Get
            Return dtFechaMantenimiento
        End Get
        Set(value As DateTime)
            dtFechaMantenimiento = value
        End Set
    End Property

#End Region

#Region "Metodos"

    Public Overrides Sub CopiarDatosDesdeDataReader(reader As SqlDataReader)
        Me.iIdFurgoneta = Convert.ToInt32(reader("IdFurgoneta"))
        Me.sObservaciones = Convert.ToString(reader("Observaciones"))
        Me.dtFechaMantenimiento = Convert.ToDateTime(reader("FechaMantenimiento"))
    End Sub

    Public Overrides Sub CopiarDatosADataRow(drw As DataRow)
        drw("IdFurgoneta") = Me.iIdFurgoneta
        drw("Observaciones") = Me.sObservaciones
        drw("FechaMantenimiento") = Me.dtFechaMantenimiento
    End Sub

    Public Overrides Function FormulariManteniment() As Type
        Return GetType(frmMantenimiento)
    End Function

#End Region

#Region "Consultas"

    Public Enum Consultas
        Defecte = 0
        Visualitzacio = 1
    End Enum

    Public Overrides Function Seleccionar_Consulta(IdConsulta As Integer, Optional oParams As Object() = Nothing) As String
        Dim sRes As String = String.Empty

        Select Case IdConsulta
            Case Consultas.Defecte
                sRes = ConsultaSelectTots()

            Case Consultas.Visualitzacio
                sRes = ConsultaSelectVisualitzacio()
        End Select

        Return sRes
    End Function

    Public Shared Function ConsultaSelectTots()
        Return "SELECT * FROM " & NOM_TAULA
    End Function

    Public Shared Function ConsultaSelectVisualitzacio()
        Return "SELECT dbo.Mantenimiento.IdMantenimiento, dbo.Furgonetas.Nombre, dbo.Furgonetas.Marca, dbo.Furgonetas.Modelo, " &
               "dbo.Furgonetas.Matricula, dbo.Mantenimiento.Observaciones, dbo.Mantenimiento.FechaMantenimiento " &
                " FROM dbo.Furgonetas INNER JOIN " &
                "  dbo.Mantenimiento ON dbo.Furgonetas.IdFurgoneta = dbo.Mantenimiento.IdFurgoneta"
    End Function

    Public Shared Function ConsultaSelectSegonsFurgoneta(IdFurgoneta As Integer)
        Return "SELECT IdMantenimiento, Observaciones, FechaMantenimiento FROM Mantenimiento WHERE IdFurgoneta = " & IdFurgoneta & " ORDER BY FechaMantenimiento DESC"
    End Function

    Public Overrides Function NomCampMostrar(sCamp As String) As String
        Dim nombreTraducido As String = ""

        Select Case sCamp
            Case "IdMantenimiento"
                nombreTraducido = fnTraductor.RetornaIdiomaSeleccionat("Id Mantenimiento", "Id Manteniment")
            Case "IdFurgoneta"
                nombreTraducido = fnTraductor.RetornaIdiomaSeleccionat("Id Furgoneta", "Id Furgoneta")
            Case "Observaciones"
                nombreTraducido = fnTraductor.RetornaIdiomaSeleccionat("Observaciones", "Observacions")
            Case "FechaMantenimiento"
                nombreTraducido = fnTraductor.RetornaIdiomaSeleccionat("Fecha Mantenimiento", "Data Manteniment")
            Case "IdFurgoneta"
                nombreTraducido = fnTraductor.RetornaIdiomaSeleccionat("Id Furgoneta", "Id Furgoneta")
            Case "Nombre"
                nombreTraducido = fnTraductor.RetornaIdiomaSeleccionat("Nombre", "Nom")
            Case "Marca"
                nombreTraducido = fnTraductor.RetornaIdiomaSeleccionat("Marca", "Marca")
            Case "Modelo"
                nombreTraducido = fnTraductor.RetornaIdiomaSeleccionat("Modelo", "Model")
            Case "Kilometros"
                nombreTraducido = fnTraductor.RetornaIdiomaSeleccionat("Kilometros", "Kilòmetres")
            Case "Matricula"
                nombreTraducido = fnTraductor.RetornaIdiomaSeleccionat("Matricula", "Matrícula")
            Case Else
                nombreTraducido = sCamp
        End Select

        Return nombreTraducido
    End Function

#End Region

End Class
