Imports MySql.Data.MySqlClient

Public Class daftar
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim connString As String = "server=localhost;userid=root;password=;database=dbmanajemenfilm"

    Sub Connect()
        conn = New MySqlConnection(connString)
    End Sub

    Private Sub daftar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loads()
    End Sub

    Public Sub Loads()
        FlowLayoutPanel1.Controls.Clear()
        Connect()
        conn.Open()
        Dim parent As Form = Me.FindForm()
        Dim listFilm As New List(Of String)
        Dim query As String
        If halamanDaftar = "Favorit" Then
            query = "SELECT id_film FROM film_favorit WHERE id_akun = @id"
            btnFavorit.BackColor = Color.Silver
            btnAntrian.BackColor = Color.Transparent
            btnFavorit.Font = New Font(btnFavorit.Font, FontStyle.Underline)
            Dim stylebtnAntrian = btnAntrian.Font.Style And FontStyle.Underline
            btnAntrian.Font = New Font(btnAntrian.Font, stylebtnAntrian)
            If TypeOf parent Is Form1 Then
                Dim f1 As Form1 = CType(parent, Form1)
                f1.btnFavorit.BackColor = Color.Silver
                For Each btn As Button In {f1.btnAntrian, f1.btnExplore, f1.btnProfile}
                    btn.BackColor = Color.Transparent
                Next
            End If
        Else
            query = "SELECT id_film FROM film_antrian WHERE id_akun = @id"
            btnFavorit.BackColor = Color.Transparent
            btnAntrian.BackColor = Color.Silver
            btnAntrian.Font = New Font(btnAntrian.Font, FontStyle.Underline)
            Dim stylebtnFavorit = btnFavorit.Font.Style And FontStyle.Underline
            btnFavorit.Font = New Font(btnFavorit.Font, stylebtnFavorit)
            If TypeOf parent Is Form1 Then
                Dim f1 As Form1 = CType(parent, Form1)
                f1.btnAntrian.BackColor = Color.Silver
                For Each btn As Button In {f1.btnFavorit, f1.btnExplore, f1.btnProfile}
                    btn.BackColor = Color.Transparent
                Next
            End If
        End If
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@id", sesiUser)
        reader = cmd.ExecuteReader()
        While reader.Read()
            listFilm.Add(reader("id_film").ToString())
        End While
        reader.Close()
        If listFilm.Count > 0 Then
            Dim query2 As String = "SELECT * FROM film WHERE id_film IN (" & String.Join(", ", listFilm) & ")"
            cmd = New MySqlCommand(query2, conn)
            reader = cmd.ExecuteReader()
            While reader.Read()
                Dim card As New card_list()
                card.PictureBox1.ImageLocation = reader("gambar").ToString()
                card.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom

                If halamanDaftar = "Favorit" Then
                    card.btnList.Image = My.Resources.heart
                    card.btnList.Tag = "Hearth"
                Else
                    card.btnList.Image = My.Resources.playlist
                    card.btnList.Tag = "Playlist"
                End If
                card.lblJudul.Text = reader("judul").ToString()
                card.lblGenre.Text = reader("genre").ToString()
                card.lblRate.Text = reader("rating").ToString()
                FlowLayoutPanel1.Controls.Add(card)
                card.Show()
            End While
            reader.Close()
        End If
        conn.Close()
    End Sub

    Private Sub btnAntrian_Click(sender As Object, e As EventArgs) Handles btnAntrian.Click
        halamanDaftar = "Antrian"
        Loads()
    End Sub

    Private Sub btnFavorit_Click(sender As Object, e As EventArgs) Handles btnFavorit.Click
        halamanDaftar = "Favorit"
        Loads()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        filterFilm = New Dictionary(Of String, List(Of String))
        filterFilm("Sort") = New List(Of String)
        filterFilm("Genre") = New List(Of String)
        filterFilm("Rating") = New List(Of String)
        filterFilm("Kategori") = New List(Of String)
        Dim lebihBanyak As New lebih_banyak()
        lebihBanyak.Show()
        Dim parent As Form = Me.FindForm()
        If TypeOf parent Is Form1 Then
            parent.Close()
        End If
    End Sub
End Class
