﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFurgoneta_Ruta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFurgoneta_Ruta))
        TabPage1 = New TabPage()
        LabelMultiIdioma3 = New LabelMultiIdioma()
        LabelMultiIdioma2 = New LabelMultiIdioma()
        LabelMultiIdioma8 = New LabelMultiIdioma()
        cmbxRutas = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
        cmbxFurgonetas = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
        cmbxTrabajadores = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
        TabControl1 = New TabControl()
        btnGuardar = New ButtonMultiIdioma()
        btnCancelar = New ButtonMultiIdioma()
        lblData = New LabelMultiIdioma()
        dtpFecha = New DateTimePicker()
        TabPage1.SuspendLayout()
        CType(cmbxRutas, ComponentModel.ISupportInitialize).BeginInit()
        CType(cmbxFurgonetas, ComponentModel.ISupportInitialize).BeginInit()
        CType(cmbxTrabajadores, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.Gainsboro
        TabPage1.Controls.Add(LabelMultiIdioma3)
        TabPage1.Controls.Add(LabelMultiIdioma2)
        TabPage1.Controls.Add(LabelMultiIdioma8)
        TabPage1.Controls.Add(cmbxRutas)
        TabPage1.Controls.Add(cmbxFurgonetas)
        TabPage1.Controls.Add(cmbxTrabajadores)
        TabPage1.Location = New Point(4, 27)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(534, 56)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Principal"
        ' 
        ' LabelMultiIdioma3
        ' 
        LabelMultiIdioma3.AutoEllipsis = True
        LabelMultiIdioma3.BackColor = Color.Khaki
        LabelMultiIdioma3.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma3.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma3.Location = New Point(359, 3)
        LabelMultiIdioma3.Name = "LabelMultiIdioma3"
        LabelMultiIdioma3.Size = New Size(172, 23)
        LabelMultiIdioma3.TabIndex = 28
        LabelMultiIdioma3.Text = "Ruta"
        LabelMultiIdioma3.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma3.TextoCastellano = "Ruta"
        LabelMultiIdioma3.TextoCatalan = "Ruta"
        ' 
        ' LabelMultiIdioma2
        ' 
        LabelMultiIdioma2.AutoEllipsis = True
        LabelMultiIdioma2.BackColor = Color.Khaki
        LabelMultiIdioma2.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma2.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma2.Location = New Point(181, 3)
        LabelMultiIdioma2.Name = "LabelMultiIdioma2"
        LabelMultiIdioma2.Size = New Size(172, 23)
        LabelMultiIdioma2.TabIndex = 27
        LabelMultiIdioma2.Text = "Furgoneta"
        LabelMultiIdioma2.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma2.TextoCastellano = "Furgoneta"
        LabelMultiIdioma2.TextoCatalan = "Furgoneta"
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
        LabelMultiIdioma8.TabIndex = 26
        LabelMultiIdioma8.Text = "Trabajador"
        LabelMultiIdioma8.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma8.TextoCastellano = "Trabajador"
        LabelMultiIdioma8.TextoCatalan = "Treballador"
        ' 
        ' cmbxRutas
        ' 
        cmbxRutas.AllowNewText = False
        cmbxRutas.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        cmbxRutas.BeforeTouchSize = New Size(172, 24)
        cmbxRutas.Border3DStyle = Border3DStyle.SunkenInner
        cmbxRutas.DropDownWidth = 200
        cmbxRutas.ForeColor = Color.FromArgb(CByte(68), CByte(68), CByte(68))
        cmbxRutas.Location = New Point(359, 29)
        cmbxRutas.MaxDropDownItems = 20
        cmbxRutas.Name = "cmbxRutas"
        cmbxRutas.Size = New Size(172, 24)
        cmbxRutas.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016White
        cmbxRutas.TabIndex = 2
        cmbxRutas.ThemeName = "Office2016White"
        ' 
        ' cmbxFurgonetas
        ' 
        cmbxFurgonetas.AllowNewText = False
        cmbxFurgonetas.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        cmbxFurgonetas.BeforeTouchSize = New Size(172, 24)
        cmbxFurgonetas.Border3DStyle = Border3DStyle.SunkenInner
        cmbxFurgonetas.DropDownWidth = 200
        cmbxFurgonetas.ForeColor = Color.FromArgb(CByte(68), CByte(68), CByte(68))
        cmbxFurgonetas.Location = New Point(181, 29)
        cmbxFurgonetas.MaxDropDownItems = 20
        cmbxFurgonetas.Name = "cmbxFurgonetas"
        cmbxFurgonetas.Size = New Size(172, 24)
        cmbxFurgonetas.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016White
        cmbxFurgonetas.TabIndex = 1
        cmbxFurgonetas.ThemeName = "Office2016White"
        ' 
        ' cmbxTrabajadores
        ' 
        cmbxTrabajadores.AllowNewText = False
        cmbxTrabajadores.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        cmbxTrabajadores.BeforeTouchSize = New Size(172, 24)
        cmbxTrabajadores.Border3DStyle = Border3DStyle.SunkenInner
        cmbxTrabajadores.DropDownWidth = 200
        cmbxTrabajadores.ForeColor = Color.FromArgb(CByte(68), CByte(68), CByte(68))
        cmbxTrabajadores.Location = New Point(3, 29)
        cmbxTrabajadores.MaxDropDownItems = 20
        cmbxTrabajadores.Name = "cmbxTrabajadores"
        cmbxTrabajadores.Size = New Size(172, 24)
        cmbxTrabajadores.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016White
        cmbxTrabajadores.TabIndex = 0
        cmbxTrabajadores.ThemeName = "Office2016White"
        ' 
        ' TabControl1
        ' 
        TabControl1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(542, 87)
        TabControl1.TabIndex = 0
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnGuardar.AutoSize = True
        btnGuardar.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), Image)
        btnGuardar.ImageAlign = ContentAlignment.MiddleLeft
        btnGuardar.Location = New Point(422, 95)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(111, 31)
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
        btnCancelar.Location = New Point(305, 95)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(116, 31)
        btnCancelar.TabIndex = 1
        btnCancelar.Text = "Cancelar"
        btnCancelar.TextoCastellano = "Cancelar"
        btnCancelar.TextoCatalan = "Cancel·lar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' lblData
        ' 
        lblData.AutoEllipsis = True
        lblData.BackColor = Color.Khaki
        lblData.BorderStyle = BorderStyle.FixedSingle
        lblData.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblData.Location = New Point(4, 92)
        lblData.Name = "lblData"
        lblData.Size = New Size(103, 23)
        lblData.TabIndex = 27
        lblData.Text = "Fecha"
        lblData.TextAlign = ContentAlignment.MiddleCenter
        lblData.TextoCastellano = "Fecha"
        lblData.TextoCatalan = "Data"
        ' 
        ' dtpFecha
        ' 
        dtpFecha.Enabled = False
        dtpFecha.Format = DateTimePickerFormat.Short
        dtpFecha.Location = New Point(109, 92)
        dtpFecha.Name = "dtpFecha"
        dtpFecha.Size = New Size(99, 23)
        dtpFecha.TabIndex = 28
        ' 
        ' frmFurgoneta_Ruta
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(540, 133)
        Controls.Add(dtpFecha)
        Controls.Add(lblData)
        Controls.Add(btnCancelar)
        Controls.Add(btnGuardar)
        Controls.Add(TabControl1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "frmFurgoneta_Ruta"
        Text = "frmGeneric"
        TabPage1.ResumeLayout(False)
        CType(cmbxRutas, ComponentModel.ISupportInitialize).EndInit()
        CType(cmbxFurgonetas, ComponentModel.ISupportInitialize).EndInit()
        CType(cmbxTrabajadores, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents btnGuardar As ButtonMultiIdioma
    Friend WithEvents btnCancelar As ButtonMultiIdioma
    Friend WithEvents cmbxTrabajadores As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
    Friend WithEvents cmbxFurgonetas As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
    Friend WithEvents cmbxRutas As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
    Friend WithEvents LabelMultiIdioma3 As LabelMultiIdioma
    Friend WithEvents LabelMultiIdioma2 As LabelMultiIdioma
    Friend WithEvents LabelMultiIdioma8 As LabelMultiIdioma
    Friend WithEvents lblData As LabelMultiIdioma
    Friend WithEvents dtpFecha As DateTimePicker
End Class
