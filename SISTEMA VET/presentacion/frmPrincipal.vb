Public Class frmPrincipal
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AbrirFormPanel(Of Miform As {Form, New})()
        Dim Formulario As Form
        Formulario = panelcontenedor.Controls.OfType(Of Miform)().FirstOrDefault()
        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False
            panelcontenedor.Controls.Add(Formulario)
            panelcontenedor.Tag = Formulario
            Formulario.Show()
        Else
            Formulario.BringToFront()
        End If
    End Sub

    Private Sub BtnfrmEmpleado_Click(sender As Object, e As EventArgs) Handles BtnfrmEmpleado.Click

        AbrirFormPanel(Of frmEmpleado)()
    End Sub

    Private Sub BtnfrmAsistencia_Click(sender As Object, e As EventArgs) Handles BtnfrmAsistencia.Click
        AbrirFormPanel(Of frmAsistencia)()
    End Sub
End Class