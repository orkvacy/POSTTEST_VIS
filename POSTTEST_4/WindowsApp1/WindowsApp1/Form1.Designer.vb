' ============================================================
'  Form1.Designer.vb  —  Designer code Form Utama
' ============================================================

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InputDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LihatKartuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpanDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BukaDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.pnlBody = New System.Windows.Forms.Panel()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBody.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MenuStrip1.ForeColor = System.Drawing.Color.White
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputDataToolStripMenuItem, Me.LihatKartuToolStripMenuItem, Me.SimpanDataToolStripMenuItem, Me.BukaDataToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 5, 0, 5)
        Me.MenuStrip1.Size = New System.Drawing.Size(1543, 50)
        Me.MenuStrip1.TabIndex = 0
        '
        'InputDataToolStripMenuItem
        '
        Me.InputDataToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.InputDataToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.InputDataToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        Me.InputDataToolStripMenuItem.Size = New System.Drawing.Size(156, 40)
        Me.InputDataToolStripMenuItem.Text = "Input Data"
        '
        'LihatKartuToolStripMenuItem
        '
        Me.LihatKartuToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.LihatKartuToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.LihatKartuToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        Me.LihatKartuToolStripMenuItem.Size = New System.Drawing.Size(158, 40)
        Me.LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
        '
        'SimpanDataToolStripMenuItem
        '
        Me.SimpanDataToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.SimpanDataToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.SimpanDataToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        Me.SimpanDataToolStripMenuItem.Size = New System.Drawing.Size(120, 40)
        Me.SimpanDataToolStripMenuItem.Text = "Simpan"
        '
        'BukaDataToolStripMenuItem
        '
        Me.BukaDataToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BukaDataToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.BukaDataToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        Me.BukaDataToolStripMenuItem.Size = New System.Drawing.Size(151, 40)
        Me.BukaDataToolStripMenuItem.Text = "Buka Data"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.KeluarToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.KeluarToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(113, 40)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.PictureBoxLogo)
        Me.pnlHeader.Controls.Add(Me.lblJudul)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 50)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(5)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1543, 200)
        Me.pnlHeader.TabIndex = 1
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PictureBoxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxLogo.Location = New System.Drawing.Point(34, 25)
        Me.PictureBoxLogo.Margin = New System.Windows.Forms.Padding(5)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(153, 149)
        Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxLogo.TabIndex = 0
        Me.PictureBoxLogo.TabStop = False
        '
        'lblJudul
        '
        Me.lblJudul.AutoSize = True
        Me.lblJudul.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblJudul.ForeColor = System.Drawing.Color.White
        Me.lblJudul.Location = New System.Drawing.Point(210, 65)
        Me.lblJudul.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(451, 78)
        Me.lblJudul.TabIndex = 1
        Me.lblJudul.Text = "SISTEM KARTU"
        '
        'pnlBody
        '
        Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.pnlBody.Controls.Add(Me.lblWelcome)
        Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBody.Location = New System.Drawing.Point(0, 250)
        Me.pnlBody.Margin = New System.Windows.Forms.Padding(5)
        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.Size = New System.Drawing.Size(1543, 717)
        Me.pnlBody.TabIndex = 0
        '
        'lblWelcome
        '
        Me.lblWelcome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblWelcome.Location = New System.Drawing.Point(0, 0)
        Me.lblWelcome.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(1543, 717)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Silahkan gunakan navigasi bar diatas untuk menyimpan, membuat, dan membuka data k" &
    "artu"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ofd
        '
        Me.ofd.FileName = "ofd"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1543, 967)
        Me.Controls.Add(Me.pnlBody)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MinimumSize = New System.Drawing.Size(1524, 983)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistem Kartu Komunitas"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBody.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    ' ── Deklarasi variabel kontrol ────────────────────────────
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents PictureBoxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents pnlBody As System.Windows.Forms.Panel
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents ofd As OpenFileDialog
    Friend WithEvents sfd As SaveFileDialog
End Class