Imports System.Drawing.Drawing2D

Public Class RoundedButton
    Inherits Button


    Private _cornerRadius As Integer = 20
    Public Property CornerRadius As Integer
        Get
            Return _cornerRadius
        End Get
        Set(value As Integer)
            _cornerRadius = Math.Max(0, Math.Min(value, Math.Min(Me.Width, Me.Height) \ 2))
            Me.Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnPaint(ByVal pevent As PaintEventArgs)

        If Me.Width <= 0 Or Me.Height <= 0 Then Return


        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        Dim path As New GraphicsPath()
        Dim rect As New Rectangle(0, 0, Me.Width, Me.Height)
        Dim cornerRadius As Integer = Math.Max(0, Math.Min(_cornerRadius, Math.Min(Me.Width, Me.Height) \ 2))


        path.AddArc(rect.X, rect.Y, cornerRadius * 2, cornerRadius * 2, 180, 90)
        path.AddArc(rect.Right - cornerRadius * 2, rect.Y, cornerRadius * 2, cornerRadius * 2, 270, 90)
        path.AddArc(rect.Right - cornerRadius * 2, rect.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90)
        path.AddArc(rect.X, rect.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90)
        path.CloseAllFigures()


        Me.Region = New Region(path)


        Using brush As New SolidBrush(Me.BackColor)
            pevent.Graphics.FillPath(brush, path)
        End Using


        Using pen As New Pen(Me.ForeColor, 2)
            pen.StartCap = LineCap.Round
            pen.EndCap = LineCap.Round
            pevent.Graphics.DrawPath(pen, path)
        End Using

        TextRenderer.DrawText(pevent.Graphics, Me.Text, Me.Font, rect, Me.ForeColor, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
    End Sub
End Class
