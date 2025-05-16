<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class card_item_min
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
        Me.btnFavorit = New System.Windows.Forms.Button()
        Me.btnAntrian = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFavorit
        '
        Me.btnFavorit.BackColor = System.Drawing.Color.Transparent
        Me.btnFavorit.FlatAppearance.BorderSize = 0
        Me.btnFavorit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnFavorit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFavorit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFavorit.Image = Global.Sistem_Manajemen_Film.My.Resources.Resources.hearth_not_fill
        Me.btnFavorit.Location = New System.Drawing.Point(72, 30)
        Me.btnFavorit.Name = "btnFavorit"
        Me.btnFavorit.Size = New System.Drawing.Size(25, 25)
        Me.btnFavorit.TabIndex = 2
        Me.btnFavorit.UseVisualStyleBackColor = False
        '
        'btnAntrian
        '
        Me.btnAntrian.BackColor = System.Drawing.Color.Transparent
        Me.btnAntrian.FlatAppearance.BorderSize = 0
        Me.btnAntrian.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown
        Me.btnAntrian.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAntrian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAntrian.Image = Global.Sistem_Manajemen_Film.My.Resources.Resources.playlist_not_fill
        Me.btnAntrian.Location = New System.Drawing.Point(72, 2)
        Me.btnAntrian.Name = "btnAntrian"
        Me.btnAntrian.Size = New System.Drawing.Size(25, 25)
        Me.btnAntrian.TabIndex = 1
        Me.btnAntrian.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 141)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'card_item_min
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnFavorit)
        Me.Controls.Add(Me.btnAntrian)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "card_item_min"
        Me.Size = New System.Drawing.Size(100, 141)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAntrian As Button
    Friend WithEvents btnFavorit As Button
End Class
