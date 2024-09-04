﻿Imports System.Reflection
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip
Imports DocumentFormat.OpenXml.Office2010.Excel.Drawing
Imports Microsoft.Data.SqlClient
Imports Syncfusion.WinForms.DataGrid
Public Class frmEnvios

#Region "Atributs"

    Private oDades As clsEnvios
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
        oDades = New clsEnvios

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

                pnlTarifa.Visible = False
                gbxEntrarTarifa.Visible = True

            Else

                LlegirDades()

                CargarHistorico()

                TabControl1.TabPages.Remove(pgeTarifa)

                ControlBTNAbrirFactura()

                tbiCodiClient.Enabled = False
                btnNouClient.Enabled = False


            End If

            bTryload = True

        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al cargar el formulario.",
                                                                      "Error al carregar el formulari."), ex)
            bTryload = False
        End Try

        Return bTryload
    End Function

    Private Sub ControlBTNAbrirFactura()
        Try
            Dim iRegistro As Object = SQLReader.ObtenirUnCamp(oConn, Nothing, "SELECT TOP 1 IdFactura FROM Factura_Linia WITH (NOLOCK) WHERE IdEnvio = " & oDades.Id)

            'If iRegistro Is Nothing Then
            '    btnAbrirFactura.Enabled = False
            '    btnAbrirFactura.Text = "Factura No Generada"
            'Else

            '    btnAbrirFactura.Tag = iRegistro
            'End If


        Catch ex As Exception
            Throw New Exception("Error ControlBTNAbrirFactura", ex)
        End Try
    End Sub

    Private Sub LlegirDades()

        Try
            oDades.Llegir(iId)

            CopiarDadesAControls()


        Catch ex As Exception
            Throw New Exception("Error frmEnvios.LlegirDades")
        End Try

    End Sub


    Private Sub CopiarControlsADades()
        oDades.CodigoSeguimiento = tbxCodigoSeguimiento.Text
        'ORIGEN

        oDades.DireccionOrigen = tbxDireccioOrigen.Text
        oDades.NombreRemitente = tbxNombreRemitente.Text
        oDades.PoblacionOrigen = tbiPoblacioOrigen._Valor
        oDades.MailRemitente = tbxMailRemitente.Text
        'DESTINO
        oDades.DireccionDestino = tbxDireccionDestino.Text
        oDades.NombreDestinatario = tbxNombreDestinatario.Text
        oDades.PoblacionDestino = tbiPoblacioDesti._Valor
        oDades.EmailDestinatario = tbxMailDestinatari.Text

        oDades.IdEstado = Convert.ToByte(cmbxEstat.SelectedIndex)
        oDades.Peso = Convert.ToDouble(tbxPeso.Text)
        oDades.Dimensiones = tbxDimensiones.Text
        oDades.CodigoCliente = If(tbiCodiClient._Valor = String.Empty, DBNull.Value, tbiCodiClient._Valor)
        oDades.Porte = Convert.ToDecimal(tbxPorte.Text)
        oDades.EmailDestinatario = tbxMailDestinatari.Text
        'oDades.IdRuta = tbiRuta._Valor
    End Sub

    Private Sub CopiarDadesAControls()
        tbxCodigoSeguimiento.Text = oDades.CodigoSeguimiento

        tbxDireccioOrigen.Text = oDades.DireccionOrigen
        tbxNombreRemitente.Text = oDades.NombreRemitente
        tbiPoblacioOrigen._Valor = oDades.PoblacionOrigen
        tbxMailRemitente.Text = oDades.MailRemitente

        tbxDireccionDestino.Text = oDades.DireccionDestino
        tbxNombreDestinatario.Text = oDades.NombreDestinatario
        tbiPoblacioDesti._Valor = oDades.PoblacionDestino
        tbxMailDestinatari.Text = oDades.EmailDestinatario

        cmbxEstat.SelectedIndex = oDades.IdEstado
        tbxPeso.Text = oDades.Peso.ToString()
        tbxDimensiones.Text = oDades.Dimensiones
        tbiCodiClient._Valor = If(IsDBNull(oDades.CodigoCliente), String.Empty, oDades.CodigoCliente.ToString())
        tbxPorte.Text = oDades.Porte.ToString()

    End Sub


    Private Sub Inicialitzacions()
        For Each iEstado As Integer In [Enum].GetValues(GetType(EstadosEnvios.Estados))

            Dim traduccion As String = EstadosEnvios.GetTraduccio(iEstado)
            cmbxEstat.Items.Add(traduccion)

        Next

        tbiCodiClient.uObjRecord = New clsClients()
        'tbiRuta.uObjRecord = New clsRutas()


        gbxDatosCliente.Text = fnTraductor.RetornaIdiomaSeleccionat("Datos Cliente", "Dades Client")
        gpxOrigen.Text = fnTraductor.RetornaIdiomaSeleccionat("Datos Destino", "Dades Destí")
        gbxCaracEnvio.Text = fnTraductor.RetornaIdiomaSeleccionat("Características Envío", "Caracteristiques Enviament")
        gbxOrigenDesti.Text = fnTraductor.RetornaIdiomaSeleccionat("Origen y Destino", "Origen i Destí")
        gbxPrecios.Text = fnTraductor.RetornaIdiomaSeleccionat("Precios", "Preus")
        Me.Text = fnTraductor.RetornaIdiomaSeleccionat("Envíos", "Enviaments")

        tbiPoblacioOrigen.uObjRecord = New clsPoblacions()
        tbiPoblacioDesti.uObjRecord = New clsPoblacions()
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

    Private ReadOnly caracteresPermitidos As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"

    Public Function GenerarCodigoEnvio() As String
        Dim codigo As New StringBuilder()
        Dim rnd As New Random()

        For i As Integer = 0 To 11
            Dim indice As Integer = rnd.Next(0, caracteresPermitidos.Length)
            codigo.Append(caracteresPermitidos(indice))
        Next

        Return codigo.ToString()
    End Function




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
            CopiarControlsADades()

            If bEsAlta Then
                Dim bExisteix As Boolean = True
                Dim sCodigo As String = String.Empty

                While bExisteix

                    sCodigo = GenerarCodigoEnvio()


                    bExisteix = SQLReader.CampoExiste(oConn, Nothing, "SELECT CodigoSeguimiento FROM Envios WITH (NOLOCK) WHERE CodigoSeguimiento = '" & sCodigo & "'")

                End While

                oDades.CodigoSeguimiento = sCodigo

            End If

            oDades.Escriure(bEsAlta)

            bGuardar = True

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

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click

        Try
            If frmMissatge.MostrarPreguntaSiNo(fnTraductor.RetornaIdiomaSeleccionat("¿Estás seguro de borrar este registro?",
                                                                                     "Estàs segur d'esborrar aquest registre?")) Then

                oDades.Esborrar()
                DialogResult = DialogResult.OK
                Close()


            End If
        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al borrar el registro", "Error al esborrar el registre"), ex)
        End Try
    End Sub

