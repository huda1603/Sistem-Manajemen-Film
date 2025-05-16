Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Public Class Halaman_Tambah_Admin
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim connString As String = "server=localhost;userid=root;password=;database=dbmanajemenfilm"

    Sub Connect()
        conn = New MySqlConnection(connString)
    End Sub

    Private Sub otwDashboard()
        Dim form_admin As New Form_Admin()
        form_admin.Panel4.Controls.Clear()
        Connect()
        conn.Open()
        Dim query As String = "SELECT username FROM akun WHERE id_akun = @id"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@id", sesiAdmin)
        reader = cmd.ExecuteReader()
        reader.Read()
        form_admin.lblUser.Text = reader("username").ToString()
        reader.Close()
        conn.Close()
        form_admin.lblKeterangan.Text = "Daftar Film"
        form_admin.btnDaftarFilm.BackColor = Color.DeepSkyBlue
        form_admin.btnProfile.BackColor = Color.Transparent
        Dim daftarFilm As New Panel_Admin_DaftarFilm()
        form_admin.Panel4.Controls.Add(daftarFilm)
        daftarFilm.Show()
        form_admin.Show()
        Me.Hide()
    End Sub

    Function cekJudul() As Boolean
        Dim hasil As Boolean
        Connect()
        Try
            conn.Open()
            Dim query As String = "SELECT judul FROM film WHERE judul = @ju"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@ju", txtJudul.Text)
            reader = cmd.ExecuteReader()
            If reader.HasRows Then
                hasil = True
            Else
                hasil = False
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
        Return hasil
    End Function

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Try
            Dim InputTextBox As String = txtJudul.Text
            If String.IsNullOrEmpty(InputTextBox) Then
                Throw New FormatException("Judul Tidak Boleh Kosong")
            End If
            If Not (cbAdv.Checked Or cbHor.Checked Or cbAct.Checked Or cbCom.Checked Or cbSciFi.Checked Or cbDra.Checked Or cbThr.Checked Or cbMis.Checked Or cbRom.Checked Or cbMus.Checked) Then
                Throw New FormatException("Mohon Pilih Salah Satu Atau Lebih Genre")
            End If
            Dim pattern As String = "^[A-Za-z\s]+$"
            Dim regex As New Regex(pattern)
            If Not regex.IsMatch(txtJudul.Text) Then
                Throw New FormatException("Film Harus Mengandung Huruf / Angka Tidak Boleh Ada Yang Mengandung Simbol")
            End If
            If PictureBox1.Image Is Nothing Then
                Throw New FormatException("Mohon Masukkan Gambar Film")
            End If
        Catch ex As FormatException
            MessageBox.Show(ex.Message)
            Return
        End Try

        If cekJudul() = True Then
            MessageBox.Show("Film Sudah Ada")
        Else
            Connect()
            Try
                conn.Open()
                Dim query As String = "INSERT INTO film (judul, tglrilis, genre, rating, gambar, views, id_akun) VALUES (@ju, @tr, @ge, @ra, @ga, @vw, @id)"
                cmd = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ju", txtJudul.Text)
                cmd.Parameters.AddWithValue("@tr", tanggalRilis.Value.ToString())
                Dim cbGenre() As CheckBox = {cbAdv, cbHor, cbAct, cbCom, cbSciFi, cbDra, cbThr, cbMis, cbRom, cbMus}
                Dim listGenre As New List(Of String)
                Dim listGenreCb As New List(Of CheckBox)
                Dim lbGenre As String = ""
                For i As Integer = 0 To cbGenre.Length - 1
                    If cbGenre(i).Checked = True Then
                        listGenre.Add(cbGenre(i).Text)
                        listGenreCb.Add(cbGenre(i))
                    End If
                Next
                For i As Integer = 0 To listGenre.Count - 1
                    If i < listGenre.Count - 1 Then
                        lbGenre = lbGenre + listGenre(i) + ", "
                    Else
                        lbGenre = lbGenre + listGenre(i)
                    End If
                Next
                cmd.Parameters.AddWithValue("@ge", lbGenre)
                cmd.Parameters.AddWithValue("@ra", "Kosong")
                Dim gambarPath As String = BukaGambar.FileName
                cmd.Parameters.AddWithValue("@ga", gambarPath)
                cmd.Parameters.AddWithValue("@vw", "0")
                cmd.Parameters.AddWithValue("@id", sesiAdmin)
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try
            otwDashboard()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        otwDashboard()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        BukaGambar.Filter = "JPG Image|*.jpg|PNG Image|*.png|JPEG Image|*.jpeg"
        If BukaGambar.ShowDialog() = DialogResult.OK Then
            PictureBox1.ImageLocation = BukaGambar.FileName
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub
End Class
