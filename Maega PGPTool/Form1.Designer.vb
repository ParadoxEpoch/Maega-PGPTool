<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnSelectGenerate = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnSelectEncrypt = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnSelectDecrypt = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.tabControlMain = New MaterialSkin.Controls.MaterialTabControl()
        Me.tabHome = New System.Windows.Forms.TabPage()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.tabGenerate = New System.Windows.Forms.TabPage()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.txtGeneratePass = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtGenerateUser = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.tabEncrypt = New System.Windows.Forms.TabPage()
        Me.cmbSaved = New System.Windows.Forms.ComboBox()
        Me.tabDecrypt = New System.Windows.Forms.TabPage()
        Me.tabSettings = New System.Windows.Forms.TabPage()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialCheckBox1 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialSingleLineTextField1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.btnBrowsePrivate1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnBrowsePublic1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.txtPrivateKey1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtPublicKey1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.tabControlMain.SuspendLayout()
        Me.tabHome.SuspendLayout()
        Me.tabGenerate.SuspendLayout()
        Me.tabEncrypt.SuspendLayout()
        Me.tabSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSelectGenerate
        '
        Me.btnSelectGenerate.Depth = 0
        Me.btnSelectGenerate.Location = New System.Drawing.Point(188, 181)
        Me.btnSelectGenerate.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSelectGenerate.Name = "btnSelectGenerate"
        Me.btnSelectGenerate.Primary = True
        Me.btnSelectGenerate.Size = New System.Drawing.Size(175, 34)
        Me.btnSelectGenerate.TabIndex = 0
        Me.btnSelectGenerate.Text = "Generate PGP Keys"
        Me.btnSelectGenerate.UseVisualStyleBackColor = True
        '
        'btnSelectEncrypt
        '
        Me.btnSelectEncrypt.Depth = 0
        Me.btnSelectEncrypt.Location = New System.Drawing.Point(389, 181)
        Me.btnSelectEncrypt.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSelectEncrypt.Name = "btnSelectEncrypt"
        Me.btnSelectEncrypt.Primary = True
        Me.btnSelectEncrypt.Size = New System.Drawing.Size(175, 34)
        Me.btnSelectEncrypt.TabIndex = 1
        Me.btnSelectEncrypt.Text = "Encrypt a Message"
        Me.btnSelectEncrypt.UseVisualStyleBackColor = True
        '
        'btnSelectDecrypt
        '
        Me.btnSelectDecrypt.Depth = 0
        Me.btnSelectDecrypt.Location = New System.Drawing.Point(583, 181)
        Me.btnSelectDecrypt.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSelectDecrypt.Name = "btnSelectDecrypt"
        Me.btnSelectDecrypt.Primary = True
        Me.btnSelectDecrypt.Size = New System.Drawing.Size(175, 34)
        Me.btnSelectDecrypt.TabIndex = 2
        Me.btnSelectDecrypt.Text = "Decrypt a Message"
        Me.btnSelectDecrypt.UseVisualStyleBackColor = True
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.tabControlMain
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(0, 64)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(980, 40)
        Me.MaterialTabSelector1.TabIndex = 3
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'tabControlMain
        '
        Me.tabControlMain.Controls.Add(Me.tabHome)
        Me.tabControlMain.Controls.Add(Me.tabGenerate)
        Me.tabControlMain.Controls.Add(Me.tabEncrypt)
        Me.tabControlMain.Controls.Add(Me.tabDecrypt)
        Me.tabControlMain.Controls.Add(Me.tabSettings)
        Me.tabControlMain.Depth = 0
        Me.tabControlMain.Location = New System.Drawing.Point(3, 110)
        Me.tabControlMain.MouseState = MaterialSkin.MouseState.HOVER
        Me.tabControlMain.Name = "tabControlMain"
        Me.tabControlMain.SelectedIndex = 0
        Me.tabControlMain.Size = New System.Drawing.Size(978, 422)
        Me.tabControlMain.TabIndex = 4
        '
        'tabHome
        '
        Me.tabHome.Controls.Add(Me.MaterialLabel1)
        Me.tabHome.Controls.Add(Me.btnSelectGenerate)
        Me.tabHome.Controls.Add(Me.btnSelectEncrypt)
        Me.tabHome.Controls.Add(Me.btnSelectDecrypt)
        Me.tabHome.Location = New System.Drawing.Point(4, 22)
        Me.tabHome.Name = "tabHome"
        Me.tabHome.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHome.Size = New System.Drawing.Size(970, 396)
        Me.tabHome.TabIndex = 0
        Me.tabHome.Text = "Home"
        Me.tabHome.UseVisualStyleBackColor = True
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(367, 117)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(230, 19)
        Me.MaterialLabel1.TabIndex = 3
        Me.MaterialLabel1.Text = "What would you like to do today?"
        '
        'tabGenerate
        '
        Me.tabGenerate.BackColor = System.Drawing.Color.White
        Me.tabGenerate.Controls.Add(Me.MaterialRaisedButton1)
        Me.tabGenerate.Controls.Add(Me.txtGeneratePass)
        Me.tabGenerate.Controls.Add(Me.txtGenerateUser)
        Me.tabGenerate.Location = New System.Drawing.Point(4, 22)
        Me.tabGenerate.Name = "tabGenerate"
        Me.tabGenerate.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGenerate.Size = New System.Drawing.Size(970, 396)
        Me.tabGenerate.TabIndex = 1
        Me.tabGenerate.Text = "Generate"
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(383, 227)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(179, 32)
        Me.MaterialRaisedButton1.TabIndex = 2
        Me.MaterialRaisedButton1.Text = "Generate"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'txtGeneratePass
        '
        Me.txtGeneratePass.Depth = 0
        Me.txtGeneratePass.Hint = ""
        Me.txtGeneratePass.Location = New System.Drawing.Point(360, 171)
        Me.txtGeneratePass.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtGeneratePass.Name = "txtGeneratePass"
        Me.txtGeneratePass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGeneratePass.SelectedText = ""
        Me.txtGeneratePass.SelectionLength = 0
        Me.txtGeneratePass.SelectionStart = 0
        Me.txtGeneratePass.Size = New System.Drawing.Size(226, 23)
        Me.txtGeneratePass.TabIndex = 1
        Me.txtGeneratePass.Text = "Password"
        Me.txtGeneratePass.UseSystemPasswordChar = False
        '
        'txtGenerateUser
        '
        Me.txtGenerateUser.Depth = 0
        Me.txtGenerateUser.Hint = ""
        Me.txtGenerateUser.Location = New System.Drawing.Point(360, 126)
        Me.txtGenerateUser.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtGenerateUser.Name = "txtGenerateUser"
        Me.txtGenerateUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGenerateUser.SelectedText = ""
        Me.txtGenerateUser.SelectionLength = 0
        Me.txtGenerateUser.SelectionStart = 0
        Me.txtGenerateUser.Size = New System.Drawing.Size(226, 23)
        Me.txtGenerateUser.TabIndex = 0
        Me.txtGenerateUser.Text = "Username"
        Me.txtGenerateUser.UseSystemPasswordChar = False
        '
        'tabEncrypt
        '
        Me.tabEncrypt.Controls.Add(Me.cmbSaved)
        Me.tabEncrypt.Location = New System.Drawing.Point(4, 22)
        Me.tabEncrypt.Name = "tabEncrypt"
        Me.tabEncrypt.Size = New System.Drawing.Size(970, 396)
        Me.tabEncrypt.TabIndex = 2
        Me.tabEncrypt.Text = "Encrypt"
        Me.tabEncrypt.UseVisualStyleBackColor = True
        '
        'cmbSaved
        '
        Me.cmbSaved.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSaved.FormattingEnabled = True
        Me.cmbSaved.Items.AddRange(New Object() {"Do not use a saved Key Pair"})
        Me.cmbSaved.Location = New System.Drawing.Point(335, 230)
        Me.cmbSaved.Name = "cmbSaved"
        Me.cmbSaved.Size = New System.Drawing.Size(268, 21)
        Me.cmbSaved.TabIndex = 0
        '
        'tabDecrypt
        '
        Me.tabDecrypt.Location = New System.Drawing.Point(4, 22)
        Me.tabDecrypt.Name = "tabDecrypt"
        Me.tabDecrypt.Size = New System.Drawing.Size(970, 396)
        Me.tabDecrypt.TabIndex = 3
        Me.tabDecrypt.Text = "Decrypt"
        Me.tabDecrypt.UseVisualStyleBackColor = True
        '
        'tabSettings
        '
        Me.tabSettings.BackColor = System.Drawing.Color.White
        Me.tabSettings.Controls.Add(Me.MaterialLabel5)
        Me.tabSettings.Controls.Add(Me.MaterialCheckBox1)
        Me.tabSettings.Controls.Add(Me.MaterialLabel4)
        Me.tabSettings.Controls.Add(Me.MaterialSingleLineTextField1)
        Me.tabSettings.Controls.Add(Me.MaterialLabel3)
        Me.tabSettings.Controls.Add(Me.MaterialLabel2)
        Me.tabSettings.Controls.Add(Me.btnBrowsePrivate1)
        Me.tabSettings.Controls.Add(Me.btnBrowsePublic1)
        Me.tabSettings.Controls.Add(Me.txtPrivateKey1)
        Me.tabSettings.Controls.Add(Me.txtPublicKey1)
        Me.tabSettings.Location = New System.Drawing.Point(4, 22)
        Me.tabSettings.Name = "tabSettings"
        Me.tabSettings.Size = New System.Drawing.Size(970, 396)
        Me.tabSettings.TabIndex = 4
        Me.tabSettings.Text = "Settings"
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(314, 187)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(62, 19)
        Me.MaterialLabel5.TabIndex = 9
        Me.MaterialLabel5.Text = "Enabled"
        '
        'MaterialCheckBox1
        '
        Me.MaterialCheckBox1.AutoSize = True
        Me.MaterialCheckBox1.Depth = 0
        Me.MaterialCheckBox1.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialCheckBox1.Location = New System.Drawing.Point(387, 183)
        Me.MaterialCheckBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckBox1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckBox1.Name = "MaterialCheckBox1"
        Me.MaterialCheckBox1.Ripple = True
        Me.MaterialCheckBox1.Size = New System.Drawing.Size(26, 30)
        Me.MaterialCheckBox1.TabIndex = 8
        Me.MaterialCheckBox1.UseVisualStyleBackColor = True
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(212, 70)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(164, 19)
        Me.MaterialLabel4.TabIndex = 7
        Me.MaterialLabel4.Text = "Save Key Pair #1 Name"
        '
        'MaterialSingleLineTextField1
        '
        Me.MaterialSingleLineTextField1.Depth = 0
        Me.MaterialSingleLineTextField1.Hint = ""
        Me.MaterialSingleLineTextField1.Location = New System.Drawing.Point(392, 66)
        Me.MaterialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField1.Name = "MaterialSingleLineTextField1"
        Me.MaterialSingleLineTextField1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField1.SelectedText = ""
        Me.MaterialSingleLineTextField1.SelectionLength = 0
        Me.MaterialSingleLineTextField1.SelectionStart = 0
        Me.MaterialSingleLineTextField1.Size = New System.Drawing.Size(290, 23)
        Me.MaterialSingleLineTextField1.TabIndex = 6
        Me.MaterialSingleLineTextField1.Text = "My Key Pair"
        Me.MaterialSingleLineTextField1.UseSystemPasswordChar = False
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(228, 149)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(148, 19)
        Me.MaterialLabel3.TabIndex = 5
        Me.MaterialLabel3.Text = "Saved Private Key #1"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(233, 108)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(143, 19)
        Me.MaterialLabel2.TabIndex = 4
        Me.MaterialLabel2.Text = "Saved Public Key #1"
        '
        'btnBrowsePrivate1
        '
        Me.btnBrowsePrivate1.Depth = 0
        Me.btnBrowsePrivate1.Location = New System.Drawing.Point(699, 145)
        Me.btnBrowsePrivate1.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnBrowsePrivate1.Name = "btnBrowsePrivate1"
        Me.btnBrowsePrivate1.Primary = True
        Me.btnBrowsePrivate1.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowsePrivate1.TabIndex = 3
        Me.btnBrowsePrivate1.Text = "Browse"
        Me.btnBrowsePrivate1.UseVisualStyleBackColor = True
        '
        'btnBrowsePublic1
        '
        Me.btnBrowsePublic1.Depth = 0
        Me.btnBrowsePublic1.Location = New System.Drawing.Point(699, 104)
        Me.btnBrowsePublic1.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnBrowsePublic1.Name = "btnBrowsePublic1"
        Me.btnBrowsePublic1.Primary = True
        Me.btnBrowsePublic1.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowsePublic1.TabIndex = 2
        Me.btnBrowsePublic1.Text = "Browse"
        Me.btnBrowsePublic1.UseVisualStyleBackColor = True
        '
        'txtPrivateKey1
        '
        Me.txtPrivateKey1.Depth = 0
        Me.txtPrivateKey1.Enabled = False
        Me.txtPrivateKey1.Hint = ""
        Me.txtPrivateKey1.Location = New System.Drawing.Point(392, 145)
        Me.txtPrivateKey1.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtPrivateKey1.Name = "txtPrivateKey1"
        Me.txtPrivateKey1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrivateKey1.SelectedText = ""
        Me.txtPrivateKey1.SelectionLength = 0
        Me.txtPrivateKey1.SelectionStart = 0
        Me.txtPrivateKey1.Size = New System.Drawing.Size(290, 23)
        Me.txtPrivateKey1.TabIndex = 1
        Me.txtPrivateKey1.UseSystemPasswordChar = False
        '
        'txtPublicKey1
        '
        Me.txtPublicKey1.Depth = 0
        Me.txtPublicKey1.Enabled = False
        Me.txtPublicKey1.Hint = ""
        Me.txtPublicKey1.Location = New System.Drawing.Point(392, 104)
        Me.txtPublicKey1.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtPublicKey1.Name = "txtPublicKey1"
        Me.txtPublicKey1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPublicKey1.SelectedText = ""
        Me.txtPublicKey1.SelectionLength = 0
        Me.txtPublicKey1.SelectionStart = 0
        Me.txtPublicKey1.Size = New System.Drawing.Size(290, 23)
        Me.txtPublicKey1.TabIndex = 0
        Me.txtPublicKey1.UseSystemPasswordChar = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(980, 538)
        Me.Controls.Add(Me.tabControlMain)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maega PGPTool"
        Me.tabControlMain.ResumeLayout(False)
        Me.tabHome.ResumeLayout(False)
        Me.tabHome.PerformLayout()
        Me.tabGenerate.ResumeLayout(False)
        Me.tabEncrypt.ResumeLayout(False)
        Me.tabSettings.ResumeLayout(False)
        Me.tabSettings.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSelectGenerate As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnSelectEncrypt As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnSelectDecrypt As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents tabControlMain As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents tabHome As TabPage
    Friend WithEvents tabGenerate As TabPage
    Friend WithEvents tabEncrypt As TabPage
    Friend WithEvents tabDecrypt As TabPage
    Friend WithEvents tabSettings As TabPage
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents txtGeneratePass As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtGenerateUser As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnBrowsePrivate1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnBrowsePublic1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents txtPrivateKey1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtPublicKey1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialSingleLineTextField1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialCheckBox1 As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents cmbSaved As ComboBox
End Class
