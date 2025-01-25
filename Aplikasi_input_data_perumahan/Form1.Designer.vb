<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.cmblantai = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.cmbtype = New System.Windows.Forms.ComboBox()
        Me.txtblok = New System.Windows.Forms.TextBox()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.cboxsubsidi = New System.Windows.Forms.CheckBox()
        Me.txtstok = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txttlp = New System.Windows.Forms.TextBox()
        Me.txtidtrns = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtkota = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbdtrumah = New System.Windows.Forms.ComboBox()
        Me.lblid = New System.Windows.Forms.Label()
        Me.lblketrmh = New System.Windows.Forms.Label()
        Me.txtadd = New System.Windows.Forms.TextBox()
        Me.btnsimpantrs = New System.Windows.Forms.Button()
        Me.btnedittrs = New System.Windows.Forms.Button()
        Me.btnhapustrs = New System.Windows.Forms.Button()
        Me.btnbataltrs = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(570, 416)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtid)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.btnhapus)
        Me.TabPage1.Controls.Add(Me.btnedit)
        Me.TabPage1.Controls.Add(Me.cmblantai)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.btnbatal)
        Me.TabPage1.Controls.Add(Me.btnsimpan)
        Me.TabPage1.Controls.Add(Me.cmbtype)
        Me.TabPage1.Controls.Add(Me.txtblok)
        Me.TabPage1.Controls.Add(Me.txtharga)
        Me.TabPage1.Controls.Add(Me.cboxsubsidi)
        Me.TabPage1.Controls.Add(Me.txtstok)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(562, 390)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Data Master Rumah"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(134, 11)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(196, 20)
        Me.txtid.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 16)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Id Data"
        '
        'btnhapus
        '
        Me.btnhapus.BackColor = System.Drawing.Color.Red
        Me.btnhapus.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapus.Location = New System.Drawing.Point(394, 91)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(162, 31)
        Me.btnhapus.TabIndex = 16
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnedit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.Location = New System.Drawing.Point(394, 61)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(162, 31)
        Me.btnedit.TabIndex = 15
        Me.btnedit.Text = "Ubah"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'cmblantai
        '
        Me.cmblantai.FormattingEnabled = True
        Me.cmblantai.Items.AddRange(New Object() {"lantai 1", "lantai 2", "lantai 3"})
        Me.cmblantai.Location = New System.Drawing.Point(136, 69)
        Me.cmblantai.Name = "cmblantai"
        Me.cmblantai.Size = New System.Drawing.Size(195, 21)
        Me.cmblantai.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Lantai"
        '
        'btnbatal
        '
        Me.btnbatal.BackColor = System.Drawing.Color.Maroon
        Me.btnbatal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbatal.ForeColor = System.Drawing.Color.White
        Me.btnbatal.Location = New System.Drawing.Point(394, 124)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(162, 30)
        Me.btnbatal.TabIndex = 12
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.UseVisualStyleBackColor = False
        '
        'btnsimpan
        '
        Me.btnsimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsimpan.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsimpan.Location = New System.Drawing.Point(394, 31)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(162, 31)
        Me.btnsimpan.TabIndex = 11
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = False
        '
        'cmbtype
        '
        Me.cmbtype.FormattingEnabled = True
        Me.cmbtype.Items.AddRange(New Object() {"36/60", "45/72", "54/90", "70/100", "90/120", "120/150", "150/200", "200/300", "250/400"})
        Me.cmbtype.Location = New System.Drawing.Point(135, 42)
        Me.cmbtype.Name = "cmbtype"
        Me.cmbtype.Size = New System.Drawing.Size(195, 21)
        Me.cmbtype.TabIndex = 10
        '
        'txtblok
        '
        Me.txtblok.Location = New System.Drawing.Point(134, 94)
        Me.txtblok.Name = "txtblok"
        Me.txtblok.Size = New System.Drawing.Size(196, 20)
        Me.txtblok.TabIndex = 9
        '
        'txtharga
        '
        Me.txtharga.Location = New System.Drawing.Point(134, 120)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(196, 20)
        Me.txtharga.TabIndex = 8
        '
        'cboxsubsidi
        '
        Me.cboxsubsidi.AutoSize = True
        Me.cboxsubsidi.Location = New System.Drawing.Point(134, 178)
        Me.cboxsubsidi.Name = "cboxsubsidi"
        Me.cboxsubsidi.Size = New System.Drawing.Size(79, 17)
        Me.cboxsubsidi.TabIndex = 7
        Me.cboxsubsidi.Text = "Ya, Subsidi"
        Me.cboxsubsidi.UseVisualStyleBackColor = True
        '
        'txtstok
        '
        Me.txtstok.Location = New System.Drawing.Point(135, 147)
        Me.txtstok.Name = "txtstok"
        Me.txtstok.Size = New System.Drawing.Size(196, 20)
        Me.txtstok.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Rumah Subsidi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Stok"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Harga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Blok"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Type Rumah"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 224)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(550, 140)
        Me.DataGridView1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnbataltrs)
        Me.TabPage2.Controls.Add(Me.btnhapustrs)
        Me.TabPage2.Controls.Add(Me.btnedittrs)
        Me.TabPage2.Controls.Add(Me.btnsimpantrs)
        Me.TabPage2.Controls.Add(Me.txtadd)
        Me.TabPage2.Controls.Add(Me.lblketrmh)
        Me.TabPage2.Controls.Add(Me.lblid)
        Me.TabPage2.Controls.Add(Me.cmbdtrumah)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Controls.Add(Me.txtkota)
        Me.TabPage2.Controls.Add(Me.txtemail)
        Me.TabPage2.Controls.Add(Me.txtidtrns)
        Me.TabPage2.Controls.Add(Me.txttlp)
        Me.TabPage2.Controls.Add(Me.txtnama)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(562, 390)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Data Penjualan"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(500, -2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Keluar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(393, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 16)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Id Transaksi"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(24, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 16)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Nama Pembeli"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(24, 68)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 16)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "No Hp / Wa"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(24, 95)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 16)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Email"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(24, 124)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 16)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Kota"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(24, 204)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 16)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Alamat"
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(132, 39)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(215, 20)
        Me.txtnama.TabIndex = 25
        '
        'txttlp
        '
        Me.txttlp.Location = New System.Drawing.Point(132, 64)
        Me.txttlp.Name = "txttlp"
        Me.txttlp.Size = New System.Drawing.Size(215, 20)
        Me.txttlp.TabIndex = 26
        '
        'txtidtrns
        '
        Me.txtidtrns.Location = New System.Drawing.Point(132, 12)
        Me.txtidtrns.Name = "txtidtrns"
        Me.txtidtrns.Size = New System.Drawing.Size(215, 20)
        Me.txtidtrns.TabIndex = 27
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(132, 94)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(215, 20)
        Me.txtemail.TabIndex = 28
        '
        'txtkota
        '
        Me.txtkota.Location = New System.Drawing.Point(132, 120)
        Me.txtkota.Name = "txtkota"
        Me.txtkota.Size = New System.Drawing.Size(215, 20)
        Me.txtkota.TabIndex = 29
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(27, 254)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(529, 126)
        Me.DataGridView2.TabIndex = 31
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(24, 150)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 16)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Data Rumah"
        '
        'cmbdtrumah
        '
        Me.cmbdtrumah.FormattingEnabled = True
        Me.cmbdtrumah.Location = New System.Drawing.Point(132, 149)
        Me.cmbdtrumah.Name = "cmbdtrumah"
        Me.cmbdtrumah.Size = New System.Drawing.Size(215, 21)
        Me.cmbdtrumah.TabIndex = 33
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.ForeColor = System.Drawing.Color.White
        Me.lblid.Location = New System.Drawing.Point(327, 176)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(20, 16)
        Me.lblid.TabIndex = 34
        Me.lblid.Text = "id"
        '
        'lblketrmh
        '
        Me.lblketrmh.AutoSize = True
        Me.lblketrmh.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblketrmh.Location = New System.Drawing.Point(131, 177)
        Me.lblketrmh.Name = "lblketrmh"
        Me.lblketrmh.Size = New System.Drawing.Size(157, 16)
        Me.lblketrmh.TabIndex = 35
        Me.lblketrmh.Text = "belum pilih data rumah"
        '
        'txtadd
        '
        Me.txtadd.Location = New System.Drawing.Point(132, 200)
        Me.txtadd.Name = "txtadd"
        Me.txtadd.Size = New System.Drawing.Size(215, 20)
        Me.txtadd.TabIndex = 36
        '
        'btnsimpantrs
        '
        Me.btnsimpantrs.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsimpantrs.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsimpantrs.Location = New System.Drawing.Point(394, 6)
        Me.btnsimpantrs.Name = "btnsimpantrs"
        Me.btnsimpantrs.Size = New System.Drawing.Size(162, 31)
        Me.btnsimpantrs.TabIndex = 37
        Me.btnsimpantrs.Text = "Simpan"
        Me.btnsimpantrs.UseVisualStyleBackColor = False
        '
        'btnedittrs
        '
        Me.btnedittrs.BackColor = System.Drawing.Color.Goldenrod
        Me.btnedittrs.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedittrs.Location = New System.Drawing.Point(394, 43)
        Me.btnedittrs.Name = "btnedittrs"
        Me.btnedittrs.Size = New System.Drawing.Size(162, 31)
        Me.btnedittrs.TabIndex = 38
        Me.btnedittrs.Text = "Ubah"
        Me.btnedittrs.UseVisualStyleBackColor = False
        '
        'btnhapustrs
        '
        Me.btnhapustrs.BackColor = System.Drawing.Color.Red
        Me.btnhapustrs.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapustrs.Location = New System.Drawing.Point(394, 80)
        Me.btnhapustrs.Name = "btnhapustrs"
        Me.btnhapustrs.Size = New System.Drawing.Size(162, 31)
        Me.btnhapustrs.TabIndex = 39
        Me.btnhapustrs.Text = "Hapus"
        Me.btnhapustrs.UseVisualStyleBackColor = False
        '
        'btnbataltrs
        '
        Me.btnbataltrs.BackColor = System.Drawing.Color.Maroon
        Me.btnbataltrs.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbataltrs.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnbataltrs.Location = New System.Drawing.Point(394, 114)
        Me.btnbataltrs.Name = "btnbataltrs"
        Me.btnbataltrs.Size = New System.Drawing.Size(162, 31)
        Me.btnbataltrs.TabIndex = 40
        Me.btnbataltrs.Text = "Batal"
        Me.btnbataltrs.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(594, 454)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form Input Data Penjualan Ruamah"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnbatal As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents cmbtype As System.Windows.Forms.ComboBox
    Friend WithEvents txtblok As System.Windows.Forms.TextBox
    Friend WithEvents txtharga As System.Windows.Forms.TextBox
    Friend WithEvents cboxsubsidi As System.Windows.Forms.CheckBox
    Friend WithEvents txtstok As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmblantai As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbdtrumah As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents txtkota As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtidtrns As System.Windows.Forms.TextBox
    Friend WithEvents txttlp As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents lblketrmh As System.Windows.Forms.Label
    Friend WithEvents txtadd As System.Windows.Forms.TextBox
    Friend WithEvents btnbataltrs As System.Windows.Forms.Button
    Friend WithEvents btnhapustrs As System.Windows.Forms.Button
    Friend WithEvents btnedittrs As System.Windows.Forms.Button
    Friend WithEvents btnsimpantrs As System.Windows.Forms.Button

End Class
