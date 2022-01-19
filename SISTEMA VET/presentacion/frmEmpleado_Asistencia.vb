Public Class frmEmpleado_Asistencia
    Private Sub frmEmpleado_Asistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargarconcepto()
    End Sub
    Public Sub Cargarconcepto()

        Dim func As New FConcepto

        Dim dt As DataTable = func.mostrar_Concepto
        cboConcepto.DataSource = dt
        cboConcepto.DisplayMember = "Concepto"
        cboConcepto.ValueMember = "id_concepto"
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And
            id_empleado.Text <> "" Then

            Try

                Dim dts As New vAsistencia
                Dim func As New FConcepto

                dts.Id_empleado1 = id_empleado.Text.Trim()
                dts.Id_concepto1 = cboConcepto.SelectedIndex + 1

                If func.insertar_asistencia(dts) Then
                    MessageBox.Show("Proveedor registrado correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim frm As frmAsistencia = CType(Owner, frmAsistencia)
                    frm.CargarLista_asistencia()
                    Me.Close()
                    'mostrar()

                Else
                    MessageBox.Show("Proveedor no fue registrado intente de nuevo", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'mostrar()
                    Dim frm As frmAsistencia = CType(Owner, frmAsistencia)
                    frm.CargarLista_asistencia()
                    Me.Close()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class