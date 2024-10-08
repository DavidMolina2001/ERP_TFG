﻿Imports Microsoft.Data.SqlClient

Public Class clsFactura_Linia
    Inherits BDRecord

#Region "Atributos y Constantes"

    Public Shared Shadows ReadOnly NOM_TAULA As String = "Factura_Linia"
    Public Shared Shadows ReadOnly NOM_PK As String = "IdFactura_Linia"

    Private iIdFactura As Integer
    Private iIdEnvio As Integer
    Private sDescripcion As String
    Private iIdTipoImpositivo As Integer

#End Region

#Region "Constructores"

    Public Sub New()
        MyBase.New(NOM_TAULA, NOM_PK)

        Me.iIdFactura = 0
        Me.iIdEnvio = 0
        Me.sDescripcion = String.Empty
        Me.iIdTipoImpositivo = 0
    End Sub

#End Region

#Region "Propiedades"

    Public Property IdFactura As Integer
        Get
            Return iIdFactura
        End Get
        Set(value As Integer)
            iIdFactura = value
        End Set
    End Property

    Public Property IdEnvio As Integer
        Get
            Return iIdEnvio
        End Get
        Set(value As Integer)
            iIdEnvio = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return sDescripcion
        End Get
        Set(value As String)
            sDescripcion = value
        End Set
    End Property

    Public Property IdTipoImpositivo As Integer
        Get
            Return iIdTipoImpositivo
        End Get
        Set(value As Integer)
            iIdTipoImpositivo = value
        End Set
    End Property

#End Region

#Region "Métodos"

    Public Overrides Sub CopiarDatosDesdeDataReader(reader As SqlDataReader)
        Me.IdFactura = Convert.ToInt32(reader("IdFactura"))
        Me.IdEnvio = Convert.ToInt32(reader("IdEnvio"))
        Me.Descripcion = Convert.ToString(reader("Descripcion"))
        Me.IdTipoImpositivo = Convert.ToInt32(reader("IdTipoImpositivo"))
    End Sub

    Public Overrides Sub CopiarDatosADataRow(drw As DataRow)
        drw("IdFactura") = Me.IdFactura
        drw("IdEnvio") = Me.IdEnvio
        drw("Descripcion") = Me.Descripcion
        drw("IdTipoImpositivo") = Me.IdTipoImpositivo
    End Sub

    Public Overrides Function FormulariManteniment() As Type
        ' No se ha proporcionado una clase para el formulario de mantenimiento.
        Return Nothing
    End Function

#End Region

#Region "Consultas"

    Public Overrides Function Seleccionar_Consulta(IdConsulta As Integer, Optional oParams As Object() = Nothing) As String
        Dim sRes As String = String.Empty
        Return sRes
    End Function

    Public Shared Function ConsultaSelectTots() As String
        Return "SELECT * FROM " & NOM_TAULA
    End Function

    Public Shared Function ConsultaSegonsFactura(IdFactura As Integer) As String
        Dim sRes As String = String.Empty
        sRes = "SELECT Factura_Linia.IdFactura_Linia, Envios.CodigoSeguimiento, Factura_Linia.IdEnvio, Envios.Porte, Factura_Linia.Descripcion, IVA.Porcentaje
                FROM Factura_Linia WITH (NOLOCK) INNER JOIN
                Envios ON Factura_Linia.IdEnvio = Envios.IdEnvio INNER JOIN
                IVA ON Factura_Linia.IdTipoImpositivo = IVA.IdTipoImpositivo WHERE IdFactura = " & IdFactura
        Return sRes
    End Function

    Public Overrides Function NomCampMostrar(nombreAtributo As String) As String
        Dim nombreColumna As String = ""

        Select Case nombreAtributo
            Case "IdFactura"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Id Factura", "Id Factura")

            Case "CodigoSeguimiento"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Código Seguimiento", "Codi Seguiment")
            Case "Porcentaje"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("IVA Aplicado", "IVA Aplicat")

            Case "IdEnvio"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Id Envío", "Id Enviament")
            Case "Descripcion"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Descripción", "Descripció")
            Case "IdTipoImpositivo"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Id Tipo Impositivo", "Id Tipus Impositiu")
            Case "Porte"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Porte", "Port")

            Case Else
                nombreColumna = nombreAtributo
        End Select

        Return nombreColumna
    End Function


#End Region

End Class
