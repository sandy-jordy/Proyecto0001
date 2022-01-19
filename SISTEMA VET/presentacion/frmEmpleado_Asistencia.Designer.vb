<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpleado_Asistencia
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboConcepto = New System.Windows.Forms.ComboBox()
        Me.id_empleado = New System.Windows.Forms.Label()
        Me.Fecha_asistencia = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(48, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Motivo:"
        '
        'cboConcepto
        '
        Me.cboConcepto.FormattingEnabled = True
        Me.cboConcepto.Location = New System.Drawing.Point(96, 82)
        Me.cboConcepto.Name = "cboConcepto"
        Me.cboConcepto.Size = New System.Drawing.Size(171, 21)
        Me.cboConcepto.TabIndex = 44
        '
        'id_empleado
        '
        Me.id_empleado.AutoSize = True
        Me.id_empleado.Location = New System.Drawing.Point(32, 32)
        Me.id_empleado.Name = "id_empleado"
        Me.id_empleado.Size = New System.Drawing.Size(19, 13)
        Me.id_empleado.TabIndex = 43
        Me.id_empleado.Text = "__"
        '
        'Fecha_asistencia
        '
        Me.Fecha_asistencia.AutoSize = True
        Me.Fecha_asistencia.Location = New System.Drawing.Point(164, 44)
        Me.Fecha_asistencia.Name = "Fecha_asistencia"
        Me.Fecha_asistencia.Size = New System.Drawing.Size(19, 13)
        Me.Fecha_asistencia.TabIndex = 46
        Me.Fecha_asistencia.Text = "__"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Fecha:"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(125, 138)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 48
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'frmEmpleado_Asistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 238)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Fecha_asistencia)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboConcepto)
        Me.Controls.Add(Me.id_empleado)
        Me.Name = "frmEmpleado_Asistencia"
        Me.Text = "frmEmpleado_Asistencia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents cboConcepto As ComboBox
    Friend WithEvents id_empleado As Label
    Friend WithEvents Fecha_asistencia As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGuardar As Button
End Class
