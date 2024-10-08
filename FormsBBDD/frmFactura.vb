﻿Imports System.CodeDom
Imports System.Globalization
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Threading
Imports Microsoft.Data.SqlClient
Imports Syncfusion.Windows.Forms.InternalMenus
Imports Syncfusion.WinForms.DataGrid

Public Class frmFactura

#Region "Atributs"

    Private oDades As clsFacturas
    Private oConn As SqlConnection
    Private bEsAlta As Boolean
    Private iId As Integer
    Public bEsborrada As Boolean
#End Region

#Region "Constructor"
    Public Sub New(_oConn As SqlConnection, _Id As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Me.oConn = _oConn
        oDades = New clsFacturas

        iId = _Id

        If _Id = 0 Then
            bEsAlta = True
        Else
            bEsAlta = False

        End If

        Me.Text = fnTraductor.RetornaIdiomaSeleccionat("Facturas", "Factures")

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

                LlegirDades()
                CargarItems()

                If Not IsDBNull(oDades.IdDocument) Then
                    btnGenerarFactura.Text = fnTraductor.RetornaIdiomaSeleccionat("Abrir factura",
                                                                                  "Obrir factura")
                End If


            End If

            bTryload = True


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
        oDades.NumFactura = tbxNumFactura.Text
        oDades.IdClient = tbiCodiClient._Valor
        oDades.Cobrado = cbxCobrado.Checked
        oDades.FechaEmision = dtpEmision.Value
        oDades.FechaVencimiento = dtpVencimiento.Value
        oDades.Observaciones = tbxObservaciones.Text
        oDades.TotalLimpio = tbxImpuestos.Text
        oDades.TotalBruto = tbxSinImpuestos.Text

    End Sub

    Private Sub CopiarDadesAControls()
        tbxNumFactura.Text = oDades.NumFactura
        tbiCodiClient._Valor = oDades.IdClient
        cbxCobrado.Checked = oDades.Cobrado
        dtpEmision.Value = oDades.FechaEmision
        dtpVencimiento.Value = oDades.FechaVencimiento
        tbxObservaciones.Text = oDades.Observaciones
        tbxImpuestos.Text = oDades.TotalLimpio
        tbxSinImpuestos.Text = oDades.TotalBruto
    End Sub

    Private Sub Inicialitzacions()
        tbiCodiClient.uObjRecord = New clsClients
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

        Dim sIdiomaInterficie As String = "es-ES"

        If clsConstants.Idioma.StartsWith("C") Then
            sIdiomaInterficie = "ca-ES"
        End If

        dtpEmision.Culture = New CultureInfo(sIdiomaInterficie)
        dtpVencimiento.Culture = New CultureInfo(sIdiomaInterficie)

    End Sub

    Private Sub getUltimNumero()
        Dim sUltim As String = SQLReader.ObtenirUnCamp(oConn, Nothing, "SELECT TOP 1 NumFactura FROM Factura WITH (NOLOCK) ORDER BY IdFactura DESC")
        Dim sNumero As Integer = 0
        If sUltim IsNot Nothing Then
            sUltim = sUltim.Substring(3, 3)
            sNumero = Integer.Parse(sUltim)
            sNumero += 1
            tbxNumFactura.Text = IIf(sNumero < 100, "FAC0" & sNumero, "FAC" & sNumero)
        End If

    End Sub


#End Region

#Region "Control Botons"

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Guardar() Then
            Close()
            DialogResult = DialogResult.OK
        End If
    End Sub

    Private Function Guardar() As Boolean

        Dim bGuardar As Boolean

        Try

            If bEsAlta Then
                getUltimNumero()
            End If

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
        Close()
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub frmGeneric_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If dtItems IsNot Nothing Then
            dtItems.Clear()
            dtItems.Dispose()
            dtItems = Nothing
        End If
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click

        Try
            If frmMissatge.MostrarPreguntaSiNo(fnTraductor.RetornaIdiomaSeleccionat("¿Estás seguro de borrar este registro?",
                                                                                     "Estàs segur d'esborrar aquest registre?")) Then

                oDades.Esborrar()
                bEsborrada = True
                Close()


            End If
        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al borrar el registro", "Error al esborrar el registre"), ex)
        End Try
    End Sub





#End Region

#Region "Items"

    Dim dtItems As DataTable = Nothing

    Private Sub CargarItems()

        Dim oClase As clsFactura_Linia = Nothing

        Try

            oClase = New clsFactura_Linia()

            dtItems = SQLReader.ReaderDataTable(clsConstants.ConnGlobal, Nothing, clsFactura_Linia.ConsultaSegonsFactura(oDades.Id))


            dgvItems.DataSource = dtItems

            For Each columna As GridColumn In dgvItems.Columns

                Dim nombreActual As String = columna.HeaderText

                If nombreActual = oClase.NOM_PK Or nombreActual = "IdFactura_Linia" Then
                    columna.Visible = False
                End If

                If nombreActual = "Descripcion" Then
                    columna.Width = 200
                End If

                Dim nombreTraducido As String = oClase.NomCampMostrar(nombreActual)

                columna.HeaderText = nombreTraducido

            Next

            dgvItems.AutoSizeColumnsMode = Enums.AutoSizeColumnsMode.AllCellsWithLastColumnFill







        Catch ex As Exception
            Throw New Exception("Error frmEnvios.CargarHistorico")
        Finally
            If oClase IsNot Nothing Then
                oClase = Nothing
            End If
        End Try
    End Sub

    Private Sub RecalcularPrecioFactura()
        Dim iTotalBruto As Decimal = 0.0
        Dim iTotalLimpio As Decimal = 0.0

        Try
            For Each item In dtItems.Rows
                'sRes = "SELECT Factura_Linia.IdFactura_Linia, Envios.CodigoSeguimiento, Factura_Linia.IdEnvio, Envios.Porte, Factura_Linia.Descripcion, IVA.Porcentaje
                iTotalBruto += item("Porte")
                iTotalLimpio += item("Porte") + (item("Porte") * item("Porcentaje") / 100)


            Next
            tbxSinImpuestos.Text = Math.Round(iTotalBruto, 2)
            tbxImpuestos.Text = Math.Round(iTotalLimpio, 2)



        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al recalcular el precio de la factura.",
                                                                      "Error al recalcular el preu de la factura."), ex)
        End Try
    End Sub

    Private Sub btnAfegirHistoric_Click(sender As Object, e As EventArgs) Handles btnAfegirHistoric.Click

        AfegirItem()
        RecalcularPrecioFactura()
    End Sub

    Private Sub AfegirItem()

        Dim oForm As frmFactura_Linia = Nothing
        Dim oEnvio As clsEnvios = Nothing

        Try

            If bEsAlta Then
                frmMissatge.MostrarAvis(fnTraductor.RetornaIdiomaSeleccionat("Para añadir un item primero guarda la factura.",
                                                                          "Per afegir un item primer desa la factura."))
                Exit Sub
            End If

            If dtItems.Rows.Count = 9 Then
                frmMissatge.MostrarAvis(fnTraductor.RetornaIdiomaSeleccionat("Solo se permite 9 items por factura.",
                                                                          "Només es permeten 9 items per factura."))
            End If

            oForm = New frmFactura_Linia(oConn, 0, oDades.Id)

            oForm.TryLoad()
            If oForm.ShowDialog() = DialogResult.OK Then

                Dim oRow As System.Data.DataRow = dtItems.NewRow()
                oRow("IdFactura_Linia") = oForm.oDades.Id
                oRow("CodigoSeguimiento") = oForm.tbxCodigoSeguimiento.Text
                oRow("IdEnvio") = oForm.oDades.IdEnvio
                oRow("Descripcion") = oForm.tbxObservacions.Text

                oEnvio = New clsEnvios()
                oEnvio.Llegir(oForm.oDades.IdEnvio)

                oRow("Porte") = oEnvio.Porte


                Dim dPorcentaje As Decimal = SQLReader.ObtenirUnCamp(oConn, Nothing, "SELECT Porcentaje FROM IVA WITH (NOLOCK) WHERE IdTipoImpositivo = " & oForm.oDades.IdTipoImpositivo)

                oRow("Porcentaje") = dPorcentaje

                dtItems.Rows.InsertAt(oRow, 0)


            End If

        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al añadir el Registro",
                                                                      "Error al afegir el registre"), ex)

        Finally
            If oForm IsNot Nothing Then
                oForm.Dispose()
                oForm = Nothing
            End If

            If oEnvio IsNot Nothing Then
                oEnvio = Nothing
            End If
        End Try
    End Sub

    Private Sub btnTreureHistoric_Click(sender As Object, e As EventArgs) Handles btnTreureHistoric.Click
        If dtItems.Rows.Count = 0 Then
            frmMissatge.MostrarAvis(fnTraductor.RetornaIdiomaSeleccionat("No hay ningun item que borrar",
                                                                          "No hi ha cap item que esborrar"))
            Exit Sub
        End If
        If dgvItems.SelectedItems.Count > 0 Then
            Dim filaSeleccionada = dgvItems.SelectedItems(0)

            Dim IdFactura_Linia = Convert.ToInt32(filaSeleccionada.Row.Item("IdFactura_Linia"))


            TreureHistoric(IdFactura_Linia)
            RecalcularPrecioFactura()
        End If

    End Sub

    Private Sub TreureHistoric(IdFactura_Linia As Integer)
        Dim oRegistre As clsFactura_Linia = Nothing
        Try
            Dim resultado As DialogResult = MessageBox.Show(fnTraductor.RetornaIdiomaSeleccionat("¿Está seguro de que desea borrar el registro?",
                                                                                                  "Estas segur de esborrar aquest registre?"), "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If resultado = DialogResult.Yes Then

                oRegistre = New clsFactura_Linia()
                oRegistre.Llegir(IdFactura_Linia)


                oRegistre.Esborrar()
                dtItems.Rows.RemoveAt(dgvItems.CurrentCell.RowIndex - 1)
                'dgvItems.View.Records.RemoveAt(dgvItems.CurrentCell.RowIndex - 1)

            End If



        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al borrar el Registro",
                                                          "Error al esborrar el registre"), ex)
        Finally
            If oRegistre IsNot Nothing Then
                oRegistre = Nothing
            End If
        End Try
    End Sub

    Private Sub ObrirDocument()
        Dim oDocument As clsDocuments = Nothing

        Try

            oDocument = New clsDocuments()
            oDocument.Llegir(oDades.IdDocument)


            Process.Start("C:\Program Files\Microsoft Office\root\Office16\winword.EXE", oDocument.RutaDocument)

        Catch ex As Exception
            Throw New Exception("Error ObrirDocument", ex)
        End Try
    End Sub

    Private Sub btnGenerarFactura_Click(sender As Object, e As EventArgs) Handles btnGenerarFactura.Click
        Dim dicDatos As Dictionary(Of String, String) = Nothing

        Try

            If Not IsDBNull(oDades.IdDocument) Then
                ObrirDocument()
                Exit Sub

            End If

            dicDatos = New Dictionary(Of String, String)
            dicDatos.Add("IDFACTURA", oDades.Id)
            dicDatos.Add("NUMFACTURA", tbxNumFactura.Text)
            dicDatos.Add("DEMISION", dtpEmision.Value.ToString("dd-MM-yyyy"))
            dicDatos.Add("DVENCIMIENTO", dtpVencimiento.Value.ToString("dd-MM-yyyy"))
            dicDatos.Add("NCLIENTE", tbxNombreCliente.Text)
            dicDatos.Add("DIRCLIENTE", tbxDirCliente.Text)
            dicDatos.Add("NIFCLIENTE", tbxNifcliente.Text)
            dicDatos.Add("MAILCLIENTE", tbxMailCliente.Text)
            dicDatos.Add("OBS", tbxObservaciones.Text)




            Dim sRuta As String = GenerarFactura.GenerarFactura(dicDatos, dtItems, tbxIdioma.Text)

            Dim iIdDocumento = frmGeneradorInformes.GuardarDocumento(sRuta, 2)

            oDades.IdDocument = iIdDocumento
            oDades.Escriure(bEsAlta)

            btnGenerarFactura.Text = fnTraductor.RetornaIdiomaSeleccionat("Abrir factura",
                                                                          "Obrir factura")

            If frmMissatge.MostrarPreguntaSiNo(fnTraductor.RetornaIdiomaSeleccionat("Factura Generada, ¿desea abrirla?", "Factura Generada, vol obrir-la?")) Then
                DialogResult = DialogResult.OK
                Me.Close()

                'Process.Start("winword.exe", sRuta)
                Process.Start("C:\Program Files\Microsoft Office\root\Office16\WINWORD.EXE", sRuta)

                'Dim wordApp As New Microsoft.Office.Interop.Word.Application()
                'wordApp.Visible = True
                'wordApp.Documents.Open(sRuta)

            End If



        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al generar la Factura",
                                                          "Error al generar la Factura"), ex)
        Finally
            If dicDatos IsNot Nothing Then
                dicDatos.Clear()
                dicDatos = Nothing
            End If
        End Try

    End Sub

#End Region


End Class