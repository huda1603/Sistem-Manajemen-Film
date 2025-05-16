Imports MySql.Data.MySqlClient

Public Class explore
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim connString As String = "server=localhost;userid=root;password=;database=dbmanajemenfilm"
    Dim sesi As Integer

    Sub Connect()
        conn = New MySqlConnection(connString)
    End Sub

    Private Sub explore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loads()
    End Sub

    Public Sub Loads()
        Dim parent As Form = Me.FindForm()
        If TypeOf parent Is Form1 Then
            Dim f1 As Form1 = CType(parent, Form1)
            f1.btnExplore.BackColor = Color.Silver
            For Each btn As Button In {f1.btnAntrian, f1.btnFavorit, f1.btnProfile}
                btn.BackColor = Color.Transparent
            Next
        End If
        FlowLayoutPanel1.Controls.Clear()
        Dim filmdict As New Dictionary(Of String, List(Of card_item_min))
        filmdict("Trending") = New List(Of card_item_min)
        filmdict("Rating") = New List(Of card_item_min)
        filmdict("Semua") = New List(Of card_item_min)
        Connect()
        conn.Open()
        Dim query As String = "SELECT * FROM film"
        cmd = New MySqlCommand(query, conn)
        reader = cmd.ExecuteReader()
        While reader.Read()
            If reader("views") > 8 Then
                Dim card As New card_item_min()
                card.Tag = reader("id_film").ToString()
                card.PictureBox1.ImageLocation = reader("gambar").ToString()
                card.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                filmdict("Trending").Add(card)
            End If
            If reader("rating") IsNot "Kosong" Then
                If reader("rating").Equals("5") Then
                    Dim card As New card_item_min()
                    card.Tag = reader("id_film").ToString()
                    card.PictureBox1.ImageLocation = reader("gambar").ToString()
                    card.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                    filmdict("Rating").Add(card)
                End If
            End If
            Dim cardAll As New card_item_min()
            cardAll.Tag = reader("id_film").ToString()
            cardAll.PictureBox1.ImageLocation = reader("gambar").ToString()
            cardAll.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            filmdict("Semua").Add(cardAll)
        End While
        reader.Close()
        If filmdict("Trending").Count > 0 Then
            Dim card_minimizes As New card_minimize()
            card_minimizes.lblJudul.Text = "Film Trending"
            For Each card As card_item_min In filmdict("Trending")
                card.btnAntrian.Parent = card.PictureBox1
                card.btnFavorit.Parent = card.PictureBox1
                card_minimizes.FlowLayoutPanel1.Controls.Add(card)
            Next
            FlowLayoutPanel1.Controls.Add(card_minimizes)
        End If
        If filmdict("Rating").Count > 0 Then
            Dim card_minimizes As New card_minimize()
            card_minimizes.lblJudul.Text = "Film Rating Tertinggi"
            For Each card As card_item_min In filmdict("Rating")
                card.btnAntrian.Parent = card.PictureBox1
                card.btnFavorit.Parent = card.PictureBox1
                card_minimizes.FlowLayoutPanel1.Controls.Add(card)
            Next
            FlowLayoutPanel1.Controls.Add(card_minimizes)
        End If
        If filmdict("Semua").Count > 0 Then
            Dim card_minimizes As New card_minimize()
            card_minimizes.lblJudul.Text = "Semua Film"
            For Each card As card_item_min In filmdict("Semua")
                card.btnAntrian.Parent = card.PictureBox1
                card.btnFavorit.Parent = card.PictureBox1
                card_minimizes.FlowLayoutPanel1.Controls.Add(card)
            Next
            FlowLayoutPanel1.Controls.Add(card_minimizes)
        End If
        If filmdict("Semua").Count > 0 Then
            If filmdict("Semua").Count >= 5 Then
                Dim btnBrowse As New btnBrowseAll()
                FlowLayoutPanel1.Controls.Add(btnBrowse)
                btnBrowse.Margin = New Padding((FlowLayoutPanel1.ClientSize.Width - btnBrowse.Width) \ 2, 10, 0, 0)
                AddHandler btnBrowse.BrowseClick, AddressOf btnBrowseClick
            End If
        Else
            Dim labelKosong As New Label()
            labelKosong.Text = "Tidak Ada Film Disini"
            labelKosong.AutoSize = True
            FlowLayoutPanel1.Controls.Add(labelKosong)
            labelKosong.Margin = New Padding((FlowLayoutPanel1.ClientSize.Width - labelKosong.PreferredWidth) \ 2, 10, 0, 0)
        End If
        conn.Close()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btn.Click
        txtSearch.Clear()
        Loads()
    End Sub

    Private Sub btnBrowseClick(sender As Object, e As EventArgs)
        filterFilm = New Dictionary(Of String, List(Of String))
        filterFilm("Sort") = New List(Of String)
        filterFilm("Genre") = New List(Of String)
        filterFilm("Rating") = New List(Of String)
        filterFilm("Kategori") = New List(Of String)
        Dim lebihBanyak As New lebih_banyak()
        lebihBanyak.Show()
        Dim parent As Form = Me.FindForm()
        If TypeOf parent Is Form1 Then
            Dim f1 As Form1 = CType(parent, Form1)
            f1.Close()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim filmdict As New List(Of card_item_min)
        Connect()
        conn.Open()
        Dim query As String = "SELECT * FROM film WHERE judul LIKE @search"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text + "%")
        reader = cmd.ExecuteReader()
        FlowLayoutPanel1.Controls.Clear()
        Dim card_minimizes As New card_minimize()
        card_minimizes.lblJudul.Text = "Hasil Pencarian"
        card_minimizes.btnBrowse.Visible = False
        While reader.Read()
            Dim card As New card_item_min()
            card.Tag = reader("id_film").ToString()
            card.PictureBox1.ImageLocation = reader("gambar").ToString()
            card.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            filmdict.Add(card)
        End While
        reader.Close()
        For Each card As card_item_min In filmdict
            card.btnAntrian.Parent = card.PictureBox1
            card.btnFavorit.Parent = card.PictureBox1
            card_minimizes.FlowLayoutPanel1.Controls.Add(card)
        Next
        FlowLayoutPanel1.Controls.Add(card_minimizes)
        conn.Close()
    End Sub
End Class
