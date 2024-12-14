Imports MySql.Data.MySqlClient

Public Class UserLogs
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub ActivityLogs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ' Query to fetch data for the Activity Logs
            Dim connstring As String = "SELECT id, username, timestamp FROM activity_logs ORDER BY timestamp ASC"
            Dim cmd As New MySqlCommand(connstring, sqlconnection)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()

            sqlconnection.Open()
            adapter.Fill(table)

            ' Populate existing columns in the DataGridView
            DataGridView1.Rows.Clear() ' Clear existing rows
            For Each row As DataRow In table.Rows
                ' Format the timestamp column to include both date and 12-hour time with AM/PM
                Dim formattedTimestamp As String = Convert.ToDateTime(row("timestamp")).ToString("M/d/yyyy h:mm tt")
                DataGridView1.Rows.Add(row("id"), row("username"), formattedTimestamp)
            Next
        Catch ex As Exception
            MsgBox("An error occurred while loading activity logs: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            sqlconnection.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        ' Ignore the placeholder text
        If txtSearch.Text = "Search User" Then Exit Sub

        Try
            ' Query with a WHERE clause to filter based on the search input
            Dim searchQuery As String = "SELECT id, username, timestamp FROM activity_logs WHERE username LIKE @search ORDER BY timestamp ASC"
            Dim cmd As New MySqlCommand(searchQuery, sqlconnection)
            cmd.Parameters.AddWithValue("@search", "%" & txtSearch.Text.Trim() & "%")

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()

            sqlconnection.Open()
            adapter.Fill(table)

            ' Populate existing columns in the DataGridView
            DataGridView1.Rows.Clear() ' Clear existing rows
            For Each row As DataRow In table.Rows
                ' Format the timestamp column to include both date and 12-hour time with AM/PM
                Dim formattedTimestamp As String = Convert.ToDateTime(row("timestamp")).ToString("M/d/yyyy h:mm tt")
                DataGridView1.Rows.Add(row("id"), row("username"), formattedTimestamp)
            Next
        Catch ex As Exception
            MsgBox("An error occurred while searching activity logs: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            sqlconnection.Close()
        End Try
    End Sub



    Private Sub txtSearch_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.GotFocus
        ' Remove the placeholder text when the TextBox gains focus
        If txtSearch.Text = "Search User" Then
            txtSearch.Text = ""
            txtSearch.ForeColor = Color.Black ' Set normal text color
        End If
    End Sub

    Private Sub txtSearch_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.LostFocus
        ' Restore the placeholder text if the TextBox is empty
        If txtSearch.Text = "" Then
            txtSearch.Text = "Search User"
            txtSearch.ForeColor = Color.Gray ' Set placeholder text color
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtSearch.Text = "Search User"
        txtSearch.ForeColor = Color.Gray ' Set placeholder text color
    End Sub

End Class
