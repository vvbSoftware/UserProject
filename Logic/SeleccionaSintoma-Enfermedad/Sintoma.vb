Imports DataAccess
Public Class Sintoma
    Property _nombre As String

    Public Sub New()
    End Sub

    Public Sub New(nombre As String)
        _nombre = nombre
    End Sub

    Public Function ObtenerSintomas() As DataTable
        Dim consu As New DBSintomas()
        Return consu.ObtenerSintomas()
    End Function
    Public Function DevolverSintomaComboBox() As DataSet
        Dim consu As New DBSintomas()
        Return consu.DevolverSintomaComboBox()
    End Function

    Public Sub Limpiar()
        Dim cons As New DBSintomas
        cons.LimpiarSeleccion()
    End Sub


End Class
