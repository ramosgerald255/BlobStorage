<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BlobStorage.My.Resources.Resources.man
        Me.PictureBox1.Location = New System.Drawing.Point(84, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(170, 168)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(84, 186)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(170, 34)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Browse Image"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtPath
        '
        Me.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPath.Location = New System.Drawing.Point(12, 245)
        Me.txtPath.Multiline = True
        Me.txtPath.Name = "txtPath"
        Me.txtPath.ReadOnly = True
        Me.txtPath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPath.Size = New System.Drawing.Size(322, 84)
        Me.txtPath.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 229)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "File Path"
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnUpload.FlatAppearance.BorderSize = 0
        Me.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpload.ForeColor = System.Drawing.Color.White
        Me.btnUpload.Location = New System.Drawing.Point(165, 360)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(170, 34)
        Me.btnUpload.TabIndex = 4
        Me.btnUpload.Text = "Upload to Azure"
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(12, 360)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 34)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "View Cloud Files"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 406)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Azure Blob Uploader"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents txtPath As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUpload As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button1 As Button
End Class
