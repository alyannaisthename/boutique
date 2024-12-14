Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Maintenance
    ' Close button handler
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.DialogResult = DialogResult.OK ' Close the form and return to the previous view
        Me.Close()
    End Sub

    ' Button to back up the database
    Private Sub btnBackup_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBackup.Click
        Try
            ' Step 1: Set up the SaveFileDialog for the user to choose where to save the backup file
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "SQL files (*.sql)|*.sql" ' Only allow saving files with .sql extension
            saveFileDialog.Title = "Database Backup" ' Title of the dialog
            saveFileDialog.FileName = "database_backup_" & DateTime.Now.ToString("yyyyMMddHHmmss") & ".sql" ' Default file name

            ' Step 2: If the user selects a location, proceed with the backup process
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                ' Path to the `mysqldump.exe` tool (update to the actual path on your machine)
                Dim mysqldumpPath As String = "C:\Program Files\MySQL\MySQL Server 8.0\bin\mysqldump.exe"
                ' Ensure this path exists on your computer. Change it if needed.

                ' The path where the user wants to save the backup file
                Dim backupFilePath As String = saveFileDialog.FileName

                ' MySQL database credentials and database to back up
                Dim backupCommand As String = "--host=localhost --user=root --password= --databases boutique_db"

                ' Step 3: Set up the process to run the mysqldump command using `cmd.exe`
                Dim process As New Process()
                process.StartInfo.FileName = mysqldumpPath
                ' Construct the arguments string to run mysqldump and save the output to the file
                process.StartInfo.Arguments = backupCommand & " --result-file=""" & backupFilePath & """"
                process.StartInfo.UseShellExecute = False
                process.StartInfo.RedirectStandardOutput = True
                process.StartInfo.RedirectStandardError = True
                process.StartInfo.CreateNoWindow = True ' Hide the cmd window

                ' Step 4: Start the process and wait for it to finish
                process.Start()
                process.WaitForExit()

                ' Step 5: Check if the process succeeded
                If process.ExitCode = 0 Then
                    MessageBox.Show("Database backup completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    ' If an error occurred, display the error message from the process
                    Dim errorMessage As String = process.StandardError.ReadToEnd()
                    MessageBox.Show("Error during backup: " & errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            ' Catch any unexpected errors and display them
            MessageBox.Show("Error during backup: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Button to show system logs
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SystemLogs.Show()
    End Sub

End Class
