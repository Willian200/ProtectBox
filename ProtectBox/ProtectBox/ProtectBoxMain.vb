Imports System.IO
Imports System.Security
Imports System.Security.Cryptography

Public Class ProtectBoxMain

    Dim strFileToEncrypt As String
    Dim strFileToDecrypt As String
    Dim strOutputEncrypt As String
    Dim strOutputDecrypt As String
    Dim fsInput As System.IO.FileStream
    Dim fsOutput As System.IO.FileStream


#Region "2. Create A Key "

    '*************************
    '** Create A Key
    '*************************

    Private Function CreateKey(ByVal strPassword As String) As Byte()
        'Convert strPassword to an array and store in chrData.
        Dim chrData() As Char = strPassword.ToCharArray
        'Use intLength to get strPassword size.
        Dim intLength As Integer = chrData.GetUpperBound(0)
        'Declare bytDataToHash and make it the same size as chrData.
        Dim bytDataToHash(intLength) As Byte

        'Use For Next to convert and store chrData into bytDataToHash.
        For i As Integer = 0 To chrData.GetUpperBound(0)
            bytDataToHash(i) = CByte(Asc(chrData(i)))
        Next

        'Declare what hash to use.
        Dim SHA512 As New System.Security.Cryptography.SHA512Managed
        'Declare bytResult, Hash bytDataToHash and store it in bytResult.
        Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
        'Declare bytKey(31).  It will hold 256 bits.
        Dim bytKey(31) As Byte

        'Use For Next to put a specific size (256 bits) of 
        'bytResult into bytKey. The 0 To 31 will put the first 256 bits
        'of 512 bits into bytKey.
        For i As Integer = 0 To 31
            bytKey(i) = bytResult(i)
        Next

        Return bytKey 'Return the key.
    End Function

#End Region


#Region "3. Create An IV "

    '*************************
    '** Create An IV
    '*************************

    Private Function CreateIV(ByVal strPassword As String) As Byte()
        'Convert strPassword to an array and store in chrData.
        Dim chrData() As Char = strPassword.ToCharArray
        'Use intLength to get strPassword size.
        Dim intLength As Integer = chrData.GetUpperBound(0)
        'Declare bytDataToHash and make it the same size as chrData.
        Dim bytDataToHash(intLength) As Byte

        'Use For Next to convert and store chrData into bytDataToHash.
        For i As Integer = 0 To chrData.GetUpperBound(0)
            bytDataToHash(i) = CByte(Asc(chrData(i)))
        Next

        'Declare what hash to use.
        Dim SHA512 As New System.Security.Cryptography.SHA512Managed
        'Declare bytResult, Hash bytDataToHash and store it in bytResult.
        Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
        'Declare bytIV(15).  It will hold 128 bits.
        Dim bytIV(15) As Byte

        'Use For Next to put a specific size (128 bits) of 
        'bytResult into bytIV. The 0 To 30 for bytKey used the first 256 bits.
        'of the hashed password. The 32 To 47 will put the next 128 bits into bytIV.
        For i As Integer = 32 To 47
            bytIV(i - 32) = bytResult(i)
        Next

        Return bytIV 'return the IV
    End Function

#End Region


