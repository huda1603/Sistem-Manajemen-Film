Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim connString As String = "server=localhost;userid=root;password=;database=dbmanajemenfilm"

    Sub Connect()
        conn = New MySqlConnection(connString)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If halamanDaftar IsNot "Explore" And halamanDaftar IsNot "Favorit" And halamanDaftar IsNot "Antrian" Then
            Profile()
        End If
    End Sub

    Private Sub Profile()
        btnProfile.BackColor = Color.Silver
        For Each btn As Button In {btnExplore, btnAntrian, btnFavorit}
            btn.BackColor = Color.Transparent
        Next
        Panel3.Controls.Clear()
        Dim profile As New profile()
        Connect()
        conn.Open()
        Dim query As String = "SELECT username FROM akun WHERE id_akun = @id"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@id", sesiUser)
        reader = cmd.ExecuteReader()
        reader.Read()
        profile.lblUser.Text = reader("username").ToString()
        reader.Close()
        conn.Close()
        Dim total_baris_favorit As Integer = 0
        Dim total_baris_antrian As Integer = 0
        Connect()
        conn.Open()
        Dim query3 As String = "SELECT * FROM film_favorit WHERE id_akun = @id"
        cmd = New MySqlCommand(query3, conn)
        cmd.Parameters.AddWithValue("@id", sesiUser)
        reader = cmd.ExecuteReader()
        While reader.Read()
            total_baris_favorit += 1
        End While
        reader.Close()
        Dim query4 As String = "SELECT * FROM film_antrian WHERE id_akun = @id"
        cmd = New MySqlCommand(query4, conn)
        cmd.Parameters.AddWithValue("@id", sesiUser)
        reader = cmd.ExecuteReader()
        While reader.Read()
            total_baris_antrian += 1
        End While
        reader.Close()
        conn.Close()
        profile.lblFilmFavorit.Text = total_baris_favorit.ToString()
        profile.lblFilmAntrian.Text = total_baris_antrian.ToString()
        Panel3.Controls.Add(profile)
        profile.Show()
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Profile()
    End Sub

    Private Sub btnExplore_Click(sender As Object, e As EventArgs) Handles btnExplore.Click
        halamanDaftar = "Explore"
        Panel3.Controls.Clear()
        Dim explores As New explore()
        Panel3.Controls.Add(explores)
        explores.Show()
    End Sub

    Private Sub btnFavorit_Click(sender As Object, e As EventArgs) Handles btnFavorit.Click
        halamanDaftar = "Favorit"
        Panel3.Controls.Clear()
        Dim favorit As New daftar()
        Panel3.Controls.Add(favorit)
        favorit.Show()
    End Sub

    Private Sub btnAntrian_Click(sender As Object, e As EventArgs) Handles btnAntrian.Click
        halamanDaftar = "Antrian"
        Panel3.Controls.Clear()
        Dim antrian As New daftar()
        Panel3.Controls.Add(antrian)
        antrian.Show()
    End Sub
End Class
