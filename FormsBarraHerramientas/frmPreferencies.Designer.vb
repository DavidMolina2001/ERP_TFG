﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        btnSelectPathEtiquetes = New ButtonMultiIdioma()
        Label2 = New Label()
        LabelMultiIdioma1 = New LabelMultiIdioma()
        tbxRutaEtiquetas = New TextBox()
        cmbxLDAP = New ComboBox()
        tbxRutaFactCAT = New TextBox()
        LabelMultiIdioma2 = New LabelMultiIdioma()
        btnSelectPathFactCAT = New ButtonMultiIdioma()
        tbxRutaFactCAS = New TextBox()
        LabelMultiIdioma3 = New LabelMultiIdioma()
        btnSelectPathFactCAS = New ButtonMultiIdioma()
        SuspendLayout()
        ' 
        ' cmbxIdioma
        ' 
        cmbxIdioma.FormattingEnabled = True
        cmbxIdioma.Location = New Point(12, 39)
        cmbxIdioma.Name = "cmbxIdioma"
        cmbxIdioma.Size = New Size(275, 23)
        cmbxIdioma.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Khaki
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(12, 15)
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
        btnAcceptar.Location = New Point(142, 312)
        btnAcceptar.Name = "btnAcceptar"
        btnAcceptar.Size = New Size(148, 25)
        btnAcceptar.TabIndex = 2
        btnAcceptar.Text = "Guardar Preferencias"
        btnAcceptar.TextoCastellano = "Guardar Preferencias"
        btnAcceptar.TextoCatalan = "Guardar Preferències"
        btnAcceptar.UseVisualStyleBackColor = True
        ' 
        ' btnSelectPathEtiquetes
        ' 
        btnSelectPathEtiquetes.AutoSize = True
        btnSelectPathEtiquetes.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnSelectPathEtiquetes.Location = New Point(225, 160)
        btnSelectPathEtiquetes.Name = "btnSelectPathEtiquetes"
        btnSelectPathEtiquetes.Size = New Size(62, 25)
        btnSelectPathEtiquetes.TabIndex = 0
        btnSelectPathEtiquetes.Text = "Cambiar"
        btnSelectPathEtiquetes.TextoCastellano = "Cambiar"
        btnSelectPathEtiquetes.TextoCatalan = "Canviar"
        btnSelectPathEtiquetes.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Khaki
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(12, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(275, 21)
        Label2.TabIndex = 3
        Label2.Text = "LDAP"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelMultiIdioma1
        ' 
        LabelMultiIdioma1.BackColor = Color.Khaki
        LabelMultiIdioma1.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LabelMultiIdioma1.Location = New Point(12, 136)
        LabelMultiIdioma1.Name = "LabelMultiIdioma1"
        LabelMultiIdioma1.Size = New Size(275, 21)
        LabelMultiIdioma1.TabIndex = 5
        LabelMultiIdioma1.Text = "Ruta Guardado Etiquetas"
        LabelMultiIdioma1.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma1.TextoCastellano = "Ruta Guardado Etiquetas"
        LabelMultiIdioma1.TextoCatalan = "Ruta Guardat Etiquetes"
        ' 
        ' tbxRutaEtiquetas
        ' 
        tbxRutaEtiquetas.Location = New Point(12, 160)
        tbxRutaEtiquetas.Name = "tbxRutaEtiquetas"
        tbxRutaEtiquetas.Size = New Size(213, 23)
        tbxRutaEtiquetas.TabIndex = 6
        ' 
        ' cmbxLDAP
        ' 
        cmbxLDAP.FormattingEnabled = True
        cmbxLDAP.Location = New Point(12, 100)
        cmbxLDAP.Name = "cmbxLDAP"
        cmbxLDAP.Size = New Size(275, 23)
        cmbxLDAP.TabIndex = 7
        ' 
        ' tbxRutaFactCAT
        ' 
        tbxRutaFactCAT.Location = New Point(12, 219)
        tbxRutaFactCAT.Name = "tbxRutaFactCAT"
        tbxRutaFactCAT.Size = New Size(213, 23)
        tbxRutaFactCAT.TabIndex = 10
        ' 
        ' LabelMultiIdioma2
        ' 
        LabelMultiIdioma2.BackColor = Color.Khaki
        LabelMultiIdioma2.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LabelMultiIdioma2.Location = New Point(12, 195)
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
        btnSelectPathFactCAT.Location = New Point(225, 219)
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
        tbxRutaFactCAS.Location = New Point(12, 276)
        tbxRutaFactCAS.Name = "tbxRutaFactCAS"
        tbxRutaFactCAS.Size = New Size(213, 23)
        tbxRutaFactCAS.TabIndex = 13
        ' 
        ' LabelMultiIdioma3
        ' 
        LabelMultiIdioma3.BackColor = Color.Khaki
        LabelMultiIdioma3.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LabelMultiIdioma3.Location = New Point(12, 252)
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
        btnSelectPathFactCAS.Location = New Point(225, 276)
        btnSelectPathFactCAS.Name = "btnSelectPathFactCAS"
        btnSelectPathFactCAS.Size = New Size(62, 25)
        btnSelectPathFactCAS.TabIndex = 11
        btnSelectPathFactCAS.Text = "Cambiar"
        btnSelectPathFactCAS.TextoCastellano = "Cambiar"
        btnSelectPathFactCAS.TextoCatalan = "Canviar"
        btnSelectPathFactCAS.UseVisualStyleBackColor = True
        ' 
        ' frmPreferencies
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(301, 352)
        Controls.Add(tbxRutaFactCAS)
        Controls.Add(LabelMultiIdioma3)
        Controls.Add(btnSelectPathFactCAS)
        Controls.Add(tbxRutaFactCAT)
        Controls.Add(LabelMultiIdioma2)
        Controls.Add(btnSelectPathFactCAT)
        Controls.Add(cmbxLDAP)
        Controls.Add(tbxRutaEtiquetas)
        Controls.Add(LabelMultiIdioma1)
        Controls.Add(Label2)
        Controls.Add(btnSelectPathEtiquetes)
        Controls.Add(btnAcceptar)
        Controls.Add(Label1)
        Controls.Add(cmbxIdioma)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmPreferencies"
        Text = "frmPreferencies"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbxIdioma As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAcceptar As ButtonMultiIdioma
    Friend WithEvents btnSelectPathEtiquetes As ButtonMultiIdioma
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelMultiIdioma1 As LabelMultiIdioma
    Friend WithEvents tbxRutaEtiquetas As TextBox
    Friend WithEvents cmbxLDAP As ComboBox
    Friend WithEvents tbxRutaFactCAT As TextBox
    Friend WithEvents LabelMultiIdioma2 As LabelMultiIdioma
    Friend WithEvents btnSelectPathFactCAT As ButtonMultiIdioma
    Friend WithEvents tbxRutaFactCAS As TextBox
    Friend WithEvents LabelMultiIdioma3 As LabelMultiIdioma
    Friend WithEvents btnSelectPathFactCAS As ButtonMultiIdioma
End Class
