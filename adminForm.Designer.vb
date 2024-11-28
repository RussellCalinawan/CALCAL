<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminForm))
        Panel1 = New Panel()
        DataGridView1 = New DataGridView()
        picboxBack = New PictureBox()
        btnManage = New RoundedButton()
        btnCreate = New RoundedButton()
        Panel3 = New Panel()
        participantsDGV = New DataGridView()
        btnView = New RoundedButton()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(picboxBack, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(participantsDGV, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.PaleGreen
        Panel1.Controls.Add(DataGridView1)
        Panel1.Location = New Point(-1, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(828, 39)
        Panel1.TabIndex = 0
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(301, 38)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(240, 150)
        DataGridView1.TabIndex = 0
        ' 
        ' picboxBack
        ' 
        picboxBack.Image = My.Resources.Resources.backero__1__removebg_preview__2_
        picboxBack.Location = New Point(731, 389)
        picboxBack.Name = "picboxBack"
        picboxBack.Size = New Size(56, 35)
        picboxBack.SizeMode = PictureBoxSizeMode.StretchImage
        picboxBack.TabIndex = 9
        picboxBack.TabStop = False
        ' 
        ' btnManage
        ' 
        btnManage.BackColor = Color.PaleGreen
        btnManage.CornerRadius = 11
        btnManage.ForeColor = SystemColors.ActiveCaptionText
        btnManage.Location = New Point(53, 164)
        btnManage.Name = "btnManage"
        btnManage.Size = New Size(208, 41)
        btnManage.TabIndex = 5
        btnManage.Text = "MANAGE EVENTS"
        btnManage.UseVisualStyleBackColor = False
        ' 
        ' btnCreate
        ' 
        btnCreate.BackColor = Color.PaleGreen
        btnCreate.CornerRadius = 11
        btnCreate.Location = New Point(53, 249)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(208, 41)
        btnCreate.TabIndex = 6
        btnCreate.Text = "CREATE EVENT"
        btnCreate.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ControlLightLight
        Panel3.Controls.Add(picboxBack)
        Panel3.Controls.Add(participantsDGV)
        Panel3.Location = New Point(2, 38)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(822, 461)
        Panel3.TabIndex = 0
        ' 
        ' participantsDGV
        ' 
        participantsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        participantsDGV.Location = New Point(21, 32)
        participantsDGV.Name = "participantsDGV"
        participantsDGV.Size = New Size(594, 392)
        participantsDGV.TabIndex = 0
        ' 
        ' btnView
        ' 
        btnView.BackColor = Color.PaleGreen
        btnView.CornerRadius = 11
        btnView.Location = New Point(53, 338)
        btnView.Name = "btnView"
        btnView.Size = New Size(208, 41)
        btnView.TabIndex = 8
        btnView.Text = "VIEW PARTICIPANTS"
        btnView.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(300, 38)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(524, 461)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' AdminForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlText
        ClientSize = New Size(825, 500)
        Controls.Add(Panel3)
        Controls.Add(btnCreate)
        Controls.Add(btnManage)
        Controls.Add(Panel1)
        Controls.Add(btnView)
        Controls.Add(PictureBox1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "AdminForm"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "S"
        Panel1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(picboxBack, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        CType(participantsDGV, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnManage As RoundedButton
    Friend WithEvents btnCreate As RoundedButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents participantsDGV As DataGridView
    Friend WithEvents btnView As RoundedButton
    Friend WithEvents picboxBack As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
