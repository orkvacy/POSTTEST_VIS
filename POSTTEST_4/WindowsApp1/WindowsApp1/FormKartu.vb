Public Class FormKartu
    Private Sub FormKartu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblKomunitas.Text = DataModule.Komunitas.ToUpper()
        If DataModule.FotoPath <> "" AndAlso IO.File.Exists(DataModule.FotoPath) Then
            picKartu.Image = System.Drawing.Image.FromFile(DataModule.FotoPath)
        End If

        lblNamaKartu.Text = DataModule.Nama
        lblIDKartu.Text = "ID: " & DataModule.IDAnggota
        lblPeranKartu.Text = DataModule.Peran
        lblTglLahirKartu.Text = "Tgl Lahir : " & DataModule.TanggalLahir 'hardcode
        lblJKKartu.Text = "Jenis Kelamin : " & DataModule.JenisKelamin
        lblTelpKartu.Text = "Telepon : " & DataModule.NoTelepon
        lblEmailKartu.Text = "Email : " & DataModule.Email
        lblAlamatKartu.Text = "Alamat : " & DataModule.Alamat

        If DataModule.Hobbies.Count > 0 Then
            lblHobiKartu.Text = "Hobi : " & String.Join(" | ", DataModule.Hobbies)
        End If
    End Sub
    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        Dim hasil As DialogResult =
            MessageBox.Show("Konfirmasi: Cetak kartu anggota atas nama " & DataModule.Nama & "?",
                            "Konfirmasi Cetak",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            MessageBox.Show("Kartu telah dikirim ke antrian cetak." & vbCrLf &
                            "(Fitur cetak nyata memerlukan integrasi PrintDocument)",
                            "Cetak", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class