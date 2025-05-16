Public Class filter_item
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If lblFilter.Text.Contains(":") Then
            filterFilm("Sort").Clear()
        Else
            For Each f As KeyValuePair(Of String, List(Of String)) In filterFilm
                filterFilm(f.Key).Remove(lblFilter.Text)
            Next
        End If
        Dim parent As Form = Me.FindForm()
        If TypeOf parent Is lebih_banyak Then
            Dim lb As lebih_banyak = CType(parent, lebih_banyak)
            lb.Loads()
        End If
    End Sub
End Class
