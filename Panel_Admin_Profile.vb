Public Class Panel_Admin_Profile
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        sesiAdmin = Nothing
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
