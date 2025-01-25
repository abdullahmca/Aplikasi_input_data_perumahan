Imports MySql.Data.MySqlClient
Public Class Form1
    Dim popup As String
    Dim subsidi, sql, item_text, connectionString, updateQuery As String
    Dim selectedRowIndex, rowindex, i As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Form2.Show()
        Label1.Text = Form2.nama_pengguna
        Call ViewData()
        cmblantai.SelectedIndex = -1
        cmbtype.SelectedIndex = -1
        cboxsubsidi.Checked = False
        txtblok.Text = ""
        txtharga.Text = "0"
        txtid.Text = ""
        txtid.ReadOnly = True
        txtstok.Text = "0"
        cmbtype.Items.Clear()
        cmbtype.Items.Add("36/60")
        cmbtype.Items.Add("45/72")
        cmbtype.Items.Add("54/90")
        cmbtype.Items.Add("70/100")
        cmbtype.Items.Add("90/120")
        cmbtype.Items.Add("120/150")
        cmbtype.Items.Add("150/200")
        cmbtype.Items.Add("200/300")
        cmbtype.Items.Add("250/400")
        'tabs transaksi
        cmbdtrumah.Items.Clear()
        AmbilData()
        txtidtrns.ReadOnly = True
        txttlp.MaxLength = 14
        txtemail.MaxLength = 30
        txtnama.MaxLength = 50
        txtkota.MaxLength = 30
        txtadd.Height = 50
        txtadd.Multiline = True

    End Sub
    Sub ViewDataa()
        koneksi()
        'da = New Odbc.OdbcDataAdapter("select * from tbl_rumah")
        'ds = New DataSet
        'ds.Clear()
        'da.Fill(ds, "tbl_rumah")
        'DataGridView.DataSource = (ds.Tables("tbl_rumah"))

    End Sub
    Sub clean()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Apakah Anda Yakin Admin Sistem ?", "Informasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Hide()
            Form2.Show()
        End If
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If cboxsubsidi.Checked = True Then
            subsidi = 1
        Else
            subsidi = 0
        End If
        'MessageBox.Show("" + txtblok.Text + "', '" + cmblantai.Text + "','" + cmbtype.Text + "','" + txtharga.Text + "', '" + txtstok.Text + "', '" + subsidi + "")

        If txtid.Text = "" Then
            If MessageBox.Show("Konfirmasi data yang aakan diinput:" + txtblok.Text + "', '" + cmblantai.Text + "','" + cmbtype.Text + "','" + txtharga.Text + "', '" + txtstok.Text + "', '" + subsidi + "", "Informasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Call InputDataRumah()
                cmblantai.SelectedIndex = -1
                cmbtype.SelectedIndex = -1
                cboxsubsidi.Checked = False
                txtblok.Text = ""
                txtharga.Text = "0"
                txtstok.Text = "0"
                Call ViewData()
            Else 
            End If
        Else
            MessageBox.Show("Anda harus input data baru bukan update data")
            Label1.Text = Form2.nama_pengguna
            Call ViewData()
            cmblantai.SelectedIndex = -1
            cmbtype.SelectedIndex = -1
            cboxsubsidi.Checked = False
            txtblok.Text = ""
            txtharga.Text = "0"
            txtid.Text = ""
            txtid.ReadOnly = True
            txtstok.Text = "0"
            cmbtype.Items.Clear()
            cmbtype.Items.Add("36/60")
            cmbtype.Items.Add("45/72")
            cmbtype.Items.Add("54/90")
            cmbtype.Items.Add("70/100")
            cmbtype.Items.Add("90/120")
            cmbtype.Items.Add("120/150")
            cmbtype.Items.Add("150/200")
            cmbtype.Items.Add("200/300")
            cmbtype.Items.Add("250/400") 
            'Memilih item pertama secara default (jika perlu) 
        End If
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Call UpdateDataRumah()
        Call ViewData()
    End Sub
    Private Sub DataGridView1_CurrentCellChanged( _
    ByVal sender As Object, _
    ByVal e As System.EventArgs _
) Handles DataGridView1.CurrentCellChanged

        Static prevRow As Integer = -1
        i = 0

        If DataGridView1.CurrentRow.Index <> prevRow Then
            prevRow = DataGridView1.CurrentRow.Index
            txtid.Text = DataGridView1.CurrentRow.Cells(0).Value
            txtblok.Text = DataGridView1.CurrentRow.Cells(1).Value
            txtharga.Text = DataGridView1.CurrentRow.Cells(4).Value
            txtstok.Text = DataGridView1.CurrentRow.Cells(5).Value
            cmblantai.SelectedItem = DataGridView1.CurrentRow.Cells(2).Value
            cmbtype.SelectedItem = DataGridView1.CurrentRow.Cells(3).Value
            If DataGridView1.CurrentRow.Cells(6).Value = 1 Then
                cboxsubsidi.Checked = True
            Else
                cboxsubsidi.Checked = False
            End If
        End If
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        HapusData()
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click  
        Label1.Text = Form2.nama_pengguna
        Call ViewData()
        cmblantai.SelectedIndex = -1
        cmbtype.SelectedIndex = -1
        cboxsubsidi.Checked = False
        txtblok.Text = ""
        txtharga.Text = "0"
        txtid.Text = ""
        txtid.ReadOnly = True
        txtstok.Text = "0"
        cmbtype.Items.Clear()
        cmbtype.Items.Add("36/60")
        cmbtype.Items.Add("45/72")
        cmbtype.Items.Add("54/90")
        cmbtype.Items.Add("70/100")
        cmbtype.Items.Add("90/120")
        cmbtype.Items.Add("120/150")
        cmbtype.Items.Add("150/200")
        cmbtype.Items.Add("200/300")
        cmbtype.Items.Add("250/400") 
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click
        cmbdtrumah.Items.Clear()
        Call AmbilData()
    End Sub

    Private Sub cmbdtrumah_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdtrumah.SelectedIndexChanged
        Dim words As String() = cmbdtrumah.Text.Split(New Char() {"."c})
        lblid.Text = words(0)
        lblketrmh.Text = words(1) + "" + words(2)

        ' cmbdtrumah.Items.Clear()
        Call AmbilData()

        ' Use For Each loop over words and display them

        'MessageBox.Show(words(0))
        'Dim word As String
        'For Each word In words
        'Console.WriteLine(word)
        'Next
    End Sub

    Private Sub btnsimpantrs_Click(sender As Object, e As EventArgs) Handles btnsimpantrs.Click
        Call Simpantrs()
    End Sub
End Class
