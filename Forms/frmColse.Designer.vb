<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmColse
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Panel1 = New Panel()
        Button1 = New Button()
        Button5 = New Button()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(480, 233)
        Panel1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Green
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(255, 149)
        Button1.Name = "Button1"
        Button1.Size = New Size(145, 42)
        Button1.TabIndex = 19
        Button1.Text = "YES"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Red
        Button5.FlatStyle = FlatStyle.Popup
        Button5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button5.ForeColor = Color.White
        Button5.Location = New Point(55, 149)
        Button5.Name = "Button5"
        Button5.Size = New Size(145, 42)
        Button5.TabIndex = 18
        Button5.Text = "NO"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.icons8_error_48
        PictureBox1.Location = New Point(151, 34)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(133, 94)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' frmColse
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(54), CByte(63), CByte(90))
        ClientSize = New Size(480, 233)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmColse"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmColse"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button5 As Button
End Class
