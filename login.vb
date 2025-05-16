Imports MySql.Data.MySqlClient
Public Class login
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim connString As String = "server=localhost;userid=root;password=;database=dbmanajemenfilm"
    Dim sesi As Integer

    Sub Connect()
        conn = New MySqlConnection(connString)
    End Sub

    Function cekUsernameDanPassword() As Boolean
        Connect()
        conn.Open()
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            conn.Close()
            MessageBox.Show("Username Atau Password tidak boleh kosong")
            Return False
        End If
        Dim query As String = "SELECT * FROM akun WHERE username = @us AND password = @pw"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@us", txtUsername.Text)
        cmd.Parameters.AddWithValue("@pw", txtPassword.Text)
        reader = cmd.ExecuteReader()
        If reader.HasRows Then
            reader.Read()
            sesi = reader("id_akun")
            reader.Close()
            conn.Close()
            Return True
        Else
            reader.Close()
            conn.Close()
            Return False
        End If
    End Function

    Private Async Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim loadd As New loading()
        Panel2.Controls.Add(loadd)
        Await Task.Delay(4000)
        If cekUsernameDanPassword() = True Then
            Panel2.Controls.Clear()
            MessageBox.Show("Login Berhasil")
            Connect()
            conn.Open()
            Dim query As String = "SELECT username, role FROM akun WHERE id_akun = @id"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", sesi)
            reader = cmd.ExecuteReader()
            If reader.Read() Then
                Dim role As String = reader("role").ToString()
                If role = "Admin" Then
                    Dim form_admin As New Form_Admin()
                    form_admin.lblUser.Text = reader("username").ToString()
                    reader.Close()
                    conn.Close()
                    sesiAdmin = sesi
                    sesi = Nothing
                    form_admin.Show()
                    Me.Hide()
                Else
                    Dim form1 As New Form1()
                    reader.Close()
                    conn.Close()
                    sesiUser = sesi
                    sesi = Nothing
                    form1.Show()
                    Me.Hide()
                End If
            End If
        Else
            Panel2.Controls.Clear()
            MessageBox.Show("Akun Tidak Ditemukan")
            txtUsername.Clear()
            txtPassword.Clear()
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim register As New register()
        register.Show()
        Me.Hide()
    End Sub
End Class