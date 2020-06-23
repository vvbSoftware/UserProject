Public Class DBEnfermedades
    Inherits ConexionBD
    Public Function ObtenerEnfermedades() As DataTable
        Dim _consultaSQL As String
        _consultaSQL = "SELECT *,nomSint FROM enfermedad e, define d where(e.nombre=d.nomEnf)"
        Return DevolverTabla(_consultaSQL)
    End Function
End Class
