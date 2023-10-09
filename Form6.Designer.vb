<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.DsyYoluTxt = New System.Windows.Forms.TextBox
        Me.AçBtn = New System.Windows.Forms.Button
        Me.GözatBtn = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.DsyYoluTxt)
        Me.Panel2.Controls.Add(Me.AçBtn)
        Me.Panel2.Controls.Add(Me.GözatBtn)
        Me.Panel2.Location = New System.Drawing.Point(36, 196)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(394, 76)
        Me.Panel2.TabIndex = 26
        '
        'DsyYoluTxt
        '
        Me.DsyYoluTxt.Location = New System.Drawing.Point(89, 8)
        Me.DsyYoluTxt.Name = "DsyYoluTxt"
        Me.DsyYoluTxt.Size = New System.Drawing.Size(263, 20)
        Me.DsyYoluTxt.TabIndex = 5
        '
        'AçBtn
        '
        Me.AçBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AçBtn.Enabled = False
        Me.AçBtn.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.AçBtn.Location = New System.Drawing.Point(8, 42)
        Me.AçBtn.Name = "AçBtn"
        Me.AçBtn.Size = New System.Drawing.Size(75, 23)
        Me.AçBtn.TabIndex = 4
        Me.AçBtn.Text = "Aç"
        Me.AçBtn.UseVisualStyleBackColor = False
        '
        'GözatBtn
        '
        Me.GözatBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GözatBtn.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.GözatBtn.Location = New System.Drawing.Point(8, 8)
        Me.GözatBtn.Name = "GözatBtn"
        Me.GözatBtn.Size = New System.Drawing.Size(75, 23)
        Me.GözatBtn.TabIndex = 6
        Me.GözatBtn.Text = "Gözat"
        Me.GözatBtn.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Location = New System.Drawing.Point(36, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(207, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Metin Kutusuna Şifrenizi Girip Entera Basın"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(36, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Kilidi Açmak İçin F12 Tuşuna Basın"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Location = New System.Drawing.Point(33, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(283, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Metin Kutusuna İstediğiniz Bir Şifre Yazınız ve Entera Basın"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(33, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Kilidi Çalıştırmak İçin F11 Tuşuna Basınız"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(462, 300)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form6"
        Me.Text = "Masaüstü Kilitleme"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DsyYoluTxt As System.Windows.Forms.TextBox
    Friend WithEvents AçBtn As System.Windows.Forms.Button
    Friend WithEvents GözatBtn As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
