Imports Microsoft.Data
Public Class clsConstants
    Public Const VERSIO_MAJOR As Integer = 1
    Public Const VERSIO_MINOR As Integer = 0
    Public Const VERSIO_BUILD As Integer = 5


    Private Shared _Idioma As String
    Public Shared Property Idioma As String
        Get
            If _Idioma Is Nothing Then
                Return "C"
            Else
                Return _Idioma
            End If

        End Get
        Set(value As String)
            _Idioma = value
        End Set
    End Property

    Public Shared Property ConnGlobal As SqlClient.SqlConnection
    Public Shared Property PathEtiquetas As String

    Public Shared Property LDAP As Boolean
    Public Shared Property PathFactCAT As String

    Public Shared Property PathFactCAS As String

    Public Shared Property PathExcelEnviosCAT As String

    Public Shared Property PathExcelEnviosCAS As String

    Public Shared Property PathExcelFacturasCAT As String

    Public Shared Property PathExcelFacturasCAS As String

    Public Shared Property PathGuardadoFacturas As String

    Public Shared Property PathGuardadoInformes As String


End Class
