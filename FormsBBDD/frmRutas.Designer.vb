﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRutas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRutas))
        TabPage1 = New TabPage()
        dgPoblaciones = New Syncfusion.WinForms.DataGrid.SfDataGrid()
        tbxNomRuta = New TextBox()
        LabelMultiIdioma1 = New LabelMultiIdioma()
        lblCodigoSeguimiento = New LabelMultiIdioma()
        TabControl1 = New TabControl()
        btnGuardar = New ButtonMultiIdioma()
        btnCancelar = New ButtonMultiIdioma()
        btnBorrar = New ButtonMultiIdioma()
        TabPage1.SuspendLayout()
        CType(dgPoblaciones, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.Gainsboro
        TabPage1.Controls.Add(dgPoblaciones)
        TabPage1.Controls.Add(tbxNomRuta)
        TabPage1.Controls.Add(LabelMultiIdioma1)
        TabPage1.Controls.Add(lblCodigoSeguimiento)
        TabPage1.Location = New Point(4, 27)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(392, 319)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Principal"
        ' 
        ' dgPoblaciones
        ' 
        dgPoblaciones.AccessibleName = "Table"
        dgPoblaciones.AddNewRowPosition = Syncfusion.WinForms.DataGrid.Enums.RowPosition.FixedBottom
        dgPoblaciones.AllowDeleting = True
        dgPoblaciones.AllowGrouping = False
        dgPoblaciones.Location = New Point(6, 60)
        dgPoblaciones.Name = "dgPoblaciones"
        dgPoblaciones.Size = New Size(374, 256)
        dgPoblaciones.Style.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        dgPoblaciones.Style.CheckBoxStyle.CheckedBackColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        dgPoblaciones.Style.CheckBoxStyle.CheckedBorderColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        dgPoblaciones.Style.CheckBoxStyle.IndeterminateBorderColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        dgPoblaciones.Style.HyperlinkStyle.DefaultLinkColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        dgPoblaciones.TabIndex = 10
        dgPoblaciones.Text = "SfDataGrid1"
        ' 
        ' tbxNomRuta
        ' 
        tbxNomRuta.Location = New Point(181, 8)
        tbxNomRuta.Name = "tbxNomRuta"
        tbxNomRuta.Size = New Size(201, 24)
        tbxNomRuta.TabIndex = 9
        ' 
        ' LabelMultiIdioma1
        ' 
        LabelMultiIdioma1.AutoEllipsis = True
        LabelMultiIdioma1.BackColor = Color.Khaki
        LabelMultiIdioma1.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma1.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma1.Location = New Point(6, 34)
        LabelMultiIdioma1.Name = "LabelMultiIdioma1"
        LabelMultiIdioma1.Size = New Size(374, 23)
        LabelMultiIdioma1.TabIndex = 7
        LabelMultiIdioma1.Text = "Rutas"
        LabelMultiIdioma1.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma1.TextoCastellano = "Rutas"
        LabelMultiIdioma1.TextoCatalan = "Rutes"
        ' 
        ' lblCodigoSeguimiento
        ' 
        lblCodigoSeguimiento.AutoEllipsis = True
        lblCodigoSeguimiento.BackColor = Color.Khaki
        lblCodigoSeguimiento.BorderStyle = BorderStyle.FixedSingle
        lblCodigoSeguimiento.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblCodigoSeguimiento.Location = New Point(6, 8)
        lblCodigoSeguimiento.Name = "lblCodigoSeguimiento"
        lblCodigoSeguimiento.Size = New Size(172, 23)
        lblCodigoSeguimiento.TabIndex = 6
        lblCodigoSeguimiento.Text = "Nombre Ruta"
        lblCodigoSeguimiento.TextAlign = ContentAlignment.MiddleCenter
        lblCodigoSeguimiento.TextoCastellano = "Nombre Ruta"
        lblCodigoSeguimiento.TextoCatalan = "Nom Ruta"
        ' 
        ' TabControl1
        ' 
        TabControl1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
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
        ' btnBorrar
        ' 
        btnBorrar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnBorrar.AutoSize = True
        btnBorrar.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), Image)
        btnBorrar.ImageAlign = ContentAlignment.MiddleLeft
        btnBorrar.Location = New Point(10, 358)
        btnBorrar.Name = "btnBorrar"
        btnBorrar.Size = New Size(116, 30)
        btnBorrar.TabIndex = 3
        btnBorrar.Text = "Borrar"
        btnBorrar.TextoCastellano = "Borrar"
        btnBorrar.TextoCatalan = "Esborrar"
        btnBorrar.UseVisualStyleBackColor = True
        ' 
        ' frmRutas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(398, 396)
        Controls.Add(btnBorrar)
        Controls.Add(btnCancelar)
        Controls.Add(btnGuardar)
        Controls.Add(TabControl1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmRutas"
        Text = "Rutas"
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(dgPoblaciones, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents btnGuardar As ButtonMultiIdioma
    Friend WithEvents btnCancelar As ButtonMultiIdioma
    Friend WithEvents LabelMultiIdioma1 As LabelMultiIdioma
    Friend WithEvents lblCodigoSeguimiento As LabelMultiIdioma
    Friend WithEvents tbxNomRuta As TextBox
    Friend WithEvents dgPoblaciones As Syncfusion.WinForms.DataGrid.SfDataGrid
    Friend WithEvents btnBorrar As ButtonMultiIdioma
End Class
