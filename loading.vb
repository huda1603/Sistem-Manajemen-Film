Public Class loading
    Dim d As New Dictionary(Of String, Button)
    Dim putaran2 As Integer = 1
    Dim lap2 As Integer = 1

    Private Sub loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each b As Button In {Button1, Button2, Button3}
            b.Image = My.Resources.dry_clean
            d.Add(b.Tag, b)
        Next
        Timer1.Interval = 120
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        d(putaran2.ToString()).Image = My.Resources.record
        If putaran2 > 1 Then
            d((putaran2 - 1).ToString()).Image = My.Resources.dry_clean
        Else
            d("3").Image = My.Resources.dry_clean
        End If
        putaran2 += 1
        If putaran2.Equals(4) Then
            lap2 += 1
            putaran2 = 1
        End If
        If lap2.Equals(6) Then
            For Each b As Button In {Button1, Button2, Button3}
                b.Image = My.Resources.dry_clean
            Next
            Timer1.Stop()
        End If
    End Sub
End Class
