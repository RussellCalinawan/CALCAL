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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminForm))
        Panel1 = New Panel()
        btnManage = New RoundedButton()
        btnCreate = New RoundedButton()
        Panel2 = New Panel()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        MonthCalendar1 = New MonthCalendar()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Panel2.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.PaleGreen
        Panel1.Location = New Point(-1, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(828, 39)
        Panel1.TabIndex = 0
        ' 
        ' btnManage
        ' 
        btnManage.BackColor = Color.PaleGreen
        btnManage.CornerRadius = 11
        btnManage.ForeColor = SystemColors.ActiveCaptionText
        btnManage.Location = New Point(44, 177)
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
        btnCreate.Location = New Point(44, 310)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(208, 41)
        btnCreate.TabIndex = 6
        btnCreate.Text = "CREATE EVENT"
        btnCreate.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlLightLight
        Panel2.Controls.Add(FlowLayoutPanel1)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(MonthCalendar1)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(300, 38)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(525, 460)
        Panel2.TabIndex = 7
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(Label2)
        FlowLayoutPanel1.Controls.Add(Label3)
        FlowLayoutPanel1.Controls.Add(Label4)
        FlowLayoutPanel1.Location = New Point(382, 314)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(120, 63)
        FlowLayoutPanel1.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 16)
        Label2.TabIndex = 6
        Label2.Text = "ADMIN: SCOFIELD"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(249, 292)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(116, 99)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-16, 42)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(541, 229)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.BackColor = Color.PaleGreen
        MonthCalendar1.Location = New Point(9, 283)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 3
        MonthCalendar1.TitleBackColor = Color.Teal
        MonthCalendar1.TrailingForeColor = SystemColors.Control
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(148, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(248, 19)
        Label1.TabIndex = 0
        Label1.Text = "RECENTLY CREATED EVENTS"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(3, 16)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 16)
        Label3.TabIndex = 7
        Label3.Text = "STUDENT #: 23-1784"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(3, 32)
        Label4.Name = "Label4"
        Label4.Size = New Size(102, 16)
        Label4.TabIndex = 8
        Label4.Text = "TIME IN: 10:30 AM"
        ' 
        ' adminForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlText
        ClientSize = New Size(825, 500)
        Controls.Add(Panel2)
        Controls.Add(btnCreate)
        Controls.Add(btnManage)
        Controls.Add(Panel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "adminForm"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "S"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnManage As RoundedButton
    Friend WithEvents btnCreate As RoundedButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
