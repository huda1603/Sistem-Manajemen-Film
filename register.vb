Imports MySql.Data.MySqlClient
Public Class register
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim connString As String = "server=localhost;userid=root;password=;database=dbmanajemenfilm"

    Sub Connect()
        conn = New MySqlConnection(connString)
    End Sub

    Function cekUsername() As Boolean
        Connect()
        conn.Open()
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            conn.Close()
            MessageBox.Show("Username Atau Password tidak boleh kosong")
            Return True
        End If
        Dim query As String = "SELECT * FROM akun WHERE username = @us AND role = @rl"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@us", txtUsername.Text)
        cmd.Parameters.AddWithValue("@rl", "Pengguna Biasa")
        reader = cmd.ExecuteReader()
        If reader.HasRows Then
            reader.Close()
            conn.Close()
            MessageBox.Show("Username sudah ada")
            Return True
        Else
            reader.Close()
            conn.Close()
            Return False
        End If
    End Function

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If cekUsername() = False Then
            Connect()
            conn.Open()
            Dim query As String = "INSERT INTO akun (username, password, role) VALUES (@us, @pw, @rl)"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@us", txtUsername.Text)
            cmd.Parameters.AddWithValue("@pw", txtPassword.Text)
            cmd.Parameters.AddWithValue("@rl", "Pengguna Biasa")
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Berhasil Register")
            Dim login As New login()
            login.Show()
            Me.Hide()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim login As New login()
        login.Show()
        Me.Hide()
    End Sub
End Class