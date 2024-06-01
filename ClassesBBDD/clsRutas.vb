﻿Imports Microsoft.Data.SqlClient

Public Class clsRutas
    Inherits BDRecord

#Region "Atributos y Constantes"

    Public Shared Shadows ReadOnly NOM_TAULA As String = "Rutas"
    Public Shared Shadows ReadOnly NOM_PK As String = "IdRuta"

    Public Shared NOM_CLASSE_CAT = "Rutes"
    Public Shared NOM_CLASSE_ES = "Rutas"

    Private sPoblaciones As String
    Private sNom As String

#End Region

#Region "Constructores"

    Public Sub New()
        MyBase.New(NOM_TAULA, NOM_PK)

        sPoblaciones = String.Empty
    End Sub

#End Region

#Region "Propiedades"

    Public Property Poblaciones As String
        Get
            Return sPoblaciones
        End Get
        Set(value As String)
            sPoblaciones = value
        End Set
    End Property

    Public Property Nom As String
        Get
            Return sNom
        End Get
        Set(value As String)
            sNom = value
        End Set
    End Property

#End Region

#Region "Metodos"

    Public Overrides Sub CopiarDatosDesdeDataReader(reader As SqlDataReader)
        Me.sPoblaciones = Convert.ToString(reader("Poblaciones"))
        Me.sNom = Convert.ToString(reader("Nom"))

    End Sub

    Public Overrides Sub CopiarDatosADataRow(drw As DataRow)
        drw("Poblaciones") = Me.sPoblaciones
        drw("Nom") = Me.sNom

    End Sub

    Public Overrides Function FormulariManteniment() As Type
        Return GetType(frmRutas)
    End Function

#End Region

#Region "Consultas"

    Public Enum Consultas
        Defecte = 0
    End Enum

    Public Overrides Function Seleccionar_Consulta(IdConsulta As Integer, Optional oParams As Object() = Nothing) As String
        Dim sRes As String = String.Empty

        Select Case IdConsulta
            Case Consultas.Defecte
                sRes = ConsultaSelectTots()
        End Select

        Return sRes
    End Function

    Public Shared Function ConsultaSelectTots()
        Return "SELECT * FROM " & NOM_TAULA
    End Function

    Public Shared Function ConsultaSelectSinRuta()
        Return "SELECT t.IdRuta, t.Nom
                FROM dbo.Rutas t
                LEFT JOIN Furgoneta_Ruta fr ON t.IdRuta = fr.IdRuta AND CONVERT(date, fr.FechaRuta) = CONVERT(date, GETDATE())
                WHERE fr.IdRuta IS NULL;"
    End Function

    Public Overrides Function NomCampMostrar(sCamp As String) As String
        Dim nombreTraducido As String = ""

        Select Case sCamp
            Case "IdRuta"
                nombreTraducido = fnTraductor.RetornaIdiomaSeleccionat("Id Ruta", "Id Ruta")
            Case "Poblaciones"
                nombreTraducido = fnTraductor.RetornaIdiomaSeleccionat("Poblaciones", "Poblacions")
            Case "Nom"
                nombreTraducido = fnTraductor.RetornaIdiomaSeleccionat("Nombre Ruta", "Nom Ruta")
            Case Else
                nombreTraducido = sCamp
        End Select

        Return nombreTraducido
    End Function

#End Region

End Class
