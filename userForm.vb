Imports MySql.Data.MySqlClient

Public Class userForm
    Dim connString As String = "Server=localhost;Database=event;Uid=root;Pwd=Calinawan27;"

    ' Declare a variable to store the logged-in user's email
    Private loggedInUserEmail As String = ""

    ' Method to set the logged-in user's email
    Public Sub SetUserEmail(email As String)
        loggedInUserEmail = email
    End Sub

    ' Method to load the user's events
    Public Sub LoadUserEvents()
        Dim query As String = "SELECT events.EventName, events.EventDate, events.EventTime, events.EventLocation 
                               FROM events
                               INNER JOIN registerevents ON events.EventName = registerevents.name
                               WHERE registerevents.email"

        Dim dt As New DataTable()

        Try
            Using conn As New MySqlConnection(connString)
                Using cmd As New MySqlCommand(query, conn)
                    ' Add the stored email as a parameter to the query
                    cmd.Parameters.AddWithValue("@userEmail", loggedInUserEmail)
                    conn.Open()

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            dt.Load(reader)
                        Else
                            MessageBox.Show("No events found for this user.", "No Events", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading events: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Bind the DataTable to the DataGridView to display the user's events
        viewDGV.DataSource = dt
    End Sub

    ' Event handler for the "My Events" button click
    Private Sub btnMyEvents_Click(sender As Object, e As EventArgs) Handles btnMyEvents.Click
        ' Load the user's events using the stored email
        LoadUserEvents()
    End Sub

    ' Hide DataGridView and Panel on form load
    Private Sub userForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewDGV.Hide()
        viewPANEL.Hide()
    End Sub

    ' Browse button to open the browse form
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        browseForm.Show()
    End Sub
End Class