<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Panel_Admin_Profile
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
        Me.lblFilm = New System.Windows.Forms.Label()
        Me.lblFilmTrending = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblFilmRating = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblFilm
        '
        Me.lblFilm.AutoSize = True
        Me.lblFilm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilm.Location = New System.Drawing.Point(299, 177)
        Me.lblFilm.Name = "lblFilm"
        Me.lblFilm.Size = New System.Drawing.Size(14, 15)
        Me.lblFilm.TabIndex = 14
        Me.lblFilm.Text = "0"
        '
        'lblFilmTrending
        '
        Me.lblFilmTrending.AutoSize = True
        Me.lblFilmTrending.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilmTrending.Location = New System.Drawing.Point(299, 229)
        Me.lblFilmTrending.Name = "lblFilmTrending"
        Me.lblFilmTrending.Size = New System.Drawing.Size(14, 15)
        Me.lblFilmTrending.TabIndex = 13
        Me.lblFilmTrending.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(268, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Total Film"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(235, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Total Film Trending"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(279, 115)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(54, 16)
        Me.lblUser.TabIndex = 10
        Me.lblUser.Text = "Label1"
        '
        'btnLogout
        '
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogout.Location = New System.Drawing.Point(242, 348)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(129, 28)
        Me.btnLogout.TabIndex = 8
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'lblFilmRating
        '
        Me.lblFilmRating.AutoSize = True
        Me.lblFilmRating.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilmRating.Location = New System.Drawing.Point(301, 281)
        Me.lblFilmRating.Name = "lblFilmRating"
        Me.lblFilmRating.Size = New System.Drawing.Size(14, 15)
        Me.lblFilmRating.TabIndex = 16
        Me.lblFilmRating.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(223, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Total Film Rating Tinggi"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.Sistem_Manajemen_Film.My.Resources.Resources.user
        Me.Button1.Location = New System.Drawing.Point(264, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 85)
        Me.Button1.TabIndex = 9
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(268, 310)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(81, 22)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Panel_Admin_Profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblFilmRating)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblFilm)
        Me.Controls.Add(Me.lblFilmTrending)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnLogout)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "Panel_Admin_Profile"
        Me.Size = New System.Drawing.Size(612, 395)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFilm As Label
    Friend WithEvents lblFilmTrending As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblFilmRating As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnExit As Button
End Class
