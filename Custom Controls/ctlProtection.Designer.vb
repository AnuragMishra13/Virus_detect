<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlProtection
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
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Panel1 = New Panel()
        PictureBox4 = New PictureBox()
        Label6 = New Label()
        Panel2 = New Panel()
        PictureBox3 = New PictureBox()
        Label7 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.icons8_error_48
        PictureBox1.Location = New Point(357, 78)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(133, 94)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources._17529_finger_hand_point_reminder_icon
        PictureBox2.Location = New Point(186, 22)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(32, 50)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(54), CByte(63), CByte(90))
        Label1.FlatStyle = FlatStyle.Popup
        Label1.Font = New Font("Segoe UI", 22F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(27, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(152, 50)
        Label1.TabIndex = 7
        Label1.Text = "FireWall"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(54), CByte(63), CByte(90))
        Label2.FlatStyle = FlatStyle.Popup
        Label2.Font = New Font("Segoe UI", 22F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(367, 245)
        Label2.Name = "Label2"
        Label2.Size = New Size(382, 50)
        Label2.TabIndex = 9
        Label2.Text = "is NOT protecting you"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(54), CByte(63), CByte(90))
        Label3.FlatStyle = FlatStyle.Popup
        Label3.Font = New Font("Segoe UI", 22F)
        Label3.ForeColor = Color.Orange
        Label3.Location = New Point(126, 245)
        Label3.Name = "Label3"
        Label3.Size = New Size(245, 50)
        Label3.TabIndex = 10
        Label3.Text = "Free Antivirus"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(54), CByte(63), CByte(90))
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(37, 337)
        Label4.Name = "Label4"
        Label4.Size = New Size(309, 28)
        Label4.TabIndex = 11
        Label4.Text = "Domain Network (Recommended)"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(54), CByte(63), CByte(90))
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(471, 337)
        Label5.Name = "Label5"
        Label5.Size = New Size(300, 28)
        Label5.TabIndex = 12
        Label5.Text = "Private Network (Recommended)"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(Label6)
        Panel1.Location = New Point(27, 368)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(344, 84)
        Panel1.TabIndex = 13
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.icons8_toggle_off_48
        PictureBox4.Location = New Point(216, 16)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(118, 56)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 15
        PictureBox4.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.White
        Label6.Font = New Font("Segoe UI", 12F)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(25, 28)
        Label6.Name = "Label6"
        Label6.Size = New Size(166, 28)
        Label6.TabIndex = 13
        Label6.Text = "Domain Network "
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(PictureBox3)
        Panel2.Controls.Add(Label7)
        Panel2.Location = New Point(453, 368)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(335, 84)
        Panel2.TabIndex = 15
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.icons8_toggle_off_48
        PictureBox3.Location = New Point(200, 16)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(118, 56)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 16
        PictureBox3.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.White
        Label7.Font = New Font("Segoe UI", 12F)
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(27, 28)
        Label7.Name = "Label7"
        Label7.Size = New Size(157, 28)
        Label7.TabIndex = 13
        Label7.Text = "Private Network "
        ' 
        ' ctlProtection
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(54), CByte(63), CByte(90))
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(PictureBox2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "ctlProtection"
        Size = New Size(848, 566)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox3 As PictureBox

End Class
