Imports System.Globalization
Imports System.Windows
Imports System.Xml
Imports Microsoft.Data.SqlClient

Public Class frmEscollirBD

    Private connectionStrings As New Dictionary(Of String, String)()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualitzarIdiomaControls(Me, clsConstants.Idioma)
        CargarComboBoxDesdeXML("database.xml")
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


    Private Sub CargarComboBoxDesdeXML(filename As String)
        Try
            Dim doc As New XmlDocument()
            doc.Load(filename)

            Dim databaseNodes As XmlNodeList = doc.SelectNodes("/databaseConfig/database")

            For Each dbNode As XmlNode In databaseNodes
                Dim dbName As String = dbNode.Attributes("name").Value
                Dim connectionString As String = dbNode.SelectSingleNode("connectionString").InnerText

                cmbxBD.Items.Add(dbName)
                connectionStrings(dbName) = connectionString
            Next

            cmbxBD.SelectedIndex = 0

        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al carregar la Base de Dades",
                                                                         "Error al cargar la Base de Datos"), ex)

        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim selectedDB As String = cmbxBD.SelectedItem.ToString()
            Dim connectionString As String = connectionStrings(selectedDB)
            clsConstants.ConnGlobal = New SqlConnection(connectionString)
            Me.DialogResult = DialogResult.OK
        Catch ex As Exception
            frmMissatge.Mostrar("AA", ex)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Forms.Application.Exit()
        End

    End Sub
End Class