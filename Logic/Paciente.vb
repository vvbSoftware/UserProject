Public Class Paciente
    Inherits Persona
    Property _mail As String
    Property _contraseña As String

    Public Sub New(ci As String, mail As String, contraseña As String,
                   tel_cel As Object, edad As Object, domicilio As String,
                   sexo As String, pNom As String, sNom As String,
                   pApe As String, sApe As String)

        MyBase.New(ci, tel_cel, edad, domicilio, sexo, pNom, sNom, pApe, sApe)
        _mail = mail
        _contraseña = contraseña
    End Sub

End Class
