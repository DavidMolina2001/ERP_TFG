﻿Public Class frmPreferencies
    Public oPreferencias As clsEmpresa

    Public Sub New(ByRef oPreferencias As clsEmpresa)
        InitializeComponent()

        Me.oPreferencias = oPreferencias
    End Sub

    Private Sub frmPreferencies_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ActualitzarIdiomaControls(Me, clsConstants.Idioma)


        Me.Text = fnTraductor.RetornaIdiomaSeleccionat("Preferencias", "Preferències")

        cmbxIdioma.Items.Add("Español")
        cmbxIdioma.Items.Add("Català")


        cmbxLDAP.Items.Add("Si")
        cmbxLDAP.Items.Add("No")

        If oPreferencias.LDAP Then
            cmbxLDAP.SelectedIndex = 0
        Else
            cmbxLDAP.SelectedIndex = 1

        End If


        If oPreferencias.CodiIdioma = "E" Then
            cmbxIdioma.SelectedIndex = 0
        Else
            cmbxIdioma.SelectedIndex = 1
        End If

        tbxRutaEtiquetas.Text = oPreferencias.PathEtiquetas

        tbxRutaFactCAT.Text = oPreferencias.PathFactura_CA
        tbxRutaFactCAS.Text = oPreferencias.PathFactura_ES

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

    Private Sub btnAcceptar_Click(sender As Object, e As EventArgs) Handles btnAcceptar.Click
        Try
            Dim cIdioma As Char = cmbxIdioma.SelectedItem.ToString(0) 'Primera letra del idioma E o C



            oPreferencias.CodiIdioma = cIdioma
            oPreferencias.LDAP = cmbxLDAP.SelectedIndex = 0

            oPreferencias.PathFactura_CA = tbxRutaFactCAT.Text
            oPreferencias.PathFactura_ES = tbxRutaFactCAS.Text

            oPreferencias.Escriure(False)
            Me.Close()
        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al guardar las preferencias",
                                                                      "Error al guardar les preferències"), ex)
        End Try


    End Sub

    Private Sub btnSelectPathEtiquetes_Click(sender As Object, e As EventArgs) Handles btnSelectPathEtiquetes.Click
        Dim folderBrowser As New FolderBrowserDialog

        folderBrowser.Description = fnTraductor.RetornaIdiomaSeleccionat("Selecciona una carpeta para guardar las etiquetas",
                                                                          "Selecciona una carpeta per guardar les etiquetes")
        folderBrowser.RootFolder = Environment.SpecialFolder.Desktop
        folderBrowser.ShowNewFolderButton = True

        If folderBrowser.ShowDialog = DialogResult.OK Then

            oPreferencias.PathEtiquetas = folderBrowser.SelectedPath

            frmMissatge.MostrarAvis(fnTraductor.RetornaIdiomaSeleccionat("Ruta guardada correctamente",
                                                                          "Ruta guardada correctament"))

            tbxRutaEtiquetas.Text = oPreferencias.PathEtiquetas


        End If
    End Sub

    Private Sub btnSelectPathFactCAT_Click(sender As Object, e As EventArgs) Handles btnSelectPathFactCAT.Click
        Dim openFileDialog As New OpenFileDialog

        openFileDialog.Title = fnTraductor.RetornaIdiomaSeleccionat("Selecciona la plantilla para facturas en Catalán",
                                                                     "Selecciona la plantilla per factures en Català")

        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        openFileDialog.Filter = "Archivos de Word (*.doc;*.docx)|*.doc;*.docx|Todos los archivos (*.*)|*.*"
        openFileDialog.FilterIndex = 1
        openFileDialog.RestoreDirectory = True

        If openFileDialog.ShowDialog = DialogResult.OK Then
            oPreferencias.PathEtiquetas = openFileDialog.FileName

            frmMissatge.MostrarAvis(fnTraductor.RetornaIdiomaSeleccionat("Ruta guardada correctamente",
                                                                          "Ruta guardada correctament"))

            tbxRutaEtiquetas.Text = oPreferencias.PathEtiquetas
        End If
    End Sub

    Private Sub btnSelectPathFactCAS_Click(sender As Object, e As EventArgs) Handles btnSelectPathFactCAS.Click
        Dim openFileDialog As New OpenFileDialog

        openFileDialog.Title = fnTraductor.RetornaIdiomaSeleccionat("Selecciona la plantilla para facturas en Castellano",
                                                                     "Selecciona la plantilla per factures en Castellà")
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        openFileDialog.Filter = "Archivos de Word (*.doc;*.docx)|*.doc;*.docx|Todos los archivos (*.*)|*.*"
        openFileDialog.FilterIndex = 1
        openFileDialog.RestoreDirectory = True

        If openFileDialog.ShowDialog = DialogResult.OK Then
            oPreferencias.PathEtiquetas = openFileDialog.FileName

            frmMissatge.MostrarAvis(fnTraductor.RetornaIdiomaSeleccionat("Ruta guardada correctamente",
                                                                          "Ruta guardada correctament"))

            tbxRutaEtiquetas.Text = oPreferencias.PathEtiquetas
        End If
    End Sub

End Class