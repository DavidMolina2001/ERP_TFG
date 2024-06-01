﻿Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip
Imports Microsoft.Data.SqlClient
Imports Syncfusion.WinForms.DataGrid

Public Class frmClients

#Region "Atributs"

    Private oDades As clsClients
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
        oDades = New clsClients

        iId = _Id

        If _Id = 0 Then
            bEsAlta = True
        Else
            bEsAlta = False

        End If

    End Sub
#End Region

#Region "Metodes"

    Public Function TryLoad() As Boolean

        Dim bTryload As Boolean 'Variable que indica si ha cargao bien el frm.

        Try

            ActualitzarIdiomaControls(Me, clsConstants.Idioma)

            Inicialitzacions() 'Inicialitzacions del formulari abans de carregar res.

            If bEsAlta Then




            Else
                CargarTarifas()
                LlegirDades()
                CargarEnvios()
                CargarFacturas()

            End If

            bTryload = True

            Me.Text = fnTraductor.RetornaIdiomaSeleccionat("Cliente", "Client")

        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al cargar el formulario.",
                                                                      "Error al carregar el formulari."), ex)
            bTryload = False
        End Try

        Return bTryload
    End Function

    Private Sub LlegirDades()

        Try
            oDades.Llegir(iId)

            CopiarDadesAControls()


        Catch ex As Exception
            Throw New Exception("Error frmEnvios.LlegirDades")
        End Try

    End Sub


    Private Sub CopiarControlsADades()
        oDades.NomClient = tbxNom.Text
        oDades.Mail = tbxMail.Text
        oDades.IdTarifaPreferida = cmbxTarifas.SelectedIndex + 1
        oDades.EsComercial = cbxEsComercial.Checked
        oDades.DireccionOrigenFavorita = tbxDireccionOrigen.Text
        oDades.NIF = tbxNIF.Text
        oDades.Idioma = IIf(cmbxIdioma.SelectedIndex = 0, "E", "C")
        oDades.Observaciones = tbxObservaciones.Text
    End Sub

    Private Sub CopiarDadesAControls()
        tbxNom.Text = oDades.NomClient
        tbxMail.Text = oDades.Mail
        cmbxTarifas.SelectedIndex = oDades.IdTarifaPreferida - 1
        cbxEsComercial.Checked = oDades.EsComercial
        tbxDireccionOrigen.Text = oDades.DireccionOrigenFavorita
        tbxNIF.Text = oDades.NIF
        cmbxIdioma.SelectedIndex = IIf(oDades.Idioma.StartsWith("E"), 0, 1)
        tbxObservaciones.Text = oDades.Observaciones
    End Sub

    Private Sub Inicialitzacions()

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

    Dim lstTarifas As List(Of String) = Nothing
    Private Sub CargarTarifas()

        Dim dt As DataTable = Nothing

        Try

            dt = SQLReader.ReaderDataTable(oConn, Nothing, "SELECT Nom FROM Tarifas")

            lstTarifas = New List(Of String)

            For Each oRow In dt.Rows
                lstTarifas.Add(oRow("Nom"))
            Next

            cmbxTarifas.DataSource = lstTarifas

            cmbxIdioma.Items.Add("Español")
            cmbxIdioma.Items.Add("Català")

        Catch ex As Exception
            Throw New Exception("Error frmEnvios.CargarTarifas")
        Finally
            If dt IsNot Nothing Then
                dt.Clear()
                dt.Dispose()
                dt = Nothing
            End If
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
            CopiarControlsADades()

            oDades.Escriure(bEsAlta)

            bGuardar = True

            btnBorrar.Enabled = True

        Catch ex As Exception

            Throw New Exception("Error frmEnvios.Guardar")
            bGuardar = False

        End Try


        Return bGuardar

    End Function

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub frmGeneric_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If dtEnvios IsNot Nothing Then
            dtEnvios.Clear()
            dtEnvios.Dispose()
            dtEnvios = Nothing
        End If
    End Sub

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



#End Region

#Region "Envios"
    Dim dtEnvios As DataTable = Nothing
    Private Sub CargarEnvios()
        Dim oClase As clsEnvios = Nothing
        Try

            dtEnvios = SQLReader.ReaderDataTable(oConn, Nothing, clsEnvios.ConsultaSelectSegunCliente(oDades.Id))
            oClase = New clsEnvios

            dgEnvios.DataSource = dtEnvios

            For Each columna As GridColumn In dgEnvios.Columns

                Dim nombreActual As String = columna.HeaderText

                Dim nombreTraducido As String = oClase.NomCampMostrar(nombreActual)

                columna.HeaderText = nombreTraducido
            Next

        Catch ex As Exception
            Throw New Exception("Error frmClients.CargarEnvios", ex)
        Finally
            If oClase IsNot Nothing Then
                oClase = Nothing
            End If
        End Try
    End Sub


#End Region

#Region "Facturas"
    Dim dtFacturas As DataTable = Nothing
    Private Sub CargarFacturas()
        Dim oClase As clsFacturas = Nothing
        Try

            dtFacturas = SQLReader.ReaderDataTable(oConn, Nothing, clsFacturas.ConsultaSelectPorCliente(oDades.Id))
            oClase = New clsFacturas

            dgFacturas.DataSource = dtFacturas

            For Each columna As GridColumn In dgFacturas.Columns

                Dim nombreActual As String = columna.HeaderText

                Dim nombreTraducido As String = oClase.NomCampMostrar(nombreActual)

                columna.HeaderText = nombreTraducido
            Next

        Catch ex As Exception
            Throw New Exception("Error frmClients.CargarFacturas", ex)
        Finally
            If oClase IsNot Nothing Then
                oClase = Nothing
            End If
        End Try
    End Sub


#End Region


End Class