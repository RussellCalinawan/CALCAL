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
        textboxEmail = New lineTextBox()
        lblUsername = New Label()
        Label1 = New Label()
        textboxConfirm = New lineTextBox()
        btnEnterer = New RoundedButton()
        piceyeClosed = New PictureBox()
        piceyeOpen = New PictureBox()
        panelSign = New Panel()
        textboxConfirmeh = New lineTextBox()
        textboxCreate = New lineTextBox()
        textboxeehmail = New lineTextBox()
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
        ' textboxEmail
        ' 
        textboxEmail.BackColor = Color.PaleGreen
        textboxEmail.BorderStyle = BorderStyle.None
        textboxEmail.Location = New Point(224, 231)
        textboxEmail.Name = "textboxEmail"
        textboxEmail.Size = New Size(413, 16)
        textboxEmail.TabIndex = 4
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
        ' textboxConfirm
        ' 
        textboxConfirm.BackColor = Color.PaleGreen
        textboxConfirm.BorderStyle = BorderStyle.None
        textboxConfirm.Location = New Point(224, 301)
        textboxConfirm.Name = "textboxConfirm"
        textboxConfirm.Size = New Size(413, 16)
        textboxConfirm.TabIndex = 7
        ' 
        ' btnEnterer
        ' 
        btnEnterer.BackColor = Color.Black
        btnEnterer.CornerRadius = 11
        btnEnterer.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEnterer.ForeColor = SystemColors.ButtonHighlight
        btnEnterer.Location = New Point(299, 438)
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
        panelSign.Controls.Add(textboxConfirmeh)
        panelSign.Controls.Add(textboxCreate)
        panelSign.Controls.Add(textboxeehmail)
        panelSign.Controls.Add(textboxName)
        panelSign.Location = New Point(0, 189)
        panelSign.Name = "panelSign"
        panelSign.Size = New Size(825, 223)
        panelSign.TabIndex = 11
        ' 
        ' textboxConfirmeh
        ' 
        textboxConfirmeh.BackColor = Color.PaleGreen
        textboxConfirmeh.BorderStyle = BorderStyle.None
        textboxConfirmeh.ForeColor = SystemColors.MenuText
        textboxConfirmeh.Location = New Point(145, 190)
        textboxConfirmeh.Name = "textboxConfirmeh"
        textboxConfirmeh.PlaceholderText = "Confirm your password"
        textboxConfirmeh.Size = New Size(469, 16)
        textboxConfirmeh.TabIndex = 4
        textboxConfirmeh.UseSystemPasswordChar = True
        ' 
        ' textboxCreate
        ' 
        textboxCreate.BackColor = Color.PaleGreen
        textboxCreate.BorderStyle = BorderStyle.None
        textboxCreate.ForeColor = SystemColors.MenuText
        textboxCreate.Location = New Point(145, 132)
        textboxCreate.Name = "textboxCreate"
        textboxCreate.PlaceholderText = "Create a password"
        textboxCreate.Size = New Size(469, 16)
        textboxCreate.TabIndex = 3
        textboxCreate.UseSystemPasswordChar = True
        ' 
        ' textboxeehmail
        ' 
        textboxeehmail.BackColor = Color.PaleGreen
        textboxeehmail.BorderStyle = BorderStyle.None
        textboxeehmail.ForeColor = SystemColors.InfoText
        textboxeehmail.Location = New Point(145, 77)
        textboxeehmail.Name = "textboxeehmail"
        textboxeehmail.PlaceholderText = "Enter your Email"
        textboxeehmail.Size = New Size(469, 16)
        textboxeehmail.TabIndex = 2
        ' 
        ' textboxName
        ' 
        textboxName.BackColor = Color.PaleGreen
        textboxName.BorderStyle = BorderStyle.None
        textboxName.ForeColor = SystemColors.MenuText
        textboxName.Location = New Point(145, 20)
        textboxName.Name = "textboxName"
        textboxName.PlaceholderText = "Enter your name"
        textboxName.Size = New Size(469, 16)
        textboxName.TabIndex = 0
        ' 
        ' btnSigner
        ' 
        btnSigner.BackColor = Color.Black
        btnSigner.CornerRadius = 11
        btnSigner.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSigner.ForeColor = SystemColors.ButtonHighlight
        btnSigner.Location = New Point(299, 438)
        btnSigner.Name = "btnSigner"
        btnSigner.Size = New Size(198, 38)
        btnSigner.TabIndex = 12
        btnSigner.Text = "SIGN UP"
        btnSigner.UseVisualStyleBackColor = False
        ' 
        ' loginform
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PaleGreen
        ClientSize = New Size(825, 500)
        Controls.Add(panelSign)
        Controls.Add(piceyeOpen)
        Controls.Add(piceyeClosed)
        Controls.Add(textboxConfirm)
        Controls.Add(Label1)
        Controls.Add(lblUsername)
        Controls.Add(textboxEmail)
        Controls.Add(btnLogin1)
        Controls.Add(Line1)
        Controls.Add(btnSign1)
        Controls.Add(Panel1)
        Controls.Add(btnSigner)
        Controls.Add(btnEnterer)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "loginform"
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
    Friend WithEvents textboxEmail As lineTextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents textboxConfirm As lineTextBox
    Friend WithEvents btnEnterer As RoundedButton
    Friend WithEvents piceyeClosed As PictureBox
    Friend WithEvents piceyeOpen As PictureBox
    Friend WithEvents panelSign As Panel
    Friend WithEvents textboxConfirmeh As lineTextBox
    Friend WithEvents textboxCreate As lineTextBox
    Friend WithEvents textboxeehmail As lineTextBox
    Friend WithEvents textboxName As lineTextBox
    Friend WithEvents btnSigner As RoundedButton
End Class
