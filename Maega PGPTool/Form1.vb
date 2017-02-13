Imports MaterialSkin
Public Class Form1
    Dim PGPLib As New ChoPGPEncryptDecrypt

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        cmbSaved.Items.Clear()
        cmbSaved.Items.Add("Specify a key - Don't use a saved key")
        If My.Settings.Key1Enabled Then cmbSaved.Items.Add("Use " + My.Settings.Key1Name)
        If My.Settings.Key2Enabled Then cmbSaved.Items.Add("Use " + My.Settings.Key2Name)
        If My.Settings.Key3Enabled Then cmbSaved.Items.Add("Use " + My.Settings.Key3Name)
        cmbSaved.SelectedItem = "Specify a key - Don't use a saved key"
    End Sub

    Private Sub btnSelectGenerate_Click(sender As Object, e As EventArgs) Handles btnSelectGenerate.Click
        tabControlMain.SelectedTab = tabGenerate
    End Sub
    Private Sub btnSelectEncrypt_Click(sender As Object, e As EventArgs) Handles btnSelectEncrypt.Click
        tabControlMain.SelectedTab = tabEncrypt
    End Sub
    Private Sub btnSelectDecrypt_Click(sender As Object, e As EventArgs) Handles btnSelectDecrypt.Click
        tabControlMain.SelectedTab = tabDecrypt
    End Sub

    Private Sub MaterialRaisedButton1_Click_1(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        Dim fd As SaveFileDialog = New SaveFileDialog()
        Dim PublicKeyPath As String
        Dim PrivateKeyPath As String

        fd.Title = "Save your public key file"
        'fd.InitialDirectory = "C:\"
        fd.FileName = "public.asc"
        fd.Filter = "PGP ASCII Armored File (*.asc)|*.asc|All files (*.*)|*.*"
        fd.FilterIndex = 1
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            PublicKeyPath = fd.FileName
            fd.Title = "Save your private key file"
            fd.FileName = "private.asc"

            If fd.ShowDialog() = DialogResult.OK Then
                PrivateKeyPath = fd.FileName
                PGPLib.GenerateKey(PublicKeyPath, PrivateKeyPath, txtGenerateUser.Text, txtGeneratePass.Text)
                MsgBox("Your PGP Key Pair was created successfully!", MsgBoxStyle.Information)
            End If

        End If
    End Sub

    Private Sub btnBrowsePublic1_Click(sender As Object, e As EventArgs) Handles btnBrowsePublic1.Click
        txtPublicKey1.Text = GetPath("Select a Public Key")
    End Sub

    Private Function GetPath(title As String)
        Dim BrowseKey As OpenFileDialog = New OpenFileDialog()
        BrowseKey.Title = title
        BrowseKey.Filter = "PGP ASCII Armored File (*.asc)|*.asc|All files (*.*)|*.*"
        BrowseKey.FilterIndex = 1
        BrowseKey.RestoreDirectory = True

        If BrowseKey.ShowDialog() = DialogResult.OK Then
            Return BrowseKey.FileName
        Else
            Return Nothing
        End If
    End Function

    Private Sub btnBrowsePrivate1_Click(sender As Object, e As EventArgs) Handles btnBrowsePrivate1.Click
        txtPrivateKey1.Text = GetPath("Select a Private Key")
    End Sub
End Class
