﻿Imports Microsoft.Data.SqlClient

Public Class frmTarifas

#Region "Atributs"

    Private oDades As clsTarifas
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
        oDades = New clsTarifas

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
        oDades.Nom = tbxNomTarifa.Text
        oDades.Multiplicador = Decimal.Parse(tbxMultiplicador.Text)
    End Sub

    Private Sub CopiarDadesAControls()
        tbxNomTarifa.Text = oDades.Nom
        tbxMultiplicador.Text = oDades.Multiplicador
    End Sub

    Private Sub Inicialitzacions()

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

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click

        Try
            If frmMissatge.MostrarPreguntaSiNo(fnTraductor.RetornaIdiomaSeleccionat("¿Estás seguro de borrar este registro?",
                                                                                     "Estàs segur d'esborrar aquest registre?")) Then

                oDades.Esborrar()
                Me.Close()


            End If
        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al borrar el registro", "Error al esborrar el registre"), ex)
        End Try
    End Sub

#End Region


End Class