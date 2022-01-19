Imports System.Data.SqlClient
Imports SISTEMA_VET.conexion

Public Class CARGO
    Private dt As New DataTable
    Private Sub Btninsertar_Click(sender As Object, e As EventArgs) Handles Btninsertar.Click
        Dim Datos As New Mostrar_Cargo
        Dim Logica As New VP_Cargo

        Logica.gTipo_de_cargo = Me.Txttipodecargo.Text
        Logica.gCodigo = Me.TextBox3.Text


        If Datos.FinsertarCargo(Logica) Then
            MsgBox("Datos ingresados")
            mostrar()
        End If
    End Sub

    Public Sub mostrar()
        Try
            Dim func As New Mostrar_Cargo
            Dim dt As DataTable = func.mostrar
            Datalistado2.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub CARGO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()

    End Sub
End Class