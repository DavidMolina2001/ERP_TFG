<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClients
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClients))
        tabPage1 = New TabPage()
        LabelMultiIdioma31 = New LabelMultiIdioma()
        tbxPoblacionOrigen = New TextBox()
        tbiPoblacioOrigen = New Lupa()
        tbxCPOrigen = New TextBox()
        LabelMultiIdioma27 = New LabelMultiIdioma()
        LabelMultiIdioma28 = New LabelMultiIdioma()
        tbxObservaciones = New TextBox()
        LabelMultiIdioma1 = New LabelMultiIdioma()
        LabelMultiIdioma5 = New LabelMultiIdioma()
        LabelMultiIdioma4 = New LabelMultiIdioma()
        tbxNIF = New TextBox()
        Label1 = New Label()
        cmbxIdioma = New ComboBox()
        cbxEsComercial = New CheckBox()
        cmbxTarifas = New ComboBox()
        LabelMultiIdioma3 = New LabelMultiIdioma()
        LabelMultiIdioma2 = New LabelMultiIdioma()
        tbxMail = New TextBox()
        LabelMultiIdioma6 = New LabelMultiIdioma()
        tbxDireccionOrigen = New TextBox()
        LabelMultiIdioma8 = New LabelMultiIdioma()
        tbxNom = New TextBox()
        tabEnvios = New TabControl()
        TabPage2 = New TabPage()
        dgEnvios = New Syncfusion.WinForms.DataGrid.SfDataGrid()
        TabPage3 = New TabPage()
        btnGenerarFactura = New ButtonMultiIdioma()
        dgFacturas = New Syncfusion.WinForms.DataGrid.SfDataGrid()
        btnGuardar = New ButtonMultiIdioma()
        btnCancelar = New ButtonMultiIdioma()
        btnBorrar = New ButtonMultiIdioma()
        tabPage1.SuspendLayout()
        tabEnvios.SuspendLayout()
        TabPage2.SuspendLayout()
        CType(dgEnvios, ComponentModel.ISupportInitialize).BeginInit()
        TabPage3.SuspendLayout()
        CType(dgFacturas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tabPage1
        ' 
        tabPage1.BackColor = Color.Gainsboro
        tabPage1.Controls.Add(LabelMultiIdioma31)
        tabPage1.Controls.Add(tbxPoblacionOrigen)
        tabPage1.Controls.Add(tbiPoblacioOrigen)
        tabPage1.Controls.Add(LabelMultiIdioma27)
        tabPage1.Controls.Add(LabelMultiIdioma28)
        tabPage1.Controls.Add(tbxCPOrigen)
        tabPage1.Controls.Add(tbxObservaciones)
        tabPage1.Controls.Add(LabelMultiIdioma1)
        tabPage1.Controls.Add(LabelMultiIdioma5)
        tabPage1.Controls.Add(LabelMultiIdioma4)
        tabPage1.Controls.Add(tbxNIF)
        tabPage1.Controls.Add(Label1)
        tabPage1.Controls.Add(cmbxIdioma)
        tabPage1.Controls.Add(cbxEsComercial)
        tabPage1.Controls.Add(cmbxTarifas)
        tabPage1.Controls.Add(LabelMultiIdioma3)
        tabPage1.Controls.Add(LabelMultiIdioma2)
        tabPage1.Controls.Add(tbxMail)
        tabPage1.Controls.Add(LabelMultiIdioma6)
        tabPage1.Controls.Add(tbxDireccionOrigen)
        tabPage1.Controls.Add(LabelMultiIdioma8)
        tabPage1.Controls.Add(tbxNom)
        tabPage1.Location = New Point(4, 27)
        tabPage1.Name = "tabPage1"
        tabPage1.Padding = New Padding(3)
        tabPage1.Size = New Size(885, 373)
        tabPage1.TabIndex = 0
        tabPage1.Text = "Principal"
        ' 
        ' LabelMultiIdioma31
        ' 
        LabelMultiIdioma31.AutoEllipsis = True
        LabelMultiIdioma31.BackColor = Color.Khaki
        LabelMultiIdioma31.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma31.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma31.Location = New Point(3, 111)
        LabelMultiIdioma31.Name = "LabelMultiIdioma31"
        LabelMultiIdioma31.Size = New Size(172, 23)
        LabelMultiIdioma31.TabIndex = 50
        LabelMultiIdioma31.Text = "Población Origen"
        LabelMultiIdioma31.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma31.TextoCastellano = "Población Origen"
        LabelMultiIdioma31.TextoCatalan = "Població Origen"
        ' 
        ' tbxPoblacionOrigen
        ' 
        tbxPoblacionOrigen.BackColor = SystemColors.GradientActiveCaption
        tbxPoblacionOrigen.BorderStyle = BorderStyle.FixedSingle
        tbxPoblacionOrigen.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbxPoblacionOrigen.Location = New Point(178, 111)
        tbxPoblacionOrigen.MaxLength = 10
        tbxPoblacionOrigen.Name = "tbxPoblacionOrigen"
        tbxPoblacionOrigen.Size = New Size(338, 23)
        tbxPoblacionOrigen.TabIndex = 51
        ' 
        ' tbiPoblacioOrigen
        ' 
        tbiPoblacioOrigen._Valor = ""
        tbiPoblacioOrigen.AutoSize = True
        tbiPoblacioOrigen.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tbiPoblacioOrigen.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        tbiPoblacioOrigen.Location = New Point(177, 82)
        tbiPoblacioOrigen.Margin = New Padding(4, 3, 4, 3)
        tbiPoblacioOrigen.Name = "tbiPoblacioOrigen"
        tbiPoblacioOrigen.Size = New Size(131, 30)
        tbiPoblacioOrigen.TabIndex = 49
        tbiPoblacioOrigen.uCampBD1 = "NomPoblacio"
        tbiPoblacioOrigen.uCampBD2 = "CodPostal"
        tbiPoblacioOrigen.uCampBD3 = ""
        tbiPoblacioOrigen.uCampBD4 = ""
        tbiPoblacioOrigen.uCampBD5 = Nothing
        tbiPoblacioOrigen.uCampBD6 = Nothing
        tbiPoblacioOrigen.uCampBD7 = Nothing
        tbiPoblacioOrigen.uObjRecord = Nothing
        tbiPoblacioOrigen.utbxCamp1 = tbxPoblacionOrigen
        tbiPoblacioOrigen.utbxCamp2 = tbxCPOrigen
        tbiPoblacioOrigen.utbxCamp3 = Nothing
        tbiPoblacioOrigen.utbxCamp4 = Nothing
        tbiPoblacioOrigen.utbxCamp5 = Nothing
        tbiPoblacioOrigen.utbxCamp6 = Nothing
        tbiPoblacioOrigen.utbxCamp7 = Nothing
        ' 
        ' tbxCPOrigen
        ' 
        tbxCPOrigen.BackColor = SystemColors.GradientActiveCaption
        tbxCPOrigen.BorderStyle = BorderStyle.FixedSingle
        tbxCPOrigen.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbxCPOrigen.Location = New Point(178, 138)
        tbxCPOrigen.MaxLength = 10
        tbxCPOrigen.Name = "tbxCPOrigen"
        tbxCPOrigen.Size = New Size(130, 23)
        tbxCPOrigen.TabIndex = 47
        ' 
        ' LabelMultiIdioma27
        ' 
        LabelMultiIdioma27.AutoEllipsis = True
        LabelMultiIdioma27.BackColor = Color.Khaki
        LabelMultiIdioma27.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma27.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma27.Location = New Point(3, 84)
        LabelMultiIdioma27.Name = "LabelMultiIdioma27"
        LabelMultiIdioma27.Size = New Size(172, 23)
        LabelMultiIdioma27.TabIndex = 48
        LabelMultiIdioma27.Text = "Población Origen"
        LabelMultiIdioma27.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma27.TextoCastellano = "Población Origen"
        LabelMultiIdioma27.TextoCatalan = "Població Origen"
        ' 
        ' LabelMultiIdioma28
        ' 
        LabelMultiIdioma28.AutoEllipsis = True
        LabelMultiIdioma28.BackColor = Color.Khaki
        LabelMultiIdioma28.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma28.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma28.Location = New Point(3, 138)
        LabelMultiIdioma28.Name = "LabelMultiIdioma28"
        LabelMultiIdioma28.Size = New Size(172, 23)
        LabelMultiIdioma28.TabIndex = 46
        LabelMultiIdioma28.Text = "CP Origen"
        LabelMultiIdioma28.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma28.TextoCastellano = "CP Origen"
        LabelMultiIdioma28.TextoCatalan = "CP Origen"
        ' 
        ' tbxObservaciones
        ' 
        tbxObservaciones.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbxObservaciones.Location = New Point(3, 191)
        tbxObservaciones.MaxLength = 500
        tbxObservaciones.Multiline = True
        tbxObservaciones.Name = "tbxObservaciones"
        tbxObservaciones.Size = New Size(876, 179)
        tbxObservaciones.TabIndex = 45
        ' 
        ' LabelMultiIdioma1
        ' 
        LabelMultiIdioma1.AutoEllipsis = True
        LabelMultiIdioma1.BackColor = Color.Khaki
        LabelMultiIdioma1.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma1.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma1.Location = New Point(3, 165)
        LabelMultiIdioma1.Name = "LabelMultiIdioma1"
        LabelMultiIdioma1.Size = New Size(172, 23)
        LabelMultiIdioma1.TabIndex = 44
        LabelMultiIdioma1.Text = "Observaciones"
        LabelMultiIdioma1.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma1.TextoCastellano = "Observaciones"
        LabelMultiIdioma1.TextoCatalan = "Observacions"
        ' 
        ' LabelMultiIdioma5
        ' 
        LabelMultiIdioma5.AutoEllipsis = True
        LabelMultiIdioma5.BackColor = Color.Khaki
        LabelMultiIdioma5.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma5.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma5.Location = New Point(444, 57)
        LabelMultiIdioma5.Name = "LabelMultiIdioma5"
        LabelMultiIdioma5.Size = New Size(172, 23)
        LabelMultiIdioma5.TabIndex = 43
        LabelMultiIdioma5.Text = "Tarifa Favorita"
        LabelMultiIdioma5.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma5.TextoCastellano = "Tarifa Favorita"
        LabelMultiIdioma5.TextoCatalan = "Tarifa Preferida"
        ' 
        ' LabelMultiIdioma4
        ' 
        LabelMultiIdioma4.AutoEllipsis = True
        LabelMultiIdioma4.BackColor = Color.Khaki
        LabelMultiIdioma4.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma4.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma4.Location = New Point(3, 57)
        LabelMultiIdioma4.Name = "LabelMultiIdioma4"
        LabelMultiIdioma4.Size = New Size(172, 23)
        LabelMultiIdioma4.TabIndex = 41
        LabelMultiIdioma4.Text = "NIF"
        LabelMultiIdioma4.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma4.TextoCastellano = "NIF"
        LabelMultiIdioma4.TextoCatalan = "NIF"
        ' 
        ' tbxNIF
        ' 
        tbxNIF.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbxNIF.Location = New Point(178, 57)
        tbxNIF.MaxLength = 15
        tbxNIF.Name = "tbxNIF"
        tbxNIF.Size = New Size(260, 23)
        tbxNIF.TabIndex = 42
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Khaki
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(444, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(172, 23)
        Label1.TabIndex = 40
        Label1.Text = "Idioma"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cmbxIdioma
        ' 
        cmbxIdioma.DropDownStyle = ComboBoxStyle.DropDownList
        cmbxIdioma.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        cmbxIdioma.FormattingEnabled = True
        cmbxIdioma.Location = New Point(619, 30)
        cmbxIdioma.Name = "cmbxIdioma"
        cmbxIdioma.Size = New Size(260, 23)
        cmbxIdioma.TabIndex = 39
        ' 
        ' cbxEsComercial
        ' 
        cbxEsComercial.AutoSize = True
        cbxEsComercial.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        cbxEsComercial.Location = New Point(619, 90)
        cbxEsComercial.Name = "cbxEsComercial"
        cbxEsComercial.Size = New Size(15, 14)
        cbxEsComercial.TabIndex = 38
        cbxEsComercial.UseVisualStyleBackColor = True
        ' 
        ' cmbxTarifas
        ' 
        cmbxTarifas.DropDownStyle = ComboBoxStyle.DropDownList
        cmbxTarifas.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        cmbxTarifas.FormattingEnabled = True
        cmbxTarifas.Location = New Point(619, 57)
        cmbxTarifas.Name = "cmbxTarifas"
        cmbxTarifas.Size = New Size(260, 23)
        cmbxTarifas.TabIndex = 37
        ' 
        ' LabelMultiIdioma3
        ' 
        LabelMultiIdioma3.AutoEllipsis = True
        LabelMultiIdioma3.BackColor = Color.Khaki
        LabelMultiIdioma3.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma3.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma3.Location = New Point(444, 84)
        LabelMultiIdioma3.Name = "LabelMultiIdioma3"
        LabelMultiIdioma3.Size = New Size(172, 23)
        LabelMultiIdioma3.TabIndex = 35
        LabelMultiIdioma3.Text = "Es Empresa"
        LabelMultiIdioma3.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma3.TextoCastellano = "Es Empresa"
        LabelMultiIdioma3.TextoCatalan = "És Empresa"
        ' 
        ' LabelMultiIdioma2
        ' 
        LabelMultiIdioma2.AutoEllipsis = True
        LabelMultiIdioma2.BackColor = Color.Khaki
        LabelMultiIdioma2.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma2.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma2.Location = New Point(3, 30)
        LabelMultiIdioma2.Name = "LabelMultiIdioma2"
        LabelMultiIdioma2.Size = New Size(172, 23)
        LabelMultiIdioma2.TabIndex = 31
        LabelMultiIdioma2.Text = "Mail"
        LabelMultiIdioma2.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma2.TextoCastellano = "Mail"
        LabelMultiIdioma2.TextoCatalan = "Mail"
        ' 
        ' tbxMail
        ' 
        tbxMail.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbxMail.Location = New Point(178, 30)
        tbxMail.MaxLength = 50
        tbxMail.Name = "tbxMail"
        tbxMail.Size = New Size(260, 23)
        tbxMail.TabIndex = 32
        ' 
        ' LabelMultiIdioma6
        ' 
        LabelMultiIdioma6.AutoEllipsis = True
        LabelMultiIdioma6.BackColor = Color.Khaki
        LabelMultiIdioma6.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma6.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma6.Location = New Point(444, 3)
        LabelMultiIdioma6.Name = "LabelMultiIdioma6"
        LabelMultiIdioma6.Size = New Size(172, 23)
        LabelMultiIdioma6.TabIndex = 29
        LabelMultiIdioma6.Text = "Dirección Origen"
        LabelMultiIdioma6.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma6.TextoCastellano = "Dirección Origen"
        LabelMultiIdioma6.TextoCatalan = "Direcció Origen"
        ' 
        ' tbxDireccionOrigen
        ' 
        tbxDireccionOrigen.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbxDireccionOrigen.Location = New Point(619, 3)
        tbxDireccionOrigen.MaxLength = 200
        tbxDireccionOrigen.Name = "tbxDireccionOrigen"
        tbxDireccionOrigen.Size = New Size(260, 23)
        tbxDireccionOrigen.TabIndex = 30
        ' 
        ' LabelMultiIdioma8
        ' 
        LabelMultiIdioma8.AutoEllipsis = True
        LabelMultiIdioma8.BackColor = Color.Khaki
        LabelMultiIdioma8.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma8.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma8.Location = New Point(3, 3)
        LabelMultiIdioma8.Name = "LabelMultiIdioma8"
        LabelMultiIdioma8.Size = New Size(172, 23)
        LabelMultiIdioma8.TabIndex = 27
        LabelMultiIdioma8.Text = "Nom Client"
        LabelMultiIdioma8.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma8.TextoCastellano = "Nombre Cliente"
        LabelMultiIdioma8.TextoCatalan = "Nom Client"
        ' 
        ' tbxNom
        ' 
        tbxNom.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbxNom.Location = New Point(178, 3)
        tbxNom.MaxLength = 100
        tbxNom.Name = "tbxNom"
        tbxNom.Size = New Size(260, 23)
        tbxNom.TabIndex = 28
        ' 
        ' tabEnvios
        ' 
        tabEnvios.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tabEnvios.Controls.Add(tabPage1)
        tabEnvios.Controls.Add(TabPage2)
        tabEnvios.Controls.Add(TabPage3)
        tabEnvios.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        tabEnvios.Location = New Point(0, 0)
        tabEnvios.Name = "tabEnvios"
        tabEnvios.SelectedIndex = 0
        tabEnvios.Size = New Size(893, 404)
        tabEnvios.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(dgEnvios)
        TabPage2.Location = New Point(4, 27)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(885, 373)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Enviaments"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' dgEnvios
        ' 
        dgEnvios.AccessibleName = "Table"
        dgEnvios.AllowEditing = False
        dgEnvios.AllowFiltering = True
        dgEnvios.AllowResizingColumns = True
        dgEnvios.AllowSelectionOnMouseDown = True
        dgEnvios.Dock = DockStyle.Fill
        dgEnvios.EditMode = Syncfusion.WinForms.DataGrid.Enums.EditMode.SingleClick
        dgEnvios.Location = New Point(3, 3)
        dgEnvios.Name = "dgEnvios"
        dgEnvios.ShowGroupDropArea = True
        dgEnvios.Size = New Size(879, 367)
        dgEnvios.Style.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        dgEnvios.Style.CheckBoxStyle.CheckedBackColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        dgEnvios.Style.CheckBoxStyle.CheckedBorderColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        dgEnvios.Style.CheckBoxStyle.IndeterminateBorderColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        dgEnvios.Style.HeaderStyle.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        dgEnvios.Style.HeaderStyle.Font.Bold = True
        dgEnvios.Style.HyperlinkStyle.DefaultLinkColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        dgEnvios.TabIndex = 10
        dgEnvios.Text = "SfDataGrid1"
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(btnGenerarFactura)
        TabPage3.Controls.Add(dgFacturas)
        TabPage3.Location = New Point(4, 27)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(885, 373)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Factures"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' btnGenerarFactura
        ' 
        btnGenerarFactura.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnGenerarFactura.AutoSize = True
        btnGenerarFactura.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnGenerarFactura.Image = CType(resources.GetObject("btnGenerarFactura.Image"), Image)
        btnGenerarFactura.ImageAlign = ContentAlignment.MiddleLeft
        btnGenerarFactura.Location = New Point(795, 15)
        btnGenerarFactura.Name = "btnGenerarFactura"
        btnGenerarFactura.Size = New Size(84, 30)
        btnGenerarFactura.TabIndex = 25
        btnGenerarFactura.Text = "Abrir"
        btnGenerarFactura.TextoCastellano = "Abrir"
        btnGenerarFactura.TextoCatalan = "Obrir"
        btnGenerarFactura.UseVisualStyleBackColor = True
        ' 
        ' dgFacturas
        ' 
        dgFacturas.AccessibleName = "Table"
        dgFacturas.AllowEditing = False
        dgFacturas.AllowFiltering = True
        dgFacturas.AllowResizingColumns = True
        dgFacturas.AllowSelectionOnMouseDown = True
        dgFacturas.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgFacturas.EditMode = Syncfusion.WinForms.DataGrid.Enums.EditMode.SingleClick
        dgFacturas.Location = New Point(0, 0)
        dgFacturas.Name = "dgFacturas"
        dgFacturas.ShowGroupDropArea = True
        dgFacturas.Size = New Size(789, 373)
        dgFacturas.Style.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        dgFacturas.Style.CheckBoxStyle.CheckedBackColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        dgFacturas.Style.CheckBoxStyle.CheckedBorderColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        dgFacturas.Style.CheckBoxStyle.IndeterminateBorderColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        dgFacturas.Style.HeaderStyle.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        dgFacturas.Style.HeaderStyle.Font.Bold = True
        dgFacturas.Style.HyperlinkStyle.DefaultLinkColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        dgFacturas.TabIndex = 11
        dgFacturas.Text = "SfDataGrid1"
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnGuardar.AutoSize = True
        btnGuardar.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), Image)
        btnGuardar.ImageAlign = ContentAlignment.MiddleLeft
        btnGuardar.Location = New Point(623, 412)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(122, 30)
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
        btnCancelar.Location = New Point(752, 412)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(127, 30)
        btnCancelar.TabIndex = 1
        btnCancelar.Text = "Cancelar"
        btnCancelar.TextoCastellano = "Cancelar"
        btnCancelar.TextoCatalan = "Cancel·lar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' btnBorrar
        ' 
        btnBorrar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnBorrar.AutoSize = True
        btnBorrar.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), Image)
        btnBorrar.ImageAlign = ContentAlignment.MiddleLeft
        btnBorrar.Location = New Point(12, 412)
        btnBorrar.Name = "btnBorrar"
        btnBorrar.Size = New Size(127, 30)
        btnBorrar.TabIndex = 2
        btnBorrar.Text = "Borrar"
        btnBorrar.TextoCastellano = "Borrar"
        btnBorrar.TextoCatalan = "Esborrar"
        btnBorrar.UseVisualStyleBackColor = True
        ' 
        ' frmClients
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(891, 450)
        Controls.Add(btnBorrar)
        Controls.Add(btnCancelar)
        Controls.Add(btnGuardar)
        Controls.Add(tabEnvios)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmClients"
        Text = "frmGeneric"
        tabPage1.ResumeLayout(False)
        tabPage1.PerformLayout()
        tabEnvios.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        CType(dgEnvios, ComponentModel.ISupportInitialize).EndInit()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        CType(dgFacturas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tabPage1 As TabPage
    Friend WithEvents tabEnvios As TabControl
    Friend WithEvents btnGuardar As ButtonMultiIdioma
    Friend WithEvents btnCancelar As ButtonMultiIdioma
    Friend WithEvents btnBorrar As ButtonMultiIdioma
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgEnvios As Syncfusion.WinForms.DataGrid.SfDataGrid
    Friend WithEvents tbxObservaciones As TextBox
    Friend WithEvents LabelMultiIdioma1 As LabelMultiIdioma
    Friend WithEvents LabelMultiIdioma5 As LabelMultiIdioma
    Friend WithEvents LabelMultiIdioma4 As LabelMultiIdioma
    Friend WithEvents tbxNIF As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbxIdioma As ComboBox
    Friend WithEvents cbxEsComercial As CheckBox
    Friend WithEvents cmbxTarifas As ComboBox
    Friend WithEvents LabelMultiIdioma3 As LabelMultiIdioma
    Friend WithEvents LabelMultiIdioma2 As LabelMultiIdioma
    Friend WithEvents tbxMail As TextBox
    Friend WithEvents LabelMultiIdioma6 As LabelMultiIdioma
    Friend WithEvents tbxDireccionOrigen As TextBox
    Friend WithEvents LabelMultiIdioma8 As LabelMultiIdioma
    Friend WithEvents tbxNom As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents dgFacturas As Syncfusion.WinForms.DataGrid.SfDataGrid
    Friend WithEvents LabelMultiIdioma31 As LabelMultiIdioma
    Friend WithEvents tbxPoblacionOrigen As TextBox
    Friend WithEvents tbiPoblacioOrigen As Lupa
    Friend WithEvents tbxCPOrigen As TextBox
    Friend WithEvents LabelMultiIdioma27 As LabelMultiIdioma
    Friend WithEvents LabelMultiIdioma28 As LabelMultiIdioma
    Friend WithEvents btnGenerarFactura As ButtonMultiIdioma
End Class
