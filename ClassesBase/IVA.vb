Public Class IVA
    Public Enum Tipo As Integer
        General = 0
        Reducido = 1
        Superreducido = 2
        Exento = 3
        Especial = 4
    End Enum


    Public Shared Function GetTraduccio(IdEstado As Integer) As String
        Dim estadoTraducido As String = ""

        Select Case IdEstado
            Case Tipo.General
                estadoTraducido = fnTraductor.RetornaIdiomaSeleccionat("IVA general", "IVA general")
            Case Tipo.Reducido
                estadoTraducido = fnTraductor.RetornaIdiomaSeleccionat("IVA reducido", "IVA reduït")
            Case Tipo.Superreducido
                estadoTraducido = fnTraductor.RetornaIdiomaSeleccionat("IVA superreducido", "IVA superreduït")
            Case Tipo.Exento
                estadoTraducido = fnTraductor.RetornaIdiomaSeleccionat("IVA exento", "IVA sense IVA")
            Case Tipo.Especial
                estadoTraducido = fnTraductor.RetornaIdiomaSeleccionat("Impuesto especial", "Impost especial")
            Case Else
                estadoTraducido = "Tipo no definido"
        End Select

        Return estadoTraducido
    End Function




End Class
