Public Class Sintomas
    Property _nombre As String
    Property _idSintoma As Integer

    Public Sub New(nombre As String)
        _nombre = nombre
    End Sub

    Public Sub New(nombre As String, idSintoma As Integer)
        _nombre = nombre
        _idSintoma = idSintoma
    End Sub

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function
End Class
