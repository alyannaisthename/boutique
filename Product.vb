Imports System.Data.DataTable
Imports MySql.Data.MySqlClient


Public Class Product
    Dim index As New Integer

    Public Sub formyid()
        Dim createId = ""

        connstring = "SELECT * FROM products_tbl WHERE product_id = '" & "NOID" & "' "
        sqlconnection.Open()
        cmd = New MySqlCommand(connstring, sqlconnection)
        dr = cmd.ExecuteReader
        If dr.Read Then
            prodproductid.Text = "ProdID-00" & dr("id").ToString
        Else
            createId = "create"
        End If

        sqlconnection.Close()
        If createId = "create" Then
            makeid()
        End If

    End Sub

    Public Sub makeid()
        connstring = "INSERT INTO products_tbl (product_id) VALUES ('" & "NOID" & "') "

        sqlconnection.Open()
        di = New MySqlDataAdapter(connstring, sqlconnection)
        di.Fill(ds)
        sqlconnection.Close()
        formyid()
    End Sub

    Public Sub DataView()
        Try
            connstring = "SELECT * FROM products_tbl WHERE product_id <> '" & "NOID" & "'"
            sqlconnection.Open()
            cmd = New MySqlCommand(connstring, sqlconnection)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            DataGridView1.Rows.Clear()

            While dr.Read()
                DataGridView1.Rows.Add(dr("product_id"), dr("product_name"), dr("product_type"), dr("description"), dr("product_code"), dr("product_price"), dr("product_quantity"), dr("availability"), dr("datein"))
            End While

            dr.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If sqlconnection.State = ConnectionState.Open Then
                sqlconnection.Close()
            End If
        End Try

    End Sub

    Private Sub ProductSettings_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Shown
        prodproductname.Focus()
        DataView()
        formyid()
        'PopulateProductTypes()
        PopulateAvailability()
    End Sub

    Private Sub prodbtnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prodbtnsave.Click
        If prodbtnsave.Text = "Save" Then
            If prodproductid.Text = "" Then
                MsgBox("Product ID is required", MsgBoxStyle.Exclamation, "Product Settings Form")
                prodproductid.Focus()
                Return
            ElseIf prodproductname.Text = "" Then
                MsgBox("Product Name is required", MsgBoxStyle.Exclamation, "Product Settings Form")
                prodproductname.Focus()
                Return
            ElseIf comboxproducttype.Text = "" Then
                MsgBox("Product Type is required", MsgBoxStyle.Exclamation, "Product Settings Form")
                comboxproducttype.Focus()
                Return
            ElseIf proddescription.Text = "" Then
                MsgBox("Product Description is required", MsgBoxStyle.Exclamation, "Product Settings Form")
                proddescription.Focus()
                Return
            ElseIf prodproductcode.Text = "" Then
                MsgBox("Product Code is required", MsgBoxStyle.Exclamation, "Product Settings Form")
                prodproductcode.Focus()
                Return
            ElseIf prodprice.Text = "" Then
                MsgBox("Product Price is required", MsgBoxStyle.Exclamation, "Product Settings Form")
                prodprice.Focus()
                Return
            ElseIf prodproductquantity.Text = "" Then
                MsgBox("Product Quantity is required", MsgBoxStyle.Exclamation, "Product Settings Form")
                prodproductquantity.Focus()
                Return
            ElseIf comboxavailability.Text = "" Then
                MsgBox("Product Availability is required", MsgBoxStyle.Exclamation, "Product Settings Form")
                comboxavailability.Focus()
                Return
            Else
                'Dim dateout As String = If(txtprodquan.Text = "0" Or cboxavailability.Text = "Out of Stock", Date.Now.ToString("yyyy-MM-dd"), "NULL")

                MsgBox("Saved Successfully", MsgBoxStyle.Information, "Product Settings Form")

                connstring = "UPDATE products_tbl SET product_id = '" & prodproductid.Text & "', product_name = '" & prodproductname.Text & "', product_type = '" & _
                                comboxproducttype.Text & "', description = '" & proddescription.Text & "', product_code = '" & _
                                prodproductcode.Text & "', product_price = '" & prodprice.Text & "', product_quantity = '" & _
                                prodproductquantity.Text & "', availability = '" & comboxavailability.Text & "', product_left = '" & prodproductquantity.Text & "', datein = '" & Date.Now.ToString("yyyy-MM-dd") & "' WHERE product_id = '" & "NOID" & "'"

                cmd = New MySqlCommand(connstring, sqlconnection)
                sqlconnection.Open()
                cmd.ExecuteNonQuery()
                sqlconnection.Close()

                ClearInputs()
                DataView()
                formyid()

                prodproductname.Focus()
            End If
        Else
            Dim newData As DataGridViewRow = DataGridView1.Rows(index)

            If prodproductid.Text = "" Then
                MsgBox("Product ID is required", MsgBoxStyle.Exclamation, "Product Settings Form")
                prodproductid.Focus()
                Return
            ElseIf prodproductname.Text = "" Then
                MsgBox("Product Name is required", MsgBoxStyle.Exclamation, "Product Settings Form")
                prodproductname.Focus()
                Return
            ElseIf comboxproducttype.Text = "" Then
                MsgBox("Product Type is required", MsgBoxStyle.Exclamation, "Product Settings Form")
                comboxproducttype.Focus()
                Return
            ElseIf proddescription.Text = "" Then
                MsgBox("Product Description is required", MsgBoxStyle.Exclamation, "Product Settings Form")
                proddescription.Focus()
                Return
            ElseIf prodproductcode.Text = "" Then
                MsgBox("Product Code is required", MsgBoxStyle.Exclamation, "Product Settings Form")
                prodproductcode.Focus()
                Return
            ElseIf prodprice.Text = "" Then
                MsgBox("Product Price is required", MsgBoxStyle.Exclamation, "Product Settings Form")
                prodprice.Focus()
                Return
            ElseIf prodproductquantity.Text = "" Then
                MsgBox("Product Quantity is required", MsgBoxStyle.Exclamation, "Product Settings Form")
                prodproductquantity.Focus()
                Return
            ElseIf comboxavailability.Text = "" Then
                MsgBox("Product Availability is required", MsgBoxStyle.Exclamation, "Product Settings Form")
                comboxavailability.Focus()
                Return
            Else
                'Dim dateout As String = If(txtprodquan.Text = "0" Or cboxavailability.Text = "Out of Stock", Date.Now.ToString("yyyy-MM-dd"), "NULL")

                MsgBox("Updated Successfully", MsgBoxStyle.Information, "Product Settings Form")

                qry = "UPDATE products_tbl SET product_id = '" & prodproductid.Text & "', product_name = '" & prodproductname.Text & "', product_type = '" &
                      comboxproducttype.Text & "', description = '" & proddescription.Text & "', product_code = '" &
                      prodproductcode.Text & "', product_price = '" & prodprice.Text & "', product_quantity = '" &
                      prodproductquantity.Text & "', availability = '" & comboxavailability.Text & "', product_left = '" & prodproductquantity.Text & "', datein = '" & Date.Now.ToString("yyyy-MM-dd") & "' WHERE product_id = '" &
                      prodproductid.Text & "'"

                cmd = New MySqlCommand(qry, sqlconnection)
                sqlconnection.Open()
                cmd.ExecuteNonQuery()
                sqlconnection.Close()

                ClearInputs()
                prodbtnsave.Text = "Save"
                DataView()
                formyid()

                prodproductname.Focus()
            End If
        End If
    End Sub

    Private Sub ClearInputs()
        prodproductid.Text = ""
        prodproductname.Text = ""
        proddescription.Text = ""
        prodproductcode.Text = ""
        prodprice.Text = ""
        prodproductquantity.Text = ""
        comboxavailability.SelectedIndex = -1
        prodproductid.Focus()
        comboxproducttype.SelectedIndex = -1
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        index = e.RowIndex

        prodproductid.Text = DataGridView1.Rows(index).Cells(0).Value
        prodproductname.Text = DataGridView1.Rows(index).Cells(1).Value
        comboxproducttype.Text = DataGridView1.Rows(index).Cells(2).Value
        proddescription.Text = DataGridView1.Rows(index).Cells(3).Value
        prodproductcode.Text = DataGridView1.Rows(index).Cells(4).Value
        prodprice.Text = DataGridView1.Rows(index).Cells(5).Value
        prodproductquantity.Text = DataGridView1.Rows(index).Cells(6).Value
        comboxavailability.Text = DataGridView1.Rows(index).Cells(7).Value


        comboxproducttype.ForeColor = Color.Black
        prodbtnsave.Text = "Update"
    End Sub

    Private Sub prodbtncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prodbtncancel.Click
        ClearInputs()
        DataView()
        formyid()
        prodproductname.Focus()
        prodbtnsave.Text = "Save"
    End Sub
    Private Sub PopulateAvailability()
        comboxavailability.Items.Clear()
        comboxavailability.Items.Add("Available")
        comboxavailability.Items.Add("Unavailable")

        comboxavailability.SelectedIndex = -1
    End Sub

    Private Sub ProductSettingsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    ' This method handles when the user clicks the scan button in the Product form
    Private Sub Scan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Scan.Click
        Barcode.Show()
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