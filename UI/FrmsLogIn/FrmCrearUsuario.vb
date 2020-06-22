Public Class FrmCrearUsuario

    Private Sub FrmCrearUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnLogin_Paint(sender As Object, e As PaintEventArgs) Handles btnCancelar.Paint, btnCrear.Paint
        BotonRedondeado(btnCancelar)
        BotonRedondeado(btnCrear)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click

    End Sub

End Class