<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFactura_Linia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFactura_Linia))
        TabPage1 = New TabPage()
        cmbxIVA = New ComboBox()
        LabelMultiIdioma3 = New LabelMultiIdioma()
        tbxCodigoSeguimiento = New TextBox()
        tbiEnvio = New Lupa()
        LabelMultiIdioma2 = New LabelMultiIdioma()
        tbxObservacions = New TextBox()
        LabelMultiIdioma1 = New LabelMultiIdioma()
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
        TabPage1.Controls.Add(cmbxIVA)
        TabPage1.Controls.Add(LabelMultiIdioma3)
        TabPage1.Controls.Add(tbxCodigoSeguimiento)
        TabPage1.Controls.Add(tbiEnvio)
        TabPage1.Controls.Add(LabelMultiIdioma2)
        TabPage1.Controls.Add(tbxObservacions)
        TabPage1.Controls.Add(LabelMultiIdioma1)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(538, 322)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Principal"
        ' 
        ' cmbxIVA
        ' 
        cmbxIVA.DropDownStyle = ComboBoxStyle.DropDownList
        cmbxIVA.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        cmbxIVA.FormattingEnabled = True
        cmbxIVA.ItemHeight = 15
        cmbxIVA.Location = New Point(182, 33)
        cmbxIVA.Name = "cmbxIVA"
        cmbxIVA.Size = New Size(131, 23)
        cmbxIVA.TabIndex = 25
        ' 
        ' LabelMultiIdioma3
        ' 
        LabelMultiIdioma3.AutoEllipsis = True
        LabelMultiIdioma3.BackColor = Color.Khaki
        LabelMultiIdioma3.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma3.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma3.Location = New Point(8, 32)
        LabelMultiIdioma3.Name = "LabelMultiIdioma3"
        LabelMultiIdioma3.Size = New Size(172, 23)
        LabelMultiIdioma3.TabIndex = 24
        LabelMultiIdioma3.Text = "IVA"
        LabelMultiIdioma3.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma3.TextoCastellano = "IVA"
        LabelMultiIdioma3.TextoCatalan = "IVA"
        ' 
        ' tbxCodigoSeguimiento
        ' 
        tbxCodigoSeguimiento.BackColor = SystemColors.GradientActiveCaption
        tbxCodigoSeguimiento.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        tbxCodigoSeguimiento.Location = New Point(312, 5)
        tbxCodigoSeguimiento.MaxLength = 12
        tbxCodigoSeguimiento.Name = "tbxCodigoSeguimiento"
        tbxCodigoSeguimiento.ReadOnly = True
        tbxCodigoSeguimiento.Size = New Size(216, 23)
        tbxCodigoSeguimiento.TabIndex = 23
        ' 
        ' tbiEnvio
        ' 
        tbiEnvio._Valor = ""
        tbiEnvio.AutoSize = True
        tbiEnvio.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tbiEnvio.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        tbiEnvio.Location = New Point(182, 3)
        tbiEnvio.Margin = New Padding(4, 3, 4, 3)
        tbiEnvio.Name = "tbiEnvio"
        tbiEnvio.Size = New Size(131, 30)
        tbiEnvio.TabIndex = 22
        tbiEnvio.uCampBD1 = "CodigoSeguimiento"
        tbiEnvio.uCampBD2 = ""
        tbiEnvio.uCampBD3 = ""
        tbiEnvio.uCampBD4 = ""
        tbiEnvio.uCampBD5 = Nothing
        tbiEnvio.uCampBD6 = Nothing
        tbiEnvio.uObjRecord = Nothing
        tbiEnvio.utbxCamp1 = tbxCodigoSeguimiento
        tbiEnvio.utbxCamp2 = Nothing
        tbiEnvio.utbxCamp3 = Nothing
        tbiEnvio.utbxCamp4 = Nothing
        tbiEnvio.utbxCamp5 = Nothing
        tbiEnvio.utbxCamp6 = Nothing
        ' 
        ' LabelMultiIdioma2
        ' 
        LabelMultiIdioma2.AutoEllipsis = True
        LabelMultiIdioma2.BackColor = Color.Khaki
        LabelMultiIdioma2.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma2.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma2.Location = New Point(8, 5)
        LabelMultiIdioma2.Name = "LabelMultiIdioma2"
        LabelMultiIdioma2.Size = New Size(172, 23)
        LabelMultiIdioma2.TabIndex = 9
        LabelMultiIdioma2.Text = "Envío"
        LabelMultiIdioma2.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma2.TextoCastellano = "Envío"
        LabelMultiIdioma2.TextoCatalan = "Enviament"
        ' 
        ' tbxObservacions
        ' 
        tbxObservacions.Location = New Point(8, 85)
        tbxObservacions.Multiline = True
        tbxObservacions.Name = "tbxObservacions"
        tbxObservacions.Size = New Size(520, 234)
        tbxObservacions.TabIndex = 8
        ' 
        ' LabelMultiIdioma1
        ' 
        LabelMultiIdioma1.AutoEllipsis = True
        LabelMultiIdioma1.BackColor = Color.Khaki
        LabelMultiIdioma1.BorderStyle = BorderStyle.FixedSingle
        LabelMultiIdioma1.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMultiIdioma1.Location = New Point(8, 59)
        LabelMultiIdioma1.Name = "LabelMultiIdioma1"
        LabelMultiIdioma1.Size = New Size(305, 23)
        LabelMultiIdioma1.TabIndex = 7
        LabelMultiIdioma1.Text = "Descripción"
        LabelMultiIdioma1.TextAlign = ContentAlignment.MiddleCenter
        LabelMultiIdioma1.TextoCastellano = "Descripción"
        LabelMultiIdioma1.TextoCatalan = "Descripció"
        ' 
        ' TabControl1
        ' 
        TabControl1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(546, 350)
        TabControl1.TabIndex = 0
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnGuardar.AutoSize = True
        btnGuardar.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), Image)
        btnGuardar.ImageAlign = ContentAlignment.MiddleLeft
        btnGuardar.Location = New Point(421, 358)
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
        btnCancelar.Location = New Point(304, 358)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(116, 30)
        btnCancelar.TabIndex = 1
        btnCancelar.Text = "Cancelar"
        btnCancelar.TextoCastellano = "Cancelar"
        btnCancelar.TextoCatalan = "Cancel·lar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' frmFactura_Linia
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(544, 396)
        Controls.Add(btnCancelar)
        Controls.Add(btnGuardar)
        Controls.Add(TabControl1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmFactura_Linia"
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
    Friend WithEvents tbxObservacions As TextBox
    Friend WithEvents LabelMultiIdioma1 As LabelMultiIdioma
    Friend WithEvents LabelMultiIdioma2 As LabelMultiIdioma
    Friend WithEvents tbiEnvio As Lupa
    Friend WithEvents tbxCodigoSeguimiento As TextBox
    Friend WithEvents LabelMultiIdioma3 As LabelMultiIdioma
    Friend WithEvents cmbxIVA As ComboBox
End Class
