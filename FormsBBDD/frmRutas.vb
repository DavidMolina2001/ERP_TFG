Imports System.ComponentModel
Imports Microsoft.Data.SqlClient
Imports Newtonsoft.Json
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.WinForms.DataGrid
Imports Syncfusion.WinForms.DataGrid.Enums

Public Class frmRutas

#Region "Atributs"

    Public oDades As clsRutas
    Private oConn As SqlConnection
    Private bEsAlta As Boolean
    Private iId As Integer
#End Region

#Region "Constructor"
    Public Sub New(_oConn As SqlConnection, _Id As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Me.oConn = _oConn
        oDades = New clsRutas
        iId = _Id
        lstPoblaciones = New List(Of String)

        If _Id = 0 Then
            bEsAlta = True
        Else
            bEsAlta = False

        End If

    End Sub

    Public Class Poblacio
        Public Property Nombre As String

    End Class


#End Region

#Region "Metodes"

    Public Function TryLoad() As Boolean

        Dim bTryload As Boolean 'Variable que indica si ha cargao bien el frm.

        Try

            ActualitzarIdiomaControls(Me, clsConstants.Idioma)

            Inicialitzacions() 'Inicialitzacions del formulari abans de carregar res.

            If bEsAlta Then




            Else

                LlegirDades()



            End If

            dgPoblaciones.AddNewRowText = fnTraductor.RetornaIdiomaSeleccionat("Haz click aqui para añadir una población nueva",
                                                                                "Fes click aquí per afegir una població nova")

            bTryload = True

        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al cargar el formulario.",
                                                                      "Error al carregar el formulari."), ex)
            bTryload = False
        End Try

        Return bTryload
    End Function

    Private lstPoblaciones As List(Of String) = Nothing

    Private Sub LlegirDades()

        Try
            oDades.Llegir(iId)

            CopiarDadesAControls()


            RellenarPrimeraColumna(lstPoblaciones)


        Catch ex As Exception
            Throw New Exception("Error frmEnvios.LlegirDades")
        End Try

    End Sub


    Private Sub CopiarControlsADades()
        oDades.Nom = tbxNomRuta.Text
        oDades.Poblaciones = JsonConvert.SerializeObject(lstPoblaciones)

    End Sub

    Private Sub CopiarDadesAControls()
        tbxNomRuta.Text = oDades.Nom
        lstPoblaciones = JsonConvert.DeserializeObject(Of List(Of String))(oDades.Poblaciones)


    End Sub

    Private Sub Inicialitzacions()

        Me.Text = fnTraductor.RetornaIdiomaSeleccionat("Rutas", "Rutes")



    End Sub


    Private Sub ActualitzarIdiomaControls(ByVal frm As Control, ByVal sIdioma As String)
        For Each ctrl As Control In frm.Controls
            If TypeOf ctrl Is LabelMultiIdioma Then
                DirectCast(ctrl, LabelMultiIdioma).CambiarIdioma(sIdioma)

            ElseIf TypeOf ctrl Is ButtonMultiIdioma Then
                DirectCast(ctrl, ButtonMultiIdioma).CambiarIdioma(sIdioma)


            ElseIf ctrl.HasChildren Then
                ActualitzarIdiomaControls(ctrl, sIdioma)
            End If
        Next
    End Sub

    Private Sub GuardarLista()
        Try
            lstPoblaciones.Clear()

            For Each item As Object In dgPoblaciones.View.Records

                Dim s As Type = item.GetType()
                Dim cellValue As Object = item.Data.Row.Item(0)
                If cellValue IsNot Nothing Then
                    lstPoblaciones.Add(cellValue.ToString())
                End If
            Next

        Catch ex As Exception
            Throw New Exception("Error al guardar la lista de poblaciones: " & ex.Message)
        End Try
    End Sub


    Dim dt As DataTable = Nothing
    Private Sub RellenarPrimeraColumna(ByVal lista As List(Of String))
        Try
            dt = New DataTable
            dt.Columns.Add()

            For Each item In lista
                dt.Rows.Add(item)
            Next


            dgPoblaciones.DataSource = dt

            dgPoblaciones.Columns(0).HeaderText = fnTraductor.RetornaIdiomaSeleccionat("Población", "Població")

        Catch ex As Exception
            Throw New Exception("Error al rellenar la primera columna: " & ex.Message)
        End Try
    End Sub


#End Region

#Region "Control Botons"

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Guardar() Then
            Me.Close()
            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    Private Function Guardar() As Boolean

        Dim bGuardar As Boolean

        Try

            GuardarLista()

            CopiarControlsADades()

            oDades.Escriure(bEsAlta)

            bGuardar = True

        Catch ex As Exception

            Throw New Exception("Error frmEnvios.Guardar")
            bGuardar = False

        End Try


        Return bGuardar

    End Function

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click

        Try
            If frmMissatge.MostrarPreguntaSiNo(fnTraductor.RetornaIdiomaSeleccionat("¿Estás seguro de borrar este registro?",
                                                                                     "Estàs segur d'esborrar aquest registre?")) Then

                oDades.Esborrar()
                Me.Close()


            End If
        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al borrar el registro", "Error al esborrar el registre"), ex)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub frmRutas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If lstPoblaciones IsNot Nothing Then
            lstPoblaciones.Clear()
            lstPoblaciones = Nothing
        End If

        If dt IsNot Nothing Then
            dt.Clear()
            dt.Dispose()
            dt = Nothing
        End If
    End Sub

    Private Sub dgPoblaciones_AddNewRowInitiating(sender As Object, e As Syncfusion.WinForms.DataGrid.Events.AddNewRowInitiatingEventArgs)
        Try
            lstPoblaciones.Add("")
            dgPoblaciones.Refresh

        Catch ex As Exception

        End Try
    End Sub



#End Region


End Class