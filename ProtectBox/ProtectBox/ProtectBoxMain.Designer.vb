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
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GlassButton2 = New Glass.GlassButton()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.CheckBoxAlteraçoes = New System.Windows.Forms.CheckBox()
        Me.GlassButton1 = New Glass.GlassButton()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.GlassButton3 = New Glass.GlassButton()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.GlassButton4 = New Glass.GlassButton()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GlassButton5 = New Glass.GlassButton()
        Me.XylosTextBox1 = New ProtectBox.XylosTextBox()
        Me.XylosTextBox2 = New ProtectBox.XylosTextBox()
        Me.XylosTextBox3 = New ProtectBox.XylosTextBox()
        Me.XylosTextBox4 = New ProtectBox.XylosTextBox()
        Me.GlassButton6 = New Glass.GlassButton()
        Me.XylosTextBox5 = New ProtectBox.XylosTextBox()
        Me.XylosTextBox6 = New ProtectBox.XylosTextBox()
        Me.XylosTextBox8 = New ProtectBox.XylosTextBox()
        Me.XylosTextBox9 = New ProtectBox.XylosTextBox()
        Me.XylosTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.SuspendLayout()
        '
        'XylosTabControl1
        '
        Me.XylosTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.XylosTabControl1.Controls.Add(Me.TabPage1)
        Me.XylosTabControl1.Controls.Add(Me.TabPage2)
        Me.XylosTabControl1.Controls.Add(Me.TabPage3)
        Me.XylosTabControl1.Controls.Add(Me.TabPage4)
        Me.XylosTabControl1.Controls.Add(Me.TabPage6)
        Me.XylosTabControl1.Controls.Add(Me.TabPage5)
        Me.XylosTabControl1.FirstHeaderBorder = False
        Me.XylosTabControl1.ItemSize = New System.Drawing.Size(40, 180)
        Me.XylosTabControl1.Location = New System.Drawing.Point(6, 29)
        Me.XylosTabControl1.Multiline = True
        Me.XylosTabControl1.Name = "XylosTabControl1"
        Me.XylosTabControl1.SelectedIndex = 0
        Me.XylosTabControl1.Size = New System.Drawing.Size(649, 452)
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
        Me.TabPage1.Size = New System.Drawing.Size(461, 444)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Criptografar"
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Location = New System.Drawing.Point(17, 280)
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
        Me.txtConPassEncrypt.Location = New System.Drawing.Point(17, 245)
        Me.txtConPassEncrypt.MaxLength = 32767
        Me.txtConPassEncrypt.MultiLine = False
        Me.txtConPassEncrypt.Name = "txtConPassEncrypt"
        Me.txtConPassEncrypt.ReadOnly = False
        Me.txtConPassEncrypt.Size = New System.Drawing.Size(323, 29)
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
        Me.txtPassEncrypt.Location = New System.Drawing.Point(17, 210)
        Me.txtPassEncrypt.MaxLength = 32767
        Me.txtPassEncrypt.MultiLine = False
        Me.txtPassEncrypt.Name = "txtPassEncrypt"
        Me.txtPassEncrypt.ReadOnly = False
        Me.txtPassEncrypt.Size = New System.Drawing.Size(323, 29)
        Me.txtPassEncrypt.TabIndex = 4
        Me.txtPassEncrypt.Text = "Insira Senha"
        Me.txtPassEncrypt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtPassEncrypt.UseSystemPasswordChar = False
        '
        'btnChangeEncrypt
        '
        Me.btnChangeEncrypt.EnabledCalc = True
        Me.btnChangeEncrypt.Location = New System.Drawing.Point(346, 91)
        Me.btnChangeEncrypt.Name = "btnChangeEncrypt"
        Me.btnChangeEncrypt.Size = New System.Drawing.Size(47, 23)
        Me.btnChangeEncrypt.TabIndex = 3
        Me.btnChangeEncrypt.Text = "..."
        '
        'btnBrowseEncrypt
        '
        Me.btnBrowseEncrypt.EnabledCalc = True
        Me.btnBrowseEncrypt.Location = New System.Drawing.Point(346, 53)
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
        Me.txtDestinationEncrypt.Size = New System.Drawing.Size(323, 29)
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
        Me.txtFileToEncrypt.Size = New System.Drawing.Size(323, 29)
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
        Me.TabPage2.Size = New System.Drawing.Size(461, 444)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Descriptografar"
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Location = New System.Drawing.Point(6, 261)
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
        Me.XylosTextBox7.Location = New System.Drawing.Point(0, 194)
        Me.XylosTextBox7.MaxLength = 32767
        Me.XylosTextBox7.MultiLine = False
        Me.XylosTextBox7.Name = "XylosTextBox7"
        Me.XylosTextBox7.ReadOnly = False
        Me.XylosTextBox7.Size = New System.Drawing.Size(368, 29)
        Me.XylosTextBox7.TabIndex = 9
        Me.XylosTextBox7.Text = "Insira a Senha Novamente"
        Me.XylosTextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.XylosTextBox7.UseSystemPasswordChar = False
        '
        'txtPassDecrypt
        '
        Me.txtPassDecrypt.EnabledCalc = True
        Me.txtPassDecrypt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPassDecrypt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtPassDecrypt.Location = New System.Drawing.Point(0, 159)
        Me.txtPassDecrypt.MaxLength = 32767
        Me.txtPassDecrypt.MultiLine = False
        Me.txtPassDecrypt.Name = "txtPassDecrypt"
        Me.txtPassDecrypt.ReadOnly = False
        Me.txtPassDecrypt.Size = New System.Drawing.Size(368, 29)
        Me.txtPassDecrypt.TabIndex = 8
        Me.txtPassDecrypt.Text = "Insira a Senha Para Descriptografar"
        Me.txtPassDecrypt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtPassDecrypt.UseSystemPasswordChar = False
        '
        'btnBrowserDecrypt
        '
        Me.btnBrowserDecrypt.EnabledCalc = True
        Me.btnBrowserDecrypt.Location = New System.Drawing.Point(386, 66)
        Me.btnBrowserDecrypt.Name = "btnBrowserDecrypt"
        Me.btnBrowserDecrypt.Size = New System.Drawing.Size(47, 23)
        Me.btnBrowserDecrypt.TabIndex = 7
        Me.btnBrowserDecrypt.Text = "..."
        '
        'btnDestinoDecrypt
        '
        Me.btnDestinoDecrypt.EnabledCalc = True
        Me.btnDestinoDecrypt.Location = New System.Drawing.Point(386, 95)
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
        Me.txtDestinationDecrypt.Size = New System.Drawing.Size(362, 29)
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
        Me.txtFileToDecrypt.Size = New System.Drawing.Size(362, 29)
        Me.txtFileToDecrypt.TabIndex = 4
        Me.txtFileToDecrypt.Text = "Selecione o Arquivo Para Descriptografar"
        Me.txtFileToDecrypt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtFileToDecrypt.UseSystemPasswordChar = False
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Controls.Add(Me.CheckBox1)
        Me.TabPage3.Controls.Add(Me.GlassButton2)
        Me.TabPage3.Controls.Add(Me.ListBox1)
        Me.TabPage3.Controls.Add(Me.CheckBoxAlteraçoes)
        Me.TabPage3.Controls.Add(Me.GlassButton1)
        Me.TabPage3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.TabPage3.Location = New System.Drawing.Point(184, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(461, 444)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Automático"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(6, 359)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(132, 19)
        Me.CheckBox1.TabIndex = 12
        Me.CheckBox1.Text = "Incluir Subdiretórios"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GlassButton2
        '
        Me.GlassButton2.Location = New System.Drawing.Point(116, 399)
        Me.GlassButton2.Name = "GlassButton2"
        Me.GlassButton2.Size = New System.Drawing.Size(109, 25)
        Me.GlassButton2.TabIndex = 11
        Me.GlassButton2.Text = "Remover"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(6, 6)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(449, 319)
        Me.ListBox1.TabIndex = 10
        '
        'CheckBoxAlteraçoes
        '
        Me.CheckBoxAlteraçoes.AutoSize = True
        Me.CheckBoxAlteraçoes.Location = New System.Drawing.Point(6, 334)
        Me.CheckBoxAlteraçoes.Name = "CheckBoxAlteraçoes"
        Me.CheckBoxAlteraçoes.Size = New System.Drawing.Size(305, 19)
        Me.CheckBoxAlteraçoes.TabIndex = 9
        Me.CheckBoxAlteraçoes.Text = "Ao ter Alterações Na Pasta Fazer Cópia Criptografada" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.CheckBoxAlteraçoes.UseVisualStyleBackColor = True
        '
        'GlassButton1
        '
        Me.GlassButton1.Location = New System.Drawing.Point(6, 399)
        Me.GlassButton1.Name = "GlassButton1"
        Me.GlassButton1.Size = New System.Drawing.Size(109, 25)
        Me.GlassButton1.TabIndex = 8
        Me.GlassButton1.Text = "Adicionar"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.White
        Me.TabPage4.Controls.Add(Me.CheckBox2)
        Me.TabPage4.Controls.Add(Me.GlassButton3)
        Me.TabPage4.Controls.Add(Me.ListBox2)
        Me.TabPage4.Controls.Add(Me.CheckBox3)
        Me.TabPage4.Controls.Add(Me.GlassButton4)
        Me.TabPage4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.TabPage4.Location = New System.Drawing.Point(184, 4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(461, 444)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Adicionar Pastas"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(6, 366)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(132, 19)
        Me.CheckBox2.TabIndex = 17
        Me.CheckBox2.Text = "Incluir Subdiretórios"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'GlassButton3
        '
        Me.GlassButton3.Location = New System.Drawing.Point(116, 406)
        Me.GlassButton3.Name = "GlassButton3"
        Me.GlassButton3.Size = New System.Drawing.Size(109, 25)
        Me.GlassButton3.TabIndex = 16
        Me.GlassButton3.Text = "Remover"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 15
        Me.ListBox2.Location = New System.Drawing.Point(6, 13)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(449, 319)
        Me.ListBox2.TabIndex = 15
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(6, 341)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(238, 19)
        Me.CheckBox3.TabIndex = 14
        Me.CheckBox3.Text = "Ao Modificar , Deletar , Criar , Renomear"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'GlassButton4
        '
        Me.GlassButton4.Location = New System.Drawing.Point(6, 406)
        Me.GlassButton4.Name = "GlassButton4"
        Me.GlassButton4.Size = New System.Drawing.Size(109, 25)
        Me.GlassButton4.TabIndex = 13
        Me.GlassButton4.Text = "Adicionar"
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.White
        Me.TabPage6.Controls.Add(Me.GlassButton5)
        Me.TabPage6.Controls.Add(Me.XylosTextBox1)
        Me.TabPage6.Controls.Add(Me.XylosTextBox2)
        Me.TabPage6.Controls.Add(Me.XylosTextBox3)
        Me.TabPage6.Controls.Add(Me.XylosTextBox4)
        Me.TabPage6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.TabPage6.Location = New System.Drawing.Point(184, 4)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(461, 444)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Encriptar Path"
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.White
        Me.TabPage5.Controls.Add(Me.GlassButton6)
        Me.TabPage5.Controls.Add(Me.XylosTextBox5)
        Me.TabPage5.Controls.Add(Me.XylosTextBox6)
        Me.TabPage5.Controls.Add(Me.XylosTextBox8)
        Me.TabPage5.Controls.Add(Me.XylosTextBox9)
        Me.TabPage5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.TabPage5.Location = New System.Drawing.Point(184, 4)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(461, 444)
        Me.TabPage5.TabIndex = 6
        Me.TabPage5.Text = "Descript Path"
        '
        'GlassButton5
        '
        Me.GlassButton5.Location = New System.Drawing.Point(29, 284)
        Me.GlassButton5.Name = "GlassButton5"
        Me.GlassButton5.Size = New System.Drawing.Size(109, 25)
        Me.GlassButton5.TabIndex = 12
        Me.GlassButton5.Text = "Criptografar"
        '
        'XylosTextBox1
        '
        Me.XylosTextBox1.BackColor = System.Drawing.Color.Gray
        Me.XylosTextBox1.EnabledCalc = True
        Me.XylosTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.XylosTextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.XylosTextBox1.Location = New System.Drawing.Point(29, 249)
        Me.XylosTextBox1.MaxLength = 32767
        Me.XylosTextBox1.MultiLine = False
        Me.XylosTextBox1.Name = "XylosTextBox1"
        Me.XylosTextBox1.ReadOnly = False
        Me.XylosTextBox1.Size = New System.Drawing.Size(323, 29)
        Me.XylosTextBox1.TabIndex = 11
        Me.XylosTextBox1.Text = "Digite a Senha Novamente"
        Me.XylosTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.XylosTextBox1.UseSystemPasswordChar = False
        '
        'XylosTextBox2
        '
        Me.XylosTextBox2.BackColor = System.Drawing.Color.Gray
        Me.XylosTextBox2.EnabledCalc = True
        Me.XylosTextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.XylosTextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.XylosTextBox2.Location = New System.Drawing.Point(29, 214)
        Me.XylosTextBox2.MaxLength = 32767
        Me.XylosTextBox2.MultiLine = False
        Me.XylosTextBox2.Name = "XylosTextBox2"
        Me.XylosTextBox2.ReadOnly = False
        Me.XylosTextBox2.Size = New System.Drawing.Size(323, 29)
        Me.XylosTextBox2.TabIndex = 10
        Me.XylosTextBox2.Text = "Insira Senha"
        Me.XylosTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.XylosTextBox2.UseSystemPasswordChar = False
        '
        'XylosTextBox3
        '
        Me.XylosTextBox3.BackColor = System.Drawing.Color.Gray
        Me.XylosTextBox3.EnabledCalc = True
        Me.XylosTextBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.XylosTextBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.XylosTextBox3.Location = New System.Drawing.Point(29, 51)
        Me.XylosTextBox3.MaxLength = 32767
        Me.XylosTextBox3.MultiLine = False
        Me.XylosTextBox3.Name = "XylosTextBox3"
        Me.XylosTextBox3.ReadOnly = False
        Me.XylosTextBox3.Size = New System.Drawing.Size(323, 29)
        Me.XylosTextBox3.TabIndex = 9
        Me.XylosTextBox3.Text = "Selecione um local para Salvar"
        Me.XylosTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.XylosTextBox3.UseSystemPasswordChar = False
        '
        'XylosTextBox4
        '
        Me.XylosTextBox4.BackColor = System.Drawing.Color.Gray
        Me.XylosTextBox4.EnabledCalc = True
        Me.XylosTextBox4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.XylosTextBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.XylosTextBox4.Location = New System.Drawing.Point(29, 95)
        Me.XylosTextBox4.MaxLength = 32767
        Me.XylosTextBox4.MultiLine = False
        Me.XylosTextBox4.Name = "XylosTextBox4"
        Me.XylosTextBox4.ReadOnly = False
        Me.XylosTextBox4.Size = New System.Drawing.Size(323, 29)
        Me.XylosTextBox4.TabIndex = 8
        Me.XylosTextBox4.Text = "Selecione um Arquivo Para Criptografar"
        Me.XylosTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.XylosTextBox4.UseSystemPasswordChar = False
        '
        'GlassButton6
        '
        Me.GlassButton6.Location = New System.Drawing.Point(17, 227)
        Me.GlassButton6.Name = "GlassButton6"
        Me.GlassButton6.Size = New System.Drawing.Size(109, 25)
        Me.GlassButton6.TabIndex = 15
        Me.GlassButton6.Text = "Descriptografar"
        '
        'XylosTextBox5
        '
        Me.XylosTextBox5.EnabledCalc = True
        Me.XylosTextBox5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.XylosTextBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.XylosTextBox5.Location = New System.Drawing.Point(11, 160)
        Me.XylosTextBox5.MaxLength = 32767
        Me.XylosTextBox5.MultiLine = False
        Me.XylosTextBox5.Name = "XylosTextBox5"
        Me.XylosTextBox5.ReadOnly = False
        Me.XylosTextBox5.Size = New System.Drawing.Size(368, 29)
        Me.XylosTextBox5.TabIndex = 14
        Me.XylosTextBox5.Text = "Insira a Senha Novamente"
        Me.XylosTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.XylosTextBox5.UseSystemPasswordChar = False
        '
        'XylosTextBox6
        '
        Me.XylosTextBox6.EnabledCalc = True
        Me.XylosTextBox6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.XylosTextBox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.XylosTextBox6.Location = New System.Drawing.Point(11, 125)
        Me.XylosTextBox6.MaxLength = 32767
        Me.XylosTextBox6.MultiLine = False
        Me.XylosTextBox6.Name = "XylosTextBox6"
        Me.XylosTextBox6.ReadOnly = False
        Me.XylosTextBox6.Size = New System.Drawing.Size(368, 29)
        Me.XylosTextBox6.TabIndex = 13
        Me.XylosTextBox6.Text = "Insira a Senha Para Descriptografar"
        Me.XylosTextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.XylosTextBox6.UseSystemPasswordChar = False
        '
        'XylosTextBox8
        '
        Me.XylosTextBox8.EnabledCalc = True
        Me.XylosTextBox8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.XylosTextBox8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.XylosTextBox8.Location = New System.Drawing.Point(17, 67)
        Me.XylosTextBox8.MaxLength = 32767
        Me.XylosTextBox8.MultiLine = False
        Me.XylosTextBox8.Name = "XylosTextBox8"
        Me.XylosTextBox8.ReadOnly = False
        Me.XylosTextBox8.Size = New System.Drawing.Size(362, 29)
        Me.XylosTextBox8.TabIndex = 12
        Me.XylosTextBox8.Text = "Destino"
        Me.XylosTextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.XylosTextBox8.UseSystemPasswordChar = False
        '
        'XylosTextBox9
        '
        Me.XylosTextBox9.EnabledCalc = True
        Me.XylosTextBox9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.XylosTextBox9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.XylosTextBox9.Location = New System.Drawing.Point(17, 32)
        Me.XylosTextBox9.MaxLength = 32767
        Me.XylosTextBox9.MultiLine = False
        Me.XylosTextBox9.Name = "XylosTextBox9"
        Me.XylosTextBox9.ReadOnly = False
        Me.XylosTextBox9.Size = New System.Drawing.Size(362, 29)
        Me.XylosTextBox9.TabIndex = 11
        Me.XylosTextBox9.Text = "Selecione o Arquivo Para Descriptografar"
        Me.XylosTextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.XylosTextBox9.UseSystemPasswordChar = False
        '
        'ProtectBoxMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(660, 486)
        Me.Controls.Add(Me.XylosTabControl1)
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.Name = "ProtectBoxMain"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.Text = "ProtectBox"
        Me.Controls.SetChildIndex(Me.XylosTabControl1, 0)
        Me.XylosTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
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
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents txtConPassEncrypt As XylosTextBox
    Friend WithEvents txtPassEncrypt As XylosTextBox
    Friend WithEvents XylosTextBox7 As XylosTextBox
    Friend WithEvents txtPassDecrypt As XylosTextBox
    Friend WithEvents XylosProgressBar1 As XylosProgressBar
    Friend WithEvents btnEncrypt As Glass.GlassButton
    Friend WithEvents btnDecrypt As Glass.GlassButton
    Friend WithEvents GlassButton1 As Glass.GlassButton
    Friend WithEvents CheckBoxAlteraçoes As CheckBox
    Friend WithEvents GlassButton2 As Glass.GlassButton
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents GlassButton3 As Glass.GlassButton
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents GlassButton4 As Glass.GlassButton
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents GlassButton5 As Glass.GlassButton
    Friend WithEvents XylosTextBox1 As XylosTextBox
    Friend WithEvents XylosTextBox2 As XylosTextBox
    Friend WithEvents XylosTextBox3 As XylosTextBox
    Friend WithEvents XylosTextBox4 As XylosTextBox
    Friend WithEvents GlassButton6 As Glass.GlassButton
    Friend WithEvents XylosTextBox5 As XylosTextBox
    Friend WithEvents XylosTextBox6 As XylosTextBox
    Friend WithEvents XylosTextBox8 As XylosTextBox
    Friend WithEvents XylosTextBox9 As XylosTextBox
End Class
