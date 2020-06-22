Imports Logic
Public Class FrmConsulta

    Private Sub Consulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnChat.Visible = False
    End Sub
    Private Sub btnConsul_Click(sender As Object, e As EventArgs) Handles btnConsul.Click
        Dim _cedula As String
        'creo un array de los sintomas seleccionados
        Dim _sintomas As New ArrayList
        'agrego cada sintoma del comboBox al array
        _sintomas.Add(cbSintoma3.Text)
        _sintomas.Add(cbSintoma4.Text)
        _sintomas.Add(cbSintoma5.Text)
        _sintomas.Add(cbSintoma6.Text)
        _sintomas.Add(cbSintoma7.Text)
        _sintomas.Add(cbSintoma8.Text)

        'lo agrego para diagnosticar
        Dim selecciona As New Selecciona(_sintomas, _cedula)


        'Dim ficha As New FrmFichaMedica
        'ficha.ShowDialog()
        'btnChat.Visible = True
    End Sub
    Private Sub btnChat_Click(sender As Object, e As EventArgs) Handles btnChat.Click
        OpenChildForm(New FrmChat)
    End Sub

#Region "styles"
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

    Private Sub btnChat_Paint(sender As Object, e As PaintEventArgs) Handles btnConsul.Paint, btnChat.Paint
        BotonRedondeado(btnConsul)
        BotonRedondeado(btnChat)
    End Sub


#End Region
End Class