﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(userForm))
        Panel1 = New Panel()
        btnMyEvents = New RoundedButton()
        btnBrowse = New RoundedButton()
        btnRegister = New RoundedButton()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlText
        Panel1.ForeColor = SystemColors.ActiveCaptionText
        Panel1.Location = New Point(0, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(825, 39)
        Panel1.TabIndex = 0
        ' 
        ' btnMyEvents
        ' 
        btnMyEvents.CornerRadius = 11
        btnMyEvents.Font = New Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnMyEvents.Location = New Point(533, 162)
        btnMyEvents.Name = "btnMyEvents"
        btnMyEvents.Size = New Size(250, 43)
        btnMyEvents.TabIndex = 1
        btnMyEvents.Text = "MY EVENTS"
        btnMyEvents.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.CornerRadius = 11
        btnBrowse.Font = New Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBrowse.Location = New Point(533, 250)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(250, 43)
        btnBrowse.TabIndex = 3
        btnBrowse.Text = "BROWSE EVENTS"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' btnRegister
        ' 
        btnRegister.CornerRadius = 11
        btnRegister.Font = New Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRegister.Location = New Point(533, 339)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(250, 43)
        btnRegister.TabIndex = 4
        btnRegister.Text = "REGISTER FOR EVENTS"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 38)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(496, 463)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' userForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PaleGreen
        ClientSize = New Size(825, 500)
        Controls.Add(PictureBox1)
        Controls.Add(btnRegister)
        Controls.Add(btnBrowse)
        Controls.Add(btnMyEvents)
        Controls.Add(Panel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "userForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "mainUserForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMyEvents As RoundedButton
    Friend WithEvents btnBrowse As RoundedButton
    Friend WithEvents btnRegister As RoundedButton
    Friend WithEvents PictureBox1 As PictureBox
End Class