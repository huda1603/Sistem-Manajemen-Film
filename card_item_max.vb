Imports MySql.Data.MySqlClient

Public Class card_item_max
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim connString As String = "server=localhost;userid=root;password=;database=dbmanajemenfilm"
    Dim sesi As Integer

    Sub Connect()
        conn = New MySqlConnection(connString)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim infoFilm As New info_film()
        infoFilm.PictureBox1.ImageLocation = PictureBox1.ImageLocation
        infoFilm.lblJudul.Text = lblJudul.Text
        infoFilm.lblGenre.Text = lblGenre.Text
        infoFilm.PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        infoFilm.lblJudul.Left = (infoFilm.Panel1.Width - infoFilm.lblJudul.Width) \ 2
        infoFilm.lblGenre.Left = (infoFilm.Panel1.Width - infoFilm.lblGenre.Width) \ 2
        Connect()
        conn.Open()
        Dim query As String = "SELECT views FROM film WHERE judul = @ju AND genre = @ge"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@ju", lblJudul.Text)
        cmd.Parameters.AddWithValue("@ge", lblGenre.Text)
        reader = cmd.ExecuteReader()
        reader.Read()
        infoFilm.lblView.Text = reader("views").ToString()
        infoFilm.Button1.Left = ((infoFilm.Width - infoFilm.Button1.Width) \ 2) - 8
        infoFilm.lblView.Left = ((infoFilm.Width - infoFilm.lblView.Width) \ 2) + 8
        reader.Close()
        conn.Close()
        infoFilm.Show()
        Dim parent As Form = Me.FindForm()
        If TypeOf parent Is lebih_banyak Then
            Dim lb As lebih_banyak = CType(parent, lebih_banyak)
            lb.Close()
        End If
    End Sub

    Private Sub card_item_max_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loads()
    End Sub

    Private Sub Loads()
        Connect()
        conn.Open()
        Dim query As String = "SELECT * FROM film_favorit WHERE id_film = @id_film AND id_akun = @id_akun"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@id_film", Integer.Parse(Me.Tag))
        cmd.Parameters.AddWithValue("@id_akun", sesiUser)
        reader = cmd.ExecuteReader()
        If reader.HasRows Then
            btnFavorit.Tag = "1"
            btnFavorit.Image = My.Resources.heart
        Else
            btnFavorit.Tag = "2"
            btnFavorit.Image = My.Resources.hearth_not_fill
        End If
        reader.Close()
        Dim query2 As String = "SELECT * FROM film_antrian WHERE id_film = @id_film AND id_akun = @id_akun"
        cmd = New MySqlCommand(query2, conn)
        cmd.Parameters.AddWithValue("@id_film", Integer.Parse(Me.Tag))
        cmd.Parameters.AddWithValue("@id_akun", sesiUser)
        reader = cmd.ExecuteReader()
        If reader.HasRows Then
            btnAntrian.Tag = "1"
            btnAntrian.Image = My.Resources.playlist
        Else
            btnAntrian.Tag = "2"
            btnAntrian.Image = My.Resources.playlist_not_fill
        End If
        reader.Close()
        conn.Close()
    End Sub

    Private Sub btnFavorit_Click(sender As Object, e As EventArgs) Handles btnFavorit.Click
        Dim status As String
        Connect()
        conn.Open()
        If btnFavorit.Tag.Equals("1") Then
            Dim query As String = "DELETE FROM film_favorit WHERE id_film = @id_film AND id_akun = @id_akun"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id_film", Integer.Parse(Me.Tag))
            cmd.Parameters.AddWithValue("@id_akun", sesiUser)
            cmd.ExecuteNonQuery()
            status = "Berhasil Di Hapus Dari Daftar Favorit"
            btnFavorit.Image = My.Resources.hearth_not_fill
        Else
            Dim query As String = "INSERT INTO film_favorit (id_film, id_akun) VALUES (@id_film, @id_akun)"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id_film", Integer.Parse(Me.Tag))
            cmd.Parameters.AddWithValue("@id_akun", sesiUser)
            cmd.ExecuteNonQuery()
            status = "Berhasil Di Tambah Ke Daftar Favorit"
            btnFavorit.Image = My.Resources.heart
        End If
        conn.Close()
        Me.Loads()
        MessageBox.Show(status)
    End Sub

    Private Sub btnAntrian_Click(sender As Object, e As EventArgs) Handles btnAntrian.Click
        Dim status As String
        Connect()
        conn.Open()
        If btnAntrian.Tag.Equals("1") Then
            Dim query As String = "DELETE FROM film_antrian WHERE id_film = @id_film AND id_akun = @id_akun"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id_film", Integer.Parse(Me.Tag))
            cmd.Parameters.AddWithValue("@id_akun", sesiUser)
            cmd.ExecuteNonQuery()
            status = "Berhasil Di Hapus Dari Daftar Antrian"
            btnAntrian.Image = My.Resources.playlist_not_fill
        Else
            Dim query As String = "INSERT INTO film_antrian (id_film, id_akun) VALUES (@id_film, @id_akun)"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id_film", Integer.Parse(Me.Tag))
            cmd.Parameters.AddWithValue("@id_akun", sesiUser)
            cmd.ExecuteNonQuery()
            status = "Berhasil Di Tambah Ke Daftar Antrian"
            btnAntrian.Image = My.Resources.playlist_not_fill
        End If
        conn.Close()
        Me.Loads()
        MessageBox.Show(status)
    End Sub

End Class
