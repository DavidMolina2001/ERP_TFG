<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreferencies
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPreferencies))
        cmbxIdioma = New ComboBox()
        Label1 = New Label()
        btnAcceptar = New ButtonMultiIdioma()
        Label2 = New Label()
        cmbxLDAP = New ComboBox()
        tbxRutaFactCAT = New TextBox()
        LabelMultiIdioma2 = New LabelMultiIdioma()
        btnSelectPathFactCAT = New ButtonMultiIdioma()
        tbxRutaFactCAS = New TextBox()
        LabelMultiIdioma3 = New LabelMultiIdioma()
        btnSelectPathFactCAS = New ButtonMultiIdioma()
        tbxRutaExcelEnvCAS = New TextBox()
        LabelMultiIdioma4 = New LabelMultiIdioma()
        btnSelectPathExcelEnvCAS = New ButtonMultiIdioma()
        tbxRutaExcelEnvCAT = New TextBox()
        LabelMultiIdioma5 = New LabelMultiIdioma()
        btnSelectPathExcelEnvCAT = New ButtonMultiIdioma()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        TabPage2 = New TabPage()
        tbxRutaExcelFactCAS = New TextBox()
        LabelMultiIdioma6 = New LabelMultiIdioma()
        btnSelectPathExcelFactCAS = New ButtonMultiIdioma()
        tbxRutaExcelFactCAT = New TextBox()
        LabelMultiIdioma7 = New LabelMultiIdioma()
        btnSelectPathExcelFactCAT = New ButtonMultiIdioma()
        TabPage3 = New TabPage()
        tbxPathGuardadoInformes = New TextBox()
        LabelMultiIdioma8 = New LabelMultiIdioma()
        btnPathGuardadoInformes = New ButtonMultiIdioma()
        tbxPathGuardadoFacturas = New TextBox()
        LabelMultiIdioma9 = New LabelMultiIdioma()
        btnPathGuardadoFacturas = New ButtonMultiIdioma()
        LabelMultiIdioma1 = New LabelMultiIdioma()
        btnSelectPathEtiquetes = New ButtonMultiIdioma()
        tbxRutaEtiquetas = New TextBox()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        SuspendLayout()
        ' 
        ' cmbxIdioma
        ' 
        cmbxIdioma.FormattingEnabled = True
        cmbxIdioma.Location = New Point(3, 27)
        cmbxIdioma.Name = "cmbxIdioma"
        cmbxIdioma.Size = New Size(275, 23)
        cmbxIdioma.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Khaki
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(3, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(275, 21)
        Label1.TabIndex = 1
        Label1.Text = "Idioma"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnAcceptar
        ' 
        btnAcceptar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnAcceptar.AutoSize = True
        btnAcceptar.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnAcceptar.Location = New Point(139, 463)
        btnAcceptar.Name = "btnAcceptar"
        btnAcceptar.Size = New Size(148, 25)
        btnAcceptar.TabIndex = 2
        btnAcceptar.Text = "Guardar Preferencias"
        btnAcceptar.TextoCastellano = "Guardar Preferencias"
        btnAcceptar.TextoCatalan = "Guardar Preferències"
        btnAcceptar.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Khaki
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(3, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(275, 21)
        Label2.TabIndex = 3
        Label2.Text = "LDAP"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cmbxLDAP
        ' 
        cmbxLDAP.FormattingEnabled = True
        cmbxLDAP.Location = New Point(3, 88)
        cmbxLDAP.Name = "cmbxLDAP"
        cmbxLDAP.Size = New Size(275, 23)
        cmbxLDAP.TabIndex = 7
        ' 
        ' tbxRutaFactCAT
        ' 
        tbxRutaFactCAT.Location = New Point(3, 28)
        tbxRutaFactCAT.Name = "tbxRutaFactCAT"
        tbxRutaFactCAT.Size = New Size(213, 23)
        tbxRutaFactCAT.TabIndex = 10
        ' 
        ' LabelMultiIdioma2
        ' 
        LabelMultiIdioma2.BackColor = Color.Khaki
        LabelMultiIdioma2.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LabelMultiIdioma2.Location = New Point(3, 4)
        LabelMultiIdioma2.Name = "LabelMultiIdioma2"
        LabelMultiIdioma2.Size = New Size(275, 21)
        LabelMultiIdioma2.TabIndex = 9
        LabelMultiIdioma2.Text = "Ruta Plantilla Factura CAT"
        LabelMultiIdioma2.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma2.TextoCastellano = "Ruta Plantilla Factura CAT"
        LabelMultiIdioma2.TextoCatalan = "Ruta Plantilla Factura CAT"
        ' 
        ' btnSelectPathFactCAT
        ' 
        btnSelectPathFactCAT.AutoSize = True
        btnSelectPathFactCAT.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnSelectPathFactCAT.Location = New Point(216, 28)
        btnSelectPathFactCAT.Name = "btnSelectPathFactCAT"
        btnSelectPathFactCAT.Size = New Size(62, 25)
        btnSelectPathFactCAT.TabIndex = 8
        btnSelectPathFactCAT.Text = "Cambiar"
        btnSelectPathFactCAT.TextoCastellano = "Cambiar"
        btnSelectPathFactCAT.TextoCatalan = "Canviar"
        btnSelectPathFactCAT.UseVisualStyleBackColor = True
        ' 
        ' tbxRutaFactCAS
        ' 
        tbxRutaFactCAS.Location = New Point(3, 85)
        tbxRutaFactCAS.Name = "tbxRutaFactCAS"
        tbxRutaFactCAS.Size = New Size(213, 23)
        tbxRutaFactCAS.TabIndex = 13
        ' 
        ' LabelMultiIdioma3
        ' 
        LabelMultiIdioma3.BackColor = Color.Khaki
        LabelMultiIdioma3.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LabelMultiIdioma3.Location = New Point(3, 61)
        LabelMultiIdioma3.Name = "LabelMultiIdioma3"
        LabelMultiIdioma3.Size = New Size(275, 21)
        LabelMultiIdioma3.TabIndex = 12
        LabelMultiIdioma3.Text = "Ruta Plantilla Factura CAS"
        LabelMultiIdioma3.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma3.TextoCastellano = "Ruta Plantilla Factura CAS"
        LabelMultiIdioma3.TextoCatalan = "Ruta Plantilla Factura CAS"
        ' 
        ' btnSelectPathFactCAS
        ' 
        btnSelectPathFactCAS.AutoSize = True
        btnSelectPathFactCAS.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnSelectPathFactCAS.Location = New Point(216, 85)
        btnSelectPathFactCAS.Name = "btnSelectPathFactCAS"
        btnSelectPathFactCAS.Size = New Size(62, 25)
        btnSelectPathFactCAS.TabIndex = 11
        btnSelectPathFactCAS.Text = "Cambiar"
        btnSelectPathFactCAS.TextoCastellano = "Cambiar"
        btnSelectPathFactCAS.TextoCatalan = "Canviar"
        btnSelectPathFactCAS.UseVisualStyleBackColor = True
        ' 
        ' tbxRutaExcelEnvCAS
        ' 
        tbxRutaExcelEnvCAS.Location = New Point(3, 197)
        tbxRutaExcelEnvCAS.Name = "tbxRutaExcelEnvCAS"
        tbxRutaExcelEnvCAS.Size = New Size(213, 23)
        tbxRutaExcelEnvCAS.TabIndex = 19
        ' 
        ' LabelMultiIdioma4
        ' 
        LabelMultiIdioma4.BackColor = Color.Khaki
        LabelMultiIdioma4.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LabelMultiIdioma4.Location = New Point(3, 173)
        LabelMultiIdioma4.Name = "LabelMultiIdioma4"
        LabelMultiIdioma4.Size = New Size(275, 21)
        LabelMultiIdioma4.TabIndex = 18
        LabelMultiIdioma4.Text = "Ruta Plantilla Excel Env. CAS"
        LabelMultiIdioma4.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma4.TextoCastellano = "Ruta Plantilla Excel Envíos CAS"
        LabelMultiIdioma4.TextoCatalan = "Ruta Plantilla Excel Env. CAS"
        ' 
        ' btnSelectPathExcelEnvCAS
        ' 
        btnSelectPathExcelEnvCAS.AutoSize = True
        btnSelectPathExcelEnvCAS.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnSelectPathExcelEnvCAS.Location = New Point(216, 197)
        btnSelectPathExcelEnvCAS.Name = "btnSelectPathExcelEnvCAS"
        btnSelectPathExcelEnvCAS.Size = New Size(62, 25)
        btnSelectPathExcelEnvCAS.TabIndex = 17
        btnSelectPathExcelEnvCAS.Text = "Cambiar"
        btnSelectPathExcelEnvCAS.TextoCastellano = "Cambiar"
        btnSelectPathExcelEnvCAS.TextoCatalan = "Canviar"
        btnSelectPathExcelEnvCAS.UseVisualStyleBackColor = True
        ' 
        ' tbxRutaExcelEnvCAT
        ' 
        tbxRutaExcelEnvCAT.Location = New Point(3, 140)
        tbxRutaExcelEnvCAT.Name = "tbxRutaExcelEnvCAT"
        tbxRutaExcelEnvCAT.Size = New Size(213, 23)
        tbxRutaExcelEnvCAT.TabIndex = 16
        ' 
        ' LabelMultiIdioma5
        ' 
        LabelMultiIdioma5.BackColor = Color.Khaki
        LabelMultiIdioma5.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma5.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LabelMultiIdioma5.Location = New Point(3, 116)
        LabelMultiIdioma5.Name = "LabelMultiIdioma5"
        LabelMultiIdioma5.Size = New Size(275, 21)
        LabelMultiIdioma5.TabIndex = 15
        LabelMultiIdioma5.Text = "Ruta Plantilla Excel Env. CAT"
        LabelMultiIdioma5.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma5.TextoCastellano = "Ruta Plantilla Excel Envíos CAT"
        LabelMultiIdioma5.TextoCatalan = "Ruta Plantilla Excel Env. CAT"
        ' 
        ' btnSelectPathExcelEnvCAT
        ' 
        btnSelectPathExcelEnvCAT.AutoSize = True
        btnSelectPathExcelEnvCAT.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnSelectPathExcelEnvCAT.Location = New Point(216, 140)
        btnSelectPathExcelEnvCAT.Name = "btnSelectPathExcelEnvCAT"
        btnSelectPathExcelEnvCAT.Size = New Size(62, 25)
        btnSelectPathExcelEnvCAT.TabIndex = 14
        btnSelectPathExcelEnvCAT.Text = "Cambiar"
        btnSelectPathExcelEnvCAT.TextoCastellano = "Cambiar"
        btnSelectPathExcelEnvCAT.TextoCatalan = "Canviar"
        btnSelectPathExcelEnvCAT.UseVisualStyleBackColor = True
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(3, 4)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(290, 452)
        TabControl1.TabIndex = 20
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(cmbxIdioma)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(cmbxLDAP)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(282, 424)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Principal"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(tbxRutaExcelFactCAS)
        TabPage2.Controls.Add(LabelMultiIdioma6)
        TabPage2.Controls.Add(btnSelectPathExcelFactCAS)
        TabPage2.Controls.Add(tbxRutaExcelFactCAT)
        TabPage2.Controls.Add(LabelMultiIdioma7)
        TabPage2.Controls.Add(btnSelectPathExcelFactCAT)
        TabPage2.Controls.Add(tbxRutaExcelEnvCAS)
        TabPage2.Controls.Add(LabelMultiIdioma4)
        TabPage2.Controls.Add(btnSelectPathExcelEnvCAS)
        TabPage2.Controls.Add(btnSelectPathFactCAT)
        TabPage2.Controls.Add(tbxRutaExcelEnvCAT)
        TabPage2.Controls.Add(LabelMultiIdioma2)
        TabPage2.Controls.Add(LabelMultiIdioma5)
        TabPage2.Controls.Add(tbxRutaFactCAT)
        TabPage2.Controls.Add(btnSelectPathExcelEnvCAT)
        TabPage2.Controls.Add(btnSelectPathFactCAS)
        TabPage2.Controls.Add(tbxRutaFactCAS)
        TabPage2.Controls.Add(LabelMultiIdioma3)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(282, 424)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Rutes Plantilles"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' tbxRutaExcelFactCAS
        ' 
        tbxRutaExcelFactCAS.Location = New Point(3, 310)
        tbxRutaExcelFactCAS.Name = "tbxRutaExcelFactCAS"
        tbxRutaExcelFactCAS.Size = New Size(213, 23)
        tbxRutaExcelFactCAS.TabIndex = 25
        ' 
        ' LabelMultiIdioma6
        ' 
        LabelMultiIdioma6.BackColor = Color.Khaki
        LabelMultiIdioma6.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma6.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LabelMultiIdioma6.Location = New Point(3, 286)
        LabelMultiIdioma6.Name = "LabelMultiIdioma6"
        LabelMultiIdioma6.Size = New Size(275, 21)
        LabelMultiIdioma6.TabIndex = 24
        LabelMultiIdioma6.Text = "Ruta Plantilla Excel Fact CAS"
        LabelMultiIdioma6.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma6.TextoCastellano = "Ruta Plantilla Excel Fact CAS"
        LabelMultiIdioma6.TextoCatalan = "Ruta Plantilla Excel Fact CAS"
        ' 
        ' btnSelectPathExcelFactCAS
        ' 
        btnSelectPathExcelFactCAS.AutoSize = True
        btnSelectPathExcelFactCAS.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnSelectPathExcelFactCAS.Location = New Point(216, 310)
        btnSelectPathExcelFactCAS.Name = "btnSelectPathExcelFactCAS"
        btnSelectPathExcelFactCAS.Size = New Size(62, 25)
        btnSelectPathExcelFactCAS.TabIndex = 23
        btnSelectPathExcelFactCAS.Text = "Cambiar"
        btnSelectPathExcelFactCAS.TextoCastellano = "Cambiar"
        btnSelectPathExcelFactCAS.TextoCatalan = "Canviar"
        btnSelectPathExcelFactCAS.UseVisualStyleBackColor = True
        ' 
        ' tbxRutaExcelFactCAT
        ' 
        tbxRutaExcelFactCAT.Location = New Point(3, 253)
        tbxRutaExcelFactCAT.Name = "tbxRutaExcelFactCAT"
        tbxRutaExcelFactCAT.Size = New Size(213, 23)
        tbxRutaExcelFactCAT.TabIndex = 22
        ' 
        ' LabelMultiIdioma7
        ' 
        LabelMultiIdioma7.BackColor = Color.Khaki
        LabelMultiIdioma7.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma7.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LabelMultiIdioma7.Location = New Point(3, 229)
        LabelMultiIdioma7.Name = "LabelMultiIdioma7"
        LabelMultiIdioma7.Size = New Size(275, 21)
        LabelMultiIdioma7.TabIndex = 21
        LabelMultiIdioma7.Text = "Ruta Plantilla Excel Fact CAT"
        LabelMultiIdioma7.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma7.TextoCastellano = "Ruta Plantilla Excel Fact CAT"
        LabelMultiIdioma7.TextoCatalan = "Ruta Plantilla Excel Fact CAT"
        ' 
        ' btnSelectPathExcelFactCAT
        ' 
        btnSelectPathExcelFactCAT.AutoSize = True
        btnSelectPathExcelFactCAT.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnSelectPathExcelFactCAT.Location = New Point(216, 253)
        btnSelectPathExcelFactCAT.Name = "btnSelectPathExcelFactCAT"
        btnSelectPathExcelFactCAT.Size = New Size(62, 25)
        btnSelectPathExcelFactCAT.TabIndex = 20
        btnSelectPathExcelFactCAT.Text = "Cambiar"
        btnSelectPathExcelFactCAT.TextoCastellano = "Cambiar"
        btnSelectPathExcelFactCAT.TextoCatalan = "Canviar"
        btnSelectPathExcelFactCAT.UseVisualStyleBackColor = True
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(tbxPathGuardadoInformes)
        TabPage3.Controls.Add(LabelMultiIdioma8)
        TabPage3.Controls.Add(btnPathGuardadoInformes)
        TabPage3.Controls.Add(tbxPathGuardadoFacturas)
        TabPage3.Controls.Add(LabelMultiIdioma9)
        TabPage3.Controls.Add(btnPathGuardadoFacturas)
        TabPage3.Controls.Add(LabelMultiIdioma1)
        TabPage3.Controls.Add(btnSelectPathEtiquetes)
        TabPage3.Controls.Add(tbxRutaEtiquetas)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(282, 424)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Rutes Desat"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' tbxPathGuardadoInformes
        ' 
        tbxPathGuardadoInformes.Location = New Point(3, 136)
        tbxPathGuardadoInformes.Name = "tbxPathGuardadoInformes"
        tbxPathGuardadoInformes.Size = New Size(213, 23)
        tbxPathGuardadoInformes.TabIndex = 31
        ' 
        ' LabelMultiIdioma8
        ' 
        LabelMultiIdioma8.BackColor = Color.Khaki
        LabelMultiIdioma8.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma8.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LabelMultiIdioma8.Location = New Point(3, 112)
        LabelMultiIdioma8.Name = "LabelMultiIdioma8"
        LabelMultiIdioma8.Size = New Size(275, 21)
        LabelMultiIdioma8.TabIndex = 30
        LabelMultiIdioma8.Text = "Ruta Guardado Informes"
        LabelMultiIdioma8.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma8.TextoCastellano = "Ruta Guardado Informes"
        LabelMultiIdioma8.TextoCatalan = "Ruta Guardat Informes"
        ' 
        ' btnPathGuardadoInformes
        ' 
        btnPathGuardadoInformes.AutoSize = True
        btnPathGuardadoInformes.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnPathGuardadoInformes.Location = New Point(216, 136)
        btnPathGuardadoInformes.Name = "btnPathGuardadoInformes"
        btnPathGuardadoInformes.Size = New Size(62, 25)
        btnPathGuardadoInformes.TabIndex = 29
        btnPathGuardadoInformes.Text = "Cambiar"
        btnPathGuardadoInformes.TextoCastellano = "Cambiar"
        btnPathGuardadoInformes.TextoCatalan = "Canviar"
        btnPathGuardadoInformes.UseVisualStyleBackColor = True
        ' 
        ' tbxPathGuardadoFacturas
        ' 
        tbxPathGuardadoFacturas.Location = New Point(3, 79)
        tbxPathGuardadoFacturas.Name = "tbxPathGuardadoFacturas"
        tbxPathGuardadoFacturas.Size = New Size(213, 23)
        tbxPathGuardadoFacturas.TabIndex = 28
        ' 
        ' LabelMultiIdioma9
        ' 
        LabelMultiIdioma9.BackColor = Color.Khaki
        LabelMultiIdioma9.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma9.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LabelMultiIdioma9.Location = New Point(3, 55)
        LabelMultiIdioma9.Name = "LabelMultiIdioma9"
        LabelMultiIdioma9.Size = New Size(275, 21)
        LabelMultiIdioma9.TabIndex = 27
        LabelMultiIdioma9.Text = "Ruta Guardado Facturas"
        LabelMultiIdioma9.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma9.TextoCastellano = "Ruta Guardado Facturas"
        LabelMultiIdioma9.TextoCatalan = "Ruta Guardat Factures"
        ' 
        ' btnPathGuardadoFacturas
        ' 
        btnPathGuardadoFacturas.AutoSize = True
        btnPathGuardadoFacturas.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnPathGuardadoFacturas.Location = New Point(216, 79)
        btnPathGuardadoFacturas.Name = "btnPathGuardadoFacturas"
        btnPathGuardadoFacturas.Size = New Size(62, 25)
        btnPathGuardadoFacturas.TabIndex = 26
        btnPathGuardadoFacturas.Text = "Cambiar"
        btnPathGuardadoFacturas.TextoCastellano = "Cambiar"
        btnPathGuardadoFacturas.TextoCatalan = "Canviar"
        btnPathGuardadoFacturas.UseVisualStyleBackColor = True
        ' 
        ' LabelMultiIdioma1
        ' 
        LabelMultiIdioma1.BackColor = Color.Khaki
        LabelMultiIdioma1.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LabelMultiIdioma1.Location = New Point(3, 3)
        LabelMultiIdioma1.Name = "LabelMultiIdioma1"
        LabelMultiIdioma1.Size = New Size(275, 21)
        LabelMultiIdioma1.TabIndex = 8
        LabelMultiIdioma1.Text = "Ruta Guardado Etiquetas"
        LabelMultiIdioma1.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma1.TextoCastellano = "Ruta Guardado Etiquetas"
        LabelMultiIdioma1.TextoCatalan = "Ruta Guardat Etiquetes"
        ' 
        ' btnSelectPathEtiquetes
        ' 
        btnSelectPathEtiquetes.AutoSize = True
        btnSelectPathEtiquetes.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnSelectPathEtiquetes.Location = New Point(216, 27)
        btnSelectPathEtiquetes.Name = "btnSelectPathEtiquetes"
        btnSelectPathEtiquetes.Size = New Size(62, 25)
        btnSelectPathEtiquetes.TabIndex = 7
        btnSelectPathEtiquetes.Text = "Cambiar"
        btnSelectPathEtiquetes.TextoCastellano = "Cambiar"
        btnSelectPathEtiquetes.TextoCatalan = "Canviar"
        btnSelectPathEtiquetes.UseVisualStyleBackColor = True
        ' 
        ' tbxRutaEtiquetas
        ' 
        tbxRutaEtiquetas.Location = New Point(3, 27)
        tbxRutaEtiquetas.Name = "tbxRutaEtiquetas"
        tbxRutaEtiquetas.Size = New Size(213, 23)
        tbxRutaEtiquetas.TabIndex = 9
        ' 
        ' frmPreferencies
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(298, 503)
        Controls.Add(TabControl1)
        Controls.Add(btnAcceptar)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmPreferencies"
        Text = "frmPreferencies"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbxIdioma As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAcceptar As ButtonMultiIdioma
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbxLDAP As ComboBox
    Friend WithEvents tbxRutaFactCAT As TextBox
    Friend WithEvents LabelMultiIdioma2 As LabelMultiIdioma
    Friend WithEvents btnSelectPathFactCAT As ButtonMultiIdioma
    Friend WithEvents tbxRutaFactCAS As TextBox
    Friend WithEvents LabelMultiIdioma3 As LabelMultiIdioma
    Friend WithEvents btnSelectPathFactCAS As ButtonMultiIdioma
    Friend WithEvents tbxRutaExcelEnvCAS As TextBox
    Friend WithEvents LabelMultiIdioma4 As LabelMultiIdioma
    Friend WithEvents btnSelectPathExcelEnvCAS As ButtonMultiIdioma
    Friend WithEvents tbxRutaExcelEnvCAT As TextBox
    Friend WithEvents LabelMultiIdioma5 As LabelMultiIdioma
    Friend WithEvents btnSelectPathExcelEnvCAT As ButtonMultiIdioma
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents tbxRutaExcelFactCAS As TextBox
    Friend WithEvents LabelMultiIdioma6 As LabelMultiIdioma
    Friend WithEvents btnSelectPathExcelFactCAS As ButtonMultiIdioma
    Friend WithEvents tbxRutaExcelFactCAT As TextBox
    Friend WithEvents LabelMultiIdioma7 As LabelMultiIdioma
    Friend WithEvents btnSelectPathExcelFactCAT As ButtonMultiIdioma
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents LabelMultiIdioma1 As LabelMultiIdioma
    Friend WithEvents btnSelectPathEtiquetes As ButtonMultiIdioma
    Friend WithEvents tbxRutaEtiquetas As TextBox
    Friend WithEvents tbxPathGuardadoInformes As TextBox
    Friend WithEvents LabelMultiIdioma8 As LabelMultiIdioma
    Friend WithEvents btnPathGuardadoInformes As ButtonMultiIdioma
    Friend WithEvents tbxPathGuardadoFacturas As TextBox
    Friend WithEvents LabelMultiIdioma9 As LabelMultiIdioma
    Friend WithEvents btnPathGuardadoFacturas As ButtonMultiIdioma
End Class
