Imports Microsoft.Data.SqlClient

Public Class clsTrabajadores
    Inherits BDRecord

#Region "Atributos y Constantes"

    Public Shared Shadows ReadOnly NOM_TAULA As String = "Trabajadores"
    Public Shared Shadows ReadOnly NOM_PK As String = "IdTrabajador"

    Public Shared NOM_CLASSE_CAT = "Treballadors"
    Public Shared NOM_CLASSE_ES = "Trabajadores"

    Private sNombre As String
    Private sApellidos As String
    Private sDNI As String
    Private sMail As String

#End Region

#Region "Constructores"

    Public Sub New()
        MyBase.New(NOM_TAULA, NOM_PK)

        sNombre = String.Empty
        sApellidos = String.Empty
        sDNI = String.Empty
        sMail = String.Empty
    End Sub

#End Region

#Region "Propiedades"

    Public Property Nombre As String
        Get
            Return sNombre
        End Get
        Set(value As String)
            sNombre = value
        End Set
    End Property

    Public Property Apellidos As String
        Get
            Return sApellidos
        End Get
        Set(value As String)
            sApellidos = value
        End Set
    End Property

    Public Property DNI As String
        Get
            Return sDNI
        End Get
        Set(value As String)
            sDNI = value
        End Set
    End Property

    Public Property Mail As String
        Get
            Return sMail
        End Get
        Set(value As String)
            sMail = value
        End Set
    End Property

#End Region

#Region "Metodos"

    Public Overrides Sub CopiarDatosDesdeDataReader(reader As SqlDataReader)
        Me.sNombre = Convert.ToString(reader("Nombre"))
        Me.sApellidos = Convert.ToString(reader("Apellidos"))
        Me.sDNI = Convert.ToString(reader("DNI"))
        Me.sMail = Convert.ToString(reader("Mail"))
    End Sub

    Public Overrides Sub CopiarDatosADataRow(drw As DataRow)
        drw("Nombre") = Me.sNombre
        drw("Apellidos") = Me.sApellidos
        drw("DNI") = Me.sDNI
        drw("Mail") = Me.sMail
    End Sub

    Public Overrides Function FormulariManteniment() As Type
        Return GetType(frmTrabajadores)
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
        Return "SELECT      dbo.Trabajadores.IdTrabajador,  dbo.Trabajadores.Nombre, dbo.Trabajadores.Apellidos
                FROM            dbo.Trabajadores"
    End Function

    Public Shared Function ConsultaSelectSinRuta()
        Return "SELECT t.IdTrabajador, t.Nombre + ' ' + t.Apellidos AS NombreCompleto 
                FROM dbo.Trabajadores t
                LEFT JOIN Furgoneta_Ruta fr ON t.IdTrabajador = fr.IdTrabajador AND CONVERT(date, fr.FechaRuta) = CONVERT(date, GETDATE())
                WHERE fr.IdTrabajador IS NULL;"
    End Function

    Public Overrides Function NomCampMostrar(sCamp As String) As String
        Dim nombreTraducido As String = ""

        Select Case sCamp
            Case "IdTrabajador"
                nombreTraducido = fnTraductor.RetornaIdiomaSeleccionat("Id Trabajador", "Id Treballador")
            Case "Nombre"
                nombreTraducido = fnTraductor.RetornaIdiomaSeleccionat("Nombre", "Nom")
            Case "Apellidos"
                nombreTraducido = fnTraductor.RetornaIdiomaSeleccionat("Apellidos", "Cognoms")
            Case "DNI"
                nombreTraducido = fnTraductor.RetornaIdiomaSeleccionat("DNI", "DNI")
            Case "Mail"
                nombreTraducido = fnTraductor.RetornaIdiomaSeleccionat("Mail", "Correu electrònic")
            Case Else
                nombreTraducido = sCamp
        End Select

        Return nombreTraducido
    End Function

#End Region

End Class