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
        headerPANEL = New Panel()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        passwordPANEL = New Panel()
        txtinput = New TextBox()
        numpadFLP = New FlowLayoutPanel()
        btn7 = New Button()
        btn8 = New Button()
        btn9 = New Button()
        btn4 = New Button()
        btn5 = New Button()
        btn6 = New Button()
        btn1 = New Button()
        btn2 = New Button()
        btn3 = New Button()
        btn0 = New Button()
        btnClr = New Button()
        btnDel = New Button()
        nextBTN = New PictureBox()
        headerPANEL.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        passwordPANEL.SuspendLayout()
        numpadFLP.SuspendLayout()
        CType(nextBTN, ComponentModel.ISupportInitialize).BeginInit()
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
        Label1.Location = New Point(38, 85)
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
        btnUser.Location = New Point(272, 203)
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
        btnAdmin.Location = New Point(272, 352)
        btnAdmin.Name = "btnAdmin"
        btnAdmin.Size = New Size(239, 42)
        btnAdmin.TabIndex = 3
        btnAdmin.Text = "ADMIN"
        btnAdmin.UseVisualStyleBackColor = False
        ' 
        ' headerPANEL
        ' 
        headerPANEL.BackColor = SystemColors.ControlText
        headerPANEL.Controls.Add(Panel2)
        headerPANEL.Location = New Point(-3, 0)
        headerPANEL.Name = "headerPANEL"
        headerPANEL.Size = New Size(828, 39)
        headerPANEL.TabIndex = 4
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
        PictureBox1.Location = New Point(277, 208)
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
        PictureBox2.Location = New Point(277, 358)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(39, 33)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' passwordPANEL
        ' 
        passwordPANEL.Controls.Add(nextBTN)
        passwordPANEL.Controls.Add(txtinput)
        passwordPANEL.Controls.Add(numpadFLP)
        passwordPANEL.Location = New Point(-3, 37)
        passwordPANEL.Name = "passwordPANEL"
        passwordPANEL.Size = New Size(760, 463)
        passwordPANEL.TabIndex = 7
        ' 
        ' txtinput
        ' 
        txtinput.Location = New Point(285, 112)
        txtinput.Name = "txtinput"
        txtinput.Size = New Size(222, 23)
        txtinput.TabIndex = 1
        ' 
        ' numpadFLP
        ' 
        numpadFLP.BackColor = Color.White
        numpadFLP.Controls.Add(btn7)
        numpadFLP.Controls.Add(btn8)
        numpadFLP.Controls.Add(btn9)
        numpadFLP.Controls.Add(btn4)
        numpadFLP.Controls.Add(btn5)
        numpadFLP.Controls.Add(btn6)
        numpadFLP.Controls.Add(btn1)
        numpadFLP.Controls.Add(btn2)
        numpadFLP.Controls.Add(btn3)
        numpadFLP.Controls.Add(btn0)
        numpadFLP.Controls.Add(btnClr)
        numpadFLP.Controls.Add(btnDel)
        numpadFLP.Location = New Point(285, 166)
        numpadFLP.Name = "numpadFLP"
        numpadFLP.Size = New Size(222, 237)
        numpadFLP.TabIndex = 0
        ' 
        ' btn7
        ' 
        btn7.Location = New Point(3, 3)
        btn7.Name = "btn7"
        btn7.Size = New Size(68, 53)
        btn7.TabIndex = 0
        btn7.Text = "7"
        btn7.UseVisualStyleBackColor = True
        ' 
        ' btn8
        ' 
        btn8.Location = New Point(77, 3)
        btn8.Name = "btn8"
        btn8.Size = New Size(68, 53)
        btn8.TabIndex = 1
        btn8.Text = "8"
        btn8.UseVisualStyleBackColor = True
        ' 
        ' btn9
        ' 
        btn9.Location = New Point(151, 3)
        btn9.Name = "btn9"
        btn9.Size = New Size(68, 53)
        btn9.TabIndex = 2
        btn9.Text = "9"
        btn9.UseVisualStyleBackColor = True
        ' 
        ' btn4
        ' 
        btn4.Location = New Point(3, 62)
        btn4.Name = "btn4"
        btn4.Size = New Size(68, 53)
        btn4.TabIndex = 3
        btn4.Text = "4"
        btn4.UseVisualStyleBackColor = True
        ' 
        ' btn5
        ' 
        btn5.Location = New Point(77, 62)
        btn5.Name = "btn5"
        btn5.Size = New Size(68, 53)
        btn5.TabIndex = 4
        btn5.Text = "5"
        btn5.UseVisualStyleBackColor = True
        ' 
        ' btn6
        ' 
        btn6.Location = New Point(151, 62)
        btn6.Name = "btn6"
        btn6.Size = New Size(68, 53)
        btn6.TabIndex = 5
        btn6.Text = "6"
        btn6.UseVisualStyleBackColor = True
        ' 
        ' btn1
        ' 
        btn1.Location = New Point(3, 121)
        btn1.Name = "btn1"
        btn1.Size = New Size(68, 53)
        btn1.TabIndex = 6
        btn1.Text = "1"
        btn1.UseVisualStyleBackColor = True
        ' 
        ' btn2
        ' 
        btn2.Location = New Point(77, 121)
        btn2.Name = "btn2"
        btn2.Size = New Size(68, 53)
        btn2.TabIndex = 7
        btn2.Text = "2"
        btn2.UseVisualStyleBackColor = True
        ' 
        ' btn3
        ' 
        btn3.Location = New Point(151, 121)
        btn3.Name = "btn3"
        btn3.Size = New Size(68, 53)
        btn3.TabIndex = 8
        btn3.Text = "3"
        btn3.UseVisualStyleBackColor = True
        ' 
        ' btn0
        ' 
        btn0.Location = New Point(3, 180)
        btn0.Name = "btn0"
        btn0.Size = New Size(68, 53)
        btn0.TabIndex = 9
        btn0.Text = "0"
        btn0.UseVisualStyleBackColor = True
        ' 
        ' btnClr
        ' 
        btnClr.Location = New Point(77, 180)
        btnClr.Name = "btnClr"
        btnClr.Size = New Size(68, 53)
        btnClr.TabIndex = 10
        btnClr.Text = "Clear"
        btnClr.UseVisualStyleBackColor = True
        ' 
        ' btnDel
        ' 
        btnDel.Location = New Point(151, 180)
        btnDel.Name = "btnDel"
        btnDel.Size = New Size(68, 53)
        btnDel.TabIndex = 11
        btnDel.Text = "Delete"
        btnDel.UseVisualStyleBackColor = True
        ' 
        ' nextBTN
        ' 
        nextBTN.Image = CType(resources.GetObject("nextBTN.Image"), Image)
        nextBTN.Location = New Point(475, 112)
        nextBTN.Name = "nextBTN"
        nextBTN.Size = New Size(33, 23)
        nextBTN.SizeMode = PictureBoxSizeMode.StretchImage
        nextBTN.TabIndex = 2
        nextBTN.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(825, 500)
        Controls.Add(passwordPANEL)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox2)
        Controls.Add(headerPANEL)
        Controls.Add(panelSide)
        Controls.Add(btnAdmin)
        Controls.Add(Label1)
        Controls.Add(btnUser)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        ImeMode = ImeMode.On
        Name = "Form1"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "`"
        headerPANEL.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        passwordPANEL.ResumeLayout(False)
        passwordPANEL.PerformLayout()
        numpadFLP.ResumeLayout(False)
        CType(nextBTN, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents panelSide As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUser As RoundedButton
    Friend WithEvents btnAdmin As RoundedButton
    Friend WithEvents headerPANEL As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents passwordPANEL As Panel
    Friend WithEvents txtinput As TextBox
    Friend WithEvents numpadFLP As FlowLayoutPanel
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btnClr As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents nextBTN As PictureBox


End Class
