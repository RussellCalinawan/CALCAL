<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class browseForm
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
        picboxBack = New PictureBox()
        DataGridView1 = New DataGridView()
        dataPANEL = New Panel()
        registrationPANEL = New Panel()
        registerButton = New RoundedButton()
        Label4 = New Label()
        eventnameCMB = New ComboBox()
        contactTextBox = New lineTextBox()
        userEmailTextBox = New lineTextBox()
        userNameTextBox = New lineTextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        eventsDGV = New DataGridView()
        Panel1.SuspendLayout()
        CType(picboxBack, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        dataPANEL.SuspendLayout()
        registrationPANEL.SuspendLayout()
        CType(eventsDGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.PaleGreen
        Panel1.Controls.Add(picboxBack)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Location = New Point(-2, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(828, 39)
        Panel1.TabIndex = 1
        ' 
        ' picboxBack
        ' 
        picboxBack.Image = My.Resources.Resources.backero__1__removebg_preview__2_
        picboxBack.Location = New Point(3, 1)
        picboxBack.Name = "picboxBack"
        picboxBack.Size = New Size(56, 35)
        picboxBack.SizeMode = PictureBoxSizeMode.StretchImage
        picboxBack.TabIndex = 8
        picboxBack.TabStop = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(301, 38)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(240, 150)
        DataGridView1.TabIndex = 0
        ' 
        ' dataPANEL
        ' 
        dataPANEL.BackColor = SystemColors.ActiveCaptionText
        dataPANEL.Controls.Add(registrationPANEL)
        dataPANEL.Controls.Add(eventsDGV)
        dataPANEL.Location = New Point(-2, 38)
        dataPANEL.Name = "dataPANEL"
        dataPANEL.Size = New Size(828, 465)
        dataPANEL.TabIndex = 2
        ' 
        ' registrationPANEL
        ' 
        registrationPANEL.BackColor = SystemColors.ControlLightLight
        registrationPANEL.Controls.Add(registerButton)
        registrationPANEL.Controls.Add(Label4)
        registrationPANEL.Controls.Add(eventnameCMB)
        registrationPANEL.Controls.Add(contactTextBox)
        registrationPANEL.Controls.Add(userEmailTextBox)
        registrationPANEL.Controls.Add(userNameTextBox)
        registrationPANEL.Controls.Add(Label3)
        registrationPANEL.Controls.Add(Label2)
        registrationPANEL.Controls.Add(Label1)
        registrationPANEL.Location = New Point(201, 41)
        registrationPANEL.Name = "registrationPANEL"
        registrationPANEL.Size = New Size(409, 371)
        registrationPANEL.TabIndex = 1
        ' 
        ' registerButton
        ' 
        registerButton.BackColor = SystemColors.ActiveCaptionText
        registerButton.CornerRadius = 11
        registerButton.ForeColor = SystemColors.ControlLightLight
        registerButton.Location = New Point(134, 286)
        registerButton.Name = "registerButton"
        registerButton.Size = New Size(130, 29)
        registerButton.TabIndex = 8
        registerButton.Text = "REGISTER"
        registerButton.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(60, 89)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 15)
        Label4.TabIndex = 7
        Label4.Text = "EVENT NAME : "
        ' 
        ' eventnameCMB
        ' 
        eventnameCMB.FormattingEnabled = True
        eventnameCMB.Location = New Point(60, 107)
        eventnameCMB.Name = "eventnameCMB"
        eventnameCMB.Size = New Size(280, 23)
        eventnameCMB.TabIndex = 6
        ' 
        ' contactTextBox
        ' 
        contactTextBox.BackColor = Color.White
        contactTextBox.BorderStyle = BorderStyle.None
        contactTextBox.Location = New Point(144, 209)
        contactTextBox.Name = "contactTextBox"
        contactTextBox.Size = New Size(196, 16)
        contactTextBox.TabIndex = 5
        ' 
        ' userEmailTextBox
        ' 
        userEmailTextBox.BackColor = Color.White
        userEmailTextBox.BorderStyle = BorderStyle.None
        userEmailTextBox.Location = New Point(124, 178)
        userEmailTextBox.Name = "userEmailTextBox"
        userEmailTextBox.Size = New Size(216, 16)
        userEmailTextBox.TabIndex = 4
        ' 
        ' userNameTextBox
        ' 
        userNameTextBox.BackColor = Color.White
        userNameTextBox.BorderStyle = BorderStyle.None
        userNameTextBox.Location = New Point(124, 146)
        userNameTextBox.Name = "userNameTextBox"
        userNameTextBox.Size = New Size(216, 16)
        userNameTextBox.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(60, 210)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 15)
        Label3.TabIndex = 2
        Label3.Text = "CONTACT # :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(60, 178)
        Label2.Name = "Label2"
        Label2.Size = New Size(47, 15)
        Label2.TabIndex = 1
        Label2.Text = "EMAIL :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(60, 147)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 15)
        Label1.TabIndex = 0
        Label1.Text = "NAME :"
        ' 
        ' eventsDGV
        ' 
        eventsDGV.BackgroundColor = SystemColors.ActiveCaptionText
        eventsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        eventsDGV.Location = New Point(3, 0)
        eventsDGV.Name = "eventsDGV"
        eventsDGV.Size = New Size(822, 450)
        eventsDGV.TabIndex = 0
        ' 
        ' browseForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(825, 500)
        Controls.Add(dataPANEL)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "browseForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "browseForm"
        Panel1.ResumeLayout(False)
        CType(picboxBack, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        dataPANEL.ResumeLayout(False)
        registrationPANEL.ResumeLayout(False)
        registrationPANEL.PerformLayout()
        CType(eventsDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents dataPANEL As Panel
    Friend WithEvents eventsDGV As DataGridView
    Friend WithEvents registrationPANEL As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents userNameTextBox As lineTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents contactTextBox As lineTextBox
    Friend WithEvents userEmailTextBox As lineTextBox
    Friend WithEvents registerButton As RoundedButton
    Friend WithEvents Label4 As Label
    Friend WithEvents eventnameCMB As ComboBox
    Friend WithEvents picboxBack As PictureBox
End Class
