<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.btn_masuk = New System.Windows.Forms.Button()
        Me.btn_keluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(197, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOGIN ADMINISTRATOR "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(98, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Pengguna"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(98, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(102, 153)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(424, 20)
        Me.txt_username.TabIndex = 3
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(102, 219)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass.Size = New System.Drawing.Size(424, 20)
        Me.txt_pass.TabIndex = 4
        '
        'btn_masuk
        '
        Me.btn_masuk.Location = New System.Drawing.Point(102, 245)
        Me.btn_masuk.Name = "btn_masuk"
        Me.btn_masuk.Size = New System.Drawing.Size(193, 42)
        Me.btn_masuk.TabIndex = 5
        Me.btn_masuk.Text = "Masuk Sistem"
        Me.btn_masuk.UseVisualStyleBackColor = True
        '
        'btn_keluar
        '
        Me.btn_keluar.Location = New System.Drawing.Point(325, 245)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(201, 42)
        Me.btn_keluar.TabIndex = 6
        Me.btn_keluar.Text = "Keluar"
        Me.btn_keluar.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(594, 359)
        Me.Controls.Add(Me.btn_keluar)
        Me.Controls.Add(Me.btn_masuk)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form Login Admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_username As System.Windows.Forms.TextBox
    Friend WithEvents txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents btn_masuk As System.Windows.Forms.Button
    Friend WithEvents btn_keluar As System.Windows.Forms.Button
End Class
