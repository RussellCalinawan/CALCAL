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
        Panel1 = New Panel()
        DataGridView1 = New DataGridView()
        btnManage = New RoundedButton()
        btnCreate = New RoundedButton()
        Panel2 = New Panel()
        Panel3 = New Panel()
        participantsDGV = New DataGridView()
        btnView = New RoundedButton()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(participantsDGV, ComponentModel.ISupportInitialize).BeginInit()
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
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlLightLight
        Panel2.Location = New Point(334, 57)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(455, 442)
        Panel2.TabIndex = 7
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ControlLightLight
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
        ' AdminForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlText
        ClientSize = New Size(825, 500)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(btnCreate)
        Controls.Add(btnManage)
        Controls.Add(Panel1)
        Controls.Add(btnView)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "AdminForm"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "S"
        Panel1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        CType(participantsDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnManage As RoundedButton
    Friend WithEvents btnCreate As RoundedButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents participantsDGV As DataGridView
    Friend WithEvents btnView As RoundedButton
End Class
