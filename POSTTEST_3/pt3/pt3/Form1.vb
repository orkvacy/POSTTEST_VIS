Public Class Form1
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;)|*.jpg;*.jpeg;*.png;"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            pbFoto.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not (Char.IsLetter(e.KeyChar) Or e.KeyChar = Chr(Keys.Back) Or e.KeyChar = Chr(Keys.Space)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back)) Then 'angka + backspace
            e.Handled = True
            lblError.Text = "Inputan Umur Harus Angka"
            lblError.Visible = True
        End If
    End Sub

    Private Sub txtNoTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoTelp.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back)) Then
            e.Handled = True
            lblError.Text = "Inputan No Telp Harus Angka"
            lblError.Visible = True
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        Dim hobiTerpilih As String = ""
        Dim adaHobi As Boolean = False



        For Each z As Control In gbHobby.Controls ' Looping untuk cek checkbox di gb hobi
            If TypeOf z Is CheckBox Then
                Dim chg As CheckBox = DirectCast(z, CheckBox)
                If chg.Checked Then
                    adaHobi = True
                    hobiTerpilih &= chg.Text & ", "
                End If
            End If
        Next

        If hobiTerpilih.Length > 0 Then
            hobiTerpilih = hobiTerpilih.Substring(0, hobiTerpilih.Length - 2)
        End If

        If pbFoto.Image Is Nothing Then
            lblError.Text = "Anda belum input foto"
            lblError.Visible = True
            Return
        End If

        If txtNama.Text = "" Or txtUmur.Text = "" Or txtNoTelp.Text = "" Or txtAlamat.Text = "" Or
       pbFoto.Image Is Nothing Or (Not rbLaki.Checked And Not rbPerempuan.Checked) Or Not adaHobi Then

            lblError.Text = "Inputan Kosong"
            lblError.Visible = True
            Return
        End If

        lblError.Visible = False

        Dim jenisKelamin As String = If(rbLaki.Checked, "Laki-Laki", "Perempuan")

        Dim formHasil As New Form2()
        formHasil.SetData(pbFoto.Image, txtNama.Text, txtUmur.Text, dtpTanggalLahir.Value.ToString("dd/MM/yyyy"), jenisKelamin, txtNoTelp.Text, hobiTerpilih, txtAlamat.Text)
        formHasil.ShowDialog()
    End Sub

    Private Sub txtAlamat_TextChanged(sender As Object, e As EventArgs) Handles txtAlamat.TextChanged

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub
End Class