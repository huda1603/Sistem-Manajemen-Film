<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class card_list
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
        Me.lblRate = New System.Windows.Forms.Label()
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.btnList = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblJudul
        '
        Me.lblJudul.AutoSize = True
        Me.lblJudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.Location = New System.Drawing.Point(79, 6)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(67, 16)
        Me.lblJudul.TabIndex = 1
        Me.lblJudul.Text = "Judul Film"
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRate.Location = New System.Drawing.Point(98, 53)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(92, 13)
        Me.lblRate.TabIndex = 2
        Me.lblRate.Text = "Belum Ada Rating"
        '
        'lblGenre
        '
        Me.lblGenre.AutoEllipsis = True
        Me.lblGenre.AutoSize = True
        Me.lblGenre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenre.Location = New System.Drawing.Point(79, 28)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(36, 13)
        Me.lblGenre.TabIndex = 4
        Me.lblGenre.Text = "Genre"
        '
        'btnList
        '
        Me.btnList.BackColor = System.Drawing.Color.Transparent
        Me.btnList.FlatAppearance.BorderSize = 0
        Me.btnList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnList.Location = New System.Drawing.Point(272, 22)
        Me.btnList.Margin = New System.Windows.Forms.Padding(0)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(25, 25)
        Me.btnList.TabIndex = 5
        Me.btnList.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.Sistem_Manajemen_Film.My.Resources.Resources.star_small
        Me.Button1.Location = New System.Drawing.Point(75, 45)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 73)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'card_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.Controls.Add(Me.btnList)
        Me.Controls.Add(Me.lblGenre)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.lblJudul)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "card_list"
        Me.Size = New System.Drawing.Size(302, 73)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblJudul As Label
    Friend WithEvents lblRate As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblGenre As Label
    Friend WithEvents btnList As Button
End Class
