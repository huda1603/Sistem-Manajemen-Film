<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class daftar
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
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAntrian = New System.Windows.Forms.Button()
        Me.btnFavorit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBrowse
        '
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Location = New System.Drawing.Point(63, 397)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(192, 39)
        Me.btnBrowse.TabIndex = 5
        Me.btnBrowse.Text = "JELAJAHI SEMUA FILM"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(11, 46)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(302, 333)
        Me.FlowLayoutPanel1.TabIndex = 4
        '
        'btnAntrian
        '
        Me.btnAntrian.BackColor = System.Drawing.Color.Transparent
        Me.btnAntrian.FlatAppearance.BorderSize = 0
        Me.btnAntrian.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAntrian.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnAntrian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAntrian.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAntrian.Location = New System.Drawing.Point(0, 0)
        Me.btnAntrian.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAntrian.Name = "btnAntrian"
        Me.btnAntrian.Size = New System.Drawing.Size(162, 30)
        Me.btnAntrian.TabIndex = 6
        Me.btnAntrian.Text = "Daftar Antrian"
        Me.btnAntrian.UseVisualStyleBackColor = False
        '
        'btnFavorit
        '
        Me.btnFavorit.BackColor = System.Drawing.Color.Transparent
        Me.btnFavorit.FlatAppearance.BorderSize = 0
        Me.btnFavorit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnFavorit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnFavorit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFavorit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFavorit.Location = New System.Drawing.Point(162, 0)
        Me.btnFavorit.Margin = New System.Windows.Forms.Padding(0)
        Me.btnFavorit.Name = "btnFavorit"
        Me.btnFavorit.Size = New System.Drawing.Size(162, 30)
        Me.btnFavorit.TabIndex = 7
        Me.btnFavorit.Text = "Daftar Favorit"
        Me.btnFavorit.UseVisualStyleBackColor = False
        '
        'daftar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnFavorit)
        Me.Controls.Add(Me.btnAntrian)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "daftar"
        Me.Size = New System.Drawing.Size(324, 463)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnAntrian As Button
    Friend WithEvents btnFavorit As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
