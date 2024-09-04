Imports System.Globalization
Imports System.Windows
Imports System.Xml
Imports Microsoft.Data.SqlClient

Public Class frmWaitForm

    Private Shared waitForm As frmWaitForm = Nothing

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualitzarIdiomaControls(Me, clsConstants.Idioma)
    End Sub

    Public Sub ActualitzarIdiomaControls(ByVal frm As Control, ByVal sIdioma As String)
        For Each ctrl As Control In frm.Controls
            If TypeOf ctrl Is LabelMultiIdioma Then
                DirectCast(ctrl, LabelMultiIdioma).CambiarIdioma(sIdioma)

            ElseIf TypeOf ctrl Is ButtonMultiIdioma Then
                DirectCast(ctrl, ButtonMultiIdioma).CambiarIdioma(sIdioma)


            ElseIf ctrl.HasChildren Then
                ActualitzarIdiomaControls(ctrl, sIdioma)
            End If
        Next


    End Sub


    Public Shared Sub ShowWaitForm(sTitol As String)

        waitForm = New frmWaitForm()
        If sTitol <> String.Empty Then
            waitForm.lblTitol.Text = sTitol
        End If
        waitForm.Show()

    End Sub


    Public Shared Sub CloseWaitForm()

        If waitForm IsNot Nothing Then
            waitForm.Close()
            waitForm.Dispose()
            waitForm = Nothing
        End If

    End Sub


End Class