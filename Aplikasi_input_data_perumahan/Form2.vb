Imports MySql.Data.MySqlClient
Public Class Form2
    Public Shared nama_pengguna As String = ""
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        Form1.Hide()
    End Sub

    Private Sub btn_masuk_Click(sender As Object, e As EventArgs) Handles btn_masuk.Click
        koneksi()
        Dim nama_pengguna As String
        nama_pengguna = txt_username.Text
        If txt_username.Text = "" Or txt_pass.Text = "" Then
            MsgBox("Pastikan data nama pengguna dan password sesuai")
        Else
            If txt_username.Text = "admin" Or txt_pass.Text = "qwerty" Then
                If MessageBox.Show("Apakah Anda Yakin Admin Sistem ?", "Informasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    Form1.Show()
                    Me.Hide()
                Else
                    Me.Show()
                    Form1.Hide()
                End If
            Else
                Me.Show()
                Form1.Hide()
            End If
        End If
    End Sub

    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        If MessageBox.Show("Apakah Anda Yakin Keluar sekarang ?", "Informasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub
End Class