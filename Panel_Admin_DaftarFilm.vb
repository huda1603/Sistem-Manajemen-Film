Imports System.Drawing.Printing
Imports System.Linq.Expressions
Imports MySql.Data.MySqlClient

Public Class Panel_Admin_DaftarFilm
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim connString As String = "server=localhost;userid=root;password=;database=dbmanajemenfilm"
    Dim pageWidth As Integer = 827
    Dim pageHeight As Integer = 1169
    Dim listFilm As New List(Of List(Of String))()
    Dim currentPage, totalPage, totalItem, marginPixels, y, x, marginRight As Integer
    Dim marginInch As Single

    Private Sub readDataFilm()
        Connect()
        conn.Open()
        cmd = New MySqlCommand("SELECT * FROM film", conn)
        reader = cmd.ExecuteReader
        totalItem = 0
        Do While reader.Read()
            Dim dataFilm As New List(Of String)()
            dataFilm.Add(reader("id_film").ToString)
            dataFilm.Add(reader("judul").ToString)
            dataFilm.Add(reader("genre").ToString)
            dataFilm.Add(reader("rating").ToString)
            dataFilm.Add(reader("views").ToString)
            dataFilm.Add(reader("gambar").ToString)
            listFilm.Add(dataFilm)
            totalItem += 1
        Loop
        totalPage = Math.Ceiling(totalItem / 3)
        reader.Close()
        conn.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim Fheader As New Font("Times New Roman", 24, FontStyle.Bold)
        Dim FBodyB As New Font("Times New Roman", 14, FontStyle.Bold)
        Dim FBody As New Font("Times New Roman", 14, FontStyle.Regular)
        Dim black As SolidBrush = New SolidBrush(Color.Black)
        Dim center As New StringFormat()
        center.Alignment = StringAlignment.Center
        Dim posY, i As Integer
        Dim hitung As Integer = 0
        If currentPage <= 1 Then
            marginInch = 2.54F
            marginPixels = CInt(e.PageSettings.PrinterResolution.X * marginInch)
            e.PageSettings.Margins = New Margins(marginPixels, marginPixels, marginPixels, marginPixels)
            x = e.MarginBounds.Left
            y = e.MarginBounds.Top
            marginRight = e.MarginBounds.Right
            e.Graphics.DrawString("Data Film", Fheader, black, pageWidth / 2, y, center)
            posY = y + 70
        Else
            posY = y
        End If
        e.Graphics.DrawLine(Pens.Black, x, posY, marginRight, posY)
        For i = (currentPage - 1) * 3 To totalItem - 1
            e.Graphics.DrawString("ID Film", FBody, black, x + 20, posY + 30)
            e.Graphics.DrawString(": " & listFilm(i)(0).ToString, FBody, black, x + 200, posY + 30)
            e.Graphics.DrawString("Judul", FBody, black, x + 20, posY + 60)
            e.Graphics.DrawString(": " & listFilm(i)(1).ToString, FBody, black, x + 200, posY + 60)
            e.Graphics.DrawString("Genre", FBody, black, x + 20, posY + 90)
            e.Graphics.DrawString(": " & listFilm(i)(2).ToString, FBody, black, x + 200, posY + 90)
            e.Graphics.DrawString("Rating", FBody, black, x + 20, posY + 120)
            e.Graphics.DrawString(": " & listFilm(i)(3).ToString, FBody, black, x + 200, posY + 120)
            e.Graphics.DrawString("Views", FBody, black, x + 20, posY + 150)
            e.Graphics.DrawString(": " & listFilm(i)(4).ToString, FBody, black, x + 200, posY + 150)
            e.Graphics.DrawString("Gambar", FBody, black, x + 20, posY + 180)
            e.Graphics.DrawString(": " & listFilm(i)(5).ToString, FBody, black, x + 200, posY + 180)
            posY += 270
            hitung += 1
            If hitung >= 3 Then
                Exit For
            End If
        Next
        If currentPage <= 1 Then
            e.Graphics.DrawLine(Pens.Black, x, y + 70, x, posY + 10)
            e.Graphics.DrawLine(Pens.Black, marginRight, y + 70, marginRight, posY + 10)
        Else
            e.Graphics.DrawLine(Pens.Black, x, y, x, posY + 10)
            e.Graphics.DrawLine(Pens.Black, marginRight, y, marginRight, posY + 10)
        End If
        currentPage += 1
        e.HasMorePages = currentPage <= totalPage
    End Sub

    Private Function ResizeImage(img As Image, scalePercent As Integer) As Image
        Dim newWidth As Integer = img.Width * scalePercent \ 100
        Dim newHeight As Integer = img.Height * scalePercent \ 100
        Dim bmp As New Bitmap(newWidth, newHeight)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.DrawImage(img, 0, 0, newWidth, newHeight)
        End Using
        Return bmp
    End Function

    Sub Connect()
        conn = New MySqlConnection(connString)
    End Sub

    Sub cls()
        DataGridView1.Controls.Clear()
        txtItem.Clear()
    End Sub

    Private Sub Panel_Admin_DaftarFilm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loads()
    End Sub

    Private Sub Loads()
        cls()
        Connect()
        Try
            conn.Open()
            Dim query As String = "SELECT judul, genre, tglrilis, rating, gambar, views FROM film WHERE id_akun = @id"
            Dim adapter As New MySqlDataAdapter(query, conn)
            adapter.SelectCommand.Parameters.AddWithValue("@id", sesiAdmin)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            DataGridView1.Rows.Clear()
            For Each row As DataRow In dt.Rows
                Dim gambar As Image = ResizeImage(Image.FromFile(row("gambar")), 40)
                Dim lebarGambar As Integer = gambar.Width
                Dim tinggiGambar As Integer = gambar.Height
                DataGridView1.Columns(4).Width = lebarGambar
                DataGridView1.RowTemplate.Height = tinggiGambar + 50
                DataGridView1.Rows.Add(row("judul"), row("genre"), row("tglrilis"), row("rating"), gambar, row("views"))
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        judulLama = txtItem.Text
        Dim edit_admin As New Halaman_Edit_Admin()
        Dim indeks As Integer = DataGridView1.CurrentRow.Index
        Dim lblGenre As String = DataGridView1.Rows(indeks).Cells(1).Value.ToString()
        Dim lblTglRilis As String = DataGridView1.Rows(indeks).Cells(2).Value.ToString()
        Connect()
        conn.Open()
        Dim query As String = "SELECT gambar FROM film WHERE judul = @ju AND id_akun = @id"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@ju", txtItem.Text)
        cmd.Parameters.AddWithValue("@id", sesiAdmin)
        reader = cmd.ExecuteReader()
        reader.Read()
        Dim lblGambar As String = reader("gambar").ToString()
        reader.Close()
        conn.Close()
        Dim listCbStr() As String = lblGenre.Split(New String() {", "}, StringSplitOptions.None)

        edit_admin.txtJudul.Text = txtItem.Text
        For i As Integer = 0 To listCbStr.Count - 1
            If edit_admin.cbAdv.Text = listCbStr(i) Then
                edit_admin.cbAdv.Checked = True
            ElseIf edit_admin.cbHor.Text = listCbStr(i) Then
                edit_admin.cbHor.Checked = True
            ElseIf edit_admin.cbAct.Text = listCbStr(i) Then
                edit_admin.cbAct.Checked = True
            ElseIf edit_admin.cbCom.Text = listCbStr(i) Then
                edit_admin.cbCom.Checked = True
            ElseIf edit_admin.cbSciFi.Text = listCbStr(i) Then
                edit_admin.cbSciFi.Checked = True
            ElseIf edit_admin.cbDra.Text = listCbStr(i) Then
                edit_admin.cbDra.Checked = True
            ElseIf edit_admin.cbThr.Text = listCbStr(i) Then
                edit_admin.cbThr.Checked = True
            ElseIf edit_admin.cbMis.Text = listCbStr(i) Then
                edit_admin.cbMis.Checked = True
            ElseIf edit_admin.cbRom.Text = listCbStr(i) Then
                edit_admin.cbRom.Checked = True
            ElseIf edit_admin.cbMus.Text = listCbStr(i) Then
                edit_admin.cbMus.Checked = True
            End If
        Next
        edit_admin.tanggalRilis.Value = Date.Parse(lblTglRilis)
        edit_admin.PictureBox1.ImageLocation = lblGambar
        edit_admin.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        edit_admin.Show()
        Dim parent As Form = Me.FindForm()
        If parent IsNot Nothing Then
            parent.Close()
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim tambah_admin As New Halaman_Tambah_Admin()
        tambah_admin.Show()
        Dim parent As Form = Me.FindForm()
        If parent IsNot Nothing Then
            parent.Close()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim indeks As Integer = DataGridView1.CurrentRow.Index
        Dim lblJudul As String = DataGridView1.Rows(indeks).Cells(0).Value.ToString()
        Connect()
        Try
            conn.Open()
            Dim query As String = "DELETE FROM film WHERE judul = @ju AND id_akun = @id"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@ju", lblJudul)
            cmd.Parameters.AddWithValue("@id", sesiAdmin)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Berhasil Menghapus Film")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
        Loads()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        cls()
        If e.RowIndex >= 0 And e.RowIndex < DataGridView1.Rows.Count Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            txtItem.Text = row.Cells("Judul_Film").Value.ToString()
        End If
    End Sub

    Private Sub CetakFilmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CetakFilmToolStripMenuItem.Click
        readDataFilm()
        currentPage = 1
        PrintDocument1.Print()
    End Sub

    Private Sub CetakFilmDenganGambarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CetakFilmDenganGambarToolStripMenuItem.Click
        readDataFilm()
        currentPage = 1
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub
End Class