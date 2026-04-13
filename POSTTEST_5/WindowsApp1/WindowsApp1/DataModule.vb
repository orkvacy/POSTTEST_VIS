Imports MySqlConnector
Imports System.Data
Imports System.Windows.Forms

Module DataModule
    Public Function getExec() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM exercises ORDER BY id DESC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal ambikl data: " & ex.Message, "Ralat", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function
    Public Function addExec(name As String, muscle As String, equipment As String) As Boolean
        Try
            Dim query As String = "INSERT INTO exercises (name, muscle_group, equipment) VALUES (@name, @muscle, @eq)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", name)
                    cmd.Parameters.AddWithValue("@muscle", muscle)
                    cmd.Parameters.AddWithValue("@eq", equipment)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message, "Ralat", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function editExec(id As Integer, name As String, muscle As String, equipment As String) As Boolean
        Try
            Dim query As String = "UPDATE exercises SET name=@name, muscle_group=@muscle, equipment=@eq WHERE id=@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@name", name)
                    cmd.Parameters.AddWithValue("@muscle", muscle)
                    cmd.Parameters.AddWithValue("@eq", equipment)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal edir data: " & ex.Message, "Ralat", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function delExec(id As Integer) As Boolean
        Try
            Dim query As String = "DELETE FROM exercises WHERE id = @id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Module