<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Halaman_Edit_Admin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbDra = New System.Windows.Forms.CheckBox()
        Me.cbMus = New System.Windows.Forms.CheckBox()
        Me.cbSciFi = New System.Windows.Forms.CheckBox()
        Me.cbCom = New System.Windows.Forms.CheckBox()
        Me.cbRom = New System.Windows.Forms.CheckBox()
        Me.cbHor = New System.Windows.Forms.CheckBox()
        Me.cbAdv = New System.Windows.Forms.CheckBox()
        Me.cbMis = New System.Windows.Forms.CheckBox()
        Me.cbAct = New System.Windows.Forms.CheckBox()
        Me.cbThr = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tanggalRilis = New System.Windows.Forms.DateTimePicker()
        Me.txtJudul = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BukaGambar = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(77, 56)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(646, 50)
        Me.Panel2.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(22, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Edit Film"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.btnBrowse)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.btnBatal)
        Me.Panel3.Controls.Add(Me.btnEdit)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.tanggalRilis)
        Me.Panel3.Controls.Add(Me.txtJudul)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(77, 106)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(646, 289)
        Me.Panel3.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbDra)
        Me.GroupBox1.Controls.Add(Me.cbMus)
        Me.GroupBox1.Controls.Add(Me.cbSciFi)
        Me.GroupBox1.Controls.Add(Me.cbCom)
        Me.GroupBox1.Controls.Add(Me.cbRom)
        Me.GroupBox1.Controls.Add(Me.cbHor)
        Me.GroupBox1.Controls.Add(Me.cbAdv)
        Me.GroupBox1.Controls.Add(Me.cbMis)
        Me.GroupBox1.Controls.Add(Me.cbAct)
        Me.GroupBox1.Controls.Add(Me.cbThr)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 138)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Genre"
        '
        'cbDra
        '
        Me.cbDra.AutoSize = True
        Me.cbDra.Location = New System.Drawing.Point(87, 63)
        Me.cbDra.Name = "cbDra"
        Me.cbDra.Size = New System.Drawing.Size(57, 17)
        Me.cbDra.TabIndex = 38
        Me.cbDra.Text = "Drama"
        Me.cbDra.UseVisualStyleBackColor = True
        '
        'cbMus
        '
        Me.cbMus.AutoSize = True
        Me.cbMus.Location = New System.Drawing.Point(87, 109)
        Me.cbMus.Name = "cbMus"
        Me.cbMus.Size = New System.Drawing.Size(62, 17)
        Me.cbMus.TabIndex = 37
        Me.cbMus.Text = "Musical"
        Me.cbMus.UseVisualStyleBackColor = True
        '
        'cbSciFi
        '
        Me.cbSciFi.AutoSize = True
        Me.cbSciFi.Location = New System.Drawing.Point(87, 17)
        Me.cbSciFi.Name = "cbSciFi"
        Me.cbSciFi.Size = New System.Drawing.Size(99, 17)
        Me.cbSciFi.TabIndex = 33
        Me.cbSciFi.Text = "Science Fiction"
        Me.cbSciFi.UseVisualStyleBackColor = True
        '
        'cbCom
        '
        Me.cbCom.AutoSize = True
        Me.cbCom.Location = New System.Drawing.Point(87, 40)
        Me.cbCom.Name = "cbCom"
        Me.cbCom.Size = New System.Drawing.Size(64, 17)
        Me.cbCom.TabIndex = 32
        Me.cbCom.Text = "Comedy"
        Me.cbCom.UseVisualStyleBackColor = True
        '
        'cbRom
        '
        Me.cbRom.AutoSize = True
        Me.cbRom.Location = New System.Drawing.Point(6, 109)
        Me.cbRom.Name = "cbRom"
        Me.cbRom.Size = New System.Drawing.Size(71, 17)
        Me.cbRom.TabIndex = 36
        Me.cbRom.Text = "Romantic"
        Me.cbRom.UseVisualStyleBackColor = True
        '
        'cbHor
        '
        Me.cbHor.AutoSize = True
        Me.cbHor.Location = New System.Drawing.Point(6, 40)
        Me.cbHor.Name = "cbHor"
        Me.cbHor.Size = New System.Drawing.Size(55, 17)
        Me.cbHor.TabIndex = 30
        Me.cbHor.Text = "Horror"
        Me.cbHor.UseVisualStyleBackColor = True
        '
        'cbAdv
        '
        Me.cbAdv.AutoSize = True
        Me.cbAdv.Location = New System.Drawing.Point(6, 17)
        Me.cbAdv.Name = "cbAdv"
        Me.cbAdv.Size = New System.Drawing.Size(75, 17)
        Me.cbAdv.TabIndex = 29
        Me.cbAdv.Text = "Adventure"
        Me.cbAdv.UseVisualStyleBackColor = True
        '
        'cbMis
        '
        Me.cbMis.AutoSize = True
        Me.cbMis.Location = New System.Drawing.Point(87, 86)
        Me.cbMis.Name = "cbMis"
        Me.cbMis.Size = New System.Drawing.Size(59, 17)
        Me.cbMis.TabIndex = 35
        Me.cbMis.Text = "Mistery"
        Me.cbMis.UseVisualStyleBackColor = True
        '
        'cbAct
        '
        Me.cbAct.AutoSize = True
        Me.cbAct.Location = New System.Drawing.Point(6, 63)
        Me.cbAct.Name = "cbAct"
        Me.cbAct.Size = New System.Drawing.Size(56, 17)
        Me.cbAct.TabIndex = 31
        Me.cbAct.Text = "Action"
        Me.cbAct.UseVisualStyleBackColor = True
        '
        'cbThr
        '
        Me.cbThr.AutoSize = True
        Me.cbThr.Location = New System.Drawing.Point(6, 86)
        Me.cbThr.Name = "cbThr"
        Me.cbThr.Size = New System.Drawing.Size(57, 17)
        Me.cbThr.TabIndex = 34
        Me.cbThr.Text = "Thriller"
        Me.cbThr.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(529, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(94, 103)
        Me.Panel1.TabIndex = 45
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.LightGray
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBrowse.Location = New System.Drawing.Point(529, 140)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(94, 26)
        Me.btnBrowse.TabIndex = 44
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(547, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 16)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Gambar"
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.Gainsboro
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBatal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Image = Global.Sistem_Manajemen_Film.My.Resources.Resources.back_arrow
        Me.btnBatal.Location = New System.Drawing.Point(610, 252)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(33, 33)
        Me.btnBatal.TabIndex = 17
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.LimeGreen
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEdit.Location = New System.Drawing.Point(21, 256)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(80, 25)
        Me.btnEdit.TabIndex = 16
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Tanggal Rilis"
        '
        'tanggalRilis
        '
        Me.tanggalRilis.Location = New System.Drawing.Point(21, 77)
        Me.tanggalRilis.Name = "tanggalRilis"
        Me.tanggalRilis.Size = New System.Drawing.Size(260, 20)
        Me.tanggalRilis.TabIndex = 4
        '
        'txtJudul
        '
        Me.txtJudul.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJudul.Location = New System.Drawing.Point(21, 31)
        Me.txtJudul.Name = "txtJudul"
        Me.txtJudul.Size = New System.Drawing.Size(260, 20)
        Me.txtJudul.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Judul"
        '
        'BukaGambar
        '
        Me.BukaGambar.FileName = "OpenFileDialog1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 103)
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'Halaman_Edit_Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "Halaman_Edit_Admin"
        Me.Text = "Halaman_Edit_Admin"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbDra As CheckBox
    Friend WithEvents cbMus As CheckBox
    Friend WithEvents cbSciFi As CheckBox
    Friend WithEvents cbCom As CheckBox
    Friend WithEvents cbRom As CheckBox
    Friend WithEvents cbHor As CheckBox
    Friend WithEvents cbAdv As CheckBox
    Friend WithEvents cbMis As CheckBox
    Friend WithEvents cbAct As CheckBox
    Friend WithEvents cbThr As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents tanggalRilis As DateTimePicker
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BukaGambar As OpenFileDialog
End Class
