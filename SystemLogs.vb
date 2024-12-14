'Imports MySql.Data.MySqlClient
'Imports System.IO

'Public Class SystemLogs
'    Private logFilePath As String = "C:\Path\To\SystemLogs.txt" ' Path to save/read logs file

'    ' Insert a log into the database and file
'    Public Sub InsertLog(ByVal logMessage As String)
'        Try
'            ' Insert log into the database
'            Dim connectionString As String = "Server=localhost;userid=root;password=;database=boutique_db"
'            Using connection As New MySqlConnection(connectionString)
'                Dim query As String = "INSERT INTO system_logs_tbl (log_date, log_message) VALUES (NOW(), @logMessage)"
'                Dim command As New MySqlCommand(query, connection)
'                command.Parameters.AddWithValue("@logMessage", logMessage)

'                connection.Open()
'                command.ExecuteNonQuery()
'                connection.Close()
'            End Using

'            ' Also save the log to a physical file
'            If Not File.Exists(logFilePath) Then
'                File.Create(logFilePath).Dispose() ' Create file if it doesn't exist
'            End If
'            File.AppendAllText(logFilePath, DateTime.Now & ": " & logMessage & Environment.NewLine)

'        Catch ex As Exception
'            MessageBox.Show("Error logging event: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try
'    End Sub

'    ' Load logs from the database
'    Private Sub LoadSystemLogs()
'        Try
'            ' Disable auto column generation
'            dgvSystemLogs.AutoGenerateColumns = False

'            ' Connection string to your database
'            Dim connectionString As String = "Server=localhost;userid=root;password=;database=boutique_db"
'            Using connection As New MySqlConnection(connectionString)
'                Dim query As String = "SELECT id, log_date, log_message FROM system_logs_tbl ORDER BY log_date DESC"
'                Dim adapter As New MySqlDataAdapter(query, connection)
'                Dim dataTable As New DataTable()

'                connection.Open()
'                adapter.Fill(dataTable)
'                connection.Close()

'                ' Bind the data to the DataGridView
'                dgvSystemLogs.DataSource = dataTable
'            End Using
'        Catch ex As Exception
'            MessageBox.Show("Error loading logs: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try
'    End Sub



'    ' Load logs from a file
'    Private Sub LoadFileLogs()
'        Try
'            If File.Exists(logFilePath) Then
'                txtSearchLogs.Text = File.ReadAllText(logFilePath)
'            Else
'                MessageBox.Show("Log file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'            End If
'        Catch ex As Exception
'            MessageBox.Show("Error reading log file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try
'    End Sub

'    ' Search logs in the database
'    Private Sub txtSearchLogs_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtSearchLogs.TextChanged
'        Try
'            Dim connectionString As String = "Server=localhost;Uid=root;Pwd=;Database=boutique_db;"
'            Dim searchTerm As String = txtSearchLogs.Text.Trim()
'            Using connection As New MySqlConnection(connectionString)
'                Dim query As String = "SELECT id, log_date, log_message FROM system_logs_tbl WHERE log_message LIKE @searchTerm ORDER BY log_date DESC"
'                Dim command As New MySqlCommand(query, connection)
'                command.Parameters.AddWithValue("@searchTerm", "%" & searchTerm & "%")
'                Dim adapter As New MySqlDataAdapter(command)
'                Dim dataTable As New DataTable()

'                connection.Open()
'                adapter.Fill(dataTable)
'                connection.Close()

'                dgvSystemLogs.DataSource = dataTable
'            End Using
'        Catch ex As Exception
'            MessageBox.Show("Error during search: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try
'    End Sub

'    ' Form Load Handler
'    Private Sub MaintenanceForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
'        LoadSystemLogs() ' Load database logs
'        ' LoadFileLogs() ' Uncomment if you want to load file logs
'    End Sub
'    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
'        Me.DialogResult = DialogResult.OK ' Close the form and return to the previous view
'        Me.Close()
'    End Sub
'End Class
