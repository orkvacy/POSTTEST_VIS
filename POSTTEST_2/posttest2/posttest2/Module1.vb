Module ModuleDataBuku
    ' Structure untuk detail buku
    Public Structure Buku
        Public Judul As String
        Public Genre As String
    End Structure

    ' Syarat: Daftar buku disimpan di dalam variable array
    Public dataBuku() As Buku
    Public totalBuku As Integer = 0

    ' Syarat: Terapkan procedure dengan minimal 1 tipe argumentasi (ByVal)
    Public Sub addBuku(ByVal judulBaru As String, ByVal genreBaru As String)
        ReDim Preserve dataBuku(totalBuku)
        dataBuku(totalBuku).Judul = judulBaru
        dataBuku(totalBuku).Genre = genreBaru
        totalBuku += 1
    End Sub

    ' Syarat: Terapkan function minimal 1
    Public Function CariIndeksBuku(ByVal judulDicari As String) As Integer
        For i As Integer = 0 To totalBuku - 1
            If dataBuku(i).Judul.ToLower() = judulDicari.ToLower() Then
                Return i
            End If
        Next
        Return -1
    End Function

    ' Procedure untuk menghapus array
    Public Sub delBuku(ByVal indeks As Integer)
        For i As Integer = indeks To totalBuku - 2
            dataBuku(i) = dataBuku(i + 1)
        Next
        totalBuku -= 1
        If totalBuku > 0 Then
            ReDim Preserve dataBuku(totalBuku - 1)
        Else
            Erase dataBuku
        End If
    End Sub
End Module