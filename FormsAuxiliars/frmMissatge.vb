Public Class frmMissatge
    Dim ex As Exception
    Public Sub Mostrar(ByVal sTextError As String, ByRef _ex As Exception)
        lblError.Text = sTextError

        tbxDescripcio.Text = _ex.ToString
        ex = _ex
        Me.ShowDialog()
    End Sub

    Public Sub MostrarAvis(ByVal sTextAvis As String)
        MsgBox(sTextAvis, MsgBoxStyle.Exclamation, "!!")
        'Me.ShowDialog()
    End Sub

    Public Function MostrarPreguntaSiNo(ByVal sTextAvis As String)
        Return MsgBox(sTextAvis, MsgBoxStyle.YesNo, "!!")
    End Function

    Private Sub btnAcceptar_Click(sender As Object, e As EventArgs) Handles btnAcceptar.Click
        Me.Close()
    End Sub

    Private Sub btnEnviarTicket_Click(sender As Object, e As EventArgs) Handles btnEnviarTicket.Click
        Dim oForm As FormTicket = Nothing
        Try

            oForm = New FormTicket(ex)
            oForm.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub
End Class