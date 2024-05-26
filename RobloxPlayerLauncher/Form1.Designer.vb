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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Timer1 = New Timer(components)
        PictureBox1 = New PictureBox()
        ProgressBar1 = New ProgressBar()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Timer2 = New Timer(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Timer1
        ' 
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Color_Roblox_Logo_500x373
        PictureBox1.Location = New Point(273, 39)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(234, 184)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(12, 344)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(776, 33)
        ProgressBar1.Style = ProgressBarStyle.Marquee
        ProgressBar1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(248, 238)
        Label1.Name = "Label1"
        Label1.Size = New Size(298, 46)
        Label1.TabIndex = 2
        Label1.Text = "Preparing Roblox..."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(294, 296)
        Label2.Name = "Label2"
        Label2.Size = New Size(189, 15)
        Label2.TabIndex = 3
        Label2.Text = "Please wait until we launch roblox!"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(315, 344)
        Button1.Name = "Button1"
        Button1.Size = New Size(155, 47)
        Button1.TabIndex = 4
        Button1.Text = "Run Roblox!"
        Button1.UseVisualStyleBackColor = False
        Button1.Visible = False
        ' 
        ' Timer2
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 434)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ProgressBar1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RobloxPlayerLauncher"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer2 As Timer

End Class