#End Region

#Region "Cargar Historico"

    Dim dtHistorico As DataTable = Nothing

    Private Sub CargarHistorico()

        Dim oClase As clsEnvios_Historico = Nothing

        Try

            oClase = New clsEnvios_Historico()

            dtHistorico = SQLReader.ReaderDataTable(clsConstants.ConnGlobal, Nothing, clsEnvios_Historico.ConsultaSegonsEnvio(oDades.Id))

            Dim nuevaColumna As New DataColumn("NuevoEstado", GetType(String))

            dtHistorico.Columns.Add(nuevaColumna)

            For Each oRow As System.Data.DataRow In dtHistorico.Rows
                Dim valorActual As Integer = Convert.ToInt32(oRow("IdEstado"))
                Dim valorConvertido As String = EstadosEnvios.GetTraduccio(valorActual)
                oRow("NuevoEstado") = valorConvertido
            Next

            dtHistorico.Columns.Remove("IdEstado")

            dtHistorico.Columns("NuevoEstado").ColumnName = "IdEstado"

            dtHistorico.Columns("IdEstado").SetOrdinal(0)



            dgvHistorico.DataSource = dtHistorico

            For Each columna As GridColumn In dgvHistorico.Columns

                Dim nombreActual As String = columna.HeaderText

                If nombreActual = oClase.NOM_PK Or nombreActual = "IdEnvio" Then
                    columna.Visible = False
                End If

                If nombreActual = "Observaciones" Then
                    columna.Width = 500
                End If

                Dim nombreTraducido As String = oClase.NomCampMostrar(nombreActual)

                columna.HeaderText = nombreTraducido

            Next

            dgvHistorico.AutoSizeColumnsMode = Enums.AutoSizeColumnsMode.AllCellsWithLastColumnFill







        Catch ex As Exception
            Throw New Exception("Error frmEnvios.CargarHistorico")
        Finally
            If oClase IsNot Nothing Then
                oClase = Nothing
            End If
        End Try
    End Sub

    Private Sub btnAfegirHistoric_Click(sender As Object, e As EventArgs) Handles btnAfegirHistoric.Click



        AfegirHistoric()
    End Sub

    Private Sub AfegirHistoric()

        Dim oForm As frmEnvios_Historicos = Nothing

        Try

            If bEsAlta Then
                frmMissatge.MostrarAvis(fnTraductor.RetornaIdiomaSeleccionat("Para añadir datos históricos primero guarda el envío.",
                                                                          "Per afegir dades històriques primer desa el enviament."))
                Exit Sub
            End If

            oForm = New frmEnvios_Historicos(oConn, 0, oDades.Id)

            oForm.TryLoad()
            If oForm.ShowDialog() = DialogResult.OK Then

                Dim oRow As System.Data.DataRow = dtHistorico.NewRow()

                oForm.oDades.CopiarDatosADataRow(oRow)

                cmbxEstat.SelectedIndex = oForm.oDades.Estado

                oRow("IdEstado") = EstadosEnvios.GetTraduccio(oForm.oDades.Estado)

                dtHistorico.Rows.InsertAt(oRow, 0)

                Dim sMail As String = IIf(tbxMailCliente.Text <> String.Empty, tbxMailCliente.Text, tbxMailDestinatari.Text) 'Si el mail del cliente no esta vacio, utilizamos ese.


                If getNecesarioEnviarMail_SegunEstado(oForm.oDades.Estado) Then

                    If EsCorreoElectronicoValido(sMail) Then
                        'clsMail.EnviarMailCliente(sMail, tbxCodigoSeguimiento.Text, oForm.oDades.Estado)
                    End If

                End If


            End If

        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al añadir el Registro",
                                                                      "Error al afegir el registre"), ex)

        Finally
            If oForm IsNot Nothing Then
                oForm.Dispose()
                oForm = Nothing
            End If
        End Try
    End Sub

    Private Function EsCorreoElectronicoValido(correo As String) As Boolean
        Dim expresionRegular As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        Dim coincide As Boolean = Regex.IsMatch(correo, expresionRegular)

        Return coincide
    End Function

    Private Function getNecesarioEnviarMail_SegunEstado(IdEstado)

        Return IdEstado = EstadosEnvios.Estados.Recibido Or IdEstado = EstadosEnvios.Estados.Reparto Or IdEstado = EstadosEnvios.Estados.Entregado Or IdEstado = EstadosEnvios.Estados.Incidencia


    End Function

    Private Sub btnTreureHistoric_Click(sender As Object, e As EventArgs) Handles btnTreureHistoric.Click
        If dtHistorico.Rows.Count = 0 Then
            frmMissatge.MostrarAvis(fnTraductor.RetornaIdiomaSeleccionat("No hay ningun histórico que borrar",
                                                                          "No hi ha cap històric que esborrar"))
            Exit Sub
        End If
        If dgvHistorico.SelectedItems.Count > 0 Then
            Dim filaSeleccionada = dgvHistorico.SelectedItems(0)

            Dim idEnviosHistorico As Integer = Convert.ToInt32(filaSeleccionada.Row.Item("IdEnvios_Historico"))


            TreureHistoric(idEnviosHistorico)
        End If

    End Sub

    Private Sub TreureHistoric(IdHistoric As Integer)
        Dim oRegistre As clsEnvios_Historico = Nothing
        Try
            Dim resultado As DialogResult = MessageBox.Show(fnTraductor.RetornaIdiomaSeleccionat("¿Está seguro de que desea borrar el registro?",
                                                                                                  "Estas segur de esborrar aquest registre?"), "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If resultado = DialogResult.Yes Then

                oRegistre = New clsEnvios_Historico()
                oRegistre.Llegir(IdHistoric)


                oRegistre.Esborrar()

                dgvHistorico.View.Records.RemoveAt(dgvHistorico.CurrentCell.RowIndex - 1)

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

#End Region

#Region "Calcular Tarifa"


    Private Async Sub CargarTarifa()


        Try



            Dim dDistancia As Decimal = Await CalculadorTarifas.getDistancia(tbxDireccioOrigenCT.Text, tbxDireccioDestiCT.Text)

            tbxDistanciaTotalCT.Text = dDistancia

            Dim iTarifa As Integer = -1

            iTarifa = cmbxTarifas.SelectedIndex

            If iTarifa = -1 Then
                frmMissatge.MostrarAvis("Selecciona la tarifa")
                Exit Sub
            End If

            Dim dPeso As Decimal
            Decimal.TryParse(tbxPesoCT.Text, dPeso) ' EN KG

            Dim dSize As Decimal
            Decimal.TryParse(tbxSize.Text, dSize)

            CalcularPrecioPorte(iTarifa, dDistancia, dPeso, dSize)

        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al cargar la Tarifa",
                                                          "Error al carregar la Tarifa"), ex)
        End Try
    End Sub

    Private Sub CalcularPrecioPorte(iTarifa As Integer, dDistancia As Decimal, dPeso As Decimal, dSize As Decimal)
        Try
            Dim dPorte As Decimal = 0.0

            Dim iMultiplicador As Integer = SQLReader.ObtenirUnCamp(oConn, Nothing, "SELECT Multiplicador FROM Tarifas WITH (NOLOCK) WHERE IdTarifa = " & iTarifa + 1)

            dPorte = (iMultiplicador * dDistancia * dPeso * dSize) / 10000

            If dPorte <> 0 Then

                tbxPrecioNoClienteCT.Text = Math.Round(dPorte, 2)
                tbxPrecioClienteCT.Text = Math.Round(dPorte * 0.85)

            End If


        Catch ex As Exception
            Throw New Exception("Error frmEnvios.CalcularPrecioPorte")
        End Try

    End Sub

    Private Sub btnEntrarTarifa_Click(sender As Object, e As EventArgs) Handles btnEntrarTarifa.Click
        Try

            If tbxDireccionDestino.Text Is String.Empty Or tbxDimensiones.Text Is String.Empty Or tbxPeso.Text Is String.Empty Then
                frmMissatge.MostrarAvis(fnTraductor.RetornaIdiomaSeleccionat("No se han acabado de rellenar los datos del envío",
                                                                              "No s'han acabat d'emplenar les dades del enviament"))
                Exit Sub
            Else

                tbxDireccioOrigenCT.Text = IIf(tbxDireccioOrigen.Text = String.Empty, CalculadorTarifas.DIR_ORIGEN, tbxDireccioOrigen.Text)
                tbxDireccioDestiCT.Text = tbxDireccionDestino.Text
            End If

            Dim regex As New Regex("^\d+x\d+x\d+$")
            If Not regex.IsMatch(tbxDimensiones.Text) Then
                frmMissatge.MostrarAvis(fnTraductor.RetornaIdiomaSeleccionat("No se han entrado bien las dimensiones",
                                                                              "No s'han entrat bé les dimensions"))
                Exit Sub
            Else
                Dim numeros() As String
                numeros = Split(tbxDimensiones.Text, "x")
                tbxAltoCT.Text = numeros(0)
                tbxAnchoCT.Text = numeros(1)
                tbxFondoCT.Text = numeros(2)
            End If


            Dim alto As Decimal
            Dim ancho As Decimal
            Dim fondo As Decimal
            Dim dSize As Decimal
            If Decimal.TryParse(tbxAltoCT.Text, alto) AndAlso Decimal.TryParse(tbxAnchoCT.Text, ancho) AndAlso Decimal.TryParse(tbxFondoCT.Text, fondo) Then
                dSize = alto * ancho * fondo
            Else
                frmMissatge.MostrarAvis(fnTraductor.RetornaIdiomaSeleccionat("No se han entrado bien las dimensiones",
                                                                              "No s'han entrat bé les dimensions"))
            End If



            CargarTarifas()

            tbxSize.Text = dSize

            tbxPesoCT.Text = tbxPeso.Text

            gbxEntrarTarifa.Visible = False
            pnlTarifa.Visible = True

        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al cargar la Tarifa",
                                                          "Error al carregar la Tarifa"), ex)
        End Try

    End Sub
    Dim lstTarifas As List(Of String) = Nothing
    Private Sub CargarTarifas()

        Dim dt As DataTable = Nothing

        Try

            dt = SQLReader.ReaderDataTable(oConn, Nothing, "SELECT Nom FROM Tarifas WITH (NOLOCK)")

            lstTarifas = New List(Of String)

            For Each oRow In dt.Rows
                lstTarifas.Add(oRow("Nom"))
            Next

            cmbxTarifas.DataSource = lstTarifas

            If tbxTarifaFavClient.Text <> String.Empty Then
                cmbxTarifas.SelectedIndex = Integer.Parse(tbxTarifaFavClient.Text) - 1
            End If


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

    Private Sub btnCalcularPorte_Click(sender As Object, e As EventArgs) Handles btnCalcularPorte.Click
        CargarTarifa()
    End Sub

    Private Sub btnAcceptarTarifa_Click(sender As Object, e As EventArgs) Handles btnAcceptarTarifa.Click
        If tbiCodiClient._Valor <> String.Empty Then
            tbxPorte.Text = tbxPrecioClienteCT.Text
        Else
            tbxPorte.Text = tbxPrecioNoClienteCT.Text
        End If
    End Sub

    Private Sub frmEnvios_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If dtHistorico IsNot Nothing Then
            dtHistorico.Clear()
            dtHistorico.Dispose()
            dtHistorico = Nothing
        End If
    End Sub

    Private Sub tbxEsComercial_TextChanged(sender As Object, e As EventArgs) Handles tbxEsComercial.TextChanged
        If tbxEsComercial.Text.StartsWith("T") Then
            cbxEsComercial.Checked = True
        Else
            cbxEsComercial.Checked = False

        End If
    End Sub

    Private Sub btnAbrirFactura_Click(sender As Object, e As EventArgs) Handles btnAbrirFactura.Click
        Dim oForm As frmFactura = Nothing
        Try
            oForm = New frmFactura(oConn, btnAbrirFactura.Tag)

            oForm.TryLoad()

            oForm.ShowDialog()

            If oForm.bEsborrada Then
                btnAbrirFactura.Enabled = False
                btnAbrirFactura.Text = "Factura Borrada"
            End If


        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al abrir la Factura",
                                                                      "Error al obrir la Factura"), ex)

        Finally
            If oForm IsNot Nothing Then
                oForm.Dispose()
                oForm = Nothing
            End If
        End Try
    End Sub

    Private Sub btnNouClient_Click(sender As Object, e As EventArgs) Handles btnNouClient.Click

        Dim oForm As frmClients = Nothing

        Try
            oForm = New frmClients(oConn, 0)

            oForm.TryLoad()

            If oForm.ShowDialog = DialogResult.OK Then
                tbiCodiClient._Valor = oForm.oDades.Id
            End If

        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al donar de alta el Cliente",
                                                                      "Error al dar d'alta el Client"), ex)

        Finally
            If oForm IsNot Nothing Then
                oForm.Dispose()
                oForm = Nothing

            End If
        End Try
    End Sub






