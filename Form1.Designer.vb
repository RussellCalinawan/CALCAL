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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        panelSide = New Panel()
        Label1 = New Label()
        btnUser = New RoundedButton()
        btnAdmin = New RoundedButton()
        Panel1 = New Panel()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panelSide
        ' 
        panelSide.BackColor = Color.PaleGreen
        panelSide.BorderStyle = BorderStyle.FixedSingle
        panelSide.Dock = DockStyle.Right
        panelSide.Location = New Point(757, 0)
        panelSide.Name = "panelSide"
        panelSide.Size = New Size(68, 500)
        panelSide.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.PaleGreen
        Label1.Location = New Point(36, 92)
        Label1.Name = "Label1"
        Label1.Size = New Size(325, 28)
        Label1.TabIndex = 1
        Label1.Text = "CALCAL EVENTS MANAGER"
        ' 
        ' btnUser
        ' 
        btnUser.BackColor = Color.PaleGreen
        btnUser.CornerRadius = 11
        btnUser.Font = New Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnUser.Location = New Point(273, 204)
        btnUser.Name = "btnUser"
        btnUser.Size = New Size(239, 42)
        btnUser.TabIndex = 2
        btnUser.Text = "USER"
        btnUser.UseVisualStyleBackColor = False
        ' 
        ' btnAdmin
        ' 
        btnAdmin.BackColor = Color.PaleGreen
        btnAdmin.CornerRadius = 11
        btnAdmin.Font = New Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAdmin.Location = New Point(273, 346)
        btnAdmin.Name = "btnAdmin"
        btnAdmin.Size = New Size(239, 42)
        btnAdmin.TabIndex = 3
        btnAdmin.Text = "ADMIN"
        btnAdmin.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlText
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(-3, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(828, 39)
        Panel1.TabIndex = 4
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.Location = New Point(3, 42)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(755, 458)
        Panel2.TabIndex = 5
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.PaleGreen
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(279, 209)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(39, 33)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.PaleGreen
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(280, 352)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(39, 33)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' mainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(825, 500)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox2)
        Controls.Add(Panel1)
        Controls.Add(panelSide)
        Controls.Add(btnAdmin)
        Controls.Add(Label1)
        Controls.Add(btnUser)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        ImeMode = ImeMode.On
        Name = "mainForm"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "`"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents panelSide As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUser As RoundedButton
    Friend WithEvents btnAdmin As RoundedButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox


End Class
