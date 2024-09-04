Imports System.Net
Imports System.Net.Http
Imports Newtonsoft.Json.Linq
Public Class CalculadorTarifas

    Public Shared DIR_ORIGEN As String = "Carrer de Maria Aurèlia Capmany i Farnés, 61, 17003 Girona"

    Private Const apiKey As String = "AIzaSyAXnasJVItYof46mQ7ZMLUZmpx9PYi04lo"

    Public Enum Tarifas
        U24 = 0
        U12 = 1
        U10 = 2
        INTERNACIONAL = 3
        CANARIAS = 4
        NORMAL = 5
    End Enum

    Friend Shared Async Function getDistancia(sOrigen As String, sDestino As String) As Task(Of Decimal)
        Dim dDistancia As Decimal = 0.0

        Dim url As String = $"https://maps.googleapis.com/maps/api/distancematrix/json?units=metric&origins={WebUtility.UrlEncode(sOrigen)}&destinations={WebUtility.UrlEncode(sDestino)}&key={apiKey}"

        Try
            Using client As New HttpClient()
                Dim response As HttpResponseMessage = Await client.GetAsync(url)
                response.EnsureSuccessStatusCode()
                Dim json As String = Await response.Content.ReadAsStringAsync()
                Dim data As JObject = JObject.Parse(json)
                Dim distanceValue As Integer = Integer.Parse(data("rows")(0)("elements")(0)("distance")("value").ToString())
                dDistancia = Convert.ToDecimal(distanceValue) / 1000
            End Using
        Catch ex As Exception
            Throw New Exception("CalculadorTarifas: Error al calcular la distancia.")
        End Try

        Return dDistancia
    End Function
End Class
