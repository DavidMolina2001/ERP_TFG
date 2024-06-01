Imports System.IO
Imports BarcodeStandard
Imports SkiaSharp
Public Class GeneradorEtiquetas
    Public Shared Function GenerarCodigoBarrasYGuardar(numeroEnvio As String)

        Dim barcode As Barcode = Nothing
        Dim rutaCompleta As String = ""
        Try
            barcode = New Barcode
            barcode.IncludeLabel = True
            Dim img As SKImage = barcode.Encode(Type.Code128, numeroEnvio, SKColors.Black, SKColors.White, 290, 120)

            Dim rutaTemporal As String = clsConstants.PathEtiquetas


            Dim nombreArchivo As String = numeroEnvio & ".png"
            rutaCompleta = Path.Combine(rutaTemporal, nombreArchivo)


            Using fs As New FileStream(rutaCompleta, FileMode.Create)
                img.Encode().SaveTo(fs)
            End Using

            'frmMissatge.MostrarAvis(clsTraductor.RetornaIdiomaSeleccionat("Etiqueta generada correctamente",
            '                                                              "Etiqueta generada correcatament"))



        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al generar el código de barras",
                                                                      "Error al generar el codi de barres"), ex)

        Finally
            If barcode IsNot Nothing Then
                barcode = Nothing
            End If
        End Try
        Return rutaCompleta
    End Function
End Class
