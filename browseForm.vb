Imports MySql.Data.MySqlClient

Public Class browseForm
    ' Connection string to your database
    Dim connString As String = "Server=localhost;Database=event;Uid=root;Pwd=Calinawan27;"

    ' DataGridView control for events (Assuming the DataGridView control is named 'eventsDGV')

    ' Method to load events into the DataGridView
    Public Sub LoadEvents()
        Dim query As String = "SELECT EventID, EventName, EventDate, EventLocation FROM events"
        Dim dt As New DataTable()

        Try
            Using conn As New MySqlConnection(connString)
                Using cmd As New MySqlCommand(query, conn)
                    conn.Open()
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Bind the DataTable to the DataGridView
        eventsDGV.DataSource = dt
    End Sub

    ' Method to load all event names into the ComboBox
    Public Sub LoadEventNamesToComboBox()
        Dim query As String = "SELECT EventName FROM events"

        Try
            Using conn As New MySqlConnection(connString)
                Using cmd As New MySqlCommand(query, conn)
                    conn.Open()
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        eventnameCMB.Items.Clear()  ' Clear any existing items
                        While reader.Read()
                            ' Add each event name to the ComboBox
                            eventnameCMB.Items.Add(reader("EventName").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading event names: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Event handler for DataGridView cell click (when user clicks on an event)
    Private Sub eventsDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles eventsDGV.CellClick
        ' Ensure a valid row is clicked
        If e.RowIndex >= 0 Then
            ' Get the selected EventID and EventName from the clicked row
            Dim eventID As Integer = eventsDGV.Rows(e.RowIndex).Cells("EventID").Value
            Dim eventName As String = eventsDGV.Rows(e.RowIndex).Cells("EventName").Value.ToString()

            ' Show the registration panel
            registrationPANEL.Visible = True

            ' You can pre-select the event name in the ComboBox (optional)
            eventnameCMB.SelectedItem = eventName
        End If
    End Sub

    ' Method to register the user for the event
    Private Sub RegisterUserForEvent()
        ' Prepare the SQL query to insert registration data
        Dim query As String = "INSERT INTO registerevents (NAME, EMAIL, CONTACT, EVENTNAME) VALUES (@NAME, @EMAIL, @CONTACT, @EVENTNAME)"

        Try
            Using conn As New MySqlConnection(connString)
                Using cmd As New MySqlCommand(query, conn)
                    ' Open the connection
                    conn.Open()

                    ' Add parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@NAME", userNameTextBox.Text)
                    cmd.Parameters.AddWithValue("@EMAIL", userEmailTextBox.Text)
                    cmd.Parameters.AddWithValue("@CONTACT", contactTextBox.Text)
                    cmd.Parameters.AddWithValue("@EVENTNAME", eventnameCMB.SelectedItem.ToString())

                    ' Execute the command
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' Show a success message
            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As MySqlException
            ' Handle any MySQL-specific errors
            MessageBox.Show("An error occurred while registering: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception
            ' Handle general errors
            MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' When the form loads, load the events into the DataGridView and hide the registration panel initially
    Private Sub browseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        registrationPANEL.Visible = False  ' Hide registration panel initially
        LoadEvents()  ' Load events from the database
        LoadEventNamesToComboBox()  ' Load all event names into the ComboBox
    End Sub

    ' Event handler for the Register button click (add your Register button logic here)
    Private Sub registerButton_Click(sender As Object, e As EventArgs) Handles registerButton.Click
        RegisterUserForEvent()  ' Call the method to register the user
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub picboxBack_Click(sender As Object, e As EventArgs) Handles picboxBack.Click
        userForm.Show()
        Me.Hide()
    End Sub

    Private Sub registrationPANEL_Paint(sender As Object, e As PaintEventArgs) Handles registrationPANEL.Paint

    End Sub
End Class
