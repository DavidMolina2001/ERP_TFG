Imports System.IO
Imports Newtonsoft.Json
Imports Microsoft.Data
Imports System.Windows
Imports System.Globalization


Public Class frmMain


    'Server=localhost;Database=master;Trusted_Connection=True;
    'MAQUINA LDAP : david tatun123
    'dominio : ldap.tfg
    'CONTRA LDAP : david tatun123
    '{SSHA}wghKlxuiHqv1uuuvkeDcAGI9Z+mG653A
    'https://www.linuxtechi.com/setup-openldap-server-on-ubuntu/
    'https://ubuntu.com/server/docs/install-and-configure-ldap SEGUIR ESTE I HACER CON TLS
#Region "Atributos"

    Dim oPreferencias As clsEmpresa

    Dim bExistenAvisos As Boolean
#End Region



#Region "Constructor"
    Public Sub New()


        Try
            'If Environment.MachineName = clsSeguretat.PC_DAVID Then
            '    clsConstants.ConnGlobal = New SqlClient.SqlConnection("Server=localhost;Database=AppTransportes;Integrated Security=True;TrustServerCertificate=True;")

            'Else
            '    'clsConstants.ConnGlobal = New SqlClient.SqlConnection("Server=192.168.2.202;Database=AppTransportesTFG;User Id=sa;Password=Z57ZVjOzCuzwsVAxcB6E;TrustServerCertificate=True;")
            '    'clsConstants.ConnGlobal = New SqlClient.SqlConnection("Server=192.168.2.202;Database=AppTransportes;User Id=sa;Password=Z57ZVjOzCuzwsVAxcB6E;TrustServerCertificate=True;MultipleActiveResultSets=true;Trusted_Connection=True")
            '    'clsConstants.ConnGlobal = New SqlClient.SqlConnection("Server=192.168.2.202;Database=AppTransportes;User Id=sa;Password=Z57ZVjOzCuzwsVAxcB6E;Trusted_Connection=True;")
            '    clsConstants.ConnGlobal = New SqlClient.SqlConnection("Data Source=tcp:192.168.2.202,1433;Initial Catalog=AppTransportes;User ID=TFG;Password=Tatun123!;TrustServerCertificate=True;MultipleActiveResultSets=true;")

            '    '
            'End If

            'frmMissatge.MostrarAvis("1")
            ElegirBaseDatos()
            'clsConstants.ConnGlobal.Open()

            'frmMissatge.MostrarAvis("2")


            InitializeComponent()

            frmWaitForm.ShowWaitForm(String.Empty)

            lblData.Text = Date.Now.ToString("dd-MM-yyyy")

            'frmMissatge.MostrarAvis("3")

            Timer1.Interval = 30000 '300000 ms que son 5 minutos

            ActualitzarIdiomaControls(Me, clsConstants.Idioma, True)
            'frmMissatge.MostrarAvis("4")

            ConsultarIncidencies()
            'frmMissatge.MostrarAvis("5")

            ComprobarRutas()
            'frmMissatge.MostrarAvis("6")

            CargarTrabajadoresEnRuta()

            'frmMissatge.MostrarAvis("7")

            If bExistenAvisos Then
                lblAvisos.Visible = True
            End If


            CargarCbxCalendario()

            frmWaitForm.CloseWaitForm()


            'AuthenticateUser()
        Catch ex As Exception
            frmMissatge.Mostrar("Error al obrir el programa", ex)
            Forms.Application.Exit()
            End
        End Try



    End Sub


    Private Sub ElegirBaseDatos()
        Dim oForm As frmEscollirBD = Nothing

        Try
            oForm = New frmEscollirBD

            If oForm.ShowDialog() = DialogResult.OK Then
                clsConstants.ConnGlobal.Open()

            End If

        Catch ex As Exception
            Throw New Exception("Error ElegirBaseDatos ", ex)
        End Try
    End Sub

#End Region



