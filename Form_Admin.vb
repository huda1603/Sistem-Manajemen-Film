Imports MySql.Data.MySqlClient

Public Class Form_Admin
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim connString As String = "server=localhost;userid=root;password=;database=dbmanajemenfilm"

    Sub Connect()
        conn = New MySqlConnection(connString)
    End Sub

    Private Sub btnDaftarFilm_Click(sender As Object, e As EventArgs) Handles btnDaftarFilm.Click
        Panel4.Controls.Clear()
        lblKeterangan.Text = "Daftar Film"
        btnDaftarFilm.BackColor = Color.DeepSkyBlue
        btnProfile.BackColor = Color.Transparent
        Dim daftarFilm As New Panel_Admin_DaftarFilm()
        Panel4.Controls.Add(daftarFilm)
        daftarFilm.Show()
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Panel4.Controls.Clear()
        lblKeterangan.Text = "Profile"
        btnProfile.BackColor = Color.DeepSkyBlue
        btnDaftarFilm.BackColor = Color.Transparent
        Dim profile As New Panel_Admin_Profile()
        Connect()
        conn.Open()
        Dim query As String = "SELECT * FROM film WHERE id_akun = @id"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@id", sesiAdmin)
        reader = cmd.ExecuteReader()
        Dim total_baris As Integer = 0
        Dim total_baris_trending As Integer = 0
        Dim total_baris_rating As Integer = 0
        While reader.Read()
            If Integer.Parse(reader("views")) >= 8 Then
                total_baris_trending += 1
            End If
            If reader("rating") = "5" Then
                total_baris_rating += 1
            End If
            total_baris += 1
        End While
        reader.Close()
        conn.Close()
        Connect()
        conn.Open()
        Dim query2 As String = "SELECT username FROM akun WHERE id_akun = @id"
        cmd = New MySqlCommand(query2, conn)
        cmd.Parameters.AddWithValue("@id", sesiAdmin)
        reader = cmd.ExecuteReader()
        reader.Read()
        profile.lblUser.Text = reader("username").ToString()
        reader.Close()
        conn.Close()
        profile.lblFilm.Text = total_baris.ToString()
        profile.lblFilmTrending.Text = total_baris_trending.ToString()
        profile.lblFilmRating.Text = total_baris_rating.ToString()
        Panel4.Controls.Add(profile)
        profile.Show()
    End Sub
End Class