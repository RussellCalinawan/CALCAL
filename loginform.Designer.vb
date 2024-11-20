<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginform))
        Panel1 = New Panel()
        btnSign1 = New Button()
        Line1 = New line()
        btnLogin1 = New Button()
        LineTextBox1 = New lineTextBox()
        lblUsername = New Label()
        Label1 = New Label()
        textPass = New lineTextBox()
        btnEnterer = New RoundedButton()
        piceyeClosed = New PictureBox()
        piceyeOpen = New PictureBox()
        panelSign = New Panel()
        textboxConfirm = New lineTextBox()
        textboxCreate = New lineTextBox()
        textboxEmail = New lineTextBox()
        textboxName = New lineTextBox()
        btnSigner = New RoundedButton()
        CType(piceyeClosed, ComponentModel.ISupportInitialize).BeginInit()
        CType(piceyeOpen, ComponentModel.ISupportInitialize).BeginInit()
        panelSign.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlText
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(825, 39)
        Panel1.TabIndex = 0
        ' 
        ' btnSign1
        ' 
        btnSign1.BackColor = Color.PaleGreen
        btnSign1.FlatStyle = FlatStyle.Flat
        btnSign1.Location = New Point(101, 78)
        btnSign1.Name = "btnSign1"
        btnSign1.Size = New Size(146, 44)
        btnSign1.TabIndex = 1
        btnSign1.Text = "SIGN UP "
        btnSign1.UseVisualStyleBackColor = False
        ' 
        ' Line1
        ' 
        Line1.BackColor = Color.PaleGreen
        Line1.Location = New Point(369, 66)
        Line1.Name = "Line1"
        Line1.Size = New Size(50, 103)
        Line1.TabIndex = 2
        Line1.Text = "Line1"
        ' 
        ' btnLogin1
        ' 
        btnLogin1.BackColor = Color.PaleGreen
        btnLogin1.FlatStyle = FlatStyle.Flat
        btnLogin1.Location = New Point(544, 78)
        btnLogin1.Name = "btnLogin1"
        btnLogin1.Size = New Size(146, 44)
        btnLogin1.TabIndex = 3
        btnLogin1.Text = "LOG IN "
        btnLogin1.UseVisualStyleBackColor = False
        ' 
        ' LineTextBox1
        ' 
        LineTextBox1.BackColor = Color.PaleGreen
        LineTextBox1.BorderStyle = BorderStyle.None
        LineTextBox1.Location = New Point(224, 231)
        LineTextBox1.Name = "LineTextBox1"
        LineTextBox1.Size = New Size(413, 16)
        LineTextBox1.TabIndex = 4
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.ForeColor = SystemColors.Desktop
        lblUsername.Location = New Point(125, 232)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(74, 15)
        lblUsername.TabIndex = 5
        lblUsername.Text = "USERNAME :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.Desktop
        Label1.Location = New Point(125, 302)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 15)
        Label1.TabIndex = 6
        Label1.Text = "PASSWORD :"
        ' 
        ' textPass
        ' 
        textPass.BackColor = Color.PaleGreen
        textPass.BorderStyle = BorderStyle.None
        textPass.Location = New Point(224, 301)
        textPass.Name = "textPass"
        textPass.Size = New Size(413, 16)
        textPass.TabIndex = 7
        ' 
        ' btnEnterer
        ' 
        btnEnterer.BackColor = Color.Black
        btnEnterer.CornerRadius = 11
        btnEnterer.ForeColor = SystemColors.ButtonHighlight
        btnEnterer.Location = New Point(308, 438)
        btnEnterer.Name = "btnEnterer"
        btnEnterer.Size = New Size(198, 38)
        btnEnterer.TabIndex = 8
        btnEnterer.Text = "LOG IN "
        btnEnterer.UseVisualStyleBackColor = False
        ' 
        ' piceyeClosed
        ' 
        piceyeClosed.Image = CType(resources.GetObject("piceyeClosed.Image"), Image)
        piceyeClosed.Location = New Point(604, 286)
        piceyeClosed.Name = "piceyeClosed"
        piceyeClosed.Size = New Size(33, 27)
        piceyeClosed.SizeMode = PictureBoxSizeMode.StretchImage
        piceyeClosed.TabIndex = 9
        piceyeClosed.TabStop = False
        ' 
        ' piceyeOpen
        ' 
        piceyeOpen.Image = CType(resources.GetObject("piceyeOpen.Image"), Image)
        piceyeOpen.Location = New Point(604, 286)
        piceyeOpen.Name = "piceyeOpen"
        piceyeOpen.Size = New Size(33, 27)
        piceyeOpen.SizeMode = PictureBoxSizeMode.StretchImage
        piceyeOpen.TabIndex = 10
        piceyeOpen.TabStop = False
        ' 
        ' panelSign
        ' 
        panelSign.Controls.Add(textboxConfirm)
        panelSign.Controls.Add(textboxCreate)
        panelSign.Controls.Add(textboxEmail)
        panelSign.Controls.Add(textboxName)
        panelSign.Location = New Point(0, 175)
        panelSign.Name = "panelSign"
        panelSign.Size = New Size(825, 237)
        panelSign.TabIndex = 11
        ' 
        ' textboxConfirm
        ' 
        textboxConfirm.BackColor = Color.PaleGreen
        textboxConfirm.BorderStyle = BorderStyle.None
        textboxConfirm.ForeColor = SystemColors.WindowFrame
        textboxConfirm.Location = New Point(145, 190)
        textboxConfirm.Name = "textboxConfirm"
        textboxConfirm.Size = New Size(469, 16)
        textboxConfirm.TabIndex = 4
        textboxConfirm.Text = "Confirm your password"
        ' 
        ' textboxCreate
        ' 
        textboxCreate.BackColor = Color.PaleGreen
        textboxCreate.BorderStyle = BorderStyle.None
        textboxCreate.ForeColor = SystemColors.WindowFrame
        textboxCreate.Location = New Point(145, 132)
        textboxCreate.Name = "textboxCreate"
        textboxCreate.Size = New Size(469, 16)
        textboxCreate.TabIndex = 3
        textboxCreate.Text = "Create a password"
        ' 
        ' textboxEmail
        ' 
        textboxEmail.BackColor = Color.PaleGreen
        textboxEmail.BorderStyle = BorderStyle.None
        textboxEmail.ForeColor = SystemColors.WindowFrame
        textboxEmail.Location = New Point(145, 77)
        textboxEmail.Name = "textboxEmail"
        textboxEmail.Size = New Size(469, 16)
        textboxEmail.TabIndex = 2
        textboxEmail.Text = "Enter your email "
        ' 
        ' textboxName
        ' 
        textboxName.BackColor = Color.PaleGreen
        textboxName.BorderStyle = BorderStyle.None
        textboxName.ForeColor = SystemColors.WindowFrame
        textboxName.Location = New Point(145, 20)
        textboxName.Name = "textboxName"
        textboxName.Size = New Size(469, 16)
        textboxName.TabIndex = 0
        textboxName.Text = "Enter your name"
        ' 
        ' btnSigner
        ' 
        btnSigner.BackColor = Color.Black
        btnSigner.CornerRadius = 11
        btnSigner.ForeColor = SystemColors.ButtonHighlight
        btnSigner.Location = New Point(308, 438)
        btnSigner.Name = "btnSigner"
        btnSigner.Size = New Size(198, 38)
        btnSigner.TabIndex = 12
        btnSigner.Text = "SIGN UP"
        btnSigner.UseVisualStyleBackColor = False
        ' 
        ' useForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PaleGreen
        ClientSize = New Size(825, 500)
        Controls.Add(panelSign)
        Controls.Add(piceyeOpen)
        Controls.Add(piceyeClosed)
        Controls.Add(textPass)
        Controls.Add(Label1)
        Controls.Add(lblUsername)
        Controls.Add(LineTextBox1)
        Controls.Add(btnLogin1)
        Controls.Add(Line1)
        Controls.Add(btnSign1)
        Controls.Add(Panel1)
        Controls.Add(btnSigner)
        Controls.Add(btnEnterer)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "useForm"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        CType(piceyeClosed, ComponentModel.ISupportInitialize).EndInit()
        CType(piceyeOpen, ComponentModel.ISupportInitialize).EndInit()
        panelSign.ResumeLayout(False)
        panelSign.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSign1 As Button
    Friend WithEvents Line1 As line
    Friend WithEvents btnLogin1 As Button
    Friend WithEvents LineTextBox1 As lineTextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents textPass As lineTextBox
    Friend WithEvents btnEnterer As RoundedButton
    Friend WithEvents piceyeClosed As PictureBox
    Friend WithEvents piceyeOpen As PictureBox
    Friend WithEvents panelSign As Panel
    Friend WithEvents textboxConfirm As lineTextBox
    Friend WithEvents textboxCreate As lineTextBox
    Friend WithEvents textboxEmail As lineTextBox
    Friend WithEvents textboxName As lineTextBox
    Friend WithEvents btnSigner As RoundedButton
End Class