#Region "Events Form"

    Dim bLogin As Boolean = False

    Private Sub ToolStripContainer1_ContentPanel_Layout(sender As Object, e As LayoutEventArgs) Handles ToolStripContainer1.ContentPanel.Layout
        If Not bLogin Then
            'frmMissatge.MostrarAvis("aa7")

            CargarPreferencias()

            'Autenticar con LDAP
            If clsConstants.LDAP Then
                If Not LDAP.AutenticarLDAP() Then
                    frmMissatge.MostrarAvis(fnTraductor.RetornaIdiomaSeleccionat("No se ha podido autenticar automáticamente, entra las credenciales",
                                                                              "No s'ha pogut autenticar automàticament, entra les credencials"))


                    ShowLogin()
                    bLogin = True
                Else

                    bLogin = True
                End If
            Else

                ShowLogin()
                bLogin = True
            End If

            lblUser.Text = clsSeguretat.Usuari


        End If

    End Sub

    Private Sub CargarPreferencias()

        Try
            Dim sVersio As String = SQLReader.ObtenirUnCamp(clsConstants.ConnGlobal, Nothing, "SELECT Versio FROM Empresa Where IdEmpresa = " & 2)

            Dim oVersio As String() = sVersio.Split(".")

            If oVersio(0) <> clsConstants.VERSIO_MAJOR Or oVersio(1) <> clsConstants.VERSIO_MINOR Or oVersio(2) <> clsConstants.VERSIO_BUILD Then
                frmMissatge.MostrarAvis(fnTraductor.RetornaIdiomaSeleccionat("El programa no esta actualitzat, executa el Update",
                                                                                  "El programa no esta actualizado, ejecuta el Update"))
                Forms.Application.Exit()
                End
            End If


            oPreferencias = New clsEmpresa

            oPreferencias.Llegir(2)
            clsConstants.Idioma = oPreferencias.CodiIdioma



            clsConstants.LDAP = oPreferencias.LDAP
            clsConstants.PathEtiquetas = oPreferencias.PathEtiquetas
            clsConstants.PathFactCAT = oPreferencias.PathFactura_CA
            clsConstants.PathFactCAS = oPreferencias.PathFactura_ES
            clsConstants.PathExcelEnviosCAT = oPreferencias.PathExcelEnvios_CA
            clsConstants.PathExcelEnviosCAS = oPreferencias.PathExcelEnvios_ES
            clsConstants.PathExcelEnviosCAT = oPreferencias.PathExcelEnvios_CA
            clsConstants.PathExcelEnviosCAS = oPreferencias.PathExcelEnvios_ES
            clsConstants.PathGuardadoFacturas = oPreferencias.PathGuardadoFacturas
            clsConstants.PathGuardadoInformes = oPreferencias.PathGuardadoInformes

        Catch ex As Exception
            Throw New Exception("Error: CargarPreferencias", ex)
        End Try



    End Sub

    Public Function getContentPanel() As ToolStripContentPanel
        Return ToolStripContainer1.ContentPanel
    End Function


    Private Sub ShowLogin()
        Dim oFormLogin As frmLogin = Nothing
        Try

            oFormLogin = New frmLogin
            oFormLogin.StartPosition = FormStartPosition.CenterParent

            If oFormLogin.ShowDialog() = DialogResult.Cancel Then
                'Me.BeginInvoke(Sub()
                '                   Me.Close()
                '               End Sub)
                Forms.Application.Exit()
                End
            End If




        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al iniciar sesión",
                                                                      "Error al iniciar sessió"), ex)
        End Try
    End Sub
    Private Sub frmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        'If oPreferencias IsNot Nothing Then
        '    oPreferencias = Nothing
        'End If
    End Sub


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub


    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ConsultarIncidencies()
    End Sub

#End Region


