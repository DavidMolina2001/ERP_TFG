﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFactura
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFactura))
        TabPage1 = New TabPage()
        tbxObservaciones = New TextBox()
        LabelMultiIdioma2 = New LabelMultiIdioma()
        GroupBox1 = New GroupBox()
        tbxImpuestos = New TextBox()
        tbxSinImpuestos = New TextBox()
        LabelMultiIdioma8 = New LabelMultiIdioma()
        LabelMultiIdioma10 = New LabelMultiIdioma()
        gbxDatosCliente = New GroupBox()
        tbiCodiClient = New Lupa()
        tbxNombreCliente = New TextBox()
        tbxMailCliente = New TextBox()
        tbxDirCliente = New TextBox()
        tbxNifcliente = New TextBox()
        LabelMultiIdioma11 = New LabelMultiIdioma()
        LabelMultiIdioma12 = New LabelMultiIdioma()
        LabelMultiIdioma13 = New LabelMultiIdioma()
        gbxGeneral = New GroupBox()
        dtpVencimiento = New Syncfusion.Windows.Forms.Tools.DateTimePickerAdv()
        dtpEmision = New Syncfusion.Windows.Forms.Tools.DateTimePickerAdv()
        cbxCobrado = New CheckBox()
        LabelMultiIdioma7 = New LabelMultiIdioma()
        LabelMultiIdioma6 = New LabelMultiIdioma()
        LabelMultiIdioma1 = New LabelMultiIdioma()
        lblCodigoSeguimiento = New LabelMultiIdioma()
        tbxNumFactura = New TextBox()
        TabControl1 = New TabControl()
        TabPage2 = New TabPage()
        dgvItems = New Syncfusion.WinForms.DataGrid.SfDataGrid()
        btnTreureHistoric = New ButtonMultiIdioma()
        btnAfegirHistoric = New ButtonMultiIdioma()
        btnGuardar = New ButtonMultiIdioma()
        btnCancelar = New ButtonMultiIdioma()
        btnBorrar = New ButtonMultiIdioma()
        btnGenerarFactura = New ButtonMultiIdioma()
        tbxIdioma = New TextBox()
        TabPage1.SuspendLayout()
        GroupBox1.SuspendLayout()
        gbxDatosCliente.SuspendLayout()
        gbxGeneral.SuspendLayout()
        CType(dtpVencimiento, ComponentModel.ISupportInitialize).BeginInit()
        CType(dtpVencimiento.Calendar, ComponentModel.ISupportInitialize).BeginInit()
        CType(dtpEmision, ComponentModel.ISupportInitialize).BeginInit()
        CType(dtpEmision.Calendar, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        TabPage2.SuspendLayout()
        CType(dgvItems, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.Gainsboro
        TabPage1.Controls.Add(tbxObservaciones)
        TabPage1.Controls.Add(LabelMultiIdioma2)
        TabPage1.Controls.Add(GroupBox1)
        TabPage1.Controls.Add(gbxDatosCliente)
        TabPage1.Controls.Add(gbxGeneral)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(780, 376)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Principal"
        ' 
        ' tbxObservaciones
        ' 
        tbxObservaciones.Location = New Point(10, 236)
        tbxObservaciones.Multiline = True
        tbxObservaciones.Name = "tbxObservaciones"
        tbxObservaciones.Size = New Size(766, 134)
        tbxObservaciones.TabIndex = 23
        ' 
        ' LabelMultiIdioma2
        ' 
        LabelMultiIdioma2.AutoEllipsis = True
        LabelMultiIdioma2.BackColor = Color.Khaki
        LabelMultiIdioma2.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma2.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma2.Location = New Point(10, 210)
        LabelMultiIdioma2.Name = "LabelMultiIdioma2"
        LabelMultiIdioma2.Size = New Size(172, 23)
        LabelMultiIdioma2.TabIndex = 22
        LabelMultiIdioma2.Text = "Observaciones"
        LabelMultiIdioma2.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma2.TextoCastellano = "Observaciones"
        LabelMultiIdioma2.TextoCatalan = "Observacions"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Silver
        GroupBox1.Controls.Add(tbxImpuestos)
        GroupBox1.Controls.Add(tbxSinImpuestos)
        GroupBox1.Controls.Add(LabelMultiIdioma8)
        GroupBox1.Controls.Add(LabelMultiIdioma10)
        GroupBox1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.Location = New Point(465, 97)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(311, 109)
        GroupBox1.TabIndex = 21
        GroupBox1.TabStop = False
        GroupBox1.Text = "Total"
        ' 
        ' tbxImpuestos
        ' 
        tbxImpuestos.BackColor = Color.LightGreen
        tbxImpuestos.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        tbxImpuestos.Location = New Point(184, 59)
        tbxImpuestos.Name = "tbxImpuestos"
        tbxImpuestos.ReadOnly = True
        tbxImpuestos.Size = New Size(100, 22)
        tbxImpuestos.TabIndex = 15
        ' 
        ' tbxSinImpuestos
        ' 
        tbxSinImpuestos.BackColor = Color.LightGreen
        tbxSinImpuestos.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        tbxSinImpuestos.Location = New Point(184, 28)
        tbxSinImpuestos.Name = "tbxSinImpuestos"
        tbxSinImpuestos.ReadOnly = True
        tbxSinImpuestos.Size = New Size(100, 22)
        tbxSinImpuestos.TabIndex = 14
        ' 
        ' LabelMultiIdioma8
        ' 
        LabelMultiIdioma8.AutoEllipsis = True
        LabelMultiIdioma8.BackColor = Color.Khaki
        LabelMultiIdioma8.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma8.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma8.Location = New Point(6, 58)
        LabelMultiIdioma8.Name = "LabelMultiIdioma8"
        LabelMultiIdioma8.Size = New Size(172, 23)
        LabelMultiIdioma8.TabIndex = 13
        LabelMultiIdioma8.Text = "Total Impuestos"
        LabelMultiIdioma8.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma8.TextoCastellano = "Total Impuestos"
        LabelMultiIdioma8.TextoCatalan = "Total Impostos"
        ' 
        ' LabelMultiIdioma10
        ' 
        LabelMultiIdioma10.AutoEllipsis = True
        LabelMultiIdioma10.BackColor = Color.Khaki
        LabelMultiIdioma10.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma10.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma10.Location = New Point(6, 29)
        LabelMultiIdioma10.Name = "LabelMultiIdioma10"
        LabelMultiIdioma10.Size = New Size(172, 23)
        LabelMultiIdioma10.TabIndex = 9
        LabelMultiIdioma10.Text = "Total Sin Impuestos"
        LabelMultiIdioma10.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma10.TextoCastellano = "Total Sin Impuestos"
        LabelMultiIdioma10.TextoCatalan = "Total Sense Impostos"
        ' 
        ' gbxDatosCliente
        ' 
        gbxDatosCliente.BackColor = Color.Silver
        gbxDatosCliente.Controls.Add(tbiCodiClient)
        gbxDatosCliente.Controls.Add(LabelMultiIdioma11)
        gbxDatosCliente.Controls.Add(tbxNombreCliente)
        gbxDatosCliente.Controls.Add(LabelMultiIdioma12)
        gbxDatosCliente.Controls.Add(tbxMailCliente)
        gbxDatosCliente.Controls.Add(LabelMultiIdioma13)
        gbxDatosCliente.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        gbxDatosCliente.Location = New Point(4, 101)
        gbxDatosCliente.Name = "gbxDatosCliente"
        gbxDatosCliente.Size = New Size(457, 105)
        gbxDatosCliente.TabIndex = 20
        gbxDatosCliente.TabStop = False
        gbxDatosCliente.Text = "Datos Cliente"
        ' 
        ' tbiCodiClient
        ' 
        tbiCodiClient._Valor = ""
        tbiCodiClient.AutoSize = True
        tbiCodiClient.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tbiCodiClient.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        tbiCodiClient.Location = New Point(181, 17)
        tbiCodiClient.Margin = New Padding(4, 3, 4, 3)
        tbiCodiClient.Name = "tbiCodiClient"
        tbiCodiClient.Size = New Size(131, 30)
        tbiCodiClient.TabIndex = 21
        tbiCodiClient.uCampBD1 = "NomClient"
        tbiCodiClient.uCampBD2 = "Mail"
        tbiCodiClient.uCampBD3 = "DireccionOrigenFavorita"
        tbiCodiClient.uCampBD4 = "NIF"
        tbiCodiClient.uCampBD5 = "Idioma"
        tbiCodiClient.uCampBD6 = Nothing
        tbiCodiClient.uObjRecord = Nothing
        tbiCodiClient.utbxCamp1 = tbxNombreCliente
        tbiCodiClient.utbxCamp2 = tbxMailCliente
        tbiCodiClient.utbxCamp3 = tbxDirCliente
        tbiCodiClient.utbxCamp4 = tbxNifcliente
        tbiCodiClient.utbxCamp5 = tbxIdioma
        tbiCodiClient.utbxCamp6 = Nothing
        ' 
        ' tbxNombreCliente
        ' 
        tbxNombreCliente.BackColor = SystemColors.GradientActiveCaption
        tbxNombreCliente.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbxNombreCliente.Location = New Point(181, 47)
        tbxNombreCliente.Name = "tbxNombreCliente"
        tbxNombreCliente.ReadOnly = True
        tbxNombreCliente.Size = New Size(270, 23)
        tbxNombreCliente.TabIndex = 14
        ' 
        ' tbxMailCliente
        ' 
        tbxMailCliente.BackColor = SystemColors.GradientActiveCaption
        tbxMailCliente.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbxMailCliente.Location = New Point(181, 74)
        tbxMailCliente.Name = "tbxMailCliente"
        tbxMailCliente.ReadOnly = True
        tbxMailCliente.Size = New Size(270, 23)
        tbxMailCliente.TabIndex = 12
        ' 
        ' tbxDirCliente
        ' 
        tbxDirCliente.BackColor = SystemColors.GradientActiveCaption
        tbxDirCliente.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbxDirCliente.Location = New Point(159, 400)
        tbxDirCliente.Name = "tbxDirCliente"
        tbxDirCliente.ReadOnly = True
        tbxDirCliente.Size = New Size(62, 23)
        tbxDirCliente.TabIndex = 23
        tbxDirCliente.Visible = False
        ' 
        ' tbxNifcliente
        ' 
        tbxNifcliente.BackColor = SystemColors.GradientActiveCaption
        tbxNifcliente.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbxNifcliente.Location = New Point(159, 427)
        tbxNifcliente.Name = "tbxNifcliente"
        tbxNifcliente.ReadOnly = True
        tbxNifcliente.Size = New Size(62, 23)
        tbxNifcliente.TabIndex = 22
        tbxNifcliente.Visible = False
        ' 
        ' LabelMultiIdioma11
        ' 
        LabelMultiIdioma11.AutoEllipsis = True
        LabelMultiIdioma11.BackColor = Color.Khaki
        LabelMultiIdioma11.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma11.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma11.Location = New Point(6, 46)
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
        LabelMultiIdioma12.Location = New Point(6, 73)
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
        LabelMultiIdioma13.Location = New Point(6, 19)
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
        gbxGeneral.Controls.Add(dtpVencimiento)
        gbxGeneral.Controls.Add(dtpEmision)
        gbxGeneral.Controls.Add(cbxCobrado)
        gbxGeneral.Controls.Add(LabelMultiIdioma7)
        gbxGeneral.Controls.Add(LabelMultiIdioma6)
        gbxGeneral.Controls.Add(LabelMultiIdioma1)
        gbxGeneral.Controls.Add(lblCodigoSeguimiento)
        gbxGeneral.Controls.Add(tbxNumFactura)
        gbxGeneral.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        gbxGeneral.Location = New Point(4, 7)
        gbxGeneral.Name = "gbxGeneral"
        gbxGeneral.Size = New Size(772, 88)
        gbxGeneral.TabIndex = 19
        gbxGeneral.TabStop = False
        gbxGeneral.Text = "General"
        ' 
        ' dtpVencimiento
        ' 
        dtpVencimiento.BorderColor = Color.Empty
        ' 
        ' 
        ' 
        dtpVencimiento.Calendar.AllowMultipleSelection = False
        dtpVencimiento.Calendar.BorderColor = Color.FromArgb(CByte(209), CByte(211), CByte(212))
        dtpVencimiento.Calendar.BottomHeight = 27
        dtpVencimiento.Calendar.Culture = New System.Globalization.CultureInfo("es-ES")
        dtpVencimiento.Calendar.DayNamesFont = New Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        dtpVencimiento.Calendar.DaysFont = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        dtpVencimiento.Calendar.Dock = DockStyle.Fill
        dtpVencimiento.Calendar.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        dtpVencimiento.Calendar.HeaderFont = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        dtpVencimiento.Calendar.HeaderHeight = 36
        dtpVencimiento.Calendar.Iso8601CalenderFormat = False
        dtpVencimiento.Calendar.Location = New Point(0, 0)
        dtpVencimiento.Calendar.MetroColor = Color.FromArgb(CByte(22), CByte(165), CByte(220))
        dtpVencimiento.Calendar.Name = "monthCalendar"
        ' 
        ' 
        ' 
        dtpVencimiento.Calendar.NoneButton.AutoSize = True
        dtpVencimiento.Calendar.NoneButton.Location = New Point(130, 0)
        dtpVencimiento.Calendar.NoneButton.Size = New Size(82, 27)
        dtpVencimiento.Calendar.NoneButton.Text = "None"
        dtpVencimiento.Calendar.ScrollButtonSize = New Size(19, 22)
        dtpVencimiento.Calendar.Size = New Size(212, 199)
        dtpVencimiento.Calendar.SizeToFit = True
        dtpVencimiento.Calendar.TabIndex = 0
        ' 
        ' 
        ' 
        dtpVencimiento.Calendar.TodayButton.AutoSize = True
        dtpVencimiento.Calendar.TodayButton.Location = New Point(0, 0)
        dtpVencimiento.Calendar.TodayButton.Size = New Size(130, 27)
        dtpVencimiento.Calendar.TodayButton.Text = "Today"
        dtpVencimiento.Calendar.WeekFont = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        dtpVencimiento.CalendarSize = New Size(189, 176)
        dtpVencimiento.DropDownImage = Nothing
        dtpVencimiento.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        dtpVencimiento.Location = New Point(518, 51)
        dtpVencimiento.MetroColor = Color.FromArgb(CByte(22), CByte(165), CByte(220))
        dtpVencimiento.MinValue = New Date(0L)
        dtpVencimiento.Name = "dtpVencimiento"
        dtpVencimiento.Size = New Size(201, 20)
        dtpVencimiento.TabIndex = 13
        dtpVencimiento.Value = New Date(2024, 5, 13, 20, 37, 21, 347)
        ' 
        ' dtpEmision
        ' 
        dtpEmision.BorderColor = Color.Empty
        ' 
        ' 
        ' 
        dtpEmision.Calendar.AllowMultipleSelection = False
        dtpEmision.Calendar.BorderColor = Color.FromArgb(CByte(209), CByte(211), CByte(212))
        dtpEmision.Calendar.BottomHeight = 27
        dtpEmision.Calendar.Culture = New System.Globalization.CultureInfo("es-ES")
        dtpEmision.Calendar.DayNamesFont = New Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        dtpEmision.Calendar.DaysFont = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        dtpEmision.Calendar.Dock = DockStyle.Fill
        dtpEmision.Calendar.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        dtpEmision.Calendar.HeaderFont = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        dtpEmision.Calendar.HeaderHeight = 36
        dtpEmision.Calendar.Iso8601CalenderFormat = False
        dtpEmision.Calendar.Location = New Point(0, 0)
        dtpEmision.Calendar.MetroColor = Color.FromArgb(CByte(22), CByte(165), CByte(220))
        dtpEmision.Calendar.Name = "monthCalendar"
        ' 
        ' 
        ' 
        dtpEmision.Calendar.NoneButton.AutoSize = True
        dtpEmision.Calendar.NoneButton.Location = New Point(130, 0)
        dtpEmision.Calendar.NoneButton.Size = New Size(82, 27)
        dtpEmision.Calendar.NoneButton.Text = "None"
        dtpEmision.Calendar.ScrollButtonSize = New Size(19, 22)
        dtpEmision.Calendar.Size = New Size(212, 199)
        dtpEmision.Calendar.SizeToFit = True
        dtpEmision.Calendar.TabIndex = 0
        ' 
        ' 
        ' 
        dtpEmision.Calendar.TodayButton.AutoSize = True
        dtpEmision.Calendar.TodayButton.Location = New Point(0, 0)
        dtpEmision.Calendar.TodayButton.Size = New Size(130, 27)
        dtpEmision.Calendar.TodayButton.Text = "Today"
        dtpEmision.Calendar.WeekFont = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        dtpEmision.CalendarSize = New Size(189, 176)
        dtpEmision.DropDownImage = Nothing
        dtpEmision.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        dtpEmision.Location = New Point(518, 25)
        dtpEmision.MetroColor = Color.FromArgb(CByte(22), CByte(165), CByte(220))
        dtpEmision.MinValue = New Date(0L)
        dtpEmision.Name = "dtpEmision"
        dtpEmision.Size = New Size(201, 20)
        dtpEmision.TabIndex = 12
        dtpEmision.Value = New Date(2024, 5, 13, 20, 37, 21, 347)
        ' 
        ' cbxCobrado
        ' 
        cbxCobrado.AutoSize = True
        cbxCobrado.Location = New Point(151, 56)
        cbxCobrado.Name = "cbxCobrado"
        cbxCobrado.Size = New Size(15, 14)
        cbxCobrado.TabIndex = 11
        cbxCobrado.UseVisualStyleBackColor = True
        ' 
        ' LabelMultiIdioma7
        ' 
        LabelMultiIdioma7.AutoEllipsis = True
        LabelMultiIdioma7.BackColor = Color.Khaki
        LabelMultiIdioma7.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma7.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma7.Location = New Point(359, 50)
        LabelMultiIdioma7.Name = "LabelMultiIdioma7"
        LabelMultiIdioma7.Size = New Size(155, 23)
        LabelMultiIdioma7.TabIndex = 10
        LabelMultiIdioma7.Text = "Fecha Vencimiento"
        LabelMultiIdioma7.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma7.TextoCastellano = "Fecha Vencimiento"
        LabelMultiIdioma7.TextoCatalan = "Data Venciment"
        ' 
        ' LabelMultiIdioma6
        ' 
        LabelMultiIdioma6.AutoEllipsis = True
        LabelMultiIdioma6.BackColor = Color.Khaki
        LabelMultiIdioma6.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma6.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma6.Location = New Point(359, 24)
        LabelMultiIdioma6.Name = "LabelMultiIdioma6"
        LabelMultiIdioma6.Size = New Size(155, 23)
        LabelMultiIdioma6.TabIndex = 9
        LabelMultiIdioma6.Text = "Fecha Emisión"
        LabelMultiIdioma6.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma6.TextoCastellano = "Fecha Emisión"
        LabelMultiIdioma6.TextoCatalan = "Data Emisió"
        ' 
        ' LabelMultiIdioma1
        ' 
        LabelMultiIdioma1.AutoEllipsis = True
        LabelMultiIdioma1.BackColor = Color.Khaki
        LabelMultiIdioma1.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma1.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma1.Location = New Point(6, 50)
        LabelMultiIdioma1.Name = "LabelMultiIdioma1"
        LabelMultiIdioma1.Size = New Size(143, 23)
        LabelMultiIdioma1.TabIndex = 7
        LabelMultiIdioma1.Text = "Cobrado"
        LabelMultiIdioma1.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma1.TextoCastellano = "Cobrado"
        LabelMultiIdioma1.TextoCatalan = "Cobrat"
        ' 
        ' lblCodigoSeguimiento
        ' 
        lblCodigoSeguimiento.AutoEllipsis = True
        lblCodigoSeguimiento.BackColor = Color.Khaki
        lblCodigoSeguimiento.BorderStyle = BorderStyle.FixedSingle
        lblCodigoSeguimiento.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblCodigoSeguimiento.Location = New Point(6, 23)
        lblCodigoSeguimiento.Name = "lblCodigoSeguimiento"
        lblCodigoSeguimiento.Size = New Size(143, 23)
        lblCodigoSeguimiento.TabIndex = 5
        lblCodigoSeguimiento.Text = "Número Factura"
        lblCodigoSeguimiento.TextAlign = ContentAlignment.MiddleCenter
        lblCodigoSeguimiento.TextoCastellano = "Número Factura"
        lblCodigoSeguimiento.TextoCatalan = "Número Factura"
        ' 
        ' tbxNumFactura
        ' 
        tbxNumFactura.BackColor = SystemColors.GradientActiveCaption
        tbxNumFactura.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        tbxNumFactura.Location = New Point(151, 24)
        tbxNumFactura.MaxLength = 12
        tbxNumFactura.Name = "tbxNumFactura"
        tbxNumFactura.ReadOnly = True
        tbxNumFactura.Size = New Size(193, 23)
        tbxNumFactura.TabIndex = 6
        ' 
        ' TabControl1
        ' 
        TabControl1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(788, 404)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(dgvItems)
        TabPage2.Controls.Add(btnTreureHistoric)
        TabPage2.Controls.Add(btnAfegirHistoric)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(780, 376)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Items"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' dgvItems
        ' 
        dgvItems.AccessibleName = "Table"
        dgvItems.AllowEditing = False
        dgvItems.AllowGrouping = False
        dgvItems.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvItems.Location = New Point(0, 0)
        dgvItems.Name = "dgvItems"
        dgvItems.Size = New Size(663, 376)
        dgvItems.Style.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        dgvItems.Style.CheckBoxStyle.CheckedBackColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        dgvItems.Style.CheckBoxStyle.CheckedBorderColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        dgvItems.Style.CheckBoxStyle.IndeterminateBorderColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        dgvItems.Style.HeaderStyle.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        dgvItems.Style.HeaderStyle.Font.Bold = True
        dgvItems.Style.HyperlinkStyle.DefaultLinkColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        dgvItems.TabIndex = 38
        dgvItems.Text = "SfDataGrid1"
        ' 
        ' btnTreureHistoric
        ' 
        btnTreureHistoric.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnTreureHistoric.AutoSize = True
        btnTreureHistoric.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnTreureHistoric.Image = CType(resources.GetObject("btnTreureHistoric.Image"), Image)
        btnTreureHistoric.ImageAlign = ContentAlignment.MiddleLeft
        btnTreureHistoric.Location = New Point(669, 54)
        btnTreureHistoric.Name = "btnTreureHistoric"
        btnTreureHistoric.Size = New Size(111, 42)
        btnTreureHistoric.TabIndex = 37
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
        btnAfegirHistoric.Location = New Point(669, 6)
        btnAfegirHistoric.Name = "btnAfegirHistoric"
        btnAfegirHistoric.Size = New Size(111, 42)
        btnAfegirHistoric.TabIndex = 36
        btnAfegirHistoric.Text = "Añadir"
        btnAfegirHistoric.TextoCastellano = "Añadir"
        btnAfegirHistoric.TextoCatalan = "Afegir"
        btnAfegirHistoric.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnGuardar.AutoSize = True
        btnGuardar.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), Image)
        btnGuardar.ImageAlign = ContentAlignment.MiddleLeft
        btnGuardar.Location = New Point(668, 412)
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
        btnCancelar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnCancelar.AutoSize = True
        btnCancelar.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), Image)
        btnCancelar.ImageAlign = ContentAlignment.MiddleLeft
        btnCancelar.Location = New Point(551, 412)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(116, 30)
        btnCancelar.TabIndex = 1
        btnCancelar.Text = "Cancelar"
        btnCancelar.TextoCastellano = "Cancelar"
        btnCancelar.TextoCatalan = "Cancel·lar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' btnBorrar
        ' 
        btnBorrar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnBorrar.AutoSize = True
        btnBorrar.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), Image)
        btnBorrar.ImageAlign = ContentAlignment.MiddleLeft
        btnBorrar.Location = New Point(12, 412)
        btnBorrar.Name = "btnBorrar"
        btnBorrar.Size = New Size(116, 30)
        btnBorrar.TabIndex = 2
        btnBorrar.Text = "Borrar"
        btnBorrar.TextoCastellano = "Borrar"
        btnBorrar.TextoCatalan = "Esborrar"
        btnBorrar.UseVisualStyleBackColor = True
        ' 
        ' btnGenerarFactura
        ' 
        btnGenerarFactura.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnGenerarFactura.AutoSize = True
        btnGenerarFactura.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnGenerarFactura.Image = CType(resources.GetObject("btnGenerarFactura.Image"), Image)
        btnGenerarFactura.ImageAlign = ContentAlignment.MiddleLeft
        btnGenerarFactura.Location = New Point(264, 412)
        btnGenerarFactura.Name = "btnGenerarFactura"
        btnGenerarFactura.Size = New Size(152, 30)
        btnGenerarFactura.TabIndex = 24
        btnGenerarFactura.Text = "Generar Factura"
        btnGenerarFactura.TextoCastellano = "Generar Factura"
        btnGenerarFactura.TextoCatalan = "Generar Factura"
        btnGenerarFactura.UseVisualStyleBackColor = True
        ' 
        ' tbxIdioma
        ' 
        tbxIdioma.BackColor = SystemColors.GradientActiveCaption
        tbxIdioma.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbxIdioma.Location = New Point(460, 412)
        tbxIdioma.Name = "tbxIdioma"
        tbxIdioma.ReadOnly = True
        tbxIdioma.Size = New Size(62, 23)
        tbxIdioma.TabIndex = 25
        tbxIdioma.Visible = False
        ' 
        ' frmFactura
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(786, 450)
        Controls.Add(tbxIdioma)
        Controls.Add(btnGenerarFactura)
        Controls.Add(tbxDirCliente)
        Controls.Add(btnBorrar)
        Controls.Add(tbxNifcliente)
        Controls.Add(btnCancelar)
        Controls.Add(btnGuardar)
        Controls.Add(TabControl1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmFactura"
        Text = "frmGeneric"
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        gbxDatosCliente.ResumeLayout(False)
        gbxDatosCliente.PerformLayout()
        gbxGeneral.ResumeLayout(False)
        gbxGeneral.PerformLayout()
        CType(dtpVencimiento.Calendar, ComponentModel.ISupportInitialize).EndInit()
        CType(dtpVencimiento, ComponentModel.ISupportInitialize).EndInit()
        CType(dtpEmision.Calendar, ComponentModel.ISupportInitialize).EndInit()
        CType(dtpEmision, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(dgvItems, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents btnGuardar As ButtonMultiIdioma
    Friend WithEvents btnCancelar As ButtonMultiIdioma
    Friend WithEvents btnBorrar As ButtonMultiIdioma
    Friend WithEvents gbxDatosCliente As GroupBox
    Friend WithEvents tbiCodiClient As Lupa
    Friend WithEvents tbxNombreCliente As TextBox
    Friend WithEvents tbxMailCliente As TextBox
    Friend WithEvents LabelMultiIdioma11 As LabelMultiIdioma
    Friend WithEvents LabelMultiIdioma12 As LabelMultiIdioma
    Friend WithEvents LabelMultiIdioma13 As LabelMultiIdioma
    Friend WithEvents gbxGeneral As GroupBox
    Friend WithEvents tbxPorte As TextBox
    Friend WithEvents lblCodigoSeguimiento As LabelMultiIdioma
    Friend WithEvents tbxNumFactura As TextBox
    Friend WithEvents tbxDimensiones As TextBox
    Friend WithEvents LabelMultiIdioma7 As LabelMultiIdioma
    Friend WithEvents LabelMultiIdioma6 As LabelMultiIdioma
    Friend WithEvents LabelMultiIdioma1 As LabelMultiIdioma
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents cbxCobrado As CheckBox
    Friend WithEvents dtpVencimiento As Syncfusion.Windows.Forms.Tools.DateTimePickerAdv
    Friend WithEvents dtpEmision As Syncfusion.Windows.Forms.Tools.DateTimePickerAdv
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelMultiIdioma8 As LabelMultiIdioma
    Friend WithEvents LabelMultiIdioma10 As LabelMultiIdioma
    Friend WithEvents tbxObservaciones As TextBox
    Friend WithEvents LabelMultiIdioma2 As LabelMultiIdioma
    Friend WithEvents tbxImpuestos As TextBox
    Friend WithEvents tbxSinImpuestos As TextBox
    Friend WithEvents tbxDirCliente As TextBox
    Friend WithEvents tbxNifcliente As TextBox
    Friend WithEvents dgvItems As Syncfusion.WinForms.DataGrid.SfDataGrid
    Friend WithEvents btnTreureHistoric As ButtonMultiIdioma
    Friend WithEvents btnAfegirHistoric As ButtonMultiIdioma
    Friend WithEvents btnGenerarFactura As ButtonMultiIdioma
    Friend WithEvents tbxIdioma As TextBox
End Class
