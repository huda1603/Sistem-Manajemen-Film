Imports MySql.Data.MySqlClient

Public Class beri_rating
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim connString As String = "server=localhost;userid=root;password=;database=dbmanajemenfilm"

    Sub Connect()
        conn = New MySqlConnection(connString)
    End Sub

    Private Sub btnKirim_Click(sender As Object, e As EventArgs) Handles btnKirim.Click
        For Each rb As RadioButton In {rb1, rb2, rb3, rb4, rb5}
            If rb.Checked Then
                Dim rating As Integer = Integer.Parse(rb.Text)
                Connect()
                conn.Open()
                Dim parent As Form = Me.FindForm()
                If TypeOf parent Is info_film Then
                    Dim info_films As info_film = CType(parent, info_film)
                    Dim query As String = "SELECT id_film FROM film WHERE judul = @ju AND genre = @ge"
                    cmd = New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ju", info_films.lblJudul.Text)
                    cmd.Parameters.AddWithValue("@ge", info_films.lblGenre.Text)
                    reader = cmd.ExecuteReader()
                    Dim id_film As Integer
                    If reader.Read() Then
                        id_film = reader("id_film")
                    End If
                    reader.Close()
                    Dim query2 As String = "SELECT rating FROM film_rate_user WHERE id_film = @id_film"
                    cmd = New MySqlCommand(query2, conn)
                    cmd.Parameters.AddWithValue("@id_film", id_film)
                    reader = cmd.ExecuteReader()
                    Dim total_rating As Integer = rating
                    Dim jumlah_baris_rating As Integer = 1
                    While reader.Read()
                        total_rating += Integer.Parse(reader("rating"))
                        jumlah_baris_rating += 1
                    End While
                    reader.Close()
                    Dim query3 As String = "UPDATE film SET rating = @rate WHERE id_film = @id_film"
                    cmd = New MySqlCommand(query3, conn)
                    cmd.Parameters.AddWithValue("@rate", CInt(Math.Floor(total_rating / jumlah_baris_rating)).ToString())
                    cmd.Parameters.AddWithValue("@id_film", id_film)
                    cmd.ExecuteNonQuery()
                    Dim query4 As String = "INSERT INTO film_rate_user (id_film, id_akun, rating) VALUES (@id_film, @id_akun, @rate)"
                    cmd = New MySqlCommand(query4, conn)
                    cmd.Parameters.AddWithValue("@id_film", id_film)
                    cmd.Parameters.AddWithValue("@id_akun", sesiUser)
                    cmd.Parameters.AddWithValue("@rate", rating.ToString())
                    cmd.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Berhasil Memberikan Rating")
                    Exit For
                End If
            End If
        Next
        Dim parent2 As Form = Me.FindForm()
        If TypeOf parent2 Is info_film Then
            Dim info_films As info_film = CType(parent2, info_film)
            info_films.Loads()
        End If
    End Sub
End Class