#Region "Boton Config"

    Private Sub btnConfiguracion_Click(sender As Object, e As EventArgs) Handles btnConfiguracion.Click
        AbrirConfiguracion()
    End Sub


    Private Sub AbrirConfiguracion()
        Dim oForm As frmPreferencies = Nothing

        Try
            oForm = New frmPreferencies(oPreferencias)
            oForm.ShowDialog()

            If oPreferencias.CodiIdioma <> clsConstants.Idioma Then
                ActualitzarIdiomaControls(Me, oPreferencias.CodiIdioma, True)
                clsConstants.Idioma = oPreferencias.CodiIdioma
            End If

            If oPreferencias.PathEtiquetas <> clsConstants.Idioma Then
                clsConstants.PathEtiquetas = oPreferencias.PathEtiquetas
            End If

            If oPreferencias.PathFactura_CA <> clsConstants.PathFactCAT Then
                clsConstants.PathFactCAT = oPreferencias.PathFactura_CA
            End If

            If oPreferencias.PathFactura_ES <> clsConstants.PathFactCAS Then
                clsConstants.PathFactCAS = oPreferencias.PathFactura_ES
            End If

            If oPreferencias.PathExcelEnvios_CA <> clsConstants.PathExcelEnviosCAT Then
                clsConstants.PathExcelEnviosCAT = oPreferencias.PathExcelEnvios_CA
            End If

            If oPreferencias.PathExcelEnvios_ES <> clsConstants.PathExcelEnviosCAS Then
                clsConstants.PathExcelEnviosCAS = oPreferencias.PathExcelEnvios_ES
            End If

            If oPreferencias.PathExcelFacturas_CA <> clsConstants.PathExcelFacturasCAT Then
                clsConstants.PathExcelFacturasCAT = oPreferencias.PathExcelFacturas_CA
            End If

            If oPreferencias.PathExcelFacturas_ES <> clsConstants.PathExcelFacturasCAS Then
                clsConstants.PathExcelFacturasCAS = oPreferencias.PathExcelFacturas_ES
            End If

            oPreferencias = oForm.oPreferencias

        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al abrir las preferencias",
                                                                      "Error al obrir les preferències"), ex)
        End Try
    End Sub





#End Region

#Region "Control Idiomas"
    Private Sub ActualitzarIdiomaControls(ByVal frm As Control, ByVal sIdioma As String, bEsMain As Boolean)

        If TypeOf (frm) Is frmWaitForm Then
            Exit Sub
        End If

        For Each ctrl As Control In frm.Controls
            If TypeOf ctrl Is LabelMultiIdioma Then
                DirectCast(ctrl, LabelMultiIdioma).CambiarIdioma(sIdioma)

            ElseIf TypeOf ctrl Is ButtonMultiIdioma Then
                DirectCast(ctrl, ButtonMultiIdioma).CambiarIdioma(sIdioma)

            ElseIf TypeOf ctrl Is TreeView Then

                ActualitzarIdiomaTreeView(ctrl, sIdioma)

            ElseIf ctrl.HasChildren Then
                ActualitzarIdiomaControls(ctrl, sIdioma, False)
            End If
        Next

        If bEsMain Then
            For Each oForm As Object In Forms.Application.OpenForms
                If Not TypeOf oForm Is frmMain Then
                    oForm.ActualitzarIdiomaControls(oForm, sIdioma)
                End If
            Next

            cCalendar.Culture = IIf(sIdioma.StartsWith("E"), New CultureInfo("es-ES"), New CultureInfo("ca-ES"))
        End If

    End Sub


    Private Sub ActualitzarIdiomaTreeView(ByRef tv As TreeView, sIdioma As String)

        Try

            For Each oNode As TreeNode In tv.Nodes
                iActualitzarIdiomaTreeView(oNode, sIdioma)
            Next

        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al actualizar el idioma del arbol ",
                                                                      "Error al actualitzar l'idiome de l'arbre ") & tv.Name, ex)
        End Try
    End Sub

    Private Sub iActualitzarIdiomaTreeView(ByRef oNode As TreeNode, sIdioma As String)

        Dim oTag As String() = Nothing

        Try
            oTag = Split(oNode.Tag, ";")

            oNode.Text = fnTraductor.RetornaIdiomaSeleccionat(oTag(1), oTag(2), sIdioma)

            If oNode.Nodes.Count <> 0 Then
                For Each oNodeFill As TreeNode In oNode.Nodes
                    iActualitzarIdiomaTreeView(oNodeFill, sIdioma)
                Next
            End If

        Catch ex As Exception
            Throw New Exception("Error frmMain.iActualitzarIdiomaTreeView", ex)
        End Try



    End Sub




