' ============================================================
'  FormKartu.Designer.vb  —  Designer code Kartu ID Card
' ============================================================

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKartu
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
        ' ── Deklarasi kontrol kartu ───────────────────────────
        Me.pnlKartu = New System.Windows.Forms.Panel()
        Me.pnlHeaderKartu = New System.Windows.Forms.Panel()
        Me.lblJudulKartu = New System.Windows.Forms.Label()
        Me.lblKomunitas = New System.Windows.Forms.Label()
        Me.pnlBody = New System.Windows.Forms.Panel()
        Me.picKartu = New System.Windows.Forms.PictureBox()
        Me.pnlInfo = New System.Windows.Forms.Panel()
        Me.lblNamaKartu = New System.Windows.Forms.Label()
        Me.lblIDKartu = New System.Windows.Forms.Label()
        Me.lblPeranKartu = New System.Windows.Forms.Label()
        Me.lblSeparator1 = New System.Windows.Forms.Label()
        Me.lblTglLahirKartu = New System.Windows.Forms.Label()
        Me.lblJKKartu = New System.Windows.Forms.Label()
        Me.lblSeparator2 = New System.Windows.Forms.Label()
        Me.lblTelpKartu = New System.Windows.Forms.Label()
        Me.lblEmailKartu = New System.Windows.Forms.Label()
        Me.lblAlamatKartu = New System.Windows.Forms.Label()
        Me.lblSeparator3 = New System.Windows.Forms.Label()
        Me.lblHobiKartu = New System.Windows.Forms.Label()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.btnCetak = New System.Windows.Forms.Button()

        Me.pnlKartu.SuspendLayout()
        Me.pnlHeaderKartu.SuspendLayout()
        Me.pnlBody.SuspendLayout()
        Me.pnlInfo.SuspendLayout()
        Me.pnlFooter.SuspendLayout()
        CType(Me.picKartu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' ══════════════════════════════════════════════════════
        '  pnlKartu  (container utama kartu, border radius via Paint)
        ' ══════════════════════════════════════════════════════
        Me.pnlKartu.BackColor = System.Drawing.Color.White
        Me.pnlKartu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlKartu.Controls.Add(Me.pnlHeaderKartu)
        Me.pnlKartu.Controls.Add(Me.pnlBody)
        Me.pnlKartu.Controls.Add(Me.pnlFooter)
        Me.pnlKartu.Location = New System.Drawing.Point(20, 15)
        Me.pnlKartu.Name = "pnlKartu"
        Me.pnlKartu.Size = New System.Drawing.Size(500, 680)

        ' ── pnlHeaderKartu ────────────────────────────────────
        Me.pnlHeaderKartu.BackColor = System.Drawing.Color.FromArgb(25, 25, 60)
        Me.pnlHeaderKartu.Controls.Add(Me.lblJudulKartu)
        Me.pnlHeaderKartu.Controls.Add(Me.lblKomunitas)
        Me.pnlHeaderKartu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeaderKartu.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeaderKartu.Name = "pnlHeaderKartu"
        Me.pnlHeaderKartu.Size = New System.Drawing.Size(498, 90)

        Me.lblJudulKartu.AutoSize = False
        Me.lblJudulKartu.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblJudulKartu.Font = New System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Bold)
        Me.lblJudulKartu.ForeColor = System.Drawing.Color.FromArgb(200, 200, 255)
        Me.lblJudulKartu.Location = New System.Drawing.Point(0, 0)
        Me.lblJudulKartu.Name = "lblJudulKartu"
        Me.lblJudulKartu.Size = New System.Drawing.Size(498, 30)
        Me.lblJudulKartu.Text = "KARTU ANGGOTA KOMUNITAS"
        Me.lblJudulKartu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        Me.lblKomunitas.AutoSize = False
        Me.lblKomunitas.Font = New System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold)
        Me.lblKomunitas.ForeColor = System.Drawing.Color.White
        Me.lblKomunitas.Location = New System.Drawing.Point(0, 30)
        Me.lblKomunitas.Name = "lblKomunitas"
        Me.lblKomunitas.Size = New System.Drawing.Size(498, 55)
        Me.lblKomunitas.Text = "NAMA KOMUNITAS"
        Me.lblKomunitas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' ── pnlBody ───────────────────────────────────────────
        Me.pnlBody.BackColor = System.Drawing.Color.White
        Me.pnlBody.Controls.Add(Me.picKartu)
        Me.pnlBody.Controls.Add(Me.pnlInfo)
        Me.pnlBody.Location = New System.Drawing.Point(0, 90)
        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.Size = New System.Drawing.Size(498, 535)

        ' picKartu — foto profil (kiri)
        Me.picKartu.BackColor = System.Drawing.Color.FromArgb(200, 200, 220)
        Me.picKartu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picKartu.Location = New System.Drawing.Point(20, 20)
        Me.picKartu.Name = "picKartu"
        Me.picKartu.Size = New System.Drawing.Size(140, 170)
        Me.picKartu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picKartu.TabIndex = 0
        Me.picKartu.TabStop = False

        ' pnlInfo — panel info sebelah kanan foto
        Me.pnlInfo.BackColor = System.Drawing.Color.White
        Me.pnlInfo.Controls.Add(Me.lblNamaKartu)
        Me.pnlInfo.Controls.Add(Me.lblIDKartu)
        Me.pnlInfo.Controls.Add(Me.lblPeranKartu)
        Me.pnlInfo.Controls.Add(Me.lblSeparator1)
        Me.pnlInfo.Controls.Add(Me.lblTglLahirKartu)
        Me.pnlInfo.Controls.Add(Me.lblJKKartu)
        Me.pnlInfo.Controls.Add(Me.lblSeparator2)
        Me.pnlInfo.Controls.Add(Me.lblTelpKartu)
        Me.pnlInfo.Controls.Add(Me.lblEmailKartu)
        Me.pnlInfo.Controls.Add(Me.lblAlamatKartu)
        Me.pnlInfo.Controls.Add(Me.lblSeparator3)
        Me.pnlInfo.Controls.Add(Me.lblHobiKartu)
        Me.pnlInfo.Location = New System.Drawing.Point(170, 10)
        Me.pnlInfo.Name = "pnlInfo"
        Me.pnlInfo.Size = New System.Drawing.Size(318, 510)

        ' ── Label-label dalam pnlInfo ─────────────────────────
        Dim yOff As Integer = 10

        ' Nama
        Me.lblNamaKartu.AutoSize = False
        Me.lblNamaKartu.Font = New System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold)
        Me.lblNamaKartu.ForeColor = System.Drawing.Color.FromArgb(20, 20, 60)
        Me.lblNamaKartu.Location = New System.Drawing.Point(0, yOff)
        Me.lblNamaKartu.Name = "lblNamaKartu"
        Me.lblNamaKartu.Size = New System.Drawing.Size(318, 30)
        Me.lblNamaKartu.Text = "Nama Anggota"
        yOff += 32

        ' ID
        Me.lblIDKartu.AutoSize = True
        Me.lblIDKartu.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Regular)
        Me.lblIDKartu.ForeColor = System.Drawing.Color.Gray
        Me.lblIDKartu.Location = New System.Drawing.Point(2, yOff)
        Me.lblIDKartu.Name = "lblIDKartu"
        Me.lblIDKartu.Text = "ID: 00000000"
        yOff += 22

        ' Peran (badge-like)
        Me.lblPeranKartu.AutoSize = True
        Me.lblPeranKartu.BackColor = System.Drawing.Color.FromArgb(50, 100, 200)
        Me.lblPeranKartu.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.lblPeranKartu.ForeColor = System.Drawing.Color.White
        Me.lblPeranKartu.Location = New System.Drawing.Point(2, yOff)
        Me.lblPeranKartu.Name = "lblPeranKartu"
        Me.lblPeranKartu.Padding = New System.Windows.Forms.Padding(6, 2, 6, 2)
        Me.lblPeranKartu.Text = "ANGGOTA"
        yOff += 30

        ' Separator 1
        Me.lblSeparator1.AutoSize = False
        Me.lblSeparator1.BackColor = System.Drawing.Color.FromArgb(180, 180, 220)
        Me.lblSeparator1.Location = New System.Drawing.Point(0, yOff + 5)
        Me.lblSeparator1.Name = "lblSeparator1"
        Me.lblSeparator1.Size = New System.Drawing.Size(318, 1)
        yOff += 14

        ' Data pribadi
        Me.lblTglLahirKartu.AutoSize = True
        Me.lblTglLahirKartu.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblTglLahirKartu.ForeColor = System.Drawing.Color.FromArgb(40, 40, 80)
        Me.lblTglLahirKartu.Location = New System.Drawing.Point(2, yOff)
        Me.lblTglLahirKartu.Name = "lblTglLahirKartu"
        Me.lblTglLahirKartu.Text = "Tgl Lahir : -"
        yOff += 22

        Me.lblJKKartu.AutoSize = True
        Me.lblJKKartu.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblJKKartu.ForeColor = System.Drawing.Color.FromArgb(40, 40, 80)
        Me.lblJKKartu.Location = New System.Drawing.Point(2, yOff)
        Me.lblJKKartu.Name = "lblJKKartu"
        Me.lblJKKartu.Text = "Jenis Kelamin : -"
        yOff += 22

        ' Separator 2
        Me.lblSeparator2.AutoSize = False
        Me.lblSeparator2.BackColor = System.Drawing.Color.FromArgb(180, 180, 220)
        Me.lblSeparator2.Location = New System.Drawing.Point(0, yOff + 4)
        Me.lblSeparator2.Name = "lblSeparator2"
        Me.lblSeparator2.Size = New System.Drawing.Size(318, 1)
        yOff += 12

        ' Kontak
        Me.lblTelpKartu.AutoSize = True
        Me.lblTelpKartu.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblTelpKartu.ForeColor = System.Drawing.Color.FromArgb(40, 40, 80)
        Me.lblTelpKartu.Location = New System.Drawing.Point(2, yOff)
        Me.lblTelpKartu.Name = "lblTelpKartu"
        Me.lblTelpKartu.Text = "Telepon : -"
        yOff += 22

        Me.lblEmailKartu.AutoSize = True
        Me.lblEmailKartu.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblEmailKartu.ForeColor = System.Drawing.Color.FromArgb(40, 40, 80)
        Me.lblEmailKartu.Location = New System.Drawing.Point(2, yOff)
        Me.lblEmailKartu.Name = "lblEmailKartu"
        Me.lblEmailKartu.Text = "Email : -"
        yOff += 22

        Me.lblAlamatKartu.AutoSize = False
        Me.lblAlamatKartu.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblAlamatKartu.ForeColor = System.Drawing.Color.FromArgb(40, 40, 80)
        Me.lblAlamatKartu.Location = New System.Drawing.Point(2, yOff)
        Me.lblAlamatKartu.Name = "lblAlamatKartu"
        Me.lblAlamatKartu.Size = New System.Drawing.Size(310, 40)
        Me.lblAlamatKartu.Text = "Alamat : -"
        yOff += 48

        ' Separator 3
        Me.lblSeparator3.AutoSize = False
        Me.lblSeparator3.BackColor = System.Drawing.Color.FromArgb(180, 180, 220)
        Me.lblSeparator3.Location = New System.Drawing.Point(0, yOff + 4)
        Me.lblSeparator3.Name = "lblSeparator3"
        Me.lblSeparator3.Size = New System.Drawing.Size(318, 1)
        yOff += 12

        ' Hobi
        Me.lblHobiKartu.AutoSize = False
        Me.lblHobiKartu.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Italic)
        Me.lblHobiKartu.ForeColor = System.Drawing.Color.FromArgb(80, 80, 140)
        Me.lblHobiKartu.Location = New System.Drawing.Point(2, yOff)
        Me.lblHobiKartu.Name = "lblHobiKartu"
        Me.lblHobiKartu.Size = New System.Drawing.Size(310, 60)
        Me.lblHobiKartu.Text = "Hobi : -"

        ' ── pnlFooter ─────────────────────────────────────────
        Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(240, 240, 255)
        Me.pnlFooter.Controls.Add(Me.btnCetak)
        Me.pnlFooter.Controls.Add(Me.btnTutup)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 625)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(498, 55)

        Me.btnCetak.BackColor = System.Drawing.Color.FromArgb(30, 130, 60)
        Me.btnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCetak.FlatAppearance.BorderSize = 0
        Me.btnCetak.Font = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        Me.btnCetak.ForeColor = System.Drawing.Color.White
        Me.btnCetak.Location = New System.Drawing.Point(260, 10)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(130, 34)
        Me.btnCetak.Text = "Cetak Kartu"

        Me.btnTutup.BackColor = System.Drawing.Color.FromArgb(150, 50, 50)
        Me.btnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTutup.FlatAppearance.BorderSize = 0
        Me.btnTutup.Font = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        Me.btnTutup.ForeColor = System.Drawing.Color.White
        Me.btnTutup.Location = New System.Drawing.Point(105, 10)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(130, 34)
        Me.btnTutup.Text = "Tutup"

        ' ── FormKartu ─────────────────────────────────────────
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(220, 220, 240)
        Me.ClientSize = New System.Drawing.Size(540, 720)
        Me.Controls.Add(Me.pnlKartu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FormKartu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kartu Anggota Komunitas"

        Me.pnlKartu.ResumeLayout(False)
        Me.pnlHeaderKartu.ResumeLayout(False)
        Me.pnlBody.ResumeLayout(False)
        Me.pnlInfo.ResumeLayout(False)
        Me.pnlInfo.PerformLayout()
        Me.pnlFooter.ResumeLayout(False)
        CType(Me.picKartu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    ' ── Deklarasi variabel kontrol ────────────────────────────
    Friend WithEvents pnlKartu As System.Windows.Forms.Panel
    Friend WithEvents pnlHeaderKartu As System.Windows.Forms.Panel
    Friend WithEvents lblJudulKartu As System.Windows.Forms.Label
    Friend WithEvents lblKomunitas As System.Windows.Forms.Label
    Friend WithEvents pnlBody As System.Windows.Forms.Panel
    Friend WithEvents picKartu As System.Windows.Forms.PictureBox
    Friend WithEvents pnlInfo As System.Windows.Forms.Panel
    Friend WithEvents lblNamaKartu As System.Windows.Forms.Label
    Friend WithEvents lblIDKartu As System.Windows.Forms.Label
    Friend WithEvents lblPeranKartu As System.Windows.Forms.Label
    Friend WithEvents lblSeparator1 As System.Windows.Forms.Label
    Friend WithEvents lblTglLahirKartu As System.Windows.Forms.Label
    Friend WithEvents lblJKKartu As System.Windows.Forms.Label
    Friend WithEvents lblSeparator2 As System.Windows.Forms.Label
    Friend WithEvents lblTelpKartu As System.Windows.Forms.Label
    Friend WithEvents lblEmailKartu As System.Windows.Forms.Label
    Friend WithEvents lblAlamatKartu As System.Windows.Forms.Label
    Friend WithEvents lblSeparator3 As System.Windows.Forms.Label
    Friend WithEvents lblHobiKartu As System.Windows.Forms.Label
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents btnCetak As System.Windows.Forms.Button
    Friend WithEvents btnTutup As System.Windows.Forms.Button

End Class