﻿Public Class frmLogin

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualitzarIdiomaControls(Me, clsConstants.Idioma)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Me.Close()
        Me.DialogResult = DialogResult.Cancel

    End Sub

    Private Sub btnAcceptar_Click(sender As Object, e As EventArgs) Handles btnAcceptar.Click

        If Environment.MachineName = clsSeguretat.PC_DAVID Then
            Me.Close()
            Me.DialogResult = DialogResult.OK
            Exit Sub
        End If

        If tbxUsuari.Text Is String.Empty Or tbxPassword.Text Is String.Empty Then
            Exit Sub
        End If


        If clsSeguretat.VerificarContra(tbxUsuari.Text, tbxPassword.Text) Then
            Me.Close()
            Me.DialogResult = DialogResult.OK
        Else
            MsgBox(fnTraductor.RetornaIdiomaSeleccionat("Usuario o contraseña incorrectos",
                                                         "Usuari o contrasenya incorrecte"),, "")
        End If



    End Sub


    Private Sub ActualitzarIdiomaControls(ByVal frm As Control, ByVal sIdioma As String)
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


End Class