﻿Imports Microsoft.Data.SqlClient

Public Class clsFurgoneta_Ruta
    Inherits BDRecord

#Region "Atributos y Constantes"

    Public Shared Shadows ReadOnly NOM_TAULA As String = "Furgoneta_Ruta"
    Public Shared Shadows ReadOnly NOM_PK As String = "IdFurgoneta_Ruta"

    Public Shared NOM_CLASSE_CAT = "Furgoneta - Ruta"
    Public Shared NOM_CLASSE_ES = "Furgoneta - Ruta"

    Private iIdFurgoneta As Integer
    Private iIdRuta As Integer
    Private iIdTrabajador As Integer
    Private dFechaRuta As Date

#End Region

#Region "Constructores"

    Public Sub New()
        MyBase.New(NOM_TAULA, NOM_PK)

        iIdFurgoneta = 0
        iIdRuta = 0
        dFechaRuta = Date.Now
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

    Public Property IdRuta As Integer
        Get
            Return iIdRuta
        End Get
        Set(value As Integer)
            iIdRuta = value
        End Set
    End Property

    Public Property IdTrabajador As Integer
        Get
            Return iIdTrabajador
        End Get
        Set(value As Integer)
            iIdTrabajador = value
        End Set
    End Property

    Public Property FechaRuta As Date
        Get
            Return dFechaRuta
        End Get
        Set(value As Date)
            dFechaRuta = value
        End Set
    End Property

#End Region

#Region "Metodos"

    Public Overrides Sub CopiarDatosDesdeDataReader(reader As SqlDataReader)
        Me.iIdFurgoneta = Convert.ToInt32(reader("IdFurgoneta"))
        Me.iIdRuta = Convert.ToInt32(reader("IdRuta"))
        Me.iIdTrabajador = Convert.ToInt32(reader("IdTrabajador"))
        Me.dFechaRuta = Convert.ToDateTime(reader("FechaRuta"))



    End Sub

    Public Overrides Sub CopiarDatosADataRow(drw As DataRow)
        drw("IdFurgoneta") = Me.iIdFurgoneta
        drw("IdRuta") = Me.iIdRuta
        drw("IdTrabajador") = Me.iIdTrabajador
        drw("FechaRuta") = Me.dFechaRuta


    End Sub

    Public Overrides Function FormulariManteniment() As Type
        Return GetType(frmFurgoneta_Ruta)
    End Function

#End Region

#Region "Consultas"

    Public Enum Consultas
        Defecte = 0
        Visualitzacio = 1
        Historic = 2
    End Enum

    Public Overrides Function Seleccionar_Consulta(IdConsulta As Integer, Optional oParams As Object() = Nothing) As String
        Dim sRes As String = String.Empty

        Select Case IdConsulta
            Case Consultas.Defecte
                sRes = ConsultaSelectTots()

            Case Consultas.Visualitzacio
                sRes = ConsultaSelectVisualitzacio()

            Case Consultas.Historic
                sRes = ConsultaSelectVisualitzacioHistoric()
        End Select

        Return sRes
    End Function

    Public Shared Function ConsultaSelectTots()
        Return "SELECT * FROM " & NOM_TAULA
    End Function

    Public Shared Function ConsultaSelectVisualitzacio()
        Return "SELECT        dbo.Furgoneta_Ruta.IdFurgoneta_Ruta, dbo.Furgonetas.Nombre, dbo.Furgonetas.Marca, dbo.Furgonetas.Modelo, dbo.Furgonetas.Matricula, dbo.Rutas.Nom, dbo.Trabajadores.Nombre AS NombreTrab, 
                         dbo.Trabajadores.Apellidos, dbo.Furgoneta_Ruta.FechaRuta
                        FROM            dbo.Furgoneta_Ruta INNER JOIN
                         dbo.Furgonetas ON dbo.Furgoneta_Ruta.IdFurgoneta = dbo.Furgonetas.IdFurgoneta INNER JOIN
                         dbo.Rutas ON dbo.Furgoneta_Ruta.IdRuta = dbo.Rutas.IdRuta INNER JOIN
                         dbo.Trabajadores ON dbo.Furgoneta_Ruta.IdTrabajador = dbo.Trabajadores.IdTrabajador WHERE CONVERT(date, dbo.Furgoneta_Ruta.FechaRuta) = CONVERT(date, GETDATE()); "
    End Function


    Public Shared Function ConsultaSelectVisualitzacioHistoric()
        Return "SELECT        dbo.Furgoneta_Ruta.IdFurgoneta_Ruta, dbo.Furgonetas.Nombre, dbo.Furgonetas.Marca, dbo.Furgonetas.Modelo, dbo.Furgonetas.Matricula, dbo.Rutas.Nom, dbo.Trabajadores.Nombre AS NombreTrab, 
                         dbo.Trabajadores.Apellidos, dbo.Furgoneta_Ruta.FechaRuta
                        FROM            dbo.Furgoneta_Ruta INNER JOIN
                         dbo.Furgonetas ON dbo.Furgoneta_Ruta.IdFurgoneta = dbo.Furgonetas.IdFurgoneta INNER JOIN
                         dbo.Rutas ON dbo.Furgoneta_Ruta.IdRuta = dbo.Rutas.IdRuta INNER JOIN
                         dbo.Trabajadores ON dbo.Furgoneta_Ruta.IdTrabajador = dbo.Trabajadores.IdTrabajador"
    End Function



    Public Overrides Function NomCampMostrar(sCamp As String) As String
        Dim nombreTraducido As String = ""

        Select Case sCamp
            Case "IdFurgoneta_Ruta"
                nombreTraducido = fnTraductor.RetornaIdiomaSeleccionat("Id Furgoneta Ruta", "Id Furgoneta Ruta")
            Case "IdFurgoneta"
                nombreTraducido = fnTraductor.RetornaIdiomaSeleccionat("Id Furgoneta", "Id Furgoneta")
            Case "IdRuta"
                nombreTraducido = fnTraductor.RetornaIdiomaSeleccionat("Id Ruta", "Id Ruta")
            Case "Nombre"
                nombreTraducido = fnTraductor.RetornaIdiomaSeleccionat("Nombre Furgoneta", "Nom Furgoneta")
            Case "Marca"
                nombreTraducido = fnTraductor.RetornaIdiomaSeleccionat("Marca", "Marca")
            Case "Modelo"
                nombreTraducido = fnTraductor.RetornaIdiomaSeleccionat("Modelo", "Model")
            Case "Matricula"
                nombreTraducido = fnTraductor.RetornaIdiomaSeleccionat("Matricula", "Matrícula")
            Case "Nom"
                nombreTraducido = fnTraductor.RetornaIdiomaSeleccionat("Nombre Ruta", "Nom Ruta")
            Case "NombreTrab"
                nombreTraducido = fnTraductor.RetornaIdiomaSeleccionat("Nombre Trabajador", "Nom Treballador")
            Case "FechaRuta"
                nombreTraducido = fnTraductor.RetornaIdiomaSeleccionat("Fecha Ruta", "Data Ruta")
            Case Else
                nombreTraducido = sCamp
        End Select

        Return nombreTraducido
    End Function

#End Region

End Class
