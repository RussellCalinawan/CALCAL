Public Class loginform
    Dim activeColor As Color = Color.Black
    Dim inactiveColor As Color = Color.PaleGreen
    Dim hoverColor As Color = Color.FromArgb(105, 216, 79)
    Dim activeSize As New Size(150, 40)
    Dim inactiveSize As New Size(100, 35)
    Dim animationStep As Integer = 5
    Dim isLoginActive As Boolean = True
    Dim isPasswordShown As Boolean = False
    Dim placeholderName As String = "Enter your name"
    Dim placeholderEmail As String = "Enter your email"
    Dim placeholderCreate As String = "Create a password"
    Dim placeholderConfirm As String = "Confirm your password"

    Private Sub useForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        panelSign.Visible = False
        btnSigner.Visible = False
        piceyeClosed.Visible = True
        piceyeOpen.Visible = False
        piceyeClosed.Cursor = Cursors.Hand
        piceyeOpen.Cursor = Cursors.Hand

        textPass.PasswordChar = "*"

        StyleButton(btnLogin1)
        StyleButton(btnSign1)

        SetActiveButton(btnLogin1, True)
        SetActiveButton(btnSign1, False)
    End Sub

    Private timerExpand As Timer
    Private timerShrink As Timer

    Public Sub New()
        InitializeComponent()


        timerExpand = New Timer()
        timerShrink = New Timer()


        timerExpand.Interval = 10
        timerShrink.Interval = 10


        AddHandler timerExpand.Tick, AddressOf timerExpand1_Tick
        AddHandler timerShrink.Tick, AddressOf timerShrink1_Tick
    End Sub

    Private Sub StyleButton(button As Button)
        button.FlatStyle = FlatStyle.Flat
        button.FlatAppearance.BorderSize = 0
        button.BackColor = inactiveColor
        button.ForeColor = Color.Black
        button.Size = inactiveSize
        button.Font = New Font(button.Font.FontFamily, 10, FontStyle.Bold)
    End Sub

    Private Sub SetActiveButton(button As Button, isActive As Boolean)
        If isActive Then
            button.BackColor = activeColor
            button.ForeColor = Color.White
            timerExpand.Start()
        Else
            button.BackColor = inactiveColor
            button.ForeColor = Color.Black
            timerShrink.Start()
        End If
    End Sub

    Private Sub timerExpand1_Tick(sender As Object, e As EventArgs)
        Dim targetButton = If(isLoginActive, btnLogin1, btnSign1)
        If targetButton.Size.Width < activeSize.Width OrElse targetButton.Size.Height < activeSize.Height Then
            targetButton.Size = New Size(
                Math.Min(targetButton.Size.Width + animationStep, activeSize.Width),
                Math.Min(targetButton.Size.Height + animationStep, activeSize.Height)
            )
        Else
            timerExpand.Stop()
        End If
    End Sub

    Private Sub timerShrink1_Tick(sender As Object, e As EventArgs)
        Dim targetButton = If(isLoginActive, btnSign1, btnLogin1)
        If targetButton.Size.Width > inactiveSize.Width OrElse targetButton.Size.Height > inactiveSize.Height Then
            targetButton.Size = New Size(
                Math.Max(targetButton.Size.Width - animationStep, inactiveSize.Width),
                Math.Max(targetButton.Size.Height - animationStep, inactiveSize.Height)
            )
        Else
            timerShrink.Stop()
        End If
    End Sub

    Private Sub btnLogin1_Click(sender As Object, e As EventArgs) Handles btnLogin1.Click
        isLoginActive = True
        SetActiveButton(btnLogin1, True)
        SetActiveButton(btnSign1, False)
        panelSign.Visible = False
        btnSigner.Visible = False

    End Sub

    Private Sub btnSign1_Click(sender As Object, e As EventArgs) Handles btnSign1.Click
        isLoginActive = False
        SetActiveButton(btnSign1, True)
        SetActiveButton(btnLogin1, False)
        panelSign.Visible = True
        btnSigner.Visible = True
    End Sub

    Private Sub btnLogin1_MouseEnter(sender As Object, e As EventArgs) Handles btnLogin1.MouseEnter
        btnLogin1.BackColor = hoverColor
    End Sub

    Private Sub btnLogin1_MouseLeave(sender As Object, e As EventArgs) Handles btnLogin1.MouseLeave
        btnLogin1.BackColor = If(isLoginActive, activeColor, inactiveColor)
    End Sub

    Private Sub btnSign1_MouseEnter(sender As Object, e As EventArgs) Handles btnSign1.MouseEnter
        btnSign1.BackColor = hoverColor
    End Sub

    Private Sub btnSign1_MouseLeave(sender As Object, e As EventArgs) Handles btnSign1.MouseLeave
        btnSign1.BackColor = If(Not isLoginActive, activeColor, inactiveColor)
    End Sub

    Private Sub piceyeOpen_Click(sender As Object, e As EventArgs) Handles piceyeOpen.Click
        textPass.PasswordChar = "*"
        piceyeClosed.Visible = True
        piceyeOpen.Visible = False
        isPasswordShown = False
    End Sub
    Private Sub piceyeClosed_Click(sender As Object, e As EventArgs) Handles piceyeClosed.Click

        textPass.PasswordChar = ""
        piceyeClosed.Visible = False
        piceyeOpen.Visible = True
        isPasswordShown = True
    End Sub

    Private Sub SetPlaceholderColor(textBox As TextBox)
        textBox.ForeColor = Color.Gray
    End Sub

    Private Sub ClearPlaceholderText(textBox As TextBox, placeholder As String)
        If textBox.Text = placeholder Then
            textBox.Text = ""
            textBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub RestorePlaceholderText(textBox As TextBox, placeholder As String)
        If String.IsNullOrEmpty(textBox.Text) Then
            textBox.Text = placeholder
            SetPlaceholderColor(textBox)
        End If
    End Sub
    Private Sub textboxName_Enter(sender As Object, e As EventArgs) Handles textboxName.Enter
        ClearPlaceholderText(textboxName, placeholderName)
    End Sub

    Private Sub textboxEmail_Enter(sender As Object, e As EventArgs) Handles textboxEmail.Enter
        ClearPlaceholderText(textboxEmail, placeholderEmail)
    End Sub

    Private Sub textboxCreate_Enter(sender As Object, e As EventArgs) Handles textboxCreate.Enter
        ClearPlaceholderText(textboxCreate, placeholderCreate)
    End Sub

    Private Sub textboxConfirm_Enter(sender As Object, e As EventArgs) Handles textboxConfirm.Enter
        ClearPlaceholderText(textboxConfirm, placeholderConfirm)
    End Sub

    Private Sub textboxName_Leave(sender As Object, e As EventArgs) Handles textboxName.Leave
        RestorePlaceholderText(textboxName, placeholderName)
    End Sub

    Private Sub textboxEmail_Leave(sender As Object, e As EventArgs) Handles textboxEmail.Leave
        RestorePlaceholderText(textboxEmail, placeholderEmail)
    End Sub

    Private Sub textboxCreate_Leave(sender As Object, e As EventArgs) Handles textboxCreate.Leave
        RestorePlaceholderText(textboxCreate, placeholderCreate)
    End Sub

    Private Sub textboxConfirm_Leave(sender As Object, e As EventArgs) Handles textboxConfirm.Leave
        RestorePlaceholderText(textboxConfirm, placeholderConfirm)
    End Sub
    Private Sub btnSigner_Click(sender As Object, e As EventArgs) Handles btnSigner.Click
        Me.Hide()
        userForm.Show()
    End Sub
    Private Sub btnEnterer_Click(sender As Object, e As EventArgs) Handles btnEnterer.Click
        userForm.Show()
        Me.Hide()
    End Sub
End Class
