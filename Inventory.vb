Imports MySql.Data.MySqlClient

Public Class Inventory
    Public Sub InventoryDataView()
        Try
            connstring = "SELECT * FROM products_tbl WHERE product_id <> '" & "NOID" & "'"
            sqlconnection.Open()
            cmd = New MySqlCommand(connstring, sqlconnection)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            DataGridView1.Rows.Clear()
            Do While dr.Read()
                DataGridView1.Rows.Add(dr("product_id"), dr("product_name"), dr("product_price"), dr("datein"), dr("product_quantity"), dr("dateout"), dr("quantity_sold"), dr("product_left"), dr("total_product_sale"), dr("availability"))
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                dr.Close()
            End If
            sqlconnection.Close()
        End Try
    End Sub

    Public Sub TotalProductSale()
        Dim price = ""
        Dim pSold = ""
        Dim TotalProductSale = ""

        connstring = "SELECT * FROM products_tbl WHERE product_id <> '" & "NOID" & "'"
        sqlconnection.Open()
        cmd = New MySqlCommand(connstring, sqlconnection)
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            price = dr("product_price").ToString()
            pSold = dr("quantity_sold").ToString()
            TotalProductSale = price * pSold
        End If
        sqlconnection.Close()

        connstring = "UPDATE products_tbl SET quantity_sold = '" & TotalProductSale & "' WHERE product_id <> '" & "NOID" & "'"
        Dim di As New MySqlDataAdapter(connstring, sqlconnection)
        di.Fill(ds)
        sqlconnection.Close()
    End Sub

    Private Sub Inventory_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        InventoryDataView()
    End Sub

    Private Sub txtsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.Click
        If txtsearch.Text = "Search Product.." Then
            txtsearch.Text = ""
            txtsearch.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        If txtsearch.Text <> "" Or txtsearch.Text = "Search Product.." Then

            qry = "SELECT * FROM products_tbl WHERE product_name LIKE'%" & txtsearch.Text & "%' AND product_id <> '" & "NOID" & "'"
            sqlconnection.Open()
            cmd = New MySqlCommand(qry, sqlconnection)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            DataGridView1.Rows.Clear()
            Do While (dr.Read() = True)
                DataGridView1.Rows.Add(dr("product_id"), dr("product_name"), dr("product_price"), dr("datein"), dr("product_quantity"), dr("dateout"), dr("quantity_sold"), dr("product_left"), dr("total_product_sale"), dr("availability"))
            Loop
            sqlconnection.Close()
        Else
            qry = "SELECT * FROM products_tbl WHERE product_name LIKE'%" & txtsearch.Text & "%' AND product_id <> '" & "NOID" & "'"
            sqlconnection.Open()
            cmd = New MySqlCommand(qry, sqlconnection)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            DataGridView1.Rows.Clear()
            Do While (dr.Read() = True)
                DataGridView1.Rows.Add(dr("product_id"), dr("product_name"), dr("product_price"), dr("datein"), dr("product_quantity"), dr("dateout"), dr("quantity_sold"), dr("product_left"), dr("total_product_sale"), dr("availability"))
            Loop
            sqlconnection.Close()
        End If
    End Sub

    Private Sub txtsearch_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtsearch.Validating
        If txtsearch.Text = "" Then
            txtsearch.Text = "Search Product.."
            txtsearch.ForeColor = Color.Gray
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