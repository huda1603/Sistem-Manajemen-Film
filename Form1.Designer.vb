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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnExplore = New System.Windows.Forms.Button()
        Me.btnFavorit = New System.Windows.Forms.Button()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.btnAntrian = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.btnExplore)
        Me.Panel2.Controls.Add(Me.btnFavorit)
        Me.Panel2.Controls.Add(Me.btnProfile)
        Me.Panel2.Controls.Add(Me.btnAntrian)
        Me.Panel2.Location = New System.Drawing.Point(0, 463)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(324, 44)
        Me.Panel2.TabIndex = 1
        '
        'btnExplore
        '
        Me.btnExplore.BackColor = System.Drawing.Color.Transparent
        Me.btnExplore.FlatAppearance.BorderSize = 0
        Me.btnExplore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnExplore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnExplore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExplore.Image = Global.Sistem_Manajemen_Film.My.Resources.Resources.search_nav
        Me.btnExplore.Location = New System.Drawing.Point(176, 3)
        Me.btnExplore.Name = "btnExplore"
        Me.btnExplore.Size = New System.Drawing.Size(44, 38)
        Me.btnExplore.TabIndex = 3
        Me.btnExplore.UseVisualStyleBackColor = False
        '
        'btnFavorit
        '
        Me.btnFavorit.BackColor = System.Drawing.Color.Transparent
        Me.btnFavorit.FlatAppearance.BorderSize = 0
        Me.btnFavorit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnFavorit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnFavorit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFavorit.Image = Global.Sistem_Manajemen_Film.My.Resources.Resources.heart_nav
        Me.btnFavorit.Location = New System.Drawing.Point(103, 3)
        Me.btnFavorit.Name = "btnFavorit"
        Me.btnFavorit.Size = New System.Drawing.Size(44, 38)
        Me.btnFavorit.TabIndex = 2
        Me.btnFavorit.UseVisualStyleBackColor = False
        '
        'btnProfile
        '
        Me.btnProfile.BackColor = System.Drawing.Color.Transparent
        Me.btnProfile.FlatAppearance.BorderSize = 0
        Me.btnProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProfile.Image = Global.Sistem_Manajemen_Film.My.Resources.Resources.user_nav
        Me.btnProfile.Location = New System.Drawing.Point(249, 3)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(44, 38)
        Me.btnProfile.TabIndex = 1
        Me.btnProfile.UseVisualStyleBackColor = False
        '
        'btnAntrian
        '
        Me.btnAntrian.BackColor = System.Drawing.Color.Transparent
        Me.btnAntrian.FlatAppearance.BorderSize = 0
        Me.btnAntrian.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAntrian.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnAntrian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAntrian.Image = Global.Sistem_Manajemen_Film.My.Resources.Resources.television
        Me.btnAntrian.Location = New System.Drawing.Point(30, 3)
        Me.btnAntrian.Name = "btnAntrian"
        Me.btnAntrian.Size = New System.Drawing.Size(44, 38)
        Me.btnAntrian.TabIndex = 0
        Me.btnAntrian.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(324, 463)
        Me.Panel3.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(324, 507)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnExplore As Button
    Friend WithEvents btnFavorit As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents btnAntrian As Button
    Friend WithEvents Panel3 As Panel
End Class
