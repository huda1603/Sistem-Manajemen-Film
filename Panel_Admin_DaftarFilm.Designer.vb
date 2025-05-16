<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Panel_Admin_DaftarFilm
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Panel_Admin_DaftarFilm))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FilmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CetakFilmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CetakFilmDenganGambarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Judul_Film = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Genre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tanggal_Rilis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rating = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gambar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Views = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Judul_Film, Me.Genre, Me.Tanggal_Rilis, Me.Rating, Me.Gambar, Me.Views})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 83)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(612, 312)
        Me.DataGridView1.TabIndex = 0
        '
        'btnEdit
        '
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Location = New System.Drawing.Point(299, 46)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(89, 23)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Edit Film"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Film Dipilih"
        '
        'txtItem
        '
        Me.txtItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItem.Location = New System.Drawing.Point(101, 46)
        Me.txtItem.Multiline = True
        Me.txtItem.Name = "txtItem"
        Me.txtItem.ReadOnly = True
        Me.txtItem.Size = New System.Drawing.Size(192, 23)
        Me.txtItem.TabIndex = 3
        '
        'btnHapus
        '
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.Location = New System.Drawing.Point(394, 46)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(89, 23)
        Me.btnHapus.TabIndex = 4
        Me.btnHapus.Text = "Hapus Film"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.Gold
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.Location = New System.Drawing.Point(489, 46)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(111, 23)
        Me.btnTambah.TabIndex = 5
        Me.btnTambah.Text = "Tambah Film"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilmToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(612, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FilmToolStripMenuItem
        '
        Me.FilmToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CetakFilmToolStripMenuItem, Me.CetakFilmDenganGambarToolStripMenuItem})
        Me.FilmToolStripMenuItem.Name = "FilmToolStripMenuItem"
        Me.FilmToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.FilmToolStripMenuItem.Text = "Film"
        '
        'CetakFilmToolStripMenuItem
        '
        Me.CetakFilmToolStripMenuItem.Name = "CetakFilmToolStripMenuItem"
        Me.CetakFilmToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.CetakFilmToolStripMenuItem.Text = "Cetak Semua Film"
        '
        'CetakFilmDenganGambarToolStripMenuItem
        '
        Me.CetakFilmDenganGambarToolStripMenuItem.Name = "CetakFilmDenganGambarToolStripMenuItem"
        Me.CetakFilmDenganGambarToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.CetakFilmDenganGambarToolStripMenuItem.Text = "Semua Film"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Judul_Film
        '
        Me.Judul_Film.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Judul_Film.HeaderText = "Judul_Film"
        Me.Judul_Film.Name = "Judul_Film"
        Me.Judul_Film.ReadOnly = True
        Me.Judul_Film.Width = 81
        '
        'Genre
        '
        Me.Genre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Genre.HeaderText = "Genre"
        Me.Genre.Name = "Genre"
        Me.Genre.ReadOnly = True
        Me.Genre.Width = 61
        '
        'Tanggal_Rilis
        '
        Me.Tanggal_Rilis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Tanggal_Rilis.HeaderText = "Tanggal_Rilis"
        Me.Tanggal_Rilis.Name = "Tanggal_Rilis"
        Me.Tanggal_Rilis.ReadOnly = True
        Me.Tanggal_Rilis.Width = 96
        '
        'Rating
        '
        Me.Rating.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Rating.HeaderText = "Rating"
        Me.Rating.Name = "Rating"
        Me.Rating.ReadOnly = True
        Me.Rating.Width = 63
        '
        'Gambar
        '
        Me.Gambar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Gambar.HeaderText = "Gambar"
        Me.Gambar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Gambar.Name = "Gambar"
        Me.Gambar.ReadOnly = True
        Me.Gambar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Gambar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Gambar.Width = 69
        '
        'Views
        '
        Me.Views.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Views.HeaderText = "Views"
        Me.Views.Name = "Views"
        Me.Views.ReadOnly = True
        Me.Views.Width = 60
        '
        'Panel_Admin_DaftarFilm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "Panel_Admin_DaftarFilm"
        Me.Size = New System.Drawing.Size(612, 395)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnEdit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtItem As TextBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FilmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CetakFilmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CetakFilmDenganGambarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Judul_Film As DataGridViewTextBoxColumn
    Friend WithEvents Genre As DataGridViewTextBoxColumn
    Friend WithEvents Tanggal_Rilis As DataGridViewTextBoxColumn
    Friend WithEvents Rating As DataGridViewTextBoxColumn
    Friend WithEvents Gambar As DataGridViewImageColumn
    Friend WithEvents Views As DataGridViewTextBoxColumn
End Class
