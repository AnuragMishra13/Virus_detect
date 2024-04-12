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
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Button2 = New Button()
        Panel5 = New Panel()
        Panel6 = New Panel()
        Button1 = New Button()
        CtlScan1 = New ctlScan()
        Panel4 = New Panel()
        btnSettings = New Button()
        btnManager = New Button()
        btnResults = New Button()
        btnPrivacy = New Button()
        btnProtection = New Button()
        btnHome = New Button()
        CtlHome1 = New ctlHome()
        CtlProtection1 = New ctlProtection()
        CtlScan2 = New ctlScan()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(909, 0)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(28), CByte(114), CByte(157))
        Panel2.Controls.Add(Panel3)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(909, 47)
        Panel2.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(28), CByte(114), CByte(157))
        Panel3.Controls.Add(PictureBox1)
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(Button2)
        Panel3.Controls.Add(Panel5)
        Panel3.Controls.Add(Button1)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(909, 47)
        Panel3.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.icons8_bell_24
        PictureBox1.Location = New Point(780, 6)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(32, 38)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Segoe UI", 12.0F)
        Label1.Location = New Point(46, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 28)
        Label1.TabIndex = 4
        Label1.Text = "Free Antivirus"
        ' 
        ' Button2
        ' 
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(818, 13)
        Button2.Name = "Button2"
        Button2.Size = New Size(40, 29)
        Button2.TabIndex = 5
        Button2.Text = "__"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(102), CByte(50), CByte(173))
        Panel5.Controls.Add(Panel6)
        Panel5.Location = New Point(3, 12)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(30, 29)
        Panel5.TabIndex = 4
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.Yellow
        Panel6.Location = New Point(8, 7)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(22, 22)
        Panel6.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(864, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(40, 29)
        Button1.TabIndex = 4
        Button1.Text = "x"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' CtlScan1
        ' 
        CtlScan1.BackColor = Color.FromArgb(CByte(54), CByte(63), CByte(90))
        CtlScan1.Location = New Point(0, 47)
        CtlScan1.Name = "CtlScan1"
        CtlScan1.Size = New Size(909, 649)
        CtlScan1.TabIndex = 6
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(28), CByte(114), CByte(157))
        Panel4.Controls.Add(btnSettings)
        Panel4.Controls.Add(btnManager)
        Panel4.Controls.Add(btnResults)
        Panel4.Controls.Add(btnPrivacy)
        Panel4.Controls.Add(btnProtection)
        Panel4.Controls.Add(btnHome)
        Panel4.Dock = DockStyle.Left
        Panel4.Location = New Point(0, 47)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(85, 648)
        Panel4.TabIndex = 3
        ' 
        ' btnSettings
        ' 
        btnSettings.BackColor = Color.FromArgb(CByte(102), CByte(50), CByte(173))
        btnSettings.FlatStyle = FlatStyle.Popup
        btnSettings.Font = New Font("Segoe UI", 8.0F)
        btnSettings.ForeColor = Color.White
        btnSettings.Location = New Point(-6, 609)
        btnSettings.Name = "btnSettings"
        btnSettings.Size = New Size(89, 39)
        btnSettings.TabIndex = 6
        btnSettings.Text = "Settings"
        btnSettings.UseVisualStyleBackColor = False
        ' 
        ' btnManager
        ' 
        btnManager.FlatStyle = FlatStyle.Popup
        btnManager.Font = New Font("Segoe UI", 9.0F)
        btnManager.ForeColor = Color.White
        btnManager.Image = My.Resources.Resources._12623_49_onebit_icon
        btnManager.ImageAlign = ContentAlignment.TopCenter
        btnManager.Location = New Point(-5, 237)
        btnManager.Name = "btnManager"
        btnManager.Size = New Size(91, 83)
        btnManager.TabIndex = 10
        btnManager.Text = "Manager"
        btnManager.TextAlign = ContentAlignment.BottomCenter
        btnManager.UseVisualStyleBackColor = True
        ' 
        ' btnResults
        ' 
        btnResults.FlatStyle = FlatStyle.Popup
        btnResults.Font = New Font("Segoe UI", 9.0F)
        btnResults.ForeColor = Color.White
        btnResults.Image = My.Resources.Resources.icons8_search_50
        btnResults.ImageAlign = ContentAlignment.TopCenter
        btnResults.Location = New Point(-3, 319)
        btnResults.Name = "btnResults"
        btnResults.Size = New Size(88, 90)
        btnResults.TabIndex = 9
        btnResults.Text = "Results"
        btnResults.TextAlign = ContentAlignment.BottomCenter
        btnResults.UseVisualStyleBackColor = True
        ' 
        ' btnPrivacy
        ' 
        btnPrivacy.FlatStyle = FlatStyle.Popup
        btnPrivacy.Font = New Font("Segoe UI", 9.0F)
        btnPrivacy.ForeColor = Color.White
        btnPrivacy.Image = My.Resources.Resources._12608_active_check_checkmark_correct_done_icon
        btnPrivacy.ImageAlign = ContentAlignment.TopCenter
        btnPrivacy.Location = New Point(-5, 158)
        btnPrivacy.Name = "btnPrivacy"
        btnPrivacy.Size = New Size(91, 80)
        btnPrivacy.TabIndex = 8
        btnPrivacy.Text = "privacy"
        btnPrivacy.TextAlign = ContentAlignment.BottomCenter
        btnPrivacy.UseVisualStyleBackColor = True
        ' 
        ' btnProtection
        ' 
        btnProtection.FlatStyle = FlatStyle.Popup
        btnProtection.Font = New Font("Segoe UI", 9.0F)
        btnProtection.ForeColor = Color.White
        btnProtection.Image = My.Resources.Resources._12597_blue_lock_safe_secure_icon
        btnProtection.ImageAlign = ContentAlignment.TopCenter
        btnProtection.Location = New Point(-3, 80)
        btnProtection.Name = "btnProtection"
        btnProtection.Size = New Size(91, 79)
        btnProtection.TabIndex = 7
        btnProtection.Text = "Protection"
        btnProtection.TextAlign = ContentAlignment.BottomCenter
        btnProtection.UseVisualStyleBackColor = True
        ' 
        ' btnHome
        ' 
        btnHome.BackColor = Color.FromArgb(CByte(102), CByte(50), CByte(173))
        btnHome.FlatStyle = FlatStyle.Popup
        btnHome.Font = New Font("Segoe UI", 9.0F)
        btnHome.ForeColor = Color.White
        btnHome.Image = My.Resources.Resources._12599_antivirus_protection_shield_icon
        btnHome.ImageAlign = ContentAlignment.TopCenter
        btnHome.Location = New Point(0, 0)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(88, 81)
        btnHome.TabIndex = 6
        btnHome.Text = "Home"
        btnHome.TextAlign = ContentAlignment.BottomCenter
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' CtlHome1
        ' 
        CtlHome1.BackColor = Color.FromArgb(CByte(54), CByte(63), CByte(90))
        CtlHome1.ForeColor = Color.White
        CtlHome1.Location = New Point(87, 47)
        CtlHome1.Name = "CtlHome1"
        CtlHome1.Size = New Size(822, 648)
        CtlHome1.TabIndex = 4
        ' 
        ' CtlProtection1
        ' 
        CtlProtection1.BackColor = Color.FromArgb(CByte(54), CByte(63), CByte(90))
        CtlProtection1.Location = New Point(82, 48)
        CtlProtection1.Name = "CtlProtection1"
        CtlProtection1.Size = New Size(827, 644)
        CtlProtection1.TabIndex = 5
        ' 
        ' CtlScan2
        ' 
        CtlScan2.BackColor = Color.FromArgb(CByte(54), CByte(63), CByte(90))
        CtlScan2.Location = New Point(84, 47)
        CtlScan2.Name = "CtlScan2"
        CtlScan2.Size = New Size(825, 649)
        CtlScan2.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(54), CByte(63), CByte(90))
        ClientSize = New Size(909, 695)
        Controls.Add(CtlHome1)
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(CtlProtection1)
        Controls.Add(CtlScan2)
        Controls.Add(CtlScan1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Antivirus"
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnManager As Button
    Friend WithEvents btnResults As Button
    Friend WithEvents btnPrivacy As Button
    Friend WithEvents btnProtection As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnSettings As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CtlHome1 As ctlHome

    Private Sub CtlHome1_Load(sender As Object, e As EventArgs) Handles CtlHome1.Load

    End Sub

    Friend WithEvents CtlProtection1 As ctlProtection
    Friend WithEvents CtlScan1 As ctlScan
    Friend WithEvents CtlScan2 As ctlScan
End Class
