Imports MySql.Data.MySqlClient

Public Class AdminForm

    ' Connection string for the database
    Dim connString As String = "Server=localhost;Database=event;Uid=root;Pwd=Calinawan27;"

    ' Method to load participants into the DataGridView and ComboBox
    Public Sub LoadParticipants()
        ' SQL query to select data
        Dim query As String = "SELECT name, email, contact, eventname FROM registerevents"
        Dim dt As New DataTable()

        Try
            Using conn As New MySqlConnection(connString)
                Using cmd As New MySqlCommand(query, conn)
                    conn.Open()

                    ' Execute the query and load the results into the DataTable
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            ' If there are rows, load them into the DataTable
                            dt.Load(reader)
                        Else
                            ' If no rows found, display a message
                            MessageBox.Show("No participants found.", "Data Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Handle any errors that occur
            MessageBox.Show("An error occurred while loading participants: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Bind the DataTable to the DataGridView to display participants
        participantsDGV.DataSource = dt

        ' Optionally, populate ComboBox if needed (e.g., with event names or participant names)

        For Each row As DataRow In dt.Rows
        Next
    End Sub

    ' Event handler for showing participants (this should be for the View button, not the DataGridView)
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        ' Show the DataGridView and ComboBox, and load participants into it
        participantsDGV.Visible = True
        Panel3.Visible = True
        LoadParticipants() ' Load the participants into the DataGridView and ComboBox
    End Sub

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initially hide the DataGridView, ComboBox, and Panel3
        participantsDGV.Visible = False
        Panel3.Visible = False
    End Sub

    Private Sub btnManage_Click(sender As Object, e As EventArgs) Handles btnManage.Click
        ManageEventsForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        CreateEventForm.Show()
        Me.Hide()
    End Sub
End Class