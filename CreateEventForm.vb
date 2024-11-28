Imports MySql.Data.MySqlClient

Public Class CreateEventForm
    Dim connString As String = "Server=localhost;Database=event;Uid=root;Pwd=Calinawan27;"
    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        If String.IsNullOrWhiteSpace(textTitle.Text) Then
            MessageBox.Show("Event Title is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrWhiteSpace(textLoc.Text) Then
            MessageBox.Show("Event Location is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrWhiteSpace(textCapacity.Text) OrElse Not IsNumeric(textCapacity.Text) Then
            MessageBox.Show("Enter a valid Max Capacity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Read inputs from the form
        Dim eventName As String = textTitle.Text
        Dim eventLocation As String = textLoc.Text
        Dim eventDate As Date = dateDTP.Value.Date
        Dim eventTime As TimeSpan = timeDTP.Value.TimeOfDay
        Dim eventCapacity As Integer = Integer.Parse(textCapacity.Text)

        ' Use the event date and event time separately
        Dim eventDateOnly As Date = eventDate ' This will be stored in EventDate (DATE type)
        Dim eventTimeOnly As TimeSpan = eventTime ' This will be stored in EventTime (TIME type)

        ' SQL query to insert the new event (using separate columns for date and time)
        Dim query As String = "INSERT INTO events (EventName, EventDate, EventTime, EventLocation, MaxCapacity) 
                               VALUES (@name, @date, @time, @location, @capacity)"

        Try
            Using conn As New MySqlConnection(connString)
                Using cmd As New MySqlCommand(query, conn)
                    ' Add parameters to the query
                    cmd.Parameters.AddWithValue("@name", eventName)
                    cmd.Parameters.AddWithValue("@date", eventDateOnly) ' Insert the date part
                    cmd.Parameters.AddWithValue("@time", eventTimeOnly) ' Insert the time part
                    cmd.Parameters.AddWithValue("@location", eventLocation)
                    cmd.Parameters.AddWithValue("@capacity", eventCapacity)

                    ' Open the connection and execute the query
                    conn.Open()
                    cmd.ExecuteNonQuery()

                    ' Show success message
                    MessageBox.Show("Event created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Optional: Clear the input fields
                    textTitle.Clear()
                    textLoc.Clear()
                    textCapacity.Clear()
                    dateDTP.Value = DateTime.Now
                    timeDTP.Value = DateTime.Now

                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CreateEventForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class