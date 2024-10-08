﻿Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip
Imports Microsoft.Data
Imports Independentsoft.Office.Spreadsheet
Imports Independentsoft.Office.Spreadsheet.Styles
Imports Syncfusion.WinForms.DataGrid

Public Class frmLlistat


#Region "Atributs"

    Dim oConn As SqlClient.SqlConnection
    Dim oClase As BDRecord
    Dim sConsulta As String
    Private _mainForm As frmMain
    Public IdSeleccionat As Integer
    Private bElegir As Boolean
    Private bNomesVisualitzacio As Boolean
#End Region

    Public Sub New(_oConn As SqlClient.SqlConnection, _oClase As BDRecord, _sConsulta As String, mainForm As frmMain, sTitolFormulari As String, _bElegir As Boolean, _NomesVisualitzacio As Boolean)

        InitializeComponent()


        oConn = _oConn
        oClase = _oClase
        sConsulta = _sConsulta
        _mainForm = mainForm
        Me.Location = New System.Drawing.Point(225, 0)
        Me.TopLevel = False

        Me.Text = sTitolFormulari
        Me.IdSeleccionat = 0
        If _bElegir Then
            btnExportarExcel.Visible = False
            btnEditar.Visible = False
            btnNou.Visible = False
            btnActualizar.Visible = False

        End If

        If _NomesVisualitzacio Then
            'btnExportarExcel.Visible = False
            'btnActualizar.Visible = False
            btnNou.Visible = False
            btnEditar.Visible = False
            btnAcceptar.Visible = False
            btnCancelar.Text = fnTraductor.RetornaIdiomaSeleccionat("Cerrar", "Tancar")
        End If

        btnAcceptar.Visible = _bElegir

        Me.bElegir = _bElegir
        Me.bNomesVisualitzacio = _NomesVisualitzacio

        ActualitzarIdiomaControls(Me, clsConstants.Idioma)


    End Sub


    Public Sub ActualitzarIdiomaControls(ByVal frm As Control, ByVal sIdioma As String)
        For Each ctrl As Control In frm.Controls
            If TypeOf ctrl Is LabelMultiIdioma Then
                DirectCast(ctrl, LabelMultiIdioma).CambiarIdioma(sIdioma)

            ElseIf TypeOf ctrl Is ButtonMultiIdioma Then
                DirectCast(ctrl, ButtonMultiIdioma).CambiarIdioma(sIdioma)

            ElseIf ctrl.HasChildren Then
                ActualitzarIdiomaControls(ctrl, sIdioma)
            End If
        Next

        For Each columna As GridColumn In dgListado.Columns

            Dim nombreActual As String = columna.HeaderText

            Dim nombreTraducido As String = oClase.NomCampMostrar(nombreActual)

            columna.HeaderText = nombreTraducido
        Next

    End Sub

    Dim dt As DataTable = Nothing

    Public Sub TryLoad()


        Try
            dt = SQLReader.ReaderDataTable(oConn, Nothing, sConsulta)

            dgListado.DataSource = dt


            For Each columna As GridColumn In dgListado.Columns

                Dim nombreActual As String = columna.HeaderText

                If nombreActual = oClase.NOM_PK Then
                    columna.Visible = False
                End If

                Dim nombreTraducido As String = oClase.NomCampMostrar(nombreActual)

                columna.HeaderText = nombreTraducido

            Next

            dgListado.AutoSizeColumnsMode = Enums.AutoSizeColumnsMode.AllCells
            Me.dgListado.GroupPanel.GroupDropAreaText = fnTraductor.RetornaIdiomaSeleccionat("Arrastra una columna aqui para agrupar",
                                                                                              "Arrossega una columna aquí per agrupar")
            Me.dgListado.GroupPanel.Height = 50

            tbxCerca.Text = fnTraductor.RetornaIdiomaSeleccionat("Entra texto para buscar",
                                                                  "Entra text per cercar")

            ResizeFormulario()



        Catch ex As Exception
            frmMissatge.Mostrar("Error frmLlistat.TryLoad", ex)
        End Try

    End Sub

    Private Sub ResizeFormulario()

        Dim iWidthTotal As Double = 0
        Try
            For Each columna As GridColumn In dgListado.Columns

                iWidthTotal += columna.ActualWidth

            Next

            If iWidthTotal > Me.Width Then
                Me.Width = iWidthTotal

            End If

        Catch ex As Exception
            'Nada, que no haga el resize y ya
        End Try

    End Sub

    Private Sub oForm_LocationChanged(sender As Object, e As EventArgs) Handles MyBase.LocationChanged

        If _mainForm IsNot Nothing AndAlso _mainForm.ToolStripContainer1 IsNot Nothing AndAlso _mainForm.ToolStripContainer1.ContentPanel IsNot Nothing Then
            Dim margin As Integer = 200

            If Not _mainForm.ToolStripContainer1.ContentPanel.ClientRectangle.Contains(_mainForm.PointToClient(New System.Drawing.Point(Me.Left, Me.Top))) Then
                Dim correctedX As Integer = Math.Max(Math.Min(Me.Left, _mainForm.ToolStripContainer1.ContentPanel.Width - Me.Width), _mainForm.ToolStripContainer1.ContentPanel.Location.X + margin)
                Dim correctedY As Integer = Math.Max(Math.Min(Me.Top, _mainForm.ToolStripContainer1.ContentPanel.Height - Me.Height), 0)

                Me.Location = New System.Drawing.Point(correctedX, correctedY)
            End If
        End If
    End Sub


    Private Sub tbxCerca_TextChanged(sender As Object, e As EventArgs) 'Despues de quitar el placeholder
        Try
            Dim filtro As String = String.Empty
            For Each col As DataColumn In dt.Columns
                If col.DataType Is GetType(String) Then
                    filtro &= $"[{col.ColumnName}] LIKE '%{tbxCerca.Text}%' OR "
                Else
                    filtro &= $"CONVERT([{col.ColumnName}], 'System.String') LIKE '%{tbxCerca.Text}%' OR "
                End If
            Next

            If filtro.EndsWith(" OR ") Then
                filtro = filtro.Remove(filtro.Length - 4)
            End If

            dt.DefaultView.RowFilter = filtro

        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmLlistat_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If dt IsNot Nothing Then
            dt.Clear()
            dt.Dispose()
            dt = Nothing
        End If

    End Sub


    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Editar()
    End Sub


    Private Sub Editar()
        Dim oForm As Object = Nothing

        Try
            If dgListado.SelectedItems.Count > 0 Then

                Dim filaSeleccionada As DataRowView = dgListado.SelectedItems(0)

                If filaSeleccionada.Row.Item(oClase.NOM_PK) IsNot Nothing Then



                    Dim valorNOM_PK As Integer = filaSeleccionada.Row.Item(oClase.NOM_PK)

                    Dim tipoFormulario As Type = oClase.FormulariManteniment()

                    If tipoFormulario IsNot Nothing AndAlso GetType(Form).IsAssignableFrom(tipoFormulario) Then

                        oForm = TryCast(Activator.CreateInstance(tipoFormulario, New Object() {clsConstants.ConnGlobal, valorNOM_PK}), Form)
                        If oForm.TryLoad() Then
                            oForm.ShowDialog()

                            If oForm.DialogResult <> DialogResult.Cancel Then
                                Me.TryLoad()

                            End If
                        End If


                    Else
                        Throw New Exception("El tipo devuelto no es un formulario válido.")
                    End If


                Else

                    Throw New Exception("Id Buit")
                End If
            End If

        Catch ex As Exception
            frmMissatge.Mostrar("Error frmLlistat.Editar", ex)
        Finally
            If oForm IsNot Nothing Then
                oForm.Dispose()
                oForm = Nothing
                GC.Collect()

            End If
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnNou_Click(sender As Object, e As EventArgs) Handles btnNou.Click
        Dim oForm As Object = Nothing

        Try

            Dim tipoFormulario = oClase.FormulariManteniment

            If tipoFormulario IsNot Nothing AndAlso GetType(Form).IsAssignableFrom(tipoFormulario) Then

                oForm = TryCast(Activator.CreateInstance(tipoFormulario, New Object() {clsConstants.ConnGlobal, 0}), Form)
                oForm.TryLoad
                oForm.ShowDialog

                If oForm.DialogResult <> DialogResult.Cancel Then

                    TryLoad()


                End If

            End If

        Catch ex As Exception

            frmMissatge.Mostrar("Error frmLlistat.btnNou_Click", ex)
        End Try
    End Sub

    Private Sub btnExportarExcel_Click(sender As Object, e As EventArgs) Handles btnExportarExcel.Click

        Dim dtExportar As DataTable = Nothing


        Try
            dtExportar = dt.DefaultView.ToTable

            Dim workbook As New Workbook

            Dim worksheet As New Worksheet

            Dim format1 As New CellFormat

            format1.Font = New Font
            format1.Font.Bold = True
            format1.Font.Underline = New Underline(UnderlineType.Single)

            format1.Fill = New Fill
            format1.Fill.Pattern = New PatternFill
            format1.Fill.Pattern.Type = PatternType.Solid
            format1.Fill.Pattern.ForegroundColor = New ForegroundColor
            format1.Fill.Pattern.ForegroundColor.Color = "ADADAD"


            For colIndex = 0 To dtExportar.Columns.Count - 1

                Dim oCell = New Cell(oClase.NomCampMostrar(dtExportar.Columns(colIndex).ColumnName))
                oCell.Format = format1

                worksheet(colIndex + 1, 1) = oCell
            Next


            For rowIndex = 0 To dtExportar.Rows.Count - 1
                For colIndex = 0 To dtExportar.Columns.Count - 1

                    worksheet(colIndex + 1, rowIndex + 2) = New Cell(dtExportar.Rows(rowIndex)(colIndex).ToString)

                Next
            Next



            workbook.Sheets.Add(worksheet)


            Dim saveFileDialog As New SaveFileDialog
            saveFileDialog.Filter = "Archivo de Excel (*.xlsx)|*.xlsx"
            saveFileDialog.Title = "Guardar archivo de Excel"
            saveFileDialog.FileName = "archivo.xlsx"

            If saveFileDialog.ShowDialog = DialogResult.OK Then

                workbook.Save(saveFileDialog.FileName)

                MessageBox.Show("Exportación exitosa a Excel.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


        Catch ex As Exception
            frmMissatge.Mostrar("Error frmLlistat.btnExportarExcel_Click", ex)

        End Try
    End Sub

    Private Sub btnAcceptar_Click(sender As Object, e As EventArgs) Handles btnAcceptar.Click

        Try
            If IdSeleccionat <> 0 Then
                Close()
            Else
                frmMissatge.MostrarAvis(fnTraductor.RetornaIdiomaSeleccionat("No se seleccionó ninguna fila",
                                                                              "No s'ha seleccionat cap fila"))
            End If

        Catch ex As Exception
            frmMissatge.Mostrar("Error frmLlistat.Acceptar", ex)
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        TryLoad()

    End Sub

    Private Sub dgListado_CellDoubleClick(sender As Object, e As Events.CellClickEventArgs) Handles dgListado.CellDoubleClick


        If Not bNomesVisualitzacio Then
            If bElegir Then
                Elegir()
            Else
                Editar()

            End If
        End If

    End Sub

    Private Sub Elegir()
        Try
            If dgListado.SelectedItems.Count > 0 Then

                Dim filaSeleccionada = dgListado.SelectedItems(0)

                If filaSeleccionada.Row.Item(oClase.NOM_PK) IsNot Nothing Then

                    Dim valorNOM_PK As Integer = filaSeleccionada.Row.Item(oClase.NOM_PK)

                    IdSeleccionat = valorNOM_PK

                    DialogResult = DialogResult.OK
                    Close()

                Else

                    Throw New Exception("Id Buit")
                End If
            End If
        Catch ex As Exception
            frmMissatge.Mostrar("Error frmLlistat.Elegir", ex)

        End Try
    End Sub

    Private Sub tbxCerca_Enter(sender As Object, e As EventArgs) Handles tbxCerca.Enter
        If tbxCerca.Text = fnTraductor.RetornaIdiomaSeleccionat("Entra texto para buscar",
                                                                  "Entra text per cercar") Then
            tbxCerca.Text = ""
            AddHandler tbxCerca.TextChanged, AddressOf tbxCerca_TextChanged
        End If
    End Sub

    Private Sub frmLlistat_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()

        GC.Collect()

    End Sub
End Class