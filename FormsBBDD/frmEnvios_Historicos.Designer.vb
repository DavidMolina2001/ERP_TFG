﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEnvios_Historicos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEnvios_Historicos))
        TabPage1 = New TabPage()
        cmbxEstat = New ComboBox()
        LabelMultiIdioma2 = New LabelMultiIdioma()
        tbxObservacions = New TextBox()
        LabelMultiIdioma1 = New LabelMultiIdioma()
        lblCodigoSeguimiento = New LabelMultiIdioma()
        DateTimePicker1 = New DateTimePicker()
        TabControl1 = New TabControl()
        btnGuardar = New ButtonMultiIdioma()
        btnCancelar = New ButtonMultiIdioma()
        TabPage1.SuspendLayout()
        TabControl1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.Gainsboro
        TabPage1.Controls.Add(cmbxEstat)
        TabPage1.Controls.Add(LabelMultiIdioma2)
        TabPage1.Controls.Add(tbxObservacions)
        TabPage1.Controls.Add(LabelMultiIdioma1)
        TabPage1.Controls.Add(lblCodigoSeguimiento)
        TabPage1.Controls.Add(DateTimePicker1)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(392, 322)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Principal"
        ' 
        ' cmbxEstat
        ' 
        cmbxEstat.FormattingEnabled = True
        cmbxEstat.Location = New Point(185, 43)
        cmbxEstat.Name = "cmbxEstat"
        cmbxEstat.Size = New Size(197, 23)
        cmbxEstat.TabIndex = 10
        ' 
        ' LabelMultiIdioma2
        ' 
        LabelMultiIdioma2.AutoEllipsis = True
        LabelMultiIdioma2.BackColor = Color.Khaki
        LabelMultiIdioma2.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma2.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma2.Location = New Point(8, 43)
        LabelMultiIdioma2.Name = "LabelMultiIdioma2"
        LabelMultiIdioma2.Size = New Size(172, 23)
        LabelMultiIdioma2.TabIndex = 9
        LabelMultiIdioma2.Text = "Estado"
        LabelMultiIdioma2.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma2.TextoCastellano = "Estado"
        LabelMultiIdioma2.TextoCatalan = "Estat"
        ' 
        ' tbxObservacions
        ' 
        tbxObservacions.Location = New Point(8, 96)
        tbxObservacions.Multiline = True
        tbxObservacions.Name = "tbxObservacions"
        tbxObservacions.Size = New Size(374, 211)
        tbxObservacions.TabIndex = 8
        ' 
        ' LabelMultiIdioma1
        ' 
        LabelMultiIdioma1.AutoEllipsis = True
        LabelMultiIdioma1.BackColor = Color.Khaki
        LabelMultiIdioma1.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma1.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma1.Location = New Point(8, 70)
        LabelMultiIdioma1.Name = "LabelMultiIdioma1"
        LabelMultiIdioma1.Size = New Size(374, 23)
        LabelMultiIdioma1.TabIndex = 7
        LabelMultiIdioma1.Text = "Observaciones"
        LabelMultiIdioma1.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma1.TextoCastellano = "Observaciones"
        LabelMultiIdioma1.TextoCatalan = "Observacions"
        ' 
        ' lblCodigoSeguimiento
        ' 
        lblCodigoSeguimiento.AutoEllipsis = True
        lblCodigoSeguimiento.BackColor = Color.Khaki
        lblCodigoSeguimiento.BorderStyle = BorderStyle.FixedSingle
        lblCodigoSeguimiento.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblCodigoSeguimiento.Location = New Point(8, 16)
        lblCodigoSeguimiento.Name = "lblCodigoSeguimiento"
        lblCodigoSeguimiento.Size = New Size(172, 23)
        lblCodigoSeguimiento.TabIndex = 6
        lblCodigoSeguimiento.Text = "Fecha Histórico"
        lblCodigoSeguimiento.TextAlign = ContentAlignment.MiddleCenter
        lblCodigoSeguimiento.TextoCastellano = "Fecha Histórico"
        lblCodigoSeguimiento.TextoCatalan = "Data Històric"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm"
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(185, 16)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(197, 23)
        DateTimePicker1.TabIndex = 0
        ' 
        ' TabControl1
        ' 
        TabControl1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(400, 350)
        TabControl1.TabIndex = 0
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnGuardar.AutoSize = True
        btnGuardar.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), Image)
        btnGuardar.ImageAlign = ContentAlignment.MiddleLeft
        btnGuardar.Location = New Point(275, 358)
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
        btnCancelar.Location = New Point(158, 358)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(116, 30)
        btnCancelar.TabIndex = 1
        btnCancelar.Text = "Cancelar"
        btnCancelar.TextoCastellano = "Cancelar"
        btnCancelar.TextoCatalan = "Cancel·lar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' frmEnvios_Historicos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(398, 396)
        Controls.Add(btnCancelar)
        Controls.Add(btnGuardar)
        Controls.Add(TabControl1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmEnvios_Historicos"
        Text = "frmEnvios_Historicos"
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabControl1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents btnGuardar As ButtonMultiIdioma
    Friend WithEvents btnCancelar As ButtonMultiIdioma
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents tbxObservacions As TextBox
    Friend WithEvents LabelMultiIdioma1 As LabelMultiIdioma
    Friend WithEvents lblCodigoSeguimiento As LabelMultiIdioma
    Friend WithEvents cmbxEstat As ComboBox
    Friend WithEvents LabelMultiIdioma2 As LabelMultiIdioma
End Class
