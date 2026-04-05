Public Module DataModule

    Public Nama As String = ""
    Public IDAnggota As String = ""
    Public TanggalLahir As String = ""
    Public JenisKelamin As String = ""
    Public Komunitas As String = ""
    Public NoTelepon As String = ""
    Public Email As String = ""
    Public Alamat As String = ""
    Public Peran As String = ""
    Public Hobbies As New List(Of String)
    Public FotoPath As String = ""

    Public Sub Reset()
        Nama = "" : IDAnggota = "" : TanggalLahir = "" : JenisKelamin = ""
        Komunitas = "" : NoTelepon = "" : Email = "" : Alamat = ""
        Peran = "" : Hobbies.Clear() : FotoPath = ""
    End Sub
    Public Sub HanyaAngka(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaHuruf(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse
           Char.IsWhiteSpace(e.KeyChar) OrElse
           Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Function ValidasiTB(tb As TextBox, pesan As String, ep As ErrorProvider) As Boolean
        If tb.Text.Trim() = "" Then
            ep.SetError(tb, pesan)
            Return False
        End If
        ep.SetError(tb, "")
        Return True
    End Function

    Public Function ValidasiMTB(mtb As MaskedTextBox, pesan As String, ep As ErrorProvider) As Boolean
        If Not mtb.MaskCompleted Then
            ep.SetError(mtb, pesan)
            Return False
        End If
        ep.SetError(mtb, "")
        Return True
    End Function
    Public Sub SimpanKeFile(filePath As String)
        Dim lines As New List(Of String) From {
            "Nama=" & Nama,
            "IDAnggota=" & IDAnggota,
            "TanggalLahir=" & TanggalLahir,
            "JenisKelamin=" & JenisKelamin,
            "Komunitas=" & Komunitas,
            "NoTelepon=" & NoTelepon,
            "Email=" & Email,
            "Alamat=" & Alamat,
            "Peran=" & Peran,
            "Hobi=" & String.Join(",", Hobbies),
            "FotoPath=" & FotoPath
        }
        IO.File.WriteAllLines(filePath, lines, System.Text.Encoding.UTF8)
    End Sub

    Public Sub BukaFile(filePath As String)
        If Not IO.File.Exists(filePath) Then Return
        For Each line As String In IO.File.ReadAllLines(filePath, System.Text.Encoding.UTF8)
            Dim idx As Integer = line.IndexOf("="c)
            If idx < 0 Then Continue For
            Dim key As String = line.Substring(0, idx)
            Dim value As String = line.Substring(idx + 1)
            Select Case key
                Case "Nama" : Nama = value
                Case "IDAnggota" : IDAnggota = value
                Case "TanggalLahir" : TanggalLahir = value
                Case "JenisKelamin" : JenisKelamin = value
                Case "Komunitas" : Komunitas = value
                Case "NoTelepon" : NoTelepon = value
                Case "Email" : Email = value
                Case "Alamat" : Alamat = value
                Case "Peran" : Peran = value
                Case "Hobi"
                    Hobbies.Clear()
                    If value <> "" Then
                        For Each h In value.Split(","c)
                            If h.Trim() <> "" Then Hobbies.Add(h.Trim())
                        Next
                    End If
                Case "FotoPath" : FotoPath = value
            End Select
        Next
    End Sub

End Module