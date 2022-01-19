<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panelcontenedor = New System.Windows.Forms.Panel()
        Me.BtnfrmEmpleado = New System.Windows.Forms.Button()
        Me.BtnfrmAsistencia = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnfrmAsistencia)
        Me.Panel1.Controls.Add(Me.BtnfrmEmpleado)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(210, 403)
        Me.Panel1.TabIndex = 0
        '
        'panelcontenedor
        '
        Me.panelcontenedor.BackColor = System.Drawing.Color.White
        Me.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelcontenedor.Location = New System.Drawing.Point(210, 0)
        Me.panelcontenedor.Name = "panelcontenedor"
        Me.panelcontenedor.Size = New System.Drawing.Size(666, 403)
        Me.panelcontenedor.TabIndex = 1
        '
        'BtnfrmEmpleado
        '
        Me.BtnfrmEmpleado.Location = New System.Drawing.Point(44, 66)
        Me.BtnfrmEmpleado.Name = "BtnfrmEmpleado"
        Me.BtnfrmEmpleado.Size = New System.Drawing.Size(108, 28)
        Me.BtnfrmEmpleado.TabIndex = 0
        Me.BtnfrmEmpleado.Text = "Añadir empleado"
        Me.BtnfrmEmpleado.UseVisualStyleBackColor = True
        '
        'BtnfrmAsistencia
        '
        Me.BtnfrmAsistencia.Location = New System.Drawing.Point(44, 129)
        Me.BtnfrmAsistencia.Name = "BtnfrmAsistencia"
        Me.BtnfrmAsistencia.Size = New System.Drawing.Size(108, 28)
        Me.BtnfrmAsistencia.TabIndex = 1
        Me.BtnfrmAsistencia.Text = "Añadir Asistencia"
        Me.BtnfrmAsistencia.UseVisualStyleBackColor = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 403)
        Me.Controls.Add(Me.panelcontenedor)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPrincipal"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents panelcontenedor As Panel
    Friend WithEvents BtnfrmAsistencia As Button
    Friend WithEvents BtnfrmEmpleado As Button
End Class
