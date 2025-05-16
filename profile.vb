Public Class profile
    Private Sub profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFilmFavorit.Left = (Me.Width - lblFilmFavorit.Width) / 2
        lblFilmAntrian.Left = (Me.Width - lblFilmAntrian.Width) / 2
        Button1.Left = (Me.Width - Button1.Width) / 2
        lblUser.Left = (Me.Width - lblUser.Width) / 2
        btnExit.Left = (Me.Width - btnExit.Width) / 2
        btnLogout.Left = (Me.Width - btnLogout.Width) / 2
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        sesiUser = Nothing
        Dim login As New login()
        login.Show()
        Dim parent As Form = Me.FindForm()
        If parent IsNot Nothing Then
            parent.Close()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
