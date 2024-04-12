<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlScan
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label4 = New Label()
        Panel1 = New Panel()
        ListView1 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ProgressBar1 = New ProgressBar()
        ProgressBar2 = New ProgressBar()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        lblVirus = New Label()
        lblTotal = New Label()
        Button1 = New Button()
        Button2 = New Button()
        btnDeepScan = New Button()
        btnOther = New Button()
        btnSmartScan = New Button()
        Label7 = New Label()
        lblLast = New Label()
        Timer1 = New Timer(components)
        FolderBrowserDialog1 = New FolderBrowserDialog()
        OpenFileDialog1 = New OpenFileDialog()
        ListBox1 = New ListBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(54), CByte(63), CByte(90))
        Label1.FlatStyle = FlatStyle.Popup
        Label1.Font = New Font("Segoe UI", 22.0F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(472, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(217, 50)
        Label1.TabIndex = 8
        Label1.Text = "Scan Centre"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(54), CByte(63), CByte(90))
        Label4.Font = New Font("Segoe UI", 12.0F)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(393, 72)
        Label4.Name = "Label4"
        Label4.Size = New Size(367, 28)
        Label4.TabIndex = 12
        Label4.Text = "Press on the GO!button to start the scan!"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Orange
        Panel1.Controls.Add(ListView1)
        Panel1.Location = New Point(307, 118)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(583, 428)
        Panel1.TabIndex = 13
        ' 
        ' ListView1
        ' 
        ListView1.BackColor = Color.White
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3})
        ListView1.GridLines = True
        ListView1.Location = New Point(3, 15)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(577, 403)
        ListView1.TabIndex = 0
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "File Scanned"
        ColumnHeader1.Width = 270
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Type"
        ColumnHeader2.Width = 170
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Status"
        ColumnHeader3.Width = 130
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(312, 552)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(578, 29)
        ProgressBar1.TabIndex = 14
        ' 
        ' ProgressBar2
        ' 
        ProgressBar2.Location = New Point(312, 587)
        ProgressBar2.Name = "ProgressBar2"
        ProgressBar2.Size = New Size(578, 51)
        ProgressBar2.TabIndex = 15
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Screenshot_2024_04_11_204702
        PictureBox1.Location = New Point(14, 142)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(133, 94)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.Screenshot_2024_04_11_204936
        PictureBox2.Location = New Point(153, 142)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(133, 94)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 17
        PictureBox2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(54), CByte(63), CByte(90))
        Label2.Font = New Font("Segoe UI", 12.0F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(11, 239)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 28)
        Label2.TabIndex = 18
        Label2.Text = "File Scanned"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(54), CByte(63), CByte(90))
        Label3.Font = New Font("Segoe UI", 12.0F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(150, 239)
        Label3.Name = "Label3"
        Label3.Size = New Size(146, 28)
        Label3.TabIndex = 19
        Label3.Text = "Detected Treats"
        ' 
        ' lblVirus
        ' 
        lblVirus.AutoSize = True
        lblVirus.BackColor = Color.Red
        lblVirus.Font = New Font("Segoe UI", 12.0F)
        lblVirus.ForeColor = Color.White
        lblVirus.Location = New Point(205, 175)
        lblVirus.Name = "lblVirus"
        lblVirus.Size = New Size(23, 28)
        lblVirus.TabIndex = 20
        lblVirus.Text = "0"
        lblVirus.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.BackColor = Color.FromArgb(CByte(49), CByte(53), CByte(86))
        lblTotal.Font = New Font("Segoe UI", 12.0F)
        lblTotal.ForeColor = Color.White
        lblTotal.Location = New Point(67, 175)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(23, 28)
        lblTotal.TabIndex = 21
        lblTotal.Text = "0"
        lblTotal.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DeepPink
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(10, 596)
        Button1.Name = "Button1"
        Button1.Size = New Size(123, 42)
        Button1.TabIndex = 23
        Button1.Text = "HIDE"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(166, 596)
        Button2.Name = "Button2"
        Button2.Size = New Size(116, 42)
        Button2.TabIndex = 24
        Button2.Text = "STOP"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' btnDeepScan
        ' 
        btnDeepScan.FlatStyle = FlatStyle.Popup
        btnDeepScan.Font = New Font("Segoe UI", 9.0F)
        btnDeepScan.ForeColor = Color.White
        btnDeepScan.Image = My.Resources.Resources.icons8_my_computer_64
        btnDeepScan.ImageAlign = ContentAlignment.TopCenter
        btnDeepScan.Location = New Point(108, 498)
        btnDeepScan.Name = "btnDeepScan"
        btnDeepScan.Size = New Size(97, 86)
        btnDeepScan.TabIndex = 25
        btnDeepScan.Text = "Deep Scan"
        btnDeepScan.TextAlign = ContentAlignment.BottomCenter
        btnDeepScan.UseVisualStyleBackColor = True
        ' 
        ' btnOther
        ' 
        btnOther.FlatStyle = FlatStyle.Popup
        btnOther.Font = New Font("Segoe UI", 9.0F)
        btnOther.ForeColor = Color.White
        btnOther.Image = My.Resources.Resources.icons8_search_50
        btnOther.ImageAlign = ContentAlignment.TopCenter
        btnOther.Location = New Point(208, 498)
        btnOther.Name = "btnOther"
        btnOther.Size = New Size(97, 86)
        btnOther.TabIndex = 26
        btnOther.Text = "Other Scan"
        btnOther.TextAlign = ContentAlignment.BottomCenter
        btnOther.UseVisualStyleBackColor = True
        ' 
        ' btnSmartScan
        ' 
        btnSmartScan.FlatStyle = FlatStyle.Popup
        btnSmartScan.Font = New Font("Segoe UI", 9.0F)
        btnSmartScan.ForeColor = Color.White
        btnSmartScan.Image = My.Resources.Resources.icons8_window_search_50
        btnSmartScan.ImageAlign = ContentAlignment.TopCenter
        btnSmartScan.Location = New Point(7, 498)
        btnSmartScan.Name = "btnSmartScan"
        btnSmartScan.Size = New Size(100, 86)
        btnSmartScan.TabIndex = 27
        btnSmartScan.Text = "Smart Scan"
        btnSmartScan.TextAlign = ContentAlignment.BottomCenter
        btnSmartScan.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.FromArgb(CByte(54), CByte(63), CByte(90))
        Label7.Font = New Font("Segoe UI", 12.0F)
        Label7.ForeColor = Color.Orange
        Label7.Location = New Point(6, 273)
        Label7.Name = "Label7"
        Label7.Size = New Size(121, 28)
        Label7.TabIndex = 28
        Label7.Text = "File Scanned"
        ' 
        ' lblLast
        ' 
        lblLast.BackColor = Color.FromArgb(CByte(54), CByte(63), CByte(90))
        lblLast.Font = New Font("Segoe UI", 12.0F)
        lblLast.ForeColor = Color.Orange
        lblLast.Location = New Point(6, 305)
        lblLast.Name = "lblLast"
        lblLast.Size = New Size(294, 180)
        lblLast.TabIndex = 29
        lblLast.Text = "C:\"
        ' 
        ' Timer1
        ' 
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(14, 16)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(60, 44)
        ListBox1.TabIndex = 30
        ' 
        ' ctlScan
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(54), CByte(63), CByte(90))
        Controls.Add(ListBox1)
        Controls.Add(lblLast)
        Controls.Add(Label7)
        Controls.Add(btnSmartScan)
        Controls.Add(btnOther)
        Controls.Add(btnDeepScan)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(lblTotal)
        Controls.Add(lblVirus)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(ProgressBar2)
        Controls.Add(ProgressBar1)
        Controls.Add(Panel1)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Name = "ctlScan"
        Size = New Size(928, 663)
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblVirus As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnDeepScan As Button
    Friend WithEvents btnOther As Button
    Friend WithEvents btnSmartScan As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents lblLast As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ListBox1 As ListBox

End Class
