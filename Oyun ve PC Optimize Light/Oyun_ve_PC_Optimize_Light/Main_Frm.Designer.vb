<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main_Frm
    Inherits MetroFramework.Forms.MetroForm

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Frm))
        Me.ChbBestPerformence = New MetroFramework.Controls.MetroCheckBox()
        Me.chbWebtarayıcısı = New MetroFramework.Controls.MetroCheckBox()
        Me.chbDetayliTemizlik = New MetroFramework.Controls.MetroCheckBox()
        Me.chbwebayarlari = New MetroFramework.Controls.MetroCheckBox()
        Me.chbDnstemizle = New MetroFramework.Controls.MetroCheckBox()
        Me.chbgereksizonbellek = New MetroFramework.Controls.MetroCheckBox()
        Me.chbPerformansmod = New MetroFramework.Controls.MetroCheckBox()
        Me.chbKucukEkran = New MetroFramework.Controls.MetroCheckBox()
        Me.lbGames = New System.Windows.Forms.ListBox()
        Me.DetayliTemizlik = New System.Windows.Forms.Timer(Me.components)
        Me.rtbNews = New System.Windows.Forms.RichTextBox()
        Me.tbOutput = New System.Windows.Forms.TextBox()
        Me.btnTemizle = New MetroFramework.Controls.MetroButton()
        Me.webtariyicioptimize = New System.Windows.Forms.Timer(Me.components)
        Me.BtnOptimize = New MetroFramework.Controls.MetroButton()
        Me.oyunekle = New System.Windows.Forms.OpenFileDialog()
        Me.LblBaslik = New MetroFramework.Controls.MetroLabel()
        Me.btnBaslat = New MetroFramework.Controls.MetroButton()
        Me.btnOptimizeEt = New MetroFramework.Controls.MetroButton()
        Me.internetvericekme = New System.Windows.Forms.Timer(Me.components)
        Me.btnAyarlar = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SuspendLayout()
        '
        'ChbBestPerformence
        '
        Me.ChbBestPerformence.AutoSize = True
        Me.ChbBestPerformence.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.ChbBestPerformence.Location = New System.Drawing.Point(13, 76)
        Me.ChbBestPerformence.Margin = New System.Windows.Forms.Padding(2)
        Me.ChbBestPerformence.Name = "ChbBestPerformence"
        Me.ChbBestPerformence.Size = New System.Drawing.Size(187, 19)
        Me.ChbBestPerformence.TabIndex = 1
        Me.ChbBestPerformence.Text = "Performans Ayarını İyileştir"
        Me.ChbBestPerformence.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ChbBestPerformence.UseSelectable = True
        '
        'chbWebtarayıcısı
        '
        Me.chbWebtarayıcısı.AutoSize = True
        Me.chbWebtarayıcısı.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.chbWebtarayıcısı.Location = New System.Drawing.Point(13, 98)
        Me.chbWebtarayıcısı.Margin = New System.Windows.Forms.Padding(2)
        Me.chbWebtarayıcısı.Name = "chbWebtarayıcısı"
        Me.chbWebtarayıcısı.Size = New System.Drawing.Size(194, 19)
        Me.chbWebtarayıcısı.TabIndex = 2
        Me.chbWebtarayıcısı.Text = "Web Tarayıcısını Optimize Et"
        Me.chbWebtarayıcısı.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.chbWebtarayıcısı.UseSelectable = True
        '
        'chbDetayliTemizlik
        '
        Me.chbDetayliTemizlik.AutoSize = True
        Me.chbDetayliTemizlik.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.chbDetayliTemizlik.Location = New System.Drawing.Point(13, 140)
        Me.chbDetayliTemizlik.Margin = New System.Windows.Forms.Padding(2)
        Me.chbDetayliTemizlik.Name = "chbDetayliTemizlik"
        Me.chbDetayliTemizlik.Size = New System.Drawing.Size(116, 19)
        Me.chbDetayliTemizlik.TabIndex = 4
        Me.chbDetayliTemizlik.Text = "Sürekli Temizlik"
        Me.chbDetayliTemizlik.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.chbDetayliTemizlik.UseSelectable = True
        '
        'chbwebayarlari
        '
        Me.chbwebayarlari.AutoSize = True
        Me.chbwebayarlari.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.chbwebayarlari.Location = New System.Drawing.Point(13, 119)
        Me.chbwebayarlari.Margin = New System.Windows.Forms.Padding(2)
        Me.chbwebayarlari.Name = "chbwebayarlari"
        Me.chbwebayarlari.Size = New System.Drawing.Size(165, 19)
        Me.chbwebayarlari.TabIndex = 3
        Me.chbwebayarlari.Text = "İnternet Ayarlarımı Yap"
        Me.chbwebayarlari.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.chbwebayarlari.UseSelectable = True
        '
        'chbDnstemizle
        '
        Me.chbDnstemizle.AutoSize = True
        Me.chbDnstemizle.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.chbDnstemizle.Location = New System.Drawing.Point(209, 140)
        Me.chbDnstemizle.Margin = New System.Windows.Forms.Padding(2)
        Me.chbDnstemizle.Name = "chbDnstemizle"
        Me.chbDnstemizle.Size = New System.Drawing.Size(100, 19)
        Me.chbDnstemizle.TabIndex = 0
        Me.chbDnstemizle.Text = "DNS Temizle"
        Me.chbDnstemizle.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.chbDnstemizle.UseSelectable = True
        '
        'chbgereksizonbellek
        '
        Me.chbgereksizonbellek.AutoSize = True
        Me.chbgereksizonbellek.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.chbgereksizonbellek.Location = New System.Drawing.Point(209, 76)
        Me.chbgereksizonbellek.Margin = New System.Windows.Forms.Padding(2)
        Me.chbgereksizonbellek.Name = "chbgereksizonbellek"
        Me.chbgereksizonbellek.Size = New System.Drawing.Size(186, 19)
        Me.chbgereksizonbellek.TabIndex = 5
        Me.chbgereksizonbellek.Text = "Gereksiz Ön Bellek Temizle"
        Me.chbgereksizonbellek.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.chbgereksizonbellek.UseSelectable = True
        '
        'chbPerformansmod
        '
        Me.chbPerformansmod.AutoSize = True
        Me.chbPerformansmod.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.chbPerformansmod.Location = New System.Drawing.Point(209, 98)
        Me.chbPerformansmod.Margin = New System.Windows.Forms.Padding(2)
        Me.chbPerformansmod.Name = "chbPerformansmod"
        Me.chbPerformansmod.Size = New System.Drawing.Size(205, 19)
        Me.chbPerformansmod.TabIndex = 6
        Me.chbPerformansmod.Text = "Ekran Kartı Performans Modu"
        Me.chbPerformansmod.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.chbPerformansmod.UseSelectable = True
        '
        'chbKucukEkran
        '
        Me.chbKucukEkran.AutoSize = True
        Me.chbKucukEkran.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.chbKucukEkran.Location = New System.Drawing.Point(209, 119)
        Me.chbKucukEkran.Margin = New System.Windows.Forms.Padding(2)
        Me.chbKucukEkran.Name = "chbKucukEkran"
        Me.chbKucukEkran.Size = New System.Drawing.Size(168, 19)
        Me.chbKucukEkran.TabIndex = 7
        Me.chbKucukEkran.Text = "Ekran Performans Ölçer"
        Me.chbKucukEkran.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.chbKucukEkran.UseSelectable = True
        '
        'lbGames
        '
        Me.lbGames.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.lbGames.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbGames.ForeColor = System.Drawing.Color.White
        Me.lbGames.FormattingEnabled = True
        Me.lbGames.Items.AddRange(New Object() {"Counter-Strike: Global Offensive", "Playerunknown's Battlegrounds", "League of Legends", "Grand Theft Auto V", "Minecraft", "Fortnite", "Rust", "H1Z1", "//Henüz oyunlarınız otomatik eklenmemektedir."})
        Me.lbGames.Location = New System.Drawing.Point(15, 181)
        Me.lbGames.Margin = New System.Windows.Forms.Padding(2)
        Me.lbGames.Name = "lbGames"
        Me.lbGames.Size = New System.Drawing.Size(392, 117)
        Me.lbGames.TabIndex = 2
        '
        'DetayliTemizlik
        '
        '
        'rtbNews
        '
        Me.rtbNews.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbNews.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.rtbNews.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbNews.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rtbNews.ForeColor = System.Drawing.Color.White
        Me.rtbNews.Location = New System.Drawing.Point(15, 395)
        Me.rtbNews.Margin = New System.Windows.Forms.Padding(2)
        Me.rtbNews.Name = "rtbNews"
        Me.rtbNews.ReadOnly = True
        Me.rtbNews.ShortcutsEnabled = False
        Me.rtbNews.Size = New System.Drawing.Size(392, 101)
        Me.rtbNews.TabIndex = 3
        Me.rtbNews.Text = "İnternet Bağlantınızı Kontrol Ediniz.."
        '
        'tbOutput
        '
        Me.tbOutput.Location = New System.Drawing.Point(84, 158)
        Me.tbOutput.Margin = New System.Windows.Forms.Padding(2)
        Me.tbOutput.Name = "tbOutput"
        Me.tbOutput.Size = New System.Drawing.Size(19, 20)
        Me.tbOutput.TabIndex = 4
        Me.tbOutput.Visible = False
        '
        'btnTemizle
        '
        Me.btnTemizle.Location = New System.Drawing.Point(145, 302)
        Me.btnTemizle.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTemizle.Name = "btnTemizle"
        Me.btnTemizle.Size = New System.Drawing.Size(125, 32)
        Me.btnTemizle.Style = MetroFramework.MetroColorStyle.Yellow
        Me.btnTemizle.TabIndex = 5
        Me.btnTemizle.Text = "Bilgisayarımı Temizle"
        Me.btnTemizle.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnTemizle.UseSelectable = True
        Me.btnTemizle.UseStyleColors = True
        '
        'webtariyicioptimize
        '
        '
        'BtnOptimize
        '
        Me.BtnOptimize.Location = New System.Drawing.Point(144, 339)
        Me.BtnOptimize.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnOptimize.Name = "BtnOptimize"
        Me.BtnOptimize.Size = New System.Drawing.Size(241, 32)
        Me.BtnOptimize.Style = MetroFramework.MetroColorStyle.Yellow
        Me.BtnOptimize.TabIndex = 5
        Me.BtnOptimize.Text = "Optimize Edilecek Program/Oyun"
        Me.BtnOptimize.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.BtnOptimize.UseSelectable = True
        Me.BtnOptimize.UseStyleColors = True
        '
        'oyunekle
        '
        Me.oyunekle.FileName = "Eklemek istediginiz dosyayı seçin"
        '
        'LblBaslik
        '
        Me.LblBaslik.AutoSize = True
        Me.LblBaslik.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LblBaslik.Location = New System.Drawing.Point(9, 159)
        Me.LblBaslik.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblBaslik.Name = "LblBaslik"
        Me.LblBaslik.Size = New System.Drawing.Size(88, 19)
        Me.LblBaslik.Style = MetroFramework.MetroColorStyle.Yellow
        Me.LblBaslik.TabIndex = 6
        Me.LblBaslik.Text = "Oyun Listesi"
        Me.LblBaslik.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.LblBaslik.UseStyleColors = True
        '
        'btnBaslat
        '
        Me.btnBaslat.Location = New System.Drawing.Point(28, 339)
        Me.btnBaslat.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBaslat.Name = "btnBaslat"
        Me.btnBaslat.Size = New System.Drawing.Size(112, 32)
        Me.btnBaslat.Style = MetroFramework.MetroColorStyle.Yellow
        Me.btnBaslat.TabIndex = 5
        Me.btnBaslat.Text = "Oyunu Başlat"
        Me.btnBaslat.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnBaslat.UseSelectable = True
        Me.btnBaslat.UseStyleColors = True
        '
        'btnOptimizeEt
        '
        Me.btnOptimizeEt.Location = New System.Drawing.Point(28, 302)
        Me.btnOptimizeEt.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOptimizeEt.Name = "btnOptimizeEt"
        Me.btnOptimizeEt.Size = New System.Drawing.Size(112, 32)
        Me.btnOptimizeEt.Style = MetroFramework.MetroColorStyle.Yellow
        Me.btnOptimizeEt.TabIndex = 5
        Me.btnOptimizeEt.Text = "Oyunu Optimize Et"
        Me.btnOptimizeEt.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnOptimizeEt.UseSelectable = True
        Me.btnOptimizeEt.UseStyleColors = True
        '
        'internetvericekme
        '
        Me.internetvericekme.Enabled = True
        Me.internetvericekme.Interval = 1000
        '
        'btnAyarlar
        '
        Me.btnAyarlar.Location = New System.Drawing.Point(274, 302)
        Me.btnAyarlar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAyarlar.Name = "btnAyarlar"
        Me.btnAyarlar.Size = New System.Drawing.Size(111, 32)
        Me.btnAyarlar.Style = MetroFramework.MetroColorStyle.Yellow
        Me.btnAyarlar.TabIndex = 5
        Me.btnAyarlar.Text = "Ayarlar"
        Me.btnAyarlar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnAyarlar.UseSelectable = True
        Me.btnAyarlar.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.Location = New System.Drawing.Point(15, 374)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(193, 19)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Yellow
        Me.MetroLabel1.TabIndex = 8
        Me.MetroLabel1.Text = "Duyurular ve Sürüm Notları"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel1.UseStyleColors = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(196, 373)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(19, 20)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.Visible = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipText = "Alta Alındı"
        Me.NotifyIcon1.BalloonTipTitle = "Açıklama"
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Oyun ve PC Optimize Light"
        '
        'Main_Frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 512)
        Me.Controls.Add(Me.LblBaslik)
        Me.Controls.Add(Me.BtnOptimize)
        Me.Controls.Add(Me.btnOptimizeEt)
        Me.Controls.Add(Me.btnBaslat)
        Me.Controls.Add(Me.btnAyarlar)
        Me.Controls.Add(Me.btnTemizle)
        Me.Controls.Add(Me.tbOutput)
        Me.Controls.Add(Me.rtbNews)
        Me.Controls.Add(Me.lbGames)
        Me.Controls.Add(Me.chbDnstemizle)
        Me.Controls.Add(Me.chbKucukEkran)
        Me.Controls.Add(Me.chbwebayarlari)
        Me.Controls.Add(Me.chbPerformansmod)
        Me.Controls.Add(Me.chbDetayliTemizlik)
        Me.Controls.Add(Me.chbgereksizonbellek)
        Me.Controls.Add(Me.chbWebtarayıcısı)
        Me.Controls.Add(Me.ChbBestPerformence)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.TextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Main_Frm"
        Me.Opacity = 0.85R
        Me.Padding = New System.Windows.Forms.Padding(15, 60, 15, 16)
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Yellow
        Me.Text = "Oyun ve PC Optimize Light"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ChbBestPerformence As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chbWebtarayıcısı As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chbDetayliTemizlik As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chbwebayarlari As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chbDnstemizle As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chbgereksizonbellek As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chbPerformansmod As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chbKucukEkran As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents lbGames As ListBox
    Friend WithEvents DetayliTemizlik As Timer
    Friend WithEvents rtbNews As RichTextBox
    Friend WithEvents tbOutput As TextBox
    Friend WithEvents btnTemizle As MetroFramework.Controls.MetroButton
    Friend WithEvents webtariyicioptimize As Timer
    Friend WithEvents BtnOptimize As MetroFramework.Controls.MetroButton
    Friend WithEvents oyunekle As OpenFileDialog
    Friend WithEvents LblBaslik As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnBaslat As MetroFramework.Controls.MetroButton
    Friend WithEvents btnOptimizeEt As MetroFramework.Controls.MetroButton
    Friend WithEvents internetvericekme As Timer
    Friend WithEvents btnAyarlar As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
End Class
