<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class LabelMultiIdioma
    Inherits System.Windows.Forms.Label

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
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Me.Font = New Font("Segoe UI", 11.0F, FontStyle.Regular, GraphicsUnit.Point)
        Me.Location = New Point(0, 0)
        Me.Name = "Label1"
        Me.Text = CambiarIdioma(clsConstants.Idioma)
        '
        'Label1.Text = CambiarIdioma(clsConstants.sIdioma)
        ' 
        ' LabelMultiIdioma
        ' 
        Name = "LabelMultiIdioma"
        ResumeLayout(False)
        PerformLayout()
    End Sub

End Class
