<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Panel_Filter
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbRating = New System.Windows.Forms.RadioButton()
        Me.rbJudul = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbDesc = New System.Windows.Forms.RadioButton()
        Me.rbAsc = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbDra = New System.Windows.Forms.CheckBox()
        Me.cbAdv = New System.Windows.Forms.CheckBox()
        Me.cbMus = New System.Windows.Forms.CheckBox()
        Me.cbThr = New System.Windows.Forms.CheckBox()
        Me.cbSciFi = New System.Windows.Forms.CheckBox()
        Me.cbAct = New System.Windows.Forms.CheckBox()
        Me.cbCom = New System.Windows.Forms.CheckBox()
        Me.cbMis = New System.Windows.Forms.CheckBox()
        Me.cbRom = New System.Windows.Forms.CheckBox()
        Me.cbHor = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cb5 = New System.Windows.Forms.CheckBox()
        Me.cb4 = New System.Windows.Forms.CheckBox()
        Me.cb3 = New System.Windows.Forms.CheckBox()
        Me.cb2 = New System.Windows.Forms.CheckBox()
        Me.cb1 = New System.Windows.Forms.CheckBox()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cbRating = New System.Windows.Forms.CheckBox()
        Me.cbTrending = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(104, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Filter Film"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbRating)
        Me.GroupBox1.Controls.Add(Me.rbJudul)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(119, 88)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Urut Berdasarkan"
        '
        'rbRating
        '
        Me.rbRating.AutoSize = True
        Me.rbRating.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRating.Location = New System.Drawing.Point(6, 43)
        Me.rbRating.Name = "rbRating"
        Me.rbRating.Size = New System.Drawing.Size(56, 17)
        Me.rbRating.TabIndex = 2
        Me.rbRating.TabStop = True
        Me.rbRating.Text = "Rating"
        Me.rbRating.UseVisualStyleBackColor = True
        '
        'rbJudul
        '
        Me.rbJudul.AutoSize = True
        Me.rbJudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbJudul.Location = New System.Drawing.Point(6, 20)
        Me.rbJudul.Name = "rbJudul"
        Me.rbJudul.Size = New System.Drawing.Size(50, 17)
        Me.rbJudul.TabIndex = 0
        Me.rbJudul.TabStop = True
        Me.rbJudul.Text = "Judul"
        Me.rbJudul.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbDesc)
        Me.GroupBox2.Controls.Add(Me.rbAsc)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(135, 36)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(145, 88)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Jenis Pengurutan"
        '
        'rbDesc
        '
        Me.rbDesc.AutoSize = True
        Me.rbDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDesc.Location = New System.Drawing.Point(6, 43)
        Me.rbDesc.Name = "rbDesc"
        Me.rbDesc.Size = New System.Drawing.Size(82, 17)
        Me.rbDesc.TabIndex = 1
        Me.rbDesc.TabStop = True
        Me.rbDesc.Text = "Descending"
        Me.rbDesc.UseVisualStyleBackColor = True
        '
        'rbAsc
        '
        Me.rbAsc.AutoSize = True
        Me.rbAsc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAsc.Location = New System.Drawing.Point(6, 20)
        Me.rbAsc.Name = "rbAsc"
        Me.rbAsc.Size = New System.Drawing.Size(75, 17)
        Me.rbAsc.TabIndex = 0
        Me.rbAsc.TabStop = True
        Me.rbAsc.Text = "Ascending"
        Me.rbAsc.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbDra)
        Me.GroupBox3.Controls.Add(Me.cbAdv)
        Me.GroupBox3.Controls.Add(Me.cbMus)
        Me.GroupBox3.Controls.Add(Me.cbThr)
        Me.GroupBox3.Controls.Add(Me.cbSciFi)
        Me.GroupBox3.Controls.Add(Me.cbAct)
        Me.GroupBox3.Controls.Add(Me.cbCom)
        Me.GroupBox3.Controls.Add(Me.cbMis)
        Me.GroupBox3.Controls.Add(Me.cbRom)
        Me.GroupBox3.Controls.Add(Me.cbHor)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(10, 130)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(270, 136)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Genre"
        '
        'cbDra
        '
        Me.cbDra.AutoSize = True
        Me.cbDra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDra.Location = New System.Drawing.Point(87, 66)
        Me.cbDra.Name = "cbDra"
        Me.cbDra.Size = New System.Drawing.Size(57, 17)
        Me.cbDra.TabIndex = 48
        Me.cbDra.Text = "Drama"
        Me.cbDra.UseVisualStyleBackColor = True
        '
        'cbAdv
        '
        Me.cbAdv.AutoSize = True
        Me.cbAdv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAdv.Location = New System.Drawing.Point(6, 20)
        Me.cbAdv.Name = "cbAdv"
        Me.cbAdv.Size = New System.Drawing.Size(75, 17)
        Me.cbAdv.TabIndex = 39
        Me.cbAdv.Text = "Adventure"
        Me.cbAdv.UseVisualStyleBackColor = True
        '
        'cbMus
        '
        Me.cbMus.AutoSize = True
        Me.cbMus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMus.Location = New System.Drawing.Point(87, 112)
        Me.cbMus.Name = "cbMus"
        Me.cbMus.Size = New System.Drawing.Size(62, 17)
        Me.cbMus.TabIndex = 47
        Me.cbMus.Text = "Musical"
        Me.cbMus.UseVisualStyleBackColor = True
        '
        'cbThr
        '
        Me.cbThr.AutoSize = True
        Me.cbThr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbThr.Location = New System.Drawing.Point(6, 89)
        Me.cbThr.Name = "cbThr"
        Me.cbThr.Size = New System.Drawing.Size(57, 17)
        Me.cbThr.TabIndex = 44
        Me.cbThr.Text = "Thriller"
        Me.cbThr.UseVisualStyleBackColor = True
        '
        'cbSciFi
        '
        Me.cbSciFi.AutoSize = True
        Me.cbSciFi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSciFi.Location = New System.Drawing.Point(87, 20)
        Me.cbSciFi.Name = "cbSciFi"
        Me.cbSciFi.Size = New System.Drawing.Size(99, 17)
        Me.cbSciFi.TabIndex = 43
        Me.cbSciFi.Text = "Science Fiction"
        Me.cbSciFi.UseVisualStyleBackColor = True
        '
        'cbAct
        '
        Me.cbAct.AutoSize = True
        Me.cbAct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAct.Location = New System.Drawing.Point(6, 66)
        Me.cbAct.Name = "cbAct"
        Me.cbAct.Size = New System.Drawing.Size(56, 17)
        Me.cbAct.TabIndex = 41
        Me.cbAct.Text = "Action"
        Me.cbAct.UseVisualStyleBackColor = True
        '
        'cbCom
        '
        Me.cbCom.AutoSize = True
        Me.cbCom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCom.Location = New System.Drawing.Point(87, 43)
        Me.cbCom.Name = "cbCom"
        Me.cbCom.Size = New System.Drawing.Size(64, 17)
        Me.cbCom.TabIndex = 42
        Me.cbCom.Text = "Comedy"
        Me.cbCom.UseVisualStyleBackColor = True
        '
        'cbMis
        '
        Me.cbMis.AutoSize = True
        Me.cbMis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMis.Location = New System.Drawing.Point(87, 89)
        Me.cbMis.Name = "cbMis"
        Me.cbMis.Size = New System.Drawing.Size(59, 17)
        Me.cbMis.TabIndex = 45
        Me.cbMis.Text = "Mistery"
        Me.cbMis.UseVisualStyleBackColor = True
        '
        'cbRom
        '
        Me.cbRom.AutoSize = True
        Me.cbRom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRom.Location = New System.Drawing.Point(6, 112)
        Me.cbRom.Name = "cbRom"
        Me.cbRom.Size = New System.Drawing.Size(71, 17)
        Me.cbRom.TabIndex = 46
        Me.cbRom.Text = "Romantic"
        Me.cbRom.UseVisualStyleBackColor = True
        '
        'cbHor
        '
        Me.cbHor.AutoSize = True
        Me.cbHor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbHor.Location = New System.Drawing.Point(6, 43)
        Me.cbHor.Name = "cbHor"
        Me.cbHor.Size = New System.Drawing.Size(55, 17)
        Me.cbHor.TabIndex = 40
        Me.cbHor.Text = "Horror"
        Me.cbHor.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cb5)
        Me.GroupBox4.Controls.Add(Me.cb4)
        Me.GroupBox4.Controls.Add(Me.cb3)
        Me.GroupBox4.Controls.Add(Me.cb2)
        Me.GroupBox4.Controls.Add(Me.cb1)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(10, 272)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(270, 44)
        Me.GroupBox4.TabIndex = 49
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Rating"
        '
        'cb5
        '
        Me.cb5.AutoSize = True
        Me.cb5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb5.Location = New System.Drawing.Point(134, 20)
        Me.cb5.Margin = New System.Windows.Forms.Padding(0)
        Me.cb5.Name = "cb5"
        Me.cb5.Size = New System.Drawing.Size(32, 17)
        Me.cb5.TabIndex = 53
        Me.cb5.Text = "5"
        Me.cb5.UseVisualStyleBackColor = True
        '
        'cb4
        '
        Me.cb4.AutoSize = True
        Me.cb4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb4.Location = New System.Drawing.Point(102, 20)
        Me.cb4.Margin = New System.Windows.Forms.Padding(0)
        Me.cb4.Name = "cb4"
        Me.cb4.Size = New System.Drawing.Size(32, 17)
        Me.cb4.TabIndex = 52
        Me.cb4.Text = "4"
        Me.cb4.UseVisualStyleBackColor = True
        '
        'cb3
        '
        Me.cb3.AutoSize = True
        Me.cb3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb3.Location = New System.Drawing.Point(70, 20)
        Me.cb3.Margin = New System.Windows.Forms.Padding(0)
        Me.cb3.Name = "cb3"
        Me.cb3.Size = New System.Drawing.Size(32, 17)
        Me.cb3.TabIndex = 51
        Me.cb3.Text = "3"
        Me.cb3.UseVisualStyleBackColor = True
        '
        'cb2
        '
        Me.cb2.AutoSize = True
        Me.cb2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb2.Location = New System.Drawing.Point(38, 20)
        Me.cb2.Margin = New System.Windows.Forms.Padding(0)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(32, 17)
        Me.cb2.TabIndex = 50
        Me.cb2.Text = "2"
        Me.cb2.UseVisualStyleBackColor = True
        '
        'cb1
        '
        Me.cb1.AutoSize = True
        Me.cb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb1.Location = New System.Drawing.Point(6, 20)
        Me.cb1.Margin = New System.Windows.Forms.Padding(0)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(32, 17)
        Me.cb1.TabIndex = 49
        Me.cb1.Text = "1"
        Me.cb1.UseVisualStyleBackColor = True
        '
        'btnFilter
        '
        Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilter.Location = New System.Drawing.Point(10, 384)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(270, 24)
        Me.btnFilter.TabIndex = 50
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cbRating)
        Me.GroupBox5.Controls.Add(Me.cbTrending)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(10, 321)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(270, 44)
        Me.GroupBox5.TabIndex = 54
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Kategori"
        '
        'cbRating
        '
        Me.cbRating.AutoSize = True
        Me.cbRating.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRating.Location = New System.Drawing.Point(74, 20)
        Me.cbRating.Margin = New System.Windows.Forms.Padding(0)
        Me.cbRating.Name = "cbRating"
        Me.cbRating.Size = New System.Drawing.Size(101, 17)
        Me.cbRating.TabIndex = 50
        Me.cbRating.Text = "Rating Tertinggi"
        Me.cbRating.UseVisualStyleBackColor = True
        '
        'cbTrending
        '
        Me.cbTrending.AutoSize = True
        Me.cbTrending.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTrending.Location = New System.Drawing.Point(6, 20)
        Me.cbTrending.Margin = New System.Windows.Forms.Padding(0)
        Me.cbTrending.Name = "cbTrending"
        Me.cbTrending.Size = New System.Drawing.Size(68, 17)
        Me.cbTrending.TabIndex = 49
        Me.cbTrending.Text = "Trending"
        Me.cbTrending.UseVisualStyleBackColor = True
        '
        'Panel_Filter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "Panel_Filter"
        Me.Size = New System.Drawing.Size(290, 425)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbJudul As RadioButton
    Friend WithEvents rbRating As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbDesc As RadioButton
    Friend WithEvents rbAsc As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cbDra As CheckBox
    Friend WithEvents cbAdv As CheckBox
    Friend WithEvents cbMus As CheckBox
    Friend WithEvents cbThr As CheckBox
    Friend WithEvents cbSciFi As CheckBox
    Friend WithEvents cbAct As CheckBox
    Friend WithEvents cbCom As CheckBox
    Friend WithEvents cbMis As CheckBox
    Friend WithEvents cbRom As CheckBox
    Friend WithEvents cbHor As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cb2 As CheckBox
    Friend WithEvents cb1 As CheckBox
    Friend WithEvents cb4 As CheckBox
    Friend WithEvents cb3 As CheckBox
    Friend WithEvents cb5 As CheckBox
    Friend WithEvents btnFilter As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents cbRating As CheckBox
    Friend WithEvents cbTrending As CheckBox
End Class
