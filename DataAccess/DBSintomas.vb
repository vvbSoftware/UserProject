Imports MySql.Data.MySqlClient
Public Class DBSintomas
    Inherits ConexionBD

    Public Sub New()
    End Sub

    Public Function DevolverSintomaComboBox() As DataSet
        Dim _consultaSQL As String
        _consultaSQL = "SELECT * FROM sintoma"
        Return DevolverParaComboBox(_consultaSQL)
    End Function

    Public Function ObtenerSintomas() As DataTable
        Dim _consultaSQL As String
        _consultaSQL = "SELECT nombre FROM sintoma"
        Return DevolverTabla(_consultaSQL)
        Return Nothing
    End Function

    Public Function GuardarSeleccion(sintomas As ArrayList, ci As String, dia As String, hora As String) As Boolean
        Dim sql As String = ""
        'Try
        '    For Each sintoma In sintomas
        '        Dim sql As String = "INSERT INTO selec(dia,hora,idSint,idPac)"
        '        sql &= " VALUES("
        '        sql &= "'" & dia & "',"
        '        sql &= "'" & hora & "',"
        '        sql &= "'" & sintoma & "',"
        '        sql &= "'" & ci & "');"
        '        consultaEjecutar(sql)
        '    Next
        '    Return True
        'Catch ex As Exception
        '    Return False
        '    MsgBox("ERROR::" & ex.Message)
        'End Try
        Try
            Using connection = GetConnection()
                connection.Open()
                Using command = New MySqlCommand()
                    command.Connection = connection

                    For Each sintoma In sintomas
                        Sql &= "INSERT INTO selec(dia,hora,idSint,idPac)"
                        sql &= " VALUES("
                        sql &= "'" & dia & "',"
                        Sql &= "'" & hora & "',"
                        Sql &= "'" & sintoma & "',"
                        Sql &= "'" & ci & "');"
                        command.CommandText = Sql
                        command.CommandType = CommandType.Text
                        Dim reader = command.ExecuteReader()
                        If reader.HasRows Then
                            reader.Dispose()
                            Return True
                        Else
                            Return False
                        End If
                    Next
                End Using
            End Using
        Catch ex As Exception
            MsgBox("ERROR::" & ex.Message)
        End Try
    End Function

    Public Sub LimpiarSeleccion()
        Dim _consultaSQL As String
        _consultaSQL = "TRUNCATE TABLE selec"
        consultaEjecutar(_consultaSQL)
    End Sub

End Class
