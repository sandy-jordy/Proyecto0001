Public Class frmEmpleado
    Private Sub frmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Ancho_pantalla As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim Alto_pantalla As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim ancho As Integer = Ancho_pantalla - Me.Width
        Dim alto As Integer = Alto_pantalla - Me.Height
        Me.Location = New Point(ancho \ 2, alto \ 2)

        rb1.Checked = True
        CargarCargo()
        mostrar()
        Label3.Visible = False
    End Sub

    Public Sub CargarCargo()

        Dim func As New FCargo

        Dim dt As DataTable = func.mostrar()
        cboCargo.DataSource = dt
        cboCargo.DisplayMember = "Nombre_cargo"
        cboCargo.ValueMember = "id_cargo"
    End Sub
    Private Sub mostrar()
        Try
            'instanciamos la clase fusuario y llamamos a la funcion mostrar usuarios
            Dim func As New FEmpleado
            Dim dt As New DataTable
            dt = func.mostrar_empleado()
            'ocultamos la columna donde aparece el check de eliminacion
            dgvDatos.Columns.Item("Eliminar").Visible = False


            'si hay registros entonces llenamos la lista con los registros, mostramos las columas del datagridview datalistado
            If dt.Rows.Count <> 0 Then
                dgvDatos.DataSource = dt
                dgvDatos.ColumnHeadersVisible = True
                dgvDatos.Columns.Item("id_empleado").Visible = False
                dgvDatos.Columns.Item("id_cargo").Visible = False
            Else
                'si no hay registros entonces no mostramos nada y mostramos el mensaje de datos inexistentes y ocultamos las columas
                dgvDatos.DataSource = Nothing
                dgvDatos.ColumnHeadersVisible = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'ocultamos y mostramos los botones correspondientes
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        btnEditar.Enabled = True
        btnGuardar.Enabled = False

        If Me.ValidateChildren = True And
            txtPNombre.Text <> "" And txtSNombre.Text <> "" And txtPapellido.Text <> "" And
            txtSapellido.Text <> "" Then

            Try

                Dim dts As New vEmpleado
                Dim func As New FEmpleado
                dts.Primer_nombre1 = txtPNombre.Text.Trim()
                dts.Segundo_nombre1 = txtSNombre.Text.Trim()
                dts.Primer_apellido1 = txtPapellido.Text.Trim()
                dts.Segundo_apellido1 = txtSapellido.Text.Trim()
                dts.Fecha_ingreso1 = fecha_ingreso.Text
                dts.Id_cargo1 = cboCargo.SelectedIndex + 1

                Dim estado_ As String
                estado_ = ""
                If rb1.Checked Then
                    estado_ = "Activo"
                ElseIf rb2.Checked Then
                    estado_ = "Inactivo"
                End If

                dts.Estado1 = estado_.Trim


                If func.insertar_empleado(dts) Then
                    MessageBox.Show("Proveedor registrado correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()

                Else
                    MessageBox.Show("Proveedor no fue registrado intente de nuevo", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtPNombre.Text = ""
        txtSNombre.Text = ""
        txtPapellido.Text = ""
        txtSapellido.Text = ""
        Label3.Text = Nothing
        btnEditar.Enabled = False
        btnGuardar.Enabled = True
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea editar los datos del empleado?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And Label3.Text <> "" And txtPNombre.Text <> "" And txtSNombre.Text <> "" And txtPapellido.Text <> "" And
            txtSapellido.Text <> "" Then
                Try
                    Dim dts As New vEmpleado
                    Dim func As New FEmpleado
                    dts.Id_empleado1 = Label3.Text
                    dts.Primer_nombre1 = txtPNombre.Text.Trim()
                    dts.Segundo_nombre1 = txtSNombre.Text.Trim()
                    dts.Primer_apellido1 = txtPapellido.Text.Trim()
                    dts.Segundo_apellido1 = txtSapellido.Text.Trim()
                    dts.Fecha_ingreso1 = fecha_ingreso.Text
                    dts.Id_cargo1 = cboCargo.SelectedIndex + 1
                    Dim estado_ As String
                    estado_ = ""
                    If rb1.Checked Then
                        estado_ = "Activo"
                    ElseIf rb2.Checked Then
                        estado_ = "Inactivo"
                    End If

                    dts.Estado1 = estado_.Trim

                    If func.editar_empleado(dts) Then
                        MessageBox.Show("Proveedor Modificado correctamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()

                    Else
                        MessageBox.Show("Proveedor no fue modifcado intente de nuevo", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()

                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Falta ingresar algunos datos", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub dgvDatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellDoubleClick
        Label3.Text = dgvDatos.SelectedCells.Item(1).Value
        txtPNombre.Text = dgvDatos.SelectedCells.Item(2).Value
        txtSNombre.Text = dgvDatos.SelectedCells.Item(3).Value
        txtPapellido.Text = dgvDatos.SelectedCells.Item(4).Value
        txtSapellido.Text = dgvDatos.SelectedCells.Item(5).Value
        fecha_ingreso.Text = dgvDatos.SelectedCells.Item(6).Value
        cboCargo.SelectedIndex = Integer.Parse(dgvDatos.SelectedCells.Item(7).Value) - 1
        Dim estado_ As String = dgvDatos.SelectedCells.Item(9).Value
        If estado_ = "Activo" Then
            rb1.Checked = True
        ElseIf estado_ = "Inactivo" Then
            rb2.Checked = True
        End If

    End Sub

    Private Sub Anadir_cargo_Click(sender As Object, e As EventArgs) Handles Anadir_cargo.Click
        Dim frm As New frmCargos
        AddOwnedForm(frm)
        frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        frm.ShowDialog()
    End Sub
End Class