<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Details
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
        Me.storename = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblid = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.lblpassword = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel1.Controls.Add(Me.storename)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(553, 119)
        Me.Panel1.TabIndex = 0
        '
        'storename
        '
        Me.storename.AutoSize = True
        Me.storename.Font = New System.Drawing.Font("Elephant", 45.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.storename.ForeColor = System.Drawing.Color.Bisque
        Me.storename.Location = New System.Drawing.Point(3, 9)
        Me.storename.Name = "storename"
        Me.storename.Size = New System.Drawing.Size(542, 97)
        Me.storename.TabIndex = 5
        Me.storename.Text = "Crendentials"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label3.Location = New System.Drawing.Point(23, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 36)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label2.Location = New System.Drawing.Point(23, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 36)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label4.Location = New System.Drawing.Point(23, 283)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 36)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Username:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label5.Location = New System.Drawing.Point(23, 349)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 36)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Password:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label6.Location = New System.Drawing.Point(26, 413)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(209, 36)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Date Created:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label7.Location = New System.Drawing.Point(26, 478)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(212, 36)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Time Created:"
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.BackColor = System.Drawing.Color.Transparent
        Me.lblid.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblid.Location = New System.Drawing.Point(119, 145)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(86, 36)
        Me.lblid.TabIndex = 12
        Me.lblid.Text = "none"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.BackColor = System.Drawing.Color.Transparent
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblname.Location = New System.Drawing.Point(152, 215)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(86, 36)
        Me.lblname.TabIndex = 13
        Me.lblname.Text = "none"
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.BackColor = System.Drawing.Color.Transparent
        Me.lblusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblusername.Location = New System.Drawing.Point(196, 283)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(86, 36)
        Me.lblusername.TabIndex = 14
        Me.lblusername.Text = "none"
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.BackColor = System.Drawing.Color.Transparent
        Me.lblpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpassword.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblpassword.Location = New System.Drawing.Point(196, 349)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(86, 36)
        Me.lblpassword.TabIndex = 15
        Me.lblpassword.Text = "none"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.BackColor = System.Drawing.Color.Transparent
        Me.lbldate.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lbldate.Location = New System.Drawing.Point(255, 413)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(86, 36)
        Me.lbldate.TabIndex = 16
        Me.lbldate.Text = "none"
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.BackColor = System.Drawing.Color.Transparent
        Me.lbltime.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lbltime.Location = New System.Drawing.Point(255, 478)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(86, 36)
        Me.lbltime.TabIndex = 17
        Me.lbltime.Text = "none"
        '
        'Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(551, 630)
        Me.Controls.Add(Me.lbltime)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.lblpassword)
        Me.Controls.Add(Me.lblusername)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Details"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents lblusername As System.Windows.Forms.Label
    Friend WithEvents lblpassword As System.Windows.Forms.Label
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents lbltime As System.Windows.Forms.Label
    Friend WithEvents storename As System.Windows.Forms.Label
End Class
