Imports Microsoft.Data.SqlClient

Public Class clsEmpresa
    Inherits BDRecord

#Region "Atributos y Constantes"
    Public Shared Shadows ReadOnly NOM_TAULA As String = "Empresa"
    Public Shared Shadows ReadOnly NOM_PK As String = "IdEmpresa"

    Public Shared NOM_CLASSE_CAT = "Empresa"
    Public Shared NOM_CLASSE_ES = "Empresa"

    Private iIdEmpresa As Integer
    Private sCodiIdioma As String
    Private sPathEtiquetas As String
    Private bLDAP As Boolean
    Private sPathFactura_CA As String
    Private sPathFactura_ES As String

#End Region

#Region "Constructores"
    Public Sub New()
        MyBase.New(NOM_TAULA, NOM_PK)

        Me.sCodiIdioma = String.Empty
        Me.sPathEtiquetas = String.Empty
        Me.sPathFactura_CA = String.Empty
        Me.sPathFactura_ES = String.Empty
    End Sub
#End Region

#Region "Propiedades"

    Public Property IdEmpresa As Integer
        Get
            Return iIdEmpresa
        End Get
        Set(value As Integer)
            iIdEmpresa = value
        End Set
    End Property

    Public Property CodiIdioma As String
        Get
            Return sCodiIdioma
        End Get
        Set(value As String)
            sCodiIdioma = value
        End Set
    End Property

    Public Property PathEtiquetas As String
        Get
            Return sPathEtiquetas
        End Get
        Set(value As String)
            sPathEtiquetas = value
        End Set
    End Property

    Public Property LDAP As Boolean
        Get
            Return bLDAP
        End Get
        Set(value As Boolean)
            bLDAP = value
        End Set
    End Property

    Public Property PathFactura_CA As String
        Get
            Return sPathFactura_CA
        End Get
        Set(value As String)
            sPathFactura_CA = value
        End Set
    End Property

    Public Property PathFactura_ES As String
        Get
            Return sPathFactura_ES
        End Get
        Set(value As String)
            sPathFactura_ES = value
        End Set
    End Property

#End Region

#Region "Metodos"
    Public Overrides Sub CopiarDatosDesdeDataReader(reader As SqlDataReader)
        Me.iIdEmpresa = Convert.ToInt32(reader("IdEmpresa"))
        Me.sCodiIdioma = Convert.ToString(reader("CodiIdioma"))
        Me.sPathEtiquetas = Convert.ToString(reader("PathEtiquetas"))
        Me.bLDAP = Convert.ToBoolean(reader("LDAP"))
        Me.sPathFactura_CA = Convert.ToString(reader("PathFactura_CA"))
        Me.sPathFactura_ES = Convert.ToString(reader("PathFactura_ES"))
    End Sub

    Public Overrides Sub CopiarDatosADataRow(drw As DataRow)
        drw("IdEmpresa") = Me.iIdEmpresa
        drw("CodiIdioma") = Me.sCodiIdioma
        drw("PathEtiquetas") = Me.sPathEtiquetas
        drw("LDAP") = Me.bLDAP
        drw("PathFactura_CA") = Me.sPathFactura_CA
        drw("PathFactura_ES") = Me.sPathFactura_ES
    End Sub

    Public Overrides Function FormulariManteniment() As Type
        'Return Nothing

        Return GetType(frmPreferencies)
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
        Return "SELECT IdEmpresa, CodiIdioma, PathEtiquetas, LDAP, PathFactura_CA, PathFactura_ES FROM Empresa"
    End Function

    Public Overrides Function NomCampMostrar(nombreAtributo As String) As String
        Dim nombreColumna As String = ""

        Select Case nombreAtributo
            Case "IdEmpresa"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Id Empresa", "Id Empresa")
            Case "CodiIdioma"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Código Idioma", "Codi Idioma")
            Case "PathEtiquetas"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Path Etiquetas", "Path Etiquetes")
            Case "LDAP"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("LDAP", "LDAP")
            Case "PathFactura_CA"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Path Factura CA", "Path Factura CA")
            Case "PathFactura_ES"
                nombreColumna = fnTraductor.RetornaIdiomaSeleccionat("Path Factura ES", "Path Factura ES")
            Case Else
                nombreColumna = nombreAtributo
        End Select

        Return nombreColumna
    End Function

#End Region

End Class
