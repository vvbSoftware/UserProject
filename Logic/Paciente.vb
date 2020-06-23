Imports DataAccess
Public Class Paciente
    Inherits Persona
    Property _mail As String
    Property _contraseña As String

    Public Sub New(ci As String)
        MyBase.New(ci)
    End Sub

    Public Sub New(ci As String, contraseña As String)
        MyBase.New(ci)
        _contraseña = contraseña
    End Sub

    Public Sub New(ci As String, mail As String, contraseña As String,
                   tel_cel As Object, edad As Object, domicilio As String,
                   sexo As String, pNom As String, sNom As String,
                   pApe As String, sApe As String)

        MyBase.New(ci, tel_cel, edad, domicilio, sexo, pNom, sNom, pApe, sApe)
        _mail = mail
        _contraseña = contraseña
    End Sub
    Public Function ComprobarLogin(paciente As Paciente) As Boolean
        Dim log As New Login
        Return log.Login(paciente._ci, paciente._contraseña)
    End Function

    Public Sub Selcciona(sintomas As ArrayList, ci As String, dia As String, hora As String)
        Dim cons As New DBSintomas
        cons.GuardarSeleccion(sintomas, ci, dia, hora)
    End Sub

End Class
