Imports Microsoft.Data
Imports Microsoft.Data.SqlClient

Public Class SQLReader


    Public Shared Function ReaderDataTable(oConn As SqlClient.SqlConnection, oTrans As SqlClient.SqlTransaction, sConsulta As String) As DataTable
        Dim dt As DataTable = New DataTable()
        Dim reader As SqlClient.SqlDataReader = Nothing

        Try

            Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand(sConsulta, oConn)

            If oTrans IsNot Nothing Then
                cmd.Transaction = oTrans
            End If

            reader = cmd.ExecuteReader()

            dt.Load(reader)

            reader.Close()

        Catch ex As Exception
            frmMissatge.Mostrar("Error SQLReader.ReaderDataTable", ex)

        Finally

            If reader IsNot Nothing Then
                If Not reader.IsClosed Then
                    reader.Close()
                End If

                reader.DisposeAsync()
            End If


        End Try

        Return dt
    End Function

    Public Shared Function ReaderDictionary(oConn As SqlClient.SqlConnection, oTrans As SqlClient.SqlTransaction, sConsulta As String) As Dictionary(Of Integer, Object)
        Dim dict As New Dictionary(Of Integer, Object)
        Dim reader As SqlClient.SqlDataReader = Nothing

        Try
            Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand(sConsulta, oConn)

            If oTrans IsNot Nothing Then
                cmd.Transaction = oTrans
            End If

            reader = cmd.ExecuteReader()

            While reader.Read()
                Dim key As Integer = Convert.ToInt32(reader(0))
                Dim value As Object = reader(1)

                dict.Add(key, value)
            End While

        Catch ex As Exception
            frmMissatge.Mostrar("Error SQLReader.ReaderDictionary", ex)

        Finally
            If reader IsNot Nothing Then
                If Not reader.IsClosed Then
                    reader.Close()
                End If

                reader.DisposeAsync()
            End If
        End Try

        Return dict
    End Function


    Public Shared Function ObtenirUnCamp(oConn As SqlConnection, oTrans As SqlTransaction, sConsulta As String) As Object
        Dim valor As Object = Nothing

        Try
            Using cmd As New SqlCommand(sConsulta, oConn)
                If oTrans IsNot Nothing Then
                    cmd.Transaction = oTrans
                End If

                valor = cmd.ExecuteScalar()
            End Using
        Catch ex As Exception
            frmMissatge.Mostrar("Error SQLReader.ObtenirUnCamp", ex)
        End Try

        Return valor
    End Function

    Public Shared Function CampoExiste(oConn As SqlConnection, oTrans As SqlTransaction, sConsulta As String) As Boolean
        Dim existe As Boolean = False

        Try

            Using cmd As New SqlCommand(sConsulta, oConn)
                If oTrans IsNot Nothing Then
                    cmd.Transaction = oTrans
                End If

                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                existe = (count > 0)
            End Using
        Catch ex As Exception
            frmMissatge.Mostrar("Error al verificar si el campo existe", ex)
        End Try

        Return existe
    End Function

    Public Shared Function ObtenerUnaFila(oConn As SqlConnection, oTrans As SqlTransaction, sConsulta As String) As List(Of Object)
        Dim campos As New List(Of Object)()

        Try
            Using cmd As New SqlCommand(sConsulta, oConn)
                If oTrans IsNot Nothing Then
                    cmd.Transaction = oTrans
                End If

                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        For i As Integer = 0 To reader.FieldCount - 1
                            campos.Add(reader.GetValue(i))
                        Next
                    End If
                End Using
            End Using
        Catch ex As Exception
            frmMissatge.Mostrar("Error al obtener los campos", ex)
        End Try

        Return campos
    End Function



End Class
