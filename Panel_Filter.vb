Public Class Panel_Filter
    Private Sub cls()
        For Each rb As RadioButton In {rbJudul, rbRating, rbAsc, rbDesc}
            rb.Checked = False
        Next
        For Each cb As CheckBox In {cbAdv, cbHor, cbAct, cbThr, cbRom, cbSciFi, cbCom, cbDra, cbMis, cbMus, cb1, cb2, cb3, cb4, cb5, cbTrending, cbRating}
            cb.Checked = False
        Next
    End Sub

    Private Sub Panel_Filter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loads()
    End Sub

    Private Sub Loads()
        For Each f As KeyValuePair(Of String, List(Of String)) In filterFilm
            For Each item As String In f.Value
                For Each rb As RadioButton In {rbJudul, rbRating, rbAsc, rbDesc}
                    If rb.Text.Equals(item) Or rb.Text.Equals(item + "ending") Then
                        rb.Checked = True
                    End If
                Next
                For Each cb As CheckBox In {cbAdv, cbHor, cbAct, cbThr, cbRom, cbSciFi, cbCom, cbDra, cbMis, cbMus, cb1, cb2, cb3, cb4, cb5, cbTrending, cbRating}
                    If cb.Text.Equals(item) Then
                        cb.Checked = True
                    End If
                Next
            Next
        Next
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        filterFilm = New Dictionary(Of String, List(Of String))
        filterFilm("Sort") = New List(Of String)
        filterFilm("Genre") = New List(Of String)
        filterFilm("Rating") = New List(Of String)
        filterFilm("Kategori") = New List(Of String)
        Dim urutBerdasarkan = False
        Dim jenisPengurutan = False
        If rbJudul.Checked Or rbRating.Checked Then
            urutBerdasarkan = True
        End If
        If rbAsc.Checked Or rbDesc.Checked Then
            jenisPengurutan = True
        End If
        If urutBerdasarkan.Equals(True) AndAlso jenisPengurutan.Equals(True) Then
            For Each rb As RadioButton In {rbJudul, rbRating, rbAsc, rbDesc}
                If rb.Checked Then
                    filterFilm("Sort").Add(rb.Text.Replace("ending", ""))
                End If
            Next
        ElseIf urutBerdasarkan.Equals(True) AndAlso jenisPengurutan.Equals(False) Then
            MessageBox.Show("Jika Sudah Memilih Urut Berdasarkan, Maka Harus Memilih Jenis Pengurutan Juga")
            Exit Sub
        ElseIf urutBerdasarkan.Equals(False) AndAlso jenisPengurutan.Equals(True) Then
            MessageBox.Show("Jika Sudah Memilih Jenis Pengurutan, Maka Harus Memilih Urut Berdasarkan Juga")
            Exit Sub
        End If
        For Each cb As CheckBox In {cbAdv, cbHor, cbAct, cbThr, cbRom, cbSciFi, cbCom, cbDra, cbMis, cbMus}
            If cb.Checked Then
                filterFilm("Genre").Add(cb.Text)
            End If
        Next
        For Each cb As CheckBox In {cb1, cb2, cb3, cb4, cb5}
            If cb.Checked Then
                filterFilm("Rating").Add(cb.Text)
            End If
        Next
        For Each cb As CheckBox In {cbTrending, cbRating}
            If cb.Checked Then
                filterFilm("Kategori").Add(cb.Text)
            End If
        Next
        Dim parent As Form = Me.FindForm()
        If TypeOf parent Is lebih_banyak Then
            Dim lebihBanyak As lebih_banyak = CType(parent, lebih_banyak)
            lebihBanyak.hilangkanPanel()
            lebihBanyak.Loads()
        End If
        cls()
    End Sub
End Class
