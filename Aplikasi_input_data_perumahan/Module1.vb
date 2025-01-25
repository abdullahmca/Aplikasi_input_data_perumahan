Imports MySql.Data.MySqlClient
Imports System.Globalization

Module Module1
    Public conn As MySqlConnection
    Public cmd, deleteCommand, updateCommand As MySqlCommand
    Public rd As MySqlDataReader
    Public da, daa As MySqlDataAdapter
    Public ds As DataSet
    Public str As String
    Dim subsidi, sql, item_text, selectQuery, connectionString, updateQuery, deleteQuery, lantai As String
    Dim rowsAffected As Integer
    Sub koneksi()
        Try
            Dim str As String = "Server=localhost;Database=db_tugas_vb;Uid=root;Pwd=;"
            conn = New MySqlConnection(str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                'MessageBox.Show("koneksi db sukses")
            Else
                MessageBox.Show("koneksi db gagal")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub ViewData()
        Try
            Dim str As String = "Server=localhost;Database=db_tugas_vb;Uid=root;Pwd=;"
            conn = New MySqlConnection(str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                'MessageBox.Show("koneksi db sukses")
                da = New MySqlDataAdapter("select * from tbl_rumah", conn)
                ' da = New OdbcDataAdapter("select code as CODE, name as NAME, address as ADDRESS ,phone as PHONE, photo as PHOTO from users", conn)
                ds = New DataSet()
                da.Fill(ds)
                Form1.DataGridView1.DataSource = ds.Tables(0)
                'Form1.DataGridView1.Columns("nomor_rumah").Width = 100
                Form1.DataGridView1.Columns("blok").Width = 250
                Form1.DataGridView1.Columns("type").Width = 250
                Form1.DataGridView1.Columns("harga").Width = 100
                Form1.DataGridView1.Columns("stok").Width = 200
                Form1.DataGridView1.Columns("is_subsidi").Width = 200
            Else
                MessageBox.Show("koneksi db gagal")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub AmbilData()

        'Form1.cmbdtrumah.Items.Add("pilih data Rumah")

        Form1.cmbdtrumah.Items.Clear()
        Try
            Dim str As String = "Server=localhost;Database=db_tugas_vb;Uid=root;Pwd=;"
            Dim value As Decimal
            Dim formattedValue As String = String.Format("{0:n}", value)
            conn = New MySqlConnection(str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                'MessageBox.Show("koneksi db sukses")
                'da = New MySqlDataAdapter("select * from tbl_rumah", conn)
                'Membuat objek MySqlCommand
                cmd = New MySqlCommand("select * from tbl_rumah", conn)
                'Membaca data menggunakan MySqlDataReader
                rd = cmd.ExecuteReader()
                While (rd.Read())
                    'value = CDec(Decimal.Parse(rd.GetString(4)))
                    Form1.cmbdtrumah.Items.Add(rd.GetString(0) + ". Type :" + rd.GetString(3) + " Harga Rp." + rd.GetString(4))
                End While
                rd.Close()
                ' da = New OdbcDataAdapter("select code as CODE, name as NAME, address as ADDRESS ,phone as PHONE, photo as PHOTO from users", conn)
                'ds = New DataSet()
                'da.Fill(ds)
                'Form1.DataGridView1.DataSource = ds.Tables(0)
                'Form1.DataGridView1.Columns("nomor_rumah").Width = 100
                'Form1.DataGridView1.Columns("blok").Width = 250
                'Form1.DataGridView1.Columns("type").Width = 250
                'Form1.DataGridView1.Columns("harga").Width = 100
                'Form1.DataGridView1.Columns("stok").Width = 200
                'Form1.DataGridView1.Columns("is_subsidi").Width = 200
            Else
                MessageBox.Show("koneksi db gagal")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub 
    Sub HapusData()
        Try
            Dim str As String = "Server=localhost;Database=db_tugas_vb;Uid=root;Pwd=;"
            conn = New MySqlConnection(str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                If MessageBox.Show("Apakah Anda Yakin Menghapus data blok=" + Form1.txtblok.Text + ",lantai=" + Form1.cmblantai.Text + ",type=" + Form1.cmbtype.Text + ",harga=" + Form1.txtharga.Text + ",stok=" + Form1.txtstok.Text + ",is_subsidi=" + subsidi + " WHERE id=" + Form1.txtid.Text + "?", "Informasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    selectQuery = "SELECT * FROM your_table"
                    da = New MySqlDataAdapter("select * from tbl_rumah", conn)
                    deleteQuery = "DELETE FROM tbl_rumah WHERE id = @ID"
                    deleteCommand = New MySqlCommand(deleteQuery, conn)
                    deleteCommand.Parameters.AddWithValue("@id", Form1.txtid.Text)
                    rowsAffected = deleteCommand.ExecuteNonQuery()
                    If (rowsAffected > 0) Then
                        MessageBox.Show("Data dengan ID " + Form1.txtid.Text + " berhasil dihapus :D.")
                    Else
                        Console.WriteLine("No data found with ID " + Form1.txtid.Text + "")
                    End If
                    'Mengatur DeleteCommand pada MySqlDataAdapter
                    da.DeleteCommand = deleteCommand
                    ds = New DataSet()
                    da.Fill(ds)
                    da.Update(ds)
                    Form1.DataGridView1.DataSource = ds.Tables(0)
                    Console.WriteLine("Data deleted successfully.")
                Else
                End If
            Else
                MessageBox.Show("koneksi db gagal")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Call ViewData()
    End Sub
    Sub UpdateDataRumah()
        Try
            If Form1.cboxsubsidi.Checked = True Then
                subsidi = 1
            Else
                subsidi = 0
            End If
            If Form1.cmblantai.Text = "lantai 1" Then
                lantai = "lantai_1"
            ElseIf Form1.cmblantai.Text = "lantai 2" Then
                lantai = "lantai_2"
            ElseIf Form1.cmblantai.Text = "lantai 3" Then
                lantai = "lantai_3"
            End If
            Dim str As String = "Server=localhost;Database=db_tugas_vb;Uid=root;Pwd=;"
            conn = New MySqlConnection(str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                If MessageBox.Show("Apakah Anda Yakin Mengubah data blok=" + Form1.txtblok.Text + ",lantai=" + Form1.cmblantai.Text + ",type=" + Form1.cmbtype.Text + ",harga=" + Form1.txtharga.Text + ",stok=" + Form1.txtstok.Text + ",is_subsidi=" + subsidi + " WHERE id=" + Form1.txtid.Text + "?", "Informasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    selectQuery = "SELECT * FROM your_table"
                    da = New MySqlDataAdapter("select * from tbl_rumah", conn)
                    updateQuery = "UPDATE tbl_rumah SET blok=@BLOK,lantai=@LANTAI,type=@TYPE,harga=@HARGA,stok=@STOK,is_subsidi=@SUBSIDI WHERE id=@ID"
                    '"UPDATE tbl_rumah SET blok=" + Form1.txtblok.Text + ",lantai=" + lantai + ",type=" + Form1.cmbtype.Text + ",harga=" + Form1.txtharga.Text + ",stok=" + Form1.txtstok.Text + ",is_subsidi=" + subsidi + " WHERE id=@id"
                    updateCommand = New MySqlCommand(updateQuery, conn)
                    updateCommand.Parameters.AddWithValue("@ID", Form1.txtid.Text)
                    updateCommand.Parameters.AddWithValue("@BLOK", Form1.txtblok.Text)
                    updateCommand.Parameters.AddWithValue("@LANTAI", Form1.cmblantai.Text)
                    updateCommand.Parameters.AddWithValue("@TYPE", Form1.cmbtype.Text)
                    updateCommand.Parameters.AddWithValue("@HARGA", Form1.txtharga.Text)
                    updateCommand.Parameters.AddWithValue("@STOK", Form1.txtstok.Text)
                    updateCommand.Parameters.AddWithValue("@SUBSIDI", subsidi)
                    rowsAffected = updateCommand.ExecuteNonQuery()
                    If (rowsAffected > 0) Then
                        MessageBox.Show("Data dengan ID " + Form1.txtid.Text + " berhasil diubah :D.")
                    Else
                        Console.WriteLine("No data found with ID " + Form1.txtid.Text + "")
                    End If
                    'Mengatur DeleteCommand pada MySqlDataAdapter
                    'da.DeleteCommand = deleteCommand
                    'ds = New DataSet()
                    'da.Fill(ds)
                    'da.Update(ds)
                    'Form1.DataGridView1.DataSource = ds.Tables(0)
                    Console.WriteLine("Data deleted successfully.")
                Else
                End If
            Else
                MessageBox.Show("koneksi db gagal")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Call ViewData()

    End Sub
    Sub InputDataRumah()
        Try
            Dim str As String = "Server=localhost;Database=db_tugas_vb;Uid=root;Pwd=;"
            conn = New MySqlConnection(str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                If Form1.cboxsubsidi.Checked = True Then
                    subsidi = 1
                Else
                    subsidi = 0
                End If
                'sql = string.Format("insert into tbl_rumah (blok, lantai, type, harga, stok, is_subsidi) values ('" + form1.txtblok.Text + form1."', '" + form1.cmblantai.Text + form1."','" + form1.txtharga.Text + form1."', '" + form1.txtstok.Text + form1."', '" + form1.subsidi + form1."')")
                'MessageBox.Show("koneksi db sukses")

                da = New MySqlDataAdapter("insert into tbl_rumah (blok, lantai, type, harga, stok, is_subsidi) values ('" + Form1.txtblok.Text + "', '" + Form1.cmblantai.Text + "','" + Form1.cmbtype.Text + "','" + Form1.txtharga.Text + "', '" + Form1.txtstok.Text + "', '" + subsidi + "')", conn)
                ' da = New OdbcDataAdapter("select code as CODE, name as NAME, address as ADDRESS ,phone as PHONE, photo as PHOTO from users", conn)
                ds = New DataSet()
                'da = New MySqlDataAdapter("select * from tbl_rumah", conn)
                da.Fill(ds)
                Form1.DataGridView1.DataSource = ds.Tables(0)
                Form1.DataGridView1.Columns("nomor_rumah").Width = 100
                Form1.DataGridView1.Columns("blok").Width = 250
                Form1.DataGridView1.Columns("type").Width = 250
                Form1.DataGridView1.Columns("harga").Width = 100
                Form1.DataGridView1.Columns("stok").Width = 200
                Form1.DataGridView1.Columns("is_subsidi").Width = 200
            Else
                MessageBox.Show("koneksi db gagal")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub Simpantrs() 
        Try
            Dim str As String = "Server=localhost;Database=db_tugas_vb;Uid=root;Pwd=;"
            conn = New MySqlConnection(str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                da = New MySqlDataAdapter("insert into tbl_rumah (blok, lantai, type, harga, stok, is_subsidi) values ('" + Form1.txtblok.Text + "', '" + Form1.cmblantai.Text + "','" + Form1.cmbtype.Text + "','" + Form1.txtharga.Text + "', '" + Form1.txtstok.Text + "', '" + subsidi + "')", conn)
                ds = New DataSet()
                da.Fill(ds)
                Form1.DataGridView1.DataSource = ds.Tables(0)
                Form1.DataGridView1.Columns("nomor_rumah").Width = 100
                Form1.DataGridView1.Columns("blok").Width = 250
                Form1.DataGridView1.Columns("type").Width = 250
                Form1.DataGridView1.Columns("harga").Width = 100
                Form1.DataGridView1.Columns("stok").Width = 200
                Form1.DataGridView1.Columns("is_subsidi").Width = 200
            Else
                MessageBox.Show("koneksi db gagal")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
