<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class card_item_max
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
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.btnFavorit = New System.Windows.Forms.Button()
        Me.btnAntrian = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblJudul
        '
        Me.lblJudul.AutoEllipsis = True
        Me.lblJudul.AutoSize = True
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblJudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Cyan
        Me.lblJudul.Location = New System.Drawing.Point(7, 102)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(85, 18)
        Me.lblJudul.TabIndex = 4
        Me.lblJudul.Text = "Judul Film"
        '
        'lblGenre
        '
        Me.lblGenre.AutoEllipsis = True
        Me.lblGenre.AutoSize = True
        Me.lblGenre.BackColor = System.Drawing.Color.Transparent
        Me.lblGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblGenre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenre.ForeColor = System.Drawing.Color.Cyan
        Me.lblGenre.Location = New System.Drawing.Point(7, 126)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(68, 15)
        Me.lblGenre.TabIndex = 5
        Me.lblGenre.Text = "Genre Film"
        '
        'btnFavorit
        '
        Me.btnFavorit.BackColor = System.Drawing.Color.Transparent
        Me.btnFavorit.FlatAppearance.BorderSize = 0
        Me.btnFavorit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnFavorit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFavorit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFavorit.Image = Global.Sistem_Manajemen_Film.My.Resources.Resources.heart
        Me.btnFavorit.Location = New System.Drawing.Point(262, 33)
        Me.btnFavorit.Name = "btnFavorit"
        Me.btnFavorit.Size = New System.Drawing.Size(25, 25)
        Me.btnFavorit.TabIndex = 3
        Me.btnFavorit.UseVisualStyleBackColor = False
        '
        'btnAntrian
        '
        Me.btnAntrian.BackColor = System.Drawing.Color.Transparent
        Me.btnAntrian.FlatAppearance.BorderSize = 0
        Me.btnAntrian.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAntrian.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAntrian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAntrian.Image = Global.Sistem_Manajemen_Film.My.Resources.Resources.playlist
        Me.btnAntrian.Location = New System.Drawing.Point(262, 3)
        Me.btnAntrian.Name = "btnAntrian"
        Me.btnAntrian.Size = New System.Drawing.Size(25, 25)
        Me.btnAntrian.TabIndex = 2
        Me.btnAntrian.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(290, 148)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'card_item_max
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblGenre)
        Me.Controls.Add(Me.lblJudul)
        Me.Controls.Add(Me.btnFavorit)
        Me.Controls.Add(Me.btnAntrian)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "card_item_max"
        Me.Size = New System.Drawing.Size(290, 148)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAntrian As Button
    Friend WithEvents btnFavorit As Button
    Friend WithEvents lblJudul As Label
    Friend WithEvents lblGenre As Label
End Class
