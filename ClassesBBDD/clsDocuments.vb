Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Data.SqlClient
Imports DocumentFormat.OpenXml.Spreadsheet

Public Class clsDocuments
    Inherits BDRecord

#Region "Atributos i Constantes"
    Public Shared Shadows ReadOnly NOM_TAULA As String = "Documents"
    Public Shared Shadows ReadOnly NOM_PK As String = "IdDocument"

    Public Shared NOM_CLASSE_CAT = "Documents"
    Public Shared NOM_CLASSE_ES = "Documentos"
    Private sNomDocument As String
    Private sRutaDocument As String
    Private cTipusDocument As Byte

#End Region

#Region "Constructores"
    Public Sub New()
        MyBase.New(NOM_TAULA, NOM_PK)

        Me.sNomDocument = String.Empty
        Me.sRutaDocument = String.Empty
        Me.cTipusDocument = 0
    End Sub
#End Region

#Region "Propiedades"
    Public Property NomDocument As String
        Get
            Return sNomDocument
        End Get
        Set(value As String)
            sNomDocument = value
        End Set
    End Property

    Public Property RutaDocument As String
        Get
            Return sRutaDocument
        End Get
        Set(value As String)
            sRutaDocument = value
        End Set
    End Property

    Public Property TipusDocument As Byte
        Get
            Return cTipusDocument
        End Get
        Set(value As Byte)
            cTipusDocument = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Overrides Function FormulariManteniment() As Type
        Return Nothing
    End Function

    Public Overrides Sub CopiarDatosDesdeDataReader(reader As SqlDataReader)
        Me.sNomDocument = Convert.ToString(reader("NomDocument"))
        Me.sRutaDocument = Convert.ToString(reader("RutaDocument"))
        Me.cTipusDocument = Convert.ToByte(reader("TipusDocument"))

    End Sub

    Public Overrides Sub CopiarDatosADataRow(drw As DataRow)
        drw("NomDocument") = Me.sNomDocument
        drw("RutaDocument") = Me.sRutaDocument
        drw("TipusDocument") = Me.cTipusDocument

    End Sub

    Public Sub CopiarDataRowADatos(drw As DataRow)
        Me.sNomDocument = Convert.ToString(drw("NomDocument"))
        Me.sRutaDocument = Convert.ToString(drw("RutaDocument"))
        Me.cTipusDocument = Convert.ToByte(drw("TipusDocument"))
    End Sub
#End Region

#Region "Consultes"

    Public Overrides Function NomCampMostrar(nombreAtributo As String) As String
        Dim nombreColumna As String = ""

        Select Case nombreAtributo
            Case "IdDocument"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Id Document", "Id Documento")
            Case "NomDocument"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Nombre Document", "Nom Documento")
            Case "RutaDocument"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Ruta Document", "Ruta Documento")
            Case "TipusDocument"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Tipus Document", "Tipo Documento")
            Case Else
                nombreColumna = nombreAtributo
        End Select

        Return nombreColumna
    End Function

    Public Shared Function ConsultaSelectTots() As String
        ' Recuperar los textos traducidos
        Dim sTipusExcelEnv As String = fnTraductor.RetornaIdiomaSeleccionat("Excel Envíos", "Excel Enviaments")
        Dim sTipusExcelCli As String = fnTraductor.RetornaIdiomaSeleccionat("Excel Clientes", "Excel Clients")
        Dim sTipusWordFact As String = fnTraductor.RetornaIdiomaSeleccionat("Word Facturas", "Word Factures")

        ' Construir la consulta SQL con CASE para mostrar el tipo como texto
        Return $"
    SELECT 
        IdDocument, 
        NomDocument, 
        RutaDocument, 
        CASE 
            WHEN TipusDocument = 0 THEN '{sTipusExcelEnv}'
            WHEN TipusDocument = 1 THEN '{sTipusExcelCli}'
            WHEN TipusDocument = 2 THEN '{sTipusWordFact}'
        END AS TipusDocument
    FROM Documents
    WITH (NOLOCK)
    "
    End Function

    Public Enum Consultas
        Defecte = 0
    End Enum

    Public Overrides Function Seleccionar_Consulta(IdConsulta As Integer, Optional oParams() As Object = Nothing) As String
        Dim sRes As String = String.Empty
        Select Case IdConsulta
            Case Consultas.Defecte
                sRes = ConsultaSelectTots()

        End Select
        Return sRes
    End Function
#End Region


End Class
