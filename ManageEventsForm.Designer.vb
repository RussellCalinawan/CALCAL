<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageEventsForm
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
        datamanagePANEL = New Panel()
        btnDelete = New RoundedButton()
        managedataDGV = New DataGridView()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        datamanagePANEL.SuspendLayout()
        CType(managedataDGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.PaleGreen
        Panel1.Controls.Add(DataGridView1)
        Panel1.Location = New Point(-2, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(828, 39)
        Panel1.TabIndex = 1
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(301, 38)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(240, 150)
        DataGridView1.TabIndex = 0
        ' 
        ' datamanagePANEL
        ' 
        datamanagePANEL.BackColor = SystemColors.ControlLight
        datamanagePANEL.Controls.Add(btnDelete)
        datamanagePANEL.Controls.Add(managedataDGV)
        datamanagePANEL.Location = New Point(-2, 39)
        datamanagePANEL.Name = "datamanagePANEL"
        datamanagePANEL.Size = New Size(825, 457)
        datamanagePANEL.TabIndex = 2
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.PaleGreen
        btnDelete.CornerRadius = 11
        btnDelete.Location = New Point(645, 370)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(158, 44)
        btnDelete.TabIndex = 4
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' managedataDGV
        ' 
        managedataDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        managedataDGV.Location = New Point(0, 0)
        managedataDGV.Name = "managedataDGV"
        managedataDGV.Size = New Size(611, 457)
        managedataDGV.TabIndex = 3
        ' 
        ' ManageEventsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlText
        ClientSize = New Size(825, 500)
        Controls.Add(datamanagePANEL)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "ManageEventsForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ManageEventsForm"
        Panel1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        datamanagePANEL.ResumeLayout(False)
        CType(managedataDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents datamanagePANEL As Panel
    Friend WithEvents managedataDGV As DataGridView
    Friend WithEvents btnDelete As RoundedButton
End Class
