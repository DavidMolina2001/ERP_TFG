<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLlistat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLlistat))
        tbxCerca = New TextBox()
        dgListado = New Syncfusion.WinForms.DataGrid.SfDataGrid()
        btnCancelar = New ButtonMultiIdioma()
        btnEditar = New ButtonMultiIdioma()
        btnExportarExcel = New ButtonMultiIdioma()
        btnAcceptar = New ButtonMultiIdioma()
        btnNou = New ButtonMultiIdioma()
        btnActualizar = New ButtonMultiIdioma()
        CType(dgListado, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tbxCerca
        ' 
        tbxCerca.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tbxCerca.Font = New Font("Segoe UI Light", 12F, FontStyle.Italic, GraphicsUnit.Point)
        tbxCerca.Location = New Point(12, 413)
        tbxCerca.Name = "tbxCerca"
        tbxCerca.Size = New Size(489, 29)
        tbxCerca.TabIndex = 2
        ' 
        ' dgListado
        ' 
        dgListado.AccessibleName = "Table"
        dgListado.AllowEditing = False
        dgListado.AllowFiltering = True
        dgListado.AllowResizingColumns = True
        dgListado.AllowSelectionOnMouseDown = True
        dgListado.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgListado.EditMode = Syncfusion.WinForms.DataGrid.Enums.EditMode.SingleClick
        dgListado.Location = New Point(0, 0)
        dgListado.Name = "dgListado"
        dgListado.ShowGroupDropArea = True
        dgListado.Size = New Size(1109, 407)
        dgListado.Style.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        dgListado.Style.CheckBoxStyle.CheckedBackColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        dgListado.Style.CheckBoxStyle.CheckedBorderColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        dgListado.Style.CheckBoxStyle.IndeterminateBorderColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        dgListado.Style.HeaderStyle.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        dgListado.Style.HeaderStyle.Font.Bold = True
        dgListado.Style.HyperlinkStyle.DefaultLinkColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        dgListado.TabIndex = 9
        dgListado.Text = "SfDataGrid1"
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnCancelar.AutoSize = True
        btnCancelar.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), Image)
        btnCancelar.ImageAlign = ContentAlignment.MiddleLeft
        btnCancelar.Location = New Point(986, 413)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(116, 30)
        btnCancelar.TabIndex = 11
        btnCancelar.Text = "Cancelar"
        btnCancelar.TextoCastellano = "Cancelar"
        btnCancelar.TextoCatalan = "Cancel·lar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnEditar.AutoSize = True
        btnEditar.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), Image)
        btnEditar.ImageAlign = ContentAlignment.MiddleLeft
        btnEditar.Location = New Point(869, 413)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(116, 30)
        btnEditar.TabIndex = 12
        btnEditar.Text = "Editar"
        btnEditar.TextoCastellano = "Editar"
        btnEditar.TextoCatalan = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnExportarExcel
        ' 
        btnExportarExcel.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnExportarExcel.AutoSize = True
        btnExportarExcel.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnExportarExcel.Image = CType(resources.GetObject("btnExportarExcel.Image"), Image)
        btnExportarExcel.ImageAlign = ContentAlignment.MiddleLeft
        btnExportarExcel.Location = New Point(735, 413)
        btnExportarExcel.Name = "btnExportarExcel"
        btnExportarExcel.Size = New Size(131, 30)
        btnExportarExcel.TabIndex = 14
        btnExportarExcel.Text = "Exportar Excel"
        btnExportarExcel.TextAlign = ContentAlignment.MiddleRight
        btnExportarExcel.TextoCastellano = "Exportar Excel"
        btnExportarExcel.TextoCatalan = "Exportar Excel"
        btnExportarExcel.UseVisualStyleBackColor = True
        ' 
        ' btnAcceptar
        ' 
        btnAcceptar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnAcceptar.AutoSize = True
        btnAcceptar.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnAcceptar.Image = CType(resources.GetObject("btnAcceptar.Image"), Image)
        btnAcceptar.ImageAlign = ContentAlignment.MiddleLeft
        btnAcceptar.Location = New Point(868, 413)
        btnAcceptar.Name = "btnAcceptar"
        btnAcceptar.Size = New Size(116, 30)
        btnAcceptar.TabIndex = 13
        btnAcceptar.Text = "Aceptar"
        btnAcceptar.TextoCastellano = "Aceptar"
        btnAcceptar.TextoCatalan = "Acceptar"
        btnAcceptar.UseVisualStyleBackColor = True
        ' 
        ' btnNou
        ' 
        btnNou.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnNou.AutoSize = True
        btnNou.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnNou.Image = CType(resources.GetObject("btnNou.Image"), Image)
        btnNou.ImageAlign = ContentAlignment.MiddleLeft
        btnNou.Location = New Point(507, 413)
        btnNou.Name = "btnNou"
        btnNou.Size = New Size(116, 30)
        btnNou.TabIndex = 16
        btnNou.Text = "Nuevo"
        btnNou.TextoCastellano = "Nuevo"
        btnNou.TextoCatalan = "Nou"
        btnNou.UseVisualStyleBackColor = True
        ' 
        ' btnActualizar
        ' 
        btnActualizar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnActualizar.AutoSize = True
        btnActualizar.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnActualizar.Image = CType(resources.GetObject("btnActualizar.Image"), Image)
        btnActualizar.ImageAlign = ContentAlignment.MiddleLeft
        btnActualizar.Location = New Point(625, 413)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(108, 30)
        btnActualizar.TabIndex = 15
        btnActualizar.Text = "Actualizar"
        btnActualizar.TextAlign = ContentAlignment.MiddleRight
        btnActualizar.TextoCastellano = "Actualizar"
        btnActualizar.TextoCatalan = "Actualitzar"
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' frmLlistat
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1109, 450)
        Controls.Add(btnNou)
        Controls.Add(btnActualizar)
        Controls.Add(btnExportarExcel)
        Controls.Add(btnAcceptar)
        Controls.Add(btnEditar)
        Controls.Add(btnCancelar)
        Controls.Add(dgListado)
        Controls.Add(tbxCerca)
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmLlistat"
        Text = "frmLlistat"
        CType(dgListado, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents tbxCerca As TextBox
    Friend WithEvents btnCancelar As ButtonMultiIdioma
    Friend WithEvents dgListado As Syncfusion.WinForms.DataGrid.SfDataGrid
    Friend WithEvents btnEditar As ButtonMultiIdioma
    Friend WithEvents btnExportarExcel As ButtonMultiIdioma
    Friend WithEvents btnAcceptar As ButtonMultiIdioma
    Friend WithEvents btnNou As ButtonMultiIdioma
    Friend WithEvents btnActualizar As ButtonMultiIdioma
End Class
