Public Class btnBrowseAll
    Public Event BrowseClick As EventHandler
    Public Sub New()
        InitializeComponent()
        AddHandler Me.Click, AddressOf OnClicked
        AddHandler Button1.Click, AddressOf OnClicked
        AddHandler Label1.Click, AddressOf OnClicked
        AddHandler Button2.Click, AddressOf OnClicked
    End Sub

    Private Sub OnClicked(sender As Object, e As EventArgs)
        RaiseEvent BrowseClick(Me, e)
    End Sub

End Class
