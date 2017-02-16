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
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.tabGenerate = New System.Windows.Forms.TabPage()
        Me.txtGenerateConfirm = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtGeneratedPrivate = New System.Windows.Forms.TextBox()
        Me.txtGeneratedPublic = New System.Windows.Forms.TextBox()
        Me.btnGenerate = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.txtGeneratePass = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtGenerateUser = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.tabEncrypt = New System.Windows.Forms.TabPage()
        Me.MaterialLabel11 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtEncryptFile = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.radEncryptFile = New MaterialSkin.Controls.MaterialRadioButton()
        Me.btnEncrypt = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.radEncryptPasteMessage = New MaterialSkin.Controls.MaterialRadioButton()
        Me.pnlEncryptPublicKey = New System.Windows.Forms.Panel()
        Me.radEncryptPasteKey = New MaterialSkin.Controls.MaterialRadioButton()
        Me.radEncryptKeyFile = New MaterialSkin.Controls.MaterialRadioButton()
        Me.txtEncryptKeyFile = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtEncryptPasteKey = New System.Windows.Forms.TextBox()
        Me.MaterialLabel9 = New MaterialSkin.Controls.MaterialLabel()
        Me.cmbPublicSaved = New System.Windows.Forms.ComboBox()
        Me.txtEncryptPasteMessage = New System.Windows.Forms.TextBox()
        Me.tabDecrypt = New System.Windows.Forms.TabPage()
        Me.MaterialLabel12 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtDecryptFile = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.radDecryptFile = New MaterialSkin.Controls.MaterialRadioButton()
        Me.btnDecrypt = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.radDecryptPasteMessage = New MaterialSkin.Controls.MaterialRadioButton()
        Me.pnlDecryptPrivateKey = New System.Windows.Forms.Panel()
        Me.txtKeyPassphrase = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.radDecryptPasteKey = New MaterialSkin.Controls.MaterialRadioButton()
        Me.radDecryptKeyFile = New MaterialSkin.Controls.MaterialRadioButton()
        Me.txtDecryptKeyFile = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtDecryptPasteKey = New System.Windows.Forms.TextBox()
        Me.MaterialLabel8 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtDecryptPasteMessage = New System.Windows.Forms.TextBox()
        Me.cmbPrivateSaved = New System.Windows.Forms.ComboBox()
        Me.tabSettings = New System.Windows.Forms.TabPage()
        Me.btnClearPrivate3 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.btnBrowsePrivate3 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.txtPrivate3Path = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btnClearPrivate2 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.btnBrowsePrivate2 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.txtPrivate2Path = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialRaisedButton5 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnClearPublic3 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.btnBrowsePublic3 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.txtPublic3Path = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btnClearPublic2 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.btnBrowsePublic2 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.txtPublic2Path = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btnClearPrivate1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnClearPublic1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.btnBrowsePrivate1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnBrowsePublic1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.txtPrivate1Path = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtPublic1Path = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.tabControlMain.SuspendLayout()
        Me.tabHome.SuspendLayout()
        Me.tabGenerate.SuspendLayout()
        Me.tabEncrypt.SuspendLayout()
        Me.pnlEncryptPublicKey.SuspendLayout()
        Me.tabDecrypt.SuspendLayout()
        Me.pnlDecryptPrivateKey.SuspendLayout()
        Me.tabSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSelectGenerate
        '
        Me.btnSelectGenerate.Depth = 0
        Me.btnSelectGenerate.Location = New System.Drawing.Point(245, 245)
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
        Me.btnSelectEncrypt.Location = New System.Drawing.Point(446, 245)
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
        Me.btnSelectDecrypt.Location = New System.Drawing.Point(640, 245)
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
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(1080, 40)
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
        Me.tabControlMain.Size = New System.Drawing.Size(1074, 532)
        Me.tabControlMain.TabIndex = 4
        '
        'tabHome
        '
        Me.tabHome.Controls.Add(Me.LinkLabel1)
        Me.tabHome.Controls.Add(Me.MaterialLabel1)
        Me.tabHome.Controls.Add(Me.btnSelectGenerate)
        Me.tabHome.Controls.Add(Me.btnSelectEncrypt)
        Me.tabHome.Controls.Add(Me.btnSelectDecrypt)
        Me.tabHome.Location = New System.Drawing.Point(4, 22)
        Me.tabHome.Name = "tabHome"
        Me.tabHome.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHome.Size = New System.Drawing.Size(1066, 506)
        Me.tabHome.TabIndex = 0
        Me.tabHome.Text = "Home"
        Me.tabHome.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(0, 492)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(1066, 23)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Maega, 2017"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(424, 181)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(230, 19)
        Me.MaterialLabel1.TabIndex = 3
        Me.MaterialLabel1.Text = "What would you like to do today?"
        '
        'tabGenerate
        '
        Me.tabGenerate.BackColor = System.Drawing.Color.White
        Me.tabGenerate.Controls.Add(Me.txtGenerateConfirm)
        Me.tabGenerate.Controls.Add(Me.txtGeneratedPrivate)
        Me.tabGenerate.Controls.Add(Me.txtGeneratedPublic)
        Me.tabGenerate.Controls.Add(Me.btnGenerate)
        Me.tabGenerate.Controls.Add(Me.txtGeneratePass)
        Me.tabGenerate.Controls.Add(Me.txtGenerateUser)
        Me.tabGenerate.Location = New System.Drawing.Point(4, 22)
        Me.tabGenerate.Name = "tabGenerate"
        Me.tabGenerate.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGenerate.Size = New System.Drawing.Size(1066, 506)
        Me.tabGenerate.TabIndex = 1
        Me.tabGenerate.Text = "Generate"
        '
        'txtGenerateConfirm
        '
        Me.txtGenerateConfirm.Depth = 0
        Me.txtGenerateConfirm.Hint = ""
        Me.txtGenerateConfirm.Location = New System.Drawing.Point(681, 38)
        Me.txtGenerateConfirm.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtGenerateConfirm.Name = "txtGenerateConfirm"
        Me.txtGenerateConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGenerateConfirm.SelectedText = ""
        Me.txtGenerateConfirm.SelectionLength = 0
        Me.txtGenerateConfirm.SelectionStart = 0
        Me.txtGenerateConfirm.Size = New System.Drawing.Size(226, 23)
        Me.txtGenerateConfirm.TabIndex = 5
        Me.txtGenerateConfirm.Text = "Confirm Passphrase"
        Me.txtGenerateConfirm.UseSystemPasswordChar = False
        '
        'txtGeneratedPrivate
        '
        Me.txtGeneratedPrivate.Location = New System.Drawing.Point(540, 148)
        Me.txtGeneratedPrivate.Multiline = True
        Me.txtGeneratedPrivate.Name = "txtGeneratedPrivate"
        Me.txtGeneratedPrivate.ReadOnly = True
        Me.txtGeneratedPrivate.Size = New System.Drawing.Size(520, 373)
        Me.txtGeneratedPrivate.TabIndex = 4
        '
        'txtGeneratedPublic
        '
        Me.txtGeneratedPublic.Location = New System.Drawing.Point(6, 148)
        Me.txtGeneratedPublic.Multiline = True
        Me.txtGeneratedPublic.Name = "txtGeneratedPublic"
        Me.txtGeneratedPublic.ReadOnly = True
        Me.txtGeneratedPublic.Size = New System.Drawing.Size(520, 373)
        Me.txtGeneratedPublic.TabIndex = 3
        '
        'btnGenerate
        '
        Me.btnGenerate.Depth = 0
        Me.btnGenerate.Location = New System.Drawing.Point(446, 79)
        Me.btnGenerate.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Primary = True
        Me.btnGenerate.Size = New System.Drawing.Size(179, 32)
        Me.btnGenerate.TabIndex = 2
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'txtGeneratePass
        '
        Me.txtGeneratePass.Depth = 0
        Me.txtGeneratePass.Hint = ""
        Me.txtGeneratePass.Location = New System.Drawing.Point(436, 38)
        Me.txtGeneratePass.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtGeneratePass.Name = "txtGeneratePass"
        Me.txtGeneratePass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGeneratePass.SelectedText = ""
        Me.txtGeneratePass.SelectionLength = 0
        Me.txtGeneratePass.SelectionStart = 0
        Me.txtGeneratePass.Size = New System.Drawing.Size(226, 23)
        Me.txtGeneratePass.TabIndex = 1
        Me.txtGeneratePass.Text = "Passphrase"
        Me.txtGeneratePass.UseSystemPasswordChar = False
        '
        'txtGenerateUser
        '
        Me.txtGenerateUser.Depth = 0
        Me.txtGenerateUser.Hint = ""
        Me.txtGenerateUser.Location = New System.Drawing.Point(192, 38)
        Me.txtGenerateUser.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtGenerateUser.Name = "txtGenerateUser"
        Me.txtGenerateUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGenerateUser.SelectedText = ""
        Me.txtGenerateUser.SelectionLength = 0
        Me.txtGenerateUser.SelectionStart = 0
        Me.txtGenerateUser.Size = New System.Drawing.Size(226, 23)
        Me.txtGenerateUser.TabIndex = 0
        Me.txtGenerateUser.Text = "Email Address (Optional)"
        Me.txtGenerateUser.UseSystemPasswordChar = False
        '
        'tabEncrypt
        '
        Me.tabEncrypt.BackColor = System.Drawing.Color.White
        Me.tabEncrypt.Controls.Add(Me.MaterialLabel11)
        Me.tabEncrypt.Controls.Add(Me.txtEncryptFile)
        Me.tabEncrypt.Controls.Add(Me.radEncryptFile)
        Me.tabEncrypt.Controls.Add(Me.btnEncrypt)
        Me.tabEncrypt.Controls.Add(Me.radEncryptPasteMessage)
        Me.tabEncrypt.Controls.Add(Me.pnlEncryptPublicKey)
        Me.tabEncrypt.Controls.Add(Me.MaterialLabel9)
        Me.tabEncrypt.Controls.Add(Me.cmbPublicSaved)
        Me.tabEncrypt.Controls.Add(Me.txtEncryptPasteMessage)
        Me.tabEncrypt.Location = New System.Drawing.Point(4, 22)
        Me.tabEncrypt.Name = "tabEncrypt"
        Me.tabEncrypt.Size = New System.Drawing.Size(1066, 506)
        Me.tabEncrypt.TabIndex = 2
        Me.tabEncrypt.Text = "Encrypt"
        '
        'MaterialLabel11
        '
        Me.MaterialLabel11.AutoSize = True
        Me.MaterialLabel11.Depth = 0
        Me.MaterialLabel11.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel11.Location = New System.Drawing.Point(153, 24)
        Me.MaterialLabel11.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel11.Name = "MaterialLabel11"
        Me.MaterialLabel11.Size = New System.Drawing.Size(188, 19)
        Me.MaterialLabel11.TabIndex = 11
        Me.MaterialLabel11.Text = "File or Message to Encrypt"
        '
        'txtEncryptFile
        '
        Me.txtEncryptFile.Depth = 0
        Me.txtEncryptFile.Enabled = False
        Me.txtEncryptFile.Hint = ""
        Me.txtEncryptFile.Location = New System.Drawing.Point(7, 151)
        Me.txtEncryptFile.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtEncryptFile.Name = "txtEncryptFile"
        Me.txtEncryptFile.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEncryptFile.SelectedText = ""
        Me.txtEncryptFile.SelectionLength = 0
        Me.txtEncryptFile.SelectionStart = 0
        Me.txtEncryptFile.Size = New System.Drawing.Size(500, 23)
        Me.txtEncryptFile.TabIndex = 10
        Me.txtEncryptFile.UseSystemPasswordChar = False
        '
        'radEncryptFile
        '
        Me.radEncryptFile.AutoSize = True
        Me.radEncryptFile.Depth = 0
        Me.radEncryptFile.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.radEncryptFile.Location = New System.Drawing.Point(158, 111)
        Me.radEncryptFile.Margin = New System.Windows.Forms.Padding(0)
        Me.radEncryptFile.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.radEncryptFile.MouseState = MaterialSkin.MouseState.HOVER
        Me.radEncryptFile.Name = "radEncryptFile"
        Me.radEncryptFile.Ripple = True
        Me.radEncryptFile.Size = New System.Drawing.Size(169, 30)
        Me.radEncryptFile.TabIndex = 7
        Me.radEncryptFile.Text = "Select a File to Encrypt"
        Me.radEncryptFile.UseVisualStyleBackColor = True
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Depth = 0
        Me.btnEncrypt.Location = New System.Drawing.Point(407, 482)
        Me.btnEncrypt.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Primary = True
        Me.btnEncrypt.Size = New System.Drawing.Size(247, 38)
        Me.btnEncrypt.TabIndex = 5
        Me.btnEncrypt.Text = "Encrypt"
        Me.btnEncrypt.UseVisualStyleBackColor = True
        '
        'radEncryptPasteMessage
        '
        Me.radEncryptPasteMessage.AutoSize = True
        Me.radEncryptPasteMessage.Checked = True
        Me.radEncryptPasteMessage.Depth = 0
        Me.radEncryptPasteMessage.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.radEncryptPasteMessage.Location = New System.Drawing.Point(157, 190)
        Me.radEncryptPasteMessage.Margin = New System.Windows.Forms.Padding(0)
        Me.radEncryptPasteMessage.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.radEncryptPasteMessage.MouseState = MaterialSkin.MouseState.HOVER
        Me.radEncryptPasteMessage.Name = "radEncryptPasteMessage"
        Me.radEncryptPasteMessage.Ripple = True
        Me.radEncryptPasteMessage.Size = New System.Drawing.Size(170, 30)
        Me.radEncryptPasteMessage.TabIndex = 6
        Me.radEncryptPasteMessage.TabStop = True
        Me.radEncryptPasteMessage.Text = "Type/Paste a Message"
        Me.radEncryptPasteMessage.UseVisualStyleBackColor = True
        '
        'pnlEncryptPublicKey
        '
        Me.pnlEncryptPublicKey.BackColor = System.Drawing.Color.White
        Me.pnlEncryptPublicKey.Controls.Add(Me.radEncryptPasteKey)
        Me.pnlEncryptPublicKey.Controls.Add(Me.radEncryptKeyFile)
        Me.pnlEncryptPublicKey.Controls.Add(Me.txtEncryptKeyFile)
        Me.pnlEncryptPublicKey.Controls.Add(Me.txtEncryptPasteKey)
        Me.pnlEncryptPublicKey.Location = New System.Drawing.Point(513, 100)
        Me.pnlEncryptPublicKey.Name = "pnlEncryptPublicKey"
        Me.pnlEncryptPublicKey.Size = New System.Drawing.Size(550, 376)
        Me.pnlEncryptPublicKey.TabIndex = 4
        '
        'radEncryptPasteKey
        '
        Me.radEncryptPasteKey.AutoSize = True
        Me.radEncryptPasteKey.Checked = True
        Me.radEncryptPasteKey.Depth = 0
        Me.radEncryptPasteKey.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.radEncryptPasteKey.Location = New System.Drawing.Point(223, 90)
        Me.radEncryptPasteKey.Margin = New System.Windows.Forms.Padding(0)
        Me.radEncryptPasteKey.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.radEncryptPasteKey.MouseState = MaterialSkin.MouseState.HOVER
        Me.radEncryptPasteKey.Name = "radEncryptPasteKey"
        Me.radEncryptPasteKey.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.radEncryptPasteKey.Ripple = True
        Me.radEncryptPasteKey.Size = New System.Drawing.Size(101, 30)
        Me.radEncryptPasteKey.TabIndex = 9
        Me.radEncryptPasteKey.TabStop = True
        Me.radEncryptPasteKey.Text = "Paste a Key"
        Me.radEncryptPasteKey.UseVisualStyleBackColor = True
        '
        'radEncryptKeyFile
        '
        Me.radEncryptKeyFile.AutoSize = True
        Me.radEncryptKeyFile.Depth = 0
        Me.radEncryptKeyFile.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.radEncryptKeyFile.Location = New System.Drawing.Point(212, 11)
        Me.radEncryptKeyFile.Margin = New System.Windows.Forms.Padding(0)
        Me.radEncryptKeyFile.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.radEncryptKeyFile.MouseState = MaterialSkin.MouseState.HOVER
        Me.radEncryptKeyFile.Name = "radEncryptKeyFile"
        Me.radEncryptKeyFile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.radEncryptKeyFile.Ripple = True
        Me.radEncryptKeyFile.Size = New System.Drawing.Size(130, 30)
        Me.radEncryptKeyFile.TabIndex = 8
        Me.radEncryptKeyFile.Text = "Select a Key File"
        Me.radEncryptKeyFile.UseVisualStyleBackColor = True
        '
        'txtEncryptKeyFile
        '
        Me.txtEncryptKeyFile.Depth = 0
        Me.txtEncryptKeyFile.Enabled = False
        Me.txtEncryptKeyFile.Hint = ""
        Me.txtEncryptKeyFile.Location = New System.Drawing.Point(3, 51)
        Me.txtEncryptKeyFile.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtEncryptKeyFile.Name = "txtEncryptKeyFile"
        Me.txtEncryptKeyFile.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEncryptKeyFile.SelectedText = ""
        Me.txtEncryptKeyFile.SelectionLength = 0
        Me.txtEncryptKeyFile.SelectionStart = 0
        Me.txtEncryptKeyFile.Size = New System.Drawing.Size(544, 23)
        Me.txtEncryptKeyFile.TabIndex = 5
        Me.txtEncryptKeyFile.UseSystemPasswordChar = False
        '
        'txtEncryptPasteKey
        '
        Me.txtEncryptPasteKey.Location = New System.Drawing.Point(3, 133)
        Me.txtEncryptPasteKey.Multiline = True
        Me.txtEncryptPasteKey.Name = "txtEncryptPasteKey"
        Me.txtEncryptPasteKey.Size = New System.Drawing.Size(544, 236)
        Me.txtEncryptPasteKey.TabIndex = 0
        '
        'MaterialLabel9
        '
        Me.MaterialLabel9.AutoSize = True
        Me.MaterialLabel9.Depth = 0
        Me.MaterialLabel9.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel9.Location = New System.Drawing.Point(759, 24)
        Me.MaterialLabel9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel9.Name = "MaterialLabel9"
        Me.MaterialLabel9.Size = New System.Drawing.Size(78, 19)
        Me.MaterialLabel9.TabIndex = 3
        Me.MaterialLabel9.Text = "Public Key"
        '
        'cmbPublicSaved
        '
        Me.cmbPublicSaved.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPublicSaved.FormattingEnabled = True
        Me.cmbPublicSaved.Items.AddRange(New Object() {"Do not use a saved Key Pair"})
        Me.cmbPublicSaved.Location = New System.Drawing.Point(667, 60)
        Me.cmbPublicSaved.Name = "cmbPublicSaved"
        Me.cmbPublicSaved.Size = New System.Drawing.Size(268, 21)
        Me.cmbPublicSaved.TabIndex = 0
        '
        'txtEncryptPasteMessage
        '
        Me.txtEncryptPasteMessage.Location = New System.Drawing.Point(9, 234)
        Me.txtEncryptPasteMessage.Multiline = True
        Me.txtEncryptPasteMessage.Name = "txtEncryptPasteMessage"
        Me.txtEncryptPasteMessage.Size = New System.Drawing.Size(500, 235)
        Me.txtEncryptPasteMessage.TabIndex = 1
        '
        'tabDecrypt
        '
        Me.tabDecrypt.BackColor = System.Drawing.Color.White
        Me.tabDecrypt.Controls.Add(Me.txtKeyPassphrase)
        Me.tabDecrypt.Controls.Add(Me.MaterialLabel12)
        Me.tabDecrypt.Controls.Add(Me.txtDecryptFile)
        Me.tabDecrypt.Controls.Add(Me.radDecryptFile)
        Me.tabDecrypt.Controls.Add(Me.btnDecrypt)
        Me.tabDecrypt.Controls.Add(Me.radDecryptPasteMessage)
        Me.tabDecrypt.Controls.Add(Me.pnlDecryptPrivateKey)
        Me.tabDecrypt.Controls.Add(Me.MaterialLabel8)
        Me.tabDecrypt.Controls.Add(Me.txtDecryptPasteMessage)
        Me.tabDecrypt.Controls.Add(Me.cmbPrivateSaved)
        Me.tabDecrypt.Location = New System.Drawing.Point(4, 22)
        Me.tabDecrypt.Name = "tabDecrypt"
        Me.tabDecrypt.Size = New System.Drawing.Size(1066, 506)
        Me.tabDecrypt.TabIndex = 3
        Me.tabDecrypt.Text = "Decrypt"
        '
        'MaterialLabel12
        '
        Me.MaterialLabel12.AutoSize = True
        Me.MaterialLabel12.Depth = 0
        Me.MaterialLabel12.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel12.Location = New System.Drawing.Point(153, 24)
        Me.MaterialLabel12.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel12.Name = "MaterialLabel12"
        Me.MaterialLabel12.Size = New System.Drawing.Size(189, 19)
        Me.MaterialLabel12.TabIndex = 20
        Me.MaterialLabel12.Text = "File or Message to Decrypt"
        '
        'txtDecryptFile
        '
        Me.txtDecryptFile.Depth = 0
        Me.txtDecryptFile.Enabled = False
        Me.txtDecryptFile.Hint = ""
        Me.txtDecryptFile.Location = New System.Drawing.Point(7, 151)
        Me.txtDecryptFile.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtDecryptFile.Name = "txtDecryptFile"
        Me.txtDecryptFile.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDecryptFile.SelectedText = ""
        Me.txtDecryptFile.SelectionLength = 0
        Me.txtDecryptFile.SelectionStart = 0
        Me.txtDecryptFile.Size = New System.Drawing.Size(500, 23)
        Me.txtDecryptFile.TabIndex = 18
        Me.txtDecryptFile.UseSystemPasswordChar = False
        '
        'radDecryptFile
        '
        Me.radDecryptFile.AutoSize = True
        Me.radDecryptFile.Depth = 0
        Me.radDecryptFile.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.radDecryptFile.Location = New System.Drawing.Point(158, 111)
        Me.radDecryptFile.Margin = New System.Windows.Forms.Padding(0)
        Me.radDecryptFile.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.radDecryptFile.MouseState = MaterialSkin.MouseState.HOVER
        Me.radDecryptFile.Name = "radDecryptFile"
        Me.radDecryptFile.Ripple = True
        Me.radDecryptFile.Size = New System.Drawing.Size(170, 30)
        Me.radDecryptFile.TabIndex = 17
        Me.radDecryptFile.Text = "Select a File to Decrypt"
        Me.radDecryptFile.UseVisualStyleBackColor = True
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Depth = 0
        Me.btnDecrypt.Location = New System.Drawing.Point(407, 482)
        Me.btnDecrypt.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Primary = True
        Me.btnDecrypt.Size = New System.Drawing.Size(247, 38)
        Me.btnDecrypt.TabIndex = 15
        Me.btnDecrypt.Text = "Decrypt"
        Me.btnDecrypt.UseVisualStyleBackColor = True
        '
        'radDecryptPasteMessage
        '
        Me.radDecryptPasteMessage.AutoSize = True
        Me.radDecryptPasteMessage.Checked = True
        Me.radDecryptPasteMessage.Depth = 0
        Me.radDecryptPasteMessage.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.radDecryptPasteMessage.Location = New System.Drawing.Point(158, 190)
        Me.radDecryptPasteMessage.Margin = New System.Windows.Forms.Padding(0)
        Me.radDecryptPasteMessage.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.radDecryptPasteMessage.MouseState = MaterialSkin.MouseState.HOVER
        Me.radDecryptPasteMessage.Name = "radDecryptPasteMessage"
        Me.radDecryptPasteMessage.Ripple = True
        Me.radDecryptPasteMessage.Size = New System.Drawing.Size(165, 30)
        Me.radDecryptPasteMessage.TabIndex = 16
        Me.radDecryptPasteMessage.TabStop = True
        Me.radDecryptPasteMessage.Text = "Paste a PGP Message"
        Me.radDecryptPasteMessage.UseVisualStyleBackColor = True
        '
        'pnlDecryptPrivateKey
        '
        Me.pnlDecryptPrivateKey.BackColor = System.Drawing.Color.White
        Me.pnlDecryptPrivateKey.Controls.Add(Me.radDecryptPasteKey)
        Me.pnlDecryptPrivateKey.Controls.Add(Me.radDecryptKeyFile)
        Me.pnlDecryptPrivateKey.Controls.Add(Me.txtDecryptKeyFile)
        Me.pnlDecryptPrivateKey.Controls.Add(Me.txtDecryptPasteKey)
        Me.pnlDecryptPrivateKey.Location = New System.Drawing.Point(513, 100)
        Me.pnlDecryptPrivateKey.Name = "pnlDecryptPrivateKey"
        Me.pnlDecryptPrivateKey.Size = New System.Drawing.Size(550, 341)
        Me.pnlDecryptPrivateKey.TabIndex = 14
        '
        'txtKeyPassphrase
        '
        Me.txtKeyPassphrase.Depth = 0
        Me.txtKeyPassphrase.Hint = ""
        Me.txtKeyPassphrase.Location = New System.Drawing.Point(515, 446)
        Me.txtKeyPassphrase.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtKeyPassphrase.Name = "txtKeyPassphrase"
        Me.txtKeyPassphrase.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKeyPassphrase.SelectedText = ""
        Me.txtKeyPassphrase.SelectionLength = 0
        Me.txtKeyPassphrase.SelectionStart = 0
        Me.txtKeyPassphrase.Size = New System.Drawing.Size(544, 23)
        Me.txtKeyPassphrase.TabIndex = 10
        Me.txtKeyPassphrase.Text = "                                                  Private Key Passphrase"
        Me.txtKeyPassphrase.UseSystemPasswordChar = False
        '
        'radDecryptPasteKey
        '
        Me.radDecryptPasteKey.AutoSize = True
        Me.radDecryptPasteKey.Checked = True
        Me.radDecryptPasteKey.Depth = 0
        Me.radDecryptPasteKey.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.radDecryptPasteKey.Location = New System.Drawing.Point(223, 90)
        Me.radDecryptPasteKey.Margin = New System.Windows.Forms.Padding(0)
        Me.radDecryptPasteKey.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.radDecryptPasteKey.MouseState = MaterialSkin.MouseState.HOVER
        Me.radDecryptPasteKey.Name = "radDecryptPasteKey"
        Me.radDecryptPasteKey.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.radDecryptPasteKey.Ripple = True
        Me.radDecryptPasteKey.Size = New System.Drawing.Size(101, 30)
        Me.radDecryptPasteKey.TabIndex = 9
        Me.radDecryptPasteKey.TabStop = True
        Me.radDecryptPasteKey.Text = "Paste a Key"
        Me.radDecryptPasteKey.UseVisualStyleBackColor = True
        '
        'radDecryptKeyFile
        '
        Me.radDecryptKeyFile.AutoSize = True
        Me.radDecryptKeyFile.Depth = 0
        Me.radDecryptKeyFile.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.radDecryptKeyFile.Location = New System.Drawing.Point(212, 11)
        Me.radDecryptKeyFile.Margin = New System.Windows.Forms.Padding(0)
        Me.radDecryptKeyFile.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.radDecryptKeyFile.MouseState = MaterialSkin.MouseState.HOVER
        Me.radDecryptKeyFile.Name = "radDecryptKeyFile"
        Me.radDecryptKeyFile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.radDecryptKeyFile.Ripple = True
        Me.radDecryptKeyFile.Size = New System.Drawing.Size(130, 30)
        Me.radDecryptKeyFile.TabIndex = 8
        Me.radDecryptKeyFile.Text = "Select a Key File"
        Me.radDecryptKeyFile.UseVisualStyleBackColor = True
        '
        'txtDecryptKeyFile
        '
        Me.txtDecryptKeyFile.Depth = 0
        Me.txtDecryptKeyFile.Enabled = False
        Me.txtDecryptKeyFile.Hint = ""
        Me.txtDecryptKeyFile.Location = New System.Drawing.Point(3, 51)
        Me.txtDecryptKeyFile.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtDecryptKeyFile.Name = "txtDecryptKeyFile"
        Me.txtDecryptKeyFile.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDecryptKeyFile.SelectedText = ""
        Me.txtDecryptKeyFile.SelectionLength = 0
        Me.txtDecryptKeyFile.SelectionStart = 0
        Me.txtDecryptKeyFile.Size = New System.Drawing.Size(544, 23)
        Me.txtDecryptKeyFile.TabIndex = 5
        Me.txtDecryptKeyFile.UseSystemPasswordChar = False
        '
        'txtDecryptPasteKey
        '
        Me.txtDecryptPasteKey.Location = New System.Drawing.Point(3, 133)
        Me.txtDecryptPasteKey.Multiline = True
        Me.txtDecryptPasteKey.Name = "txtDecryptPasteKey"
        Me.txtDecryptPasteKey.Size = New System.Drawing.Size(544, 203)
        Me.txtDecryptPasteKey.TabIndex = 0
        '
        'MaterialLabel8
        '
        Me.MaterialLabel8.AutoSize = True
        Me.MaterialLabel8.Depth = 0
        Me.MaterialLabel8.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel8.Location = New System.Drawing.Point(758, 24)
        Me.MaterialLabel8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel8.Name = "MaterialLabel8"
        Me.MaterialLabel8.Size = New System.Drawing.Size(83, 19)
        Me.MaterialLabel8.TabIndex = 13
        Me.MaterialLabel8.Text = "Private Key"
        '
        'txtDecryptPasteMessage
        '
        Me.txtDecryptPasteMessage.Location = New System.Drawing.Point(9, 234)
        Me.txtDecryptPasteMessage.Multiline = True
        Me.txtDecryptPasteMessage.Name = "txtDecryptPasteMessage"
        Me.txtDecryptPasteMessage.Size = New System.Drawing.Size(500, 235)
        Me.txtDecryptPasteMessage.TabIndex = 12
        '
        'cmbPrivateSaved
        '
        Me.cmbPrivateSaved.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPrivateSaved.FormattingEnabled = True
        Me.cmbPrivateSaved.Items.AddRange(New Object() {"Do not use a saved Key Pair"})
        Me.cmbPrivateSaved.Location = New System.Drawing.Point(667, 60)
        Me.cmbPrivateSaved.Name = "cmbPrivateSaved"
        Me.cmbPrivateSaved.Size = New System.Drawing.Size(268, 21)
        Me.cmbPrivateSaved.TabIndex = 1
        '
        'tabSettings
        '
        Me.tabSettings.BackColor = System.Drawing.Color.White
        Me.tabSettings.Controls.Add(Me.btnClearPrivate3)
        Me.tabSettings.Controls.Add(Me.MaterialLabel7)
        Me.tabSettings.Controls.Add(Me.btnBrowsePrivate3)
        Me.tabSettings.Controls.Add(Me.txtPrivate3Path)
        Me.tabSettings.Controls.Add(Me.btnClearPrivate2)
        Me.tabSettings.Controls.Add(Me.MaterialLabel6)
        Me.tabSettings.Controls.Add(Me.btnBrowsePrivate2)
        Me.tabSettings.Controls.Add(Me.txtPrivate2Path)
        Me.tabSettings.Controls.Add(Me.MaterialRaisedButton5)
        Me.tabSettings.Controls.Add(Me.btnClearPublic3)
        Me.tabSettings.Controls.Add(Me.MaterialLabel5)
        Me.tabSettings.Controls.Add(Me.btnBrowsePublic3)
        Me.tabSettings.Controls.Add(Me.txtPublic3Path)
        Me.tabSettings.Controls.Add(Me.btnClearPublic2)
        Me.tabSettings.Controls.Add(Me.MaterialLabel4)
        Me.tabSettings.Controls.Add(Me.btnBrowsePublic2)
        Me.tabSettings.Controls.Add(Me.txtPublic2Path)
        Me.tabSettings.Controls.Add(Me.btnClearPrivate1)
        Me.tabSettings.Controls.Add(Me.btnClearPublic1)
        Me.tabSettings.Controls.Add(Me.MaterialLabel3)
        Me.tabSettings.Controls.Add(Me.MaterialLabel2)
        Me.tabSettings.Controls.Add(Me.btnBrowsePrivate1)
        Me.tabSettings.Controls.Add(Me.btnBrowsePublic1)
        Me.tabSettings.Controls.Add(Me.txtPrivate1Path)
        Me.tabSettings.Controls.Add(Me.txtPublic1Path)
        Me.tabSettings.Location = New System.Drawing.Point(4, 22)
        Me.tabSettings.Name = "tabSettings"
        Me.tabSettings.Size = New System.Drawing.Size(1066, 506)
        Me.tabSettings.TabIndex = 4
        Me.tabSettings.Text = "Settings"
        '
        'btnClearPrivate3
        '
        Me.btnClearPrivate3.Depth = 0
        Me.btnClearPrivate3.Location = New System.Drawing.Point(772, 288)
        Me.btnClearPrivate3.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnClearPrivate3.Name = "btnClearPrivate3"
        Me.btnClearPrivate3.Primary = True
        Me.btnClearPrivate3.Size = New System.Drawing.Size(75, 23)
        Me.btnClearPrivate3.TabIndex = 29
        Me.btnClearPrivate3.Text = "Clear"
        Me.btnClearPrivate3.UseVisualStyleBackColor = True
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel7.Location = New System.Drawing.Point(220, 292)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(148, 19)
        Me.MaterialLabel7.TabIndex = 28
        Me.MaterialLabel7.Text = "Saved Private Key #3"
        '
        'btnBrowsePrivate3
        '
        Me.btnBrowsePrivate3.Depth = 0
        Me.btnBrowsePrivate3.Location = New System.Drawing.Point(691, 288)
        Me.btnBrowsePrivate3.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnBrowsePrivate3.Name = "btnBrowsePrivate3"
        Me.btnBrowsePrivate3.Primary = True
        Me.btnBrowsePrivate3.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowsePrivate3.TabIndex = 27
        Me.btnBrowsePrivate3.Text = "Browse"
        Me.btnBrowsePrivate3.UseVisualStyleBackColor = True
        '
        'txtPrivate3Path
        '
        Me.txtPrivate3Path.Depth = 0
        Me.txtPrivate3Path.Enabled = False
        Me.txtPrivate3Path.Hint = ""
        Me.txtPrivate3Path.Location = New System.Drawing.Point(384, 288)
        Me.txtPrivate3Path.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtPrivate3Path.Name = "txtPrivate3Path"
        Me.txtPrivate3Path.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrivate3Path.SelectedText = ""
        Me.txtPrivate3Path.SelectionLength = 0
        Me.txtPrivate3Path.SelectionStart = 0
        Me.txtPrivate3Path.Size = New System.Drawing.Size(290, 23)
        Me.txtPrivate3Path.TabIndex = 26
        Me.txtPrivate3Path.UseSystemPasswordChar = False
        '
        'btnClearPrivate2
        '
        Me.btnClearPrivate2.Depth = 0
        Me.btnClearPrivate2.Location = New System.Drawing.Point(772, 259)
        Me.btnClearPrivate2.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnClearPrivate2.Name = "btnClearPrivate2"
        Me.btnClearPrivate2.Primary = True
        Me.btnClearPrivate2.Size = New System.Drawing.Size(75, 23)
        Me.btnClearPrivate2.TabIndex = 25
        Me.btnClearPrivate2.Text = "Clear"
        Me.btnClearPrivate2.UseVisualStyleBackColor = True
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel6.Location = New System.Drawing.Point(220, 263)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(148, 19)
        Me.MaterialLabel6.TabIndex = 24
        Me.MaterialLabel6.Text = "Saved Private Key #2"
        '
        'btnBrowsePrivate2
        '
        Me.btnBrowsePrivate2.Depth = 0
        Me.btnBrowsePrivate2.Location = New System.Drawing.Point(691, 259)
        Me.btnBrowsePrivate2.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnBrowsePrivate2.Name = "btnBrowsePrivate2"
        Me.btnBrowsePrivate2.Primary = True
        Me.btnBrowsePrivate2.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowsePrivate2.TabIndex = 23
        Me.btnBrowsePrivate2.Text = "Browse"
        Me.btnBrowsePrivate2.UseVisualStyleBackColor = True
        '
        'txtPrivate2Path
        '
        Me.txtPrivate2Path.Depth = 0
        Me.txtPrivate2Path.Enabled = False
        Me.txtPrivate2Path.Hint = ""
        Me.txtPrivate2Path.Location = New System.Drawing.Point(384, 259)
        Me.txtPrivate2Path.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtPrivate2Path.Name = "txtPrivate2Path"
        Me.txtPrivate2Path.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrivate2Path.SelectedText = ""
        Me.txtPrivate2Path.SelectionLength = 0
        Me.txtPrivate2Path.SelectionStart = 0
        Me.txtPrivate2Path.Size = New System.Drawing.Size(290, 23)
        Me.txtPrivate2Path.TabIndex = 22
        Me.txtPrivate2Path.UseSystemPasswordChar = False
        '
        'MaterialRaisedButton5
        '
        Me.MaterialRaisedButton5.Depth = 0
        Me.MaterialRaisedButton5.Location = New System.Drawing.Point(457, 384)
        Me.MaterialRaisedButton5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton5.Name = "MaterialRaisedButton5"
        Me.MaterialRaisedButton5.Primary = True
        Me.MaterialRaisedButton5.Size = New System.Drawing.Size(157, 23)
        Me.MaterialRaisedButton5.TabIndex = 21
        Me.MaterialRaisedButton5.Text = "Save"
        Me.MaterialRaisedButton5.UseVisualStyleBackColor = True
        '
        'btnClearPublic3
        '
        Me.btnClearPublic3.Depth = 0
        Me.btnClearPublic3.Location = New System.Drawing.Point(772, 155)
        Me.btnClearPublic3.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnClearPublic3.Name = "btnClearPublic3"
        Me.btnClearPublic3.Primary = True
        Me.btnClearPublic3.Size = New System.Drawing.Size(75, 23)
        Me.btnClearPublic3.TabIndex = 20
        Me.btnClearPublic3.Text = "Clear"
        Me.btnClearPublic3.UseVisualStyleBackColor = True
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(225, 159)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(143, 19)
        Me.MaterialLabel5.TabIndex = 19
        Me.MaterialLabel5.Text = "Saved Public Key #3"
        '
        'btnBrowsePublic3
        '
        Me.btnBrowsePublic3.Depth = 0
        Me.btnBrowsePublic3.Location = New System.Drawing.Point(691, 155)
        Me.btnBrowsePublic3.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnBrowsePublic3.Name = "btnBrowsePublic3"
        Me.btnBrowsePublic3.Primary = True
        Me.btnBrowsePublic3.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowsePublic3.TabIndex = 18
        Me.btnBrowsePublic3.Text = "Browse"
        Me.btnBrowsePublic3.UseVisualStyleBackColor = True
        '
        'txtPublic3Path
        '
        Me.txtPublic3Path.Depth = 0
        Me.txtPublic3Path.Enabled = False
        Me.txtPublic3Path.Hint = ""
        Me.txtPublic3Path.Location = New System.Drawing.Point(384, 155)
        Me.txtPublic3Path.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtPublic3Path.Name = "txtPublic3Path"
        Me.txtPublic3Path.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPublic3Path.SelectedText = ""
        Me.txtPublic3Path.SelectionLength = 0
        Me.txtPublic3Path.SelectionStart = 0
        Me.txtPublic3Path.Size = New System.Drawing.Size(290, 23)
        Me.txtPublic3Path.TabIndex = 17
        Me.txtPublic3Path.UseSystemPasswordChar = False
        '
        'btnClearPublic2
        '
        Me.btnClearPublic2.Depth = 0
        Me.btnClearPublic2.Location = New System.Drawing.Point(772, 126)
        Me.btnClearPublic2.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnClearPublic2.Name = "btnClearPublic2"
        Me.btnClearPublic2.Primary = True
        Me.btnClearPublic2.Size = New System.Drawing.Size(75, 23)
        Me.btnClearPublic2.TabIndex = 16
        Me.btnClearPublic2.Text = "Clear"
        Me.btnClearPublic2.UseVisualStyleBackColor = True
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(225, 130)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(143, 19)
        Me.MaterialLabel4.TabIndex = 15
        Me.MaterialLabel4.Text = "Saved Public Key #2"
        '
        'btnBrowsePublic2
        '
        Me.btnBrowsePublic2.Depth = 0
        Me.btnBrowsePublic2.Location = New System.Drawing.Point(691, 126)
        Me.btnBrowsePublic2.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnBrowsePublic2.Name = "btnBrowsePublic2"
        Me.btnBrowsePublic2.Primary = True
        Me.btnBrowsePublic2.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowsePublic2.TabIndex = 14
        Me.btnBrowsePublic2.Text = "Browse"
        Me.btnBrowsePublic2.UseVisualStyleBackColor = True
        '
        'txtPublic2Path
        '
        Me.txtPublic2Path.Depth = 0
        Me.txtPublic2Path.Enabled = False
        Me.txtPublic2Path.Hint = ""
        Me.txtPublic2Path.Location = New System.Drawing.Point(384, 126)
        Me.txtPublic2Path.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtPublic2Path.Name = "txtPublic2Path"
        Me.txtPublic2Path.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPublic2Path.SelectedText = ""
        Me.txtPublic2Path.SelectionLength = 0
        Me.txtPublic2Path.SelectionStart = 0
        Me.txtPublic2Path.Size = New System.Drawing.Size(290, 23)
        Me.txtPublic2Path.TabIndex = 13
        Me.txtPublic2Path.UseSystemPasswordChar = False
        '
        'btnClearPrivate1
        '
        Me.btnClearPrivate1.Depth = 0
        Me.btnClearPrivate1.Location = New System.Drawing.Point(772, 230)
        Me.btnClearPrivate1.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnClearPrivate1.Name = "btnClearPrivate1"
        Me.btnClearPrivate1.Primary = True
        Me.btnClearPrivate1.Size = New System.Drawing.Size(75, 23)
        Me.btnClearPrivate1.TabIndex = 12
        Me.btnClearPrivate1.Text = "Clear"
        Me.btnClearPrivate1.UseVisualStyleBackColor = True
        '
        'btnClearPublic1
        '
        Me.btnClearPublic1.Depth = 0
        Me.btnClearPublic1.Location = New System.Drawing.Point(772, 97)
        Me.btnClearPublic1.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnClearPublic1.Name = "btnClearPublic1"
        Me.btnClearPublic1.Primary = True
        Me.btnClearPublic1.Size = New System.Drawing.Size(75, 23)
        Me.btnClearPublic1.TabIndex = 11
        Me.btnClearPublic1.Text = "Clear"
        Me.btnClearPublic1.UseVisualStyleBackColor = True
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(220, 234)
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
        Me.MaterialLabel2.Location = New System.Drawing.Point(225, 101)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(143, 19)
        Me.MaterialLabel2.TabIndex = 4
        Me.MaterialLabel2.Text = "Saved Public Key #1"
        '
        'btnBrowsePrivate1
        '
        Me.btnBrowsePrivate1.Depth = 0
        Me.btnBrowsePrivate1.Location = New System.Drawing.Point(691, 230)
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
        Me.btnBrowsePublic1.Location = New System.Drawing.Point(691, 97)
        Me.btnBrowsePublic1.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnBrowsePublic1.Name = "btnBrowsePublic1"
        Me.btnBrowsePublic1.Primary = True
        Me.btnBrowsePublic1.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowsePublic1.TabIndex = 2
        Me.btnBrowsePublic1.Text = "Browse"
        Me.btnBrowsePublic1.UseVisualStyleBackColor = True
        '
        'txtPrivate1Path
        '
        Me.txtPrivate1Path.Depth = 0
        Me.txtPrivate1Path.Enabled = False
        Me.txtPrivate1Path.Hint = ""
        Me.txtPrivate1Path.Location = New System.Drawing.Point(384, 230)
        Me.txtPrivate1Path.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtPrivate1Path.Name = "txtPrivate1Path"
        Me.txtPrivate1Path.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrivate1Path.SelectedText = ""
        Me.txtPrivate1Path.SelectionLength = 0
        Me.txtPrivate1Path.SelectionStart = 0
        Me.txtPrivate1Path.Size = New System.Drawing.Size(290, 23)
        Me.txtPrivate1Path.TabIndex = 1
        Me.txtPrivate1Path.UseSystemPasswordChar = False
        '
        'txtPublic1Path
        '
        Me.txtPublic1Path.Depth = 0
        Me.txtPublic1Path.Enabled = False
        Me.txtPublic1Path.Hint = ""
        Me.txtPublic1Path.Location = New System.Drawing.Point(384, 97)
        Me.txtPublic1Path.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtPublic1Path.Name = "txtPublic1Path"
        Me.txtPublic1Path.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPublic1Path.SelectedText = ""
        Me.txtPublic1Path.SelectionLength = 0
        Me.txtPublic1Path.SelectionStart = 0
        Me.txtPublic1Path.Size = New System.Drawing.Size(290, 23)
        Me.txtPublic1Path.TabIndex = 0
        Me.txtPublic1Path.UseSystemPasswordChar = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1080, 646)
        Me.Controls.Add(Me.tabControlMain)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.MaximumSize = New System.Drawing.Size(1080, 646)
        Me.MinimumSize = New System.Drawing.Size(1080, 646)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maega PGPTool"
        Me.tabControlMain.ResumeLayout(False)
        Me.tabHome.ResumeLayout(False)
        Me.tabHome.PerformLayout()
        Me.tabGenerate.ResumeLayout(False)
        Me.tabGenerate.PerformLayout()
        Me.tabEncrypt.ResumeLayout(False)
        Me.tabEncrypt.PerformLayout()
        Me.pnlEncryptPublicKey.ResumeLayout(False)
        Me.pnlEncryptPublicKey.PerformLayout()
        Me.tabDecrypt.ResumeLayout(False)
        Me.tabDecrypt.PerformLayout()
        Me.pnlDecryptPrivateKey.ResumeLayout(False)
        Me.pnlDecryptPrivateKey.PerformLayout()
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
    Friend WithEvents btnGenerate As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents txtGeneratePass As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtGenerateUser As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnBrowsePrivate1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnBrowsePublic1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents txtPrivate1Path As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtPublic1Path As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents cmbPublicSaved As ComboBox
    Friend WithEvents btnClearPrivate1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnClearPublic1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnClearPublic3 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnBrowsePublic3 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents txtPublic3Path As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents btnClearPublic2 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnBrowsePublic2 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents txtPublic2Path As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialRaisedButton5 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnClearPrivate3 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnBrowsePrivate3 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents txtPrivate3Path As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents btnClearPrivate2 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnBrowsePrivate2 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents txtPrivate2Path As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents cmbPrivateSaved As ComboBox
    Friend WithEvents pnlEncryptPublicKey As Panel
    Friend WithEvents radEncryptPasteKey As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents radEncryptKeyFile As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents txtEncryptKeyFile As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtEncryptPasteKey As TextBox
    Friend WithEvents MaterialLabel9 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtEncryptPasteMessage As TextBox
    Friend WithEvents btnEncrypt As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents txtEncryptFile As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents radEncryptFile As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents radEncryptPasteMessage As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents txtDecryptFile As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents radDecryptFile As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents btnDecrypt As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents radDecryptPasteMessage As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents pnlDecryptPrivateKey As Panel
    Friend WithEvents radDecryptPasteKey As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents radDecryptKeyFile As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents txtDecryptKeyFile As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtDecryptPasteKey As TextBox
    Friend WithEvents MaterialLabel8 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtDecryptPasteMessage As TextBox
    Friend WithEvents txtGeneratedPrivate As TextBox
    Friend WithEvents txtGeneratedPublic As TextBox
    Friend WithEvents txtGenerateConfirm As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel11 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtKeyPassphrase As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel12 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
