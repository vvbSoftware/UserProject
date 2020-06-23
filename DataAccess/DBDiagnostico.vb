﻿Imports MySql.Data.MySqlClient
Public Class DBDiagnostico
    Inherits ConexionBD

    Public Function Diagnostico() As DataTable
        Dim _consultaSQL As String = "select nomEnf From define Join selec ON idSint=nomSint Group by nomEnf"
        Return DevolverTabla(_consultaSQL)
    End Function

    Public Function GuardarDiagnostico(ci As String, enfermedades As ArrayList, dia As String) As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using command = New MySqlCommand()
                command.Connection = connection
                command.CommandText = "Insert into diagnostico(idDiag,idP,nomE,fecha) Values(null,'@idP','@nomE','@fecha');"
                command.Parameters.AddWithValue("@idP", ci)
                command.Parameters.AddWithValue("@nomE", enfermedades.Item(0))
                command.Parameters.AddWithValue("@fecha", dia)
                command.CommandType = CommandType.Text
                Dim reader = command.ExecuteReader()
                If reader.HasRows Then
                    reader.Dispose()
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function

End Class
