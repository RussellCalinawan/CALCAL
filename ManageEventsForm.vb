Imports MySql.Data.MySqlClient

Public Class ManageEventsForm
    ' Connection string to your database
    Dim connString As String = "Server=localhost;Database=event;Uid=root;Pwd=Calinawan27;"

    ' Method to load all created events into the DataGridView
    Public Sub LoadCreatedEvents()
        ' SQL query to fetch all created events
        Dim query As String = "SELECT EventID, EventName, EventDate, EventLocation FROM events"
        Dim dt As New DataTable()

        Try
            Using conn As New MySqlConnection(connString)
                Using cmd As New MySqlCommand(query, conn)
                    conn.Open()

                    ' Execute the query and load data into the DataTable
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Show error message in case of a database error
            MessageBox.Show("An error occurred while loading events: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Bind the DataTable to the DataGridView
        managedataDGV.DataSource = dt
    End Sub

    ' Event handler for the form load
    Private Sub ManageEventsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load all events into managedataDGV when the form loads
        LoadCreatedEvents()
    End Sub

    ' Optional: Handle any additional logic for the panel paint event
    Private Sub datamanagePANEL_Paint(sender As Object, e As PaintEventArgs) Handles datamanagePANEL.Paint
        ' Leave this empty or add custom drawing logic if needed
    End Sub

    ' Event handler for the Delete button
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Check if a row is selected in the DataGridView
        If managedataDGV.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an event to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get the EventID of the selected row
        Dim eventID As Integer = Convert.ToInt32(managedataDGV.SelectedRows(0).Cells("EventID").Value)

        ' Ask for confirmation before deletion
        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this event?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.Yes Then
            Try
                ' SQL query to delete the selected event
                Dim query As String = "DELETE FROM events WHERE EventID = @EventID"

                Using conn As New MySqlConnection(connString)
                    Using cmd As New MySqlCommand(query, conn)
                        ' Open the database connection
                        conn.Open()

                        ' Add the EventID parameter
                        cmd.Parameters.AddWithValue("@EventID", eventID)

                        ' Execute the delete command
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                ' Refresh the DataGridView after deletion
                LoadCreatedEvents()

                ' Show success message
                MessageBox.Show("Event deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                ' Show error message if deletion fails
                MessageBox.Show("An error occurred while deleting the event: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub picboxBack_Click(sender As Object, e As EventArgs) Handles picboxBack.Click
        Me.Hide()
        AdminForm.Show()
    End Sub
End Class
