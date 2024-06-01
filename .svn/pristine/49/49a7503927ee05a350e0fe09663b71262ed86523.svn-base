Public Class EstadosEnvios
    Public Enum Estados As Integer
        Recibido = 0
        Preparacion = 1
        Transito = 2
        AlmacenDestino = 3
        Reparto = 4
        Entregado = 5
        Incidencia = 6
    End Enum


    Public Shared Function GetTraduccio(IdEstado As Integer) As String
        Dim estadoTraducido As String = ""

        Select Case IdEstado
            Case Estados.Recibido
                estadoTraducido = fnTraductor.RetornaIdiomaSeleccionat("Recibido", "Rebut")
            Case Estados.Preparacion
                estadoTraducido = fnTraductor.RetornaIdiomaSeleccionat("Preparación", "Preparació")
            Case Estados.Transito
                estadoTraducido = fnTraductor.RetornaIdiomaSeleccionat("Transito", "Trànsit")
            Case Estados.AlmacenDestino
                estadoTraducido = fnTraductor.RetornaIdiomaSeleccionat("Almacén Destino", "Magatzem Destí")
            Case Estados.Reparto
                estadoTraducido = fnTraductor.RetornaIdiomaSeleccionat("Reparto", "Repartiment")
            Case Estados.Entregado
                estadoTraducido = fnTraductor.RetornaIdiomaSeleccionat("Entregado", "Lliurat")
            Case Estados.Incidencia
                estadoTraducido = fnTraductor.RetornaIdiomaSeleccionat("Incidencia", "Incidència")
            Case Else
                estadoTraducido = "Estado no definido"
        End Select

        Return estadoTraducido
    End Function




End Class
