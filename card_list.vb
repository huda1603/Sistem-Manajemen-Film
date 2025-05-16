Imports MySql.Data.MySqlClient

Public Class card_list
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim connString As String = "server=localhost;userid=root;password=;database=dbmanajemenfilm"

    Sub Connect()
        conn = New MySqlConnection(connString)
    End Sub

    Private Sub card_list_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Dim infoFilm As New info_film()
        infoFilm.PictureBox1.ImageLocation = PictureBox1.ImageLocation
        infoFilm.lblJudul.Text = lblJudul.Text
        infoFilm.lblGenre.Text = lblGenre.Text
        infoFilm.PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        infoFilm.lblJudul.Left = (infoFilm.Panel1.Width - infoFilm.lblJudul.Width) \ 2
        infoFilm.lblGenre.Left = (infoFilm.Panel1.Width - infoFilm.lblGenre.Width) \ 2
        Connect()
        conn.Open()
        Dim query As String = "SELECT views FROM film WHERE judul = @ju AND genre = @ge"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@ju", lblJudul.Text)
        cmd.Parameters.AddWithValue("@ge", lblGenre.Text)
        reader = cmd.ExecuteReader()
        reader.Read()
        infoFilm.lblView.Text = reader("views").ToString()
        infoFilm.Button1.Left = ((infoFilm.Width - infoFilm.Button1.Width) \ 2) - 8
        infoFilm.lblView.Left = ((infoFilm.Width - infoFilm.lblView.Width) \ 2) + 8
        reader.Close()
        conn.Close()
        infoFilm.Show()
        Dim parent As Form = Me.FindForm()
        If TypeOf parent Is Form1 Then
            Dim f1 As Form1 = CType(parent, Form1)
            f1.Close()
        End If
    End Sub

    Private Sub card_list_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        Me.BackColor = Color.Aquamarine
    End Sub

    Private Sub card_list_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        Me.BackColor = Color.Gainsboro
    End Sub

    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
        Connect()
        conn.Open()
        Dim id_film As Integer
        Dim query As String = "SELECT id_film FROM film WHERE judul = @ju"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@ju", lblJudul.Text)
        reader = cmd.ExecuteReader()
        reader.Read()
        id_film = reader("id_film")
        reader.Close()
        If btnList.Tag = "Hearth" Then
            Dim query2 As String = "DELETE FROM film_favorit WHERE id_film = @id_film AND id_akun = @id_akun"
            cmd = New MySqlCommand(query2, conn)
            cmd.Parameters.AddWithValue("@id_film", id_film)
            cmd.Parameters.AddWithValue("@id_akun", sesiUser)
            If cmd.ExecuteNonQuery() > 0 Then
                btnList.Image = My.Resources.hearth_not_fill
                MessageBox.Show("Dihapus Dari Daftar Favorit")
            End If
        Else
            Dim query2 As String = "DELETE FROM film_antrian WHERE id_film = @id_film AND id_akun = @id_akun"
            cmd = New MySqlCommand(query2, conn)
            cmd.Parameters.AddWithValue("@id_film", id_film)
            cmd.Parameters.AddWithValue("@id_akun", sesiUser)
            If cmd.ExecuteNonQuery() > 0 Then
                btnList.Image = My.Resources.playlist_not_fill
                MessageBox.Show("Dihapus Dari Daftar Antrian")
            End If
        End If
        conn.Close()
        Dim parentUC As Control = Me.Parent.Parent
        If TypeOf parentUC Is daftar Then
            Dim uc As daftar = CType(parentUC, daftar)
            uc.Loads()
        End If
    End Sub
End Class