#End Region


#Region "Arbres"
    Private Sub btnEnviaments_Click(sender As Object, e As EventArgs) Handles btnEnviaments.Click
        lblTreeSelected.Text = fnTraductor.RetornaIdiomaSeleccionat("Envíos", "Enviaments")
        tvEnviaments.BringToFront()
        cmbxSelectCalendari.Visible = False


    End Sub

    Private Sub btnClients_Click(sender As Object, e As EventArgs) Handles btnClients.Click
        lblTreeSelected.Text = fnTraductor.RetornaIdiomaSeleccionat("Clientes", "Clients")
        tvClients.BringToFront()
        cmbxSelectCalendari.Visible = False

    End Sub

    Private Sub btnLogistica_Click(sender As Object, e As EventArgs) Handles btnLogistica.Click
        lblTreeSelected.Text = fnTraductor.RetornaIdiomaSeleccionat("Logística", "Logística")
        tvLogistica.BringToFront()
        cmbxSelectCalendari.Visible = False
    End Sub

    Private Sub btnInformes_Click(sender As Object, e As EventArgs) Handles btnInformes.Click
        lblTreeSelected.Text = "Informes"
        tvInformes.BringToFront()
        cmbxSelectCalendari.Visible = False
    End Sub


#Region "Controles Treeview i Eventos Calendario"

    Private Sub btnCalendario_Click(sender As Object, e As EventArgs) Handles btnCalendario.Click
        lblTreeSelected.Text = fnTraductor.RetornaIdiomaSeleccionat("Calendario", "Calendari")
        cCalendar.Visible = True
        cmbxSelectCalendari.Visible = True
        cmbxSelectCalendari.BringToFront()
        cCalendar.BringToFront()

    End Sub


    Private Sub CargarCbxCalendario()

        cmbxSelectCalendari.Items.Add(fnTraductor.RetornaIdiomaSeleccionat("Envíos", "Enviaments"))
        cmbxSelectCalendari.Items.Add(fnTraductor.RetornaIdiomaSeleccionat("Incidencias", "Incidències"))
        cmbxSelectCalendari.Items.Add(fnTraductor.RetornaIdiomaSeleccionat("Informes", "Informes"))
        cmbxSelectCalendari.Items.Add(fnTraductor.RetornaIdiomaSeleccionat("Facturas", "Factures"))
        cmbxSelectCalendari.SelectedIndex = 0

    End Sub

    Private Sub cCalendar_SelectionChanged(sender As Object, e As EventArgs) Handles cCalendar.SelectionChanged, cmbxSelectCalendari.SelectionChangeCommitted

        Dim oForm As frmLlistat = Nothing

        Try

            Dim dDate = cCalendar.SelectedDate

            Dim sNombreClasse = String.Empty

            Dim iConsulta = 2



            Select Case cmbxSelectCalendari.SelectedIndex
                Case 0
                    sNombreClasse = "clsEnvios"
                Case 1
                    sNombreClasse = "clsEnvios"
                    iConsulta = 3
                Case 2
                    sNombreClasse = "clsInformes"
                Case 3
                    sNombreClasse = "clsFacturas"
                Case Else
                    Throw New Exception("Error Selecció CMBX")

            End Select

            Dim sClasse = "AppTransportesTFG." & sNombreClasse

            Dim tipoClase = Type.GetType(sClasse)

            Dim instanciaClase = Activator.CreateInstance(tipoClase)

            Dim sTitol As String = fnTraductor.RetornaIdiomaSeleccionat(instanciaClase.NOM_CLASSE_ES, instanciaClase.NOM_CLASSE_CAT)

            If iConsulta = 3 Then
                sTitol = fnTraductor.RetornaIdiomaSeleccionat("Incidencias", "Incidències")
            End If

            Dim oParams As Object() = {dDate}



            oForm = New frmLlistat(clsConstants.ConnGlobal, instanciaClase, instanciaClase.Seleccionar_Consulta(iConsulta, oParams), Me, sTitol, False, False)
            oForm.TryLoad()
            ToolStripContainer1.ContentPanel.Controls.Add(oForm)
            oForm.BringToFront()
            oForm.Show()


        Catch ex As Exception

            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al abrir el listado desde el calendario.",
                                                                      "Error al obrir el llistat des de el calendari."), ex)
        End Try
    End Sub



