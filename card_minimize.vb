Public Class card_minimize
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        filterFilm = New Dictionary(Of String, List(Of String))
        filterFilm("Sort") = New List(Of String)
        filterFilm("Genre") = New List(Of String)
        filterFilm("Rating") = New List(Of String)
        filterFilm("Kategori") = New List(Of String)
        If lblJudul.Text.Equals("Film Trending") Then
            filterFilm("Kategori").Add("Trending")
        ElseIf lblJudul.Text.Equals("Film Rating Tertinggi") Then
            filterFilm("Kategori").Add("Rating Tertinggi")
        End If
        Dim lebihBanyak As New lebih_banyak()
        lebihBanyak.Show()
        Dim parent As Form = Me.FindForm()
        If parent IsNot Nothing Then
            parent.Close()
        End If
    End Sub
End Class
