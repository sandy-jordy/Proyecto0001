<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DATOS_MEDIO_AMBIENTSLES
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RTxtnutricion = New System.Windows.Forms.RichTextBox()
        Me.RTxtentorno = New System.Windows.Forms.RichTextBox()
        Me.Txtid_datos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Btneditar = New System.Windows.Forms.Button()
        Me.Btneliminar = New System.Windows.Forms.Button()
        Me.Btnguardar = New System.Windows.Forms.Button()
        Me.Btninsertar = New System.Windows.Forms.Button()
        Me.Datalistado3 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Btnbuscar = New System.Windows.Forms.Button()
        Me.txtcargo = New System.Windows.Forms.TextBox()
        Me.RBtnid_datos = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Datalistado3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RTxtnutricion)
        Me.GroupBox1.Controls.Add(Me.RTxtentorno)
        Me.GroupBox1.Controls.Add(Me.Txtid_datos)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(290, 175)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Medio Ambientales"
        '
        'RTxtnutricion
        '
        Me.RTxtnutricion.Location = New System.Drawing.Point(145, 89)
        Me.RTxtnutricion.Name = "RTxtnutricion"
        Me.RTxtnutricion.Size = New System.Drawing.Size(139, 70)
        Me.RTxtnutricion.TabIndex = 10
        Me.RTxtnutricion.Text = ""
        '
        'RTxtentorno
        '
        Me.RTxtentorno.Location = New System.Drawing.Point(6, 89)
        Me.RTxtentorno.Name = "RTxtentorno"
        Me.RTxtentorno.Size = New System.Drawing.Size(133, 70)
        Me.RTxtentorno.TabIndex = 9
        Me.RTxtentorno.Text = ""
        '
        'Txtid_datos
        '
        Me.Txtid_datos.Location = New System.Drawing.Point(62, 30)
        Me.Txtid_datos.Name = "Txtid_datos"
        Me.Txtid_datos.Size = New System.Drawing.Size(69, 24)
        Me.Txtid_datos.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(145, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nutricion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Entorno:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Btneditar)
        Me.GroupBox2.Controls.Add(Me.Btneliminar)
        Me.GroupBox2.Controls.Add(Me.Btnguardar)
        Me.GroupBox2.Controls.Add(Me.Btninsertar)
        Me.GroupBox2.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(22, 277)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(343, 57)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones"
        '
        'Btneditar
        '
        Me.Btneditar.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btneditar.Location = New System.Drawing.Point(254, 19)
        Me.Btneditar.Name = "Btneditar"
        Me.Btneditar.Size = New System.Drawing.Size(83, 32)
        Me.Btneditar.TabIndex = 42
        Me.Btneditar.Text = "Editar"
        Me.Btneditar.UseVisualStyleBackColor = True
        '
        'Btneliminar
        '
        Me.Btneliminar.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btneliminar.Location = New System.Drawing.Point(164, 19)
        Me.Btneliminar.Name = "Btneliminar"
        Me.Btneliminar.Size = New System.Drawing.Size(79, 32)
        Me.Btneliminar.TabIndex = 41
        Me.Btneliminar.Text = "Eliminar"
        Me.Btneliminar.UseVisualStyleBackColor = True
        '
        'Btnguardar
        '
        Me.Btnguardar.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnguardar.Location = New System.Drawing.Point(83, 19)
        Me.Btnguardar.Name = "Btnguardar"
        Me.Btnguardar.Size = New System.Drawing.Size(75, 32)
        Me.Btnguardar.TabIndex = 40
        Me.Btnguardar.Text = "Guardar"
        Me.Btnguardar.UseVisualStyleBackColor = True
        '
        'Btninsertar
        '
        Me.Btninsertar.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btninsertar.Location = New System.Drawing.Point(6, 19)
        Me.Btninsertar.Name = "Btninsertar"
        Me.Btninsertar.Size = New System.Drawing.Size(71, 32)
        Me.Btninsertar.TabIndex = 38
        Me.Btninsertar.Text = "Insertar"
        Me.Btninsertar.UseVisualStyleBackColor = True
        '
        'Datalistado3
        '
        Me.Datalistado3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datalistado3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.Datalistado3.Location = New System.Drawing.Point(324, 124)
        Me.Datalistado3.Name = "Datalistado3"
        Me.Datalistado3.Size = New System.Drawing.Size(262, 133)
        Me.Datalistado3.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID_DATOS"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "ENTORNO"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "NUTRICION"
        Me.Column3.Name = "Column3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sitka Small", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(114, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(344, 31)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "DATOS MEDIO AMBIENTALES"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Btnbuscar)
        Me.GroupBox3.Controls.Add(Me.txtcargo)
        Me.GroupBox3.Controls.Add(Me.RBtnid_datos)
        Me.GroupBox3.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(324, 66)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(262, 52)
        Me.GroupBox3.TabIndex = 49
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Buscar Cargo"
        '
        'Btnbuscar
        '
        Me.Btnbuscar.Location = New System.Drawing.Point(189, 16)
        Me.Btnbuscar.Name = "Btnbuscar"
        Me.Btnbuscar.Size = New System.Drawing.Size(67, 33)
        Me.Btnbuscar.TabIndex = 2
        Me.Btnbuscar.Text = "Buscar"
        Me.Btnbuscar.UseVisualStyleBackColor = True
        '
        'txtcargo
        '
        Me.txtcargo.Location = New System.Drawing.Point(83, 21)
        Me.txtcargo.Name = "txtcargo"
        Me.txtcargo.Size = New System.Drawing.Size(100, 24)
        Me.txtcargo.TabIndex = 1
        '
        'RBtnid_datos
        '
        Me.RBtnid_datos.AutoSize = True
        Me.RBtnid_datos.Location = New System.Drawing.Point(6, 21)
        Me.RBtnid_datos.Name = "RBtnid_datos"
        Me.RBtnid_datos.Size = New System.Drawing.Size(74, 23)
        Me.RBtnid_datos.TabIndex = 0
        Me.RBtnid_datos.TabStop = True
        Me.RBtnid_datos.Text = "Codigo"
        Me.RBtnid_datos.UseVisualStyleBackColor = True
        '
        'DATOS_MEDIO_AMBIENTSLES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 346)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Datalistado3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "DATOS_MEDIO_AMBIENTSLES"
        Me.Text = "DATOS_MEDIO_AMBIENTSLES"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Datalistado3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Txtid_datos As TextBox
    Friend WithEvents RTxtnutricion As RichTextBox
    Friend WithEvents RTxtentorno As RichTextBox
    Friend WithEvents Btninsertar As Button
    Friend WithEvents Btnguardar As Button
    Friend WithEvents Btneliminar As Button
    Friend WithEvents Datalistado3 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Btnbuscar As Button
    Friend WithEvents txtcargo As TextBox
    Friend WithEvents RBtnid_datos As RadioButton
    Friend WithEvents Btneditar As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
