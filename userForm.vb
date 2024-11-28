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
        ' Query to fetch events the user has registered for
        Dim query As String = "SELECT idregisterevents, NAME, EVENTNAME, EMAIL, CONTACT 
                           FROM registerevents
                           WHERE EMAIL = @userEmail"

        Dim dt As New DataTable()

        Try
            ' Initialize the connection using the connection string
            Using conn As New MySqlConnection(connString)
                ' Create a command object with the query and connection
                Using cmd As New MySqlCommand(query, conn)
                    ' Add the user's email as a parameter to the query
                    cmd.Parameters.AddWithValue("@userEmail", loggedInUserEmail)

                    ' Open the connection
                    conn.Open()

                    ' Execute the query and load the result into the DataTable
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            dt.Load(reader) ' Load data into DataTable if rows exist
                        Else
                            ' Inform the user if no events are found
                            MessageBox.Show("No events found for this user.", "No Events", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As MySqlException
            ' Handle MySQL-specific errors
            MessageBox.Show("A database error occurred: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            ' Handle general errors
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Bind the DataTable to the DataGridView to display the user's registered events
        viewDGV.DataSource = dt
        ' Optional: Adjust DataGridView columns for better readability
        viewDGV.AutoResizeColumns()
    End Sub


    ' Event handler for the "My Events" button click
    Private Sub btnMyEvents_Click(sender As Object, e As EventArgs) Handles btnMyEvents.Click
        viewDGV.Show()
        viewPANEL.Show()
        PictureBox1.Hide()
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

    Private Sub picboxBack_Click(sender As Object, e As EventArgs) Handles picboxBack.Click
        Me.Hide()
        loginform.Show()
    End Sub
End Class