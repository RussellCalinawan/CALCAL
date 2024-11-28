Imports MySql.Data.MySqlClient
Imports BCrypt.Net

Public Class loginform
    Dim activeColor As Color = Color.Black
    Dim inactiveColor As Color = Color.PaleGreen
    Dim hoverColor As Color = Color.FromArgb(105, 216, 79)
    Dim activeSize As New Size(150, 40)
    Dim inactiveSize As New Size(100, 35)
    Dim animationStep As Integer = 5
    Dim isLoginActive As Boolean = True
    Dim isPasswordShown As Boolean = False

    Dim connString As String = "Server=localhost;Database=event;Uid=root;Pwd=Calinawan27;"

    Private Sub useForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelSign.Visible = False
        btnSigner.Visible = False
        piceyeClosed.Visible = True
        piceyeOpen.Visible = False
        piceyeClosed.Cursor = Cursors.Hand
        piceyeOpen.Cursor = Cursors.Hand

        textboxConfirm.PasswordChar = "*"

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
        textboxConfirm.PasswordChar = "*"
        piceyeClosed.Visible = True
        piceyeOpen.Visible = False
        isPasswordShown = False
    End Sub

    Private Sub piceyeClosed_Click(sender As Object, e As EventArgs) Handles piceyeClosed.Click
        textboxConfirm.PasswordChar = ""
        piceyeClosed.Visible = False
        piceyeOpen.Visible = True
        isPasswordShown = True
    End Sub

    Private Sub btnSigner_Click(sender As Object, e As EventArgs) Handles btnSigner.Click
        ' Validate the password match
        If textboxCreate.Text <> textboxConfirmeh.Text Then
            MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim plainPassword As String = textboxCreate.Text ' Store the plain password

        ' Hash the password using bcrypt
        Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(plainPassword)

        Dim query As String = "INSERT INTO signup (name, email, password) VALUES (@name, @userEmail, @password)"

        ' Execute the SQL query to insert the user into the database
        Try
            Using conn As New MySqlConnection(connString)
                Using cmd As New MySqlCommand(query, conn)
                    ' Add parameters to avoid SQL injection
                    cmd.Parameters.AddWithValue("@name", textboxName.Text)
                    cmd.Parameters.AddWithValue("@userEmail", textboxeehmail.Text)
                    cmd.Parameters.AddWithValue("@password", hashedPassword)

                    conn.Open()
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Signup successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Show()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEnterer_Click(sender As Object, e As EventArgs) Handles btnEnterer.Click
        Dim enteredEmail As String = textboxEmail.Text
        Dim enteredPassword As String = textboxConfirm.Text
        userForm.SetUserEmail(textboxEmail.Text)
        ' Query to retrieve the stored hashed password based on the entered email
        Dim query As String = "SELECT password FROM signup WHERE email = @email"

        Using conn As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@email", enteredEmail)

                Try
                    conn.Open()

                    ' Retrieve the stored hashed password from the database
                    Dim storedHashedPassword As Object = cmd.ExecuteScalar()

                    ' Check if the email exists in the database
                    If storedHashedPassword Is Nothing OrElse String.IsNullOrEmpty(storedHashedPassword.ToString()) Then
                        MessageBox.Show("Email not found.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        ' Verify the entered password against the stored hashed password using bcrypt
                        If BCrypt.Net.BCrypt.Verify(enteredPassword, storedHashedPassword.ToString()) Then
                            ' Password is correct, proceed with login
                            userForm.Show()
                            Me.Hide()
                        Else
                            MessageBox.Show("Incorrect password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub textboxeehmail_TextChanged(sender As Object, e As EventArgs) Handles textboxeehmail.TextChanged

    End Sub
End Class