#End Region

    Private Sub ControlTreeViewClick(sender As Object, e As EventArgs) Handles tvEnviaments.DoubleClick, tvLogistica.DoubleClick, tvClients.DoubleClick, tvInformes.DoubleClick

        Dim oTag As String() = Nothing
        Dim oForm As frmLlistat = Nothing
        Dim oFormInforme As frmGeneradorInformes = Nothing

        Try
            oTag = Split(sender.SelectedNode.Tag, ";")

            If oTag(0) = 0 Then 'Es carpeta res.
                Exit Sub

            ElseIf oTag(0) = 1 Then 'Es un item

                If oTag(3) = "clsAltaRapida" Then

                    Dim oFormAR As frmAltaRapida = New frmAltaRapida(clsConstants.ConnGlobal)

                    oFormAR.TryLoad()

                    oFormAR.Show()

                ElseIf oTag(3) = "clsDocuments" Then

                    Dim sClasse As String = "AppTransportesTFG.clsDocuments" ' & oTag(3)

                    Dim tipoClase As Type = Type.GetType(sClasse)

                    Dim instanciaClase As Object = Activator.CreateInstance(tipoClase)

                    Dim sTitol As String = fnTraductor.RetornaIdiomaSeleccionat("Elige un documento para abrir",
                                                                                 "Escull un document per obrir")



                    oForm = New frmLlistat(clsConstants.ConnGlobal, instanciaClase, instanciaClase.Seleccionar_Consulta(oTag(4)), Me, sTitol, True, False)
                    oForm.TopLevel = True

                    oForm.TryLoad()
                    'ToolStripContainer1.ContentPanel.Controls.Add(oForm)
                    oForm.BringToFront()
                    If oForm.ShowDialog() = DialogResult.OK Then
                        Dim IdDocument As Integer = oForm.IdSeleccionat

                        Dim oDocument As clsDocuments = New clsDocuments
                        oDocument.Llegir(IdDocument)

                        Process.Start("C:\Program Files\Microsoft Office\root\Office16\excel.EXE", oDocument.RutaDocument)


                    End If


                ElseIf oTag(3) <> "clsEtiquetas" Then 'TODO: igual en un futuro interesa agrupar los que no abren listados de eleccion como por ejemplo etiquetas i asi
                    Dim sClasse As String = "AppTransportesTFG." & oTag(3)

                    Dim tipoClase As Type = Type.GetType(sClasse)

                    Dim instanciaClase As Object = Activator.CreateInstance(tipoClase)

                    Dim sTitol As String = fnTraductor.RetornaIdiomaSeleccionat(instanciaClase.NOM_CLASSE_ES, instanciaClase.NOM_CLASSE_CAT)

                    Dim bNomesVisualitzacio As Boolean = IIf(oTag(5) = 1, True, False)

                    oForm = New frmLlistat(clsConstants.ConnGlobal, instanciaClase, instanciaClase.Seleccionar_Consulta(oTag(4)), Me, sTitol, False, bNomesVisualitzacio)
                    oForm.TryLoad()
                    ToolStripContainer1.ContentPanel.Controls.Add(oForm)
                    oForm.BringToFront()
                    oForm.Show()


                ElseIf oTag(3) = "clsEtiquetas" Then
                    Dim sClasse As String = "AppTransportesTFG.clsEnvios" ' & oTag(3)

                    Dim tipoClase As Type = Type.GetType(sClasse)

                    Dim instanciaClase As Object = Activator.CreateInstance(tipoClase)

                    Dim sTitol As String = fnTraductor.RetornaIdiomaSeleccionat("Elige el envío para generar la etiqueta",
                                                                                 "Escull l'enviament per generar l'etiqueta")



                    oForm = New frmLlistat(clsConstants.ConnGlobal, instanciaClase, instanciaClase.Seleccionar_Consulta(oTag(4)), Me, sTitol, True, False)
                    oForm.TopLevel = True

                    oForm.TryLoad()
                    'ToolStripContainer1.ContentPanel.Controls.Add(oForm)
                    oForm.BringToFront()
                    If oForm.ShowDialog() = DialogResult.OK Then
                        Dim IdEnvio As Integer = oForm.IdSeleccionat

                        Dim sCodigoEnvio As String = SQLReader.ObtenirUnCamp(clsConstants.ConnGlobal, Nothing, "SELECT CodigoSeguimiento FROM Envios WITH (NOLOCK) WHERE IdEnvio = " & IdEnvio)


                        Dim sRuta As String = GeneradorEtiquetas.GenerarCodigoBarrasYGuardar(sCodigoEnvio)

                        frmMissatge.MostrarAvis(fnTraductor.RetornaIdiomaSeleccionat("Etiqueta guardada en: ", "Etiqueta desada a: ") & sRuta)
                    End If



                End If

            Else 'Es un informe

                Dim sTipusInforme As String = oTag(3)
                oFormInforme = New frmGeneradorInformes(clsConstants.ConnGlobal, sTipusInforme.StartsWith("E"))


                oFormInforme.TryLoad()
                oFormInforme.ShowDialog()


            End If


        Catch ex As Exception


            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al mostrar el listado.",
                                                                      "Error al mostrar el llistat."), ex)

        Finally
            If oTag IsNot Nothing Then
                oTag = Nothing
            End If

            'If oForm IsNot Nothing Then
            '    oForm.Dispose()
            '    oForm = Nothing
            'End If
        End Try
    End Sub
