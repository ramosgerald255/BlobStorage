Imports Microsoft.Azure.Storage
Imports Microsoft.Azure.Storage.Blob

Public Class ListBlob
    Public Function ListAllItems(ByVal connectionString As String, ByVal TLP As TableLayoutPanel, ByVal FBD As FolderBrowserDialog)
        Dim backupStorageAccount As CloudStorageAccount = CloudStorageAccount.Parse(connectionString)
        Dim backupBlobClient As CloudBlobClient = backupStorageAccount.CreateCloudBlobClient()
        Dim backupContainer As CloudBlobContainer = backupBlobClient.GetContainerReference("uploads")

        Dim blobs = backupContainer.ListBlobs().OfType(Of CloudBlockBlob).ToList
        Dim blobList As New List(Of String)
        Dim row As Integer = 0
        For Each singleblob In blobs
            Dim blobName As String = singleblob.Name
            blobList.Add(blobName)
            Console.WriteLine(blobName)

            Dim BlobFileName As New Label
            BlobFileName.Text = blobName

            Dim btnDownload As New Button
            btnDownload.Text = "Download"
            AddHandler btnDownload.Click,
                Sub(s As Object, e As EventArgs)
                    FBD.ShowNewFolderButton = True
                    If (FBD.ShowDialog() = DialogResult.OK) Then
                        Dim selectedPath As String = FBD.SelectedPath
                        Console.WriteLine(selectedPath)
                        Dim blobFile As CloudBlockBlob = backupContainer.GetBlockBlobReference(blobName)
                        blobFile.DownloadToFile(selectedPath + "\" + blobName, System.IO.FileMode.Create)
                        Console.WriteLine("downloaded successfully")
                    End If
                End Sub

            TLP.SuspendLayout()
            TLP.RowStyles.Add(New RowStyle(SizeType.Absolute, 50))
            TLP.Controls.Add(BlobFileName, 0, row)
            TLP.Controls.Add(btnDownload, 1, row)
            TLP.ResumeLayout()
            row = row + 1
        Next


    End Function
End Class
