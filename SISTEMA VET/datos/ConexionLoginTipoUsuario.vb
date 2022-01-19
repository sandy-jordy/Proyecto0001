Imports System.Data.Sql
Imports System.Data.SqlClient
Module ConexionLoginTipoUsuario
    Public cnn As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader
    Sub abrir()
        Try
            cnn = New SqlConnection("data source=DESKTOP-0A8S1EG\SQLEXPRESS;initial catalog=CLINICA_VETERINARIA;Integrated Security=True")
            cnn.Open()
        Catch ex As Exception
            MsgBox("No se pudo conectar" + ex.ToString)
        End Try
    End Sub

    Function usuarioRegistrado(ByVal nombreUsuario As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enunciado = New SqlCommand("Select * from usuario where usuario='" & nombreUsuario & "'", cnn)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Function contrasena(ByVal nombreUsuario As String) As String
        Dim resultado As String = ""
        Try
            enunciado = New SqlCommand("Select Contrasena from usuario where usuario='" & nombreUsuario & "'", cnn)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = respuesta.Item("Contrasena")
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Function ConsultarTipoUsuario(ByVal nombreUsuario As String) As Integer
        Dim resultado As Integer
        Try
            enunciado = New SqlCommand("Select IdTipoUsuario from usuario where usuario='" & nombreUsuario & "'", cnn)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = CInt(respuesta.Item("IdTipoUsuario"))
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
End Module