#End Region


#Region "Control Incidencies"
    Private Sub ConsultarIncidencies()

        Dim iFiles As Integer = 0

        Try

            iFiles = SQLReader.ObtenirUnCamp(clsConstants.ConnGlobal, Nothing, "SELECT COUNT(*) as Total FROM Envios WITH (NOLOCK) WHERE IdEstado = 6")

            If iFiles <> 0 Then
                lblIncidencies.Visible = True

                If iFiles = 1 Then

                    lblIncidencies.Text = (fnTraductor.RetornaIdiomaSeleccionat("Tienes " & iFiles & " incidencia pendiente de resolver",
                                                                              "Tens " & iFiles & " incidència pendent de resoldre"))

                Else

                    lblIncidencies.Text = (fnTraductor.RetornaIdiomaSeleccionat("Tienes " & iFiles & " incidencias pendientes de resolver",
                                                                              "Tens " & iFiles & " incidències pendents de resoldre"))
                End If

                If bExistenAvisos And Not gbxControlRutas.Visible Then
                    lblIncidencies.Location = New Point(lblAvisos.Location.X, lblAvisos.Location.Y + 55)
                Else
                    bExistenAvisos = True
                End If



            Else
                lblIncidencies.Visible = False

            End If

        Catch ex As Exception

            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al consultar las incidencias pendientes",
                                                                      "Error al consultar les incidències pendents"), ex)
        Finally

        End Try
    End Sub

    Private Sub lblIncidencies_DoubleClick(sender As Object, e As EventArgs) Handles lblIncidencies.DoubleClick
        ObrirIncidencies()
    End Sub

    Private Sub ObrirIncidencies()
        Dim oForm As frmLlistat = Nothing

        Try
            Dim oObject As New clsEnvios
            oForm = New frmLlistat(clsConstants.ConnGlobal, oObject, oObject.Seleccionar_Consulta(1), Me, fnTraductor.RetornaIdiomaSeleccionat("Incidencies", "Incidències"), False, False)
            oForm.TryLoad()
            ToolStripContainer1.ContentPanel.Controls.Add(oForm)
            oForm.BringToFront()

            oForm.Show()

            AddHandler oForm.FormClosed, AddressOf oConsultaIncidenciasClosed


        Catch ex As Exception

            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al mostrar el listado de incidencias",
                                                                      "Error al mostrar el llistat d'incidències"), ex)
        End Try
    End Sub


    Private Sub oConsultaIncidenciasClosed(sender As Object, e As FormClosedEventArgs)
        ConsultarIncidencies()
    End Sub




