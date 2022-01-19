<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpleado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPNombre = New System.Windows.Forms.TextBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.rb1 = New System.Windows.Forms.RadioButton()
        Me.rb2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSapellido = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPapellido = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.fecha_ingreso = New System.Windows.Forms.DateTimePicker()
        Me.cboCargo = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Anadir_cargo = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Primer Nombre:"
        '
        'txtPNombre
        '
        Me.txtPNombre.Location = New System.Drawing.Point(99, 27)
        Me.txtPNombre.Name = "txtPNombre"
        Me.txtPNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtPNombre.TabIndex = 22
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(462, 27)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 27
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(462, 97)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 26
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(462, 61)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 25
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'dgvDatos
        '
        Me.dgvDatos.AllowUserToAddRows = False
        Me.dgvDatos.AllowUserToDeleteRows = False
        Me.dgvDatos.AllowUserToOrderColumns = True
        Me.dgvDatos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDatos.BackgroundColor = System.Drawing.Color.White
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.dgvDatos.Location = New System.Drawing.Point(28, 195)
        Me.dgvDatos.MultiSelect = False
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDatos.Size = New System.Drawing.Size(677, 155)
        Me.dgvDatos.TabIndex = 24
        '
        'rb1
        '
        Me.rb1.AutoSize = True
        Me.rb1.Location = New System.Drawing.Point(6, 12)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(55, 17)
        Me.rb1.TabIndex = 28
        Me.rb1.TabStop = True
        Me.rb1.Text = "Activo"
        Me.rb1.UseVisualStyleBackColor = True
        '
        'rb2
        '
        Me.rb2.AutoSize = True
        Me.rb2.Location = New System.Drawing.Point(61, 12)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(63, 17)
        Me.rb2.TabIndex = 29
        Me.rb2.TabStop = True
        Me.rb2.Text = "Inactivo"
        Me.rb2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb1)
        Me.GroupBox1.Controls.Add(Me.rb2)
        Me.GroupBox1.Location = New System.Drawing.Point(85, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(127, 39)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(220, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Segundo Nombre:"
        '
        'txtSNombre
        '
        Me.txtSNombre.Location = New System.Drawing.Point(313, 27)
        Me.txtSNombre.Name = "txtSNombre"
        Me.txtSNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtSNombre.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "__"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(220, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Segundo Apellido:"
        '
        'txtSapellido
        '
        Me.txtSapellido.Location = New System.Drawing.Point(313, 61)
        Me.txtSapellido.Name = "txtSapellido"
        Me.txtSapellido.Size = New System.Drawing.Size(100, 20)
        Me.txtSapellido.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Primer Apellido:"
        '
        'txtPapellido
        '
        Me.txtPapellido.Location = New System.Drawing.Point(99, 59)
        Me.txtPapellido.Name = "txtPapellido"
        Me.txtPapellido.Size = New System.Drawing.Size(100, 20)
        Me.txtPapellido.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Estado:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(220, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Fecha ingreso:"
        '
        'fecha_ingreso
        '
        Me.fecha_ingreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_ingreso.Location = New System.Drawing.Point(314, 100)
        Me.fecha_ingreso.Name = "fecha_ingreso"
        Me.fecha_ingreso.Size = New System.Drawing.Size(99, 20)
        Me.fecha_ingreso.TabIndex = 40
        '
        'cboCargo
        '
        Me.cboCargo.FormattingEnabled = True
        Me.cboCargo.Location = New System.Drawing.Point(86, 146)
        Me.cboCargo.Name = "cboCargo"
        Me.cboCargo.Size = New System.Drawing.Size(126, 21)
        Me.cboCargo.TabIndex = 41
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(44, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Cargo:"
        '
        'Anadir_cargo
        '
        Me.Anadir_cargo.Location = New System.Drawing.Point(223, 145)
        Me.Anadir_cargo.Name = "Anadir_cargo"
        Me.Anadir_cargo.Size = New System.Drawing.Size(30, 23)
        Me.Anadir_cargo.TabIndex = 43
        Me.Anadir_cargo.Text = "+"
        Me.Anadir_cargo.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'frmEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 362)
        Me.Controls.Add(Me.Anadir_cargo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboCargo)
        Me.Controls.Add(Me.fecha_ingreso)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSapellido)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPapellido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSNombre)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.dgvDatos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPNombre)
        Me.Name = "frmEmpleado"
        Me.Text = "frmEmpleado"
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtPNombre As TextBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents dgvDatos As DataGridView
    Friend WithEvents rb1 As RadioButton
    Friend WithEvents rb2 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSapellido As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPapellido As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents fecha_ingreso As DateTimePicker
    Friend WithEvents cboCargo As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Anadir_cargo As Button
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
End Class
