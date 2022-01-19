<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CARGO
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
        Me.Txttipodecargo = New System.Windows.Forms.TextBox()
        Me.Txtid_Cargo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Btninsertar = New System.Windows.Forms.Button()
        Me.Btnguardar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Datalistado2 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RBtnid_cargo = New System.Windows.Forms.RadioButton()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Btnbuscar = New System.Windows.Forms.Button()
        Me.Btneliminar = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Datalistado2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Txttipodecargo)
        Me.GroupBox1.Controls.Add(Me.Txtid_Cargo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(268, 119)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Cargo"
        '
        'Txttipodecargo
        '
        Me.Txttipodecargo.Location = New System.Drawing.Point(122, 76)
        Me.Txttipodecargo.Name = "Txttipodecargo"
        Me.Txttipodecargo.Size = New System.Drawing.Size(128, 24)
        Me.Txttipodecargo.TabIndex = 5
        '
        'Txtid_Cargo
        '
        Me.Txtid_Cargo.Location = New System.Drawing.Point(76, 37)
        Me.Txtid_Cargo.Name = "Txtid_Cargo"
        Me.Txtid_Cargo.Size = New System.Drawing.Size(58, 24)
        Me.Txtid_Cargo.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo de Cargo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Btneliminar)
        Me.GroupBox2.Controls.Add(Me.Btninsertar)
        Me.GroupBox2.Controls.Add(Me.Btnguardar)
        Me.GroupBox2.Font = New System.Drawing.Font("Sitka Small", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 170)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(268, 68)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones"
        '
        'Btninsertar
        '
        Me.Btninsertar.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btninsertar.Location = New System.Drawing.Point(6, 21)
        Me.Btninsertar.Name = "Btninsertar"
        Me.Btninsertar.Size = New System.Drawing.Size(78, 35)
        Me.Btninsertar.TabIndex = 36
        Me.Btninsertar.Text = "Insertar"
        Me.Btninsertar.UseVisualStyleBackColor = True
        '
        'Btnguardar
        '
        Me.Btnguardar.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnguardar.Location = New System.Drawing.Point(90, 21)
        Me.Btnguardar.Name = "Btnguardar"
        Me.Btnguardar.Size = New System.Drawing.Size(85, 35)
        Me.Btnguardar.TabIndex = 38
        Me.Btnguardar.Text = "Guardar"
        Me.Btnguardar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Small", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(150, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(252, 31)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "REGISTRO DE CARGO"
        '
        'Datalistado2
        '
        Me.Datalistado2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datalistado2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.Datalistado2.Location = New System.Drawing.Point(289, 109)
        Me.Datalistado2.Name = "Datalistado2"
        Me.Datalistado2.Size = New System.Drawing.Size(262, 88)
        Me.Datalistado2.TabIndex = 47
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Btnbuscar)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.RBtnid_cargo)
        Me.GroupBox3.Font = New System.Drawing.Font("Sitka Small", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(289, 45)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(262, 58)
        Me.GroupBox3.TabIndex = 48
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Buscar Cargo"
        '
        'RBtnid_cargo
        '
        Me.RBtnid_cargo.AutoSize = True
        Me.RBtnid_cargo.Location = New System.Drawing.Point(6, 21)
        Me.RBtnid_cargo.Name = "RBtnid_cargo"
        Me.RBtnid_cargo.Size = New System.Drawing.Size(71, 22)
        Me.RBtnid_cargo.TabIndex = 0
        Me.RBtnid_cargo.TabStop = True
        Me.RBtnid_cargo.Text = "Codigo"
        Me.RBtnid_cargo.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(83, 21)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 22)
        Me.TextBox3.TabIndex = 1
        '
        'Btnbuscar
        '
        Me.Btnbuscar.Location = New System.Drawing.Point(189, 16)
        Me.Btnbuscar.Name = "Btnbuscar"
        Me.Btnbuscar.Size = New System.Drawing.Size(62, 33)
        Me.Btnbuscar.TabIndex = 2
        Me.Btnbuscar.Text = "Buscar"
        Me.Btnbuscar.UseVisualStyleBackColor = True
        '
        'Btneliminar
        '
        Me.Btneliminar.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btneliminar.Location = New System.Drawing.Point(181, 21)
        Me.Btneliminar.Name = "Btneliminar"
        Me.Btneliminar.Size = New System.Drawing.Size(78, 35)
        Me.Btneliminar.TabIndex = 40
        Me.Btneliminar.Text = "Eliminar"
        Me.Btneliminar.UseVisualStyleBackColor = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID_CARGO"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Tipo de Cargo"
        Me.Column2.Name = "Column2"
        '
        'CARGO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 245)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Datalistado2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CARGO"
        Me.Text = "CARGO"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Datalistado2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Txtid_Cargo As TextBox
    Friend WithEvents Txttipodecargo As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Btninsertar As Button
    Friend WithEvents Btnguardar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Datalistado2 As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Btnbuscar As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents RBtnid_cargo As RadioButton
    Friend WithEvents Btneliminar As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
