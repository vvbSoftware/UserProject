Public Class FrmPrincipal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenChildForm(New FrmConsulta, PanelChildForm)
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        'cierro totalmente la app
        Application.Exit()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        'para cerrar sesion
    End Sub

    Private Sub btnAgendaMedica_Click(sender As Object, e As EventArgs) Handles btnAgendaMedica.Click
        OpenChildForm(New FrmAgendaMedica, PanelChildForm)

    End Sub

    Private Sub btnHistorial_Click(sender As Object, e As EventArgs) Handles btnHistorial.Click
        OpenChildForm(New FrmHistorial, PanelChildForm)

    End Sub

    Private Sub btnConsulta_Click(sender As Object, e As EventArgs) Handles btnConsulta.Click
        OpenChildForm(New FrmConsulta, PanelChildForm)
    End Sub
End Class