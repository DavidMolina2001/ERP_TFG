<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMissatge
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMissatge))
        lblError = New Label()
        tbxDescripcio = New TextBox()
        btnAcceptar = New Button()
        btnEnviarTicket = New Button()
        SuspendLayout()
        ' 
        ' lblError
        ' 
        lblError.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblError.Location = New Point(12, 9)
        lblError.Name = "lblError"
        lblError.Size = New Size(404, 65)
        lblError.TabIndex = 0
        lblError.Text = "Label1"
        ' 
        ' tbxDescripcio
        ' 
        tbxDescripcio.BackColor = SystemColors.ControlDark
        tbxDescripcio.Location = New Point(12, 77)
        tbxDescripcio.Multiline = True
        tbxDescripcio.Name = "tbxDescripcio"
        tbxDescripcio.ReadOnly = True
        tbxDescripcio.Size = New Size(404, 220)
        tbxDescripcio.TabIndex = 1
        ' 
        ' btnAcceptar
        ' 
        btnAcceptar.Location = New Point(268, 316)
        btnAcceptar.Name = "btnAcceptar"
        btnAcceptar.Size = New Size(148, 23)
        btnAcceptar.TabIndex = 2
        btnAcceptar.Text = "Acceptar"
        btnAcceptar.UseVisualStyleBackColor = True
        ' 
        ' btnEnviarTicket
        ' 
        btnEnviarTicket.Location = New Point(12, 316)
        btnEnviarTicket.Name = "btnEnviarTicket"
        btnEnviarTicket.Size = New Size(148, 23)
        btnEnviarTicket.TabIndex = 3
        btnEnviarTicket.Text = "Enviar Tiquet"
        btnEnviarTicket.UseVisualStyleBackColor = True
        ' 
        ' frmMissatge
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(428, 351)
        Controls.Add(btnEnviarTicket)
        Controls.Add(btnAcceptar)
        Controls.Add(tbxDescripcio)
        Controls.Add(lblError)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmMissatge"
        Text = "frmMissatge"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblError As Label
    Friend WithEvents tbxDescripcio As TextBox
    Friend WithEvents btnAcceptar As Button
    Friend WithEvents btnEnviarTicket As Button
End Class
