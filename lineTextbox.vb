Public Class lineTextBox
    Inherits TextBox

    Public Sub New()
        ' Set the control styles for transparency
        Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.White ' Or set to Transparent if the parent allows it

        ' Remove the default border
        Me.BorderStyle = BorderStyle.None
    End Sub

    Protected Overrides Sub OnPaintBackground(pevent As PaintEventArgs)
        MyBase.OnPaintBackground(pevent)
        ' Background painting logic is intentionally overridden but retained base functionality
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)

        ' Handle WM_PAINT (0xF)
        If m.Msg = &HF Then
            Using g As Graphics = Graphics.FromHwnd(Me.Handle)
                Dim rect As Rectangle = Me.ClientRectangle

                ' Draw the bottom border as a line
                Using pen As New Pen(Color.Black, 2) ' Change the color as needed
                    g.DrawLine(pen, 0, rect.Height - 1, rect.Width, rect.Height - 1)
                End Using
            End Using
        End If
    End Sub
End Class

