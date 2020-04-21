'Imports System.IO
'Imports Microsoft.WindowsAzure.Storage
'Imports Microsoft.WindowsAzure.Storage.Blob
Imports System
Imports System.IO
Imports System.Threading.Tasks
'Imports Microsoft.Azure.Storage
'Imports Microsoft.Azure.Storage.Blob
Imports Microsoft.WindowsAzure.Storage
Imports Microsoft.WindowsAzure.Storage.Auth
Imports Microsoft.WindowsAzure.Storage.Blob
Imports System.Configuration
Imports System.Threading
Imports Microsoft.WindowsAzure.Storage.Core.Util

Public Class Form1


    Dim doesBrowsing As Boolean = False
    Dim accountName As String = "mkprojectmanagement"
    Dim accessKey As String = "8Akkcxur0kMh6CIlHhQhzD0618VT1P4u1ZRDHx7hnzlZOpo0ZWmSXMFUtPfmn50brHYXAv+mGc2zUR5yL+elHQ=="
    Public Connection As String = "DefaultEndpointsProtocol=https;AccountName=mkprojectmanagement;AccountKey=8Akkcxur0kMh6CIlHhQhzD0618VT1P4u1ZRDHx7hnzlZOpo0ZWmSXMFUtPfmn50brHYXAv+mGc2zUR5yL+elHQ==;EndpointSuffix=core.windows.net"

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Bitmap |*.bmp| JPG | *.jpg | GIF | *.gif | All Files|*.*"
        OpenFileDialog1.FileName = ""

        If OpenFileDialog1.ShowDialog(Me) = DialogResult.OK Then

            'Get the image name 

            Dim img As String = OpenFileDialog1.FileName

            'Create a new Bitmap and display it 

            PictureBox1.Image = System.Drawing.Bitmap.FromFile(img)
            txtPath.Text = img
            doesBrowsing = True


        End If
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Select Case doesBrowsing
            Case False
                MsgBox("Browse some picture first")
            Case True
                'MsgBox("I'm uploading now")
                If Upload(txtPath.Text) = True Then
                    MsgBox("Uploaded Sucessfully")
                End If
                'Dim result = isUploaded(txtPath.Text).Result
                'Console.WriteLine(result)
                'Console.ReadLine()
        End Select
    End Sub

    Public Function Upload(ByVal filename As String) As Boolean
        Try



            Dim connectionString As String = "DefaultEndpointsProtocol=https;AccountName=mkprojectmanagement;AccountKey=8Akkcxur0kMh6CIlHhQhzD0618VT1P4u1ZRDHx7hnzlZOpo0ZWmSXMFUtPfmn50brHYXAv+mGc2zUR5yL+elHQ==;EndpointSuffix=core.windows.net"
            Dim containerName As String = "uploads"


            Dim storageAccount As CloudStorageAccount = CloudStorageAccount.Parse(connectionString)
            Dim blobClient As CloudBlobClient = storageAccount.CreateCloudBlobClient()
            Dim container As CloudBlobContainer = blobClient.GetContainerReference(containerName)
            Dim blockBlob As CloudBlockBlob = container.GetBlockBlobReference(Path.GetFileName(filename).ToString)

            Using FileStream = System.IO.File.OpenRead(filename)
                blockBlob.UploadFromStream(FileStream)
                Return True
            End Using

            'DOWNLOAD File FROM SERVER
            'Dim NewBlob2 As CloudBlockBlob = container.GetBlockBlobReference("10838-03-04-2014--19-12-32.pdf")
            'NewBlob2.DownloadToFile("c:\Folder\LocalFilename.pdf", IO.FileMode.CreateNew)


        Catch ex As Exception
            Return False
            MsgBox(ex.Message)
        End Try
    End Function

    Public Async Function isUploaded(ByVal fileName As String) As Task(Of Boolean)
        Try
            Dim connectionString As String = "DefaultEndpointsProtocol=https;AccountName=mkprojectmanagement;AccountKey=8Akkcxur0kMh6CIlHhQhzD0618VT1P4u1ZRDHx7hnzlZOpo0ZWmSXMFUtPfmn50brHYXAv+mGc2zUR5yL+elHQ==;EndpointSuffix=core.windows.net"
            Dim containerName As String = "uploads"
            Dim storageAccount As CloudStorageAccount = CloudStorageAccount.Parse(connectionString)
            Dim blobClient As CloudBlobClient = storageAccount.CreateCloudBlobClient()
            Dim container As CloudBlobContainer = blobClient.GetContainerReference(containerName)
            Dim blockBlob As CloudBlockBlob = container.GetBlockBlobReference(Path.GetFileName(fileName).ToString)
            ' Define the function how to handle the infromation

            Dim handelr As Action(Of StorageProgress) = Sub(progress) Console.WriteLine("Progress: {0} bytes transferred", progress.BytesTransferred)
            Dim progressHandler As IProgress(Of StorageProgress) = New Progress(Of StorageProgress)(handelr)
            Dim cancellationToken As CancellationToken = New CancellationToken()

            Using FileStream = File.OpenRead(fileName)
                Await blockBlob.UploadFromStreamAsync(FileStream,
                                                       New AccessCondition(),
                                                       New BlobRequestOptions(),
                                                       New OperationContext(),
                                                       progressHandler,
                                                       cancellationToken)
                Return True
            End Using
        Catch ex As Exception
            Return False
            MsgBox(ex.Message)

        End Try
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub
    '09096509014










End Class