#End Region

#Region "Botones direcciones"

    Private Sub btnImportarDirClientOrigen_Click(sender As Object, e As EventArgs) Handles btnImportarDirClientOrigen.Click
        Dim oList As List(Of Object) = Nothing
        Try
            If tbiCodiClient._Valor = String.Empty Then
                frmMissatge.MostrarAvis(fnTraductor.RetornaIdiomaSeleccionat("Primero entra el cliente", "Primer entra el client"))
                Exit Sub
            End If

            oList = SQLReader.ObtenerUnaFila(oConn, Nothing, "SELECT DireccionOrigenFavorita, NomClient, IdPoblacio, Mail FROM Clients WHERE IdClient =" & tbiCodiClient._Valor)

            tbxDireccioOrigen.Text = oList(0)
            tbxNombreRemitente.Text = oList(1)
            tbiPoblacioOrigen._Valor = oList(2)
            tbxMailRemitente.Text = oList(3)

        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al importar la dirección del Cliente",
                                                                      "Error al importar la direcció del Client"), ex)
        Finally
            If oList IsNot Nothing Then
                oList.Clear()
                oList = Nothing
            End If
        End Try
    End Sub

    Private Sub btnImportarClientDesti_Click(sender As Object, e As EventArgs) Handles btnImportarClientDesti.Click
        Dim oList As List(Of Object) = Nothing
        Try
            If tbiCodiClient._Valor = String.Empty Then
                frmMissatge.MostrarAvis(fnTraductor.RetornaIdiomaSeleccionat("Primero entra el cliente", "Primer entra el client"))
                Exit Sub
            End If

            oList = SQLReader.ObtenerUnaFila(oConn, Nothing, "SELECT DireccionOrigenFavorita, NomClient, IdPoblacio, Mail FROM Clients WHERE IdClient =" & tbiCodiClient._Valor)

            tbxDireccionDestino.Text = oList(0)
            tbxNombreDestinatario.Text = oList(1)
            tbiPoblacioDesti._Valor = oList(2)
            tbxMailDestinatari.Text = oList(3)

        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al importar la dirección del Cliente",
                                                                      "Error al importar la direcció del Client"), ex)
        Finally
            If oList IsNot Nothing Then
                oList.Clear()
                oList = Nothing
            End If
        End Try
    End Sub


#End Region


End Class