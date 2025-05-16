Imports MySql.Data.MySqlClient

Public Class info_film
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim connString As String = "server=localhost;userid=root;password=;database=dbmanajemenfilm"

    Sub Connect()
        conn = New MySqlConnection(connString)
    End Sub

    Private Sub info_film_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()
        conn.Open()
        Dim query As String = "UPDATE film SET views = @viewBaru WHERE judul = @ju"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@viewBaru", (Integer.Parse(lblView.Text) + 1).ToString())
        cmd.Parameters.AddWithValue("@ju", lblJudul.Text)
        cmd.ExecuteNonQuery()
        conn.Close()
        lblView.Text = (Integer.Parse(lblView.Text) + 1).ToString()
        Loads()
    End Sub

    Public Sub Loads()
        Dim sudahBeriRating As Boolean
        Panel4.Controls.Clear()
        Connect()
        conn.Open()
        Dim query As String = "SELECT id_film, rating FROM film WHERE judul = @ju AND genre = @ge"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@ju", lblJudul.Text)
        cmd.Parameters.AddWithValue("@ge", lblGenre.Text)
        reader = cmd.ExecuteReader()
        Dim id_film As Integer
        Dim rating As Integer
        If reader.Read() Then
            id_film = reader("id_film")
            If reader("rating").Equals("Kosong") Then
                rating = Nothing
            Else
                rating = Integer.Parse(reader("rating").ToString())
            End If
        End If
        reader.Close()
        Dim query2 As String = "SELECT * FROM film_rate_user WHERE id_film = @id_film AND id_akun = @id_akun"
        cmd = New MySqlCommand(query2, conn)
        cmd.Parameters.AddWithValue("@id_film", id_film)
        cmd.Parameters.AddWithValue("@id_akun", sesiUser)
        reader = cmd.ExecuteReader()
        If reader.HasRows Then
            sudahBeriRating = True
        Else
            sudahBeriRating = False
        End If
        reader.Close()
        conn.Close()
        If sudahBeriRating = True Then
            Dim info_ratings As New info_rating()
            Dim i_star As Integer = 0
            For Each ctrl As Control In info_ratings.Panel1.Controls
                If TypeOf ctrl Is Button Then
                    Dim star As Button = CType(ctrl, Button)
                    star.Image = My.Resources.star
                    i_star += 1
                    If i_star.Equals(rating) Then
                        Exit For
                    End If
                End If
            Next
            Panel4.Controls.Add(info_ratings)
            info_ratings.Show()
        Else
            Dim beri_ratings As New beri_rating()
            Panel4.Controls.Add(beri_ratings)
            beri_ratings.Show()
        End If
    End Sub

    Private Sub btnOut_Click(sender As Object, e As EventArgs) Handles btnOut.Click
        If openFormMoreFilm.Equals(True) Then
            Dim lebihBanyak As New lebih_banyak()
            lebihBanyak.Show()
            Me.Hide()
        Else
            Dim f1 As New Form1()
            If halamanDaftar = "Explore" Then
                Dim explores As New explore()
                f1.Panel3.Controls.Add(explores)
                explores.Show()
            Else
                Dim daftars As New daftar()
                f1.Panel3.Controls.Add(daftars)
                daftars.Show()
            End If
            f1.Show()
            Me.Hide()
        End If
    End Sub
End Class