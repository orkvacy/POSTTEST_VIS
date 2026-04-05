Public Class Form1

    Private Sub InputDataToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles InputDataToolStripMenuItem.Click
        Dim frmInput As New FormInput()
        frmInput.ShowDialog()
    End Sub
    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles LihatKartuToolStripMenuItem.Click
        If DataModule.Nama.Trim() = "" Then
            MessageBox.Show("Belum ada data anggota. Silakan input data terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim frmKartu As New FormKartu()
            frmKartu.Show()
        End If
    End Sub

    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles SimpanDataToolStripMenuItem.Click
        If DataModule.Nama.Trim() = "" Then
            MessageBox.Show("Belum ada data yang dapat disimpan.",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim konfirmasi As DialogResult =
            MessageBox.Show("Apakah Anda yakin ingin menyimpan data anggota?", "Konfirmasi Simpan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi <> DialogResult.Yes Then Return


        If sfd.ShowDialog() = DialogResult.OK Then
            DataModule.SimpanKeFile(sfd.FileName)
            MessageBox.Show("Data berhasil disimpan ke:" & vbCrLf & sfd.FileName,
                            "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles BukaDataToolStripMenuItem.Click
        If ofd.ShowDialog() = DialogResult.OK Then
            DataModule.BukaFile(ofd.FileName)
            If DataModule.Nama.Trim() = "" Then
                MessageBox.Show("File tidak valid atau data kosong.",
                                "Gagal Membuka", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim frmKartu As New FormKartu()
                frmKartu.Show()
            End If
        End If
    End Sub


    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles KeluarToolStripMenuItem.Click
        Dim hasil As DialogResult =
            MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?",
                            "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then Application.Exit()
    End Sub


    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) _
        Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Dim hasil As DialogResult =
                MessageBox.Show("Apakah Anda yakin ingin keluar?",
                                "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If hasil = DialogResult.No Then e.Cancel = True
        End If
    End Sub

    Private Sub lblWelcome_Click(sender As Object, e As EventArgs) Handles lblWelcome.Click

    End Sub

    Private Sub lblJudul_Click(sender As Object, e As EventArgs) Handles lblJudul.Click

    End Sub
End Class