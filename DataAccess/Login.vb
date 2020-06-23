Imports MySql.Data.MySqlClient
Public Class Login
    Inherits ConexionBD

    Public Function Login(ci As String, pass As String) As Boolean

        Using connection = GetConnection()
            connection.Open()
            Using command = New MySqlCommand()
                command.Connection = connection
                command.CommandText = "select *from paciente where ciP=@user and contraseña=@pass"
                command.Parameters.AddWithValue("@user", ci)
                command.Parameters.AddWithValue("@pass", pass)
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