#Region "4. Encrypt / Decrypt File "

    '****************************
    '** Encrypt/Decrypt File
    '****************************

    Private Enum CryptoAction
        'Define the enumeration for CryptoAction.
        ActionEncrypt = 1
        ActionDecrypt = 2
    End Enum

    Private Sub EncryptOrDecryptFile(ByVal strInputFile As String,
                                     ByVal strOutputFile As String,
                                     ByVal bytKey() As Byte,
                                     ByVal bytIV() As Byte,
                                     ByVal Direction As CryptoAction)
        Try 'In case of errors.

            'Setup file streams to handle input and output.
            fsInput = New System.IO.FileStream(strInputFile, FileMode.Open,
                                               FileAccess.Read)
            fsOutput = New System.IO.FileStream(strOutputFile, FileMode.OpenOrCreate,
                                                FileAccess.Write)
            fsOutput.SetLength(0) 'make sure fsOutput is empty

            'Declare variables for encrypt/decrypt process.
            Dim bytBuffer(4096) As Byte 'holds a block of bytes for processing
            Dim lngBytesProcessed As Long = 0 'running count of bytes processed
            Dim lngFileLength As Long = fsInput.Length 'the input file's length
            Dim intBytesInCurrentBlock As Integer 'current bytes being processed
            Dim csCryptoStream As CryptoStream
            'Declare your CryptoServiceProvider.
            Dim cspRijndael As New System.Security.Cryptography.RijndaelManaged
            'Setup Progress Bar
            XylosProgressBar1.Value = 0
            XylosProgressBar1.Maximum = 100

            'Determine if ecryption or decryption and setup CryptoStream.
            Select Case Direction
                Case CryptoAction.ActionEncrypt
                    csCryptoStream = New CryptoStream(fsOutput,
                    cspRijndael.CreateEncryptor(bytKey, bytIV),
                    CryptoStreamMode.Write)

                Case CryptoAction.ActionDecrypt
                    csCryptoStream = New CryptoStream(fsOutput,
                    cspRijndael.CreateDecryptor(bytKey, bytIV),
                    CryptoStreamMode.Write)
            End Select

            'Use While to loop until all of the file is processed.
            While lngBytesProcessed < lngFileLength
                'Read file with the input filestream.
                intBytesInCurrentBlock = fsInput.Read(bytBuffer, 0, 4096)
                'Write output file with the cryptostream.
                csCryptoStream.Write(bytBuffer, 0, intBytesInCurrentBlock)
                'Update lngBytesProcessed
                lngBytesProcessed = lngBytesProcessed + CLng(intBytesInCurrentBlock)
                'Update Progress Bar
                XylosProgressBar1.Value = CInt((lngBytesProcessed / lngFileLength) * 100)
            End While

            'Close FileStreams and CryptoStream.
            csCryptoStream.Close()
            fsInput.Close()
            fsOutput.Close()

            'If encrypting then delete the original unencrypted file.
            If Direction = CryptoAction.ActionEncrypt Then
                Dim fileOriginal As New FileInfo(strFileToEncrypt)
                fileOriginal.Delete()
            End If

            'If decrypting then delete the encrypted file.
            If Direction = CryptoAction.ActionDecrypt Then
                Dim fileEncrypted As New FileInfo(strFileToDecrypt)
                fileEncrypted.Delete()
            End If

            'Update the user when the file is done.
            Dim Wrap As String = Chr(13) + Chr(10)
            If Direction = CryptoAction.ActionEncrypt Then
                MsgBox("Encryption Complete" + Wrap + Wrap +
                        "Total bytes processed = " +
                        lngBytesProcessed.ToString,
                        MsgBoxStyle.Information, "Done")

                'Update the progress bar and textboxes.
                XylosProgressBar1.Value = 0
                txtFileToEncrypt.Text = "Click Browse to load file."
                txtPassEncrypt.Text = ""

                txtDestinationEncrypt.Text = ""
                btnEncrypt.Enabled = False

            Else
                'Update the user when the file is done.
                MsgBox("Decryption Complete" + Wrap + Wrap +
                       "Total bytes processed = " +
                        lngBytesProcessed.ToString,
                        MsgBoxStyle.Information, "Done")

                'Update the progress bar and textboxes.
                XylosProgressBar1.Value = 0
                txtFileToDecrypt.Text = "Click Browse to load file."
                txtPassDecrypt.Text = ""
                txtConPassEncrypt.Text = ""
                txtDestinationDecrypt.Text = ""

                btnDecrypt.Enabled = False
            End If


            'Catch file not found error.
        Catch When Err.Number = 53 'if file not found
            MsgBox("Please check to make sure the path and filename" +
                    "are correct and if the file exists.",
                     MsgBoxStyle.Exclamation, "Invalid Path or Filename")

            'Catch all other errors. And delete partial files.
        Catch
            fsInput.Close()
            fsOutput.Close()

            If Direction = CryptoAction.ActionDecrypt Then
                Dim fileDelete As New FileInfo(txtDestinationDecrypt.Text)
                fileDelete.Delete()
                XylosProgressBar1.Value = 0
                txtPassDecrypt.Text = ""
                txtConPassEncrypt.Text = ""

                MsgBox("Please check to make sure that you entered the correct" +
                        "password.", MsgBoxStyle.Exclamation, "Invalid Password")
            Else
                Dim fileDelete As New FileInfo(txtDestinationEncrypt.Text)
                fileDelete.Delete()

                XylosProgressBar1.Value = 0
                txtPassEncrypt.Text = ""
                txtConPassEncrypt.Text = ""

                MsgBox("This file cannot be encrypted.",
                        MsgBoxStyle.Exclamation, "Invalid File")

            End If

        End Try
    End Sub

