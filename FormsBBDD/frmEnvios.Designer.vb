﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnvios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEnvios))
        TabPage1 = New TabPage()
        gbxDatosCliente = New GroupBox()
        cbxEsComercial = New CheckBox()
        LabelMultiIdioma25 = New LabelMultiIdioma()
        LabelMultiIdioma10 = New LabelMultiIdioma()
        tbxNifCliente = New TextBox()
        tbiCodiClient = New Lupa()
        tbxNombreCliente = New TextBox()
        tbxMailCliente = New TextBox()
        tbxTarifaFavClient = New TextBox()
        tbxDireccionOrigen = New TextBox()
        tbxEsComercial = New TextBox()
        LabelMultiIdioma11 = New LabelMultiIdioma()
        LabelMultiIdioma12 = New LabelMultiIdioma()
        LabelMultiIdioma13 = New LabelMultiIdioma()
        gbxGeneral = New GroupBox()
        cmbxEstat = New ComboBox()
        LabelMultiIdioma6 = New LabelMultiIdioma()
        LabelMultiIdioma1 = New LabelMultiIdioma()
        tbxPorte = New TextBox()
        LabelMultiIdioma7 = New LabelMultiIdioma()
        lblCodigoSeguimiento = New LabelMultiIdioma()
        tbxPeso = New TextBox()
        tbxCodigoSeguimiento = New TextBox()
        LabelMultiIdioma8 = New LabelMultiIdioma()
        tbxDimensiones = New TextBox()
        LabelMultiIdioma9 = New LabelMultiIdioma()
        gpxOrigen = New GroupBox()
        tbiRuta = New Lupa()
        tbxRuta = New TextBox()
        lblMailDestinatari = New LabelMultiIdioma()
        tbxMailDestinatari = New TextBox()
        LabelMultiIdioma24 = New LabelMultiIdioma()
        LabelMultiIdioma5 = New LabelMultiIdioma()
        tbxNombreDestinatario = New TextBox()
        LabelMultiIdioma4 = New LabelMultiIdioma()
        tbxPoblacionDestino = New TextBox()
        LabelMultiIdioma3 = New LabelMultiIdioma()
        tbxCPDestino = New TextBox()
        LabelMultiIdioma2 = New LabelMultiIdioma()
        tbxDireccionDestino = New TextBox()
        TabControl1 = New TabControl()
        TabPage2 = New TabPage()
        dgvHistorico = New Syncfusion.WinForms.DataGrid.SfDataGrid()
        btnTreureHistoric = New ButtonMultiIdioma()
        btnAfegirHistoric = New ButtonMultiIdioma()
        pgeTarifa = New TabPage()
        pnlTarifa = New Panel()
        gbxPrecios = New GroupBox()
        btnAcceptarTarifa = New ButtonMultiIdioma()
        btnCalcularPorte = New ButtonMultiIdioma()
        LabelMultiIdioma22 = New LabelMultiIdioma()
        tbxPrecioNoClienteCT = New TextBox()
        LabelMultiIdioma19 = New LabelMultiIdioma()
        tbxPrecioClienteCT = New TextBox()
        LabelMultiIdioma18 = New LabelMultiIdioma()
        tbxDistanciaTotalCT = New TextBox()
        gbxTarifa = New GroupBox()
        cmbxTarifas = New ComboBox()
        gbxCaracEnvio = New GroupBox()
        LabelMultiIdioma16 = New LabelMultiIdioma()
        LabelMultiIdioma17 = New LabelMultiIdioma()
        tbxFondoCT = New TextBox()
        tbxAnchoCT = New TextBox()
        LabelMultiIdioma14 = New LabelMultiIdioma()
        LabelMultiIdioma15 = New LabelMultiIdioma()
        tbxAltoCT = New TextBox()
        tbxPesoCT = New TextBox()
        gbxOrigenDesti = New GroupBox()
        LabelMultiIdioma20 = New LabelMultiIdioma()
        LabelMultiIdioma21 = New LabelMultiIdioma()
        tbxDireccioDestiCT = New TextBox()
        tbxDireccioOrigenCT = New TextBox()
        gbxEntrarTarifa = New GroupBox()
        LabelMultiIdioma23 = New LabelMultiIdioma()
        btnEntrarTarifa = New ButtonMultiIdioma()
        btnGuardar = New ButtonMultiIdioma()
        btnCancelar = New ButtonMultiIdioma()
        tbxSize = New TextBox()
        btnBorrar = New ButtonMultiIdioma()
        btnAbrirFactura = New ButtonMultiIdioma()
        TabPage1.SuspendLayout()
        gbxDatosCliente.SuspendLayout()
        gbxGeneral.SuspendLayout()
        gpxOrigen.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage2.SuspendLayout()
        CType(dgvHistorico, ComponentModel.ISupportInitialize).BeginInit()
        pgeTarifa.SuspendLayout()
        pnlTarifa.SuspendLayout()
        gbxPrecios.SuspendLayout()
        gbxTarifa.SuspendLayout()
        gbxCaracEnvio.SuspendLayout()
        gbxOrigenDesti.SuspendLayout()
        gbxEntrarTarifa.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.Gainsboro
        TabPage1.Controls.Add(gbxDatosCliente)
        TabPage1.Controls.Add(gbxGeneral)
        TabPage1.Controls.Add(gpxOrigen)
        TabPage1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1065, 251)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Principal"
        ' 
        ' gbxDatosCliente
        ' 
        gbxDatosCliente.BackColor = Color.Silver
        gbxDatosCliente.Controls.Add(cbxEsComercial)
        gbxDatosCliente.Controls.Add(LabelMultiIdioma25)
        gbxDatosCliente.Controls.Add(LabelMultiIdioma10)
        gbxDatosCliente.Controls.Add(tbxNifCliente)
        gbxDatosCliente.Controls.Add(tbiCodiClient)
        gbxDatosCliente.Controls.Add(LabelMultiIdioma11)
        gbxDatosCliente.Controls.Add(tbxNombreCliente)
        gbxDatosCliente.Controls.Add(LabelMultiIdioma12)
        gbxDatosCliente.Controls.Add(tbxMailCliente)
        gbxDatosCliente.Controls.Add(LabelMultiIdioma13)
        gbxDatosCliente.Location = New Point(3, 87)
        gbxDatosCliente.Name = "gbxDatosCliente"
        gbxDatosCliente.Size = New Size(457, 158)
        gbxDatosCliente.TabIndex = 17
        gbxDatosCliente.TabStop = False
        gbxDatosCliente.Text = "Datos Cliente"
        ' 
        ' cbxEsComercial
        ' 
        cbxEsComercial.AutoSize = True
        cbxEsComercial.Enabled = False
        cbxEsComercial.Location = New Point(181, 137)
        cbxEsComercial.Name = "cbxEsComercial"
        cbxEsComercial.Size = New Size(15, 14)
        cbxEsComercial.TabIndex = 25
        cbxEsComercial.UseVisualStyleBackColor = True
        ' 
        ' LabelMultiIdioma25
        ' 
        LabelMultiIdioma25.AutoEllipsis = True
        LabelMultiIdioma25.BackColor = Color.Khaki
        LabelMultiIdioma25.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma25.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma25.Location = New Point(6, 131)
        LabelMultiIdioma25.Name = "LabelMultiIdioma25"
        LabelMultiIdioma25.Size = New Size(172, 23)
        LabelMultiIdioma25.TabIndex = 24
        LabelMultiIdioma25.Text = "Es Comercial"
        LabelMultiIdioma25.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma25.TextoCastellano = "Es Comercial"
        LabelMultiIdioma25.TextoCatalan = "És Comercial"
        ' 
        ' LabelMultiIdioma10
        ' 
        LabelMultiIdioma10.AutoEllipsis = True
        LabelMultiIdioma10.BackColor = Color.Khaki
        LabelMultiIdioma10.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma10.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma10.Location = New Point(6, 104)
        LabelMultiIdioma10.Name = "LabelMultiIdioma10"
        LabelMultiIdioma10.Size = New Size(172, 23)
        LabelMultiIdioma10.TabIndex = 22
        LabelMultiIdioma10.Text = "NIF"
        LabelMultiIdioma10.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma10.TextoCastellano = "NIF"
        LabelMultiIdioma10.TextoCatalan = "NIF"
        ' 
        ' tbxNifCliente
        ' 
        tbxNifCliente.BackColor = SystemColors.GradientActiveCaption
        tbxNifCliente.BorderStyle = BorderStyle.FixedSingle
        tbxNifCliente.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbxNifCliente.Location = New Point(181, 105)
        tbxNifCliente.Name = "tbxNifCliente"
        tbxNifCliente.ReadOnly = True
        tbxNifCliente.Size = New Size(270, 23)
        tbxNifCliente.TabIndex = 23
        ' 
        ' tbiCodiClient
        ' 
        tbiCodiClient._Valor = ""
        tbiCodiClient.AutoSize = True
        tbiCodiClient.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tbiCodiClient.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        tbiCodiClient.Location = New Point(181, 21)
        tbiCodiClient.Margin = New Padding(4, 3, 4, 3)
        tbiCodiClient.Name = "tbiCodiClient"
        tbiCodiClient.Size = New Size(131, 30)
        tbiCodiClient.TabIndex = 21
        tbiCodiClient.uCampBD1 = "NomClient"
        tbiCodiClient.uCampBD2 = "Mail"
        tbiCodiClient.uCampBD3 = "IdTarifaPreferida"
        tbiCodiClient.uCampBD4 = "DireccionOrigenFavorita"
        tbiCodiClient.uCampBD5 = "NIF"
        tbiCodiClient.uCampBD6 = "EsComercial"
        tbiCodiClient.uObjRecord = Nothing
        tbiCodiClient.utbxCamp1 = tbxNombreCliente
        tbiCodiClient.utbxCamp2 = tbxMailCliente
        tbiCodiClient.utbxCamp3 = tbxTarifaFavClient
        tbiCodiClient.utbxCamp4 = tbxDireccionOrigen
        tbiCodiClient.utbxCamp5 = tbxNifCliente
        tbiCodiClient.utbxCamp6 = tbxEsComercial
        ' 
        ' tbxNombreCliente
        ' 
        tbxNombreCliente.BackColor = SystemColors.GradientActiveCaption
        tbxNombreCliente.BorderStyle = BorderStyle.FixedSingle
        tbxNombreCliente.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbxNombreCliente.Location = New Point(181, 51)
        tbxNombreCliente.Name = "tbxNombreCliente"
        tbxNombreCliente.ReadOnly = True
        tbxNombreCliente.Size = New Size(270, 23)
        tbxNombreCliente.TabIndex = 14
        ' 
        ' tbxMailCliente
        ' 
        tbxMailCliente.BackColor = SystemColors.GradientActiveCaption
        tbxMailCliente.BorderStyle = BorderStyle.FixedSingle
        tbxMailCliente.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbxMailCliente.Location = New Point(181, 78)
        tbxMailCliente.Name = "tbxMailCliente"
        tbxMailCliente.ReadOnly = True
        tbxMailCliente.Size = New Size(270, 23)
        tbxMailCliente.TabIndex = 12
        ' 
        ' tbxTarifaFavClient
        ' 
        tbxTarifaFavClient.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        tbxTarifaFavClient.Location = New Point(135, 285)
        tbxTarifaFavClient.Name = "tbxTarifaFavClient"
        tbxTarifaFavClient.Size = New Size(89, 23)
        tbxTarifaFavClient.TabIndex = 22
        tbxTarifaFavClient.Visible = False
        ' 
        ' tbxDireccionOrigen
        ' 
        tbxDireccionOrigen.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbxDireccionOrigen.Location = New Point(181, 46)
        tbxDireccionOrigen.MaxLength = 200
        tbxDireccionOrigen.Name = "tbxDireccionOrigen"
        tbxDireccionOrigen.Size = New Size(216, 23)
        tbxDireccionOrigen.TabIndex = 8
        ' 
        ' tbxEsComercial
        ' 
        tbxEsComercial.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        tbxEsComercial.Location = New Point(249, 285)
        tbxEsComercial.Name = "tbxEsComercial"
        tbxEsComercial.Size = New Size(89, 23)
        tbxEsComercial.TabIndex = 23
        tbxEsComercial.Visible = False
        ' 
        ' LabelMultiIdioma11
        ' 
        LabelMultiIdioma11.AutoEllipsis = True
        LabelMultiIdioma11.BackColor = Color.Khaki
        LabelMultiIdioma11.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma11.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma11.Location = New Point(6, 50)
        LabelMultiIdioma11.Name = "LabelMultiIdioma11"
        LabelMultiIdioma11.Size = New Size(172, 23)
        LabelMultiIdioma11.TabIndex = 13
        LabelMultiIdioma11.Text = "Nombre Cliente"
        LabelMultiIdioma11.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma11.TextoCastellano = "Nombre Cliente"
        LabelMultiIdioma11.TextoCatalan = "Nom Client"
        ' 
        ' LabelMultiIdioma12
        ' 
        LabelMultiIdioma12.AutoEllipsis = True
        LabelMultiIdioma12.BackColor = Color.Khaki
        LabelMultiIdioma12.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma12.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma12.Location = New Point(6, 77)
        LabelMultiIdioma12.Name = "LabelMultiIdioma12"
        LabelMultiIdioma12.Size = New Size(172, 23)
        LabelMultiIdioma12.TabIndex = 11
        LabelMultiIdioma12.Text = "Mail Cliente"
        LabelMultiIdioma12.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma12.TextoCastellano = "Mail Cliente"
        LabelMultiIdioma12.TextoCatalan = "Mail Client"
        ' 
        ' LabelMultiIdioma13
        ' 
        LabelMultiIdioma13.AutoEllipsis = True
        LabelMultiIdioma13.BackColor = Color.Khaki
        LabelMultiIdioma13.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma13.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma13.Location = New Point(6, 23)
        LabelMultiIdioma13.Name = "LabelMultiIdioma13"
        LabelMultiIdioma13.Size = New Size(172, 23)
        LabelMultiIdioma13.TabIndex = 9
        LabelMultiIdioma13.Text = "Código Cliente"
        LabelMultiIdioma13.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma13.TextoCastellano = "Código Cliente"
        LabelMultiIdioma13.TextoCatalan = "Codi Client"
        ' 
        ' gbxGeneral
        ' 
        gbxGeneral.BackColor = Color.Silver
        gbxGeneral.Controls.Add(cmbxEstat)
        gbxGeneral.Controls.Add(LabelMultiIdioma6)
        gbxGeneral.Controls.Add(LabelMultiIdioma1)
        gbxGeneral.Controls.Add(tbxPorte)
        gbxGeneral.Controls.Add(tbxDireccionOrigen)
        gbxGeneral.Controls.Add(LabelMultiIdioma7)
        gbxGeneral.Controls.Add(lblCodigoSeguimiento)
        gbxGeneral.Controls.Add(tbxPeso)
        gbxGeneral.Controls.Add(tbxCodigoSeguimiento)
        gbxGeneral.Controls.Add(LabelMultiIdioma8)
        gbxGeneral.Controls.Add(tbxDimensiones)
        gbxGeneral.Controls.Add(LabelMultiIdioma9)
        gbxGeneral.Location = New Point(3, 6)
        gbxGeneral.Name = "gbxGeneral"
        gbxGeneral.Size = New Size(1049, 79)
        gbxGeneral.TabIndex = 6
        gbxGeneral.TabStop = False
        gbxGeneral.Text = "General"
        ' 
        ' cmbxEstat
        ' 
        cmbxEstat.DropDownStyle = ComboBoxStyle.DropDownList
        cmbxEstat.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        cmbxEstat.FormattingEnabled = True
        cmbxEstat.ItemHeight = 15
        cmbxEstat.Location = New Point(577, 19)
        cmbxEstat.Name = "cmbxEstat"
        cmbxEstat.Size = New Size(131, 23)
        cmbxEstat.TabIndex = 17
        ' 
        ' LabelMultiIdioma6
        ' 
        LabelMultiIdioma6.AutoEllipsis = True
        LabelMultiIdioma6.BackColor = Color.Khaki
        LabelMultiIdioma6.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma6.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma6.Location = New Point(714, 45)
        LabelMultiIdioma6.Name = "LabelMultiIdioma6"
        LabelMultiIdioma6.Size = New Size(172, 23)
        LabelMultiIdioma6.TabIndex = 15
        LabelMultiIdioma6.Text = "Precio"
        LabelMultiIdioma6.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma6.TextoCastellano = "Precio"
        LabelMultiIdioma6.TextoCatalan = "Preu"
        ' 
        ' LabelMultiIdioma1
        ' 
        LabelMultiIdioma1.AutoEllipsis = True
        LabelMultiIdioma1.BackColor = Color.Khaki
        LabelMultiIdioma1.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma1.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma1.Location = New Point(6, 46)
        LabelMultiIdioma1.Name = "LabelMultiIdioma1"
        LabelMultiIdioma1.Size = New Size(172, 23)
        LabelMultiIdioma1.TabIndex = 7
        LabelMultiIdioma1.Text = "Dirección Origen"
        LabelMultiIdioma1.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma1.TextoCastellano = "Dirección Origen"
        LabelMultiIdioma1.TextoCatalan = "Direcció Origen"
        ' 
        ' tbxPorte
        ' 
        tbxPorte.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbxPorte.Location = New Point(889, 45)
        tbxPorte.Name = "tbxPorte"
        tbxPorte.Size = New Size(130, 23)
        tbxPorte.TabIndex = 16
        ' 
        ' LabelMultiIdioma7
        ' 
        LabelMultiIdioma7.AutoEllipsis = True
        LabelMultiIdioma7.BackColor = Color.Khaki
        LabelMultiIdioma7.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma7.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma7.Location = New Point(403, 45)
        LabelMultiIdioma7.Name = "LabelMultiIdioma7"
        LabelMultiIdioma7.Size = New Size(172, 23)
        LabelMultiIdioma7.TabIndex = 13
        LabelMultiIdioma7.Text = "Peso"
        LabelMultiIdioma7.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma7.TextoCastellano = "Peso"
        LabelMultiIdioma7.TextoCatalan = "Pes"
        ' 
        ' lblCodigoSeguimiento
        ' 
        lblCodigoSeguimiento.AutoEllipsis = True
        lblCodigoSeguimiento.BackColor = Color.Khaki
        lblCodigoSeguimiento.BorderStyle = BorderStyle.FixedSingle
        lblCodigoSeguimiento.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblCodigoSeguimiento.Location = New Point(6, 19)
        lblCodigoSeguimiento.Name = "lblCodigoSeguimiento"
        lblCodigoSeguimiento.Size = New Size(172, 23)
        lblCodigoSeguimiento.TabIndex = 5
        lblCodigoSeguimiento.Text = "Código Seguimiento"
        lblCodigoSeguimiento.TextAlign = ContentAlignment.MiddleCenter
        lblCodigoSeguimiento.TextoCastellano = "Código Seguimiento"
        lblCodigoSeguimiento.TextoCatalan = "Codi Seguiment"
        ' 
        ' tbxPeso
        ' 
        tbxPeso.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbxPeso.Location = New Point(578, 45)
        tbxPeso.Name = "tbxPeso"
        tbxPeso.Size = New Size(130, 23)
        tbxPeso.TabIndex = 14
        ' 
        ' tbxCodigoSeguimiento
        ' 
        tbxCodigoSeguimiento.BackColor = SystemColors.GradientActiveCaption
        tbxCodigoSeguimiento.BorderStyle = BorderStyle.FixedSingle
        tbxCodigoSeguimiento.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbxCodigoSeguimiento.Location = New Point(181, 19)
        tbxCodigoSeguimiento.MaxLength = 12
        tbxCodigoSeguimiento.Name = "tbxCodigoSeguimiento"
        tbxCodigoSeguimiento.ReadOnly = True
        tbxCodigoSeguimiento.Size = New Size(216, 23)
        tbxCodigoSeguimiento.TabIndex = 6
        ' 
        ' LabelMultiIdioma8
        ' 
        LabelMultiIdioma8.AutoEllipsis = True
        LabelMultiIdioma8.BackColor = Color.Khaki
        LabelMultiIdioma8.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma8.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma8.Location = New Point(714, 19)
        LabelMultiIdioma8.Name = "LabelMultiIdioma8"
        LabelMultiIdioma8.Size = New Size(172, 23)
        LabelMultiIdioma8.TabIndex = 11
        LabelMultiIdioma8.Text = "Dimensiones"
        LabelMultiIdioma8.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma8.TextoCastellano = "Dimensiones"
        LabelMultiIdioma8.TextoCatalan = "Dimensions"
        ' 
        ' tbxDimensiones
        ' 
        tbxDimensiones.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbxDimensiones.Location = New Point(889, 19)
        tbxDimensiones.MaxLength = 100
        tbxDimensiones.Name = "tbxDimensiones"
        tbxDimensiones.Size = New Size(130, 23)
        tbxDimensiones.TabIndex = 12
        ' 
        ' LabelMultiIdioma9
        ' 
        LabelMultiIdioma9.AutoEllipsis = True
        LabelMultiIdioma9.BackColor = Color.Khaki
        LabelMultiIdioma9.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma9.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma9.Location = New Point(403, 19)
        LabelMultiIdioma9.Name = "LabelMultiIdioma9"
        LabelMultiIdioma9.Size = New Size(172, 23)
        LabelMultiIdioma9.TabIndex = 9
        LabelMultiIdioma9.Text = "Estado Envío"
        LabelMultiIdioma9.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma9.TextoCastellano = "Estado Envío"
        LabelMultiIdioma9.TextoCatalan = "Estat Enviament"
        ' 
        ' gpxOrigen
        ' 
        gpxOrigen.BackColor = Color.Silver
        gpxOrigen.Controls.Add(tbiRuta)
        gpxOrigen.Controls.Add(lblMailDestinatari)
        gpxOrigen.Controls.Add(tbxRuta)
        gpxOrigen.Controls.Add(tbxMailDestinatari)
        gpxOrigen.Controls.Add(LabelMultiIdioma24)
        gpxOrigen.Controls.Add(LabelMultiIdioma5)
        gpxOrigen.Controls.Add(tbxNombreDestinatario)
        gpxOrigen.Controls.Add(LabelMultiIdioma4)
        gpxOrigen.Controls.Add(tbxPoblacionDestino)
        gpxOrigen.Controls.Add(LabelMultiIdioma3)
        gpxOrigen.Controls.Add(tbxCPDestino)
        gpxOrigen.Controls.Add(LabelMultiIdioma2)
        gpxOrigen.Controls.Add(tbxDireccionDestino)
        gpxOrigen.Location = New Point(466, 87)
        gpxOrigen.Name = "gpxOrigen"
        gpxOrigen.Size = New Size(586, 158)
        gpxOrigen.TabIndex = 5
        gpxOrigen.TabStop = False
        gpxOrigen.Text = "Datos Destino"
        ' 
        ' tbiRuta
        ' 
        tbiRuta._Valor = ""
        tbiRuta.AutoSize = True
        tbiRuta.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tbiRuta.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        tbiRuta.Location = New Point(180, 128)
        tbiRuta.Margin = New Padding(4, 3, 4, 3)
        tbiRuta.Name = "tbiRuta"
        tbiRuta.Size = New Size(131, 30)
        tbiRuta.TabIndex = 26
        tbiRuta.uCampBD1 = "Nom"
        tbiRuta.uCampBD2 = ""
        tbiRuta.uCampBD3 = ""
        tbiRuta.uCampBD4 = ""
        tbiRuta.uCampBD5 = ""
        tbiRuta.uCampBD6 = Nothing
        tbiRuta.uObjRecord = Nothing
        tbiRuta.utbxCamp1 = tbxRuta
        tbiRuta.utbxCamp2 = Nothing
        tbiRuta.utbxCamp3 = Nothing
        tbiRuta.utbxCamp4 = Nothing
        tbiRuta.utbxCamp5 = Nothing
        tbiRuta.utbxCamp6 = Nothing
        ' 
        ' tbxRuta
        ' 
        tbxRuta.BackColor = SystemColors.GradientActiveCaption
        tbxRuta.BorderStyle = BorderStyle.FixedSingle
        tbxRuta.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbxRuta.Location = New Point(311, 130)
        tbxRuta.Name = "tbxRuta"
        tbxRuta.ReadOnly = True
        tbxRuta.Size = New Size(266, 23)
        tbxRuta.TabIndex = 25
        ' 
        ' lblMailDestinatari
        ' 
        lblMailDestinatari.AutoEllipsis = True
        lblMailDestinatari.BackColor = Color.Khaki
        lblMailDestinatari.BorderStyle = BorderStyle.FixedSingle
        lblMailDestinatari.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblMailDestinatari.Location = New Point(267, 104)
        lblMailDestinatari.Name = "lblMailDestinatari"
        lblMailDestinatari.Size = New Size(71, 23)
        lblMailDestinatari.TabIndex = 17
        lblMailDestinatari.Text = "Mail"
        lblMailDestinatari.TextAlign = ContentAlignment.MiddleCenter
        lblMailDestinatari.TextoCastellano = "Mail"
        lblMailDestinatari.TextoCatalan = "Mail"
        ' 
        ' tbxMailDestinatari
        ' 
        tbxMailDestinatari.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbxMailDestinatari.Location = New Point(341, 104)
        tbxMailDestinatari.MaxLength = 100
        tbxMailDestinatari.Name = "tbxMailDestinatari"
        tbxMailDestinatari.Size = New Size(236, 23)
        tbxMailDestinatari.TabIndex = 18
        ' 
        ' LabelMultiIdioma24
        ' 
        LabelMultiIdioma24.AutoEllipsis = True
        LabelMultiIdioma24.BackColor = Color.Khaki
        LabelMultiIdioma24.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma24.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma24.Location = New Point(6, 131)
        LabelMultiIdioma24.Name = "LabelMultiIdioma24"
        LabelMultiIdioma24.Size = New Size(172, 23)
        LabelMultiIdioma24.TabIndex = 24
        LabelMultiIdioma24.Text = "Código Cliente"
        LabelMultiIdioma24.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma24.TextoCastellano = "Código Cliente"
        LabelMultiIdioma24.TextoCatalan = "Codi Client"
        ' 
        ' LabelMultiIdioma5
        ' 
        LabelMultiIdioma5.AutoEllipsis = True
        LabelMultiIdioma5.BackColor = Color.Khaki
        LabelMultiIdioma5.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma5.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma5.Location = New Point(6, 50)
        LabelMultiIdioma5.Name = "LabelMultiIdioma5"
        LabelMultiIdioma5.Size = New Size(172, 23)
        LabelMultiIdioma5.TabIndex = 15
        LabelMultiIdioma5.Text = "Nombre Destinatario"
        LabelMultiIdioma5.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma5.TextoCastellano = "Nombre Destinatario"
        LabelMultiIdioma5.TextoCatalan = "Nom Destinatari"
        ' 
        ' tbxNombreDestinatario
        ' 
        tbxNombreDestinatario.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbxNombreDestinatario.Location = New Point(181, 50)
        tbxNombreDestinatario.MaxLength = 100
        tbxNombreDestinatario.Name = "tbxNombreDestinatario"
        tbxNombreDestinatario.Size = New Size(399, 23)
        tbxNombreDestinatario.TabIndex = 16
        ' 
        ' LabelMultiIdioma4
        ' 
        LabelMultiIdioma4.AutoEllipsis = True
        LabelMultiIdioma4.BackColor = Color.Khaki
        LabelMultiIdioma4.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma4.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma4.Location = New Point(6, 77)
        LabelMultiIdioma4.Name = "LabelMultiIdioma4"
        LabelMultiIdioma4.Size = New Size(172, 23)
        LabelMultiIdioma4.TabIndex = 13
        LabelMultiIdioma4.Text = "Población Destino"
        LabelMultiIdioma4.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma4.TextoCastellano = "Población Destino"
        LabelMultiIdioma4.TextoCatalan = "Població Destí"
        ' 
        ' tbxPoblacionDestino
        ' 
        tbxPoblacionDestino.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbxPoblacionDestino.Location = New Point(181, 77)
        tbxPoblacionDestino.MaxLength = 50
        tbxPoblacionDestino.Name = "tbxPoblacionDestino"
        tbxPoblacionDestino.Size = New Size(130, 23)
        tbxPoblacionDestino.TabIndex = 14
        ' 
        ' LabelMultiIdioma3
        ' 
        LabelMultiIdioma3.AutoEllipsis = True
        LabelMultiIdioma3.BackColor = Color.Khaki
        LabelMultiIdioma3.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma3.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma3.Location = New Point(6, 104)
        LabelMultiIdioma3.Name = "LabelMultiIdioma3"
        LabelMultiIdioma3.Size = New Size(172, 23)
        LabelMultiIdioma3.TabIndex = 11
        LabelMultiIdioma3.Text = "CP Destino"
        LabelMultiIdioma3.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma3.TextoCastellano = "CP Destino"
        LabelMultiIdioma3.TextoCatalan = "CP Destí"
        ' 
        ' tbxCPDestino
        ' 
        tbxCPDestino.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbxCPDestino.Location = New Point(181, 104)
        tbxCPDestino.MaxLength = 10
        tbxCPDestino.Name = "tbxCPDestino"
        tbxCPDestino.Size = New Size(80, 23)
        tbxCPDestino.TabIndex = 12
        ' 
        ' LabelMultiIdioma2
        ' 
        LabelMultiIdioma2.AutoEllipsis = True
        LabelMultiIdioma2.BackColor = Color.Khaki
        LabelMultiIdioma2.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma2.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma2.Location = New Point(6, 23)
        LabelMultiIdioma2.Name = "LabelMultiIdioma2"
        LabelMultiIdioma2.Size = New Size(172, 23)
        LabelMultiIdioma2.TabIndex = 9
        LabelMultiIdioma2.Text = "Dirección Destino"
        LabelMultiIdioma2.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma2.TextoCastellano = "Dirección Destino"
        LabelMultiIdioma2.TextoCatalan = "Direcció Destí"
        ' 
        ' tbxDireccionDestino
        ' 
        tbxDireccionDestino.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbxDireccionDestino.Location = New Point(181, 23)
        tbxDireccionDestino.MaxLength = 200
        tbxDireccionDestino.Name = "tbxDireccionDestino"
        tbxDireccionDestino.Size = New Size(399, 23)
        tbxDireccionDestino.TabIndex = 10
        ' 
        ' TabControl1
        ' 
        TabControl1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(pgeTarifa)
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1073, 279)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(dgvHistorico)
        TabPage2.Controls.Add(btnTreureHistoric)
        TabPage2.Controls.Add(btnAfegirHistoric)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1065, 251)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Histórico"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' dgvHistorico
        ' 
        dgvHistorico.AccessibleName = "Table"
        dgvHistorico.AllowEditing = False
        dgvHistorico.AllowGrouping = False
        dgvHistorico.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvHistorico.Location = New Point(0, 0)
        dgvHistorico.Name = "dgvHistorico"
        dgvHistorico.Size = New Size(946, 248)
        dgvHistorico.Style.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        dgvHistorico.Style.CheckBoxStyle.CheckedBackColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        dgvHistorico.Style.CheckBoxStyle.CheckedBorderColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        dgvHistorico.Style.CheckBoxStyle.IndeterminateBorderColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        dgvHistorico.Style.HeaderStyle.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        dgvHistorico.Style.HeaderStyle.Font.Bold = True
        dgvHistorico.Style.HyperlinkStyle.DefaultLinkColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        dgvHistorico.TabIndex = 35
        dgvHistorico.Text = "SfDataGrid1"
        ' 
        ' btnTreureHistoric
        ' 
        btnTreureHistoric.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnTreureHistoric.AutoSize = True
        btnTreureHistoric.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnTreureHistoric.Image = CType(resources.GetObject("btnTreureHistoric.Image"), Image)
        btnTreureHistoric.ImageAlign = ContentAlignment.MiddleLeft
        btnTreureHistoric.Location = New Point(952, 54)
        btnTreureHistoric.Name = "btnTreureHistoric"
        btnTreureHistoric.Size = New Size(111, 42)
        btnTreureHistoric.TabIndex = 3
        btnTreureHistoric.Text = "Quitar"
        btnTreureHistoric.TextoCastellano = "Quitar"
        btnTreureHistoric.TextoCatalan = "Treure"
        btnTreureHistoric.UseVisualStyleBackColor = True
        ' 
        ' btnAfegirHistoric
        ' 
        btnAfegirHistoric.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnAfegirHistoric.AutoSize = True
        btnAfegirHistoric.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnAfegirHistoric.Image = CType(resources.GetObject("btnAfegirHistoric.Image"), Image)
        btnAfegirHistoric.ImageAlign = ContentAlignment.MiddleLeft
        btnAfegirHistoric.Location = New Point(952, 6)
        btnAfegirHistoric.Name = "btnAfegirHistoric"
        btnAfegirHistoric.Size = New Size(111, 42)
        btnAfegirHistoric.TabIndex = 2
        btnAfegirHistoric.Text = "Añadir"
        btnAfegirHistoric.TextoCastellano = "Añadir"
        btnAfegirHistoric.TextoCatalan = "Afegir"
        btnAfegirHistoric.UseVisualStyleBackColor = True
        ' 
        ' pgeTarifa
        ' 
        pgeTarifa.Controls.Add(pnlTarifa)
        pgeTarifa.Controls.Add(gbxEntrarTarifa)
        pgeTarifa.Location = New Point(4, 24)
        pgeTarifa.Name = "pgeTarifa"
        pgeTarifa.Padding = New Padding(3)
        pgeTarifa.Size = New Size(1065, 251)
        pgeTarifa.TabIndex = 2
        pgeTarifa.Text = "Calculador Tarifa"
        pgeTarifa.UseVisualStyleBackColor = True
        ' 
        ' pnlTarifa
        ' 
        pnlTarifa.Controls.Add(gbxPrecios)
        pnlTarifa.Controls.Add(gbxTarifa)
        pnlTarifa.Controls.Add(gbxCaracEnvio)
        pnlTarifa.Controls.Add(gbxOrigenDesti)
        pnlTarifa.Location = New Point(0, 0)
        pnlTarifa.Name = "pnlTarifa"
        pnlTarifa.Size = New Size(1069, 251)
        pnlTarifa.TabIndex = 3
        ' 
        ' gbxPrecios
        ' 
        gbxPrecios.BackColor = Color.Silver
        gbxPrecios.Controls.Add(btnAcceptarTarifa)
        gbxPrecios.Controls.Add(btnCalcularPorte)
        gbxPrecios.Controls.Add(LabelMultiIdioma22)
        gbxPrecios.Controls.Add(tbxPrecioNoClienteCT)
        gbxPrecios.Controls.Add(LabelMultiIdioma19)
        gbxPrecios.Controls.Add(tbxPrecioClienteCT)
        gbxPrecios.Controls.Add(LabelMultiIdioma18)
        gbxPrecios.Controls.Add(tbxDistanciaTotalCT)
        gbxPrecios.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        gbxPrecios.Location = New Point(580, 10)
        gbxPrecios.Name = "gbxPrecios"
        gbxPrecios.Size = New Size(480, 226)
        gbxPrecios.TabIndex = 21
        gbxPrecios.TabStop = False
        gbxPrecios.Text = "Precios"
        ' 
        ' btnAcceptarTarifa
        ' 
        btnAcceptarTarifa.AutoSize = True
        btnAcceptarTarifa.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnAcceptarTarifa.Image = CType(resources.GetObject("btnAcceptarTarifa.Image"), Image)
        btnAcceptarTarifa.ImageAlign = ContentAlignment.MiddleLeft
        btnAcceptarTarifa.Location = New Point(151, 164)
        btnAcceptarTarifa.Name = "btnAcceptarTarifa"
        btnAcceptarTarifa.Size = New Size(152, 38)
        btnAcceptarTarifa.TabIndex = 26
        btnAcceptarTarifa.Text = "Aceptar Tarifa"
        btnAcceptarTarifa.TextAlign = ContentAlignment.MiddleRight
        btnAcceptarTarifa.TextoCastellano = "Aceptar Tarifa"
        btnAcceptarTarifa.TextoCatalan = "Acceptar Tarifa"
        btnAcceptarTarifa.UseVisualStyleBackColor = True
        ' 
        ' btnCalcularPorte
        ' 
        btnCalcularPorte.AutoSize = True
        btnCalcularPorte.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnCalcularPorte.Image = CType(resources.GetObject("btnCalcularPorte.Image"), Image)
        btnCalcularPorte.ImageAlign = ContentAlignment.MiddleLeft
        btnCalcularPorte.Location = New Point(151, 17)
        btnCalcularPorte.Name = "btnCalcularPorte"
        btnCalcularPorte.Size = New Size(152, 37)
        btnCalcularPorte.TabIndex = 0
        btnCalcularPorte.Text = "Calcular"
        btnCalcularPorte.TextoCastellano = "Calcular"
        btnCalcularPorte.TextoCatalan = "Calcular"
        btnCalcularPorte.UseVisualStyleBackColor = True
        ' 
        ' LabelMultiIdioma22
        ' 
        LabelMultiIdioma22.AutoEllipsis = True
        LabelMultiIdioma22.BackColor = Color.Khaki
        LabelMultiIdioma22.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma22.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma22.Location = New Point(279, 94)
        LabelMultiIdioma22.Name = "LabelMultiIdioma22"
        LabelMultiIdioma22.Size = New Size(172, 23)
        LabelMultiIdioma22.TabIndex = 25
        LabelMultiIdioma22.Text = "Precio NO Cliente"
        LabelMultiIdioma22.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma22.TextoCastellano = "Precio NO Cliente"
        LabelMultiIdioma22.TextoCatalan = "Preu NO Client"
        ' 
        ' tbxPrecioNoClienteCT
        ' 
        tbxPrecioNoClienteCT.BackColor = SystemColors.ActiveCaption
        tbxPrecioNoClienteCT.BorderStyle = BorderStyle.FixedSingle
        tbxPrecioNoClienteCT.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        tbxPrecioNoClienteCT.Location = New Point(279, 120)
        tbxPrecioNoClienteCT.Name = "tbxPrecioNoClienteCT"
        tbxPrecioNoClienteCT.ReadOnly = True
        tbxPrecioNoClienteCT.Size = New Size(172, 23)
        tbxPrecioNoClienteCT.TabIndex = 24
        ' 
        ' LabelMultiIdioma19
        ' 
        LabelMultiIdioma19.AutoEllipsis = True
        LabelMultiIdioma19.BackColor = Color.Khaki
        LabelMultiIdioma19.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma19.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma19.Location = New Point(6, 94)
        LabelMultiIdioma19.Name = "LabelMultiIdioma19"
        LabelMultiIdioma19.Size = New Size(172, 23)
        LabelMultiIdioma19.TabIndex = 23
        LabelMultiIdioma19.Text = "Precio Cliente"
        LabelMultiIdioma19.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma19.TextoCastellano = "Precio Cliente"
        LabelMultiIdioma19.TextoCatalan = "Preu Client"
        ' 
        ' tbxPrecioClienteCT
        ' 
        tbxPrecioClienteCT.BackColor = SystemColors.ActiveCaption
        tbxPrecioClienteCT.BorderStyle = BorderStyle.FixedSingle
        tbxPrecioClienteCT.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        tbxPrecioClienteCT.Location = New Point(6, 120)
        tbxPrecioClienteCT.Name = "tbxPrecioClienteCT"
        tbxPrecioClienteCT.ReadOnly = True
        tbxPrecioClienteCT.Size = New Size(172, 23)
        tbxPrecioClienteCT.TabIndex = 22
        ' 
        ' LabelMultiIdioma18
        ' 
        LabelMultiIdioma18.AutoEllipsis = True
        LabelMultiIdioma18.BackColor = Color.Khaki
        LabelMultiIdioma18.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma18.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma18.Location = New Point(6, 59)
        LabelMultiIdioma18.Name = "LabelMultiIdioma18"
        LabelMultiIdioma18.Size = New Size(172, 23)
        LabelMultiIdioma18.TabIndex = 21
        LabelMultiIdioma18.Text = "Distancia Total (KMs)"
        LabelMultiIdioma18.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma18.TextoCastellano = "Distancia Total (KMs)"
        LabelMultiIdioma18.TextoCatalan = "Distància Total (KMs)"
        ' 
        ' tbxDistanciaTotalCT
        ' 
        tbxDistanciaTotalCT.BackColor = SystemColors.ActiveCaption
        tbxDistanciaTotalCT.BorderStyle = BorderStyle.FixedSingle
        tbxDistanciaTotalCT.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        tbxDistanciaTotalCT.Location = New Point(181, 59)
        tbxDistanciaTotalCT.Name = "tbxDistanciaTotalCT"
        tbxDistanciaTotalCT.ReadOnly = True
        tbxDistanciaTotalCT.Size = New Size(89, 23)
        tbxDistanciaTotalCT.TabIndex = 20
        ' 
        ' gbxTarifa
        ' 
        gbxTarifa.BackColor = Color.Silver
        gbxTarifa.Controls.Add(cmbxTarifas)
        gbxTarifa.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        gbxTarifa.Location = New Point(292, 10)
        gbxTarifa.Name = "gbxTarifa"
        gbxTarifa.Size = New Size(282, 135)
        gbxTarifa.TabIndex = 20
        gbxTarifa.TabStop = False
        gbxTarifa.Text = "Tarifa"
        ' 
        ' cmbxTarifas
        ' 
        cmbxTarifas.DropDownStyle = ComboBoxStyle.DropDownList
        cmbxTarifas.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        cmbxTarifas.FormattingEnabled = True
        cmbxTarifas.Location = New Point(46, 59)
        cmbxTarifas.Name = "cmbxTarifas"
        cmbxTarifas.Size = New Size(189, 29)
        cmbxTarifas.TabIndex = 21
        ' 
        ' gbxCaracEnvio
        ' 
        gbxCaracEnvio.BackColor = Color.Silver
        gbxCaracEnvio.Controls.Add(LabelMultiIdioma16)
        gbxCaracEnvio.Controls.Add(LabelMultiIdioma17)
        gbxCaracEnvio.Controls.Add(tbxFondoCT)
        gbxCaracEnvio.Controls.Add(tbxAnchoCT)
        gbxCaracEnvio.Controls.Add(LabelMultiIdioma14)
        gbxCaracEnvio.Controls.Add(LabelMultiIdioma15)
        gbxCaracEnvio.Controls.Add(tbxAltoCT)
        gbxCaracEnvio.Controls.Add(tbxPesoCT)
        gbxCaracEnvio.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        gbxCaracEnvio.Location = New Point(4, 10)
        gbxCaracEnvio.Name = "gbxCaracEnvio"
        gbxCaracEnvio.Size = New Size(282, 135)
        gbxCaracEnvio.TabIndex = 7
        gbxCaracEnvio.TabStop = False
        gbxCaracEnvio.Text = "Caracteríticas Envío"
        ' 
        ' LabelMultiIdioma16
        ' 
        LabelMultiIdioma16.AutoEllipsis = True
        LabelMultiIdioma16.BackColor = Color.Khaki
        LabelMultiIdioma16.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma16.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma16.Location = New Point(6, 76)
        LabelMultiIdioma16.Name = "LabelMultiIdioma16"
        LabelMultiIdioma16.Size = New Size(172, 23)
        LabelMultiIdioma16.TabIndex = 19
        LabelMultiIdioma16.Text = "Ancho"
        LabelMultiIdioma16.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma16.TextoCastellano = "Ancho"
        LabelMultiIdioma16.TextoCatalan = "Ample"
        ' 
        ' LabelMultiIdioma17
        ' 
        LabelMultiIdioma17.AutoEllipsis = True
        LabelMultiIdioma17.BackColor = Color.Khaki
        LabelMultiIdioma17.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma17.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma17.Location = New Point(6, 103)
        LabelMultiIdioma17.Name = "LabelMultiIdioma17"
        LabelMultiIdioma17.Size = New Size(172, 23)
        LabelMultiIdioma17.TabIndex = 18
        LabelMultiIdioma17.Text = "Alto"
        LabelMultiIdioma17.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma17.TextoCastellano = "Alto"
        LabelMultiIdioma17.TextoCatalan = "Altura"
        ' 
        ' tbxFondoCT
        ' 
        tbxFondoCT.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbxFondoCT.Location = New Point(181, 103)
        tbxFondoCT.Name = "tbxFondoCT"
        tbxFondoCT.Size = New Size(89, 23)
        tbxFondoCT.TabIndex = 17
        ' 
        ' tbxAnchoCT
        ' 
        tbxAnchoCT.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        tbxAnchoCT.Location = New Point(181, 76)
        tbxAnchoCT.Name = "tbxAnchoCT"
        tbxAnchoCT.Size = New Size(89, 23)
        tbxAnchoCT.TabIndex = 16
        ' 
        ' LabelMultiIdioma14
        ' 
        LabelMultiIdioma14.AutoEllipsis = True
        LabelMultiIdioma14.BackColor = Color.Khaki
        LabelMultiIdioma14.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma14.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma14.Location = New Point(6, 23)
        LabelMultiIdioma14.Name = "LabelMultiIdioma14"
        LabelMultiIdioma14.Size = New Size(172, 23)
        LabelMultiIdioma14.TabIndex = 15
        LabelMultiIdioma14.Text = "Peso"
        LabelMultiIdioma14.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma14.TextoCastellano = "Peso"
        LabelMultiIdioma14.TextoCatalan = "Pes"
        ' 
        ' LabelMultiIdioma15
        ' 
        LabelMultiIdioma15.AutoEllipsis = True
        LabelMultiIdioma15.BackColor = Color.Khaki
        LabelMultiIdioma15.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma15.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma15.Location = New Point(6, 50)
        LabelMultiIdioma15.Name = "LabelMultiIdioma15"
        LabelMultiIdioma15.Size = New Size(172, 23)
        LabelMultiIdioma15.TabIndex = 14
        LabelMultiIdioma15.Text = "Largo"
        LabelMultiIdioma15.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma15.TextoCastellano = "Largo"
        LabelMultiIdioma15.TextoCatalan = "Llargada"
        ' 
        ' tbxAltoCT
        ' 
        tbxAltoCT.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbxAltoCT.Location = New Point(181, 50)
        tbxAltoCT.Name = "tbxAltoCT"
        tbxAltoCT.Size = New Size(89, 23)
        tbxAltoCT.TabIndex = 8
        ' 
        ' tbxPesoCT
        ' 
        tbxPesoCT.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        tbxPesoCT.Location = New Point(181, 23)
        tbxPesoCT.Name = "tbxPesoCT"
        tbxPesoCT.Size = New Size(89, 23)
        tbxPesoCT.TabIndex = 6
        ' 
        ' gbxOrigenDesti
        ' 
        gbxOrigenDesti.BackColor = Color.Silver
        gbxOrigenDesti.Controls.Add(LabelMultiIdioma20)
        gbxOrigenDesti.Controls.Add(LabelMultiIdioma21)
        gbxOrigenDesti.Controls.Add(tbxDireccioDestiCT)
        gbxOrigenDesti.Controls.Add(tbxDireccioOrigenCT)
        gbxOrigenDesti.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        gbxOrigenDesti.Location = New Point(4, 151)
        gbxOrigenDesti.Name = "gbxOrigenDesti"
        gbxOrigenDesti.Size = New Size(570, 85)
        gbxOrigenDesti.TabIndex = 20
        gbxOrigenDesti.TabStop = False
        gbxOrigenDesti.Text = "Origen y Destino"
        ' 
        ' LabelMultiIdioma20
        ' 
        LabelMultiIdioma20.AutoEllipsis = True
        LabelMultiIdioma20.BackColor = Color.Khaki
        LabelMultiIdioma20.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma20.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma20.Location = New Point(6, 23)
        LabelMultiIdioma20.Name = "LabelMultiIdioma20"
        LabelMultiIdioma20.Size = New Size(172, 23)
        LabelMultiIdioma20.TabIndex = 15
        LabelMultiIdioma20.Text = "Origen"
        LabelMultiIdioma20.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma20.TextoCastellano = "Origen"
        LabelMultiIdioma20.TextoCatalan = "Origen"
        ' 
        ' LabelMultiIdioma21
        ' 
        LabelMultiIdioma21.AutoEllipsis = True
        LabelMultiIdioma21.BackColor = Color.Khaki
        LabelMultiIdioma21.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma21.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma21.Location = New Point(6, 50)
        LabelMultiIdioma21.Name = "LabelMultiIdioma21"
        LabelMultiIdioma21.Size = New Size(172, 23)
        LabelMultiIdioma21.TabIndex = 14
        LabelMultiIdioma21.Text = "Destino"
        LabelMultiIdioma21.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma21.TextoCastellano = "Destino"
        LabelMultiIdioma21.TextoCatalan = "Destí"
        ' 
        ' tbxDireccioDestiCT
        ' 
        tbxDireccioDestiCT.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbxDireccioDestiCT.Location = New Point(181, 50)
        tbxDireccioDestiCT.Name = "tbxDireccioDestiCT"
        tbxDireccioDestiCT.Size = New Size(383, 23)
        tbxDireccioDestiCT.TabIndex = 8
        ' 
        ' tbxDireccioOrigenCT
        ' 
        tbxDireccioOrigenCT.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        tbxDireccioOrigenCT.Location = New Point(181, 23)
        tbxDireccioOrigenCT.Name = "tbxDireccioOrigenCT"
        tbxDireccioOrigenCT.Size = New Size(383, 23)
        tbxDireccioOrigenCT.TabIndex = 6
        ' 
        ' gbxEntrarTarifa
        ' 
        gbxEntrarTarifa.BackColor = Color.Silver
        gbxEntrarTarifa.Controls.Add(LabelMultiIdioma23)
        gbxEntrarTarifa.Controls.Add(btnEntrarTarifa)
        gbxEntrarTarifa.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        gbxEntrarTarifa.Location = New Point(274, 107)
        gbxEntrarTarifa.Name = "gbxEntrarTarifa"
        gbxEntrarTarifa.Size = New Size(570, 85)
        gbxEntrarTarifa.TabIndex = 21
        gbxEntrarTarifa.TabStop = False
        gbxEntrarTarifa.Text = "Entrar Tarifa"
        ' 
        ' LabelMultiIdioma23
        ' 
        LabelMultiIdioma23.AutoSize = True
        LabelMultiIdioma23.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma23.Location = New Point(9, 38)
        LabelMultiIdioma23.Name = "LabelMultiIdioma23"
        LabelMultiIdioma23.Size = New Size(284, 20)
        LabelMultiIdioma23.TabIndex = 28
        LabelMultiIdioma23.Text = "Nota: Primero rellenar los datos del envío"
        LabelMultiIdioma23.TextoCastellano = "Nota: Primero rellenar los datos del envío"
        LabelMultiIdioma23.TextoCatalan = "Nota: Primer emplenar les dades del enviament"
        ' 
        ' btnEntrarTarifa
        ' 
        btnEntrarTarifa.AutoSize = True
        btnEntrarTarifa.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnEntrarTarifa.Image = CType(resources.GetObject("btnEntrarTarifa.Image"), Image)
        btnEntrarTarifa.ImageAlign = ContentAlignment.MiddleLeft
        btnEntrarTarifa.Location = New Point(363, 32)
        btnEntrarTarifa.Name = "btnEntrarTarifa"
        btnEntrarTarifa.Size = New Size(118, 38)
        btnEntrarTarifa.TabIndex = 27
        btnEntrarTarifa.Text = "Entrar Tarifa"
        btnEntrarTarifa.TextAlign = ContentAlignment.MiddleRight
        btnEntrarTarifa.TextoCastellano = "Entrar Tarifa"
        btnEntrarTarifa.TextoCatalan = "Entrar Tarifa"
        btnEntrarTarifa.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnGuardar.AutoSize = True
        btnGuardar.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), Image)
        btnGuardar.ImageAlign = ContentAlignment.MiddleLeft
        btnGuardar.Location = New Point(832, 287)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(111, 30)
        btnGuardar.TabIndex = 0
        btnGuardar.Text = "Guardar"
        btnGuardar.TextoCastellano = "Guardar"
        btnGuardar.TextoCatalan = "Desar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnCancelar.AutoSize = True
        btnCancelar.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), Image)
        btnCancelar.ImageAlign = ContentAlignment.MiddleLeft
        btnCancelar.Location = New Point(949, 287)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(116, 30)
        btnCancelar.TabIndex = 1
        btnCancelar.Text = "Cancelar"
        btnCancelar.TextoCastellano = "Cancelar"
        btnCancelar.TextoCatalan = "Cancel·lar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' tbxSize
        ' 
        tbxSize.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        tbxSize.Location = New Point(344, 290)
        tbxSize.Name = "tbxSize"
        tbxSize.Size = New Size(89, 23)
        tbxSize.TabIndex = 20
        tbxSize.Visible = False
        ' 
        ' btnBorrar
        ' 
        btnBorrar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnBorrar.AutoSize = True
        btnBorrar.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), Image)
        btnBorrar.ImageAlign = ContentAlignment.MiddleLeft
        btnBorrar.Location = New Point(13, 287)
        btnBorrar.Name = "btnBorrar"
        btnBorrar.Size = New Size(116, 30)
        btnBorrar.TabIndex = 21
        btnBorrar.Text = "Borrar"
        btnBorrar.TextoCastellano = "Borrar"
        btnBorrar.TextoCatalan = "Esborrar"
        btnBorrar.UseVisualStyleBackColor = True
        ' 
        ' btnAbrirFactura
        ' 
        btnAbrirFactura.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnAbrirFactura.AutoSize = True
        btnAbrirFactura.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnAbrirFactura.Image = CType(resources.GetObject("btnAbrirFactura.Image"), Image)
        btnAbrirFactura.ImageAlign = ContentAlignment.MiddleLeft
        btnAbrirFactura.Location = New Point(506, 287)
        btnAbrirFactura.Name = "btnAbrirFactura"
        btnAbrirFactura.Size = New Size(194, 30)
        btnAbrirFactura.TabIndex = 24
        btnAbrirFactura.Text = "Abrir Factura"
        btnAbrirFactura.TextoCastellano = "Abrir Factura"
        btnAbrirFactura.TextoCatalan = "Obrir Factura"
        btnAbrirFactura.UseVisualStyleBackColor = True
        ' 
        ' frmEnvios
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1071, 325)
        Controls.Add(btnAbrirFactura)
        Controls.Add(tbxEsComercial)
        Controls.Add(tbxTarifaFavClient)
        Controls.Add(btnBorrar)
        Controls.Add(tbxSize)
        Controls.Add(btnCancelar)
        Controls.Add(btnGuardar)
        Controls.Add(TabControl1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmEnvios"
        Text = "frmEnvios"
        TabPage1.ResumeLayout(False)
        gbxDatosCliente.ResumeLayout(False)
        gbxDatosCliente.PerformLayout()
        gbxGeneral.ResumeLayout(False)
        gbxGeneral.PerformLayout()
        gpxOrigen.ResumeLayout(False)
        gpxOrigen.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(dgvHistorico, ComponentModel.ISupportInitialize).EndInit()
        pgeTarifa.ResumeLayout(False)
        pnlTarifa.ResumeLayout(False)
        gbxPrecios.ResumeLayout(False)
        gbxPrecios.PerformLayout()
        gbxTarifa.ResumeLayout(False)
        gbxCaracEnvio.ResumeLayout(False)
        gbxCaracEnvio.PerformLayout()
        gbxOrigenDesti.ResumeLayout(False)
        gbxOrigenDesti.PerformLayout()
        gbxEntrarTarifa.ResumeLayout(False)
        gbxEntrarTarifa.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents btnGuardar As ButtonMultiIdioma
    Friend WithEvents btnCancelar As ButtonMultiIdioma
    Friend WithEvents gpxOrigen As GroupBox
    Friend WithEvents gbxGeneral As GroupBox
    Friend WithEvents LabelMultiIdioma1 As LabelMultiIdioma
    Friend WithEvents tbxDireccionOrigen As TextBox
    Friend WithEvents lblCodigoSeguimiento As LabelMultiIdioma
    Friend WithEvents tbxCodigoSeguimiento As TextBox
    Friend WithEvents LabelMultiIdioma5 As LabelMultiIdioma
    Friend WithEvents tbxNombreDestinatario As TextBox
    Friend WithEvents LabelMultiIdioma4 As LabelMultiIdioma
    Friend WithEvents tbxPoblacionDestino As TextBox
    Friend WithEvents LabelMultiIdioma3 As LabelMultiIdioma
    Friend WithEvents tbxCPDestino As TextBox
    Friend WithEvents LabelMultiIdioma2 As LabelMultiIdioma
    Friend WithEvents tbxDireccionDestino As TextBox
    Friend WithEvents gbxDatosCliente As GroupBox
    Friend WithEvents LabelMultiIdioma11 As LabelMultiIdioma
    Friend WithEvents tbxNombreCliente As TextBox
    Friend WithEvents LabelMultiIdioma12 As LabelMultiIdioma
    Friend WithEvents tbxMailCliente As TextBox
    Friend WithEvents LabelMultiIdioma13 As LabelMultiIdioma
    Friend WithEvents LabelMultiIdioma6 As LabelMultiIdioma
    Friend WithEvents tbxPorte As TextBox
    Friend WithEvents LabelMultiIdioma7 As LabelMultiIdioma
    Friend WithEvents tbxPeso As TextBox
    Friend WithEvents LabelMultiIdioma8 As LabelMultiIdioma
    Friend WithEvents tbxDimensiones As TextBox
    Friend WithEvents LabelMultiIdioma9 As LabelMultiIdioma
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnAfegirHistoric As ButtonMultiIdioma
    Friend WithEvents btnTreureHistoric As ButtonMultiIdioma
    Friend WithEvents lblMailDestinatari As LabelMultiIdioma
    Friend WithEvents tbxMailDestinatari As TextBox
    Friend WithEvents cmbxEstat As ComboBox
    Friend WithEvents pgeTarifa As TabPage
    Friend WithEvents gbxCaracEnvio As GroupBox
    Friend WithEvents tbxPrecioClienteCT As TextBox
    Friend WithEvents tbxPesoCT As TextBox
    Friend WithEvents LabelMultiIdioma16 As LabelMultiIdioma
    Friend WithEvents LabelMultiIdioma17 As LabelMultiIdioma
    Friend WithEvents tbxFondoCT As TextBox
    Friend WithEvents tbxAnchoCT As TextBox
    Friend WithEvents tbxAltoCT As TextBox
    Friend WithEvents LabelMultiIdioma14 As LabelMultiIdioma
    Friend WithEvents LabelMultiIdioma15 As LabelMultiIdioma
    Friend WithEvents gbxTarifa As GroupBox
    Friend WithEvents gbxOrigenDesti As GroupBox
    Friend WithEvents LabelMultiIdioma20 As LabelMultiIdioma
    Friend WithEvents LabelMultiIdioma21 As LabelMultiIdioma
    Friend WithEvents tbxDireccioDestiCT As TextBox
    Friend WithEvents tbxDireccioOrigenCT As TextBox
    Friend WithEvents gbxPrecios As GroupBox
    Friend WithEvents LabelMultiIdioma19 As LabelMultiIdioma
    Friend WithEvents LabelMultiIdioma18 As LabelMultiIdioma
    Friend WithEvents tbxDistanciaTotalCT As TextBox
    Friend WithEvents LabelMultiIdioma22 As LabelMultiIdioma
    Friend WithEvents tbxPrecioNoClienteCT As TextBox
    Friend WithEvents btnAcceptarTarifa As ButtonMultiIdioma
    Friend WithEvents btnCalcularPorte As ButtonMultiIdioma
    Friend WithEvents pnlTarifa As Panel
    Friend WithEvents gbxEntrarTarifa As GroupBox
    Friend WithEvents btnEntrarTarifa As ButtonMultiIdioma
    Friend WithEvents LabelMultiIdioma23 As LabelMultiIdioma
    Friend WithEvents tbxSize As TextBox
    Friend WithEvents tbiCodiClient As Lupa
    Friend WithEvents cmbxTarifas As ComboBox
    Friend WithEvents btnBorrar As ButtonMultiIdioma
    Friend WithEvents dgvHistorico As Syncfusion.WinForms.DataGrid.SfDataGrid
    Friend WithEvents tbxTarifaFavClient As TextBox
    Friend WithEvents LabelMultiIdioma10 As LabelMultiIdioma
    Friend WithEvents tbxNifCliente As TextBox
    Friend WithEvents tbiRuta As Lupa
    Friend WithEvents tbxRuta As TextBox
    Friend WithEvents LabelMultiIdioma24 As LabelMultiIdioma
    Friend WithEvents LabelMultiIdioma25 As LabelMultiIdioma
    Friend WithEvents tbxEsComercial As TextBox
    Friend WithEvents cbxEsComercial As CheckBox
    Friend WithEvents btnAbrirFactura As ButtonMultiIdioma
End Class
