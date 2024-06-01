<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTicket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTicket))
        lblExplica = New LabelMultiIdioma()
        tbxExplicacio = New TextBox()
        btnEnviarTicket = New Button()
        SuspendLayout()
        ' 
        ' lblExplica
        ' 
        lblExplica.BackColor = Color.Khaki
        lblExplica.BorderStyle = BorderStyle.FixedSingle
        lblExplica.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblExplica.Location = New Point(12, 9)
        lblExplica.Name = "lblExplica"
        lblExplica.Size = New Size(204, 23)
        lblExplica.TabIndex = 0
        lblExplica.Text = "Explicanos que ha ocurrido"
        lblExplica.TextAlign = ContentAlignment.MiddleCenter
        lblExplica.TextoCastellano = "Explicanos que ha ocurrido"
        lblExplica.TextoCatalan = "Explicans que ha passat"
        ' 
        ' tbxExplicacio
        ' 
        tbxExplicacio.Location = New Point(12, 35)
        tbxExplicacio.Multiline = True
        tbxExplicacio.Name = "tbxExplicacio"
        tbxExplicacio.Size = New Size(626, 332)
        tbxExplicacio.TabIndex = 1
        ' 
        ' btnEnviarTicket
        ' 
        btnEnviarTicket.Location = New Point(520, 373)
        btnEnviarTicket.Name = "btnEnviarTicket"
        btnEnviarTicket.Size = New Size(118, 32)
        btnEnviarTicket.TabIndex = 2
        btnEnviarTicket.Text = "Enviar Ticket"
        btnEnviarTicket.UseVisualStyleBackColor = True
        ' 
        ' FormTicket
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(654, 417)
        Controls.Add(btnEnviarTicket)
        Controls.Add(tbxExplicacio)
        Controls.Add(lblExplica)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FormTicket"
        Text = "FormTicket"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblExplica As LabelMultiIdioma
    Friend WithEvents tbxExplicacio As TextBox
    Friend WithEvents btnEnviarTicket As Button
End Class
