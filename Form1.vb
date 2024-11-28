Public Class Form1
    Dim hoverColor As Color = Color.FromArgb(105, 216, 79)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        passwordPANEL.Visible = False
        numpadFLP.Visible = False
        txtinput.Visible = False

        For Each ctrl As Control In numpadFLP.Controls
            If TypeOf ctrl Is Button AndAlso ctrl.Name.StartsWith("btn") Then
                AddHandler ctrl.Click, AddressOf NumpadButton_Click
            End If
        Next
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        HideAllControls()
        Dim UserForm As New loginform()
        TransitionToForm(UserForm)
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        numpadFLP.Visible = True
        txtinput.Visible = True
        passwordPANEL.Visible = True
    End Sub

    Private Sub NumpadButton_Click(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)

        Select Case btn.Name
            Case "btnClr"
                txtinput.Text = ""
            Case "btnBackspace"
                If txtinput.Text.Length > 0 Then
                    txtinput.Text = txtinput.Text.Substring(0, txtinput.Text.Length - 1)
                End If
            Case Else
                txtinput.Text &= btn.Text
        End Select
    End Sub

    Private Sub btnAdmin_MouseEnter(sender As Object, e As EventArgs) Handles btnAdmin.MouseEnter

        btnAdmin.BackColor = hoverColor
        PictureBox2.BackColor = hoverColor
    End Sub

    Private Sub btnAdmin_MouseLeave(sender As Object, e As EventArgs) Handles btnAdmin.MouseLeave
        btnAdmin.BackColor = Color.PaleGreen
        PictureBox2.BackColor = Color.PaleGreen
    End Sub

    Private Sub btnUser_MouseEnter(sender As Object, e As EventArgs) Handles btnUser.MouseEnter
        btnUser.BackColor = hoverColor
        PictureBox1.BackColor = hoverColor
    End Sub

    Private Sub btnUser_MouseLeave(sender As Object, e As EventArgs) Handles btnUser.MouseLeave
        btnUser.BackColor = Color.PaleGreen
        PictureBox1.BackColor = Color.PaleGreen
    End Sub

    Private Sub HideAllControls()
        For Each control As Control In Me.Controls
            If TypeOf control Is Label OrElse TypeOf control Is Button Then
                control.Visible = False
            End If
        Next
        PictureBox1.Visible = False
        PictureBox2.Visible = False
    End Sub

    Private Sub TransitionToForm(targetForm As Form)
        Dim targetWidth As Integer = 870
        Do While panelSide.Width < targetWidth
            panelSide.Width += 10
            Threading.Thread.Sleep(2)
            Application.DoEvents()
        Loop

        targetForm.Opacity = 0
        targetForm.StartPosition = FormStartPosition.Manual
        targetForm.Location = Me.Location
        targetForm.Show()

        For opacity As Double = 0 To 1 Step 0.05
            targetForm.Opacity = opacity
            Threading.Thread.Sleep(5)
            Application.DoEvents()
        Next

        targetForm.Opacity = 1.0
        Me.Hide()
    End Sub

    Private Sub nextBTN_Click(sender As Object, e As EventArgs) Handles nextBTN.Click
        Me.Hide()
        adminForm.Show()
    End Sub
End Class
