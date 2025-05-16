<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class beri_rating
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
        Me.aa = New System.Windows.Forms.Label()
        Me.btnKirim = New System.Windows.Forms.Button()
        Me.rb1 = New System.Windows.Forms.RadioButton()
        Me.rb2 = New System.Windows.Forms.RadioButton()
        Me.rb3 = New System.Windows.Forms.RadioButton()
        Me.rb4 = New System.Windows.Forms.RadioButton()
        Me.rb5 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'aa
        '
        Me.aa.AutoSize = True
        Me.aa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aa.Location = New System.Drawing.Point(125, 3)
        Me.aa.Name = "aa"
        Me.aa.Size = New System.Drawing.Size(59, 13)
        Me.aa.TabIndex = 4
        Me.aa.Text = "Beri Rating"
        '
        'btnKirim
        '
        Me.btnKirim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKirim.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKirim.Location = New System.Drawing.Point(85, 44)
        Me.btnKirim.Margin = New System.Windows.Forms.Padding(0)
        Me.btnKirim.Name = "btnKirim"
        Me.btnKirim.Size = New System.Drawing.Size(127, 21)
        Me.btnKirim.TabIndex = 6
        Me.btnKirim.Text = "Kirim"
        Me.btnKirim.UseVisualStyleBackColor = True
        '
        'rb1
        '
        Me.rb1.AutoSize = True
        Me.rb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb1.Location = New System.Drawing.Point(58, 21)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(31, 17)
        Me.rb1.TabIndex = 0
        Me.rb1.TabStop = True
        Me.rb1.Text = "1"
        Me.rb1.UseVisualStyleBackColor = True
        '
        'rb2
        '
        Me.rb2.AutoSize = True
        Me.rb2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb2.Location = New System.Drawing.Point(95, 21)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(31, 17)
        Me.rb2.TabIndex = 1
        Me.rb2.TabStop = True
        Me.rb2.Text = "2"
        Me.rb2.UseVisualStyleBackColor = True
        '
        'rb3
        '
        Me.rb3.AutoSize = True
        Me.rb3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb3.Location = New System.Drawing.Point(132, 21)
        Me.rb3.Name = "rb3"
        Me.rb3.Size = New System.Drawing.Size(31, 17)
        Me.rb3.TabIndex = 2
        Me.rb3.TabStop = True
        Me.rb3.Text = "3"
        Me.rb3.UseVisualStyleBackColor = True
        '
        'rb4
        '
        Me.rb4.AutoSize = True
        Me.rb4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb4.Location = New System.Drawing.Point(169, 21)
        Me.rb4.Name = "rb4"
        Me.rb4.Size = New System.Drawing.Size(31, 17)
        Me.rb4.TabIndex = 3
        Me.rb4.TabStop = True
        Me.rb4.Text = "4"
        Me.rb4.UseVisualStyleBackColor = True
        '
        'rb5
        '
        Me.rb5.AutoSize = True
        Me.rb5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb5.Location = New System.Drawing.Point(206, 21)
        Me.rb5.Name = "rb5"
        Me.rb5.Size = New System.Drawing.Size(31, 17)
        Me.rb5.TabIndex = 4
        Me.rb5.TabStop = True
        Me.rb5.Text = "5"
        Me.rb5.UseVisualStyleBackColor = True
        '
        'beri_rating
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.rb5)
        Me.Controls.Add(Me.rb4)
        Me.Controls.Add(Me.btnKirim)
        Me.Controls.Add(Me.rb3)
        Me.Controls.Add(Me.aa)
        Me.Controls.Add(Me.rb2)
        Me.Controls.Add(Me.rb1)
        Me.Name = "beri_rating"
        Me.Size = New System.Drawing.Size(300, 65)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents aa As Label
    Friend WithEvents btnKirim As Button
    Friend WithEvents rb1 As RadioButton
    Friend WithEvents rb5 As RadioButton
    Friend WithEvents rb4 As RadioButton
    Friend WithEvents rb3 As RadioButton
    Friend WithEvents rb2 As RadioButton
End Class
