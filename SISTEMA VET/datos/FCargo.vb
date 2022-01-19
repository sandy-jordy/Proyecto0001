Imports System.Data.SqlClient
Public Class FCargo
    Inherits conexion
    Dim cmd As New SqlCommand
    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("SP_Mostrar_cargo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function insertar_cargo(ByVal dts As vCargo) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("SP_insertar_cargo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_cargo", dts.Id_Cargo1)
            cmd.Parameters.AddWithValue("@Nombre_cargo", dts.Nombre_cargo1)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function editar_cargo(ByVal dts As vCargo) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("SP_editar_cargo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_cargo", dts.Id_Cargo1)
            cmd.Parameters.AddWithValue("@Nombre_cargo", dts.Nombre_cargo1)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
End Class
