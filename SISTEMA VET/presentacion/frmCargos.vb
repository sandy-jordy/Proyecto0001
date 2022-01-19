Imports System.Data.SqlClient
Imports SISTEMA_VET.conexion
Public Class frmCargos


    Private Sub mostrar()
        Try
            'instanciamos la clase fusuario y llamamos a la funcion mostrar usuarios
            Dim func As New FCargo
            Dim dt As New DataTable
            dt = func.mostrar()
            'ocultamos la columna donde aparece el check de eliminacion
            dgvDatos.Columns.Item("Eliminar").Visible = False


            'si hay registros entonces llenamos la lista con los registros, mostramos las columas del datagridview datalistado
            If dt.Rows.Count <> 0 Then
                dgvDatos.DataSource = dt
                dgvDatos.ColumnHeadersVisible = True
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        btnEditar.Enabled = True
        btnGuardar.Enabled = False

        If Me.ValidateChildren = True And
            TextBox1.Text <> "" Then
            Try

                Dim dts As New vCargo
                Dim func As New FCargo
                'dts.Id_Cargo1 = Label1.Text
                dts.Nombre_cargo1 = TextBox1.Text.Trim().ToUpper()
                If func.insertar_cargo(dts) Then
                    MessageBox.Show("Proveedor registrado correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim frm As frmEmpleado = CType(Owner, frmEmpleado)
                    frm.CargarCargo()
                    Me.Close()
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

    Private Sub dgvDatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellDoubleClick
        TextBox1.Text = dgvDatos.SelectedCells.Item(2).Value
        Label1.Text = Convert.ToString(Me.dgvDatos.SelectedCells.Item(1).Value)
        btnEditar.Enabled = True
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        TextBox1.Text = ""
        btnEditar.Enabled = False
        btnGuardar.Enabled = True
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea editar los datos del cliente?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And Label1.Text <> "" And
            TextBox1.Text <> "" Then
                Try
                    Dim dts As New vCargo
                    Dim func As New FCargo

                    dts.Id_Cargo1 = Label1.Text
                    dts.Nombre_cargo1 = TextBox1.Text.Trim().ToUpper()

                    If func.editar_cargo(dts) Then
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

    Private Sub MENU_PRINCIPAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        Label1.Visible = False
        btnGuardar.Enabled = False
    End Sub
End Class