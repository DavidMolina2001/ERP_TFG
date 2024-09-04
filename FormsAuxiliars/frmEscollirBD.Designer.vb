<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEscollirBD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEscollirBD))
        btnGuardar = New ButtonMultiIdioma()
        btnCancelar = New ButtonMultiIdioma()
        cmbxBD = New ComboBox()
        lblData = New LabelMultiIdioma()
        SuspendLayout()
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnGuardar.AutoSize = True
        btnGuardar.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), Image)
        btnGuardar.ImageAlign = ContentAlignment.MiddleLeft
        btnGuardar.Location = New Point(270, 71)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(116, 30)
        btnGuardar.TabIndex = 0
        btnGuardar.Text = "Aceptar"
        btnGuardar.TextoCastellano = "Aceptar"
        btnGuardar.TextoCatalan = "Acceptar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnCancelar.AutoSize = True
        btnCancelar.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), Image)
        btnCancelar.ImageAlign = ContentAlignment.MiddleLeft
        btnCancelar.Location = New Point(154, 71)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(116, 30)
        btnCancelar.TabIndex = 1
        btnCancelar.Text = "Cancelar"
        btnCancelar.TextoCastellano = "Cancelar"
        btnCancelar.TextoCatalan = "Cancel·lar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' cmbxBD
        ' 
        cmbxBD.DropDownStyle = ComboBoxStyle.DropDownList
        cmbxBD.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point)
        cmbxBD.FormattingEnabled = True
        cmbxBD.Location = New Point(12, 36)
        cmbxBD.Name = "cmbxBD"
        cmbxBD.Size = New Size(374, 29)
        cmbxBD.TabIndex = 3
        ' 
        ' lblData
        ' 
        lblData.AutoEllipsis = True
        lblData.BackColor = Color.Khaki
        lblData.BorderStyle = BorderStyle.FixedSingle
        lblData.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblData.Location = New Point(12, 9)
        lblData.Name = "lblData"
        lblData.Size = New Size(374, 23)
        lblData.TabIndex = 28
        lblData.Text = "Escoje la Base de Datos"
        lblData.TextAlign = ContentAlignment.MiddleCenter
        lblData.TextoCastellano = "Escoje la Base de Datos"
        lblData.TextoCatalan = "Escull la Base de Dades"
        ' 
        ' frmEscollirBD
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(398, 109)
        Controls.Add(lblData)
        Controls.Add(cmbxBD)
        Controls.Add(btnCancelar)
        Controls.Add(btnGuardar)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmEscollirBD"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BBDD"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnGuardar As ButtonMultiIdioma
    Friend WithEvents btnCancelar As ButtonMultiIdioma
    Friend WithEvents cmbxBD As ComboBox
    Friend WithEvents lblData As LabelMultiIdioma
End Class
