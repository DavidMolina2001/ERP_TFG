﻿Imports Microsoft.Data.SqlClient
Imports Newtonsoft.Json

Public Class frmAltaRapida

#Region "Atributs"

    Private oConn As SqlConnection
#End Region

#Region "Constructor"
    Public Sub New(_oConn As SqlConnection)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Me.oConn = _oConn

        Me.Text = fnTraductor.RetornaIdiomaSeleccionat("Alta Rápida", "Alta Ràpida")


    End Sub
#End Region

#Region "Metodes"

    Public Function TryLoad() As Boolean

        Dim bTryload As Boolean 'Variable que indica si ha cargao bien el frm.

        Try

            ActualitzarIdiomaControls(Me, clsConstants.Idioma)

            Inicialitzacions() 'Inicialitzacions del formulari abans de carregar res.



            bTryload = True


        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al cargar el formulario.",
                                                                      "Error al carregar el formulari."), ex)
            bTryload = False
        End Try

        Return bTryload
    End Function

    Private lstEstados As List(Of Integer)
    Private lstPoblaciones As List(Of String)
    Private lstClientes As List(Of Integer)
    Private dicRutas As Dictionary(Of Integer, List(Of String))
    Private dtEnvios As DataTable = Nothing
    Private oGenerador As GeneradorEnvios = Nothing

    Private Sub Inicialitzacions()

        LlenarListas()


        oGenerador = New GeneradorEnvios(lstEstados, lstClientes, dicRutas)

    End Sub

    Private Sub LlenarListas()
        lstEstados = New List(Of Integer)()
        lstClientes = New List(Of Integer)()
        dicRutas = New Dictionary(Of Integer, List(Of String))()
        lstPoblaciones = New List(Of String)
        Dim dt As DataTable = Nothing
        Dim oClase As clsEnvios = Nothing
        Try

            dtEnvios = SQLReader.ReaderDataTable(oConn, Nothing, "SELECT * FROM Envios WHERE (1=0)")

            oClase = New clsEnvios

            dg_Envios.DataSource = dtEnvios



            For Each columna As Syncfusion.WinForms.DataGrid.GridColumn In dg_Envios.Columns
                Dim nombreActual As String = columna.HeaderText

                If nombreActual = oClase.NOM_PK Or nombreActual = "IdEnvio" Then
                    columna.Visible = False
                End If

                Dim nombreTraducido As String = oClase.NomCampMostrar(nombreActual)

                columna.HeaderText = nombreTraducido

            Next
            dg_Envios.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCells


            dt = SQLReader.ReaderDataTable(oConn, Nothing, "SELECT IdEstado FROM Envios_Estados")
            For Each row As DataRow In dt.Rows
                lstEstados.Add(Convert.ToInt32(row("IdEstado")))
            Next

            dt = SQLReader.ReaderDataTable(oConn, Nothing, "SELECT IdClient FROM Clients")
            For Each row As DataRow In dt.Rows
                lstClientes.Add(Convert.ToInt32(row("IdClient")))
            Next

            dt = SQLReader.ReaderDataTable(oConn, Nothing, "SELECT IdRuta, Poblaciones FROM Rutas")
            For Each row As DataRow In dt.Rows
                Dim lstTemp As List(Of String) = JsonConvert.DeserializeObject(Of List(Of String))(row("Poblaciones"))
                lstPoblaciones.AddRange(lstTemp)
                dicRutas.Add(Convert.ToInt32(row("IdRuta")), lstTemp)
            Next





        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al cargar las listas.",
                                                                      "Error al carregar les llistes."), ex)
        Finally
            If dt IsNot Nothing Then
                dt.Clear()
                dt.Dispose()
                dt = Nothing
            End If
        End Try


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


#End Region

#Region "Control Botons"

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Guardar() Then
            Me.Close()
            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    Private Function Guardar() As Boolean



    End Function

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub frmGeneric_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub

    Private Sub btnAfegir_Click(sender As Object, e As EventArgs) Handles btnAfegir.Click


        Try

            If tbxEnvio.Text = String.Empty Then
                frmMissatge.MostrarAvis(fnTraductor.RetornaIdiomaSeleccionat("Entra un envío",
                                                                             "Entra un enviament"))
                Exit Sub
            End If
            Dim oRow As DataRow = dtEnvios.NewRow

            If cbxRecuperarPlataforma.Checked Then
                oGenerador.GenerarEnvio(oRow, tbxEnvio.Text)
            Else
                oRow("CodigoSeguimiento") = tbxEnvio.Text
            End If


            dtEnvios.Rows.Add(oRow)


        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al recuperar la información del envío.",
                                                                      "Error al recuperar la informació de l'enviament."), ex)
        End Try
    End Sub

    Private Sub btnTreureSeleccionat_Click(sender As Object, e As EventArgs) Handles btnTreureSeleccionat.Click
        Try
            If dtEnvios.Rows.Count = 0 Then
                frmMissatge.MostrarAvis(fnTraductor.RetornaIdiomaSeleccionat("No hay ningun item que borrar",
                                                                              "No hi ha cap item que esborrar"))
                Exit Sub
            End If

            If dg_Envios.SelectedItems.Count > 0 Then
                dtEnvios.Rows.RemoveAt(dg_Envios.CurrentCell.RowIndex - 1)
            End If
            '

        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al quitar el envío.",
                                                                      "Error al treure l'enviament."), ex)
        End Try
    End Sub

    Private Sub dg_Envios_CurrentCellEndEdit(sender As Object, e As Syncfusion.WinForms.DataGrid.Events.CurrentCellEndEditEventArgs) Handles dg_Envios.CurrentCellEndEdit
        Try
            If e.DataColumn.ColumnIndex = 3 Then 'Solo poblaciones
                Dim sPoblacion As String = e.DataRow.RowData.Row.ItemArray(3).ToString()
                If lstPoblaciones.Exists(Function(x) x.Equals(sPoblacion, StringComparison.OrdinalIgnoreCase)) Then

                    Dim b As Boolean = True
                Else

                    frmMissatge.MostrarAvis(fnTraductor.RetornaIdiomaSeleccionat("La población entrada no existe en nuestras rutas",
                                                                                 "La població entrada no existeix en les nostres rutes"))
                End If
            End If
        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al comprobar la población de destino.",
                                                                      "Error al comprovar la població de destí."), ex)
        End Try
    End Sub




#End Region


End Class