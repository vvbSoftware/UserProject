Module Module1

    Public Sub BotonRedondeado(btn As Button)
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btn.ClientRectangle
        myRectangle.Inflate(0, 60)
        buttonPath.AddEllipse(myRectangle)
        btn.Region = New Region(buttonPath)
    End Sub

    Private currentForm As Form = Nothing 'form en el panel no esta visible porque es el inicio de la app

    'Metodo para abrir ventanas dentro de la principal
    Public Sub OpenChildForm(childForm As Form, PanelChildForm As Panel)
        If currentForm IsNot Nothing Then currentForm.Close() 'prenguto si hay un form abierto
        currentForm = childForm 'cargo el form que quiero abrir
        'Le pongo los estilos que necesito
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelChildForm.Controls.Add(childForm)
        PanelChildForm.Tag = childForm
        'muestro el form
        childForm.BringToFront()
        childForm.Show()
    End Sub
End Module
