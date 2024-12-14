<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.storename = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.login_username = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.login_password = New System.Windows.Forms.TextBox()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SignUpForm = New System.Windows.Forms.LinkLabel()
        Me.loginshowpass = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.storename)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(920, 103)
        Me.Panel1.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Bisque
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(11, 12)
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
        Me.storename.Location = New System.Drawing.Point(310, 0)
        Me.storename.Name = "storename"
        Me.storename.Size = New System.Drawing.Size(327, 103)
        Me.storename.TabIndex = 5
        Me.storename.Text = "Log In"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel2.Location = New System.Drawing.Point(1, 734)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(920, 42)
        Me.Panel2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label2.Location = New System.Drawing.Point(136, 341)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 38)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label3.Location = New System.Drawing.Point(136, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 38)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Username:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.login_username)
        Me.Panel3.Location = New System.Drawing.Point(143, 250)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(609, 57)
        Me.Panel3.TabIndex = 4
        '
        'login_username
        '
        Me.login_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_username.Location = New System.Drawing.Point(3, 3)
        Me.login_username.Multiline = True
        Me.login_username.Name = "login_username"
        Me.login_username.Size = New System.Drawing.Size(606, 54)
        Me.login_username.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.login_password)
        Me.Panel4.Location = New System.Drawing.Point(143, 406)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(609, 57)
        Me.Panel4.TabIndex = 5
        '
        'login_password
        '
        Me.login_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_password.Location = New System.Drawing.Point(0, 0)
        Me.login_password.Multiline = True
        Me.login_password.Name = "login_password"
        Me.login_password.Size = New System.Drawing.Size(603, 57)
        Me.login_password.TabIndex = 0
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.Sienna
        Me.btnlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.Color.White
        Me.btnlogin.Location = New System.Drawing.Point(373, 559)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(171, 56)
        Me.btnlogin.TabIndex = 6
        Me.btnlogin.Text = "Log In"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Chocolate
        Me.Label4.Location = New System.Drawing.Point(358, 664)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(204, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Dont have an Account?"
        '
        'SignUpForm
        '
        Me.SignUpForm.AutoSize = True
        Me.SignUpForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignUpForm.LinkColor = System.Drawing.Color.Sienna
        Me.SignUpForm.Location = New System.Drawing.Point(422, 693)
        Me.SignUpForm.Name = "SignUpForm"
        Me.SignUpForm.Size = New System.Drawing.Size(89, 25)
        Me.SignUpForm.TabIndex = 8
        Me.SignUpForm.TabStop = True
        Me.SignUpForm.Text = "Sign Up"
        '
        'loginshowpass
        '
        Me.loginshowpass.AutoSize = True
        Me.loginshowpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginshowpass.ForeColor = System.Drawing.Color.SaddleBrown
        Me.loginshowpass.Location = New System.Drawing.Point(543, 499)
        Me.loginshowpass.Name = "loginshowpass"
        Me.loginshowpass.Size = New System.Drawing.Size(209, 33)
        Me.loginshowpass.TabIndex = 12
        Me.loginshowpass.Text = "Show Password"
        Me.loginshowpass.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 100)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(920, 638)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 53
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(921, 778)
        Me.Controls.Add(Me.loginshowpass)
        Me.Controls.Add(Me.SignUpForm)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents login_username As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents login_password As System.Windows.Forms.TextBox
    Friend WithEvents btnlogin As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SignUpForm As System.Windows.Forms.LinkLabel
    Friend WithEvents loginshowpass As System.Windows.Forms.CheckBox
    Friend WithEvents storename As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
