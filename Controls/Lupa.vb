﻿Imports System.Reflection.Emit
Imports System.Windows.Forms

Partial Public Class Lupa

    Public Property uCampBD1 As String
    Public Property uCampBD2 As String
    Public Property uCampBD3 As String
    Public Property uCampBD4 As String
    Public Property uCampBD5 As String
    Public Property uCampBD6 As String
    Public Property uCampBD7 As String


    Public Property utbxCamp1 As TextBox
    Public Property utbxCamp2 As TextBox
    Public Property utbxCamp3 As TextBox
    Public Property utbxCamp4 As TextBox
    Public Property utbxCamp5 As TextBox
    Public Property utbxCamp6 As TextBox
    Public Property utbxCamp7 As TextBox

    Public Property uObjRecord As BDRecord

    Public Property _Valor() As Object
        Get
            Return TextBox1.Text
        End Get
        Set(ByVal value As Object)
            TextBox1.Text = IIf(IsDBNull(value) Or IsNothing(value), String.Empty, value)
        End Set
    End Property


    Public Sub New()
        InitializeComponent()

    End Sub

    Private Sub Emplenar_Camps()

        Dim oForm As frmLlistat = Nothing
        Dim ltResultats As List(Of Object) = Nothing

        Try
            oForm = New frmLlistat(clsConstants.ConnGlobal, uObjRecord, uObjRecord.Seleccionar_Consulta(0), Nothing, fnTraductor.RetornaIdiomaSeleccionat("Selecciona un registro", "Selecciona un registre"), True, False)
            oForm.TryLoad()
            oForm.TopLevel = True
            oForm.BringToFront()


            If oForm.ShowDialog() = DialogResult.OK Then

                Dim sSelect As String = getSelect()

                ltResultats = SQLReader.ObtenerUnaFila(clsConstants.ConnGlobal, Nothing, "SELECT " & sSelect & " FROM " & uObjRecord.NOM_TAULA & " WHERE " & uObjRecord.NOM_PK & " = " & oForm.IdSeleccionat)

                If ltResultats IsNot Nothing AndAlso ltResultats.Count > 0 Then
                    EmplenarControlsFormPare(ltResultats)
                    TextBox1.Text = oForm.IdSeleccionat
                End If

            End If



        Catch ex As Exception

            frmMissatge.Mostrar(fnTraductor.RetornaIdiomaSeleccionat("Error al mostrar los registros",
                                                                   "Error al mostrar els registres"), ex)
        Finally
            If oForm IsNot Nothing Then
                oForm.Dispose()
                oForm = Nothing
            End If
            If ltResultats IsNot Nothing Then
                ltResultats.Clear()
                ltResultats = Nothing
            End If
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Emplenar_Camps()


    End Sub

    Private Function getSelect()
        Dim sRes As String = ""


        If uCampBD1 <> String.Empty Then
            sRes &= uCampBD1 & ", "
        End If

        If uCampBD2 <> String.Empty Then
            sRes &= uCampBD2 & ", "
        End If

        If uCampBD3 <> String.Empty Then
            sRes &= uCampBD3 & ", "
        End If

        If uCampBD4 <> String.Empty Then
            sRes &= uCampBD4 & ", "
        End If

        If uCampBD5 <> String.Empty Then
            sRes &= uCampBD5 & ", "
        End If

        If uCampBD6 <> String.Empty Then
            sRes &= uCampBD6 & ", "
        End If

        If uCampBD7 <> String.Empty Then
            sRes &= uCampBD7 & ", "
        End If

        If sRes.EndsWith(", ") Then
            sRes = sRes.TrimEnd(", ".ToCharArray())
        End If

        Return sRes
    End Function

    Private Sub EmplenarControlsFormPare(ByRef ltResultats As List(Of Object))
        Try
             Dim controlTbxCamp1 As TextBox
            If utbxCamp1 IsNot Nothing Then
                controlTbxCamp1 = Me.ParentForm.Controls.Find(utbxCamp1.Name, True).FirstOrDefault()

                If controlTbxCamp1 IsNot Nothing AndAlso TypeOf controlTbxCamp1 Is TextBox Then
                    DirectCast(controlTbxCamp1, TextBox).Text = ltResultats(0).ToString()
                End If
            End If

            If utbxCamp2 IsNot Nothing Then
                controlTbxCamp1 = Me.ParentForm.Controls.Find(utbxCamp2.Name, True).FirstOrDefault()

                If controlTbxCamp1 IsNot Nothing AndAlso TypeOf controlTbxCamp1 Is TextBox Then
                    DirectCast(controlTbxCamp1, TextBox).Text = ltResultats(1).ToString()
                End If
            End If

            If utbxCamp3 IsNot Nothing Then
                controlTbxCamp1 = Me.ParentForm.Controls.Find(utbxCamp3.Name, True).FirstOrDefault()

                If controlTbxCamp1 IsNot Nothing AndAlso TypeOf controlTbxCamp1 Is TextBox Then
                    DirectCast(controlTbxCamp1, TextBox).Text = ltResultats(2).ToString()
                End If
            End If

            If utbxCamp4 IsNot Nothing Then
                controlTbxCamp1 = Me.ParentForm.Controls.Find(utbxCamp4.Name, True).FirstOrDefault()

                If controlTbxCamp1 IsNot Nothing AndAlso TypeOf controlTbxCamp1 Is TextBox Then
                    DirectCast(controlTbxCamp1, TextBox).Text = ltResultats(3).ToString()
                End If
            End If

            If utbxCamp5 IsNot Nothing Then
                controlTbxCamp1 = Me.ParentForm.Controls.Find(utbxCamp5.Name, True).FirstOrDefault()

                If controlTbxCamp1 IsNot Nothing AndAlso TypeOf controlTbxCamp1 Is TextBox Then
                    DirectCast(controlTbxCamp1, TextBox).Text = ltResultats(4).ToString()
                End If
            End If

            If utbxCamp6 IsNot Nothing Then
                controlTbxCamp1 = Me.ParentForm.Controls.Find(utbxCamp6.Name, True).FirstOrDefault()

                If controlTbxCamp1 IsNot Nothing AndAlso TypeOf controlTbxCamp1 Is TextBox Then
                    DirectCast(controlTbxCamp1, TextBox).Text = ltResultats(5).ToString()
                End If
            End If

            If utbxCamp7 IsNot Nothing Then
                controlTbxCamp1 = Me.ParentForm.Controls.Find(utbxCamp7.Name, True).FirstOrDefault()

                If controlTbxCamp1 IsNot Nothing AndAlso TypeOf controlTbxCamp1 Is TextBox Then
                    DirectCast(controlTbxCamp1, TextBox).Text = ltResultats(6).ToString()
                End If
            End If




        Catch ex As Exception
            Throw New Exception("Lupa.EmplenarControlsFormPare")
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'Emplenar_Camps()
        Dim ltResultats As List(Of Object) = Nothing

        Try
            Dim sSelect As String = getSelect()

            ltResultats = SQLReader.ObtenerUnaFila(clsConstants.ConnGlobal, Nothing, "SELECT " & sSelect & " FROM " & uObjRecord.NOM_TAULA & " WHERE " & uObjRecord.NOM_PK & " = " & TextBox1.Text)

            If ltResultats IsNot Nothing AndAlso ltResultats.Count > 0 Then
                EmplenarControlsFormPare(ltResultats)
            End If
        Catch ex As Exception
            Throw New Exception("Lupa.TextBox1_TextChanged")

        Finally

            If ltResultats IsNot Nothing Then
                ltResultats.Clear()
                ltResultats = Nothing
            End If
        End Try
    End Sub
End Class
