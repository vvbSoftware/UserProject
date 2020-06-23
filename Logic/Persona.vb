﻿Public Class Persona
    Property _ci As String
    Property _tel_cel As Integer
    Property _edad As Integer
    Property _domicilio As String
    Property _sexo As String
    Property _pNom As String
    Property _sNom As String
    Property _pApe As String
    Property _sApe As String

    Public Sub New(ci As String)
        _ci = ci
    End Sub

    Public Sub New(ci As String, tel_cel As Object, edad As Object,
                   domicilio As String, sexo As String, pNom As String,
                   sNom As String, pApe As String, sApe As String)
        _ci = ci
        _tel_cel = tel_cel
        _edad = edad
        _domicilio = domicilio
        _sexo = sexo
        _pNom = pNom
        _sNom = sNom
        _pApe = pApe
        _sApe = sApe
    End Sub

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function

End Class
