Imports System.Data.SqlClient
Public Class Mostrar_Cliente
    Inherits conexion
    Dim cmd As New SqlCommand
    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("Mostrar_Clientes")
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

    Public Function Fininsetarcliente(ByVal dts As VP_Clientes) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_Registrar_Cliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@nombres", dts.gnombre)
            cmd.Parameters.AddWithValue("@apellidos", dts.gapellido)
            cmd.Parameters.AddWithValue("@direccion", dts.gDireccion)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)
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
