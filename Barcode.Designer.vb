<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Barcode
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
        Me.picCamera = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnScanBarcode = New System.Windows.Forms.Button()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.btnCapture = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.picCamera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.storename)
        Me.Panel1.Location = New System.Drawing.Point(-191, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1333, 106)
        Me.Panel1.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Bisque
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(203, 12)
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
        Me.storename.Location = New System.Drawing.Point(404, 3)
        Me.storename.Name = "storename"
        Me.storename.Size = New System.Drawing.Size(769, 103)
        Me.storename.TabIndex = 3
        Me.storename.Text = "Barcode Scanner"
        '
        'picCamera
        '
        Me.picCamera.BackColor = System.Drawing.Color.Bisque
        Me.picCamera.Location = New System.Drawing.Point(3, 3)
        Me.picCamera.Name = "picCamera"
        Me.picCamera.Size = New System.Drawing.Size(441, 363)
        Me.picCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picCamera.TabIndex = 2
        Me.picCamera.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel2.Controls.Add(Me.picCamera)
        Me.Panel2.Location = New System.Drawing.Point(330, 222)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(447, 369)
        Me.Panel2.TabIndex = 3
        '
        'btnScanBarcode
        '
        Me.btnScanBarcode.BackColor = System.Drawing.Color.Sienna
        Me.btnScanBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScanBarcode.ForeColor = System.Drawing.Color.White
        Me.btnScanBarcode.Location = New System.Drawing.Point(389, 612)
        Me.btnScanBarcode.Name = "btnScanBarcode"
        Me.btnScanBarcode.Size = New System.Drawing.Size(334, 56)
        Me.btnScanBarcode.TabIndex = 15
        Me.btnScanBarcode.Text = "Turn on Camera"
        Me.btnScanBarcode.UseVisualStyleBackColor = False
        '
        'txtBarcode
        '
        Me.txtBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcode.Location = New System.Drawing.Point(271, 164)
        Me.txtBarcode.Multiline = True
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.ReadOnly = True
        Me.txtBarcode.Size = New System.Drawing.Size(562, 39)
        Me.txtBarcode.TabIndex = 16
        '
        'btnCapture
        '
        Me.btnCapture.BackColor = System.Drawing.Color.Sienna
        Me.btnCapture.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapture.ForeColor = System.Drawing.Color.White
        Me.btnCapture.Location = New System.Drawing.Point(410, 687)
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.Size = New System.Drawing.Size(280, 56)
        Me.btnCapture.TabIndex = 17
        Me.btnCapture.Text = "Scan Barcode"
        Me.btnCapture.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Elephant", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(264, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 38)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Scanned Barcode:"
        '
        'Barcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(1145, 772)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCapture)
        Me.Controls.Add(Me.btnScanBarcode)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Barcode"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picCamera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents picCamera As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnScanBarcode As System.Windows.Forms.Button
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents btnCapture As System.Windows.Forms.Button
    Friend WithEvents storename As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
