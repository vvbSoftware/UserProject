Public Class FrmConsulta
    Private Sub Consulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnChat.Visible = False
    End Sub
    Private Sub btnConsul_Click(sender As Object, e As EventArgs) Handles btnConsul.Click
        btnChat.Visible = True
    End Sub
    Private Sub btnChat_Click(sender As Object, e As EventArgs) Handles btnChat.Click
        MsgBox("chat")
        OpenChildForm(New FrmChat)

    End Sub


#Region "styles"

    Public Sub Button1_Paint(sender As Object, e As PaintEventArgs) Handles btnConsul.Paint, btnChat.Paint
        With btnConsul
            Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
            Dim myRectangle As Rectangle = .ClientRectangle
            myRectangle.Inflate(0, 15)
            buttonPath.AddEllipse(myRectangle)
            .Region = New Region(buttonPath)
        End With
        With btnChat
            Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
            Dim myRectangle As Rectangle = .ClientRectangle
            myRectangle.Inflate(0, 15)
            buttonPath.AddEllipse(myRectangle)
            .Region = New Region(buttonPath)
        End With
    End Sub
    Private currentForm As Form = Nothing 'form en el panel no esta visible porque es el inicio de la app
    'Metodo para abrir ventanas dentro de la principal
    Public Sub OpenChildForm(childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close() 'prenguto si hay un form abierto
        currentForm = childForm 'cargo el form que quiero abrir
        'Le pongo los estilos que necesito
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        pnChildCons.Controls.Add(childForm)
        pnChildCons.Tag = childForm
        'muestro el form
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub pnChildCons_Paint(sender As Object, e As PaintEventArgs) Handles pnChildCons.Paint

    End Sub
#End Region
End Class