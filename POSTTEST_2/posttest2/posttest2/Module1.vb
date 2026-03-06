Module ModuleDataBuku
    Public Structure Buku
        Public Judul As String
        Public Genre As String
    End Structure

    Public dataBuku() As Buku
    Public totalBuku As Integer = 0

    Public Sub addBuku(ByVal judulBaru As String, ByVal genreBaru As String)
        ReDim Preserve dataBuku(totalBuku)
        dataBuku(totalBuku).Judul = judulBaru
        dataBuku(totalBuku).Genre = genreBaru
        totalBuku += 1
    End Sub

    Public Function findIdx(ByVal judulDicari As String) As Integer
        For i As Integer = 0 To totalBuku - 1
            If dataBuku(i).Judul.ToLower() = judulDicari.ToLower() Then
                Return i
            End If
        Next
        Return -1
    End Function

    Public Sub delBuku(ByVal indeks As Integer)
        For i As Integer = indeks To totalBuku - 2
            dataBuku(i) = dataBuku(i + 1)
        Next
        totalBuku -= 1
        If totalBuku > 0 Then
            ReDim Preserve dataBuku(totalBuku - 1) 'resize/adjust tanpa format data
        Else
            Erase dataBuku
        End If
    End Sub
End Module