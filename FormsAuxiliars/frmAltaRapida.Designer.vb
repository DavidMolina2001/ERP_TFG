﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAltaRapida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAltaRapida))
        TabPage1 = New TabPage()
        cbxRecuperarPlataforma = New CheckBox()
        btnTreureSeleccionat = New ButtonMultiIdioma()
        btnAfegir = New ButtonMultiIdioma()
        tbxEnvio = New TextBox()
        lblData = New LabelMultiIdioma()
        dg_Envios = New Syncfusion.WinForms.DataGrid.SfDataGrid()
        TabControl1 = New TabControl()
        btnGuardar = New ButtonMultiIdioma()
        btnCancelar = New ButtonMultiIdioma()
        TabPage1.SuspendLayout()
        CType(dg_Envios, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.Gainsboro
        TabPage1.Controls.Add(cbxRecuperarPlataforma)
        TabPage1.Controls.Add(btnTreureSeleccionat)
        TabPage1.Controls.Add(btnAfegir)
        TabPage1.Controls.Add(tbxEnvio)
        TabPage1.Controls.Add(lblData)
        TabPage1.Controls.Add(dg_Envios)
        TabPage1.Location = New Point(4, 27)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1551, 373)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Principal"
        ' 
        ' cbxRecuperarPlataforma
        ' 
        cbxRecuperarPlataforma.AutoSize = True
        cbxRecuperarPlataforma.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        cbxRecuperarPlataforma.Location = New Point(683, 4)
        cbxRecuperarPlataforma.Name = "cbxRecuperarPlataforma"
        cbxRecuperarPlataforma.Size = New Size(202, 24)
        cbxRecuperarPlataforma.TabIndex = 31
        cbxRecuperarPlataforma.Text = "Recuperar de Plataforma"
        cbxRecuperarPlataforma.UseVisualStyleBackColor = True
        cbxRecuperarPlataforma.Visible = False
        ' 
        ' btnTreureSeleccionat
        ' 
        btnTreureSeleccionat.AutoSize = True
        btnTreureSeleccionat.BackColor = Color.Red
        btnTreureSeleccionat.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btnTreureSeleccionat.ForeColor = SystemColors.ActiveCaptionText
        btnTreureSeleccionat.Location = New Point(525, 1)
        btnTreureSeleccionat.Name = "btnTreureSeleccionat"
        btnTreureSeleccionat.Size = New Size(152, 27)
        btnTreureSeleccionat.TabIndex = 30
        btnTreureSeleccionat.Text = "Quitar Seleccionado"
        btnTreureSeleccionat.TextoCastellano = "Quitar Seleccionado"
        btnTreureSeleccionat.TextoCatalan = "Treure Seleccionat"
        btnTreureSeleccionat.UseVisualStyleBackColor = False
        ' 
        ' btnAfegir
        ' 
        btnAfegir.AutoSize = True
        btnAfegir.BackColor = Color.GreenYellow
        btnAfegir.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btnAfegir.ForeColor = SystemColors.ActiveCaptionText
        btnAfegir.Location = New Point(373, 1)
        btnAfegir.Name = "btnAfegir"
        btnAfegir.Size = New Size(152, 27)
        btnAfegir.TabIndex = 0
        btnAfegir.Text = "Añadir"
        btnAfegir.TextoCastellano = "Añadir"
        btnAfegir.TextoCatalan = "Afegir"
        btnAfegir.UseVisualStyleBackColor = False
        ' 
        ' tbxEnvio
        ' 
        tbxEnvio.Location = New Point(173, 3)
        tbxEnvio.Name = "tbxEnvio"
        tbxEnvio.Size = New Size(200, 24)
        tbxEnvio.TabIndex = 29
        ' 
        ' lblData
        ' 
        lblData.AutoEllipsis = True
        lblData.BackColor = Color.Khaki
        lblData.BorderStyle = BorderStyle.FixedSingle
        lblData.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblData.Location = New Point(1, 2)
        lblData.Name = "lblData"
        lblData.Size = New Size(170, 23)
        lblData.TabIndex = 28
        lblData.Text = "Código Seguimiento"
        lblData.TextAlign = ContentAlignment.MiddleCenter
        lblData.TextoCastellano = "Código Seguimiento"
        lblData.TextoCatalan = "Codi Seguiment"
        ' 
        ' dg_Envios
        ' 
        dg_Envios.AccessibleName = "Table"
        dg_Envios.AllowDeleting = True
        dg_Envios.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dg_Envios.Location = New Point(0, 28)
        dg_Envios.Name = "dg_Envios"
        dg_Envios.Size = New Size(1551, 345)
        dg_Envios.Style.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        dg_Envios.Style.CheckBoxStyle.CheckedBackColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        dg_Envios.Style.CheckBoxStyle.CheckedBorderColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        dg_Envios.Style.CheckBoxStyle.IndeterminateBorderColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        dg_Envios.Style.HyperlinkStyle.DefaultLinkColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        dg_Envios.TabIndex = 0
        dg_Envios.Text = "SfDataGrid1"
        ' 
        ' TabControl1
        ' 
        TabControl1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1559, 404)
        TabControl1.TabIndex = 0
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnGuardar.AutoSize = True
        btnGuardar.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), Image)
        btnGuardar.ImageAlign = ContentAlignment.MiddleLeft
        btnGuardar.Location = New Point(1434, 412)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(111, 30)
        btnGuardar.TabIndex = 0
        btnGuardar.Text = "Alta"
        btnGuardar.TextoCastellano = "Alta"
        btnGuardar.TextoCatalan = "Alta"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnCancelar.AutoSize = True
        btnCancelar.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), Image)
        btnCancelar.ImageAlign = ContentAlignment.MiddleLeft
        btnCancelar.Location = New Point(1317, 412)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(116, 30)
        btnCancelar.TabIndex = 1
        btnCancelar.Text = "Cancelar"
        btnCancelar.TextoCastellano = "Cancelar"
        btnCancelar.TextoCatalan = "Cancel·lar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' frmAltaRapida
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1557, 450)
        Controls.Add(btnCancelar)
        Controls.Add(btnGuardar)
        Controls.Add(TabControl1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmAltaRapida"
        Text = "frmGeneric"
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(dg_Envios, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents btnGuardar As ButtonMultiIdioma
    Friend WithEvents btnCancelar As ButtonMultiIdioma
    Friend WithEvents dg_Envios As Syncfusion.WinForms.DataGrid.SfDataGrid
    Friend WithEvents tbxEnvio As TextBox
    Friend WithEvents lblData As LabelMultiIdioma
    Friend WithEvents btnTreureSeleccionat As ButtonMultiIdioma
    Friend WithEvents btnAfegir As ButtonMultiIdioma
    Friend WithEvents cbxRecuperarPlataforma As CheckBox
End Class
