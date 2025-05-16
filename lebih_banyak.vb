Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient

Public Class lebih_banyak
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim connString As String = "server=localhost;userid=root;password=;database=dbmanajemenfilm"
    Dim filterMuncul As Boolean = False
    Dim posisiTopAwalFilter As Integer = 542

    Sub Connect()
        conn = New MySqlConnection(connString)
    End Sub

    Function updateQuery(ByRef query As String, key As String, item As String) As String
        query += " "
        Dim ekspresi As String = Nothing
        If item IsNot "Trending" Then
            If item.Equals("Rating Tertinggi") Then
                key = "rating"
                item = "5"
            End If
            ekspresi = " LIKE '%" + item + "%'"
        Else
            key = "views"
            ekspresi = " > " + (8).ToString()
        End If
        If query.Contains("WHERE") Then
            query += "OR " + key + ekspresi
        Else
            query += "WHERE " + key + ekspresi
        End If
        Return query
    End Function

    Private Sub lebih_banyak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openFormMoreFilm = True
        Loads()
    End Sub

    Public Sub Loads()
        FlowLayoutPanel1.Controls.Clear()
        FlowLayoutPanel2.Controls.Clear()
        Dim filterItem As New List(Of String)
        Connect()
        conn.Open()
        Dim query As String = "SELECT * FROM film"
        For Each f As KeyValuePair(Of String, List(Of String)) In filterFilm
            If f.Key IsNot "Sort" Then
                For i As Integer = 0 To f.Value.Count - 1
                    updateQuery(query, f.Key.ToLower, f.Value(i))
                    filterItem.Add(f.Value(i))
                Next
            End If
        Next
        If filterFilm("Sort").Count > 0 Then
            query += " ORDER BY " + filterFilm("Sort")(0).ToLower + " " + filterFilm("Sort")(1).ToUpper
            filterItem.Add(filterFilm("Sort")(0) + ":" + filterFilm("Sort")(1))
        End If
        cmd = New MySqlCommand(query, conn)
        reader = cmd.ExecuteReader()
        While reader.Read()
            Dim card As New card_item_max()
            card.Tag = reader("id_film").ToString()
            card.PictureBox1.ImageLocation = reader("gambar").ToString()
            card.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            card.lblJudul.Text = reader("judul").ToString()
            card.lblGenre.Text = reader("genre").ToString()
            card.lblJudul.Parent = card.PictureBox1
            card.lblGenre.Parent = card.PictureBox1
            card.btnAntrian.Parent = card.PictureBox1
            card.btnFavorit.Parent = card.PictureBox1
            FlowLayoutPanel1.Controls.Add(card)
        End While
        reader.Close()
        conn.Close()
        For Each item As String In filterItem
            Dim itemFilter As New filter_item()
            itemFilter.lblFilter.Text = item
            FlowLayoutPanel2.Controls.Add(itemFilter)
        Next
    End Sub

    Private Sub btnOut_Click(sender As Object, e As EventArgs) Handles btnOut.Click
        filterFilm("Sort").Clear()
        filterFilm("Genre").Clear()
        filterFilm("Rating").Clear()
        filterFilm("Kategori").Clear()
        openFormMoreFilm = False
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
    End Sub

    Public Sub munculkanPanel()
        filterMuncul = True
        Dim filter As New Panel_Filter()
        Panel2.Controls.Add(filter)
        Timer1.Interval = 5
        Timer1.Start()
    End Sub

    Public Sub hilangkanPanel()
        filterMuncul = False
        Timer1.Interval = 5
        Timer1.Start()
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        If filterMuncul.Equals(False) Then
            munculkanPanel()
        Else
            hilangkanPanel()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If filterMuncul.Equals(True) Then
            If Panel2.Top >= FlowLayoutPanel1.Top Then
                Panel2.Top -= 25
            Else
                Panel2.Top = FlowLayoutPanel1.Top
                Timer1.Stop()
            End If
        Else
            If Panel2.Top <= posisiTopAwalFilter Then
                Panel2.Top += 25
            Else
                Panel2.Top = posisiTopAwalFilter
                Panel2.Controls.Clear()
                Timer1.Stop()
            End If
        End If
    End Sub
End Class