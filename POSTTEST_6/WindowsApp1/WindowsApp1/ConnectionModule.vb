Imports MySqlConnector

Module ConnectionModule
    Public ReadOnly ConnectionString As String = "Server=localhost;Database=hevy_pemvis;Uid=root;Pwd=;"

    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(ConnectionString)
    End Function
End Module