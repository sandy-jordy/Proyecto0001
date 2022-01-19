Imports System.Data.SqlClient
Imports SISTEMA_VET.conexion
Public Class ANTECEDENTE
    Private dt As New DataTable
    Private Sub Btninsertar_Click(sender As Object, e As EventArgs) Handles Btninsertar.Click
        Dim Datos As New Mostrar_Antecedente__vb
        Dim Logica As New VP_Antecedente

        Logica.gNombre = Me.Txtnombre.Text
        Logica.gdescipcion = Me.RichTextBox1.Text
        Logica.gantecedente = Me.TextBox5.Text

        If Datos.finsertarAntecedente(Logica) Then
            MsgBox("Datos ingresados")
            mostrar()
        End If
    End Sub

    Public Sub mostrar()
        Try
            Dim func As New Mostrar_Antecedente__vb
            Dim dt As DataTable = func.mostrar
            Datalistado1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub ANTECEDENTE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()

    End Sub

End Class