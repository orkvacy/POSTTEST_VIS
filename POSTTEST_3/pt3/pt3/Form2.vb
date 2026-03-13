Public Class Form2

    Public Sub SetData(foto As Image, nama As String, umur As String, tglLahir As String, jk As String, telp As String, hobi As String, alamat As String)
        pbFotoHasil.Image = foto
        lblNama.Text = nama
        lblUmur.Text = umur & " Tahun"
        lblTglLahir.Text = tglLahir
        lblJenisKelamin.Text = jk
        lblNoTelp.Text = telp
        lblHobby.Text = hobi
        lblAlamat.Text = alamat
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
    End Sub


End Class