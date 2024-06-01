Imports Microsoft.Data.SqlClient

Public Class clsFurgonetas
    Inherits BDRecord

#Region "Atributos y Constantes"

    Public Shared Shadows ReadOnly NOM_TAULA As String = "Furgonetas"
    Public Shared Shadows ReadOnly NOM_PK As String = "IdFurgoneta"

    Public Shared NOM_CLASSE_CAT = "Furgonetes"
    Public Shared NOM_CLASSE_ES = "Furgonetas"

    Private sNombre As String
    Private sMarca As String
    Private sModelo As String
    Private iKilometros As Integer
    Private sMatricula As String

#End Region

#Region "Constructores"

    Public Sub New()
        MyBase.New(NOM_TAULA, NOM_PK)

        sNombre = String.Empty
        sMarca = String.Empty
        sModelo = String.Empty
        iKilometros = 0
        sMatricula = String.Empty
    End Sub

#End Region

#Region "Propiedades"

    Public Property Nombre As Object
        Get
            Return sNombre
        End Get
        Set(value As Object)
            sNombre = value
        End Set
    End Property

    Public Property Marca As String
        Get
            Return sMarca
        End Get
        Set(value As String)
            sMarca = value
        End Set
    End Property

    Public Property Modelo As String
        Get
            Return sModelo
        End Get
        Set(value As String)
            sModelo = value
        End Set
    End Property

    Public Property Kilometros As Integer
        Get
            Return iKilometros
        End Get
        Set(value As Integer)
            iKilometros = value
        End Set
    End Property

    Public Property Matricula As String
        Get
            Return sMatricula
        End Get
        Set(value As String)
            sMatricula = value
        End Set
    End Property

#End Region

#Region "Metodos"

    Public Overrides Sub CopiarDatosDesdeDataReader(reader As SqlDataReader)
        Me.sNombre = Convert.ToString(reader("Nombre"))
        Me.sMarca = Convert.ToString(reader("Marca"))
        Me.sModelo = Convert.ToString(reader("Modelo"))
        Me.iKilometros = Convert.ToInt32(reader("Kilometros"))
        Me.sMatricula = Convert.ToString(reader("Matricula"))
    End Sub

    Public Overrides Sub CopiarDatosADataRow(drw As DataRow)
        drw("Nombre") = Me.sNombre
        drw("Marca") = Me.sMarca
        drw("Modelo") = Me.sModelo
        drw("Kilometros") = Me.iKilometros
        drw("Matricula") = Me.sMatricula
    End Sub

    Public Overrides Function FormulariManteniment() As Type
        Return GetType(frmFurgonetas)
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
        Return "SELECT t.IdFurgoneta, t.Nombre
                FROM dbo.Furgonetas t
                LEFT JOIN Furgoneta_Ruta fr ON t.IdFurgoneta = fr.IdFurgoneta AND CONVERT(date, fr.FechaRuta) = CONVERT(date, GETDATE())
                WHERE fr.IdFurgoneta IS NULL;"
    End Function


    Public Overrides Function NomCampMostrar(sCamp As String) As String
        Dim nombreTraducido As String = ""

        Select Case sCamp
            Case "IdFurgoneta"
                nombreTraducido = fnTraductor.RetornaIdiomaSeleccionat("Id Furgoneta", "Id Furgoneta")
            Case "Nombre"
                nombreTraducido = fnTraductor.RetornaIdiomaSeleccionat("Nombre Furgoneta", "Nom Furgoneta")
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
