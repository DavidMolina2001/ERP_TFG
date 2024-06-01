Public Class GeneradorEnvios

    Private lstEstados As List(Of Integer)
    Private lstClientes As List(Of Integer)
    Private dicRutas As Dictionary(Of Integer, List(Of String))

    Public Sub New(_lstEstados As List(Of Integer), _lstClientes As List(Of Integer), _lstRutas As Dictionary(Of Integer, List(Of String)))
        Me.lstEstados = _lstEstados
        Me.lstClientes = _lstClientes
        Me.dicRutas = _lstRutas

    End Sub


    Public Sub GenerarEnvio(ByRef row As DataRow, sEnvio As String)
        Dim rnd As New Random()
        Try
            Dim iRuta As Integer = dicRutas.Keys.ElementAt(rnd.Next(dicRutas.Count))
            row("CodigoSeguimiento") = sEnvio
            row("DireccionOrigen") = "Calle Falsa " & rnd.Next(1, 1000)
            row("PoblacionDestino") = dicRutas(iRuta)(rnd.Next(dicRutas(iRuta).Count))
            row("CodigoPostalDestino") = rnd.Next(10000, 99999).ToString()
            row("NombreDestinatario") = "Nombre " & rnd.Next(1, 100)
            row("IdEstado") = lstEstados(rnd.Next(lstEstados.Count))
            row("DireccionDestino") = "Calle Verdadera " & rnd.Next(1, 1000)
            row("Peso") = Math.Round(rnd.NextDouble() * 100, 2)
            row("Dimensiones") = rnd.Next(10, 100).ToString() & "x" & rnd.Next(10, 100).ToString() & "x" & rnd.Next(10, 100).ToString()
            row("CodigoCliente") = lstClientes(rnd.Next(lstClientes.Count))
            row("Porte") = Math.Round(rnd.NextDouble() * 100, 2)
            row("EmailDestinatario") = "email" & rnd.Next(1, 1000) & "@example.com"
            row("IdRuta") = iRuta

        Catch ex As Exception
            Throw New Exception("Error: GenerarEnvio", ex)
        End Try
    End Sub


End Class
