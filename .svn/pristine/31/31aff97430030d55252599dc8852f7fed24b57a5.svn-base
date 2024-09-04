Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Data.SqlClient
Imports DocumentFormat.OpenXml.Spreadsheet

Public Class clsPoblacions
    Inherits BDRecord

#Region "Atributos i Constantes"
    Public Shared Shadows ReadOnly NOM_TAULA As String = "Poblacions"
    Public Shared Shadows ReadOnly NOM_PK As String = "IdPoblacio"

    Public Shared NOM_CLASSE_CAT = "Poblacions"
    Public Shared NOM_CLASSE_ES = "Poblaciones"
    Public Property sNomPoblacio As String
    Public Property sCodPostal As String
#End Region

#Region "Constructores"
    Public Sub New()
        MyBase.New(NOM_TAULA, NOM_PK)

        Me.sNomPoblacio = String.Empty
        Me.sCodPostal = String.Empty
    End Sub
#End Region

#Region "Propiedades"
    Public Property NomPoblacio As String
        Get
            Return sNomPoblacio
        End Get
        Set(value As String)
            sNomPoblacio = value
        End Set
    End Property

    Public Property CodPostal As String
        Get
            Return sCodPostal
        End Get
        Set(value As String)
            sCodPostal = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Overrides Function FormulariManteniment() As Type
        Return Nothing
    End Function

    Public Overrides Sub CopiarDatosDesdeDataReader(reader As SqlDataReader)
        Me.sNomPoblacio = Convert.ToString(reader("NomPoblacio"))
        Me.sCodPostal = Convert.ToString(reader("CodPostal"))
    End Sub

    Public Overrides Sub CopiarDatosADataRow(drw As DataRow)
        drw("NomPoblacio") = Me.sNomPoblacio
        drw("CodPostal") = Me.sCodPostal
    End Sub

    Public Sub CopiarDataRowADatos(drw As DataRow)
        Me.sNomPoblacio = Convert.ToString(drw("NomPoblacio"))
        Me.sCodPostal = Convert.ToString(drw("CodPostal"))
    End Sub
#End Region

#Region "Consultes"

    Public Overrides Function NomCampMostrar(nombreAtributo As String) As String
        Dim nombreColumna As String = ""

        Select Case nombreAtributo
            Case "IdPoblacio"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Id Población", "Id Població")
            Case "NomPoblacio"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Nombre Población", "Nom Població")
            Case "CodPostal"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Código Postal", "Codi Postal")
            Case Else
                nombreColumna = nombreAtributo
        End Select

        Return nombreColumna
    End Function

    Public Shared Function ConsultaSelectTots() As String
        Return "SELECT IdPoblacio, NomPoblacio, CodPostal FROM Poblacions WITH (NOLOCK)"
    End Function

    Public Shared Function ConsultaSelectPorId(ByVal Id As Integer) As String
        Return "SELECT IdPoblacio, NomPoblacio, CodPostal FROM Poblacions WITH (NOLOCK) WHERE IdPoblacio = " & Id
    End Function

    Public Shared Function ConsultaSelectPorNombre(ByVal Nombre As String) As String
        Return "SELECT IdPoblacio, NomPoblacio, CodPostal FROM Poblacions WITH (NOLOCK) WHERE NomPoblacio LIKE '%" & Nombre & "%'"
    End Function

    Public Shared Function ConsultaSelectPorCodigoPostal(ByVal CodigoPostal As String) As String
        Return "SELECT IdPoblacio, NomPoblacio, CodPostal FROM Poblacions WITH (NOLOCK) WHERE CodPostal = '" & CodigoPostal & "'"
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
