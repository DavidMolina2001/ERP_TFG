Imports System.DirectoryServices

Public Class LDAP

    Private Const DOMINIO As String = "LDAP://192.168.0.32"
    Private Const DOMINIOUSUARIO As String = "LDAPTFG" & "\" & "Administrador"
    Private Const CONTRASENA As String = "Tatun123"


    Public Shared Function AutenticarLDAP() As Boolean

        If Not clsConstants.LDAP Then
            Return False
        End If

        Dim entry As New DirectoryEntry(DOMINIO, DOMINIOUSUARIO, CONTRASENA)

        Dim userName As String = GetUsuario()

        Try
            ' Intenta autenticar el usuario

            Dim obj As Object = entry.NativeObject
            Dim search As New DirectorySearcher(entry)

            search.Filter = "(SAMAccountName=" & userName & ")" 'Esto seria el where
            search.PropertiesToLoad.Add("cn")
            search.PropertiesToLoad.Add("mail") ' Aqui se añaden las propiedades para buscar rollo select


            Dim result As SearchResult = search.FindOne()

            If result IsNot Nothing Then

                Dim cn As String = ""
                If result.Properties.Contains("cn") Then
                    cn = result.Properties("cn")(0).ToString()
                End If

                If result.Properties.Contains("mail") Then
                    cn = result.Properties("mail")(0).ToString()
                End If

                clsSeguretat.Usuari = userName


                Return True
            Else
                Return False
            End If


        Catch ex As Exception
            Return False
        End Try

    End Function

    Private Shared Function GetUsuario()
        Dim userName As Object = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString 'Nombre del pc 
        Dim usernameParts() As String = userName.Split("\")
        Dim usernameB As String = usernameParts(usernameParts.Length - 1)

        Return usernameB
    End Function

End Class
