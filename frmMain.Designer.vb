﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim TreeNode1 As TreeNode = New TreeNode("Seguimiento", 2, 2)
        Dim TreeNode2 As TreeNode = New TreeNode("Incidencias")
        Dim TreeNode3 As TreeNode = New TreeNode("Envíos", 3, 3, New TreeNode() {TreeNode1, TreeNode2})
        Dim TreeNode4 As TreeNode = New TreeNode("Tarifas", 2, 2)
        Dim TreeNode5 As TreeNode = New TreeNode("Etiquetas de Envío", 2, 2)
        Dim TreeNode6 As TreeNode = New TreeNode("Alta Rápida")
        Dim TreeNode7 As TreeNode = New TreeNode("Comercials")
        Dim TreeNode8 As TreeNode = New TreeNode("Personals")
        Dim TreeNode9 As TreeNode = New TreeNode("Clients", 3, 3, New TreeNode() {TreeNode7, TreeNode8})
        Dim TreeNode10 As TreeNode = New TreeNode("Facturas")
        Dim TreeNode11 As TreeNode = New TreeNode("FacturesPendiente")
        Dim TreeNode12 As TreeNode = New TreeNode("Facturació", 3, 3, New TreeNode() {TreeNode10, TreeNode11})
        Dim TreeNode13 As TreeNode = New TreeNode("Furgonetas")
        Dim TreeNode14 As TreeNode = New TreeNode("Mantenimientos")
        Dim TreeNode15 As TreeNode = New TreeNode("Furgonetes", 3, 3, New TreeNode() {TreeNode13, TreeNode14})
        Dim TreeNode16 As TreeNode = New TreeNode("Rutas")
        Dim TreeNode17 As TreeNode = New TreeNode("Rutas (Hoy)")
        Dim TreeNode18 As TreeNode = New TreeNode("Rutas (Historico)")
        Dim TreeNode19 As TreeNode = New TreeNode("Rutes", 3, 3, New TreeNode() {TreeNode16, TreeNode17, TreeNode18})
        Dim TreeNode20 As TreeNode = New TreeNode("Trabajadores")
        Dim TreeNode21 As TreeNode = New TreeNode("Informe Envíos", 4, 4)
        Dim TreeNode22 As TreeNode = New TreeNode("Informe Facturación")
        Dim TreeNode23 As TreeNode = New TreeNode("MostrarInformes")
        ToolStripContainer1 = New ToolStripContainer()
        btnActualizarTrabajadoresRuta = New ButtonMultiIdioma()
        lblTrabajadoresEnRuta = New LabelMultiIdioma()
        dgTrabajadoresEnRuta = New Syncfusion.WinForms.DataGrid.SfDataGrid()
        lblAvisos = New LabelMultiIdioma()
        gbxControlRutas = New GroupBox()
        lblRutaDiaria = New LabelMultiIdioma()
        btnCopiarRutasNO = New ButtonMultiIdioma()
        btnCopiarRutasSI = New ButtonMultiIdioma()
        lblIncidencies = New LabelMultiIdioma()
        Panel1 = New Panel()
        SplitContainer1 = New SplitContainer()
        cCalendar = New Syncfusion.WinForms.Input.SfCalendar()
        cmbxSelectCalendari = New ComboBox()
        tvEnviaments = New TreeView()
        ImageList1 = New ImageList(components)
        tvClients = New TreeView()
        tvLogistica = New TreeView()
        lblTreeSelected = New LabelMultiIdioma()
        tvInformes = New TreeView()
        btnConfiguracion = New ButtonMultiIdioma()
        btnCalendario = New ButtonMultiIdioma()
        btnInformes = New ButtonMultiIdioma()
        btnClients = New ButtonMultiIdioma()
        btnLogistica = New ButtonMultiIdioma()
        btnEnviaments = New ButtonMultiIdioma()
        StatusStrip1 = New StatusStrip()
        lblUser = New ToolStripStatusLabel()
        lblData = New ToolStripStatusLabel()
        Timer1 = New Timer(components)
        ToolStripContainer1.ContentPanel.SuspendLayout()
        ToolStripContainer1.SuspendLayout()
        CType(dgTrabajadoresEnRuta, ComponentModel.ISupportInitialize).BeginInit()
        gbxControlRutas.SuspendLayout()
        Panel1.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ToolStripContainer1
        ' 
        ' 
        ' ToolStripContainer1.ContentPanel
        ' 
        ToolStripContainer1.ContentPanel.BackColor = SystemColors.AppWorkspace
        ToolStripContainer1.ContentPanel.Controls.Add(btnActualizarTrabajadoresRuta)
        ToolStripContainer1.ContentPanel.Controls.Add(lblTrabajadoresEnRuta)
        ToolStripContainer1.ContentPanel.Controls.Add(dgTrabajadoresEnRuta)
        ToolStripContainer1.ContentPanel.Controls.Add(lblAvisos)
        ToolStripContainer1.ContentPanel.Controls.Add(gbxControlRutas)
        ToolStripContainer1.ContentPanel.Controls.Add(lblIncidencies)
        ToolStripContainer1.ContentPanel.Controls.Add(Panel1)
        ToolStripContainer1.ContentPanel.Size = New Size(1413, 622)
        ToolStripContainer1.Dock = DockStyle.Fill
        ToolStripContainer1.Location = New Point(0, 0)
        ToolStripContainer1.Name = "ToolStripContainer1"
        ToolStripContainer1.Size = New Size(1413, 647)
        ToolStripContainer1.TabIndex = 1
        ToolStripContainer1.Text = "ToolStripContainer1"
        ' 
        ' btnActualizarTrabajadoresRuta
        ' 
        btnActualizarTrabajadoresRuta.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnActualizarTrabajadoresRuta.AutoSize = True
        btnActualizarTrabajadoresRuta.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnActualizarTrabajadoresRuta.Image = CType(resources.GetObject("btnActualizarTrabajadoresRuta.Image"), Image)
        btnActualizarTrabajadoresRuta.ImageAlign = ContentAlignment.MiddleLeft
        btnActualizarTrabajadoresRuta.Location = New Point(1302, 329)
        btnActualizarTrabajadoresRuta.Name = "btnActualizarTrabajadoresRuta"
        btnActualizarTrabajadoresRuta.Size = New Size(108, 30)
        btnActualizarTrabajadoresRuta.TabIndex = 30
        btnActualizarTrabajadoresRuta.Text = "Actualizar"
        btnActualizarTrabajadoresRuta.TextAlign = ContentAlignment.MiddleRight
        btnActualizarTrabajadoresRuta.TextoCastellano = "Actualizar"
        btnActualizarTrabajadoresRuta.TextoCatalan = "Actualitzar"
        btnActualizarTrabajadoresRuta.UseVisualStyleBackColor = True
        ' 
        ' lblTrabajadoresEnRuta
        ' 
        lblTrabajadoresEnRuta.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        lblTrabajadoresEnRuta.AutoEllipsis = True
        lblTrabajadoresEnRuta.BackColor = Color.Khaki
        lblTrabajadoresEnRuta.BorderStyle = BorderStyle.FixedSingle
        lblTrabajadoresEnRuta.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblTrabajadoresEnRuta.Location = New Point(711, 329)
        lblTrabajadoresEnRuta.Name = "lblTrabajadoresEnRuta"
        lblTrabajadoresEnRuta.Size = New Size(699, 29)
        lblTrabajadoresEnRuta.TabIndex = 29
        lblTrabajadoresEnRuta.Text = "Trabajadores en Ruta"
        lblTrabajadoresEnRuta.TextAlign = ContentAlignment.MiddleCenter
        lblTrabajadoresEnRuta.TextoCastellano = "Trabajadores en Ruta"
        lblTrabajadoresEnRuta.TextoCatalan = "Treballadors en Ruta"
        ' 
        ' dgTrabajadoresEnRuta
        ' 
        dgTrabajadoresEnRuta.AccessibleName = "Table"
        dgTrabajadoresEnRuta.AllowEditing = False
        dgTrabajadoresEnRuta.AllowFiltering = True
        dgTrabajadoresEnRuta.AllowGrouping = False
        dgTrabajadoresEnRuta.AllowResizingColumns = True
        dgTrabajadoresEnRuta.AllowSelectionOnMouseDown = True
        dgTrabajadoresEnRuta.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        dgTrabajadoresEnRuta.EditMode = Syncfusion.WinForms.DataGrid.Enums.EditMode.SingleClick
        dgTrabajadoresEnRuta.Location = New Point(711, 361)
        dgTrabajadoresEnRuta.Name = "dgTrabajadoresEnRuta"
        dgTrabajadoresEnRuta.Size = New Size(699, 258)
        dgTrabajadoresEnRuta.Style.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        dgTrabajadoresEnRuta.Style.CheckBoxStyle.CheckedBackColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        dgTrabajadoresEnRuta.Style.CheckBoxStyle.CheckedBorderColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        dgTrabajadoresEnRuta.Style.CheckBoxStyle.IndeterminateBorderColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        dgTrabajadoresEnRuta.Style.HeaderStyle.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        dgTrabajadoresEnRuta.Style.HeaderStyle.Font.Bold = True
        dgTrabajadoresEnRuta.Style.HyperlinkStyle.DefaultLinkColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        dgTrabajadoresEnRuta.TabIndex = 11
        dgTrabajadoresEnRuta.Text = "SfDataGrid1"
        ' 
        ' lblAvisos
        ' 
        lblAvisos.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblAvisos.BackColor = Color.Red
        lblAvisos.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblAvisos.ForeColor = SystemColors.Control
        lblAvisos.Location = New Point(1004, 11)
        lblAvisos.Name = "lblAvisos"
        lblAvisos.Size = New Size(397, 51)
        lblAvisos.TabIndex = 5
        lblAvisos.Text = "AVISOS"
        lblAvisos.TextAlign = ContentAlignment.MiddleCenter
        lblAvisos.TextoCastellano = "AVISOS"
        lblAvisos.TextoCatalan = "AVISOS"
        ' 
        ' gbxControlRutas
        ' 
        gbxControlRutas.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        gbxControlRutas.Controls.Add(lblRutaDiaria)
        gbxControlRutas.Controls.Add(btnCopiarRutasNO)
        gbxControlRutas.Controls.Add(btnCopiarRutasSI)
        gbxControlRutas.Location = New Point(1004, 62)
        gbxControlRutas.Name = "gbxControlRutas"
        gbxControlRutas.Size = New Size(397, 96)
        gbxControlRutas.TabIndex = 4
        gbxControlRutas.TabStop = False
        gbxControlRutas.Visible = False
        ' 
        ' lblRutaDiaria
        ' 
        lblRutaDiaria.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblRutaDiaria.BackColor = Color.Red
        lblRutaDiaria.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblRutaDiaria.ForeColor = SystemColors.Control
        lblRutaDiaria.Location = New Point(3, 16)
        lblRutaDiaria.Name = "lblRutaDiaria"
        lblRutaDiaria.Size = New Size(315, 74)
        lblRutaDiaria.TabIndex = 2
        lblRutaDiaria.Text = "¡ATENCIÓN! No hay rutas establecidas para hoy, ¿quieres copiar las últimas rutas entradas?"
        lblRutaDiaria.TextAlign = ContentAlignment.MiddleCenter
        lblRutaDiaria.TextoCastellano = "¡ATENCIÓN! No hay rutas establecidas para hoy, ¿quieres copiar las últimas rutas entradas?"
        lblRutaDiaria.TextoCatalan = "ATENCIÓ! No hi ha rutas establertes per avui, vols copiar les últimes rutes entrades?"
        ' 
        ' btnCopiarRutasNO
        ' 
        btnCopiarRutasNO.AutoSize = True
        btnCopiarRutasNO.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnCopiarRutasNO.Location = New Point(325, 52)
        btnCopiarRutasNO.Name = "btnCopiarRutasNO"
        btnCopiarRutasNO.Size = New Size(56, 39)
        btnCopiarRutasNO.TabIndex = 3
        btnCopiarRutasNO.Text = "No"
        btnCopiarRutasNO.TextoCastellano = "No"
        btnCopiarRutasNO.TextoCatalan = "No"
        btnCopiarRutasNO.UseVisualStyleBackColor = True
        ' 
        ' btnCopiarRutasSI
        ' 
        btnCopiarRutasSI.AutoSize = True
        btnCopiarRutasSI.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnCopiarRutasSI.Location = New Point(325, 14)
        btnCopiarRutasSI.Name = "btnCopiarRutasSI"
        btnCopiarRutasSI.Size = New Size(56, 39)
        btnCopiarRutasSI.TabIndex = 0
        btnCopiarRutasSI.Text = "Sí"
        btnCopiarRutasSI.TextoCastellano = "Sí"
        btnCopiarRutasSI.TextoCatalan = "Si"
        btnCopiarRutasSI.UseVisualStyleBackColor = True
        ' 
        ' lblIncidencies
        ' 
        lblIncidencies.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblIncidencies.BackColor = Color.Red
        lblIncidencies.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblIncidencies.ForeColor = SystemColors.Control
        lblIncidencies.Location = New Point(1003, 161)
        lblIncidencies.Name = "lblIncidencies"
        lblIncidencies.Size = New Size(398, 23)
        lblIncidencies.TabIndex = 1
        lblIncidencies.Text = "Tienes 3 incidencias pendientes de resolver"
        lblIncidencies.TextAlign = ContentAlignment.MiddleCenter
        lblIncidencies.TextoCastellano = "Tienes 3 incidencias pendientes de resolver"
        lblIncidencies.TextoCatalan = "Tens 3 incidències pendents de resoldre"
        lblIncidencies.Visible = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(SplitContainer1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(224, 622)
        Panel1.TabIndex = 0
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.BackColor = SystemColors.Control
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        SplitContainer1.Orientation = Orientation.Horizontal
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(cCalendar)
        SplitContainer1.Panel1.Controls.Add(cmbxSelectCalendari)
        SplitContainer1.Panel1.Controls.Add(tvEnviaments)
        SplitContainer1.Panel1.Controls.Add(tvClients)
        SplitContainer1.Panel1.Controls.Add(tvLogistica)
        SplitContainer1.Panel1.Controls.Add(lblTreeSelected)
        SplitContainer1.Panel1.Controls.Add(tvInformes)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.BackColor = SystemColors.Control
        SplitContainer1.Panel2.Controls.Add(btnConfiguracion)
        SplitContainer1.Panel2.Controls.Add(btnCalendario)
        SplitContainer1.Panel2.Controls.Add(btnInformes)
        SplitContainer1.Panel2.Controls.Add(btnClients)
        SplitContainer1.Panel2.Controls.Add(btnLogistica)
        SplitContainer1.Panel2.Controls.Add(btnEnviaments)
        SplitContainer1.Size = New Size(224, 622)
        SplitContainer1.SplitterDistance = 266
        SplitContainer1.TabIndex = 0
        ' 
        ' cCalendar
        ' 
        cCalendar.Location = New Point(0, 27)
        cCalendar.MinimumSize = New Size(196, 196)
        cCalendar.Name = "cCalendar"
        cCalendar.Size = New Size(224, 252)
        cCalendar.TabIndex = 2
        cCalendar.Text = "SfCalendar1"
        cCalendar.Visible = False
        ' 
        ' cmbxSelectCalendari
        ' 
        cmbxSelectCalendari.DropDownStyle = ComboBoxStyle.DropDownList
        cmbxSelectCalendari.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        cmbxSelectCalendari.FormattingEnabled = True
        cmbxSelectCalendari.Location = New Point(0, 0)
        cmbxSelectCalendari.Name = "cmbxSelectCalendari"
        cmbxSelectCalendari.Size = New Size(224, 28)
        cmbxSelectCalendari.TabIndex = 2
        cmbxSelectCalendari.Visible = False
        ' 
        ' tvEnviaments
        ' 
        tvEnviaments.BorderStyle = BorderStyle.FixedSingle
        tvEnviaments.Dock = DockStyle.Fill
        tvEnviaments.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        tvEnviaments.ImageIndex = 0
        tvEnviaments.ImageList = ImageList1
        tvEnviaments.Location = New Point(0, 20)
        tvEnviaments.Name = "tvEnviaments"
        TreeNode1.ImageIndex = 2
        TreeNode1.Name = "ndeSeguiment"
        TreeNode1.SelectedImageIndex = 2
        TreeNode1.Tag = "1;Seguimiento;Seguiment;clsEnvios;0;0"
        TreeNode1.Text = "Seguimiento"
        TreeNode2.ImageKey = "itemts.png"
        TreeNode2.Name = "ndeIncidencias"
        TreeNode2.SelectedImageKey = "itemts.png"
        TreeNode2.Tag = "1;Incidencias;Incidències;clsEnvios;1;0"
        TreeNode2.Text = "Incidencias"
        TreeNode3.ImageIndex = 3
        TreeNode3.Name = "ndeEnvios"
        TreeNode3.SelectedImageIndex = 3
        TreeNode3.StateImageKey = "(ninguna)"
        TreeNode3.Tag = "0;Envíos;Enviaments"
        TreeNode3.Text = "Envíos"
        TreeNode4.ImageIndex = 2
        TreeNode4.Name = "ndeTarifas"
        TreeNode4.SelectedImageIndex = 2
        TreeNode4.Tag = "1;Tarifas;Tarifes;clsTarifas;0;0"
        TreeNode4.Text = "Tarifas"
        TreeNode5.ImageIndex = 2
        TreeNode5.Name = "ndeEtiquetas"
        TreeNode5.SelectedImageIndex = 2
        TreeNode5.Tag = "1;Etiquetas de Envío;Etiquetes d'Enviament;clsEtiquetas;0;0"
        TreeNode5.Text = "Etiquetas de Envío"
        TreeNode6.ImageKey = "itemts.png"
        TreeNode6.Name = "ndeAltaRapida"
        TreeNode6.SelectedImageKey = "itemts.png"
        TreeNode6.Tag = "1;Alta Rápida;Alta Ràpida;clsAltaRapida;0;0"
        TreeNode6.Text = "Alta Rápida"
        tvEnviaments.Nodes.AddRange(New TreeNode() {TreeNode3, TreeNode4, TreeNode5, TreeNode6})
        tvEnviaments.SelectedImageIndex = 0
        tvEnviaments.Size = New Size(224, 246)
        tvEnviaments.TabIndex = 0
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth8Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "folderclosed.png")
        ImageList1.Images.SetKeyName(1, "folderopen.png")
        ImageList1.Images.SetKeyName(2, "itemts.png")
        ImageList1.Images.SetKeyName(3, "folder.png")
        ImageList1.Images.SetKeyName(4, "excel.png")
        ' 
        ' tvClients
        ' 
        tvClients.BorderStyle = BorderStyle.FixedSingle
        tvClients.Dock = DockStyle.Fill
        tvClients.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        tvClients.ImageIndex = 0
        tvClients.ImageList = ImageList1
        tvClients.Location = New Point(0, 20)
        tvClients.Name = "tvClients"
        TreeNode7.ImageKey = "itemts.png"
        TreeNode7.Name = "ndeComercials"
        TreeNode7.SelectedImageKey = "itemts.png"
        TreeNode7.Tag = "1;Clientes Comerciales;Clients Comercials;clsClients;2;0"
        TreeNode7.Text = "Comercials"
        TreeNode8.ImageKey = "itemts.png"
        TreeNode8.Name = "ndePersonals"
        TreeNode8.SelectedImageKey = "itemts.png"
        TreeNode8.Tag = "1;Clientes Personals;Clients Personales;clsClients;1;0"
        TreeNode8.Text = "Personals"
        TreeNode9.ImageIndex = 3
        TreeNode9.Name = "ndeClients"
        TreeNode9.SelectedImageIndex = 3
        TreeNode9.StateImageKey = "(ninguna)"
        TreeNode9.Tag = "0;Clientes;Clients"
        TreeNode9.Text = "Clients"
        TreeNode10.ImageKey = "itemts.png"
        TreeNode10.Name = "ndeFacturasTodas"
        TreeNode10.SelectedImageKey = "itemts.png"
        TreeNode10.Tag = "1;Facturas;Factures;clsFacturas;0;0"
        TreeNode10.Text = "Facturas"
        TreeNode11.ImageKey = "itemts.png"
        TreeNode11.Name = "ndeFacturesNoCobrado"
        TreeNode11.SelectedImageKey = "itemts.png"
        TreeNode11.Tag = "1;Facturas Pendientes;Factures Pendents;clsFacturas;1;0"
        TreeNode11.Text = "FacturesPendiente"
        TreeNode12.ImageIndex = 3
        TreeNode12.Name = "ndeFacturacio"
        TreeNode12.SelectedImageIndex = 3
        TreeNode12.Tag = "0;Facturación;Facturació"
        TreeNode12.Text = "Facturació"
        tvClients.Nodes.AddRange(New TreeNode() {TreeNode9, TreeNode12})
        tvClients.SelectedImageIndex = 0
        tvClients.Size = New Size(224, 246)
        tvClients.TabIndex = 1
        ' 
        ' tvLogistica
        ' 
        tvLogistica.BorderStyle = BorderStyle.FixedSingle
        tvLogistica.Dock = DockStyle.Fill
        tvLogistica.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        tvLogistica.ImageIndex = 0
        tvLogistica.ImageList = ImageList1
        tvLogistica.Location = New Point(0, 20)
        tvLogistica.Name = "tvLogistica"
        TreeNode13.ImageKey = "itemts.png"
        TreeNode13.Name = "ndeFurgonetas"
        TreeNode13.SelectedImageKey = "itemts.png"
        TreeNode13.Tag = "1;Furgonetas;Furgonetes;clsFurgonetas;0;0"
        TreeNode13.Text = "Furgonetas"
        TreeNode14.ImageKey = "itemts.png"
        TreeNode14.Name = "ndeMantenimientos"
        TreeNode14.SelectedImageKey = "itemts.png"
        TreeNode14.Tag = "1;Mantenimiento;Manteniment;clsMantenimiento;1;0"
        TreeNode14.Text = "Mantenimientos"
        TreeNode15.ImageIndex = 3
        TreeNode15.Name = "ndeFurgonetas"
        TreeNode15.SelectedImageIndex = 3
        TreeNode15.StateImageKey = "(ninguna)"
        TreeNode15.Tag = "0;Furgonetas;Furgonetes"
        TreeNode15.Text = "Furgonetes"
        TreeNode16.ImageKey = "itemts.png"
        TreeNode16.Name = "ndeRutas"
        TreeNode16.SelectedImageKey = "itemts.png"
        TreeNode16.Tag = "1;Rutas;Rutes;clsRutas;0;0"
        TreeNode16.Text = "Rutas"
        TreeNode17.ImageKey = "itemts.png"
        TreeNode17.Name = "ndeFurgonetaRuta"
        TreeNode17.SelectedImageKey = "itemts.png"
        TreeNode17.Tag = "1;Rutas (Hoy);Rutes (Avui);clsFurgoneta_Ruta;1;0"
        TreeNode17.Text = "Rutas (Hoy)"
        TreeNode18.ImageKey = "itemts.png"
        TreeNode18.Name = "ndeRutasHistorico"
        TreeNode18.SelectedImageKey = "itemts.png"
        TreeNode18.Tag = "1;Rutas (Histórico);Rutes (Històric);clsFurgoneta_Ruta;2;0"
        TreeNode18.Text = "Rutas (Historico)"
        TreeNode19.ImageIndex = 3
        TreeNode19.Name = "ndeRutas"
        TreeNode19.SelectedImageIndex = 3
        TreeNode19.Tag = "0;Rutas;Rutes"
        TreeNode19.Text = "Rutes"
        TreeNode20.ImageKey = "itemts.png"
        TreeNode20.Name = "ndeTrabajadores"
        TreeNode20.SelectedImageKey = "itemts.png"
        TreeNode20.Tag = "1;Trabajadores;Treballadors;clsTrabajadores;1;0"
        TreeNode20.Text = "Trabajadores"
        tvLogistica.Nodes.AddRange(New TreeNode() {TreeNode15, TreeNode19, TreeNode20})
        tvLogistica.SelectedImageIndex = 0
        tvLogistica.Size = New Size(224, 246)
        tvLogistica.TabIndex = 1
        ' 
        ' lblTreeSelected
        ' 
        lblTreeSelected.BackColor = SystemColors.Control
        lblTreeSelected.Dock = DockStyle.Top
        lblTreeSelected.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblTreeSelected.Location = New Point(0, 0)
        lblTreeSelected.Name = "lblTreeSelected"
        lblTreeSelected.Size = New Size(224, 20)
        lblTreeSelected.TabIndex = 0
        lblTreeSelected.Text = "SELECTED"
        lblTreeSelected.TextAlign = ContentAlignment.MiddleCenter
        lblTreeSelected.TextoCastellano = "Envíos"
        lblTreeSelected.TextoCatalan = "Enviaments"
        ' 
        ' tvInformes
        ' 
        tvInformes.BorderStyle = BorderStyle.FixedSingle
        tvInformes.Dock = DockStyle.Fill
        tvInformes.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        tvInformes.ImageIndex = 0
        tvInformes.ImageList = ImageList1
        tvInformes.Location = New Point(0, 0)
        tvInformes.Name = "tvInformes"
        TreeNode21.ImageIndex = 4
        TreeNode21.Name = "ndeInformeEnvios"
        TreeNode21.SelectedImageIndex = 4
        TreeNode21.Tag = "2;Informe Envíos;Informe Enviaments;E;0;0"
        TreeNode21.Text = "Informe Envíos"
        TreeNode22.ImageKey = "excel.png"
        TreeNode22.Name = "ndeInformeFacturacio"
        TreeNode22.SelectedImageKey = "excel.png"
        TreeNode22.Tag = "2;Informe Facturación;Informe Facturació;F;0;0"
        TreeNode22.Text = "Informe Facturación"
        TreeNode23.ImageKey = "itemts.png"
        TreeNode23.Name = "ndeMostrarInformes"
        TreeNode23.SelectedImageKey = "itemts.png"
        TreeNode23.Tag = "1;Mostrar Informes;Mostrar Informes;clsDocuments;0;0"
        TreeNode23.Text = "MostrarInformes"
        tvInformes.Nodes.AddRange(New TreeNode() {TreeNode21, TreeNode22, TreeNode23})
        tvInformes.SelectedImageIndex = 0
        tvInformes.Size = New Size(224, 266)
        tvInformes.TabIndex = 3
        ' 
        ' btnConfiguracion
        ' 
        btnConfiguracion.AutoSize = True
        btnConfiguracion.Dock = DockStyle.Top
        btnConfiguracion.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnConfiguracion.Image = CType(resources.GetObject("btnConfiguracion.Image"), Image)
        btnConfiguracion.ImageAlign = ContentAlignment.MiddleLeft
        btnConfiguracion.Location = New Point(0, 230)
        btnConfiguracion.Name = "btnConfiguracion"
        btnConfiguracion.Size = New Size(224, 46)
        btnConfiguracion.TabIndex = 4
        btnConfiguracion.Text = "Configuración"
        btnConfiguracion.TextoCastellano = "Configuración"
        btnConfiguracion.TextoCatalan = "Configuració"
        btnConfiguracion.UseVisualStyleBackColor = True
        ' 
        ' btnCalendario
        ' 
        btnCalendario.AutoSize = True
        btnCalendario.Dock = DockStyle.Top
        btnCalendario.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnCalendario.Image = CType(resources.GetObject("btnCalendario.Image"), Image)
        btnCalendario.ImageAlign = ContentAlignment.MiddleLeft
        btnCalendario.Location = New Point(0, 184)
        btnCalendario.Name = "btnCalendario"
        btnCalendario.Size = New Size(224, 46)
        btnCalendario.TabIndex = 3
        btnCalendario.Text = "Calendario"
        btnCalendario.TextoCastellano = "Calendario"
        btnCalendario.TextoCatalan = "Calendari"
        btnCalendario.UseVisualStyleBackColor = True
        ' 
        ' btnInformes
        ' 
        btnInformes.AutoSize = True
        btnInformes.Dock = DockStyle.Top
        btnInformes.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnInformes.Image = CType(resources.GetObject("btnInformes.Image"), Image)
        btnInformes.ImageAlign = ContentAlignment.MiddleLeft
        btnInformes.Location = New Point(0, 138)
        btnInformes.Name = "btnInformes"
        btnInformes.Size = New Size(224, 46)
        btnInformes.TabIndex = 2
        btnInformes.Text = "Informes"
        btnInformes.TextoCastellano = "Informes"
        btnInformes.TextoCatalan = "Informes"
        btnInformes.UseVisualStyleBackColor = True
        ' 
        ' btnClients
        ' 
        btnClients.AutoSize = True
        btnClients.Dock = DockStyle.Top
        btnClients.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnClients.Image = CType(resources.GetObject("btnClients.Image"), Image)
        btnClients.ImageAlign = ContentAlignment.MiddleLeft
        btnClients.Location = New Point(0, 92)
        btnClients.Name = "btnClients"
        btnClients.Size = New Size(224, 46)
        btnClients.TabIndex = 1
        btnClients.Text = "Clientes"
        btnClients.TextoCastellano = "Clientes"
        btnClients.TextoCatalan = "Clients"
        btnClients.UseVisualStyleBackColor = True
        ' 
        ' btnLogistica
        ' 
        btnLogistica.AutoSize = True
        btnLogistica.Dock = DockStyle.Top
        btnLogistica.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogistica.Image = CType(resources.GetObject("btnLogistica.Image"), Image)
        btnLogistica.ImageAlign = ContentAlignment.MiddleLeft
        btnLogistica.Location = New Point(0, 46)
        btnLogistica.Name = "btnLogistica"
        btnLogistica.Size = New Size(224, 46)
        btnLogistica.TabIndex = 5
        btnLogistica.Text = "Logística"
        btnLogistica.TextoCastellano = "Logística"
        btnLogistica.TextoCatalan = "Logística"
        btnLogistica.UseVisualStyleBackColor = True
        ' 
        ' btnEnviaments
        ' 
        btnEnviaments.AutoSize = True
        btnEnviaments.Dock = DockStyle.Top
        btnEnviaments.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnEnviaments.Image = CType(resources.GetObject("btnEnviaments.Image"), Image)
        btnEnviaments.ImageAlign = ContentAlignment.MiddleLeft
        btnEnviaments.Location = New Point(0, 0)
        btnEnviaments.Name = "btnEnviaments"
        btnEnviaments.Size = New Size(224, 46)
        btnEnviaments.TabIndex = 0
        btnEnviaments.Text = "Envíos"
        btnEnviaments.TextoCastellano = "Envíos"
        btnEnviaments.TextoCatalan = "Enviaments"
        btnEnviaments.UseVisualStyleBackColor = True
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {lblUser, lblData})
        StatusStrip1.Location = New Point(0, 647)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(1413, 26)
        StatusStrip1.TabIndex = 2
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' lblUser
        ' 
        lblUser.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(48, 21)
        lblUser.Text = "USER"
        ' 
        ' lblData
        ' 
        lblData.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblData.Name = "lblData"
        lblData.Size = New Size(47, 21)
        lblData.Text = "DATA"
        ' 
        ' Timer1
        ' 
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1413, 673)
        Controls.Add(ToolStripContainer1)
        Controls.Add(StatusStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(1100, 700)
        Name = "frmMain"
        Text = "MyTFG"
        WindowState = FormWindowState.Maximized
        ToolStripContainer1.ContentPanel.ResumeLayout(False)
        ToolStripContainer1.ContentPanel.PerformLayout()
        ToolStripContainer1.ResumeLayout(False)
        ToolStripContainer1.PerformLayout()
        CType(dgTrabajadoresEnRuta, ComponentModel.ISupportInitialize).EndInit()
        gbxControlRutas.ResumeLayout(False)
        gbxControlRutas.PerformLayout()
        Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        SplitContainer1.Panel2.PerformLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblUser As ToolStripStatusLabel
    Friend WithEvents lblData As ToolStripStatusLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents tvEnviaments As TreeView
    Friend WithEvents btnEnviaments As ButtonMultiIdioma
    Friend WithEvents btnInformes As ButtonMultiIdioma
    Friend WithEvents btnClients As ButtonMultiIdioma
    Friend WithEvents btnCalendario As ButtonMultiIdioma
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents tvClients As TreeView
    Friend WithEvents tvLogistica As TreeView
    Friend WithEvents lblTreeSelected As LabelMultiIdioma
    Friend WithEvents lblIncidencies As LabelMultiIdioma
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnConfiguracion As ButtonMultiIdioma
    Friend WithEvents cmbxSelectCalendari As ComboBox
    Friend WithEvents btnLogistica As ButtonMultiIdioma
    Friend WithEvents cCalendar As Syncfusion.WinForms.Input.SfCalendar
    Friend WithEvents lblRutaDiaria As LabelMultiIdioma
    Friend WithEvents btnCopiarRutasNO As ButtonMultiIdioma
    Friend WithEvents btnCopiarRutasSI As ButtonMultiIdioma
    Friend WithEvents gbxControlRutas As GroupBox
    Friend WithEvents lblAvisos As LabelMultiIdioma
    Friend WithEvents dgTrabajadoresEnRuta As Syncfusion.WinForms.DataGrid.SfDataGrid
    Friend WithEvents lblTrabajadoresEnRuta As LabelMultiIdioma
    Friend WithEvents btnActualizarTrabajadoresRuta As ButtonMultiIdioma
    Friend WithEvents tvInformes As TreeView
End Class
