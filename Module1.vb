Imports MySql.Data.MySqlClient
Module Module1
    Public connstring As String = "Server=localhost;userid=root;password=;database=boutique_db"
    Public sqlconnection As New MySqlConnection(connstring)
    Public dr As MySqlDataReader
    Public di As New MySqlDataAdapter
    Public cmd As New MySqlCommand
    Public ds As New DataSet
    Public dt As DataTable
    Public qry As String
    Public img As String
End Module
