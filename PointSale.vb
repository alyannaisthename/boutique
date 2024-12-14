Imports MySql.Data.MySqlClient

Public Class PointSale
    Dim index As New Integer

    Public Sub verifyProductName()
        Try
            Dim sqlconnection As New MySqlConnection("Server=localhost;userid=root;password=;database=boutique_db")
            sqlconnection.Open()
            Dim query As String = "SELECT * FROM products_tbl WHERE product_name = '" & pointproductname.Text & "'"
            Dim cmd As New MySqlCommand(query, sqlconnection)
            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            If dr.Read() Then
                ' Calculate the available stock
                Dim productQuantity As Integer = Val(dr("product_quantity"))
                Dim quantitySold As Integer = Val(dr("quantity_sold"))
                Dim productLeft As Integer = productQuantity - quantitySold

                ' If no stock is left, display "Out of Stock"
                If productLeft <= 0 Then
                    pointproductquantity.Text = "Out of Stock"
                    Dim sqlconnection2 As New MySqlConnection("Server=localhost;userid=root;password=;database=boutique_db")
                    sqlconnection2.Open()
                    Dim query2 As String = "UPDATE products_tbl SET availability='Out of Stock', dateout = '" & Date.Now.ToString("yyyy-MM-dd") & "' WHERE product_code='" & dr("product_code").ToString() & "'"
                    Dim cmd2 As New MySqlCommand(query2, sqlconnection2)
                    cmd2.ExecuteNonQuery()

                    'dateSoldOut()

                    sqlconnection2.Close()

                    ' Prevent adding out-of-stock products
                    MsgBox("This product is out of stock and cannot be added.", MsgBoxStyle.Exclamation, "Product Availability")
                    btnadd.Enabled = False
                Else
                    ' Display the available quantity
                    pointproductquantity.Text = productLeft.ToString()
                    btnadd.Enabled = True
                End If

                pointproductcode.Text = dr("product_code").ToString()
                pointitemprice.Text = dr("product_price").ToString()
            Else
                MsgBox("Product not found", MsgBoxStyle.Exclamation, "Main Dashboard Message")
                pointproductname.Text = ""
                pointproductname.Focus()
            End If

            sqlconnection.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try
    End Sub



    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        If pointproductname.Text = "" Then
            MsgBox("Product Name Required", MsgBoxStyle.Exclamation, "Main Dashboard Message")
        Else
            verifyProductName()
        End If
    End Sub

    Private Sub PointOfSale_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        pointproductname.Focus()
        pointitemprice.Text = "0"
        pointsetquantity.Text = "0"
        pointtotalprice.Text = "0"
        pointamount.Text = "0"
        pointchange.Text = "0"
        btntotal.Text = "Check Total"
        DataGridView1.Rows.Clear()

        If Not DataGridView1.Columns.Contains("DeleteColumn") Then
            Dim deleteColumn As New DataGridViewButtonColumn()
            deleteColumn.HeaderText = "More Action"
            deleteColumn.Name = "DeleteColumn"
            deleteColumn.Text = "Delete"
            deleteColumn.UseColumnTextForButtonValue = True
            DataGridView1.Columns.Add(deleteColumn)
        End If
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        pointproductcode.Text = ""
        pointproductname.Text = ""
        pointproductquantity.Text = ""
        pointitemprice.Text = "0"
        pointsetquantity.Text = "0"
        pointtotalprice.Text = "0"
        pointamount.Text = "0"
        pointchange.Text = "0"
        btntotal.Text = "Check Total"
        btnadd.Enabled = True
    End Sub

    Private Sub pointsetquantity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pointsetquantity.Click
        pointsetquantity.Text = ""
    End Sub

    Private Sub pointamount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pointamount.Click
        pointamount.Text = ""
    End Sub

    Private Sub calculateTotalPrice()
        If Val(pointsetquantity.Text) > 0 And Val(pointitemprice.Text) > 0 Then
            pointtotalprice.Text = (Val(pointsetquantity.Text) * Val(pointitemprice.Text)).ToString("0.00")
        End If
    End Sub


    Private Sub pointsetquantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pointsetquantity.TextChanged
        If pointsetquantity.Text = "" Or Val(pointsetquantity.Text) <= 0 Then
            pointtotalprice.Text = "0"
        Else
            calculateTotalPrice()
        End If
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If pointproductname.Text = "" Then
            MsgBox("Product Name Required", MsgBoxStyle.Exclamation, "Main Dashboard Message")
            pointproductname.Focus()
        ElseIf pointsetquantity.Text = "" Or Val(pointsetquantity.Text) <= 0 Then
            MsgBox("Set the quantity of the item purchased", MsgBoxStyle.Exclamation, "Main Dashboard Message")
            pointsetquantity.Focus()
        Else
            Dim totalItemPrice As Decimal = Val(pointsetquantity.Text) * Val(pointitemprice.Text)
            pointtotalprice.Text = totalItemPrice.ToString("0.00")

            ' Add row to DataGridView
            DataGridView1.Rows.Add(
                pointproductcode.Text,
                pointproductname.Text,
                pointsetquantity.Text,
                totalItemPrice.ToString("0.00"))

            ' Clear input fields
            pointproductcode.Text = ""
            pointproductname.Text = ""
            pointproductquantity.Text = ""
            pointitemprice.Text = "0"
            pointsetquantity.Text = "0"
            pointtotalprice.Text = "0"
            pointamount.Text = "0"
            pointchange.Text = "0"

            pointproductname.Focus()
        End If
    End Sub


    Private Sub pointamount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pointamount.TextChanged
        If Val(pointamount.Text) = 0 Then
            pointchange.Text = "0"
        Else
            calculateChange()
        End If
    End Sub

    Private Sub calculateChange()
        If Val(pointamount.Text) > 0 Then
            Dim total As Decimal = 0
            For Each row As DataGridViewRow In DataGridView1.Rows
                total += Val(row.Cells("Column4").Value)
            Next
            pointchange.Text = (Val(pointamount.Text) - total).ToString("0.00")
        End If
    End Sub

    Private Sub btntotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntotal.Click
        If btntotal.Text = "Check Total" Then
            Dim total As Decimal = 0
            For Each row As DataGridViewRow In DataGridView1.Rows
                If Not row.IsNewRow Then
                    total += Val(row.Cells("Column4").Value)
                End If
            Next

            If total > 0 Then
                pointtotalprice.Text = total.ToString("0.00")
                btntotal.Text = "Check Out"
            Else
                MessageBox.Show("No items to calculate.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        ElseIf btntotal.Text = "Check Out" Then
            ' Ensure the entered amount is valid
            If String.IsNullOrWhiteSpace(pointamount.Text) Or Val(pointamount.Text) <= 0 Then
                MsgBox("Please enter a valid amount before checking out.", MsgBoxStyle.Exclamation, "Main Dashboard Message")
                pointamount.Focus()
                Return
            End If

            ' Check if the entered amount is sufficient to cover the total price
            Dim totalPrice As Decimal = Val(pointtotalprice.Text)
            Dim enteredAmount As Decimal = Val(pointamount.Text)

            If enteredAmount < totalPrice Then
                MsgBox("Insufficient amount. Please enter an sufficient amount.", MsgBoxStyle.Exclamation, "Checkout Error")
                pointamount.Focus()
                Return
            End If

            Try
                Dim sqlconnection As New MySqlConnection("Server=localhost;userid=root;password=;database=boutique_db")
                sqlconnection.Open()

                ' After Check Total logic and validation
                For Each row As DataGridViewRow In DataGridView1.Rows
                    If Not row.IsNewRow Then
                        Dim productCode As String = row.Cells("Column1").Value.ToString()
                        Dim quantitySold As Integer = Val(row.Cells("Column3").Value)

                        ' Update quantity_sold
                        Dim query As String = "UPDATE products_tbl SET quantity_sold = quantity_sold + @quantity WHERE product_code = @productCode"
                        Using cmd As New MySqlCommand(query, sqlconnection)
                            cmd.Parameters.AddWithValue("@quantity", quantitySold)
                            cmd.Parameters.AddWithValue("@productCode", productCode)
                            cmd.ExecuteNonQuery()
                        End Using

                        ' Update product left
                        UpdateProductLeft(productCode)

                        ' Fetch updated stock values to determine stock status
                        Dim checkStockQuery As String = "SELECT product_quantity, quantity_sold FROM products_tbl WHERE product_code = @productCode"
                        Using cmdCheck As New MySqlCommand(checkStockQuery, sqlconnection)
                            cmdCheck.Parameters.AddWithValue("@productCode", productCode)
                            Dim dr As MySqlDataReader = cmdCheck.ExecuteReader()

                            If dr.Read() Then
                                Dim remainingStock As Integer = Val(dr("product_quantity")) - Val(dr("quantity_sold"))
                                dr.Close()

                                ' Mark product as sold out if no stock remains
                                If remainingStock <= 0 Then
                                    Dim updateAvailabilityQuery As String = "UPDATE products_tbl SET availability = 'Out of Stock' WHERE product_code = @productCode"
                                    Using cmdUpdate As New MySqlCommand(updateAvailabilityQuery, sqlconnection)
                                        cmdUpdate.Parameters.AddWithValue("@productCode", productCode)
                                        cmdUpdate.ExecuteNonQuery()
                                    End Using
                                End If
                            Else
                                dr.Close()
                            End If
                        End Using
                    End If
                Next

                ' Update dateSoldOut and total sales
                dateSoldOut()



                sqlconnection.Close()

                ' Clear DataGridView after successful checkout
                DataGridView1.Rows.Clear()
                pointtotalprice.Text = "0"
                pointamount.Text = "0"
                pointchange.Text = "0"
                btntotal.Text = "Check Total"
                MessageBox.Show("Check out successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MsgBox("Error during checkout: " & ex.Message, MsgBoxStyle.Critical, "Checkout Error")
            End Try

        End If

    End Sub
    Private Sub UpdateProductLeft(ByVal productCode As String)
        Try
            Dim sqlconnection As New MySqlConnection("Server=localhost;userid=root;password=;database=boutique_db")
            sqlconnection.Open()

            Dim updateQuery As String = "UPDATE products_tbl SET product_left = product_quantity - quantity_sold WHERE product_code = @productCode"
            Dim cmd As New MySqlCommand(updateQuery, sqlconnection)
            cmd.Parameters.AddWithValue("@productCode", productCode)
            cmd.ExecuteNonQuery()

            sqlconnection.Close()
        Catch ex As Exception
            MsgBox("Error updating product left: " & ex.Message, MsgBoxStyle.Critical, "Update Error")
        End Try
    End Sub




    Private Sub DataGridView1_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = DataGridView1.Columns("DeleteColumn").Index Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                DataGridView1.Rows.RemoveAt(e.RowIndex)
            End If

        End If
    End Sub

    Public Sub dateSoldOut()
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                Dim prodcode As String = row.Cells("Column1").Value.ToString()

                Using sqlconnection As New MySqlConnection("Server=localhost;userid=root;password=;database=boutique_db")
                    sqlconnection.Open()

                    ' Fetch the product's current state
                    Dim query As String = "SELECT product_quantity, quantity_sold, product_price FROM products_tbl WHERE product_code = @productCode"
                    Using cmd As New MySqlCommand(query, sqlconnection)
                        cmd.Parameters.AddWithValue("@productCode", prodcode)
                        Dim dr As MySqlDataReader = cmd.ExecuteReader()

                        If dr.Read() Then
                            Dim prodqty As Integer = Val(dr("product_quantity"))
                            Dim prodsold As Integer = Val(dr("quantity_sold"))
                            Dim totalProductSales As Decimal = prodsold * Val(dr("product_price"))

                            dr.Close() ' Close reader before issuing updates

                            ' If sold equals stock, mark as sold out and set dateout
                            If prodsold >= prodqty Then
                                Dim updateQuery As String = "UPDATE products_tbl SET dateout = @dateOut, total_product_sale = @totalSales WHERE product_code = @productCode"
                                Using updateCmd As New MySqlCommand(updateQuery, sqlconnection)
                                    updateCmd.Parameters.AddWithValue("@dateOut", Date.Now.ToString("yyyy-MM-dd"))
                                    updateCmd.Parameters.AddWithValue("@totalSales", totalProductSales)
                                    updateCmd.Parameters.AddWithValue("@productCode", prodcode)
                                    updateCmd.ExecuteNonQuery()
                                End Using
                            Else
                                ' Otherwise, just update the total sales
                                Dim updateSalesQuery As String = "UPDATE products_tbl SET total_product_sale = @totalSales WHERE product_code = @productCode"
                                Using updateSalesCmd As New MySqlCommand(updateSalesQuery, sqlconnection)
                                    updateSalesCmd.Parameters.AddWithValue("@totalSales", totalProductSales)
                                    updateSalesCmd.Parameters.AddWithValue("@productCode", prodcode)
                                    updateSalesCmd.ExecuteNonQuery()
                                End Using
                            End If
                        End If
                    End Using
                End Using
            End If
        Next
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