#End Region

#Region "Control Rutas"


    Private Sub ComprobarRutas()
        Try
            Dim bExistenRutas As Boolean = SQLReader.CampoExiste(clsConstants.ConnGlobal, Nothing, "SELECT TOP 1 IdFurgoneta_Ruta FROM Furgoneta_Ruta WITH (NOLOCK) WHERE FechaRuta = CONVERT(date, GETDATE())")

            If Not bExistenRutas Then
                gbxControlRutas.Visible = True
            Else

                lblIncidencies.Location = New Point(lblAvisos.Location.X, lblAvisos.Location.Y + 55)

                bExistenAvisos = True

            End If

        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al comprobar las rutas de hoy",
                                                                      "Error al comprovar les rutes d'avui"), ex)
        End Try
    End Sub

    Private Sub btnCopiarRutasNO_Click(sender As Object, e As EventArgs) Handles btnCopiarRutasNO.Click
        gbxControlRutas.Visible = False
        lblIncidencies.Location = New Point(lblAvisos.Location.X, lblAvisos.Location.Y + 55)

    End Sub

    Private Sub btnCopiarRutasSI_Click(sender As Object, e As EventArgs) Handles btnCopiarRutasSI.Click
        Dim dtRutasHistorico As DataTable = Nothing
        Dim oRuta As clsFurgoneta_Ruta = Nothing
        Try

            dtRutasHistorico = SQLReader.ReaderDataTable(clsConstants.ConnGlobal, Nothing, "SELECT * FROM Furgoneta_Ruta WITH (NOLOCK) WHERE FechaRuta = (SELECT MAX(FechaRuta) FROM Furgoneta_Ruta WITH (NOLOCK))")

            If dtRutasHistorico.Rows.Count <> 0 Then
                For Each oRow In dtRutasHistorico.Rows
                    oRuta = New clsFurgoneta_Ruta()
                    oRuta.IdFurgoneta = oRow("IdFurgoneta")
                    oRuta.IdRuta = oRow("IdRuta")
                    oRuta.IdTrabajador = oRow("IdTrabajador")
                    oRuta.FechaRuta = Date.Now

                    oRuta.Escriure(True)

                Next
                gbxControlRutas.Visible = False

                lblIncidencies.Location = New Point(lblAvisos.Location.X, lblAvisos.Location.Y + 55)


                frmMissatge.MostrarAvis(fnTraductor.RetornaIdiomaSeleccionat("Rutas copiadas con éxito",
                                                                              "Rutes copiades amb èxit"))

                CargarTrabajadoresEnRuta()
            Else
                frmMissatge.MostrarAvis(fnTraductor.RetornaIdiomaSeleccionat("No hay rutas para copiar",
                                                                              "No hi ha rutes per copiar"))
            End If




        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al copiar las rutas",
                                                                     "Error al copiar les rutes"), ex)
        Finally
            If dtRutasHistorico IsNot Nothing Then
                dtRutasHistorico.Clear()
                dtRutasHistorico.Dispose()
                dtRutasHistorico = Nothing
            End If

            If oRuta IsNot Nothing Then
                oRuta = Nothing
            End If
        End Try
    End Sub




