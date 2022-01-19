Imports System.Data.SqlClient
Public Class frmAsistencia
    Private Btn As DataGridViewButtonColumn = New DataGridViewButtonColumn()
    Private Sub frmAsistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Ancho_pantalla As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim Alto_pantalla As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim ancho As Integer = Ancho_pantalla - Me.Width
        Dim alto As Integer = Alto_pantalla - Me.Height
        Me.Location = New Point(ancho \ 2, alto \ 2)
        'Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CargarLista_asistencia()
        dgvDatos.Columns.Item("Eliminar").Visible = False
        dgvDatos.Columns.Item("id_empleado").Visible = False
        Btn.Text = "Boton"
        Btn.HeaderText = "Cargar asistencia"
        Btn.Name = "btnAgregar"
        dgvDatos.Columns.Insert(6, Btn)

        carga()


    End Sub
    Public Sub CargarLista_asistencia()
        Dim func As New FEmpleado
        Dim func1 As New FCargo
        Dim dt As DataTable = func.mostrar_empleado_activo()
        'dgvDatos.Columns.Add(Btn)

        Try

            If dt.Rows.Count <> 0 Then
                dgvDatos.DataSource = dt
                dgvDatos.ColumnHeadersVisible = True

                'dgvDatos.Columns.Item("id_cargo").Visible = False

            Else
                'si no hay registros entonces no mostramos nada y mostramos el mensaje de datos inexistentes y ocultamos las columas
                dgvDatos.DataSource = Nothing
                dgvDatos.ColumnHeadersVisible = False
            End If




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub carga()
        'MessageBox.Show("sdfsdfdsfds")
        If Me.dgvDatos.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In Me.dgvDatos.Rows
                If Not Fila Is Nothing Then
                    If Convert.ToString(Fila.Cells("fecha_asis").Value) <> "" Then
                        'If Convert.ToString(Fila.Cells("id_empleado").Value) = Fila.Cells("id_empleado").Value Then
                        'MessageBox.Show(Convert.ToString(Fila.Cells("id_empleado").Value))
                        'MessageBox.Show(Fila.Cells("id_empleado").ColumnIndex.ToString() + " " + Fila.Cells("id_empleado").RowIndex.ToString())

                        Dim bb1 As DataGridViewCheckBoxCell = Me.dgvDatos.Rows(Fila.Cells("id_empleado").RowIndex).Cells("Eliminar")
                        Me.dgvDatos.Rows(Fila.Cells("id_empleado").RowIndex).Cells("Eliminar").Value = True
                        'Not (Convert.ToBoolean(bb1.Value))
                        'End If
                    End If
                End If
            Next
        End If
    End Sub

    Public codigo As String
    Private Sub dgvDatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellContentClick
        'Dim a As String = e.ColumnIndex.ToString + " " + dgvDatos.Columns("comboBoxColumn").Index.ToString
        'MessageBox.Show(a)
        If (dgvDatos.SelectedRows.Count > 0) Then
            'If (e.ColumnIndex = dgvDatos.Columns.Item("Eliminar").Index) Then
            'Dim bb As DataGridViewCheckBoxCell = dgvDatos.Rows(e.RowIndex).Cells("Eliminar")
            'bb.Value = Not (Convert.ToBoolean(bb.Value))
            'End If

            Dim bb1 As DataGridViewCheckBoxCell = dgvDatos.Rows(e.RowIndex).Cells("Eliminar")
            'bb1.Value = Not (Convert.ToBoolean(bb1.Value))-

            'If ((e.ColumnIndex = dgvDatos.Columns.Item("btnAgregar").Index) And (Convert.ToBoolean(bb1.Value) = False)) Then
            If ((e.ColumnIndex = dgvDatos.Columns.Item("btnAgregar").Index) And (Convert.ToString(dgvDatos.Rows(e.RowIndex).Cells("fecha_asis").Value) = "")) Then
                'Dim bb As DataGridViewButtonCell = dgvDatos.Rows(e.RowIndex).Cells("btnAgregar")
                'And (Convert.ToBoolean(bb1.Value) = False)
                'MessageBox.Show((Convert.ToBoolean(bb1.Value)))
                'MessageBox.Show(dgvDatos.CurrentRow.Cells(2).Value.ToString())
                Dim frm As New frmEmpleado_Asistencia

                AddOwnedForm(frm)
                frm.id_empleado.Text = dgvDatos.CurrentRow.Cells(2).Value.ToString()
                frm.Fecha_asistencia.Text = DateTime.Now.ToString("yyyy-MM-dd").ToString()
                frm.id_empleado.Visible = False
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
                frm.ShowDialog()
            End If
        Else
                MessageBox.Show("Por favor seleccione una fila...")
        End If


    End Sub
End Class