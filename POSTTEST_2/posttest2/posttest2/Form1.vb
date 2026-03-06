Public Class Form1

    Private Sub refresh()
        DataGridView1.Rows.Clear()
        For i As Integer = 0 To totalBuku - 1
            DataGridView1.Rows.Add(dataBuku(i).Judul, dataBuku(i).Genre)
        Next
    End Sub




    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim judulBaru As String = txtJudul.Text
        Dim genreBaru As String = txtGenre.Text

        If judulBaru = "" Or genreBaru = "" Then
            lblText.ForeColor = Color.Red
            lblText.Text = "Judul dan Genre harus terisi dua-duanya"
            Return
        End If

        If findIdx(judulBaru) <> -1 Then
            lblText.ForeColor = Color.Red
            lblText.Text = "Buku ini sudah " & judulBaru & "' sudah ada"
            txtJudul.Clear()
            txtJudul.Focus()
            Return
        End If

        addBuku(judulBaru, genreBaru)
        refresh()


        lblText.ForeColor = Color.Green
        lblText.Text = "Done, buku berhasil tertambah"

        txtJudul.Clear()
        txtGenre.Clear()
        txtJudul.Focus()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim judulYangDihapus As String = txtDelBuku.Text

        If judulYangDihapus = "" Then
            lblText.ForeColor = Color.Red
            lblText.Text = "Silahkan Input sesuatu"
            Return
        End If


        Dim indeks As Integer = findIdx(judulYangDihapus)

        If indeks <> -1 Then
            delBuku(indeks)
            refresh()
            txtDelBuku.Clear()

            lblText.ForeColor = Color.Green
            lblText.Text = "Done'" & judulYangDihapus & " berhasil dihapus!"
        Else
            lblText.ForeColor = Color.Red
            lblText.Text = "Buku tersebut tidak ditemukan"
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex < 0 OrElse e.RowIndex >= totalBuku Then ' cek event
            Return
        End If
        If e.ColumnIndex = 2 Then

            Dim judul = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()

            delBuku(e.RowIndex)
            refresh()

            lblText.ForeColor = Color.Green
            lblText.Text = "Done, '" & judul & "' berhasil dihapus!"

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim colAct As DataGridViewButtonColumn = DirectCast(DataGridView1.Columns(2), DataGridViewButtonColumn)
        colAct.Text = "❌"
        colAct.UseColumnTextForButtonValue = True

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class