Imports System.Security.Cryptography
Imports System.Text

Public Class clsSeguretat

    Public Const PC_DAVID As String = "DESKTOP-SEL5MT6"

    Friend Shared Usuari As String

    'ADMIN ADMIN123

    Friend Shared Function Encriptar(password As String) As String

        Dim passwordBytes As Byte() = Encoding.UTF8.GetBytes(password)


        Using sha256 As SHA256 = SHA256.Create()

            Dim hashedBytes As Byte() = sha256.ComputeHash(passwordBytes)


            Dim hashedString As String = BitConverter.ToString(hashedBytes).Replace("-", "")

            Return hashedString
        End Using
    End Function


    Friend Shared Function VerificarContra(usuari As String, password As String) As Boolean

        Dim hashedInput As String = Encriptar(password)
        Dim bCorrecta As Boolean = False

        Try
            Dim sHashed As String = SQLReader.ObtenirUnCamp(clsConstants.ConnGlobal, Nothing, "SELECT PasswordUsuari FROM Usuaris WITH (NOLOCK) WHERE CodiUsuari = '" & usuari & "'")

            If sHashed IsNot Nothing And sHashed IsNot String.Empty Then
                bCorrecta = String.Equals(hashedInput, sHashed, StringComparison.OrdinalIgnoreCase)

                If bCorrecta Then
                    clsSeguretat.Usuari = usuari
                End If
            End If

        Catch ex As Exception
            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al comprobar la contraseña",
                                                                      "Error al comprovar la contrasenya"), ex)
        End Try


        Return bCorrecta
    End Function


End Class
