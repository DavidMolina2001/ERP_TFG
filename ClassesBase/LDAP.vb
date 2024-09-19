Imports System.DirectoryServices
Imports System.DirectoryServices.Protocols

Public Class LDAP

    Private Const DOMINIO As String = "LDAP://localhost"
    Private Const DOMINIOUSUARIO As String = "TFG" & "\" & "Administrador"
    Private Const CONTRASENA As String = "Xarxes1234!"


    'Public Shared Function AutenticarLDAP() As Boolean


    '    Dim bLogin As Boolean = False
    '    If Not clsConstants.LDAP Then
    '        Return False
    '    End If

    '    Dim entry As New DirectoryEntry(DOMINIO, DOMINIOUSUARIO, CONTRASENA)

    '    Dim userName As String = GetUsuario()


    '    Try

    '        Dim obj As Object = entry.NativeObject
    '        Dim search As New DirectorySearcher(entry)

    '        search.Filter = "(SAMAccountName=" & userName & ")"
    '        search.PropertiesToLoad.Add("cn")


    '        Dim result As SearchResult = search.FindOne()

    '        If result IsNot Nothing Then

    '            Dim cn As String = ""
    '            If result.Properties.Contains("cn") Then
    '                cn = result.Properties("cn")(0).ToString()

    '                If cn = userName Then
    '                    clsSeguretat.Usuari = userName

    '                    bLogin = True
    '                Else
    '                    bLogin = False
    '                End If
    '            End If


    '            bLogin = True
    '        Else

    '            bLogin = False
    '        End If


    '    Catch ex As Exception
    '        bLogin = False
    '    End Try
    '    Return bLogin
    'End Function

    Public Shared Function AutenticarLDAP() As Boolean
        Dim bLogin As Boolean = False

        If Not clsConstants.LDAP Then
            Return False
        End If

        Dim entry As New DirectoryEntry(DOMINIO, DOMINIOUSUARIO, CONTRASENA)
        Dim userName As String = GetUsuario()

        Try
            Dim obj As Object = entry.NativeObject
            Dim search As New DirectorySearcher(entry)

            search.Filter = "(SAMAccountName=" & userName & ")"
            search.PropertiesToLoad.Add("cn")
            search.PropertiesToLoad.Add("memberOf")

            Dim result As SearchResult = search.FindOne()

            If result IsNot Nothing Then
                Dim cn As String = ""
                If result.Properties.Contains("cn") Then
                    cn = result.Properties("cn")(0).ToString()

                    If cn = userName Then
                        If result.Properties.Contains("memberOf") Then
                            For Each group As String In result.Properties("memberOf")
                                If group.Contains("CN=Administradors") Then
                                    clsSeguretat.Usuari = "ADMIN"
                                    bLogin = True
                                    Exit For
                                ElseIf group.Contains("CN=Administratius") Then
                                    clsSeguretat.Usuari = userName
                                    bLogin = True
                                End If
                            Next
                        End If
                    Else
                        bLogin = False
                    End If
                End If
            Else
                bLogin = False
            End If

        Catch ex As Exception
            bLogin = False
        End Try
        Return bLogin
    End Function


    Private Shared Function GetUsuario()
        Dim userName As Object = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString 'Nombre del pc 
        Dim usernameParts() As String = userName.Split("\")
        Dim usernameB As String = usernameParts(usernameParts.Length - 1)

        Return usernameB
    End Function

End Class