#End Region


#Region "5. Browse / Change Button "

    '******************************
    '** Browse/Change Buttons
    '******************************

    Private Sub btnBrowseEncrypt_Click(ByVal sender As System.Object,
                                       ByVal e As System.EventArgs) _
                                       Handles btnBrowseEncrypt.Click


        Dim Abrir As New OpenFileDialog()
        Abrir.FileName = ""
        Abrir.Title = "Choose a file to encrypt"
        Abrir.InitialDirectory = "C:\"
        Abrir.Filter = "All Files (*.*) | *.*"

        'Find out if the user chose a file.
        If Abrir.ShowDialog = DialogResult.OK Then
            strFileToEncrypt = Abrir.FileName
            txtFileToEncrypt.Text = strFileToEncrypt

            Dim iPosition As Integer = 0
            Dim i As Integer = 0

            'Get the position of the last "\" in the OpenFileDialog.FileName path.
            '-1 is when the character your searching for is not there.
            'IndexOf searches from left to right.
            While strFileToEncrypt.IndexOf("\"c, i) <> -1
                iPosition = strFileToEncrypt.IndexOf("\"c, i)
                i = iPosition + 1
            End While

            'Assign strOutputFile to the position after the last "\" in the path.
            'This position is the beginning of the file name.
            strOutputEncrypt = strFileToEncrypt.Substring(iPosition + 1)
            'Assign S the entire path, ending at the last "\".
            Dim S As String = strFileToEncrypt.Substring(0, iPosition + 1)
            'Replace the "." in the file extension with "_".
            strOutputEncrypt = strOutputEncrypt.Replace("."c, "_"c)
            'The final file name.  XXXXX.encrypt
            txtDestinationEncrypt.Text = S + strOutputEncrypt + ".encrypt"
            'Update buttons.
            btnEncrypt.Enabled = True

        End If

    End Sub

    Private Sub btnBrowseDecrypt_Click(ByVal sender As System.Object,
                                       ByVal e As System.EventArgs) Handles btnBrowserDecrypt.Click

        Dim BrowserDecrypt As New OpenFileDialog()
        'Setup the open dialog.
        BrowserDecrypt.FileName = ""
        BrowserDecrypt.Title = "Choose a file to decrypt"
        BrowserDecrypt.InitialDirectory = "C:\"
        BrowserDecrypt.Filter = "Encrypted Files (*.encrypt) | *.encrypt"

        'Find out if the user chose a file.
        If BrowserDecrypt.ShowDialog = DialogResult.OK Then
            strFileToDecrypt = BrowserDecrypt.FileName
            txtFileToDecrypt.Text = strFileToDecrypt
            Dim iPosition As Integer = 0
            Dim i As Integer = 0
            'Get the position of the last "\" in the OpenFileDialog.FileName path.
            '-1 is when the character your searching for is not there.
            'IndexOf searches from left to right.

            While strFileToDecrypt.IndexOf("\"c, i) <> -1
                iPosition = strFileToDecrypt.IndexOf("\"c, i)
                i = iPosition + 1
            End While

            'strOutputFile = the file path minus the last 8 characters (.encrypt)
            strOutputDecrypt = strFileToDecrypt.Substring(0, strFileToDecrypt.Length - 8)
            'Assign S the entire path, ending at the last "\".
            Dim S As String = strFileToDecrypt.Substring(0, iPosition + 1)
            'Assign strOutputFile to the position after the last "\" in the path.
            strOutputDecrypt = strOutputDecrypt.Substring((iPosition + 1))
            'Replace "_" with "."
            txtDestinationDecrypt.Text = S + strOutputDecrypt.Replace("_"c, "."c)
            'Update buttons
            btnDecrypt.Enabled = True

        End If
    End Sub



#End Region


#Region "6. Encrypt / Decrypt Buttons "

    '******************************
    '** Encrypt/Decrypt Buttons
    '******************************

    Private Sub btnEncrypt_Click(ByVal sender As System.Object,
                                 ByVal e As System.EventArgs) _
                                 Handles btnEncrypt.Click
        'Make sure the password is correct.
        If txtConPassEncrypt.Text = txtPassEncrypt.Text Then
            'Declare variables for the key and iv.
            'The key needs to hold 256 bits and the iv 128 bits.
            Dim bytKey As Byte()
            Dim bytIV As Byte()
            'Send the password to the CreateKey function.
            bytKey = CreateKey(txtPassEncrypt.Text)
            'Send the password to the CreateIV function.
            bytIV = CreateIV(txtPassEncrypt.Text)
            'Start the encryption.
            EncryptOrDecryptFile(strFileToEncrypt, txtDestinationEncrypt.Text,
                                 bytKey, bytIV, CryptoAction.ActionEncrypt)
        Else
            MsgBox("Please re-enter your password.", MsgBoxStyle.Exclamation)
            txtPassEncrypt.Text = ""
            txtConPassEncrypt.Text = ""
        End If
    End Sub

    Private Sub btnDecrypt_Click(ByVal sender As System.Object,
                                 ByVal e As System.EventArgs) _
                                 Handles btnDecrypt.Click
        'Make sure the password is correct.
        If txtConPassEncrypt.Text = txtPassDecrypt.Text Then
            'Declare variables for the key and iv.
            'The key needs to hold 256 bits and the iv 128 bits.
            Dim bytKey As Byte()
            Dim bytIV As Byte()
            'Send the password to the CreateKey function.
            bytKey = CreateKey(txtPassDecrypt.Text)
            'Send the password to the CreateIV function.
            bytIV = CreateIV(txtPassDecrypt.Text)
            'Start the decryption.
            EncryptOrDecryptFile(strFileToDecrypt, txtDestinationDecrypt.Text,
                                 bytKey, bytIV, CryptoAction.ActionDecrypt)
        Else
            MsgBox("Please re-enter your password.", MsgBoxStyle.Exclamation)
            txtPassDecrypt.Text = ""
            txtConPassEncrypt.Text = ""
        End If
    End Sub

    Private Sub btnChangeEncrypt_Click(ByVal sender As System.Object,
                                       ByVal e As System.EventArgs) _
                                       Handles btnChangeEncrypt.Click
        Dim fb As New FolderBrowserDialog()

        'Setup up folder browser.
        fb.Description = "Selecione a Pasta Para Salvar"
        'If the user selected a folder assign the path to txtDestinationEncrypt.
        If fb.ShowDialog = DialogResult.OK Then
            txtDestinationEncrypt.Text = fb.SelectedPath +
                                         "\" + strOutputEncrypt + ".encrypt"
        End If

    End Sub



    Private Sub btnChangeDecrypt_Click(ByVal sender As System.Object,
                                       ByVal e As System.EventArgs) _
                                       Handles btnBrowserDecrypt.Click


        Dim fbr As New FolderBrowserDialog()
        'Setup up folder browser.
        fbr.Description = "Select a folder for to place the decrypted file in."
        'If the user selected a folder assign the path to txtDestinationDecrypt.
        If fbr.ShowDialog = DialogResult.OK Then
            txtDestinationDecrypt.Text = fbr.SelectedPath +
                                         "\" + strOutputDecrypt.Replace("_"c, "."c)
        End If
    End Sub








#End Region




End Class


