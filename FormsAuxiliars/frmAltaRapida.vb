Imports Microsoft.Data.SqlClient
Imports Newtonsoft.Json

Public Class frmAltaRapida

#Region "Atributs"

    Private oConn As SqlConnection
#End Region

#Region "Constructor"
    Public Sub New(_oConn As SqlConnection)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Me.oConn = _oConn

        Me.Text = fnTraductor.RetornaIdiomaSeleccionat("Alta Rápida", "Alta Ràpida")


    End Sub
#End Region

#Region "Metodes"

    Public Function TryLoad() As Boolean

        Dim bTryload As Boolean 'Variable que indica si ha cargao bien el frm.

        Try

            ActualitzarIdiomaControls(Me, clsConstants.Idioma)

            Inicialitzacions() 'Inicialitzacions del formulari abans de carregar res.



            bTryload = True


        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al cargar el formulario.",
                                                                      "Error al carregar el formulari."), ex)
            bTryload = False
        End Try

        Return bTryload
    End Function

    Private lstEstados As List(Of Integer)
    Private lstPoblaciones As List(Of String)
    Private lstClientes As List(Of Integer)
    Private dicRutas As Dictionary(Of Integer, List(Of String))
    Private dtEnvios As DataTable = Nothing
    Private oGenerador As GeneradorEnvios = Nothing

    Private Sub Inicialitzacions()

        LlenarListas()


        oGenerador = New GeneradorEnvios(lstEstados, lstClientes, dicRutas)

    End Sub

    Private Sub LlenarListas()
        lstEstados = New List(Of Integer)()
        lstClientes = New List(Of Integer)()
        dicRutas = New Dictionary(Of Integer, List(Of String))()
        lstPoblaciones = New List(Of String)
        Dim dt As DataTable = Nothing
        Dim oClase As clsEnvios = Nothing
        Try

            dtEnvios = SQLReader.ReaderDataTable(oConn, Nothing, "SELECT * FROM Envios WITH (NOLOCK) WHERE (1=0)")

            oClase = New clsEnvios

            dg_Envios.DataSource = dtEnvios

            dt = SQLReader.ReaderDataTable(oConn, Nothing, "SELECT IdRuta, Poblaciones FROM Rutas WITH (NOLOCK)")
            For Each row As DataRow In dt.Rows
                Dim lstTemp As List(Of String) = JsonConvert.DeserializeObject(Of List(Of String))(row("Poblaciones"))
                lstPoblaciones.AddRange(lstTemp)
                dicRutas.Add(Convert.ToInt32(row("IdRuta")), lstTemp)
            Next


            For Each columna As Syncfusion.WinForms.DataGrid.GridColumn In dg_Envios.Columns
                Dim nombreActual As String = columna.HeaderText

                If nombreActual = oClase.NOM_PK Or nombreActual = "IdEnvio" Then
                    columna.Visible = False
                End If




                Dim nombreTraducido As String = oClase.NomCampMostrar(nombreActual)

                columna.HeaderText = nombreTraducido



            Next


            If dg_Envios.Columns("PoblacionDestino") IsNot Nothing Then
                Dim poblacionColumn As New Syncfusion.WinForms.DataGrid.GridComboBoxColumn()
                poblacionColumn.MappingName = "PoblacionDestino"
                poblacionColumn.HeaderText = fnTraductor.RetornaIdiomaSeleccionat("Población Destino", "Població Destí")
                poblacionColumn.DisplayMember = "NombrePoblacionDestino"
                poblacionColumn.ValueMember = "NombrePoblacionDestino"
                poblacionColumn.DataSource = lstPoblaciones
                poblacionColumn.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList

                Dim columnIndex As Integer = dg_Envios.Columns.IndexOf(dg_Envios.Columns("PoblacionDestino"))
                dg_Envios.Columns.RemoveAt(columnIndex)
                dg_Envios.Columns.Insert(columnIndex, poblacionColumn)

            End If


            dg_Envios.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCells


            dt = SQLReader.ReaderDataTable(oConn, Nothing, "SELECT IdEstado FROM Envios_Estados WITH (NOLOCK)")
            For Each row As DataRow In dt.Rows
                lstEstados.Add(Convert.ToInt32(row("IdEstado")))
            Next

            dt = SQLReader.ReaderDataTable(oConn, Nothing, "SELECT IdClient FROM Clients WITH (NOLOCK)")
            For Each row As DataRow In dt.Rows
                lstClientes.Add(Convert.ToInt32(row("IdClient")))
            Next






        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al cargar las listas.",
                                                                      "Error al carregar les llistes."), ex)
        Finally
            If dt IsNot Nothing Then
                dt.Clear()
                dt.Dispose()
                dt = Nothing
            End If
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
        Dim oEnvio As clsEnvios = Nothing
        Dim bRes As Boolean = False
        Try

            Dim sRepetits As String = String.Empty

            For Each oRow In dtEnvios.Rows
                oEnvio = New clsEnvios()

                If Not SQLReader.CampoExiste(oConn, Nothing, "SELECT CodigoSeguimiento FROM Envios WITH (NOLOCK) WHERE CodigoSeguimiento = '" & oRow("CodigoSeguimiento") & "'") Then
                    oEnvio.CopiarDataRowADatos(oRow)
                    oEnvio.Escriure(True)
                Else
                    sRepetits &= oRow("CodigoSeguimiento") & ", "
                End If
            Next

            If sRepetits <> String.Empty Then
                sRepetits = sRepetits.Substring(0, sRepetits.Length - 2)
                frmMissatge.MostrarAvis(fnTraductor.RetornaIdiomaSeleccionat("Los envíos: " & sRepetits & " no se han añadido ya que ya existen en la base de datos",
                                                                             "Els enviaments: " & sRepetits & " no s'han afegit ja que ja existeixen a la base de dades"))



            End If

            bRes = True

        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al guardar los envíos nuevos",
                                                                     "Error al guardar els enviaments nous"), ex)

        Finally
            If oEnvio IsNot Nothing Then
                oEnvio = Nothing
            End If

        End Try

        Return bRes
    End Function

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub frmGeneric_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub

    Private Sub btnAfegir_Click(sender As Object, e As EventArgs) Handles btnAfegir.Click


        Try

            If tbxEnvio.Text = String.Empty Then
                frmMissatge.MostrarAvis(fnTraductor.RetornaIdiomaSeleccionat("Entra un envío",
                                                                             "Entra un enviament"))
                Exit Sub
            End If
            Dim oRow As DataRow = dtEnvios.NewRow

            If cbxRecuperarPlataforma.Checked Then
                oGenerador.GenerarEnvio(oRow, tbxEnvio.Text)
            Else
                oRow("CodigoSeguimiento") = tbxEnvio.Text
                oRow("PoblacionOrigen") = 0
                oRow("DireccionOrigen") = String.Empty
                oRow("NombreRemitente") = String.Empty
                oRow("PoblacionDestino") = 0
                oRow("NombreDestinatario") = String.Empty
                oRow("IdEstado") = 0
                oRow("DireccionDestino") = String.Empty
                oRow("Peso") = 0.0
                oRow("Dimensiones") = String.Empty
                'oRow("CodigoCliente") = 0
                oRow("Porte") = 0.0
                oRow("EmailDestinatario") = String.Empty
                oRow("IdRuta") = 0


            End If


            dtEnvios.Rows.Add(oRow)


        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al recuperar la información del envío.",
                                                                      "Error al recuperar la informació de l'enviament."), ex)
        End Try
    End Sub

    Private Sub btnTreureSeleccionat_Click(sender As Object, e As EventArgs) Handles btnTreureSeleccionat.Click
        Try
            If dtEnvios.Rows.Count = 0 Then
                frmMissatge.MostrarAvis(fnTraductor.RetornaIdiomaSeleccionat("No hay ningún item que borrar",
                                                                              "No hi ha cap item que esborrar"))
                Exit Sub
            End If

            If dg_Envios.SelectedItems.Count > 0 Then
                dtEnvios.Rows.RemoveAt(dg_Envios.CurrentCell.RowIndex - 1)
            End If
            '

        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al quitar el envío.",
                                                                      "Error al treure l'enviament."), ex)
        End Try
    End Sub

    Private Sub dg_Envios_CurrentCellEndEdit(sender As Object, e As Syncfusion.WinForms.DataGrid.Events.CurrentCellEndEditEventArgs) Handles dg_Envios.CurrentCellEndEdit
        Try
            If e.DataColumn.ColumnIndex = 3 Then 'Solo poblaciones
                Dim sPoblacion As String = e.DataRow.RowData.Row.ItemArray(3).ToString()
                If lstPoblaciones.Exists(Function(x) x.Equals(sPoblacion, StringComparison.OrdinalIgnoreCase)) Then

                    For Each kvp As KeyValuePair(Of Integer, List(Of String)) In dicRutas
                        If kvp.Value.Contains(sPoblacion) Then
                            dtEnvios.Rows(e.DataRow.Index - 1)(13) = kvp.Key
                            'e.DataRow.RowData.Row.ItemArray(13) = kvp.Key
                            dtEnvios.AcceptChanges()

                        End If
                    Next

                Else

                    frmMissatge.MostrarAvis(fnTraductor.RetornaIdiomaSeleccionat("La población entrada no existe en nuestras rutas",
                                                                                 "La població entrada no existeix en les nostres rutes"))
                End If
            End If
        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al comprobar la población de destino.",
                                                                      "Error al comprovar la població de destí."), ex)
        End Try
    End Sub




#End Region


End Class