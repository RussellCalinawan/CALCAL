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
        Label1 = New Label()
        textTitle = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        dateDTP = New DateTimePicker()
        timeDTP = New DateTimePicker()
        btnAccept = New RoundedButton()
        Label4 = New Label()
        textLoc = New TextBox()
        Label5 = New Label()
        textCapacity = New TextBox()
        picboxBack = New PictureBox()
        CType(picboxBack, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(54, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 17)
        Label1.TabIndex = 0
        Label1.Text = "Title :"
        ' 
        ' textTitle
        ' 
        textTitle.BackColor = SystemColors.ControlLightLight
        textTitle.Location = New Point(99, 63)
        textTitle.Name = "textTitle"
        textTitle.Size = New Size(415, 23)
        textTitle.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(54, 147)
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
        Label3.Location = New Point(373, 147)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 17)
        Label3.TabIndex = 3
        Label3.Text = "Time :"
        ' 
        ' dateDTP
        ' 
        dateDTP.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dateDTP.Location = New Point(54, 168)
        dateDTP.Name = "dateDTP"
        dateDTP.Size = New Size(213, 21)
        dateDTP.TabIndex = 4
        ' 
        ' timeDTP
        ' 
        timeDTP.Format = DateTimePickerFormat.Time
        timeDTP.Location = New Point(373, 166)
        timeDTP.Name = "timeDTP"
        timeDTP.ShowUpDown = True
        timeDTP.Size = New Size(91, 23)
        timeDTP.TabIndex = 5
        ' 
        ' btnAccept
        ' 
        btnAccept.BackColor = Color.PaleGreen
        btnAccept.CornerRadius = 11
        btnAccept.Location = New Point(170, 361)
        btnAccept.Name = "btnAccept"
        btnAccept.Size = New Size(234, 31)
        btnAccept.TabIndex = 6
        btnAccept.Text = "CREATE"
        btnAccept.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(55, 206)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 17)
        Label4.TabIndex = 11
        Label4.Text = "Location :"
        ' 
        ' textLoc
        ' 
        textLoc.BackColor = SystemColors.ControlLightLight
        textLoc.Location = New Point(55, 226)
        textLoc.Name = "textLoc"
        textLoc.Size = New Size(212, 23)
        textLoc.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(373, 206)
        Label5.Name = "Label5"
        Label5.Size = New Size(93, 17)
        Label5.TabIndex = 13
        Label5.Text = "Max Capacity :"
        ' 
        ' textCapacity
        ' 
        textCapacity.BackColor = SystemColors.ControlLightLight
        textCapacity.Location = New Point(373, 226)
        textCapacity.Name = "textCapacity"
        textCapacity.Size = New Size(91, 23)
        textCapacity.TabIndex = 14
        ' 
        ' picboxBack
        ' 
        picboxBack.Image = My.Resources.Resources.backero__1__removebg_preview__2_
        picboxBack.Location = New Point(3, 2)
        picboxBack.Name = "picboxBack"
        picboxBack.Size = New Size(56, 35)
        picboxBack.SizeMode = PictureBoxSizeMode.StretchImage
        picboxBack.TabIndex = 15
        picboxBack.TabStop = False
        ' 
        ' CreateEventForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        ClientSize = New Size(601, 463)
        Controls.Add(picboxBack)
        Controls.Add(textCapacity)
        Controls.Add(Label5)
        Controls.Add(textLoc)
        Controls.Add(Label4)
        Controls.Add(btnAccept)
        Controls.Add(timeDTP)
        Controls.Add(dateDTP)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(textTitle)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "CreateEventForm"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        CType(picboxBack, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents textTitle As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dateDTP As DateTimePicker
    Friend WithEvents timeDTP As DateTimePicker
    Friend WithEvents btnAccept As RoundedButton
    Friend WithEvents Label4 As Label
    Friend WithEvents textLoc As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents textCapacity As TextBox
    Friend WithEvents picboxBack As PictureBox
End Class
