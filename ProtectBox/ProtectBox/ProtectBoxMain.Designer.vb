<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProtectBoxMain
    Inherits Metro.Form

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
        Me.XylosTabControl1 = New ProtectBox.XylosTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnEncrypt = New Glass.GlassButton()
        Me.XylosProgressBar1 = New ProtectBox.XylosProgressBar()
        Me.txtConPassEncrypt = New ProtectBox.XylosTextBox()
        Me.txtPassEncrypt = New ProtectBox.XylosTextBox()
        Me.btnChangeEncrypt = New ProtectBox.XylosButton()
        Me.btnBrowseEncrypt = New ProtectBox.XylosButton()
        Me.txtDestinationEncrypt = New ProtectBox.XylosTextBox()
        Me.txtFileToEncrypt = New ProtectBox.XylosTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnDecrypt = New Glass.GlassButton()
        Me.XylosTextBox7 = New ProtectBox.XylosTextBox()
        Me.txtPassDecrypt = New ProtectBox.XylosTextBox()
        Me.btnBrowserDecrypt = New ProtectBox.XylosButton()
        Me.btnDestinoDecrypt = New ProtectBox.XylosButton()
        Me.txtDestinationDecrypt = New ProtectBox.XylosTextBox()
        Me.txtFileToDecrypt = New ProtectBox.XylosTextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.XylosTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'XylosTabControl1
        '
        Me.XylosTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.XylosTabControl1.Controls.Add(Me.TabPage1)
        Me.XylosTabControl1.Controls.Add(Me.TabPage2)
        Me.XylosTabControl1.Controls.Add(Me.TabPage3)
        Me.XylosTabControl1.Controls.Add(Me.TabPage4)
        Me.XylosTabControl1.Controls.Add(Me.TabPage5)
        Me.XylosTabControl1.Controls.Add(Me.TabPage6)
        Me.XylosTabControl1.FirstHeaderBorder = False
        Me.XylosTabControl1.ItemSize = New System.Drawing.Size(40, 180)
        Me.XylosTabControl1.Location = New System.Drawing.Point(6, 29)
        Me.XylosTabControl1.Multiline = True
        Me.XylosTabControl1.Name = "XylosTabControl1"
        Me.XylosTabControl1.SelectedIndex = 0
        Me.XylosTabControl1.Size = New System.Drawing.Size(524, 348)
        Me.XylosTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.XylosTabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.btnEncrypt)
        Me.TabPage1.Controls.Add(Me.XylosProgressBar1)
        Me.TabPage1.Controls.Add(Me.txtConPassEncrypt)
        Me.TabPage1.Controls.Add(Me.txtPassEncrypt)
        Me.TabPage1.Controls.Add(Me.btnChangeEncrypt)
        Me.TabPage1.Controls.Add(Me.btnBrowseEncrypt)
        Me.TabPage1.Controls.Add(Me.txtDestinationEncrypt)
        Me.TabPage1.Controls.Add(Me.txtFileToEncrypt)
        Me.TabPage1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.TabPage1.Location = New System.Drawing.Point(184, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(336, 340)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Criptografar"
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Location = New System.Drawing.Point(17, 267)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(109, 25)
        Me.btnEncrypt.TabIndex = 7
        Me.btnEncrypt.Text = "Criptografar"
        '
        'XylosProgressBar1
        '
        Me.XylosProgressBar1.BackColor = System.Drawing.Color.Gray
        Me.XylosProgressBar1.BackgroundColor = System.Drawing.Color.Green
        Me.XylosProgressBar1.Location = New System.Drawing.Point(17, 298)
        Me.XylosProgressBar1.Maximum = 100
        Me.XylosProgressBar1.Minimum = 0
        Me.XylosProgressBar1.Name = "XylosProgressBar1"
        Me.XylosProgressBar1.Size = New System.Drawing.Size(179, 23)
        Me.XylosProgressBar1.Stripes = System.Drawing.Color.DarkGreen
        Me.XylosProgressBar1.TabIndex = 6
        Me.XylosProgressBar1.Text = "XylosProgressBar1"
        Me.XylosProgressBar1.Value = 0
        '
        'txtConPassEncrypt
        '
        Me.txtConPassEncrypt.BackColor = System.Drawing.Color.Gray
        Me.txtConPassEncrypt.EnabledCalc = True
        Me.txtConPassEncrypt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtConPassEncrypt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtConPassEncrypt.Location = New System.Drawing.Point(17, 230)
        Me.txtConPassEncrypt.MaxLength = 32767
        Me.txtConPassEncrypt.MultiLine = False
        Me.txtConPassEncrypt.Name = "txtConPassEncrypt"
        Me.txtConPassEncrypt.ReadOnly = False
        Me.txtConPassEncrypt.Size = New System.Drawing.Size(238, 29)
        Me.txtConPassEncrypt.TabIndex = 5
        Me.txtConPassEncrypt.Text = "Digite a Senha Novamente"
        Me.txtConPassEncrypt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtConPassEncrypt.UseSystemPasswordChar = False
        '
        'txtPassEncrypt
        '
        Me.txtPassEncrypt.BackColor = System.Drawing.Color.Gray
        Me.txtPassEncrypt.EnabledCalc = True
        Me.txtPassEncrypt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPassEncrypt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtPassEncrypt.Location = New System.Drawing.Point(17, 195)
        Me.txtPassEncrypt.MaxLength = 32767
        Me.txtPassEncrypt.MultiLine = False
        Me.txtPassEncrypt.Name = "txtPassEncrypt"
        Me.txtPassEncrypt.ReadOnly = False
        Me.txtPassEncrypt.Size = New System.Drawing.Size(238, 29)
        Me.txtPassEncrypt.TabIndex = 4
        Me.txtPassEncrypt.Text = "Insira Senha"
        Me.txtPassEncrypt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtPassEncrypt.UseSystemPasswordChar = False
        '
        'btnChangeEncrypt
        '
        Me.btnChangeEncrypt.EnabledCalc = True
        Me.btnChangeEncrypt.Location = New System.Drawing.Point(261, 91)
        Me.btnChangeEncrypt.Name = "btnChangeEncrypt"
        Me.btnChangeEncrypt.Size = New System.Drawing.Size(47, 23)
        Me.btnChangeEncrypt.TabIndex = 3
        Me.btnChangeEncrypt.Text = "..."
        '
        'btnBrowseEncrypt
        '
        Me.btnBrowseEncrypt.EnabledCalc = True
        Me.btnBrowseEncrypt.Location = New System.Drawing.Point(261, 53)
        Me.btnBrowseEncrypt.Name = "btnBrowseEncrypt"
        Me.btnBrowseEncrypt.Size = New System.Drawing.Size(47, 23)
        Me.btnBrowseEncrypt.TabIndex = 2
        Me.btnBrowseEncrypt.Text = "..."
        '
        'txtDestinationEncrypt
        '
        Me.txtDestinationEncrypt.BackColor = System.Drawing.Color.Gray
        Me.txtDestinationEncrypt.EnabledCalc = True
        Me.txtDestinationEncrypt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDestinationEncrypt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtDestinationEncrypt.Location = New System.Drawing.Point(17, 47)
        Me.txtDestinationEncrypt.MaxLength = 32767
        Me.txtDestinationEncrypt.MultiLine = False
        Me.txtDestinationEncrypt.Name = "txtDestinationEncrypt"
        Me.txtDestinationEncrypt.ReadOnly = False
        Me.txtDestinationEncrypt.Size = New System.Drawing.Size(238, 29)
        Me.txtDestinationEncrypt.TabIndex = 1
        Me.txtDestinationEncrypt.Text = "Selecione um local para Salvar"
        Me.txtDestinationEncrypt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtDestinationEncrypt.UseSystemPasswordChar = False
        '
        'txtFileToEncrypt
        '
        Me.txtFileToEncrypt.BackColor = System.Drawing.Color.Gray
        Me.txtFileToEncrypt.EnabledCalc = True
        Me.txtFileToEncrypt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFileToEncrypt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtFileToEncrypt.Location = New System.Drawing.Point(17, 91)
        Me.txtFileToEncrypt.MaxLength = 32767
        Me.txtFileToEncrypt.MultiLine = False
        Me.txtFileToEncrypt.Name = "txtFileToEncrypt"
        Me.txtFileToEncrypt.ReadOnly = False
        Me.txtFileToEncrypt.Size = New System.Drawing.Size(238, 29)
        Me.txtFileToEncrypt.TabIndex = 0
        Me.txtFileToEncrypt.Text = "Selecione um Arquivo Para Criptografar"
        Me.txtFileToEncrypt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtFileToEncrypt.UseSystemPasswordChar = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.btnDecrypt)
        Me.TabPage2.Controls.Add(Me.XylosTextBox7)
        Me.TabPage2.Controls.Add(Me.txtPassDecrypt)
        Me.TabPage2.Controls.Add(Me.btnBrowserDecrypt)
        Me.TabPage2.Controls.Add(Me.btnDestinoDecrypt)
        Me.TabPage2.Controls.Add(Me.txtDestinationDecrypt)
        Me.TabPage2.Controls.Add(Me.txtFileToDecrypt)
        Me.TabPage2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.TabPage2.Location = New System.Drawing.Point(184, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(336, 340)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Descriptografar"
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Location = New System.Drawing.Point(17, 275)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(109, 25)
        Me.btnDecrypt.TabIndex = 10
        Me.btnDecrypt.Text = "Descriptografar"
        '
        'XylosTextBox7
        '
        Me.XylosTextBox7.EnabledCalc = True
        Me.XylosTextBox7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.XylosTextBox7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.XylosTextBox7.Location = New System.Drawing.Point(6, 229)
        Me.XylosTextBox7.MaxLength = 32767
        Me.XylosTextBox7.MultiLine = False
        Me.XylosTextBox7.Name = "XylosTextBox7"
        Me.XylosTextBox7.ReadOnly = False
        Me.XylosTextBox7.Size = New System.Drawing.Size(238, 29)
        Me.XylosTextBox7.TabIndex = 9
        Me.XylosTextBox7.Text = "XylosTextBox7"
        Me.XylosTextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.XylosTextBox7.UseSystemPasswordChar = False
        '
        'txtPassDecrypt
        '
        Me.txtPassDecrypt.EnabledCalc = True
        Me.txtPassDecrypt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPassDecrypt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtPassDecrypt.Location = New System.Drawing.Point(6, 194)
        Me.txtPassDecrypt.MaxLength = 32767
        Me.txtPassDecrypt.MultiLine = False
        Me.txtPassDecrypt.Name = "txtPassDecrypt"
        Me.txtPassDecrypt.ReadOnly = False
        Me.txtPassDecrypt.Size = New System.Drawing.Size(238, 29)
        Me.txtPassDecrypt.TabIndex = 8
        Me.txtPassDecrypt.Text = "Insira a Senha Para Descriptografar"
        Me.txtPassDecrypt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtPassDecrypt.UseSystemPasswordChar = False
        '
        'btnBrowserDecrypt
        '
        Me.btnBrowserDecrypt.EnabledCalc = True
        Me.btnBrowserDecrypt.Location = New System.Drawing.Point(250, 72)
        Me.btnBrowserDecrypt.Name = "btnBrowserDecrypt"
        Me.btnBrowserDecrypt.Size = New System.Drawing.Size(47, 23)
        Me.btnBrowserDecrypt.TabIndex = 7
        Me.btnBrowserDecrypt.Text = "..."
        '
        'btnDestinoDecrypt
        '
        Me.btnDestinoDecrypt.EnabledCalc = True
        Me.btnDestinoDecrypt.Location = New System.Drawing.Point(250, 101)
        Me.btnDestinoDecrypt.Name = "btnDestinoDecrypt"
        Me.btnDestinoDecrypt.Size = New System.Drawing.Size(47, 23)
        Me.btnDestinoDecrypt.TabIndex = 6
        Me.btnDestinoDecrypt.Text = "..."
        '
        'txtDestinationDecrypt
        '
        Me.txtDestinationDecrypt.EnabledCalc = True
        Me.txtDestinationDecrypt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDestinationDecrypt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtDestinationDecrypt.Location = New System.Drawing.Point(6, 101)
        Me.txtDestinationDecrypt.MaxLength = 32767
        Me.txtDestinationDecrypt.MultiLine = False
        Me.txtDestinationDecrypt.Name = "txtDestinationDecrypt"
        Me.txtDestinationDecrypt.ReadOnly = False
        Me.txtDestinationDecrypt.Size = New System.Drawing.Size(238, 29)
        Me.txtDestinationDecrypt.TabIndex = 5
        Me.txtDestinationDecrypt.Text = "Destino"
        Me.txtDestinationDecrypt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtDestinationDecrypt.UseSystemPasswordChar = False
        '
        'txtFileToDecrypt
        '
        Me.txtFileToDecrypt.EnabledCalc = True
        Me.txtFileToDecrypt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFileToDecrypt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtFileToDecrypt.Location = New System.Drawing.Point(6, 66)
        Me.txtFileToDecrypt.MaxLength = 32767
        Me.txtFileToDecrypt.MultiLine = False
        Me.txtFileToDecrypt.Name = "txtFileToDecrypt"
        Me.txtFileToDecrypt.ReadOnly = False
        Me.txtFileToDecrypt.Size = New System.Drawing.Size(238, 29)
        Me.txtFileToDecrypt.TabIndex = 4
        Me.txtFileToDecrypt.Text = "Selecione o Arquivo Para Descriptografar"
        Me.txtFileToDecrypt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtFileToDecrypt.UseSystemPasswordChar = False
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.TabPage3.Location = New System.Drawing.Point(184, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(336, 340)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Automático"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.White
        Me.TabPage4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.TabPage4.Location = New System.Drawing.Point(184, 4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(336, 340)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Adicionar Pastas"
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.White
        Me.TabPage5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.TabPage5.Location = New System.Drawing.Point(184, 4)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(336, 340)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Diretório"
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.White
        Me.TabPage6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.TabPage6.Location = New System.Drawing.Point(184, 4)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(336, 340)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Unlock Dir"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(535, 379)
        Me.Controls.Add(Me.XylosTabControl1)
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.Text = "ProtectBox"
        Me.Controls.SetChildIndex(Me.XylosTabControl1, 0)
        Me.XylosTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents XylosTabControl1 As XylosTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btnChangeEncrypt As XylosButton
    Friend WithEvents btnBrowseEncrypt As XylosButton
    Friend WithEvents txtDestinationEncrypt As XylosTextBox
    Friend WithEvents txtFileToEncrypt As XylosTextBox
    Friend WithEvents btnBrowserDecrypt As XylosButton
    Friend WithEvents btnDestinoDecrypt As XylosButton
    Friend WithEvents txtDestinationDecrypt As XylosTextBox
    Friend WithEvents txtFileToDecrypt As XylosTextBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents txtConPassEncrypt As XylosTextBox
    Friend WithEvents txtPassEncrypt As XylosTextBox
    Friend WithEvents XylosTextBox7 As XylosTextBox
    Friend WithEvents txtPassDecrypt As XylosTextBox
    Friend WithEvents XylosProgressBar1 As XylosProgressBar
    Friend WithEvents btnEncrypt As Glass.GlassButton
    Friend WithEvents btnDecrypt As Glass.GlassButton
End Class
