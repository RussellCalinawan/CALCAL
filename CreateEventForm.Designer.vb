<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateEventForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateEventForm))
        Label1 = New Label()
        textTitle = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        btnAccept = New RoundedButton()
        PictureBox1 = New PictureBox()
        lblDesc = New Label()
        richtextDesc = New RichTextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(54, 110)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 17)
        Label1.TabIndex = 0
        Label1.Text = "Title :"
        ' 
        ' textTitle
        ' 
        textTitle.BackColor = SystemColors.ControlLightLight
        textTitle.Location = New Point(99, 108)
        textTitle.Name = "textTitle"
        textTitle.Size = New Size(415, 23)
        textTitle.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(54, 196)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 17)
        Label2.TabIndex = 2
        Label2.Text = "Date :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(379, 196)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 17)
        Label3.TabIndex = 3
        Label3.Text = "Time :"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(54, 238)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(213, 21)
        DateTimePicker1.TabIndex = 4
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Format = DateTimePickerFormat.Time
        DateTimePicker2.Location = New Point(379, 236)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.ShowUpDown = True
        DateTimePicker2.Size = New Size(91, 23)
        DateTimePicker2.TabIndex = 5
        ' 
        ' btnAccept
        ' 
        btnAccept.BackColor = Color.PaleGreen
        btnAccept.CornerRadius = 11
        btnAccept.Location = New Point(186, 375)
        btnAccept.Name = "btnAccept"
        btnAccept.Size = New Size(206, 33)
        btnAccept.TabIndex = 6
        btnAccept.Text = "CREATE"
        btnAccept.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ControlLightLight
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(386, 110)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(23, 18)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' lblDesc
        ' 
        lblDesc.AutoSize = True
        lblDesc.BackColor = SystemColors.ControlLightLight
        lblDesc.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDesc.ForeColor = SystemColors.ControlText
        lblDesc.Location = New Point(413, 112)
        lblDesc.Name = "lblDesc"
        lblDesc.Size = New Size(98, 13)
        lblDesc.TabIndex = 8
        lblDesc.Text = "Add a description"
        ' 
        ' richtextDesc
        ' 
        richtextDesc.Location = New Point(272, 130)
        richtextDesc.Name = "richtextDesc"
        richtextDesc.Size = New Size(241, 202)
        richtextDesc.TabIndex = 10
        richtextDesc.Text = ""
        ' 
        ' CreateEventForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlText
        ClientSize = New Size(601, 463)
        Controls.Add(richtextDesc)
        Controls.Add(lblDesc)
        Controls.Add(PictureBox1)
        Controls.Add(btnAccept)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(textTitle)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "CreateEventForm"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents textTitle As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents btnAccept As RoundedButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblDesc As Label
    Friend WithEvents richtextDesc As RichTextBox
End Class
