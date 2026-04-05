' ============================================================
'  FormInput.Designer.vb  —  Designer code Form Input (3 Tab)
' ============================================================

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInput
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabDataUtama = New System.Windows.Forms.TabPage()
        Me.btnKeTab2 = New System.Windows.Forms.Button()
        Me.cmbKomunitas = New System.Windows.Forms.ComboBox()
        Me.lblKomunitas = New System.Windows.Forms.Label()
        Me.grpJenisKelamin = New System.Windows.Forms.GroupBox()
        Me.rbLakiLaki = New System.Windows.Forms.RadioButton()
        Me.rbPerempuan = New System.Windows.Forms.RadioButton()
        Me.dtpTanggalLahir = New System.Windows.Forms.DateTimePicker()
        Me.lblTglLahir = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblHeaderTab1 = New System.Windows.Forms.Label()
        Me.tabKontakInfo = New System.Windows.Forms.TabPage()
        Me.btnKeTab3 = New System.Windows.Forms.Button()
        Me.btnKeTab1 = New System.Windows.Forms.Button()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.lblAlamat = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.mtbTelepon = New System.Windows.Forms.MaskedTextBox()
        Me.lblTelepon = New System.Windows.Forms.Label()
        Me.lblHeaderTab2 = New System.Windows.Forms.Label()
        Me.tabProfilAktivitas = New System.Windows.Forms.TabPage()
        Me.btnSimpanCetak = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnKeTab2Balik = New System.Windows.Forms.Button()
        Me.grpHobi = New System.Windows.Forms.GroupBox()
        Me.cbFotografi = New System.Windows.Forms.CheckBox()
        Me.cbDesain = New System.Windows.Forms.CheckBox()
        Me.cbCoding = New System.Windows.Forms.CheckBox()
        Me.cbMusik = New System.Windows.Forms.CheckBox()
        Me.cbOlahraga = New System.Windows.Forms.CheckBox()
        Me.cbMenulis = New System.Windows.Forms.CheckBox()
        Me.cbVideografi = New System.Windows.Forms.CheckBox()
        Me.cbPublicSpeaking = New System.Windows.Forms.CheckBox()
        Me.grpPeran = New System.Windows.Forms.GroupBox()
        Me.rbKetua = New System.Windows.Forms.RadioButton()
        Me.rbWakilKetua = New System.Windows.Forms.RadioButton()
        Me.rbSekretaris = New System.Windows.Forms.RadioButton()
        Me.rbBendahara = New System.Windows.Forms.RadioButton()
        Me.rbAnggota = New System.Windows.Forms.RadioButton()
        Me.rbAdmin = New System.Windows.Forms.RadioButton()
        Me.rbKoordinator = New System.Windows.Forms.RadioButton()
        Me.rbRelawan = New System.Windows.Forms.RadioButton()
        Me.btnBrowseFoto = New System.Windows.Forms.Button()
        Me.picFotoProfil = New System.Windows.Forms.PictureBox()
        Me.lblHeaderTab3 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.tabDataUtama.SuspendLayout()
        Me.grpJenisKelamin.SuspendLayout()
        Me.tabKontakInfo.SuspendLayout()
        Me.tabProfilAktivitas.SuspendLayout()
        Me.grpHobi.SuspendLayout()
        Me.grpPeran.SuspendLayout()
        CType(Me.picFotoProfil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabDataUtama)
        Me.TabControl1.Controls.Add(Me.tabKontakInfo)
        Me.TabControl1.Controls.Add(Me.tabProfilAktivitas)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1337, 1060)
        Me.TabControl1.TabIndex = 0
        '
        'tabDataUtama
        '
        Me.tabDataUtama.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tabDataUtama.Controls.Add(Me.btnKeTab2)
        Me.tabDataUtama.Controls.Add(Me.cmbKomunitas)
        Me.tabDataUtama.Controls.Add(Me.lblKomunitas)
        Me.tabDataUtama.Controls.Add(Me.grpJenisKelamin)
        Me.tabDataUtama.Controls.Add(Me.dtpTanggalLahir)
        Me.tabDataUtama.Controls.Add(Me.lblTglLahir)
        Me.tabDataUtama.Controls.Add(Me.txtID)
        Me.tabDataUtama.Controls.Add(Me.lblID)
        Me.tabDataUtama.Controls.Add(Me.txtNama)
        Me.tabDataUtama.Controls.Add(Me.lblNama)
        Me.tabDataUtama.Controls.Add(Me.lblHeaderTab1)
        Me.tabDataUtama.Location = New System.Drawing.Point(8, 51)
        Me.tabDataUtama.Margin = New System.Windows.Forms.Padding(5)
        Me.tabDataUtama.Name = "tabDataUtama"
        Me.tabDataUtama.Padding = New System.Windows.Forms.Padding(14, 13, 14, 13)
        Me.tabDataUtama.Size = New System.Drawing.Size(1321, 1001)
        Me.tabDataUtama.TabIndex = 0
        Me.tabDataUtama.Text = " Tab 1 - Data Utama "
        '
        'btnKeTab2
        '
        Me.btnKeTab2.BackColor = System.Drawing.Color.Blue
        Me.btnKeTab2.FlatAppearance.BorderSize = 0
        Me.btnKeTab2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeTab2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnKeTab2.ForeColor = System.Drawing.Color.White
        Me.btnKeTab2.Location = New System.Drawing.Point(994, 925)
        Me.btnKeTab2.Margin = New System.Windows.Forms.Padding(5)
        Me.btnKeTab2.Name = "btnKeTab2"
        Me.btnKeTab2.Size = New System.Drawing.Size(274, 60)
        Me.btnKeTab2.TabIndex = 0
        Me.btnKeTab2.Text = "Lanjut ke Kontak >>"
        Me.btnKeTab2.UseVisualStyleBackColor = False
        '
        'cmbKomunitas
        '
        Me.cmbKomunitas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKomunitas.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbKomunitas.Items.AddRange(New Object() {"Komunitas Teknologi", "Komunitas Seni", "Komunitas Musik", "Komunitas Olahraga", "Komunitas Literasi", """Komunitas Fotografi", "Komunitas Lingkungan", "Komunitas Bisnis & Wirausaha", "Komunitas Gaming", "Divisi IT", "Divisi Marketing", "Divisi Kreatif", "Divisi Operasional"})
        Me.cmbKomunitas.Location = New System.Drawing.Point(343, 448)
        Me.cmbKomunitas.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbKomunitas.Name = "cmbKomunitas"
        Me.cmbKomunitas.Size = New System.Drawing.Size(546, 45)
        Me.cmbKomunitas.TabIndex = 1
        '
        'lblKomunitas
        '
        Me.lblKomunitas.AutoSize = True
        Me.lblKomunitas.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblKomunitas.Location = New System.Drawing.Point(51, 453)
        Me.lblKomunitas.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblKomunitas.Name = "lblKomunitas"
        Me.lblKomunitas.Size = New System.Drawing.Size(249, 37)
        Me.lblKomunitas.TabIndex = 2
        Me.lblKomunitas.Text = "Komunitas / Divisi *"
        '
        'grpJenisKelamin
        '
        Me.grpJenisKelamin.Controls.Add(Me.rbLakiLaki)
        Me.grpJenisKelamin.Controls.Add(Me.rbPerempuan)
        Me.grpJenisKelamin.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.grpJenisKelamin.Location = New System.Drawing.Point(51, 317)
        Me.grpJenisKelamin.Margin = New System.Windows.Forms.Padding(5)
        Me.grpJenisKelamin.Name = "grpJenisKelamin"
        Me.grpJenisKelamin.Padding = New System.Windows.Forms.Padding(5)
        Me.grpJenisKelamin.Size = New System.Drawing.Size(771, 100)
        Me.grpJenisKelamin.TabIndex = 3
        Me.grpJenisKelamin.TabStop = False
        Me.grpJenisKelamin.Text = "Jenis Kelamin *"
        '
        'rbLakiLaki
        '
        Me.rbLakiLaki.AutoSize = True
        Me.rbLakiLaki.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.rbLakiLaki.Location = New System.Drawing.Point(291, 40)
        Me.rbLakiLaki.Margin = New System.Windows.Forms.Padding(5)
        Me.rbLakiLaki.Name = "rbLakiLaki"
        Me.rbLakiLaki.Size = New System.Drawing.Size(147, 41)
        Me.rbLakiLaki.TabIndex = 0
        Me.rbLakiLaki.Text = "Laki-laki"
        '
        'rbPerempuan
        '
        Me.rbPerempuan.AutoSize = True
        Me.rbPerempuan.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.rbPerempuan.Location = New System.Drawing.Point(480, 40)
        Me.rbPerempuan.Margin = New System.Windows.Forms.Padding(5)
        Me.rbPerempuan.Name = "rbPerempuan"
        Me.rbPerempuan.Size = New System.Drawing.Size(182, 41)
        Me.rbPerempuan.TabIndex = 1
        Me.rbPerempuan.Text = "Perempuan"
        '
        'dtpTanggalLahir
        '
        Me.dtpTanggalLahir.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.dtpTanggalLahir.Location = New System.Drawing.Point(343, 247)
        Me.dtpTanggalLahir.Margin = New System.Windows.Forms.Padding(5)
        Me.dtpTanggalLahir.Name = "dtpTanggalLahir"
        Me.dtpTanggalLahir.Size = New System.Drawing.Size(477, 43)
        Me.dtpTanggalLahir.TabIndex = 4
        '
        'lblTglLahir
        '
        Me.lblTglLahir.AutoSize = True
        Me.lblTglLahir.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblTglLahir.Location = New System.Drawing.Point(51, 252)
        Me.lblTglLahir.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTglLahir.Name = "lblTglLahir"
        Me.lblTglLahir.Size = New System.Drawing.Size(193, 37)
        Me.lblTglLahir.TabIndex = 5
        Me.lblTglLahir.Text = "Tanggal Lahir *"
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtID.Location = New System.Drawing.Point(343, 175)
        Me.txtID.Margin = New System.Windows.Forms.Padding(5)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(340, 43)
        Me.txtID.TabIndex = 6
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblID.Location = New System.Drawing.Point(51, 180)
        Me.lblID.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(171, 37)
        Me.lblID.TabIndex = 7
        Me.lblID.Text = "ID Anggota *"
        '
        'txtNama
        '
        Me.txtNama.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtNama.Location = New System.Drawing.Point(343, 103)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(546, 43)
        Me.txtNama.TabIndex = 8
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblNama.Location = New System.Drawing.Point(51, 108)
        Me.lblNama.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(214, 37)
        Me.lblNama.TabIndex = 9
        Me.lblNama.Text = "Nama Lengkap *"
        '
        'lblHeaderTab1
        '
        Me.lblHeaderTab1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblHeaderTab1.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeaderTab1.ForeColor = System.Drawing.Color.White
        Me.lblHeaderTab1.Location = New System.Drawing.Point(0, 0)
        Me.lblHeaderTab1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblHeaderTab1.Name = "lblHeaderTab1"
        Me.lblHeaderTab1.Size = New System.Drawing.Size(1323, 67)
        Me.lblHeaderTab1.TabIndex = 10
        Me.lblHeaderTab1.Text = "DATA UTAMA ANGGOTA"
        Me.lblHeaderTab1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabKontakInfo
        '
        Me.tabKontakInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tabKontakInfo.Controls.Add(Me.btnKeTab3)
        Me.tabKontakInfo.Controls.Add(Me.btnKeTab1)
        Me.tabKontakInfo.Controls.Add(Me.txtAlamat)
        Me.tabKontakInfo.Controls.Add(Me.lblAlamat)
        Me.tabKontakInfo.Controls.Add(Me.txtEmail)
        Me.tabKontakInfo.Controls.Add(Me.lblEmail)
        Me.tabKontakInfo.Controls.Add(Me.mtbTelepon)
        Me.tabKontakInfo.Controls.Add(Me.lblTelepon)
        Me.tabKontakInfo.Controls.Add(Me.lblHeaderTab2)
        Me.tabKontakInfo.Location = New System.Drawing.Point(8, 51)
        Me.tabKontakInfo.Margin = New System.Windows.Forms.Padding(5)
        Me.tabKontakInfo.Name = "tabKontakInfo"
        Me.tabKontakInfo.Size = New System.Drawing.Size(1321, 1001)
        Me.tabKontakInfo.TabIndex = 1
        Me.tabKontakInfo.Text = " Tab 2 - Kontak & Info "
        '
        'btnKeTab3
        '
        Me.btnKeTab3.BackColor = System.Drawing.Color.Blue
        Me.btnKeTab3.FlatAppearance.BorderSize = 0
        Me.btnKeTab3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeTab3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnKeTab3.ForeColor = System.Drawing.Color.White
        Me.btnKeTab3.Location = New System.Drawing.Point(1011, 925)
        Me.btnKeTab3.Margin = New System.Windows.Forms.Padding(5)
        Me.btnKeTab3.Name = "btnKeTab3"
        Me.btnKeTab3.Size = New System.Drawing.Size(257, 60)
        Me.btnKeTab3.TabIndex = 0
        Me.btnKeTab3.Text = "Lanjut ke Profil >>"
        Me.btnKeTab3.UseVisualStyleBackColor = False
        '
        'btnKeTab1
        '
        Me.btnKeTab1.BackColor = System.Drawing.Color.Gray
        Me.btnKeTab1.FlatAppearance.BorderSize = 0
        Me.btnKeTab1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeTab1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnKeTab1.ForeColor = System.Drawing.Color.White
        Me.btnKeTab1.Location = New System.Drawing.Point(51, 925)
        Me.btnKeTab1.Margin = New System.Windows.Forms.Padding(5)
        Me.btnKeTab1.Name = "btnKeTab1"
        Me.btnKeTab1.Size = New System.Drawing.Size(240, 60)
        Me.btnKeTab1.TabIndex = 1
        Me.btnKeTab1.Text = "<< Kembali"
        Me.btnKeTab1.UseVisualStyleBackColor = False
        '
        'txtAlamat
        '
        Me.txtAlamat.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtAlamat.Location = New System.Drawing.Point(343, 247)
        Me.txtAlamat.Margin = New System.Windows.Forms.Padding(5)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAlamat.Size = New System.Drawing.Size(683, 147)
        Me.txtAlamat.TabIndex = 2
        '
        'lblAlamat
        '
        Me.lblAlamat.AutoSize = True
        Me.lblAlamat.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblAlamat.Location = New System.Drawing.Point(51, 252)
        Me.lblAlamat.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblAlamat.Name = "lblAlamat"
        Me.lblAlamat.Size = New System.Drawing.Size(119, 37)
        Me.lblAlamat.TabIndex = 3
        Me.lblAlamat.Text = "Alamat *"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtEmail.Location = New System.Drawing.Point(343, 175)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(5)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(546, 43)
        Me.txtEmail.TabIndex = 4
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblEmail.Location = New System.Drawing.Point(51, 180)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(100, 37)
        Me.lblEmail.TabIndex = 5
        Me.lblEmail.Text = "Email *"
        '
        'mtbTelepon
        '
        Me.mtbTelepon.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.mtbTelepon.Location = New System.Drawing.Point(343, 103)
        Me.mtbTelepon.Margin = New System.Windows.Forms.Padding(5)
        Me.mtbTelepon.Mask = "0000-0000-0000"
        Me.mtbTelepon.Name = "mtbTelepon"
        Me.mtbTelepon.Size = New System.Drawing.Size(340, 43)
        Me.mtbTelepon.TabIndex = 6
        '
        'lblTelepon
        '
        Me.lblTelepon.AutoSize = True
        Me.lblTelepon.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblTelepon.Location = New System.Drawing.Point(51, 108)
        Me.lblTelepon.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTelepon.Name = "lblTelepon"
        Me.lblTelepon.Size = New System.Drawing.Size(177, 37)
        Me.lblTelepon.TabIndex = 7
        Me.lblTelepon.Text = "No. Telepon *"
        '
        'lblHeaderTab2
        '
        Me.lblHeaderTab2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblHeaderTab2.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeaderTab2.ForeColor = System.Drawing.Color.White
        Me.lblHeaderTab2.Location = New System.Drawing.Point(0, 0)
        Me.lblHeaderTab2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblHeaderTab2.Name = "lblHeaderTab2"
        Me.lblHeaderTab2.Size = New System.Drawing.Size(1323, 67)
        Me.lblHeaderTab2.TabIndex = 8
        Me.lblHeaderTab2.Text = "KONTAK"
        Me.lblHeaderTab2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabProfilAktivitas
        '
        Me.tabProfilAktivitas.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tabProfilAktivitas.Controls.Add(Me.btnSimpanCetak)
        Me.tabProfilAktivitas.Controls.Add(Me.btnBatal)
        Me.tabProfilAktivitas.Controls.Add(Me.btnKeTab2Balik)
        Me.tabProfilAktivitas.Controls.Add(Me.grpHobi)
        Me.tabProfilAktivitas.Controls.Add(Me.grpPeran)
        Me.tabProfilAktivitas.Controls.Add(Me.btnBrowseFoto)
        Me.tabProfilAktivitas.Controls.Add(Me.picFotoProfil)
        Me.tabProfilAktivitas.Controls.Add(Me.lblHeaderTab3)
        Me.tabProfilAktivitas.Location = New System.Drawing.Point(8, 51)
        Me.tabProfilAktivitas.Margin = New System.Windows.Forms.Padding(5)
        Me.tabProfilAktivitas.Name = "tabProfilAktivitas"
        Me.tabProfilAktivitas.Size = New System.Drawing.Size(1321, 1001)
        Me.tabProfilAktivitas.TabIndex = 2
        Me.tabProfilAktivitas.Text = " Tab 3 - Profil & Aktivitas "
        '
        'btnSimpanCetak
        '
        Me.btnSimpanCetak.BackColor = System.Drawing.Color.Lime
        Me.btnSimpanCetak.FlatAppearance.BorderSize = 0
        Me.btnSimpanCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpanCetak.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSimpanCetak.ForeColor = System.Drawing.Color.White
        Me.btnSimpanCetak.Location = New System.Drawing.Point(986, 925)
        Me.btnSimpanCetak.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSimpanCetak.Name = "btnSimpanCetak"
        Me.btnSimpanCetak.Size = New System.Drawing.Size(283, 60)
        Me.btnSimpanCetak.TabIndex = 0
        Me.btnSimpanCetak.Text = "Simpan"
        Me.btnSimpanCetak.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.Red
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnBatal.ForeColor = System.Drawing.Color.White
        Me.btnBatal.Location = New System.Drawing.Point(737, 925)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(5)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(223, 60)
        Me.btnBatal.TabIndex = 1
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnKeTab2Balik
        '
        Me.btnKeTab2Balik.BackColor = System.Drawing.Color.Gray
        Me.btnKeTab2Balik.FlatAppearance.BorderSize = 0
        Me.btnKeTab2Balik.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeTab2Balik.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnKeTab2Balik.ForeColor = System.Drawing.Color.White
        Me.btnKeTab2Balik.Location = New System.Drawing.Point(51, 925)
        Me.btnKeTab2Balik.Margin = New System.Windows.Forms.Padding(5)
        Me.btnKeTab2Balik.Name = "btnKeTab2Balik"
        Me.btnKeTab2Balik.Size = New System.Drawing.Size(240, 60)
        Me.btnKeTab2Balik.TabIndex = 2
        Me.btnKeTab2Balik.Text = "<< Kembali"
        Me.btnKeTab2Balik.UseVisualStyleBackColor = False
        '
        'grpHobi
        '
        Me.grpHobi.Controls.Add(Me.cbFotografi)
        Me.grpHobi.Controls.Add(Me.cbDesain)
        Me.grpHobi.Controls.Add(Me.cbCoding)
        Me.grpHobi.Controls.Add(Me.cbMusik)
        Me.grpHobi.Controls.Add(Me.cbOlahraga)
        Me.grpHobi.Controls.Add(Me.cbMenulis)
        Me.grpHobi.Controls.Add(Me.cbVideografi)
        Me.grpHobi.Controls.Add(Me.cbPublicSpeaking)
        Me.grpHobi.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpHobi.Location = New System.Drawing.Point(51, 458)
        Me.grpHobi.Margin = New System.Windows.Forms.Padding(5)
        Me.grpHobi.Name = "grpHobi"
        Me.grpHobi.Padding = New System.Windows.Forms.Padding(5)
        Me.grpHobi.Size = New System.Drawing.Size(1217, 217)
        Me.grpHobi.TabIndex = 3
        Me.grpHobi.TabStop = False
        Me.grpHobi.Text = "Hobi (Minimal pilih 1)"
        '
        'cbFotografi
        '
        Me.cbFotografi.AutoSize = True
        Me.cbFotografi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cbFotografi.Location = New System.Drawing.Point(34, 50)
        Me.cbFotografi.Margin = New System.Windows.Forms.Padding(5)
        Me.cbFotografi.Name = "cbFotografi"
        Me.cbFotografi.Size = New System.Drawing.Size(142, 36)
        Me.cbFotografi.TabIndex = 0
        Me.cbFotografi.Text = "Fotografi"
        '
        'cbDesain
        '
        Me.cbDesain.AutoSize = True
        Me.cbDesain.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cbDesain.Location = New System.Drawing.Point(34, 100)
        Me.cbDesain.Margin = New System.Windows.Forms.Padding(5)
        Me.cbDesain.Name = "cbDesain"
        Me.cbDesain.Size = New System.Drawing.Size(185, 36)
        Me.cbDesain.TabIndex = 1
        Me.cbDesain.Text = "Desain Grafis"
        '
        'cbCoding
        '
        Me.cbCoding.AutoSize = True
        Me.cbCoding.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cbCoding.Location = New System.Drawing.Point(34, 150)
        Me.cbCoding.Margin = New System.Windows.Forms.Padding(5)
        Me.cbCoding.Name = "cbCoding"
        Me.cbCoding.Size = New System.Drawing.Size(191, 36)
        Me.cbCoding.TabIndex = 2
        Me.cbCoding.Text = "Programming"
        '
        'cbMusik
        '
        Me.cbMusik.AutoSize = True
        Me.cbMusik.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cbMusik.Location = New System.Drawing.Point(343, 50)
        Me.cbMusik.Margin = New System.Windows.Forms.Padding(5)
        Me.cbMusik.Name = "cbMusik"
        Me.cbMusik.Size = New System.Drawing.Size(110, 36)
        Me.cbMusik.TabIndex = 3
        Me.cbMusik.Text = "Musik"
        '
        'cbOlahraga
        '
        Me.cbOlahraga.AutoSize = True
        Me.cbOlahraga.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cbOlahraga.Location = New System.Drawing.Point(343, 100)
        Me.cbOlahraga.Margin = New System.Windows.Forms.Padding(5)
        Me.cbOlahraga.Name = "cbOlahraga"
        Me.cbOlahraga.Size = New System.Drawing.Size(142, 36)
        Me.cbOlahraga.TabIndex = 4
        Me.cbOlahraga.Text = "Olahraga"
        '
        'cbMenulis
        '
        Me.cbMenulis.AutoSize = True
        Me.cbMenulis.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cbMenulis.Location = New System.Drawing.Point(343, 150)
        Me.cbMenulis.Margin = New System.Windows.Forms.Padding(5)
        Me.cbMenulis.Name = "cbMenulis"
        Me.cbMenulis.Size = New System.Drawing.Size(131, 36)
        Me.cbMenulis.TabIndex = 5
        Me.cbMenulis.Text = "Menulis"
        '
        'cbVideografi
        '
        Me.cbVideografi.AutoSize = True
        Me.cbVideografi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cbVideografi.Location = New System.Drawing.Point(669, 50)
        Me.cbVideografi.Margin = New System.Windows.Forms.Padding(5)
        Me.cbVideografi.Name = "cbVideografi"
        Me.cbVideografi.Size = New System.Drawing.Size(156, 36)
        Me.cbVideografi.TabIndex = 6
        Me.cbVideografi.Text = "Videografi"
        '
        'cbPublicSpeaking
        '
        Me.cbPublicSpeaking.AutoSize = True
        Me.cbPublicSpeaking.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cbPublicSpeaking.Location = New System.Drawing.Point(669, 100)
        Me.cbPublicSpeaking.Margin = New System.Windows.Forms.Padding(5)
        Me.cbPublicSpeaking.Name = "cbPublicSpeaking"
        Me.cbPublicSpeaking.Size = New System.Drawing.Size(215, 36)
        Me.cbPublicSpeaking.TabIndex = 7
        Me.cbPublicSpeaking.Text = "Public Speaking"
        '
        'grpPeran
        '
        Me.grpPeran.Controls.Add(Me.rbKetua)
        Me.grpPeran.Controls.Add(Me.rbWakilKetua)
        Me.grpPeran.Controls.Add(Me.rbSekretaris)
        Me.grpPeran.Controls.Add(Me.rbBendahara)
        Me.grpPeran.Controls.Add(Me.rbAnggota)
        Me.grpPeran.Controls.Add(Me.rbAdmin)
        Me.grpPeran.Controls.Add(Me.rbKoordinator)
        Me.grpPeran.Controls.Add(Me.rbRelawan)
        Me.grpPeran.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpPeran.Location = New System.Drawing.Point(343, 83)
        Me.grpPeran.Margin = New System.Windows.Forms.Padding(5)
        Me.grpPeran.Name = "grpPeran"
        Me.grpPeran.Padding = New System.Windows.Forms.Padding(5)
        Me.grpPeran.Size = New System.Drawing.Size(926, 183)
        Me.grpPeran.TabIndex = 4
        Me.grpPeran.TabStop = False
        Me.grpPeran.Text = "Peran dalam Komunitas *"
        '
        'rbKetua
        '
        Me.rbKetua.AutoSize = True
        Me.rbKetua.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rbKetua.Location = New System.Drawing.Point(26, 47)
        Me.rbKetua.Margin = New System.Windows.Forms.Padding(5)
        Me.rbKetua.Name = "rbKetua"
        Me.rbKetua.Size = New System.Drawing.Size(106, 36)
        Me.rbKetua.TabIndex = 0
        Me.rbKetua.Text = "Ketua"
        '
        'rbWakilKetua
        '
        Me.rbWakilKetua.AutoSize = True
        Me.rbWakilKetua.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rbWakilKetua.Location = New System.Drawing.Point(197, 47)
        Me.rbWakilKetua.Margin = New System.Windows.Forms.Padding(5)
        Me.rbWakilKetua.Name = "rbWakilKetua"
        Me.rbWakilKetua.Size = New System.Drawing.Size(170, 36)
        Me.rbWakilKetua.TabIndex = 1
        Me.rbWakilKetua.Text = "Wakil Ketua"
        '
        'rbSekretaris
        '
        Me.rbSekretaris.AutoSize = True
        Me.rbSekretaris.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rbSekretaris.Location = New System.Drawing.Point(403, 47)
        Me.rbSekretaris.Margin = New System.Windows.Forms.Padding(5)
        Me.rbSekretaris.Name = "rbSekretaris"
        Me.rbSekretaris.Size = New System.Drawing.Size(148, 36)
        Me.rbSekretaris.TabIndex = 2
        Me.rbSekretaris.Text = "Sekretaris"
        '
        'rbBendahara
        '
        Me.rbBendahara.AutoSize = True
        Me.rbBendahara.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rbBendahara.Location = New System.Drawing.Point(600, 47)
        Me.rbBendahara.Margin = New System.Windows.Forms.Padding(5)
        Me.rbBendahara.Name = "rbBendahara"
        Me.rbBendahara.Size = New System.Drawing.Size(158, 36)
        Me.rbBendahara.TabIndex = 3
        Me.rbBendahara.Text = "Bendahara"
        '
        'rbAnggota
        '
        Me.rbAnggota.AutoSize = True
        Me.rbAnggota.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rbAnggota.Location = New System.Drawing.Point(26, 103)
        Me.rbAnggota.Margin = New System.Windows.Forms.Padding(5)
        Me.rbAnggota.Name = "rbAnggota"
        Me.rbAnggota.Size = New System.Drawing.Size(136, 36)
        Me.rbAnggota.TabIndex = 4
        Me.rbAnggota.Text = "Anggota"
        '
        'rbAdmin
        '
        Me.rbAdmin.AutoSize = True
        Me.rbAdmin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rbAdmin.Location = New System.Drawing.Point(197, 103)
        Me.rbAdmin.Margin = New System.Windows.Forms.Padding(5)
        Me.rbAdmin.Name = "rbAdmin"
        Me.rbAdmin.Size = New System.Drawing.Size(115, 36)
        Me.rbAdmin.TabIndex = 5
        Me.rbAdmin.Text = "Admin"
        '
        'rbKoordinator
        '
        Me.rbKoordinator.AutoSize = True
        Me.rbKoordinator.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rbKoordinator.Location = New System.Drawing.Point(403, 103)
        Me.rbKoordinator.Margin = New System.Windows.Forms.Padding(5)
        Me.rbKoordinator.Name = "rbKoordinator"
        Me.rbKoordinator.Size = New System.Drawing.Size(170, 36)
        Me.rbKoordinator.TabIndex = 6
        Me.rbKoordinator.Text = "Koordinator"
        '
        'rbRelawan
        '
        Me.rbRelawan.AutoSize = True
        Me.rbRelawan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rbRelawan.Location = New System.Drawing.Point(600, 103)
        Me.rbRelawan.Margin = New System.Windows.Forms.Padding(5)
        Me.rbRelawan.Name = "rbRelawan"
        Me.rbRelawan.Size = New System.Drawing.Size(132, 36)
        Me.rbRelawan.TabIndex = 7
        Me.rbRelawan.Text = "Relawan"
        '
        'btnBrowseFoto
        '
        Me.btnBrowseFoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBrowseFoto.FlatAppearance.BorderSize = 0
        Me.btnBrowseFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowseFoto.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnBrowseFoto.ForeColor = System.Drawing.Color.White
        Me.btnBrowseFoto.Location = New System.Drawing.Point(51, 375)
        Me.btnBrowseFoto.Margin = New System.Windows.Forms.Padding(5)
        Me.btnBrowseFoto.Name = "btnBrowseFoto"
        Me.btnBrowseFoto.Size = New System.Drawing.Size(240, 53)
        Me.btnBrowseFoto.TabIndex = 5
        Me.btnBrowseFoto.Text = "Browse Foto"
        Me.btnBrowseFoto.UseVisualStyleBackColor = False
        '
        'picFotoProfil
        '
        Me.picFotoProfil.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.picFotoProfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picFotoProfil.Location = New System.Drawing.Point(51, 92)
        Me.picFotoProfil.Margin = New System.Windows.Forms.Padding(5)
        Me.picFotoProfil.Name = "picFotoProfil"
        Me.picFotoProfil.Size = New System.Drawing.Size(239, 265)
        Me.picFotoProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFotoProfil.TabIndex = 0
        Me.picFotoProfil.TabStop = False
        '
        'lblHeaderTab3
        '
        Me.lblHeaderTab3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblHeaderTab3.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeaderTab3.ForeColor = System.Drawing.Color.White
        Me.lblHeaderTab3.Location = New System.Drawing.Point(0, 0)
        Me.lblHeaderTab3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblHeaderTab3.Name = "lblHeaderTab3"
        Me.lblHeaderTab3.Size = New System.Drawing.Size(1323, 67)
        Me.lblHeaderTab3.TabIndex = 6
        Me.lblHeaderTab3.Text = "PROFIL & AKTIVITAS ANGGOTA"
        Me.lblHeaderTab3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ofd
        '
        Me.ofd.FileName = "ofd"
        Me.ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp"
        Me.ofd.Title = "Pilih Foto Profil"
        '
        'FormInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1337, 1060)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MinimumSize = New System.Drawing.Size(1346, 1083)
        Me.Name = "FormInput"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input Data Anggota"
        Me.TabControl1.ResumeLayout(False)
        Me.tabDataUtama.ResumeLayout(False)
        Me.tabDataUtama.PerformLayout()
        Me.grpJenisKelamin.ResumeLayout(False)
        Me.grpJenisKelamin.PerformLayout()
        Me.tabKontakInfo.ResumeLayout(False)
        Me.tabKontakInfo.PerformLayout()
        Me.tabProfilAktivitas.ResumeLayout(False)
        Me.grpHobi.ResumeLayout(False)
        Me.grpHobi.PerformLayout()
        Me.grpPeran.ResumeLayout(False)
        Me.grpPeran.PerformLayout()
        CType(Me.picFotoProfil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    ' ── Deklarasi variabel kontrol ────────────────────────────
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabDataUtama As System.Windows.Forms.TabPage
    Friend WithEvents tabKontakInfo As System.Windows.Forms.TabPage
    Friend WithEvents tabProfilAktivitas As System.Windows.Forms.TabPage
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider

    ' Tab 1
    Friend WithEvents lblHeaderTab1 As System.Windows.Forms.Label
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents lblTglLahir As System.Windows.Forms.Label
    Friend WithEvents dtpTanggalLahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents grpJenisKelamin As System.Windows.Forms.GroupBox
    Friend WithEvents rbLakiLaki As System.Windows.Forms.RadioButton
    Friend WithEvents rbPerempuan As System.Windows.Forms.RadioButton
    Friend WithEvents lblKomunitas As System.Windows.Forms.Label
    Friend WithEvents cmbKomunitas As System.Windows.Forms.ComboBox
    Friend WithEvents btnKeTab2 As System.Windows.Forms.Button

    ' Tab 2
    Friend WithEvents lblHeaderTab2 As System.Windows.Forms.Label
    Friend WithEvents lblTelepon As System.Windows.Forms.Label
    Friend WithEvents mtbTelepon As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblAlamat As System.Windows.Forms.Label
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents btnKeTab1 As System.Windows.Forms.Button
    Friend WithEvents btnKeTab3 As System.Windows.Forms.Button

    ' Tab 3
    Friend WithEvents lblHeaderTab3 As System.Windows.Forms.Label
    Friend WithEvents picFotoProfil As System.Windows.Forms.PictureBox
    Friend WithEvents btnBrowseFoto As System.Windows.Forms.Button
    Friend WithEvents grpPeran As System.Windows.Forms.GroupBox
    Friend WithEvents rbKetua As System.Windows.Forms.RadioButton
    Friend WithEvents rbWakilKetua As System.Windows.Forms.RadioButton
    Friend WithEvents rbSekretaris As System.Windows.Forms.RadioButton
    Friend WithEvents rbBendahara As System.Windows.Forms.RadioButton
    Friend WithEvents rbAnggota As System.Windows.Forms.RadioButton
    Friend WithEvents rbAdmin As System.Windows.Forms.RadioButton
    Friend WithEvents rbKoordinator As System.Windows.Forms.RadioButton
    Friend WithEvents rbRelawan As System.Windows.Forms.RadioButton
    Friend WithEvents grpHobi As System.Windows.Forms.GroupBox
    Friend WithEvents cbFotografi As System.Windows.Forms.CheckBox
    Friend WithEvents cbDesain As System.Windows.Forms.CheckBox
    Friend WithEvents cbCoding As System.Windows.Forms.CheckBox
    Friend WithEvents cbMusik As System.Windows.Forms.CheckBox
    Friend WithEvents cbOlahraga As System.Windows.Forms.CheckBox
    Friend WithEvents cbMenulis As System.Windows.Forms.CheckBox
    Friend WithEvents cbVideografi As System.Windows.Forms.CheckBox
    Friend WithEvents cbPublicSpeaking As System.Windows.Forms.CheckBox
    Friend WithEvents btnKeTab2Balik As System.Windows.Forms.Button
    Friend WithEvents btnSimpanCetak As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents ofd As OpenFileDialog
End Class