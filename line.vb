Public Class line
    Inherits Control

    Public Sub New()

        Me.DoubleBuffered = True


        Me.Size = New Size(50, 200)

        Me.BackColor = Color.White
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)


        Using myPen As New Pen(Color.Black, 2)

            If Me.Width > 0 And Me.Height > 0 Then

                e.Graphics.DrawLine(myPen, Me.Width \ 2, 0, Me.Width \ 2, Me.Height)
            End If
        End Using
    End Sub
End Class
