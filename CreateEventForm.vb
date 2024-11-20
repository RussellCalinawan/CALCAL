Public Class CreateEventForm
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If lblDesc.Visible Then
            lblDesc.Visible = False
            richtextDesc.Visible = True
        Else
            lblDesc.Visible = True
            richtextDesc.Visible = False
        End If
    End Sub

    Private Sub CreateEventForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        richtextDesc.Visible = False
        lblDesc.Visible = True
    End Sub
End Class