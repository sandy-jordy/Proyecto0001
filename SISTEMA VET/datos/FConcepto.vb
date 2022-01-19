Imports System.Data.SqlClient
Public Class FConcepto
    Inherits conexion
    Dim cmd As New SqlCommand
    Public Function mostrar_Concepto() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("SP_mostrar_concepto")
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

    Public Function insertar_asistencia(ByVal dts As vAsistencia) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("SP_insertar_asistencia")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_asistencia", dts.Id_asistencia1)
            cmd.Parameters.AddWithValue("@id_empleado", dts.Id_empleado1)
            cmd.Parameters.AddWithValue("@id_concepto", dts.Id_concepto1)

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

    Public Function editar_empleado(ByVal dts As vEmpleado) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("SP_editar_empleado")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_empleado", dts.Id_empleado1)
            cmd.Parameters.AddWithValue("@primer_n", dts.Primer_nombre1)
            cmd.Parameters.AddWithValue("@segundo_n", dts.Segundo_nombre1)
            cmd.Parameters.AddWithValue("@pri_apellido", dts.Primer_apellido1)
            cmd.Parameters.AddWithValue("@seg_apellido", dts.Segundo_apellido1)
            cmd.Parameters.AddWithValue("@fecha_ingreso", dts.Fecha_ingreso1)
            cmd.Parameters.AddWithValue("@id_cargo", dts.Id_cargo1)
            cmd.Parameters.AddWithValue("@estado", dts.Estado1)
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
