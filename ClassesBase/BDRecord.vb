Imports System.Collections.ObjectModel
Imports System.Linq.Expressions
Imports System.Security.Cryptography
Imports Microsoft.Data.SqlClient

Public MustInherit Class BDRecord
    Implements IRecord
    Public Property Id As String Implements IRecord.Id

    Public Property NOM_TAULA As String Implements IRecord.NOM_TAULA
    Public Property NOM_PK As String Implements IRecord.NOM_PK

    Public Sub New(tableName As String, primaryKeyName As String)
        NOM_TAULA = tableName
        NOM_PK = primaryKeyName
    End Sub

    Public Sub New()
    End Sub


    Public MustOverride Sub CopiarDatosDesdeDataReader(reader As SqlDataReader)

    Public MustOverride Sub CopiarDatosADataRow(drw As DataRow)

    Public MustOverride Function FormulariManteniment() As Type

    Public MustOverride Function NomCampMostrar(sCamp As String) As String

    Public MustOverride Function Seleccionar_Consulta(IdConsulta As Integer, Optional oParams As Object() = Nothing) As String

    Public Sub Llegir(sId As String) Implements IRecord.Llegir

        Dim reader As SqlDataReader = Nothing

        Try


            Dim command As New SqlCommand("SELECT * FROM " & NOM_TAULA & " WHERE " & NOM_PK & " = @Id", clsConstants.ConnGlobal)

            command.Parameters.AddWithValue("@Id", sId)

            reader = command.ExecuteReader()
            If reader.Read() Then
                Me.CopiarDatosDesdeDataReader(reader)
            Else
                Throw New Exception("Error Llegir Reader.")
            End If

            Me.Id = sId

            reader.Close()

        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al leer la clase con ID: ",
                                                                      "Error al llegir la classe amb ID:") & sId, ex)

        Finally
            If reader IsNot Nothing Then
                If Not reader.IsClosed Then
                    reader.Close()
                End If
                reader.DisposeAsync()

            End If
        End Try
    End Sub

    Public Sub Escriure(ByVal bEsAlta As Boolean) Implements IRecord.Escriure
        Try

            Dim dataSet As New DataSet()
            Dim adapter As New SqlDataAdapter()

            Dim selectQuery As String = "SELECT * FROM " & NOM_TAULA & " WHERE " & NOM_PK & " = @Id"
            adapter.SelectCommand = New SqlCommand(selectQuery, clsConstants.ConnGlobal)

            If Id Is Nothing Then
                Id = 0
            End If

            adapter.SelectCommand.Parameters.AddWithValue("@Id", Id)

            adapter.Fill(dataSet, "Tabla")

            Dim row As DataRow

            If dataSet.Tables("Tabla").Rows.Count = 0 Then
                row = dataSet.Tables("Tabla").NewRow()
                dataSet.Tables("Tabla").Rows.Add(row)
            Else
                row = dataSet.Tables("Tabla").Rows(0)
            End If


            If bEsAlta Then
                Dim ultimoId As Integer = ObtenerUltimoIdDisponible(clsConstants.ConnGlobal)
                row(NOM_PK) = ultimoId
            End If

            CopiarDatosADataRow(row)

            adapter.UpdateCommand = New SqlCommandBuilder(adapter).GetUpdateCommand()
            adapter.Update(dataSet, "Tabla")

            If bEsAlta Then
                Me.Id = ObtenerUltimoIdDisponible(clsConstants.ConnGlobal) - 1

            End If


        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al escribir la clase en la base de datos.",
                                                                      "Error al escriure la classe a la base de dades."), ex)
        End Try
    End Sub

    Public Function Esborrar() As Boolean Implements IRecord.Esborrar

        Dim bEsborrat As Boolean = False

        Try


            Dim deleteQuery As String = "DELETE FROM " & NOM_TAULA & " WHERE " & NOM_PK & " = @Id"
            Dim command As New SqlCommand(deleteQuery, clsConstants.ConnGlobal)

            If Id Is Nothing Then
                Return False
            End If

            command.Parameters.AddWithValue("@Id", Id)

            Dim rowsAffected As Integer = command.ExecuteNonQuery()

            If rowsAffected > 0 Then
                bEsborrat = True
            Else
                bEsborrat = False
            End If

        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al borrar la clase en la base de datos.",
                                                                      "Error al esborrar la classe a la base de dades."), ex)
        End Try
        Return bEsborrat
    End Function

    Private Function ObtenerUltimoIdDisponible(ByVal connection As SqlConnection) As Integer
        Dim ultimoId As Integer = 0

        Try
            Dim command As New SqlCommand("SELECT MAX(" & NOM_PK & ") FROM " & NOM_TAULA, connection)
            Dim result As Object = command.ExecuteScalar()

            If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                ultimoId = Convert.ToInt32(result) + 1
            Else
                ultimoId = 1
            End If
        Catch ex As Exception
            Throw New Exception("Error BDRecord.ObtenerUltimoIdDisponible", ex)
        End Try

        Return ultimoId
    End Function



End Class
