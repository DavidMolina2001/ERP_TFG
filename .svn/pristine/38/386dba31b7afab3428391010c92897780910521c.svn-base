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

        clsConstants.ConnGlobal = New SqlClient.SqlConnection("Server=localhost;Database=AppTransportes;Integrated Security=True;TrustServerCertificate=True;")

        clsConstants.ConnGlobal.Open()

        InitializeComponent()


        lblData.Text = Date.Now.ToString("dd-MM-yyyy")



        Timer1.Interval = 300000 '300000 ms que son 5 minutos

        ActualitzarIdiomaControls(Me, clsConstants.Idioma, True)

        ComprobarRutas()


        ConsultarIncidencies()


        If bExistenAvisos Then
            lblAvisos.Visible = True
        End If

        CargarCbxCalendario()
        'AuthenticateUser()

    End Sub

#End Region



#Region "Events Form"

    Dim bLogin As Boolean = False

    Private Sub ToolStripContainer1_ContentPanel_Layout(sender As Object, e As LayoutEventArgs) Handles ToolStripContainer1.ContentPanel.Layout
        If Not bLogin Then

            CargarPreferencias()

            'Autenticar con LDAP
            If Not LDAP.AutenticarLDAP() And clsConstants.LDAP Then
                frmMissatge.MostrarAvis(fnTraductor.RetornaIdiomaSeleccionat("No se ha podido autenticar automáticamente, entra las credenciales",
                                                                              "No s'ha pogut autenticar automàticament, entra les credencials"))
                ShowLogin()
                bLogin = True
            Else
                ShowLogin()
                bLogin = True

            End If
        End If

    End Sub

    Private Sub CargarPreferencias()
        oPreferencias = New clsEmpresa

        oPreferencias.Llegir(2)
        clsConstants.Idioma = oPreferencias.CodiIdioma
        clsConstants.PathEtiquetas = oPreferencias.PathEtiquetas
        clsConstants.PathFactCAT = oPreferencias.PathFactura_CA
        clsConstants.PathFactCAS = oPreferencias.PathFactura_ES

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

            lblUser.Text = clsSeguretat.Usuari



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

            oPreferencias = oForm.oPreferencias

        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al abrir las preferencias",
                                                                      "Error al obrir les preferències"), ex)
        End Try
    End Sub





#End Region

#Region "Control Idiomas"
    Private Sub ActualitzarIdiomaControls(ByVal frm As Control, ByVal sIdioma As String, bEsMain As Boolean)
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


#Region "Controles i Eventos Calendario"

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


    Private Sub tvEnviaments_DoubleClick(sender As Object, e As EventArgs) Handles tvEnviaments.DoubleClick, tvLogistica.DoubleClick, tvClients.DoubleClick

        Dim oTag As String() = Nothing
        Dim oForm As frmLlistat = Nothing

        Try
            oTag = Split(sender.SelectedNode.Tag, ";")

            If oTag(0) = 0 Then 'Es carpeta res.
                Exit Sub

            Else 'Es un item

                If oTag(3) = "clsAltaRapida" Then

                    Dim oFormAR As frmAltaRapida = New frmAltaRapida(clsConstants.ConnGlobal)

                    oFormAR.TryLoad()

                    oFormAR.Show()


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


                Else
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

                        Dim sCodigoEnvio As String = SQLReader.ObtenirUnCamp(clsConstants.ConnGlobal, Nothing, "SELECT CodigoSeguimiento FROM Envios WHERE IdEnvio = " & IdEnvio)


                        Dim sRuta As String = GeneradorEtiquetas.GenerarCodigoBarrasYGuardar(sCodigoEnvio)

                        frmMissatge.MostrarAvis(fnTraductor.RetornaIdiomaSeleccionat("Etiqueta guardada en: ", "Etiqueta desada a: ") & sRuta)
                    End If


                End If


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

            iFiles = SQLReader.ObtenirUnCamp(clsConstants.ConnGlobal, Nothing, "SELECT COUNT(*) as Total FROM Envios WHERE IdEstado = 6")

            If iFiles <> 0 Then
                lblIncidencies.Visible = True

                If iFiles = 1 Then

                    lblIncidencies.Text = (fnTraductor.RetornaIdiomaSeleccionat("Tienes " & iFiles & " incidencia pendiente de resolver",
                                                                              "Tens " & iFiles & " incidència pendent de resoldre"))

                Else

                    lblIncidencies.Text = (fnTraductor.RetornaIdiomaSeleccionat("Tienes " & iFiles & " incidencias pendientes de resolver",
                                                                              "Tens " & iFiles & " incidències pendents de resoldre"))
                End If

                If bExistenAvisos Then
                    lblIncidencies.Location = New Point(lblAvisos.Location.X, lblAvisos.Location.Y + 65)
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
            Dim bExistenRutas As Boolean = SQLReader.CampoExiste(clsConstants.ConnGlobal, Nothing, "SELECT TOP 1 IdFurgoneta_Ruta FROM Furgoneta_Ruta WHERE FechaRuta = CONVERT(date, GETDATE())")

            If Not bExistenRutas Then
                gbxControlRutas.Visible = True
            Else


                bExistenAvisos = True

            End If

        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al comprobar las rutas de hoy",
                                                                      "Error al comprovar les rutes d'avui"), ex)
        End Try
    End Sub

    Private Sub btnCopiarRutasNO_Click(sender As Object, e As EventArgs) Handles btnCopiarRutasNO.Click
        gbxControlRutas.Visible = False
        lblIncidencies.Location = New Point(lblAvisos.Location.X, lblAvisos.Location.Y + 65)

    End Sub

    Private Sub btnCopiarRutasSI_Click(sender As Object, e As EventArgs) Handles btnCopiarRutasSI.Click
        Dim dtRutasHistorico As DataTable = Nothing
        Dim oRuta As clsFurgoneta_Ruta = Nothing
        Try

            dtRutasHistorico = SQLReader.ReaderDataTable(clsConstants.ConnGlobal, Nothing, "SELECT * FROM Furgoneta_Ruta WHERE FechaRuta = (SELECT MAX(FechaRuta) FROM Furgoneta_Ruta)")

            For Each oRow In dtRutasHistorico.Rows
                oRuta = New clsFurgoneta_Ruta()
                oRuta.IdFurgoneta = oRow("IdFurgoneta")
                oRuta.IdRuta = oRow("IdRuta")
                oRuta.IdTrabajador = oRow("IdTrabajador")
                oRuta.FechaRuta = Date.Now

                oRuta.Escriure(True)

            Next
            gbxControlRutas.Visible = False

            lblIncidencies.Location = New Point(lblAvisos.Location.X, lblAvisos.Location.Y + 65)


            frmMissatge.MostrarAvis(fnTraductor.RetornaIdiomaSeleccionat("Rutas copiadas con éxito",
                                                                          "Rutes copiades amb èxit"))

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




End Class
