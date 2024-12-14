<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Boutique
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Boutique))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.storename = New System.Windows.Forms.Label()
        Me.pichome = New System.Windows.Forms.PictureBox()
        Me.picproducts = New System.Windows.Forms.PictureBox()
        Me.picinventory = New System.Windows.Forms.PictureBox()
        Me.piclogin = New System.Windows.Forms.PictureBox()
        Me.picsettings = New System.Windows.Forms.PictureBox()
        Me.picmintainance = New System.Windows.Forms.PictureBox()
        Me.picstocks = New System.Windows.Forms.PictureBox()
        Me.storebtnhome = New System.Windows.Forms.Button()
        Me.storebtnproduct = New System.Windows.Forms.Button()
        Me.storebtninventory = New System.Windows.Forms.Button()
        Me.storebtnstocks = New System.Windows.Forms.Button()
        Me.storebtnmaintenance = New System.Windows.Forms.Button()
        Me.storebtnsettings = New System.Windows.Forms.Button()
        Me.storebtnlogin = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.pichome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picproducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picinventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piclogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picsettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picmintainance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picstocks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.storename)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1525, 103)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Elephant", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Bisque
        Me.Label2.Location = New System.Drawing.Point(1299, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 38)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Boutique"
        '
        'storename
        '
        Me.storename.AutoSize = True
        Me.storename.Font = New System.Drawing.Font("Elephant", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.storename.ForeColor = System.Drawing.Color.Bisque
        Me.storename.Location = New System.Drawing.Point(395, 0)
        Me.storename.Name = "storename"
        Me.storename.Size = New System.Drawing.Size(861, 103)
        Me.storename.TabIndex = 2
        Me.storename.Text = "For Women By Me"
        '
        'pichome
        '
        Me.pichome.BackColor = System.Drawing.Color.White
        Me.pichome.Image = CType(resources.GetObject("pichome.Image"), System.Drawing.Image)
        Me.pichome.Location = New System.Drawing.Point(12, 128)
        Me.pichome.Name = "pichome"
        Me.pichome.Size = New System.Drawing.Size(65, 65)
        Me.pichome.TabIndex = 2
        Me.pichome.TabStop = False
        '
        'picproducts
        '
        Me.picproducts.BackColor = System.Drawing.Color.White
        Me.picproducts.Image = CType(resources.GetObject("picproducts.Image"), System.Drawing.Image)
        Me.picproducts.Location = New System.Drawing.Point(12, 210)
        Me.picproducts.Name = "picproducts"
        Me.picproducts.Size = New System.Drawing.Size(65, 65)
        Me.picproducts.TabIndex = 3
        Me.picproducts.TabStop = False
        '
        'picinventory
        '
        Me.picinventory.BackColor = System.Drawing.Color.White
        Me.picinventory.Image = CType(resources.GetObject("picinventory.Image"), System.Drawing.Image)
        Me.picinventory.Location = New System.Drawing.Point(12, 292)
        Me.picinventory.Name = "picinventory"
        Me.picinventory.Size = New System.Drawing.Size(65, 65)
        Me.picinventory.TabIndex = 4
        Me.picinventory.TabStop = False
        '
        'piclogin
        '
        Me.piclogin.BackColor = System.Drawing.Color.White
        Me.piclogin.Image = CType(resources.GetObject("piclogin.Image"), System.Drawing.Image)
        Me.piclogin.Location = New System.Drawing.Point(12, 621)
        Me.piclogin.Name = "piclogin"
        Me.piclogin.Size = New System.Drawing.Size(65, 65)
        Me.piclogin.TabIndex = 5
        Me.piclogin.TabStop = False
        '
        'picsettings
        '
        Me.picsettings.BackColor = System.Drawing.Color.White
        Me.picsettings.Image = CType(resources.GetObject("picsettings.Image"), System.Drawing.Image)
        Me.picsettings.Location = New System.Drawing.Point(12, 540)
        Me.picsettings.Name = "picsettings"
        Me.picsettings.Size = New System.Drawing.Size(65, 65)
        Me.picsettings.TabIndex = 6
        Me.picsettings.TabStop = False
        '
        'picmintainance
        '
        Me.picmintainance.BackColor = System.Drawing.Color.White
        Me.picmintainance.Image = CType(resources.GetObject("picmintainance.Image"), System.Drawing.Image)
        Me.picmintainance.Location = New System.Drawing.Point(12, 459)
        Me.picmintainance.Name = "picmintainance"
        Me.picmintainance.Size = New System.Drawing.Size(65, 65)
        Me.picmintainance.TabIndex = 7
        Me.picmintainance.TabStop = False
        '
        'picstocks
        '
        Me.picstocks.BackColor = System.Drawing.Color.White
        Me.picstocks.Image = CType(resources.GetObject("picstocks.Image"), System.Drawing.Image)
        Me.picstocks.Location = New System.Drawing.Point(12, 374)
        Me.picstocks.Name = "picstocks"
        Me.picstocks.Size = New System.Drawing.Size(65, 65)
        Me.picstocks.TabIndex = 8
        Me.picstocks.TabStop = False
        '
        'storebtnhome
        '
        Me.storebtnhome.BackColor = System.Drawing.Color.Bisque
        Me.storebtnhome.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.storebtnhome.ForeColor = System.Drawing.Color.Black
        Me.storebtnhome.Location = New System.Drawing.Point(90, 128)
        Me.storebtnhome.Name = "storebtnhome"
        Me.storebtnhome.Size = New System.Drawing.Size(266, 50)
        Me.storebtnhome.TabIndex = 14
        Me.storebtnhome.Text = "MainBoard"
        Me.storebtnhome.UseVisualStyleBackColor = False
        '
        'storebtnproduct
        '
        Me.storebtnproduct.BackColor = System.Drawing.Color.Bisque
        Me.storebtnproduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.storebtnproduct.ForeColor = System.Drawing.Color.Black
        Me.storebtnproduct.Location = New System.Drawing.Point(90, 210)
        Me.storebtnproduct.Name = "storebtnproduct"
        Me.storebtnproduct.Size = New System.Drawing.Size(266, 50)
        Me.storebtnproduct.TabIndex = 15
        Me.storebtnproduct.Text = "Products"
        Me.storebtnproduct.UseVisualStyleBackColor = False
        '
        'storebtninventory
        '
        Me.storebtninventory.BackColor = System.Drawing.Color.Bisque
        Me.storebtninventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.storebtninventory.ForeColor = System.Drawing.Color.Black
        Me.storebtninventory.Location = New System.Drawing.Point(90, 292)
        Me.storebtninventory.Name = "storebtninventory"
        Me.storebtninventory.Size = New System.Drawing.Size(266, 50)
        Me.storebtninventory.TabIndex = 16
        Me.storebtninventory.Text = "Inventory"
        Me.storebtninventory.UseVisualStyleBackColor = False
        '
        'storebtnstocks
        '
        Me.storebtnstocks.BackColor = System.Drawing.Color.Bisque
        Me.storebtnstocks.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.storebtnstocks.ForeColor = System.Drawing.Color.Black
        Me.storebtnstocks.Location = New System.Drawing.Point(90, 374)
        Me.storebtnstocks.Name = "storebtnstocks"
        Me.storebtnstocks.Size = New System.Drawing.Size(266, 50)
        Me.storebtnstocks.TabIndex = 17
        Me.storebtnstocks.Text = "Stocks"
        Me.storebtnstocks.UseVisualStyleBackColor = False
        '
        'storebtnmaintenance
        '
        Me.storebtnmaintenance.BackColor = System.Drawing.Color.Bisque
        Me.storebtnmaintenance.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.storebtnmaintenance.ForeColor = System.Drawing.Color.Black
        Me.storebtnmaintenance.Location = New System.Drawing.Point(90, 459)
        Me.storebtnmaintenance.Name = "storebtnmaintenance"
        Me.storebtnmaintenance.Size = New System.Drawing.Size(266, 50)
        Me.storebtnmaintenance.TabIndex = 18
        Me.storebtnmaintenance.Text = "Maintenance"
        Me.storebtnmaintenance.UseVisualStyleBackColor = False
        '
        'storebtnsettings
        '
        Me.storebtnsettings.BackColor = System.Drawing.Color.Bisque
        Me.storebtnsettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.storebtnsettings.ForeColor = System.Drawing.Color.Black
        Me.storebtnsettings.Location = New System.Drawing.Point(90, 540)
        Me.storebtnsettings.Name = "storebtnsettings"
        Me.storebtnsettings.Size = New System.Drawing.Size(266, 50)
        Me.storebtnsettings.TabIndex = 19
        Me.storebtnsettings.Text = "Settings"
        Me.storebtnsettings.UseVisualStyleBackColor = False
        '
        'storebtnlogin
        '
        Me.storebtnlogin.BackColor = System.Drawing.Color.Bisque
        Me.storebtnlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.storebtnlogin.ForeColor = System.Drawing.Color.Blue
        Me.storebtnlogin.Location = New System.Drawing.Point(90, 621)
        Me.storebtnlogin.Name = "storebtnlogin"
        Me.storebtnlogin.Size = New System.Drawing.Size(266, 50)
        Me.storebtnlogin.TabIndex = 20
        Me.storebtnlogin.Text = "Log-In"
        Me.storebtnlogin.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel2.Location = New System.Drawing.Point(371, 101)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(30, 631)
        Me.Panel2.TabIndex = 21
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel3.Location = New System.Drawing.Point(1, 729)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1524, 47)
        Me.Panel3.TabIndex = 22
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(396, 101)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1130, 631)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(432, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(955, 125)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Boutique
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(1527, 778)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.storebtnlogin)
        Me.Controls.Add(Me.storebtnsettings)
        Me.Controls.Add(Me.storebtnmaintenance)
        Me.Controls.Add(Me.storebtnstocks)
        Me.Controls.Add(Me.storebtninventory)
        Me.Controls.Add(Me.storebtnproduct)
        Me.Controls.Add(Me.storebtnhome)
        Me.Controls.Add(Me.picstocks)
        Me.Controls.Add(Me.picmintainance)
        Me.Controls.Add(Me.picsettings)
        Me.Controls.Add(Me.piclogin)
        Me.Controls.Add(Me.picinventory)
        Me.Controls.Add(Me.picproducts)
        Me.Controls.Add(Me.pichome)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Boutique"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pichome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picproducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picinventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piclogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picsettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picmintainance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picstocks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents storename As System.Windows.Forms.Label
    Friend WithEvents picproducts As System.Windows.Forms.PictureBox
    Friend WithEvents pichome As System.Windows.Forms.PictureBox
    Friend WithEvents picinventory As System.Windows.Forms.PictureBox
    Friend WithEvents piclogin As System.Windows.Forms.PictureBox
    Friend WithEvents picsettings As System.Windows.Forms.PictureBox
    Friend WithEvents picmintainance As System.Windows.Forms.PictureBox
    Friend WithEvents picstocks As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents storebtnhome As System.Windows.Forms.Button
    Friend WithEvents storebtnproduct As System.Windows.Forms.Button
    Friend WithEvents storebtninventory As System.Windows.Forms.Button
    Friend WithEvents storebtnstocks As System.Windows.Forms.Button
    Friend WithEvents storebtnmaintenance As System.Windows.Forms.Button
    Friend WithEvents storebtnsettings As System.Windows.Forms.Button
    Friend WithEvents storebtnlogin As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
