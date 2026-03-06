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
        Me.txtJudul = New System.Windows.Forms.TextBox()
        Me.txtGenre = New System.Windows.Forms.TextBox()
        Me.txtDelBuku = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.lblText = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtJudul
        '
        Me.txtJudul.Location = New System.Drawing.Point(33, 122)
        Me.txtJudul.Name = "txtJudul"
        Me.txtJudul.Size = New System.Drawing.Size(313, 31)
        Me.txtJudul.TabIndex = 0
        '
        'txtGenre
        '
        Me.txtGenre.Location = New System.Drawing.Point(33, 213)
        Me.txtGenre.Name = "txtGenre"
        Me.txtGenre.Size = New System.Drawing.Size(313, 31)
        Me.txtGenre.TabIndex = 1
        '
        'txtDelBuku
        '
        Me.txtDelBuku.Location = New System.Drawing.Point(904, 293)
        Me.txtDelBuku.Name = "txtDelBuku"
        Me.txtDelBuku.Size = New System.Drawing.Size(297, 31)
        Me.txtDelBuku.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(33, 273)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(313, 50)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "➕Tambah"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DataGridView1.Location = New System.Drawing.Point(102, 480)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 82
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(1055, 168)
        Me.DataGridView1.TabIndex = 5
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(904, 344)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(326, 50)
        Me.btnDel.TabIndex = 4
        Me.btnDel.Text = "Hapus"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Location = New System.Drawing.Point(788, 678)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(77, 25)
        Me.lblText.TabIndex = 6
        Me.lblText.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Judul Buku"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Genre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(899, 256)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Judul Buku"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(899, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Hapus Buku"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 25)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Tambah Buku"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.txtGenre)
        Me.Panel1.Controls.Add(Me.txtJudul)
        Me.Panel1.Location = New System.Drawing.Point(102, 71)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(382, 353)
        Me.Panel1.TabIndex = 12
        '
        'Column1
        '
        Me.Column1.HeaderText = "Judul Buku"
        Me.Column1.MinimumWidth = 10
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 200
        '
        'Column2
        '
        Me.Column2.HeaderText = "Genre"
        Me.Column2.MinimumWidth = 10
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.HeaderText = "Action"
        Me.Column3.MinimumWidth = 10
        Me.Column3.Name = "Column3"
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column3.Text = "❌"
        Me.Column3.Width = 200
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1524, 732)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.txtDelBuku)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtJudul As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtDelBuku As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnDel As Button
    Friend WithEvents lblText As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewButtonColumn
End Class