#End Region

#Region "Control Trabajadores en Ruta"
    Private dtTrabajadoresRuta As DataTable = Nothing

    Private Sub CargarTrabajadoresEnRuta()
        Try
            Dim sConsulta As String = "SELECT        Furgonetas.Nombre, Furgonetas.Marca, Furgonetas.Modelo, Trabajadores.Nombre AS Expr1, Trabajadores.Apellidos, Rutas.Nom
            FROM Furgoneta_Ruta WITH (NOLOCK) INNER JOIN
                                     Furgonetas ON Furgoneta_Ruta.IdFurgoneta = Furgonetas.IdFurgoneta INNER JOIN
                                     Trabajadores ON Furgoneta_Ruta.IdTrabajador = Trabajadores.IdTrabajador INNER JOIN
                                     Rutas ON Furgoneta_Ruta.IdRuta = Rutas.IdRuta
            WHERE        (CAST(Furgoneta_Ruta.FechaRuta AS DATE) = CAST(GETDATE() AS DATE))"

            dtTrabajadoresRuta = SQLReader.ReaderDataTable(clsConstants.ConnGlobal, Nothing, sConsulta)

            If dtTrabajadoresRuta.Rows.Count = 0 Then
                dgTrabajadoresEnRuta.Visible = False
                btnActualizarTrabajadoresRuta.Visible = False
                lblTrabajadoresEnRuta.Visible = False
                Exit Sub

            Else
                dgTrabajadoresEnRuta.Visible = True
                lblTrabajadoresEnRuta.Visible = True
                btnActualizarTrabajadoresRuta.Visible = True

            End If

            dgTrabajadoresEnRuta.DataSource = dtTrabajadoresRuta


            For Each columna As Syncfusion.WinForms.DataGrid.GridColumn In dgTrabajadoresEnRuta.Columns
                Dim nombreActual As String = columna.HeaderText

                Select Case nombreActual
                    Case "Nombre" ' Furgonetas.Nombre
                        columna.HeaderText = fnTraductor.RetornaIdiomaSeleccionat("Nombre Furgoneta", "Nom Furgoneta")

                    Case "Marca" ' Furgonetas.Marca
                        columna.HeaderText = fnTraductor.RetornaIdiomaSeleccionat("Marca", "Marca")

                    Case "Modelo" ' Furgonetas.Modelo
                        columna.HeaderText = fnTraductor.RetornaIdiomaSeleccionat("Modelo", "Model")

                    Case "Expr1" ' Trabajadores.Nombre
                        columna.HeaderText = fnTraductor.RetornaIdiomaSeleccionat("Nombre Trabajador", "Nom Treballador")

                    Case "Apellidos" ' Trabajadores.Apellidos
                        columna.HeaderText = fnTraductor.RetornaIdiomaSeleccionat("Apellidos", "Cognoms")

                    Case "Nom" ' Rutas.Nom
                        columna.HeaderText = fnTraductor.RetornaIdiomaSeleccionat("Ruta", "Ruta")

                End Select
                columna.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCells


            Next

            dgTrabajadoresEnRuta.Refresh()
            'dgTrabajadoresEnRuta.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCells



        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al cargar los trabajadores en ruta",
                                                                     "Error al carregar els treballadors en ruta"), ex)
        End Try
    End Sub

    Private Sub btnActualizarTrabajadoresRuta_Click(sender As Object, e As EventArgs) Handles btnActualizarTrabajadoresRuta.Click
        CargarTrabajadoresEnRuta()

    End Sub







#End Region



End Class
