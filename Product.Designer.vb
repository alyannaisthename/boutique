<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Product
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.storename = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.prodproductid = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.prodproductname = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.proddescription = New System.Windows.Forms.TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.prodproductcode = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.prodprice = New System.Windows.Forms.TextBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.prodproductquantity = New System.Windows.Forms.TextBox()
        Me.comboxavailability = New System.Windows.Forms.ComboBox()
        Me.comboxproducttype = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodbtnsave = New System.Windows.Forms.Button()
        Me.prodbtncancel = New System.Windows.Forms.Button()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Scan = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.storename)
        Me.Panel1.Location = New System.Drawing.Point(0, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1525, 103)
        Me.Panel1.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Bisque
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(12, 10)
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
        Me.storename.Location = New System.Drawing.Point(423, 0)
        Me.storename.Name = "storename"
        Me.storename.Size = New System.Drawing.Size(735, 103)
        Me.storename.TabIndex = 5
        Me.storename.Text = "Product Settings"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel3.Location = New System.Drawing.Point(1, 730)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1524, 47)
        Me.Panel3.TabIndex = 23
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel2.Location = New System.Drawing.Point(600, 101)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(30, 631)
        Me.Panel2.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label3.Location = New System.Drawing.Point(12, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 32)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Product ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(12, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 32)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Product Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label2.Location = New System.Drawing.Point(12, 262)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 32)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Product Type:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label4.Location = New System.Drawing.Point(12, 338)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 32)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Description:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label5.Location = New System.Drawing.Point(12, 415)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(209, 32)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Product Code:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label6.Location = New System.Drawing.Point(12, 492)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 32)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Price:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label7.Location = New System.Drawing.Point(12, 569)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(252, 32)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Product Quantity:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label8.Location = New System.Drawing.Point(16, 644)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(174, 32)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Availability:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.prodproductid)
        Me.Panel4.Location = New System.Drawing.Point(18, 143)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(562, 39)
        Me.Panel4.TabIndex = 33
        '
        'prodproductid
        '
        Me.prodproductid.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prodproductid.Location = New System.Drawing.Point(0, 0)
        Me.prodproductid.Multiline = True
        Me.prodproductid.Name = "prodproductid"
        Me.prodproductid.ReadOnly = True
        Me.prodproductid.Size = New System.Drawing.Size(562, 39)
        Me.prodproductid.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.prodproductname)
        Me.Panel5.Location = New System.Drawing.Point(18, 220)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(562, 39)
        Me.Panel5.TabIndex = 34
        '
        'prodproductname
        '
        Me.prodproductname.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prodproductname.Location = New System.Drawing.Point(0, 0)
        Me.prodproductname.Multiline = True
        Me.prodproductname.Name = "prodproductname"
        Me.prodproductname.Size = New System.Drawing.Size(562, 39)
        Me.prodproductname.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Controls.Add(Me.proddescription)
        Me.Panel7.Location = New System.Drawing.Point(18, 373)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(562, 39)
        Me.Panel7.TabIndex = 34
        '
        'proddescription
        '
        Me.proddescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.proddescription.Location = New System.Drawing.Point(0, 0)
        Me.proddescription.Multiline = True
        Me.proddescription.Name = "proddescription"
        Me.proddescription.Size = New System.Drawing.Size(562, 39)
        Me.proddescription.TabIndex = 1
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.Controls.Add(Me.prodproductcode)
        Me.Panel8.Location = New System.Drawing.Point(18, 450)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(372, 39)
        Me.Panel8.TabIndex = 36
        '
        'prodproductcode
        '
        Me.prodproductcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prodproductcode.Location = New System.Drawing.Point(0, 0)
        Me.prodproductcode.Multiline = True
        Me.prodproductcode.Name = "prodproductcode"
        Me.prodproductcode.Size = New System.Drawing.Size(370, 39)
        Me.prodproductcode.TabIndex = 1
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.White
        Me.Panel9.Controls.Add(Me.prodprice)
        Me.Panel9.Location = New System.Drawing.Point(18, 527)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(562, 39)
        Me.Panel9.TabIndex = 37
        '
        'prodprice
        '
        Me.prodprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prodprice.Location = New System.Drawing.Point(0, 0)
        Me.prodprice.Multiline = True
        Me.prodprice.Name = "prodprice"
        Me.prodprice.Size = New System.Drawing.Size(562, 39)
        Me.prodprice.TabIndex = 1
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.White
        Me.Panel10.Controls.Add(Me.prodproductquantity)
        Me.Panel10.Location = New System.Drawing.Point(18, 602)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(562, 39)
        Me.Panel10.TabIndex = 38
        '
        'prodproductquantity
        '
        Me.prodproductquantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prodproductquantity.Location = New System.Drawing.Point(0, 0)
        Me.prodproductquantity.Multiline = True
        Me.prodproductquantity.Name = "prodproductquantity"
        Me.prodproductquantity.Size = New System.Drawing.Size(562, 39)
        Me.prodproductquantity.TabIndex = 1
        '
        'comboxavailability
        '
        Me.comboxavailability.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboxavailability.FormattingEnabled = True
        Me.comboxavailability.Items.AddRange(New Object() {"Available", "Unavailable"})
        Me.comboxavailability.Location = New System.Drawing.Point(0, -1)
        Me.comboxavailability.Name = "comboxavailability"
        Me.comboxavailability.Size = New System.Drawing.Size(562, 37)
        Me.comboxavailability.TabIndex = 1
        '
        'comboxproducttype
        '
        Me.comboxproducttype.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboxproducttype.FormattingEnabled = True
        Me.comboxproducttype.Items.AddRange(New Object() {"Dress", "Top", "Short", "Skirt", "T-Shirt", "Shoes", "Sandals", "Heels"})
        Me.comboxproducttype.Location = New System.Drawing.Point(0, 0)
        Me.comboxproducttype.Name = "comboxproducttype"
        Me.comboxproducttype.Size = New System.Drawing.Size(562, 37)
        Me.comboxproducttype.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.SaddleBrown
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.DataGridView1.Location = New System.Drawing.Point(637, 115)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(878, 525)
        Me.DataGridView1.TabIndex = 39
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
        Me.Column3.HeaderText = "Product Type"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "Description"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "Product Code"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "Price"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column7.HeaderText = "Product Quantity"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column8.HeaderText = "Availability"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column9.HeaderText = "DateIn"
        Me.Column9.Name = "Column9"
        '
        'prodbtnsave
        '
        Me.prodbtnsave.BackColor = System.Drawing.Color.Sienna
        Me.prodbtnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prodbtnsave.ForeColor = System.Drawing.Color.White
        Me.prodbtnsave.Location = New System.Drawing.Point(738, 646)
        Me.prodbtnsave.Name = "prodbtnsave"
        Me.prodbtnsave.Size = New System.Drawing.Size(280, 56)
        Me.prodbtnsave.TabIndex = 14
        Me.prodbtnsave.Text = "Save"
        Me.prodbtnsave.UseVisualStyleBackColor = False
        '
        'prodbtncancel
        '
        Me.prodbtncancel.BackColor = System.Drawing.Color.Sienna
        Me.prodbtncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prodbtncancel.ForeColor = System.Drawing.Color.White
        Me.prodbtncancel.Location = New System.Drawing.Point(1131, 644)
        Me.prodbtncancel.Name = "prodbtncancel"
        Me.prodbtncancel.Size = New System.Drawing.Size(280, 56)
        Me.prodbtncancel.TabIndex = 40
        Me.prodbtncancel.Text = "Cancel"
        Me.prodbtncancel.UseVisualStyleBackColor = False
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.White
        Me.Panel11.Controls.Add(Me.comboxavailability)
        Me.Panel11.Location = New System.Drawing.Point(22, 679)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(562, 39)
        Me.Panel11.TabIndex = 34
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.comboxproducttype)
        Me.Panel6.Location = New System.Drawing.Point(18, 296)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(562, 39)
        Me.Panel6.TabIndex = 35
        '
        'Scan
        '
        Me.Scan.BackColor = System.Drawing.Color.Sienna
        Me.Scan.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Scan.ForeColor = System.Drawing.Color.White
        Me.Scan.Location = New System.Drawing.Point(398, 437)
        Me.Scan.Name = "Scan"
        Me.Scan.Size = New System.Drawing.Size(186, 54)
        Me.Scan.TabIndex = 41
        Me.Scan.Text = "Scan"
        Me.Scan.UseVisualStyleBackColor = False
        '
        'Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(1527, 778)
        Me.Controls.Add(Me.Scan)
        Me.Controls.Add(Me.prodbtncancel)
        Me.Controls.Add(Me.prodbtnsave)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Product"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents prodproductid As System.Windows.Forms.TextBox
    Friend WithEvents prodproductname As System.Windows.Forms.TextBox
    Friend WithEvents proddescription As System.Windows.Forms.TextBox
    Friend WithEvents prodproductcode As System.Windows.Forms.TextBox
    Friend WithEvents prodprice As System.Windows.Forms.TextBox
    Friend WithEvents prodproductquantity As System.Windows.Forms.TextBox
    Friend WithEvents comboxavailability As System.Windows.Forms.ComboBox
    Friend WithEvents comboxproducttype As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents prodbtnsave As System.Windows.Forms.Button
    Friend WithEvents prodbtncancel As System.Windows.Forms.Button
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Scan As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents storename As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
