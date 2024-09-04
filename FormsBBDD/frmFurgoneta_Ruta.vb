﻿Imports Microsoft.Data.SqlClient

Public Class frmFurgoneta_Ruta

#Region "Atributs"

    Private oDades As clsFurgoneta_Ruta
    Private oConn As SqlConnection
    Private bEsAlta As Boolean
    Private iId As Integer
#End Region

#Region "Constructor"
    Public Sub New(_oConn As SqlConnection, _Id As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Me.oConn = _oConn
        oDades = New clsFurgoneta_Ruta

        iId = _Id

        If _Id = 0 Then
            bEsAlta = True
        Else
            bEsAlta = False

        End If

    End Sub
#End Region

#Region "Metodes"

    Public Function TryLoad() As Boolean

        Dim bTryload As Boolean 'Variable que indica si ha cargao bien el frm.

        Try

            ActualitzarIdiomaControls(Me, clsConstants.Idioma)

            Inicialitzacions() 'Inicialitzacions del formulari abans de carregar res.

            If bEsAlta Then

                lblData.Visible = False
                dtpFecha.Visible = False

            Else

                LlegirDades()



            End If

            bTryload = True

        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al cargar el formulario.",
                                                                      "Error al carregar el formulari."), ex)
            bTryload = False
        End Try

        Return bTryload
    End Function

    Private Sub LlegirDades()

        Try
            oDades.Llegir(iId)

            CopiarDadesAControls()


        Catch ex As Exception
            Throw New Exception("Error frmEnvios.LlegirDades")
        End Try

    End Sub


    Private Sub CopiarControlsADades()
        oDades.IdTrabajador = dtTrabajadores.Rows(cmbxTrabajadores.SelectedIndex)("IdTrabajador")
        oDades.IdFurgoneta = dtFurgonetas.Rows(cmbxFurgonetas.SelectedIndex)("IdFurgoneta")
        oDades.IdRuta = dtRutas.Rows(cmbxRutas.SelectedIndex)("IdRuta")
        If bEsAlta Then
            oDades.FechaRuta = dtpFecha.Value
        End If
    End Sub

    Private Sub CopiarDadesAControls()
        cmbxTrabajadores.SelectedIndex = dtTrabajadores.Rows.IndexOf(dtTrabajadores.Select("IdTrabajador = " & oDades.IdTrabajador)(0))
        cmbxFurgonetas.SelectedIndex = dtFurgonetas.Rows.IndexOf(dtFurgonetas.Select("IdFurgoneta = " & oDades.IdFurgoneta)(0))
        cmbxRutas.SelectedIndex = dtRutas.Rows.IndexOf(dtRutas.Select("IdRuta = " & oDades.IdRuta)(0))
        dtpFecha.Value = oDades.FechaRuta
    End Sub

    Dim dtTrabajadores As DataTable = Nothing
    Dim dtFurgonetas As DataTable = Nothing
    Dim dtRutas As DataTable = Nothing

    Dim dvTrabajadores As DataView = Nothing
    Dim dvFurgonetas As DataView = Nothing
    Dim dvRutas As DataView = Nothing


    Private Sub Inicialitzacions()
        Me.Text = fnTraductor.RetornaIdiomaSeleccionat("Ruta Assignada", "Ruta Asignada")


        Try

            'cmbx Trabajadores
            dtTrabajadores = SQLReader.ReaderDataTable(oConn, Nothing, "SELECT IdTrabajador, Nombre + ' ' + Apellidos AS NombreCompleto FROM Trabajadores WITH (NOLOCK)")
            dvTrabajadores = New DataView(dtTrabajadores)
            cmbxTrabajadores.DataSource = dvTrabajadores
            Me.cmbxTrabajadores.DisplayMember = "NombreCompleto"

            'cmbx Furgonetas
            dtFurgonetas = SQLReader.ReaderDataTable(oConn, Nothing, "SELECT IdFurgoneta, Nombre FROM Furgonetas WITH (NOLOCK)")
            dvFurgonetas = New DataView(dtFurgonetas)
            cmbxFurgonetas.DataSource = dvFurgonetas

            Me.cmbxFurgonetas.DisplayMember = "Nombre"

            'cmbx Rutas
            dtRutas = SQLReader.ReaderDataTable(oConn, Nothing, "SELECT IdRuta, Nom FROM Rutas WITH (NOLOCK)")
            dvRutas = New DataView(dtRutas)
            cmbxRutas.DataSource = dvRutas

            Me.cmbxRutas.DisplayMember = "Nom"


        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al cargar los selectores.",
                                                                      "Error al carregar els selectors."), ex)

        Finally

        End Try



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


#End Region

#Region "Control Botons"

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Guardar() Then
            Me.Close()
            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    Private Function Guardar() As Boolean

        Dim bGuardar As Boolean

        Try
            CopiarControlsADades()

            oDades.Escriure(bEsAlta)

            bGuardar = True

        Catch ex As Exception

            Throw New Exception("Error frmEnvios.Guardar")
            bGuardar = False

        End Try


        Return bGuardar

    End Function

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub frmGeneric_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If dtTrabajadores IsNot Nothing Then
            dtTrabajadores.Clear()
            dtTrabajadores.Dispose()
            dtTrabajadores = Nothing
        End If

        If dtFurgonetas IsNot Nothing Then
            dtFurgonetas.Clear()
            dtFurgonetas.Dispose()
            dtFurgonetas = Nothing
        End If

        If dtRutas IsNot Nothing Then
            dtRutas.Clear()
            dtRutas.Dispose()
            dtRutas = Nothing
        End If

        If dvTrabajadores IsNot Nothing Then
            dvTrabajadores.Dispose()
            dvTrabajadores = Nothing
        End If

        If dvFurgonetas IsNot Nothing Then
            dvFurgonetas.Dispose()
            dvFurgonetas = Nothing
        End If

        If dvRutas IsNot Nothing Then
            dvRutas.Dispose()
            dvRutas = Nothing
        End If

        Me.Dispose()

        GC.Collect()

    End Sub



#End Region


End Class