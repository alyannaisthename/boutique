Imports MySql.Data.MySqlClient

Public Class Stocks
    Private searchPlaceholder As String = "Search product..."
    Private placeholderColor As Color = Color.Gray
    Private normalTextColor As Color = Color.Black
    Private connstring As String = "Server=localhost;userid=root;password=;database=boutique_db"
    Private sqlconnection As New MySqlConnection(connstring)

    Private Sub Stocks_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        txtsearch.Focus()
        SetSearchPlaceholder(txtsearch)
        StocksDataView()
    End Sub

    Public Sub StocksDataView()
        Dim qry As String = "SELECT * FROM products_tbl WHERE product_id <> 'NOID'"
        Using sqlconnection As New MySqlConnection(connstring)
            Try
                sqlconnection.Open()
                Using cmd As New MySqlCommand(qry, sqlconnection)
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        DataGridView1.Rows.Clear()
                        While dr.Read()
                            DataGridView1.Rows.Add(dr("product_id"), dr("product_code"), dr("product_name"), dr("product_quantity"), dr("quantity_sold"), dr("product_left"), dr("availability"))
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        Dim qry As String = "SELECT * FROM products_tbl WHERE product_name LIKE @searchTerm AND product_id <> 'NOID'"
        Using sqlconnection As New MySqlConnection(connstring)
            Try
                sqlconnection.Open()
                Using cmd As New MySqlCommand(qry, sqlconnection)
                    cmd.Parameters.AddWithValue("@searchTerm", "%" & txtsearch.Text & "%")
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        DataGridView1.Rows.Clear()
                        While dr.Read()
                            DataGridView1.Rows.Add(dr("product_id"), dr("product_code"), dr("product_name"), dr("product_quantity"), dr("quantity_sold"), dr("product_left"), dr("availability"))
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub txtsearch_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.Enter
        If txtsearch.Text = searchPlaceholder Then
            txtsearch.Text = ""
            txtsearch.ForeColor = normalTextColor
        End If
    End Sub

    Private Sub txtsearch_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsearch.Leave
        SetSearchPlaceholder(txtsearch)
    End Sub

    Private Sub SetSearchPlaceholder(ByVal txt As TextBox)
        If String.IsNullOrWhiteSpace(txt.Text) Then
            txt.Text = searchPlaceholder
            txt.ForeColor = placeholderColor
        End If
    End Sub

    Private Sub txtsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.Click
        If txtsearch.Text = searchPlaceholder Then
            txtsearch.Text = ""
            txtsearch.ForeColor = normalTextColor
        End If
    End Sub

    Private Sub txtsearch_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtsearch.Validating
        If String.IsNullOrWhiteSpace(txtsearch.Text) Then
            SetSearchPlaceholder(txtsearch)
        End If
    End Sub

    Private Sub CloseForm_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class