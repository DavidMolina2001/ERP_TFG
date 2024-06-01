Public Interface IRecord
    Sub Llegir(ByVal sId As String)
    Sub Escriure(ByVal bEsAlta As Boolean)


    Function Esborrar() As Boolean

    Property Id As String
    Property NOM_TAULA As String

    Property NOM_PK As String

End Interface
