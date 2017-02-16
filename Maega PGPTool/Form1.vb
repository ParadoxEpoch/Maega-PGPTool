Imports System.IO
Imports MaterialSkin
Public Class Form1
    Dim PGPLib As New ChoPGPEncryptDecrypt
    Dim SpecifyMessage As String = "Specify a key - Don't use a saved key"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Here we set the properties for MaterialSkin. Technically we don't have to because there are defaults, but specifying this now makes it easier to make theming changes down the road.
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)

        'If any keys have been saved, load them in now.
        If Not My.Settings.Public1Path = Nothing Then txtPublic1Path.Text = My.Settings.Public1Path
        If Not My.Settings.Public2Path = Nothing Then txtPublic2Path.Text = My.Settings.Public2Path
        If Not My.Settings.Public3Path = Nothing Then txtPublic3Path.Text = My.Settings.Public3Path
        If Not My.Settings.Private1Path = Nothing Then txtPrivate1Path.Text = My.Settings.Private1Path
        If Not My.Settings.Private2Path = Nothing Then txtPrivate2Path.Text = My.Settings.Private2Path
        If Not My.Settings.Private3Path = Nothing Then txtPrivate3Path.Text = My.Settings.Private3Path

        'All this sad, wasted code below was originally going to be to name each of the private and public key entries.
        'Once upon a time they were stored as key pairs, but that's useless in practise since you won't be encrypting things with your own public key, or decrypting with other's private keys.
        'Alas, this code remains for potential future use.

        'If Not My.Settings.KeyName1 = Nothing Then txtKey1Name.Text = My.Settings.KeyName1 Else txtKey1Name.Text = "My Key Pair"
        'If IO.File.Exists(My.Settings.Public1Path) Then txtPublic1Path.Text = My.Settings.Public1Path Else My.Settings.Key1Enabled = False
        'If IO.File.Exists(My.Settings.Public2Path) Then txtPrivate1Path.Text = My.Settings.Public2Path Else My.Settings.Key1Enabled = False
        'If My.Settings.Key1Enabled Then chkKey1Enabled.Checked = True
        'If IO.File.Exists(My.Settings.Pub2Path) Then txtPublicKey2.Text = My.Settings.Pub2Path Else My.Settings.Key2Enabled = False
        'If IO.File.Exists(My.Settings.Pri2Path) Then txtPrivateKey2.Text = My.Settings.Pri2Path Else My.Settings.Key2Enabled = False
        'If My.Settings.Key2Enabled Then chkKey2Enabled.Checked = True
        'If IO.File.Exists(My.Settings.Pub3Path) Then txtPublicKey3.Text = My.Settings.Pub3Path Else My.Settings.Key3Enabled = False
        'If IO.File.Exists(My.Settings.Pri3Path) Then txtPrivateKey3.Text = My.Settings.Pri3Path Else My.Settings.Key3Enabled = False
        'If My.Settings.Key3Enabled Then chkKey3Enabled.Checked = True

        'Refresh the comboboxes to update saved keys
        RefreshCombos()

        If My.Settings.FirstRun Then
            'If it's the first launch of PGPTool, show the message informing users about licensing and that PGPTool is free and open source. If you're reading this, you know that by now.
            MsgBox("Welcome to Maega PGPTool" + vbNewLine + vbNewLine + "This software is FREE and OPEN SOURCE. If you paid for PGPTool, demand a refund!" + vbNewLine + vbNewLine + "This software uses third-party libraries which are not covered under the PGPTool license." + vbNewLine + vbNewLine + "This software was developed by Maega for any use scenario. You are not limited by licensing and are free to use PGPTool for any personal, commercial or educational use." + vbNewLine + vbNewLine + "If you fork PGPTool into your own project, we'd appreciate some credit, however it's not required." + vbNewLine + vbNewLine + "Thanks for using Maega Software!", MsgBoxStyle.Information)
            'Now disable the FirstRun boolean and save it.
            My.Settings.FirstRun = False
            My.Settings.Save()
        End If
    End Sub

    Private Sub RefreshCombos()
        'Clears out the comboboxes and adds saved keys as options.
        cmbPublicSaved.Items.Clear()
        cmbPrivateSaved.Items.Clear()
        cmbPublicSaved.Items.Add(SpecifyMessage)
        cmbPrivateSaved.Items.Add(SpecifyMessage)

        'This is more code which was once used in naming key pairs. eg: "Use 'My Key Pair 1'"
        'If My.Settings.Key1Enabled Then cmbSaved.Items.Add("Use '" + My.Settings.KeyName1 + "'")
        'If My.Settings.Key2Enabled Then cmbSaved.Items.Add("Use '" + My.Settings.KeyName2 + "'")
        'If My.Settings.Key3Enabled Then cmbSaved.Items.Add("Use '" + My.Settings.KeyName3 + "'")

        'Time to add the saved keys as options
        If Not My.Settings.Public1Path = Nothing Then cmbPublicSaved.Items.Add("Use Public Key 1")
        If Not My.Settings.Public2Path = Nothing Then cmbPublicSaved.Items.Add("Use Public Key 2")
        If Not My.Settings.Public3Path = Nothing Then cmbPublicSaved.Items.Add("Use Public Key 3")
        If Not My.Settings.Private1Path = Nothing Then cmbPrivateSaved.Items.Add("Use Private Key 1")
        If Not My.Settings.Private2Path = Nothing Then cmbPrivateSaved.Items.Add("Use Private Key 2")
        If Not My.Settings.Private3Path = Nothing Then cmbPrivateSaved.Items.Add("Use Private Key 3")

        'Now we have the combobox select the "Specify a key" option as default because a e s t h e t i c.
        cmbPublicSaved.SelectedItem = SpecifyMessage
        cmbPrivateSaved.SelectedItem = SpecifyMessage
    End Sub

    Private Sub btnSelectGenerate_Click(sender As Object, e As EventArgs) Handles btnSelectGenerate.Click
        'Sends the user to the "Generate" tab when clicking the relevant button on the "Home" tab
        tabControlMain.SelectedTab = tabGenerate
    End Sub

    Private Sub btnSelectEncrypt_Click(sender As Object, e As EventArgs) Handles btnSelectEncrypt.Click
        'Sends the user to the "Encrypt" tab when clicking the relevant button on the "Home" tab
        tabControlMain.SelectedTab = tabEncrypt
    End Sub

    Private Sub btnSelectDecrypt_Click(sender As Object, e As EventArgs) Handles btnSelectDecrypt.Click
        'Sends the user to the "Decrypt" tab when clicking the relevant button on the "Home" tab
        tabControlMain.SelectedTab = tabDecrypt
    End Sub

    Private Sub MaterialRaisedButton1_Click_1(sender As Object, e As EventArgs) Handles btnGenerate.Click

        'Checks if the entered passphrases match
        If Not txtGeneratePass.Text = txtGenerateConfirm.Text Then
            MsgBox("The passphrases you entered don't match. Please try again.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        'If the user didn't specify an email address, make it blank
        If txtGenerateUser.Text = "Email Address (Optional)" Then txtGenerateUser.Text = String.Empty

        'Create a new SaveFileDialog and define path variables for the public and private keys; getting ready to save.
        Dim fd As SaveFileDialog = New SaveFileDialog()
        Dim PublicKeyPath As String
        Dim PrivateKeyPath As String

        'Specifying some SaveFileDialog properties, again for a e s t h e t i c. Alright, I'll stop that now.
        fd.Title = "Save your public key file"
        fd.FileName = "public.asc"
        fd.Filter = "PGP ASCII Armored File (*.asc)|*.asc|All files (*.*)|*.*"
        fd.FilterIndex = 1
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            'If the user chose a path for the public key, get another dialog ready for the public key
            'Fun fact: This was originally going to be a FolderBrowserDialog but I decided users probably want to choose file names
            PublicKeyPath = fd.FileName
            fd.Title = "Save your private key file"
            fd.FileName = "private.asc"

            If fd.ShowDialog() = DialogResult.OK Then
                'If the user hasn't cancelled by now, they're all in. We set the PrivateKeyPath variable to the path selected by the user, and delete any files in that location. The user was already warned.
                PrivateKeyPath = fd.FileName
                If File.Exists(PublicKeyPath) Then File.Delete(PublicKeyPath)
                If File.Exists(PrivateKeyPath) Then File.Delete(PrivateKeyPath)
                Try
                    'Now it's time to generate the key pair. We don't have much control over this step because it's handled by a third-party library available on NuGet.
                    PGPLib.GenerateKey(PublicKeyPath, PrivateKeyPath, txtGenerateUser.Text, txtGeneratePass.Text)
                Catch ex As Exception
                    'If something went wrong, blame the user. I'm kidding, nothing should go wrong.
                    MsgBox("Failed to generate a key pair. An unknown error occurred. Please check the information you provided and try again.", MsgBoxStyle.Critical)
                End Try

                'Outputs the newly saved keys into the two relevant textboxes (txtGeneratedPublic and txtGeneratedPrivate)
                txtGeneratedPublic.Text = File.ReadAllText(PublicKeyPath)
                txtGeneratedPrivate.Text = File.ReadAllText(PrivateKeyPath)

                'Finally we set everything back to normal so the user can generate more keys if they want.
                txtGenerateUser.Text = "Email Address (Optional)"
                txtGeneratePass.Text = "Passphrase"
                txtGeneratePass.UseSystemPasswordChar = False
                txtGenerateConfirm.Text = "Confirm Passphrase"
                txtGenerateConfirm.UseSystemPasswordChar = False
            End If
        End If
    End Sub

    Private Function GetPath(title As String, Optional filter As String = "PGP ASCII Armored File (*.asc)|*.asc|All files (*.*)|*.*")
        Dim BrowseKey As OpenFileDialog = New OpenFileDialog()
        BrowseKey.Title = title
        BrowseKey.Filter = filter
        BrowseKey.FilterIndex = 1
        BrowseKey.RestoreDirectory = True

        If BrowseKey.ShowDialog() = DialogResult.OK Then
            Return BrowseKey.FileName
        Else
            Return Nothing
        End If
    End Function

    Private Sub MaterialRaisedButton5_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton5.Click
        My.Settings.Save()
        RefreshCombos()
    End Sub

    Private Sub btnBrowsePublic1_Click(sender As Object, e As EventArgs) Handles btnBrowsePublic1.Click
        Dim Pub1Path As String = GetPath("Select a Public Key")
        txtPublic1Path.Text = Pub1Path
        My.Settings.Public1Path = Pub1Path
    End Sub

    Private Sub btnBrowsePublic2_Click(sender As Object, e As EventArgs) Handles btnBrowsePublic2.Click
        Dim Public2Path As String = GetPath("Select a Public Key")
        txtPublic2Path.Text = Public2Path
        My.Settings.Public2Path = Public2Path
    End Sub

    Private Sub btnBrowsePublic3_Click(sender As Object, e As EventArgs) Handles btnBrowsePublic3.Click
        Dim Public3Path As String = GetPath("Select a Public Key")
        txtPublic3Path.Text = Public3Path
        My.Settings.Public3Path = Public3Path
    End Sub

    Private Sub btnClearPublic1_Click(sender As Object, e As EventArgs) Handles btnClearPublic1.Click
        My.Settings.Public1Path = Nothing
        txtPublic1Path.Text = String.Empty
    End Sub

    Private Sub btnClearPublic2_Click(sender As Object, e As EventArgs) Handles btnClearPublic2.Click
        My.Settings.Public2Path = Nothing
        txtPublic2Path.Text = String.Empty
    End Sub

    Private Sub btnClearPublic3_Click(sender As Object, e As EventArgs) Handles btnClearPublic3.Click
        My.Settings.Public3Path = Nothing
        txtPublic3Path.Text = String.Empty
    End Sub
    Private Sub btnClearPrivate1_Click(sender As Object, e As EventArgs) Handles btnClearPrivate1.Click
        My.Settings.Private1Path = Nothing
        txtPrivate1Path.Text = String.Empty
    End Sub

    Private Sub btnClearPrivate2_Click(sender As Object, e As EventArgs) Handles btnClearPrivate2.Click
        My.Settings.Private2Path = Nothing
        txtPrivate2Path.Text = String.Empty
    End Sub

    Private Sub btnClearPrivate3_Click(sender As Object, e As EventArgs) Handles btnClearPrivate3.Click
        My.Settings.Private3Path = Nothing
        txtPrivate3Path.Text = String.Empty
    End Sub

    Private Sub btnBrowsePrivate1_Click(sender As Object, e As EventArgs) Handles btnBrowsePrivate1.Click
        Dim Private1Path As String = GetPath("Select a Private Key")
        txtPrivate1Path.Text = Private1Path
        My.Settings.Private1Path = Private1Path
    End Sub

    Private Sub btnBrowsePrivate2_Click(sender As Object, e As EventArgs) Handles btnBrowsePrivate2.Click
        Dim Private2Path As String = GetPath("Select a Private Key")
        txtPrivate2Path.Text = Private2Path
        My.Settings.Private2Path = Private2Path
    End Sub

    Private Sub btnBrowsePrivate3_Click(sender As Object, e As EventArgs) Handles btnBrowsePrivate3.Click
        Dim Private3Path As String = GetPath("Select a Private Key")
        txtPrivate3Path.Text = Private3Path
        My.Settings.Private3Path = Private3Path
    End Sub

    Private Sub radEncryptKeyFile_Click(sender As Object, e As EventArgs) Handles radEncryptKeyFile.Click
        txtEncryptKeyFile.Text = GetPath("Select a Public Key File")
        If txtEncryptKeyFile.Text = Nothing Then radEncryptPasteKey.Checked = True
    End Sub

    'Private Sub radEncryptPasteKey_CheckedChanged(sender As Object, e As EventArgs) Handles radEncryptPasteKey.CheckedChanged
    'If radEncryptPasteKey.Checked = False Then txtEncryptPasteKey.Enabled = False Else txtEncryptPasteKey.Enabled = True
    'End Sub

    Private Sub txtEncryptPasteKey_Click(sender As Object, e As EventArgs) Handles txtEncryptPasteKey.Click
        radEncryptPasteKey.Checked = True
    End Sub

    Private Sub radDecryptKeyFile_Click(sender As Object, e As EventArgs) Handles radDecryptKeyFile.Click
        txtDecryptKeyFile.Text = GetPath("Select a Private Key File")
        If txtDecryptKeyFile.Text = Nothing Then radDecryptPasteKey.Checked = True
    End Sub

    'Private Sub radDecryptPasteKey_CheckedChanged(sender As Object, e As EventArgs) Handles radDecryptPasteKey.CheckedChanged
    'If radDecryptPasteKey.Checked = False Then txtDecryptPasteKey.Enabled = False Else txtDecryptPasteKey.Enabled = True
    'End Sub

    Private Sub txtDecryptPasteKey_Click(sender As Object, e As EventArgs) Handles txtDecryptPasteKey.Click
        radDecryptPasteKey.Checked = True
    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles btnEncrypt.Click
        Dim InputFilePath As String
        Dim InputKeyPath As String
        Dim OutputFilePath As String

        If File.Exists(Directory.GetCurrentDirectory + "\EncryptPasteKey.asc") Then File.Delete(Directory.GetCurrentDirectory + "\EncryptPasteKey.asc")
        If File.Exists(Directory.GetCurrentDirectory + "\EncryptPasteMessage.txt") Then File.Delete(Directory.GetCurrentDirectory + "\EncryptPasteMessage.txt")

        If radEncryptFile.Checked Then
            InputFilePath = txtEncryptFile.Text
        Else
            'Make txtEncryptPasteMessage.Text contents into a file and use that file's path at InputFilePath
            Dim TempMessagePath As String = Directory.GetCurrentDirectory + "\EncryptPasteMessage.txt"
            Using outputFile As New StreamWriter(TempMessagePath)
                outputFile.WriteLine(txtEncryptPasteMessage.Text)
            End Using
            InputFilePath = TempMessagePath
        End If


        If cmbPublicSaved.SelectedItem = SpecifyMessage Then
            If radEncryptKeyFile.Checked Then
                InputKeyPath = txtEncryptKeyFile.Text
            Else
                'Make txtEncryptPasteKey.Text contents into a file and use that file's path as InputKeyPath
                Dim TempKeyPath As String = Directory.GetCurrentDirectory + "\EncryptPasteKey.asc"
                Using outputFile As New StreamWriter(TempKeyPath)
                    outputFile.WriteLine(txtEncryptPasteKey.Text)
                End Using
                InputKeyPath = TempKeyPath
            End If
        ElseIf cmbPublicSaved.SelectedItem = "Use Public Key 1" Then
            InputKeyPath = My.Settings.Public1Path
        ElseIf cmbPublicSaved.SelectedItem = "Use Public Key 2" Then
            InputKeyPath = My.Settings.Public2Path
        ElseIf cmbPublicSaved.SelectedItem = "Use Public Key 3" Then
            InputKeyPath = My.Settings.Public3Path
        End If



        Dim SaveOutput As SaveFileDialog = New SaveFileDialog()
        SaveOutput.Title = "Save your encrypted file or message"
        SaveOutput.Filter = "All files (*.*)|*.*"
        SaveOutput.RestoreDirectory = True

        If SaveOutput.ShowDialog() = DialogResult.OK Then
            OutputFilePath = SaveOutput.FileName
            Try
                PGPLib.EncryptFile(InputFilePath, OutputFilePath, InputKeyPath, True, False)
            Catch ex As Exception
                MsgBox("Failed to encrypt. Please check that you entered a valid public key and try again.", MsgBoxStyle.Critical)
            End Try
            If File.Exists(Directory.GetCurrentDirectory + "\EncryptPasteKey.asc") Then File.Delete(Directory.GetCurrentDirectory + "\EncryptPasteKey.asc")
            If File.Exists(Directory.GetCurrentDirectory + "\EncryptPasteMessage.txt") Then File.Delete(Directory.GetCurrentDirectory + "\EncryptPasteMessage.txt")
        Else
            InputFilePath = Nothing
            InputKeyPath = Nothing
            OutputFilePath = Nothing
            Exit Sub
        End If
    End Sub

    Private Sub txtEncryptPasteMessage_Click(sender As Object, e As EventArgs) Handles txtEncryptPasteMessage.Click
        radEncryptPasteMessage.Checked = True
    End Sub

    Private Sub radEncryptFile_Click(sender As Object, e As EventArgs) Handles radEncryptFile.Click
        txtEncryptFile.Text = GetPath("Select a File to Encrypt", "All files (*.*)|*.*")
        If txtEncryptFile.Text = Nothing Then radEncryptPasteMessage.Checked = True
    End Sub

    Private Sub cmbPublicSaved_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPublicSaved.SelectedIndexChanged
        If cmbPublicSaved.SelectedItem = SpecifyMessage Then
            pnlEncryptPublicKey.Enabled = True
        Else
            pnlEncryptPublicKey.Enabled = False
        End If
    End Sub

    Private Sub txtDecryptPasteMessage_Click(sender As Object, e As EventArgs) Handles txtDecryptPasteMessage.Click
        radDecryptPasteMessage.Checked = True
    End Sub

    Private Sub radDecryptFile_Click(sender As Object, e As EventArgs) Handles radDecryptFile.Click
        txtDecryptFile.Text = GetPath("Select a File to Decrypt", "All files (*.*)|*.*")
        If txtDecryptFile.Text = Nothing Then radDecryptPasteMessage.Checked = True
    End Sub

    Private Sub cmbPrivateSaved_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPrivateSaved.SelectedIndexChanged
        If cmbPrivateSaved.SelectedItem = SpecifyMessage Then
            pnlDecryptPrivateKey.Enabled = True
        Else
            pnlDecryptPrivateKey.Enabled = False
        End If
    End Sub

    Private Sub txtGeneratePass_Click(sender As Object, e As EventArgs) Handles txtGeneratePass.Click
        If txtGeneratePass.Text = "Passphrase" Then txtGeneratePass.Text = String.Empty
        txtGeneratePass.UseSystemPasswordChar = True
    End Sub

    Private Sub txtGenerateUser_Click(sender As Object, e As EventArgs) Handles txtGenerateUser.Click
        If txtGenerateUser.Text = "Email Address (Optional)" Then txtGenerateUser.Text = String.Empty
    End Sub

    Private Sub txtGenerateConfirm_Click(sender As Object, e As EventArgs) Handles txtGenerateConfirm.Click
        If txtGenerateConfirm.Text = "Confirm Passphrase" Then txtGenerateConfirm.Text = String.Empty
        txtGenerateConfirm.UseSystemPasswordChar = True
    End Sub

    Private Sub btnDecrypt_Click(sender As Object, e As EventArgs) Handles btnDecrypt.Click
        Dim InputFilePath As String
        Dim InputKeyPath As String
        Dim OutputFilePath As String
        Dim KeyPassphrase As String

        If File.Exists(Directory.GetCurrentDirectory + "\DecryptPasteKey.asc") Then File.Delete(Directory.GetCurrentDirectory + "\DecryptPasteKey.asc")
        If File.Exists(Directory.GetCurrentDirectory + "\DecryptPasteMessage.txt") Then File.Delete(Directory.GetCurrentDirectory + "\DecryptPasteMessage.txt")

        'This line might look messy, but it serves two purposes. One, to recognise the manually centered text, but second to allow someone in the unlikely event to actually use "Private Key Passphrase" as a passphrase.
        If txtKeyPassphrase.Text = "                                                  Private Key Passphrase" Then txtKeyPassphrase.Text = String.Empty

        KeyPassphrase = txtKeyPassphrase.Text

        If radDecryptFile.Checked Then
            InputFilePath = txtDecryptFile.Text
        Else
            'Make txtDecryptPasteMessage.Text contents into a file and use that file's path at InputFilePath
            Dim TempMessagePath As String = Directory.GetCurrentDirectory + "\DecryptPasteMessage.txt"
            Using outputFile As New StreamWriter(TempMessagePath)
                outputFile.WriteLine(txtDecryptPasteMessage.Text)
            End Using
            InputFilePath = TempMessagePath
        End If


        If cmbPrivateSaved.SelectedItem = SpecifyMessage Then
            If radDecryptKeyFile.Checked Then
                InputKeyPath = txtDecryptKeyFile.Text
            Else
                'Make txtDecryptPasteKey.Text contents into a file and use that file's path as InputKeyPath
                Dim TempKeyPath As String = Directory.GetCurrentDirectory + "\DecryptPasteKey.asc"
                Using outputFile As New StreamWriter(TempKeyPath)
                    outputFile.WriteLine(txtDecryptPasteKey.Text)
                End Using
                InputKeyPath = TempKeyPath
            End If
        ElseIf cmbPrivateSaved.SelectedItem = "Use Private Key 1" Then
            InputKeyPath = My.Settings.Private1Path
        ElseIf cmbPrivateSaved.SelectedItem = "Use Private Key 2" Then
            InputKeyPath = My.Settings.Private2Path
        ElseIf cmbPrivateSaved.SelectedItem = "Use Private Key 3" Then
            InputKeyPath = My.Settings.Private3Path
        End If



        Dim SaveOutput As SaveFileDialog = New SaveFileDialog()
        SaveOutput.Title = "Save your Decrypted file or message"
        SaveOutput.Filter = "All files (*.*)|*.*"
        SaveOutput.RestoreDirectory = True

        If SaveOutput.ShowDialog() = DialogResult.OK Then
            OutputFilePath = SaveOutput.FileName
            Try
                PGPLib.DecryptFile(InputFilePath, OutputFilePath, InputKeyPath, KeyPassphrase)
            Catch ex As Exception
                MsgBox("Failed to decrypt. Please check that you entered a valid private key and relevant passphrase, and try again.", MsgBoxStyle.Critical)
            End Try
            If File.Exists(Directory.GetCurrentDirectory + "\DecryptPasteKey.asc") Then File.Delete(Directory.GetCurrentDirectory + "\DecryptPasteKey.asc")
            If File.Exists(Directory.GetCurrentDirectory + "\DecryptPasteMessage.txt") Then File.Delete(Directory.GetCurrentDirectory + "\DecryptPasteMessage.txt")
        Else
            InputFilePath = Nothing
            InputKeyPath = Nothing
            OutputFilePath = Nothing
            Exit Sub
        End If
    End Sub

    Private Sub txtKeyPassphrase_Click(sender As Object, e As EventArgs) Handles txtKeyPassphrase.Click
        If txtKeyPassphrase.Text = "                                                  Private Key Passphrase" Then
            txtKeyPassphrase.UseSystemPasswordChar = True
            txtKeyPassphrase.Text = String.Empty
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://maeganetwork.com/")
    End Sub
End Class
