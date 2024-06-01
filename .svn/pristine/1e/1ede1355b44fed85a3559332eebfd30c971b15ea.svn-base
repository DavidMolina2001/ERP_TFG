Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip
Imports Microsoft.Data.SqlClient
Imports Syncfusion.WinForms.DataGrid
Imports Syncfusion.WinForms.DataGrid.Enums

Public Class frmFurgonetas

#Region "Atributs"

    Private oDades As clsFurgonetas
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
        oDades = New clsFurgonetas

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

                CarregarManteniments()

            End If

            btnAfegirHistoric.Enabled = Not bEsAlta
            btnTreureHistoric.Enabled = Not bEsAlta Or dgMantenimientos.RowCount <> 0

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
            Throw New Exception("Error frmFurgonetas.LlegirDades")
        End Try

    End Sub



    Private Sub CopiarControlsADades()
        oDades.Nombre = tbxNom.Text
        oDades.Modelo = tbxModelo.Text
        oDades.Matricula = tbxMatricula.Text
        oDades.Marca = tbxMarca.Text
        oDades.Kilometros = tbxKilometros.Text
    End Sub

    Private Sub CopiarDadesAControls()
        tbxNom.Text = oDades.Nombre
        tbxModelo.Text = oDades.Modelo
        tbxMatricula.Text = oDades.Matricula
        tbxMarca.Text = oDades.Marca
        tbxKilometros.Text = oDades.Kilometros


    End Sub

    Private Sub Inicialitzacions()
        Me.Text = fnTraductor.RetornaIdiomaSeleccionat("Furgonetas", "Furgonetes")
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

            Throw New Exception("Error frmFurgonetas.Guardar")
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

#Region "Manteniments"
    Private dtMantenimientos As DataTable = Nothing
    Private Sub CarregarManteniments()

        Dim oMantenimiento As clsMantenimiento = Nothing
        Try

            dtMantenimientos = SQLReader.ReaderDataTable(oConn, Nothing, clsMantenimiento.ConsultaSelectSegonsFurgoneta(oDades.Id))

            dgMantenimientos.DataSource = dtMantenimientos

            oMantenimiento = New clsMantenimiento

            For Each columna As GridColumn In dgMantenimientos.Columns
                Dim nombreActual As String = columna.HeaderText

                If nombreActual = oMantenimiento.NOM_PK Then
                    columna.Visible = False
                End If

                Dim nombreTraducido As String = oMantenimiento.NomCampMostrar(nombreActual)

                columna.HeaderText = nombreTraducido
                columna.Width = 300
            Next




        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al cargar los mantenimientos",
                                                                      "Error al carregar els manteniments"), ex)
        Finally
            If oMantenimiento IsNot Nothing Then
                oMantenimiento = Nothing
            End If

        End Try
    End Sub

    Private Sub btnAfegirHistoric_Click(sender As Object, e As EventArgs) Handles btnAfegirHistoric.Click

        Dim oForm As frmMantenimiento = Nothing

        Try
            oForm = New frmMantenimiento(oConn, 0, oDades.Id)

            oForm.TryLoad()

            If oForm.ShowDialog = DialogResult.OK Then
                CarregarManteniments()
            End If


        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al añadir el mantenimiento",
                                                                      "Error al afegir el manteniment"), ex)
        Finally
            If oForm IsNot Nothing Then
                oForm.Dispose()
                oForm = Nothing
            End If
        End Try
    End Sub


    Private Sub btnTreureHistoric_Click(sender As Object, e As EventArgs) Handles btnTreureHistoric.Click
        Dim oRegistre As clsMantenimiento = Nothing

        Try
            If dgMantenimientos.SelectedItems.Count > 0 Then
                Dim filaSeleccionada = dgMantenimientos.SelectedItems(0)


                Dim IdMantenimiento As Integer = Convert.ToInt32(filaSeleccionada.Row.Item("IdMantenimiento"))


                Dim resultado As DialogResult = MessageBox.Show(fnTraductor.RetornaIdiomaSeleccionat("¿Está seguro de que desea borrar el registro?",
                                                                                                  "Estas segur de esborrar aquest registre?"), "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If resultado = DialogResult.Yes Then

                    oRegistre = New clsMantenimiento()
                    oRegistre.Llegir(IdMantenimiento)


                    oRegistre.Esborrar()
                    dgMantenimientos.View.Records.RemoveAt(dgMantenimientos.CurrentCell.RowIndex - 1)

                End If
            End If
        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al eliminar el mantenimiento",
                                                                      "Error al eliminar el manteniment"), ex)
        Finally
            If oRegistre IsNot Nothing Then
                oRegistre = Nothing
            End If
            btnTreureHistoric.Enabled = dgMantenimientos.RowCount <> 0

        End Try
    End Sub

#End Region


    Private Sub frmFurgonetas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If dtMantenimientos IsNot Nothing Then
            dtMantenimientos.Clear()
            dtMantenimientos.Dispose()
            dtMantenimientos = Nothing
        End If
    End Sub
End Class