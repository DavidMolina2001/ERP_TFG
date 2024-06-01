﻿Imports System.IO
Imports DocumentFormat.OpenXml.Packaging
Imports DocumentFormat.OpenXml.Wordprocessing
Imports Independentsoft.Office.Word


Public Class GenerarFactura

    Public Shared Function GenerarFactura(ByRef dicDatos As Dictionary(Of String, String), ByRef dtLinias As System.Data.DataTable, sCodiIdioma As String)
        Dim outputPath As String = "C:\Users\david\Downloads\Factura-" & dicDatos("IDFACTURA") & "-" & DateTime.Now.ToString("dd-MM-yyyy--HH-mm") & ".docx"

        Try

            'dicDatos.Add("IDFACTURA", oDades.Id)
            'dicDatos.Add("NUMFACTURA", tbxNumFactura.Text)
            'dicDatos.Add("DEMISION", dtpEmision.Value.ToString("dd-MM-yyyy"))
            'dicDatos.Add("DVENCIMIENTO", dtpVencimiento.Value.ToString("dd-MM-yyyy"))
            'dicDatos.Add("NCLIENTE", tbxNombreCliente.Text)
            'dicDatos.Add("DIRCLIENTE", tbxDirCliente.Text)
            'dicDatos.Add("NIFCLIENTE", tbxNifCliente.Text)
            'dicDatos.Add("MAILCLIENTE", tbxMailCliente.Text)
            'dicDatos.Add("OBS", tbxObservaciones.Text)
            Dim templatePath As String

            If sCodiIdioma.StartsWith("C") Then
                templatePath = clsConstants.PathFactCAT

            Else
                templatePath = clsConstants.PathFactCAS

            End If



            Dim fechaReemplazo As String = DateTime.Now.ToString("dd/MM/yyyy")

            File.Copy(templatePath, outputPath, True)

            Using wordDoc As WordprocessingDocument = WordprocessingDocument.Open(outputPath, True)
                Dim docPart As MainDocumentPart = wordDoc.MainDocumentPart
                Dim body As DocumentFormat.OpenXml.Wordprocessing.Body = docPart.Document.Body

                Dim iTotalEnvios As Decimal = 0.0
                Dim iTotalEnviosImpuesto As Decimal = 0.0

                RellenarLinias(docPart, dtLinias, iTotalEnvios, iTotalEnviosImpuesto)

                RellenarDatos(body, dicDatos, iTotalEnvios, iTotalEnviosImpuesto)


                docPart.Document.Save()

                wordDoc.Dispose()
            End Using






        Catch ex As Exception
            Throw New Exception("Error: GenerarFactura", ex)
        End Try

        Return outputPath

    End Function


    Private Shared Sub RellenarLinias(docPart As MainDocumentPart, dtLinias As DataTable, ByRef iTotalEnvios As Decimal, ByRef iTotalEnviosImpuesto As Decimal)
        Dim tables As IEnumerable(Of Table) = docPart.Document.Body.Descendants(Of Table)()
        Dim primeraTabla As Table = tables(1)

        If primeraTabla IsNot Nothing Then
            Dim templateRow As TableRow = primeraTabla.Elements(Of TableRow)().Skip(1).FirstOrDefault()

            If templateRow IsNot Nothing Then
                For Each linea As DataRow In dtLinias.Rows
                    Dim newRow As TableRow = templateRow.CloneNode(True)

                    For Each textElement As DocumentFormat.OpenXml.Wordprocessing.Text In newRow.Descendants(Of DocumentFormat.OpenXml.Wordprocessing.Text)()
                        If textElement.Text.Contains("«NENVIAMENT»") Then
                            textElement.Text = linea("CodigoSeguimiento").ToString()

                        ElseIf textElement.Text.Contains("«ENVDESC»") Then
                            textElement.Text = linea("Descripcion").ToString()

                        ElseIf textElement.Text.Contains("«PREUENV»") Then
                            iTotalEnvios += System.Math.Round(linea("Porte"), 2)
                            textElement.Text = System.Math.Round(linea("Porte"), 2).ToString() & "€"

                        ElseIf textElement.Text.Contains("«IVA»") Then
                            textElement.Text = linea("Porcentaje").ToString() & "%"

                        ElseIf textElement.Text.Contains("«PREUTOTAL»") Then
                            iTotalEnviosImpuesto += System.Math.Round((linea("Porte") + (linea("Porte") * linea("Porcentaje")) / 100), 2)

                            textElement.Text = System.Math.Round((linea("Porte") + (linea("Porte") * linea("Porcentaje")) / 100), 2).ToString() & "€"

                        End If
                    Next

                    primeraTabla.InsertAfter(newRow, templateRow)
                Next

                primeraTabla.RemoveChild(templateRow)
            Else
                Throw New Exception("Error GenerarFactura. BAD PL")
            End If
        Else
            Throw New Exception("Error GenerarFactura. BAD PL")

        End If
    End Sub

    Private Shared Sub RellenarDatos(body As DocumentFormat.OpenXml.Wordprocessing.Body, dicDatos As Dictionary(Of String, String), iTotalEnvios As Decimal, iTotalEnviosImpuesto As Decimal)
        For Each textElement As DocumentFormat.OpenXml.Wordprocessing.Text In body.Descendants(Of DocumentFormat.OpenXml.Wordprocessing.Text)()
            If textElement.Text.Contains("«DATA»") Then
                textElement.Text = dicDatos("DEMISION")

            End If

            If textElement.Text.Contains("«NFACTURA»") Then
                textElement.Text = dicDatos("NUMFACTURA")

            End If

            If textElement.Text.Contains("«NOMCLIENT»") Then
                textElement.Text = dicDatos("NCLIENTE")

            End If

            If textElement.Text.Contains("«DIRCLIENT»") Then
                textElement.Text = dicDatos("DIRCLIENTE")

            End If

            If textElement.Text.Contains("«NIFCLIENT»") Then
                textElement.Text = dicDatos("NIFCLIENTE")

            End If

            If textElement.Text.Contains("«MAILCLIENTE»") Then
                textElement.Text = dicDatos("MAILCLIENTE")

            End If

            If textElement.Text.Contains("«OBSERVACIONESCLIENTE»") Then
                textElement.Text = dicDatos("OBS")

            End If

            If textElement.Text.Contains("«FECHAVENCIMIENTO»") Then
                textElement.Text = dicDatos("DVENCIMIENTO")

            End If

            If textElement.Text.Contains("«TOTALSI»") Then
                textElement.Text = System.Math.Round(iTotalEnvios, 2).ToString & "€"

            End If

            If textElement.Text.Contains("«TOTALCI»") Then
                textElement.Text = iTotalEnviosImpuesto.ToString & "€"

            End If

            If textElement.Text.Contains("«TOTALT»") Then
                textElement.Text = (iTotalEnviosImpuesto + 2.45).ToString & "€"


            End If


        Next
    End Sub
End Class
