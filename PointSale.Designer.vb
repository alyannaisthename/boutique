<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PointSale
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.storename = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btntotal = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.pointsetquantity = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.pointtotalprice = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.pointamount = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.pointchange = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pointitemprice = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.pointproductname = New System.Windows.Forms.TextBox()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.pointproductcode = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.pointproductquantity = New System.Windows.Forms.TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(0, 735)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1531, 42)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Controls.Add(Me.storename)
        Me.Panel2.Location = New System.Drawing.Point(0, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1525, 103)
        Me.Panel2.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Bisque
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(12, 9)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(149, 56)
        Me.btnClose.TabIndex = 46
        Me.btnClose.Text = "Back"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'storename
        '
        Me.storename.AutoSize = True
        Me.storename.Font = New System.Drawing.Font("Elephant", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.storename.ForeColor = System.Drawing.Color.Bisque
        Me.storename.Location = New System.Drawing.Point(473, 0)
        Me.storename.Name = "storename"
        Me.storename.Size = New System.Drawing.Size(572, 103)
        Me.storename.TabIndex = 2
        Me.storename.Text = "Point of Sale"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Bisque
        Me.GroupBox1.Controls.Add(Me.btntotal)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Panel4)
        Me.GroupBox1.Controls.Add(Me.Panel5)
        Me.GroupBox1.Controls.Add(Me.Panel6)
        Me.GroupBox1.Controls.Add(Me.Panel7)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Location = New System.Drawing.Point(934, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Size = New System.Drawing.Size(590, 626)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'btntotal
        '
        Me.btntotal.BackColor = System.Drawing.Color.SaddleBrown
        Me.btntotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntotal.ForeColor = System.Drawing.Color.White
        Me.btntotal.Location = New System.Drawing.Point(146, 512)
        Me.btntotal.Name = "btntotal"
        Me.btntotal.Size = New System.Drawing.Size(324, 58)
        Me.btntotal.TabIndex = 31
        Me.btntotal.Text = "Check Total"
        Me.btntotal.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label5.Location = New System.Drawing.Point(21, 396)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 38)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Change:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label4.Location = New System.Drawing.Point(21, 302)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(253, 38)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Amt. Received:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label2.Location = New System.Drawing.Point(21, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(194, 38)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Total Price:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(21, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 38)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Set Quantity:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label3.Location = New System.Drawing.Point(21, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 38)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Item Price:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.pointsetquantity)
        Me.Panel4.Location = New System.Drawing.Point(304, 118)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(262, 57)
        Me.Panel4.TabIndex = 1
        '
        'pointsetquantity
        '
        Me.pointsetquantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pointsetquantity.Location = New System.Drawing.Point(0, 1)
        Me.pointsetquantity.Multiline = True
        Me.pointsetquantity.Name = "pointsetquantity"
        Me.pointsetquantity.Size = New System.Drawing.Size(261, 55)
        Me.pointsetquantity.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.pointtotalprice)
        Me.Panel5.Location = New System.Drawing.Point(304, 210)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(262, 57)
        Me.Panel5.TabIndex = 1
        '
        'pointtotalprice
        '
        Me.pointtotalprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pointtotalprice.Location = New System.Drawing.Point(1, 0)
        Me.pointtotalprice.Multiline = True
        Me.pointtotalprice.Name = "pointtotalprice"
        Me.pointtotalprice.Size = New System.Drawing.Size(260, 56)
        Me.pointtotalprice.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.pointamount)
        Me.Panel6.Location = New System.Drawing.Point(304, 300)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(262, 57)
        Me.Panel6.TabIndex = 1
        '
        'pointamount
        '
        Me.pointamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pointamount.Location = New System.Drawing.Point(0, 3)
        Me.pointamount.Multiline = True
        Me.pointamount.Name = "pointamount"
        Me.pointamount.Size = New System.Drawing.Size(260, 53)
        Me.pointamount.TabIndex = 0
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Controls.Add(Me.pointchange)
        Me.Panel7.Location = New System.Drawing.Point(304, 394)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(262, 57)
        Me.Panel7.TabIndex = 1
        '
        'pointchange
        '
        Me.pointchange.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pointchange.Location = New System.Drawing.Point(1, 1)
        Me.pointchange.Multiline = True
        Me.pointchange.Name = "pointchange"
        Me.pointchange.Size = New System.Drawing.Size(260, 55)
        Me.pointchange.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.pointitemprice)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Location = New System.Drawing.Point(304, 21)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(262, 57)
        Me.Panel3.TabIndex = 0
        '
        'pointitemprice
        '
        Me.pointitemprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pointitemprice.Location = New System.Drawing.Point(1, 1)
        Me.pointitemprice.Multiline = True
        Me.pointitemprice.Name = "pointitemprice"
        Me.pointitemprice.ReadOnly = True
        Me.pointitemprice.Size = New System.Drawing.Size(261, 55)
        Me.pointitemprice.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(0, 1)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(261, 55)
        Me.TextBox1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Bisque
        Me.GroupBox2.Controls.Add(Me.pointproductname)
        Me.GroupBox2.Controls.Add(Me.btnsearch)
        Me.GroupBox2.Controls.Add(Me.btncancel)
        Me.GroupBox2.Controls.Add(Me.btnadd)
        Me.GroupBox2.Controls.Add(Me.pointproductcode)
        Me.GroupBox2.Controls.Add(Me.Panel9)
        Me.GroupBox2.Controls.Add(Me.Panel8)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 109)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(931, 357)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'pointproductname
        '
        Me.pointproductname.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pointproductname.Location = New System.Drawing.Point(354, 97)
        Me.pointproductname.Multiline = True
        Me.pointproductname.Name = "pointproductname"
        Me.pointproductname.Size = New System.Drawing.Size(361, 55)
        Me.pointproductname.TabIndex = 40
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.Gray
        Me.btnsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.ForeColor = System.Drawing.Color.White
        Me.btnsearch.Location = New System.Drawing.Point(712, 96)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(153, 55)
        Me.btnsearch.TabIndex = 39
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.SaddleBrown
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.White
        Me.btncancel.Location = New System.Drawing.Point(621, 282)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(263, 57)
        Me.btncancel.TabIndex = 37
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.Color.White
        Me.btnadd.Location = New System.Drawing.Point(352, 282)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(263, 57)
        Me.btnadd.TabIndex = 36
        Me.btnadd.Text = "Add Item"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'pointproductcode
        '
        Me.pointproductcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pointproductcode.Location = New System.Drawing.Point(354, 21)
        Me.pointproductcode.Multiline = True
        Me.pointproductcode.Name = "pointproductcode"
        Me.pointproductcode.ReadOnly = True
        Me.pointproductcode.Size = New System.Drawing.Size(529, 55)
        Me.pointproductcode.TabIndex = 35
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.White
        Me.Panel9.Controls.Add(Me.pointproductquantity)
        Me.Panel9.Location = New System.Drawing.Point(354, 185)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(530, 54)
        Me.Panel9.TabIndex = 34
        '
        'pointproductquantity
        '
        Me.pointproductquantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pointproductquantity.Location = New System.Drawing.Point(2, 1)
        Me.pointproductquantity.Multiline = True
        Me.pointproductquantity.Name = "pointproductquantity"
        Me.pointproductquantity.ReadOnly = True
        Me.pointproductquantity.Size = New System.Drawing.Size(527, 52)
        Me.pointproductquantity.TabIndex = 0
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.Location = New System.Drawing.Point(354, 22)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(530, 54)
        Me.Panel8.TabIndex = 33
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label8.Location = New System.Drawing.Point(12, 185)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(298, 38)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Product Qty Avail:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label7.Location = New System.Drawing.Point(12, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(248, 38)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Product Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label6.Location = New System.Drawing.Point(12, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(239, 38)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Product Code:"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Bisque
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 475)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(928, 260)
        Me.DataGridView1.TabIndex = 5
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel10.Location = New System.Drawing.Point(934, 109)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(15, 626)
        Me.Panel10.TabIndex = 35
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Product ID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Product Name"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Quantity"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "Total Price"
        Me.Column4.Name = "Column4"
        '
        'PointSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SaddleBrown
        Me.ClientSize = New System.Drawing.Size(1527, 778)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "PointSale"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents storename As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btntotal As System.Windows.Forms.Button
    Friend WithEvents pointsetquantity As System.Windows.Forms.TextBox
    Friend WithEvents pointtotalprice As System.Windows.Forms.TextBox
    Friend WithEvents pointamount As System.Windows.Forms.TextBox
    Friend WithEvents pointchange As System.Windows.Forms.TextBox
    Friend WithEvents pointitemprice As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents pointproductcode As System.Windows.Forms.TextBox
    Friend WithEvents pointproductquantity As System.Windows.Forms.TextBox
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents pointproductname As System.Windows.Forms.TextBox
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
