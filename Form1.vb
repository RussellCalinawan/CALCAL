Public Class Form1
    Dim hoverColor As Color = Color.FromArgb(105, 216, 79)
    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click

        For Each control As Control In Me.Controls
            If TypeOf control Is Label OrElse TypeOf control Is Button Then
                control.Visible = False
                PictureBox1.Visible = False
                PictureBox2.Visible = False
            End If
        Next
        Dim targetWidth As Integer = 870
        Do While panelSide.Width < targetWidth
            panelSide.Width += 10
            Threading.Thread.Sleep(2)
            Application.DoEvents()
        Loop

        Dim UserForm As New loginform()
        UserForm.Opacity = 0
        UserForm.StartPosition = FormStartPosition.Manual
        UserForm.Location = Me.Location
        UserForm.Show()

        For opacity As Double = 0 To 1 Step 0.05
            UserForm.Opacity = opacity
            Threading.Thread.Sleep(5)
            Application.DoEvents()
        Next

        UserForm.Opacity = 1.0
        Me.Hide()
    End Sub

    Private Sub btnAdmin_Enter(sender As Object, e As EventArgs) Handles btnAdmin.MouseEnter
        btnAdmin.BackColor = hoverColor
        PictureBox2.BackColor = hoverColor
    End Sub

    Private Sub btnAdmin_leave(sender As Object, e As EventArgs) Handles btnAdmin.MouseLeave
        btnAdmin.BackColor = Color.PaleGreen
        PictureBox2.BackColor = Color.PaleGreen
    End Sub

    Private Sub btnUser_Enter(sender As Object, e As EventArgs) Handles btnUser.MouseEnter
        btnUser.BackColor = hoverColor
        PictureBox1.BackColor = hoverColor
    End Sub

    Private Sub btnUser_Leave(sender As Object, e As EventArgs) Handles btnUser.MouseLeave
        btnUser.BackColor = Color.PaleGreen
        PictureBox1.BackColor = Color.PaleGreen
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click

        For Each control As Control In Me.Controls
            If TypeOf control Is Label OrElse TypeOf control Is Button Then
                control.Visible = False
                PictureBox1.Visible = False
                PictureBox2.Visible = False
            End If
        Next


        Dim targetWidth As Integer = 870
        Do While panelSide.Width < targetWidth
            panelSide.Width += 10
            Threading.Thread.Sleep(2)
            Application.DoEvents()
        Loop


        Dim AdminForm As New adminForm()
        AdminForm.Opacity = 0
        AdminForm.StartPosition = FormStartPosition.Manual
        AdminForm.Location = Me.Location
        AdminForm.Show()


        For opacity As Double = 0 To 1 Step 0.05
            AdminForm.Opacity = opacity
            Threading.Thread.Sleep(5)
            Application.DoEvents()
        Next


        AdminForm.Opacity = 1.0
        Me.Hide()
    End Sub
End Class