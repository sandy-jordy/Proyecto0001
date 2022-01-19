<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ANTECEDENTE
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Datalistado1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Txtnombre = New System.Windows.Forms.TextBox()
        Me.Txtantecedente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Btninsertar = New System.Windows.Forms.Button()
        Me.Btneditar = New System.Windows.Forms.Button()
        Me.Btnguardar = New System.Windows.Forms.Button()
        Me.Btneliminar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Btnbuscar = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.RBtnnombre = New System.Windows.Forms.RadioButton()
        Me.RBtnantecedente = New System.Windows.Forms.RadioButton()
        CType(Me.Datalistado1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sitka Small", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(212, 6)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(565, 50)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "REGISTRO DE ANTECEDENTE"
        '
        'Datalistado1
        '
        Me.Datalistado1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datalistado1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.Datalistado1.Location = New System.Drawing.Point(380, 137)
        Me.Datalistado1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Datalistado1.Name = "Datalistado1"
        Me.Datalistado1.Size = New System.Drawing.Size(519, 156)
        Me.Datalistado1.TabIndex = 42
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID_ANTECEDENTE "
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "ID_MASCOTA"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "NOMBRE"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "DESCRIPCION"
        Me.Column4.Name = "Column4"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RichTextBox1)
        Me.GroupBox1.Controls.Add(Me.Txtnombre)
        Me.GroupBox1.Controls.Add(Me.Txtantecedente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 59)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(341, 260)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Antecedente"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(144, 140)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(172, 107)
        Me.RichTextBox1.TabIndex = 4
        Me.RichTextBox1.Text = ""
        '
        'Txtnombre
        '
        Me.Txtnombre.Location = New System.Drawing.Point(100, 91)
        Me.Txtnombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtnombre.Name = "Txtnombre"
        Me.Txtnombre.Size = New System.Drawing.Size(172, 28)
        Me.Txtnombre.TabIndex = 4
        '
        'Txtantecedente
        '
        Me.Txtantecedente.Location = New System.Drawing.Point(100, 34)
        Me.Txtantecedente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtantecedente.Name = "Txtantecedente"
        Me.Txtantecedente.Size = New System.Drawing.Size(81, 28)
        Me.Txtantecedente.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 144)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descripcion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 95)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Btninsertar)
        Me.GroupBox2.Controls.Add(Me.Btneditar)
        Me.GroupBox2.Controls.Add(Me.Btnguardar)
        Me.GroupBox2.Controls.Add(Me.Btneliminar)
        Me.GroupBox2.Font = New System.Drawing.Font("Sitka Small", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(221, 326)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(624, 87)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones"
        '
        'Btninsertar
        '
        Me.Btninsertar.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btninsertar.Location = New System.Drawing.Point(68, 23)
        Me.Btninsertar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btninsertar.Name = "Btninsertar"
        Me.Btninsertar.Size = New System.Drawing.Size(117, 53)
        Me.Btninsertar.TabIndex = 36
        Me.Btninsertar.Text = "Insertar"
        Me.Btninsertar.UseVisualStyleBackColor = True
        '
        'Btneditar
        '
        Me.Btneditar.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btneditar.Location = New System.Drawing.Point(349, 23)
        Me.Btneditar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btneditar.Name = "Btneditar"
        Me.Btneditar.Size = New System.Drawing.Size(111, 53)
        Me.Btneditar.TabIndex = 37
        Me.Btneditar.Text = "Editar"
        Me.Btneditar.UseVisualStyleBackColor = True
        '
        'Btnguardar
        '
        Me.Btnguardar.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnguardar.Location = New System.Drawing.Point(220, 23)
        Me.Btnguardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btnguardar.Name = "Btnguardar"
        Me.Btnguardar.Size = New System.Drawing.Size(109, 53)
        Me.Btnguardar.TabIndex = 38
        Me.Btnguardar.Text = "Guardar"
        Me.Btnguardar.UseVisualStyleBackColor = True
        '
        'Btneliminar
        '
        Me.Btneliminar.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btneliminar.Location = New System.Drawing.Point(488, 23)
        Me.Btneliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btneliminar.Name = "Btneliminar"
        Me.Btneliminar.Size = New System.Drawing.Size(104, 53)
        Me.Btneliminar.TabIndex = 39
        Me.Btneliminar.Text = "Eliminar"
        Me.Btneliminar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Btnbuscar)
        Me.GroupBox3.Controls.Add(Me.TextBox5)
        Me.GroupBox3.Controls.Add(Me.RBtnnombre)
        Me.GroupBox3.Controls.Add(Me.RBtnantecedente)
        Me.GroupBox3.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(365, 59)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(561, 70)
        Me.GroupBox3.TabIndex = 45
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Buscar Antecedente"
        '
        'Btnbuscar
        '
        Me.Btnbuscar.Location = New System.Drawing.Point(451, 25)
        Me.Btnbuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btnbuscar.Name = "Btnbuscar"
        Me.Btnbuscar.Size = New System.Drawing.Size(100, 36)
        Me.Btnbuscar.TabIndex = 4
        Me.Btnbuscar.Text = "Buscar"
        Me.Btnbuscar.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(243, 27)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(196, 28)
        Me.TextBox5.TabIndex = 3
        '
        'RBtnnombre
        '
        Me.RBtnnombre.AutoSize = True
        Me.RBtnnombre.Location = New System.Drawing.Point(139, 25)
        Me.RBtnnombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RBtnnombre.Name = "RBtnnombre"
        Me.RBtnnombre.Size = New System.Drawing.Size(110, 29)
        Me.RBtnnombre.TabIndex = 2
        Me.RBtnnombre.TabStop = True
        Me.RBtnnombre.Text = "Nombre "
        Me.RBtnnombre.UseVisualStyleBackColor = True
        '
        'RBtnantecedente
        '
        Me.RBtnantecedente.AutoSize = True
        Me.RBtnantecedente.Location = New System.Drawing.Point(32, 27)
        Me.RBtnantecedente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RBtnantecedente.Name = "RBtnantecedente"
        Me.RBtnantecedente.Size = New System.Drawing.Size(96, 29)
        Me.RBtnantecedente.TabIndex = 1
        Me.RBtnantecedente.TabStop = True
        Me.RBtnantecedente.Text = "Codigo"
        Me.RBtnantecedente.UseVisualStyleBackColor = True
        '
        'ANTECEDENTE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 421)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Datalistado1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ANTECEDENTE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ANTECEDENTE"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Datalistado1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Datalistado1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Txtnombre As TextBox
    Friend WithEvents Txtantecedente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Btninsertar As Button
    Friend WithEvents Btneditar As Button
    Friend WithEvents Btnguardar As Button
    Friend WithEvents Btneliminar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Btnbuscar As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents RBtnnombre As RadioButton
    Friend WithEvents RBtnantecedente As RadioButton
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
