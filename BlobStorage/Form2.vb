Public Class Form2
    Public Listing As New ListBlob

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Listing.ListAllItems(Form1.Connection, TableLayoutPanel1, FolderBrowserDialog1)
    End Sub
End Class