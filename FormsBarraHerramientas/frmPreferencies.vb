Public Class frmPreferencies
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

        tbxRutaExcelEnvCAT.Text = oPreferencias.PathExcelEnvios_CA
        tbxRutaExcelEnvCAS.Text = oPreferencias.PathExcelEnvios_ES

        tbxRutaExcelFactCAT.Text = oPreferencias.PathExcelFacturas_CA
        tbxRutaExcelFactCAS.Text = oPreferencias.PathExcelFacturas_ES

        tbxPathGuardadoFacturas.Text = oPreferencias.PathGuardadoFacturas
        tbxPathGuardadoInformes.Text = oPreferencias.PathGuardadoInformes


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

            oPreferencias.PathExcelEnvios_CA = tbxRutaExcelEnvCAT.Text
            oPreferencias.PathExcelEnvios_ES = tbxRutaExcelEnvCAS.Text

            oPreferencias.PathExcelFacturas_CA = tbxRutaExcelFactCAT.Text
            oPreferencias.PathExcelFacturas_ES = tbxRutaExcelFactCAS.Text

            oPreferencias.PathGuardadoFacturas = tbxPathGuardadoFacturas.Text
            oPreferencias.PathGuardadoInformes = tbxPathGuardadoInformes.Text

            oPreferencias.Escriure(False)
            Me.Close()
        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al guardar las preferencias",
                                                                      "Error al guardar les preferències"), ex)
        End Try


    End Sub

    Private Sub btnSelectPathEtiquetes_Click(sender As Object, e As EventArgs)
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
            oPreferencias.PathFactura_CA = openFileDialog.FileName

            frmMissatge.MostrarAvis(fnTraductor.RetornaIdiomaSeleccionat("Ruta guardada correctamente",
                                                                          "Ruta guardada correctament"))

            tbxRutaFactCAT.Text = oPreferencias.PathFactura_CA
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
            oPreferencias.PathFactura_ES = openFileDialog.FileName

            frmMissatge.MostrarAvis(fnTraductor.RetornaIdiomaSeleccionat("Ruta guardada correctamente",
                                                                          "Ruta guardada correctament"))

            tbxRutaFactCAS.Text = oPreferencias.PathFactura_ES
        End If
    End Sub

    Private Sub btnSelectPathExcelEnvCAT_Click(sender As Object, e As EventArgs) Handles btnSelectPathExcelEnvCAT.Click
        Dim openFileDialog As New OpenFileDialog

        openFileDialog.Title = fnTraductor.RetornaIdiomaSeleccionat("Selecciona la plantilla para Informe Excel Envíos en Catalán",
                                                                     "Selecciona la plantilla per Informe Excel Enviaments en Català")
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        openFileDialog.Filter = "Archivos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx|Todos los archivos (*.*)|*.*"
        openFileDialog.FilterIndex = 1
        openFileDialog.RestoreDirectory = True

        If openFileDialog.ShowDialog = DialogResult.OK Then
            oPreferencias.PathExcelEnvios_CA = openFileDialog.FileName

            frmMissatge.MostrarAvis(fnTraductor.RetornaIdiomaSeleccionat("Ruta guardada correctamente",
                                                                          "Ruta guardada correctament"))

            tbxRutaExcelEnvCAT.Text = oPreferencias.PathExcelEnvios_CA
        End If
    End Sub

    Private Sub btnSelectPathExcelEnvCAS_Click(sender As Object, e As EventArgs) Handles btnSelectPathExcelEnvCAS.Click
        Dim openFileDialog As New OpenFileDialog

        openFileDialog.Title = fnTraductor.RetornaIdiomaSeleccionat("Selecciona la plantilla para Informe Excel Envíos en Castellano",
                                                                     "Selecciona la plantilla per Informe Excel Envíos en Castellà")

        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        openFileDialog.Filter = "Archivos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx|Todos los archivos (*.*)|*.*"
        openFileDialog.FilterIndex = 1
        openFileDialog.RestoreDirectory = True

        If openFileDialog.ShowDialog = DialogResult.OK Then
            oPreferencias.PathExcelEnvios_ES = openFileDialog.FileName

            frmMissatge.MostrarAvis(fnTraductor.RetornaIdiomaSeleccionat("Ruta guardada correctamente",
                                                                          "Ruta guardada correctament"))

            tbxRutaExcelEnvCAS.Text = oPreferencias.PathExcelEnvios_ES
        End If
    End Sub

    Private Sub btnSelectPathExcelFactCAT_Click(sender As Object, e As EventArgs) Handles btnSelectPathExcelFactCAT.Click
        Dim openFileDialog As New OpenFileDialog

        openFileDialog.Title = fnTraductor.RetornaIdiomaSeleccionat("Selecciona la plantilla para Informe Excel Facturas en Catalán",
                                                                     "Selecciona la plantilla per Informe Excel Envíos en Català")

        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        openFileDialog.Filter = "Archivos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx|Todos los archivos (*.*)|*.*"
        openFileDialog.FilterIndex = 1
        openFileDialog.RestoreDirectory = True

        If openFileDialog.ShowDialog = DialogResult.OK Then
            oPreferencias.PathExcelFacturas_CA = openFileDialog.FileName

            frmMissatge.MostrarAvis(fnTraductor.RetornaIdiomaSeleccionat("Ruta guardada correctamente",
                                                                          "Ruta guardada correctament"))

            tbxRutaExcelFactCAT.Text = oPreferencias.PathExcelFacturas_CA
        End If
    End Sub

    Private Sub btnSelectPathExcelFactCAS_Click(sender As Object, e As EventArgs) Handles btnSelectPathExcelFactCAS.Click
        Dim openFileDialog As New OpenFileDialog

        openFileDialog.Title = fnTraductor.RetornaIdiomaSeleccionat("Selecciona la plantilla para Informe Excel Facturas en Castellano",
                                                                     "Selecciona la plantilla per Informe Excel Envíos en Castellà")

        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        openFileDialog.Filter = "Archivos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx|Todos los archivos (*.*)|*.*"
        openFileDialog.FilterIndex = 1
        openFileDialog.RestoreDirectory = True

        If openFileDialog.ShowDialog = DialogResult.OK Then
            oPreferencias.PathExcelFacturas_ES = openFileDialog.FileName

            frmMissatge.MostrarAvis(fnTraductor.RetornaIdiomaSeleccionat("Ruta guardada correctamente",
                                                                          "Ruta guardada correctament"))

            tbxRutaExcelFactCAS.Text = oPreferencias.PathExcelFacturas_ES
        End If
    End Sub

    Private Sub btnPathGuardadoFacturas_Click(sender As Object, e As EventArgs) Handles btnPathGuardadoFacturas.Click
        Dim folderBrowser As New FolderBrowserDialog

        folderBrowser.Description = fnTraductor.RetornaIdiomaSeleccionat("Selecciona la ruta para el guardado de Facturas",
                                                                     "Selecciona la ruta pel desat de Factures")

        folderBrowser.RootFolder = Environment.SpecialFolder.Desktop
        folderBrowser.ShowNewFolderButton = True

        If folderBrowser.ShowDialog = DialogResult.OK Then
            oPreferencias.PathGuardadoFacturas = folderBrowser.SelectedPath

            frmMissatge.MostrarAvis(fnTraductor.RetornaIdiomaSeleccionat("Ruta guardada correctamente",
                                                                          "Ruta guardada correctament"))

            tbxPathGuardadoFacturas.Text = oPreferencias.PathGuardadoFacturas
        End If
    End Sub

    Private Sub btnPathGuardadoInformes_Click(sender As Object, e As EventArgs) Handles btnPathGuardadoInformes.Click
        Dim folderBrowser As New FolderBrowserDialog

        folderBrowser.Description = fnTraductor.RetornaIdiomaSeleccionat("Selecciona la ruta para el guardado de Informes",
                                                                     "Selecciona la ruta pel desat d'Informes")

        folderBrowser.RootFolder = Environment.SpecialFolder.Desktop
        folderBrowser.ShowNewFolderButton = True

        If folderBrowser.ShowDialog = DialogResult.OK Then
            oPreferencias.PathGuardadoInformes = folderBrowser.SelectedPath

            frmMissatge.MostrarAvis(fnTraductor.RetornaIdiomaSeleccionat("Ruta guardada correctamente",
                                                                          "Ruta guardada correctament"))

            tbxPathGuardadoInformes.Text = oPreferencias.PathGuardadoInformes
        End If
    End Sub


End Class