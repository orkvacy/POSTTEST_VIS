<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pbFoto = New System.Windows.Forms.PictureBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.gbJenisKelamin = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rbPerempuan = New System.Windows.Forms.RadioButton()
        Me.rbLaki = New System.Windows.Forms.RadioButton()
        Me.pnlFoto = New System.Windows.Forms.Panel()
        Me.lblFotoSec = New System.Windows.Forms.Label()
        Me.pnlFotoSep = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtUmur = New System.Windows.Forms.TextBox()
        Me.txtNoTelp = New System.Windows.Forms.TextBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.dtpTanggalLahir = New System.Windows.Forms.DateTimePicker()
        Me.gbHobby = New System.Windows.Forms.GroupBox()
        Me.chkHobby1 = New System.Windows.Forms.CheckBox()
        Me.chkHobby2 = New System.Windows.Forms.CheckBox()
        Me.chkHobby3 = New System.Windows.Forms.CheckBox()
        Me.chkHobby4 = New System.Windows.Forms.CheckBox()
        Me.chkHobby5 = New System.Windows.Forms.CheckBox()
        Me.chkHobby6 = New System.Windows.Forms.CheckBox()
        Me.chkHobby7 = New System.Windows.Forms.CheckBox()
        Me.chkHobby8 = New System.Windows.Forms.CheckBox()
        Me.chkHobby9 = New System.Windows.Forms.CheckBox()
        Me.chkHobby10 = New System.Windows.Forms.CheckBox()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblError = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbJenisKelamin.SuspendLayout()
        Me.pnlFoto.SuspendLayout()
        Me.gbHobby.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbFoto
        '
        Me.pbFoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbFoto.Location = New System.Drawing.Point(35, 48)
        Me.pbFoto.Name = "pbFoto"
        Me.pbFoto.Size = New System.Drawing.Size(291, 290)
        Me.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFoto.TabIndex = 0
        Me.pbFoto.TabStop = False
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.Aqua
        Me.btnBrowse.Font = New System.Drawing.Font("Segoe Fluent Icons", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.Location = New System.Drawing.Point(35, 370)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(285, 53)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Upload Foto"
        Me.btnBrowse.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'gbJenisKelamin
        '
        Me.gbJenisKelamin.Controls.Add(Me.Label6)
        Me.gbJenisKelamin.Controls.Add(Me.rbPerempuan)
        Me.gbJenisKelamin.Controls.Add(Me.rbLaki)
        Me.gbJenisKelamin.Location = New System.Drawing.Point(30, 442)
        Me.gbJenisKelamin.Name = "gbJenisKelamin"
        Me.gbJenisKelamin.Size = New System.Drawing.Size(301, 135)
        Me.gbJenisKelamin.TabIndex = 7
        Me.gbJenisKelamin.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(-1, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(189, 32)
        Me.Label6.TabIndex = 106
        Me.Label6.Text = "Jenis Kelamin *"
        '
        'rbPerempuan
        '
        Me.rbPerempuan.AutoSize = True
        Me.rbPerempuan.Location = New System.Drawing.Point(33, 85)
        Me.rbPerempuan.Name = "rbPerempuan"
        Me.rbPerempuan.Size = New System.Drawing.Size(153, 29)
        Me.rbPerempuan.TabIndex = 1
        Me.rbPerempuan.TabStop = True
        Me.rbPerempuan.Text = "Perempuan"
        Me.rbPerempuan.UseVisualStyleBackColor = True
        '
        'rbLaki
        '
        Me.rbLaki.AutoSize = True
        Me.rbLaki.Location = New System.Drawing.Point(33, 44)
        Me.rbLaki.Name = "rbLaki"
        Me.rbLaki.Size = New System.Drawing.Size(130, 29)
        Me.rbLaki.TabIndex = 0
        Me.rbLaki.TabStop = True
        Me.rbLaki.Text = "Laki-Laki"
        Me.rbLaki.UseVisualStyleBackColor = True
        '
        'pnlFoto
        '
        Me.pnlFoto.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pnlFoto.Controls.Add(Me.lblFotoSec)
        Me.pnlFoto.Controls.Add(Me.pnlFotoSep)
        Me.pnlFoto.Controls.Add(Me.pbFoto)
        Me.pnlFoto.Controls.Add(Me.btnBrowse)
        Me.pnlFoto.Controls.Add(Me.gbJenisKelamin)
        Me.pnlFoto.Location = New System.Drawing.Point(48, 29)
        Me.pnlFoto.Name = "pnlFoto"
        Me.pnlFoto.Size = New System.Drawing.Size(386, 601)
        Me.pnlFoto.TabIndex = 15
        '
        'lblFotoSec
        '
        Me.lblFotoSec.AutoSize = True
        Me.lblFotoSec.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblFotoSec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.lblFotoSec.Location = New System.Drawing.Point(34, 25)
        Me.lblFotoSec.Name = "lblFotoSec"
        Me.lblFotoSec.Size = New System.Drawing.Size(135, 32)
        Me.lblFotoSec.TabIndex = 8
        Me.lblFotoSec.Text = "Foto Profil"
        '
        'pnlFotoSep
        '
        Me.pnlFotoSep.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.pnlFotoSep.Location = New System.Drawing.Point(40, 43)
        Me.pnlFotoSep.Name = "pnlFotoSep"
        Me.pnlFotoSep.Size = New System.Drawing.Size(291, 2)
        Me.pnlFotoSep.TabIndex = 105
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(22, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(750, 2)
        Me.Panel1.TabIndex = 106
        '
        'txtNama
        '
        Me.txtNama.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNama.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtNama.Location = New System.Drawing.Point(22, 82)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(345, 43)
        Me.txtNama.TabIndex = 2
        '
        'txtUmur
        '
        Me.txtUmur.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtUmur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUmur.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtUmur.Location = New System.Drawing.Point(397, 82)
        Me.txtUmur.Name = "txtUmur"
        Me.txtUmur.Size = New System.Drawing.Size(355, 43)
        Me.txtUmur.TabIndex = 3
        '
        'txtNoTelp
        '
        Me.txtNoTelp.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtNoTelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoTelp.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtNoTelp.Location = New System.Drawing.Point(397, 155)
        Me.txtNoTelp.Name = "txtNoTelp"
        Me.txtNoTelp.Size = New System.Drawing.Size(355, 43)
        Me.txtNoTelp.TabIndex = 4
        '
        'txtAlamat
        '
        Me.txtAlamat.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtAlamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAlamat.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtAlamat.Location = New System.Drawing.Point(22, 231)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAlamat.Size = New System.Drawing.Size(730, 62)
        Me.txtAlamat.TabIndex = 5
        '
        'dtpTanggalLahir
        '
        Me.dtpTanggalLahir.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.dtpTanggalLahir.Location = New System.Drawing.Point(22, 152)
        Me.dtpTanggalLahir.Name = "dtpTanggalLahir"
        Me.dtpTanggalLahir.Size = New System.Drawing.Size(345, 43)
        Me.dtpTanggalLahir.TabIndex = 6
        '
        'gbHobby
        '
        Me.gbHobby.Controls.Add(Me.chkHobby10)
        Me.gbHobby.Controls.Add(Me.chkHobby9)
        Me.gbHobby.Controls.Add(Me.chkHobby8)
        Me.gbHobby.Controls.Add(Me.chkHobby7)
        Me.gbHobby.Controls.Add(Me.chkHobby6)
        Me.gbHobby.Controls.Add(Me.chkHobby5)
        Me.gbHobby.Controls.Add(Me.chkHobby4)
        Me.gbHobby.Controls.Add(Me.chkHobby3)
        Me.gbHobby.Controls.Add(Me.chkHobby2)
        Me.gbHobby.Controls.Add(Me.chkHobby1)
        Me.gbHobby.Location = New System.Drawing.Point(28, 322)
        Me.gbHobby.Name = "gbHobby"
        Me.gbHobby.Size = New System.Drawing.Size(747, 231)
        Me.gbHobby.TabIndex = 8
        Me.gbHobby.TabStop = False
        '
        'chkHobby1
        '
        Me.chkHobby1.AutoSize = True
        Me.chkHobby1.Location = New System.Drawing.Point(7, 31)
        Me.chkHobby1.Name = "chkHobby1"
        Me.chkHobby1.Size = New System.Drawing.Size(112, 29)
        Me.chkHobby1.TabIndex = 0
        Me.chkHobby1.Text = "Coding"
        Me.chkHobby1.UseVisualStyleBackColor = True
        '
        'chkHobby2
        '
        Me.chkHobby2.AutoSize = True
        Me.chkHobby2.Location = New System.Drawing.Point(7, 67)
        Me.chkHobby2.Name = "chkHobby2"
        Me.chkHobby2.Size = New System.Drawing.Size(132, 29)
        Me.chkHobby2.TabIndex = 1
        Me.chkHobby2.Text = "Olahraga"
        Me.chkHobby2.UseVisualStyleBackColor = True
        '
        'chkHobby3
        '
        Me.chkHobby3.AutoSize = True
        Me.chkHobby3.Location = New System.Drawing.Point(7, 103)
        Me.chkHobby3.Name = "chkHobby3"
        Me.chkHobby3.Size = New System.Drawing.Size(137, 29)
        Me.chkHobby3.TabIndex = 2
        Me.chkHobby3.Text = "Menyanyi"
        Me.chkHobby3.UseVisualStyleBackColor = True
        '
        'chkHobby4
        '
        Me.chkHobby4.AutoSize = True
        Me.chkHobby4.Location = New System.Drawing.Point(11, 139)
        Me.chkHobby4.Name = "chkHobby4"
        Me.chkHobby4.Size = New System.Drawing.Size(138, 29)
        Me.chkHobby4.TabIndex = 3
        Me.chkHobby4.Text = "Membaca"
        Me.chkHobby4.UseVisualStyleBackColor = True
        '
        'chkHobby5
        '
        Me.chkHobby5.AutoSize = True
        Me.chkHobby5.Location = New System.Drawing.Point(13, 175)
        Me.chkHobby5.Name = "chkHobby5"
        Me.chkHobby5.Size = New System.Drawing.Size(111, 29)
        Me.chkHobby5.TabIndex = 4
        Me.chkHobby5.Text = "Belajar"
        Me.chkHobby5.UseVisualStyleBackColor = True
        '
        'chkHobby6
        '
        Me.chkHobby6.AutoSize = True
        Me.chkHobby6.Location = New System.Drawing.Point(369, 30)
        Me.chkHobby6.Name = "chkHobby6"
        Me.chkHobby6.Size = New System.Drawing.Size(133, 29)
        Me.chkHobby6.TabIndex = 5
        Me.chkHobby6.Text = "Traveling"
        Me.chkHobby6.UseVisualStyleBackColor = True
        '
        'chkHobby7
        '
        Me.chkHobby7.AutoSize = True
        Me.chkHobby7.Location = New System.Drawing.Point(369, 66)
        Me.chkHobby7.Name = "chkHobby7"
        Me.chkHobby7.Size = New System.Drawing.Size(135, 29)
        Me.chkHobby7.TabIndex = 6
        Me.chkHobby7.Text = "Kulineran"
        Me.chkHobby7.UseVisualStyleBackColor = True
        '
        'chkHobby8
        '
        Me.chkHobby8.AutoSize = True
        Me.chkHobby8.Location = New System.Drawing.Point(369, 102)
        Me.chkHobby8.Name = "chkHobby8"
        Me.chkHobby8.Size = New System.Drawing.Size(124, 29)
        Me.chkHobby8.TabIndex = 7
        Me.chkHobby8.Text = "Berkuda"
        Me.chkHobby8.UseVisualStyleBackColor = True
        '
        'chkHobby9
        '
        Me.chkHobby9.AutoSize = True
        Me.chkHobby9.Location = New System.Drawing.Point(369, 138)
        Me.chkHobby9.Name = "chkHobby9"
        Me.chkHobby9.Size = New System.Drawing.Size(124, 29)
        Me.chkHobby9.TabIndex = 8
        Me.chkHobby9.Text = "Berlayar"
        Me.chkHobby9.UseVisualStyleBackColor = True
        '
        'chkHobby10
        '
        Me.chkHobby10.AutoSize = True
        Me.chkHobby10.Location = New System.Drawing.Point(369, 174)
        Me.chkHobby10.Name = "chkHobby10"
        Me.chkHobby10.Size = New System.Drawing.Size(146, 29)
        Me.chkHobby10.TabIndex = 9
        Me.chkHobby10.Text = "Sky Diving"
        Me.chkHobby10.UseVisualStyleBackColor = True
        '
        'btnCetak
        '
        Me.btnCetak.Location = New System.Drawing.Point(576, 559)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(199, 56)
        Me.btnCetak.TabIndex = 9
        Me.btnCetak.Text = "cetak"
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(22, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 32)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Nama Lengkap *"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(397, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 31)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Umur * (tahun)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(22, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 31)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Tanggal Lahir *"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(397, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(187, 31)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Nomor Telepon *"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(22, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 31)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Alamat *"
        '
        'pnlRight
        '
        Me.pnlRight.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pnlRight.Controls.Add(Me.lblError)
        Me.pnlRight.Controls.Add(Me.Label8)
        Me.pnlRight.Controls.Add(Me.Label7)
        Me.pnlRight.Controls.Add(Me.Label5)
        Me.pnlRight.Controls.Add(Me.Label4)
        Me.pnlRight.Controls.Add(Me.Panel2)
        Me.pnlRight.Controls.Add(Me.Panel1)
        Me.pnlRight.Controls.Add(Me.Label3)
        Me.pnlRight.Controls.Add(Me.Label2)
        Me.pnlRight.Controls.Add(Me.Label1)
        Me.pnlRight.Controls.Add(Me.btnCetak)
        Me.pnlRight.Controls.Add(Me.gbHobby)
        Me.pnlRight.Controls.Add(Me.dtpTanggalLahir)
        Me.pnlRight.Controls.Add(Me.txtAlamat)
        Me.pnlRight.Controls.Add(Me.txtNoTelp)
        Me.pnlRight.Controls.Add(Me.txtUmur)
        Me.pnlRight.Controls.Add(Me.txtNama)
        Me.pnlRight.Location = New System.Drawing.Point(479, 32)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(805, 625)
        Me.pnlRight.TabIndex = 107
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(17, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 32)
        Me.Label7.TabIndex = 106
        Me.Label7.Text = "Data Pribadi"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(23, 300)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 32)
        Me.Label8.TabIndex = 107
        Me.Label8.Text = "Hobi"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(28, 322)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(750, 2)
        Me.Panel2.TabIndex = 108
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.ForeColor = System.Drawing.Color.Crimson
        Me.lblError.Location = New System.Drawing.Point(157, 573)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(77, 25)
        Me.lblError.TabIndex = 109
        Me.lblError.Text = "Label9"
        Me.lblError.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1510, 660)
        Me.Controls.Add(Me.pnlRight)
        Me.Controls.Add(Me.pnlFoto)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbJenisKelamin.ResumeLayout(False)
        Me.gbJenisKelamin.PerformLayout()
        Me.pnlFoto.ResumeLayout(False)
        Me.pnlFoto.PerformLayout()
        Me.gbHobby.ResumeLayout(False)
        Me.gbHobby.PerformLayout()
        Me.pnlRight.ResumeLayout(False)
        Me.pnlRight.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents gbJenisKelamin As GroupBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Friend WithEvents pnlFoto As Panel
    Friend WithEvents lblFotoSec As Label
    Friend WithEvents pnlFotoSep As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtNoTelp As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents gbHobby As GroupBox
    Friend WithEvents chkHobby10 As CheckBox
    Friend WithEvents chkHobby9 As CheckBox
    Friend WithEvents chkHobby8 As CheckBox
    Friend WithEvents chkHobby7 As CheckBox
    Friend WithEvents chkHobby6 As CheckBox
    Friend WithEvents chkHobby5 As CheckBox
    Friend WithEvents chkHobby4 As CheckBox
    Friend WithEvents chkHobby3 As CheckBox
    Friend WithEvents chkHobby2 As CheckBox
    Friend WithEvents chkHobby1 As CheckBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents pnlRight As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblError As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
