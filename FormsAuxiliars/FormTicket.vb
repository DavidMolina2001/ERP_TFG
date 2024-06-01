﻿

Public Class FormTicket

    Private ex As Exception


    Public Sub New(ByVal _ex As Exception)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        ex = _ex

    End Sub

    Private Sub btnEnviarTicket_Click(sender As Object, e As EventArgs) Handles btnEnviarTicket.Click

        If tbxExplicacio.Text = String.Empty Then
            MsgBox(fnTraductor.RetornaIdiomaSeleccionat("Por favor, rellena el campo explicandonos que ha ocurrido.",
                                                             "Sisplau, emplena el camp explicant-nos que ha passat."))
            Exit Sub
        End If





        Try

            Randomize()

            Dim iTicket As Integer = Int((999999 - 100000 + 1) * Rnd() + 100000)

            clsMail.EnviarTicket(iTicket, tbxExplicacio.Text, ex.ToString)

            MessageBox.Show(fnTraductor.RetornaIdiomaSeleccionat("Grácias por reportar el error. Número de Ticket: " & iTicket,
                                                                  "Gràcies per reportar l'error. Número de Ticket: " & iTicket))


            Me.Close()
            Me.Dispose()


        Catch ex As Exception
            Throw New Exception("Error al enviar el mail")
        End Try
    End Sub
End Class