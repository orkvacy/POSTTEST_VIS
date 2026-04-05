Public Class FormInput
    Private Sub FormInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler txtNama.KeyPress, AddressOf DataModule.HanyaHuruf
        AddHandler txtID.KeyPress, AddressOf DataModule.HanyaAngka
    End Sub

    Private Sub btnKeTab2_Click(sender As Object, e As EventArgs) Handles btnKeTab2.Click
        If ValidasiTab1() Then
            TabControl1.SelectedTab = tabKontakInfo
        End If
    End Sub

    Private Sub btnKeTab1_Click(sender As Object, e As EventArgs) Handles btnKeTab1.Click
        TabControl1.SelectedTab = tabDataUtama
    End Sub

    Private Sub btnKeTab3_Click(sender As Object, e As EventArgs) Handles btnKeTab3.Click
        If ValidasiTab2() Then
            TabControl1.SelectedTab = tabProfilAktivitas
        End If
    End Sub

    Private Sub btnKeTab2Balik_Click(sender As Object, e As EventArgs) Handles btnKeTab2Balik.Click
        TabControl1.SelectedTab = tabKontakInfo
    End Sub


    Private Sub btnBrowseFoto_Click(sender As Object, e As EventArgs) Handles btnBrowseFoto.Click

        If ofd.ShowDialog() = DialogResult.OK Then
            Dim path As String = ofd.FileName
            Dim folder As String = IO.Path.Combine(Application.StartupPath, "Foto")
            If Not IO.Directory.Exists(folder) Then IO.Directory.CreateDirectory(folder)

            Dim namaFile As String = "foto_" & DateTime.Now.Ticks &
                                     IO.Path.GetExtension(path)
            Dim dest As String = IO.Path.Combine(folder, namaFile)
            IO.File.Copy(path, dest, True)

            DataModule.FotoPath = dest
            picFotoProfil.Image = System.Drawing.Image.FromFile(dest)
        End If
    End Sub

    Private Sub mtbTelepon_Leave(sender As Object, e As EventArgs) Handles mtbTelepon.Leave
        If Not mtbTelepon.MaskCompleted Then
            ErrorProvider1.SetError(mtbTelepon, "Nomor HP harus lengkap (contoh: 0812-3456-7890)")
        Else
            ErrorProvider1.SetError(mtbTelepon, "")
        End If
    End Sub
    Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) Handles btnSimpanCetak.Click
        If Not ValidasiTab3() Then Return

        Dim hasil As DialogResult =
            MessageBox.Show("Data sudah lengkap. Simpan dan tampilkan kartu anggota?",
                            "Konfirmasi Cetak Kartu",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question)

        If hasil = DialogResult.Cancel Then Return
        If hasil = DialogResult.No Then
            SimpanKeDataModule()
            MessageBox.Show("Data berhasil disimpan tanpa menampilkan kartu.",
                            "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Return
        End If

        SimpanKeDataModule()
        Dim frmKartu As New FormKartu()
        frmKartu.Show()
        Me.Close()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Dim hasil As DialogResult =
            MessageBox.Show("Apakah Anda yakin ingin membatalkan pengisian data?",
                            "Konfirmasi Batal",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If hasil = DialogResult.Yes Then Me.Close()
    End Sub

    Private Sub SimpanKeDataModule()
        DataModule.Nama = txtNama.Text.Trim()
        DataModule.IDAnggota = txtID.Text.Trim()
        DataModule.TanggalLahir = dtpTanggalLahir.Value.ToString("dd MMMM yyyy")
        DataModule.JenisKelamin = If(rbLakiLaki.Checked, "Laki-laki", "Perempuan")
        DataModule.Komunitas = cmbKomunitas.Text
        DataModule.NoTelepon = mtbTelepon.Text
        DataModule.Email = txtEmail.Text.Trim()
        DataModule.Alamat = txtAlamat.Text.Trim()

        For Each rb As RadioButton In grpPeran.Controls.OfType(Of RadioButton)()
            If rb.Checked Then
                DataModule.Peran = rb.Text
                Exit For
            End If
        Next

        DataModule.Hobbies.Clear()
        For Each cb As CheckBox In grpHobi.Controls.OfType(Of CheckBox)()
            If cb.Checked Then DataModule.Hobbies.Add(cb.Text)
        Next
    End Sub

    Private Function ValidasiTab1() As Boolean
        Dim ok As Boolean = True
        ErrorProvider1.Clear()

        If Not DataModule.ValidasiTB(txtNama, "Inputan tidak boleh kosong", ErrorProvider1) Then ok = False
        If Not DataModule.ValidasiTB(txtID, "Inputan tidak boleh kosong", ErrorProvider1) Then ok = False

        If cmbKomunitas.SelectedIndex < 0 Then
            ErrorProvider1.SetError(cmbKomunitas, "Pilih jenis komunitas/divisi")
            ok = False
        Else
            ErrorProvider1.SetError(cmbKomunitas, "")
        End If

        Dim adaJK As Boolean = rbLakiLaki.Checked OrElse rbPerempuan.Checked
        If Not adaJK Then
            ErrorProvider1.SetError(grpJenisKelamin, "Inputan tidak boleh kosong")
            ok = False
        Else
            ErrorProvider1.SetError(grpJenisKelamin, "")
        End If

        If Not ok Then
            MessageBox.Show("Harap lengkapi semua field yang ditandai merah.",
                            "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Return ok
    End Function



    Private Function ValidasiTab2() As Boolean
        Dim ok As Boolean = True
        ErrorProvider1.Clear()

        If Not DataModule.ValidasiMTB(mtbTelepon, "Inputan tidak boleh kosong / format salah", ErrorProvider1) Then ok = False
        If Not DataModule.ValidasiTB(txtEmail, "Inputan tidak boleh kosong", ErrorProvider1) Then ok = False
        If Not DataModule.ValidasiTB(txtAlamat, "Inputan tidak boleh kosong", ErrorProvider1) Then ok = False

        If Not ok Then
            MessageBox.Show("Harap lengkapi semua field yang ditandai merah.",
                            "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Return ok
    End Function

    Private Function ValidasiTab3() As Boolean
        Dim ok As Boolean = True
        ErrorProvider1.Clear()

        ' Cek foto
        If DataModule.FotoPath = "" Then
            ErrorProvider1.SetError(picFotoProfil, "Inputan tidak boleh kosong - Upload foto profil")
            ok = False
        Else
            ErrorProvider1.SetError(picFotoProfil, "")
        End If

        ' Cek peran
        Dim adaPeran As Boolean = False
        For Each rb As RadioButton In grpPeran.Controls.OfType(Of RadioButton)()
            If rb.Checked Then adaPeran = True
        Next
        If Not adaPeran Then
            ErrorProvider1.SetError(grpPeran, "Inputan tidak boleh kosong - Pilih peran")
            ok = False
        Else
            ErrorProvider1.SetError(grpPeran, "")
        End If

        ' Cek minimal 1 hobi
        Dim adaHobi As Boolean = False
        For Each cb As CheckBox In grpHobi.Controls.OfType(Of CheckBox)()
            If cb.Checked Then adaHobi = True
        Next
        If Not adaHobi Then
            ErrorProvider1.SetError(grpHobi, "Inputan tidak boleh kosong - Pilih minimal 1 hobi")
            ok = False
        Else
            ErrorProvider1.SetError(grpHobi, "")
        End If

        If Not ok Then
            MessageBox.Show("Harap lengkapi semua field yang ditandai merah.",
                            "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Return ok
    End Function
End Class
