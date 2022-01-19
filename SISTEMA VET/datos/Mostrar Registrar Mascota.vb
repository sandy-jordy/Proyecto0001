Imports System.Data.SqlClient
Public Class Mostrar_Registrar_Mascota
    Inherits conexion
    Dim cmd As New SqlCommand
    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("Mostrar_Registrar_Mascota")
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

    Public Function Fininsetarmacota(ByVal dts As VP_Registrar_Mascota) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_Registrar_Mascota")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@raza", dts.graza)
            cmd.Parameters.AddWithValue("@sexo", dts.gsexo)
            cmd.Parameters.AddWithValue("@peso", dts.gpeso)
            cmd.Parameters.AddWithValue("@fecha_nacimiento", dts.gfecha_nacimiento)
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
