<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainFrm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainFrm))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.sbJam = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sbTanggal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sbOperator = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuTransaksi = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanProdukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLaporan = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanPerKasirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPengaturan = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengaturanAplikasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBantuan = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuKeluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGantiUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuKeluarDariProgram = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.menuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sbJam, Me.ToolStripStatusLabel2, Me.sbTanggal, Me.ToolStripStatusLabel6, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel3, Me.sbOperator, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel7})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 799)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1284, 26)
        Me.StatusStrip1.TabIndex = 23
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'sbJam
        '
        Me.sbJam.Image = CType(resources.GetObject("sbJam.Image"), System.Drawing.Image)
        Me.sbJam.Name = "sbJam"
        Me.sbJam.Size = New System.Drawing.Size(83, 20)
        Me.sbJam.Text = "00:00:00"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(13, 20)
        Me.ToolStripStatusLabel2.Text = "|"
        '
        'sbTanggal
        '
        Me.sbTanggal.Image = CType(resources.GetObject("sbTanggal.Image"), System.Drawing.Image)
        Me.sbTanggal.Name = "sbTanggal"
        Me.sbTanggal.Size = New System.Drawing.Size(73, 20)
        Me.sbTanggal.Text = "Hari, ..."
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(13, 20)
        Me.ToolStripStatusLabel6.Text = "|"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Image = CType(resources.GetObject("ToolStripStatusLabel1.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(100, 20)
        Me.ToolStripStatusLabel1.Text = "Kode Toko"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(13, 20)
        Me.ToolStripStatusLabel3.Text = "|"
        '
        'sbOperator
        '
        Me.sbOperator.Image = CType(resources.GetObject("sbOperator.Image"), System.Drawing.Image)
        Me.sbOperator.Name = "sbOperator"
        Me.sbOperator.Size = New System.Drawing.Size(96, 20)
        Me.sbOperator.Text = "operator..."
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(13, 20)
        Me.ToolStripStatusLabel4.Text = "|"
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(352, 20)
        Me.ToolStripStatusLabel7.Text = "Retailer Pintar (Cashier) Versi  1.0.0 - Copyright 2021"
        '
        'menuStrip1
        '
        Me.menuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTransaksi, Me.mnuLaporan, Me.mnuPengaturan, Me.mnuBantuan, Me.mnuKeluar})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(1284, 28)
        Me.menuStrip1.TabIndex = 24
        Me.menuStrip1.Text = "menuStrip1"
        '
        'mnuTransaksi
        '
        Me.mnuTransaksi.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenjualanProdukToolStripMenuItem})
        Me.mnuTransaksi.Name = "mnuTransaksi"
        Me.mnuTransaksi.Size = New System.Drawing.Size(82, 24)
        Me.mnuTransaksi.Text = "Transaksi"
        '
        'PenjualanProdukToolStripMenuItem
        '
        Me.PenjualanProdukToolStripMenuItem.Name = "PenjualanProdukToolStripMenuItem"
        Me.PenjualanProdukToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.PenjualanProdukToolStripMenuItem.Text = "Penjualan Produk"
        '
        'mnuLaporan
        '
        Me.mnuLaporan.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenjualanPerKasirToolStripMenuItem})
        Me.mnuLaporan.Name = "mnuLaporan"
        Me.mnuLaporan.Size = New System.Drawing.Size(77, 24)
        Me.mnuLaporan.Text = "Laporan"
        '
        'PenjualanPerKasirToolStripMenuItem
        '
        Me.PenjualanPerKasirToolStripMenuItem.Name = "PenjualanPerKasirToolStripMenuItem"
        Me.PenjualanPerKasirToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.PenjualanPerKasirToolStripMenuItem.Text = "Penjualan Per Kasir"
        '
        'mnuPengaturan
        '
        Me.mnuPengaturan.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PengaturanAplikasiToolStripMenuItem})
        Me.mnuPengaturan.Name = "mnuPengaturan"
        Me.mnuPengaturan.Size = New System.Drawing.Size(97, 24)
        Me.mnuPengaturan.Text = "Pengaturan"
        '
        'PengaturanAplikasiToolStripMenuItem
        '
        Me.PengaturanAplikasiToolStripMenuItem.Name = "PengaturanAplikasiToolStripMenuItem"
        Me.PengaturanAplikasiToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.PengaturanAplikasiToolStripMenuItem.Text = "Pengaturan Aplikasi"
        '
        'mnuBantuan
        '
        Me.mnuBantuan.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
        Me.mnuBantuan.Name = "mnuBantuan"
        Me.mnuBantuan.Size = New System.Drawing.Size(77, 24)
        Me.mnuBantuan.Text = "Bantuan"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(133, 26)
        Me.mnuAbout.Text = "About"
        '
        'mnuKeluar
        '
        Me.mnuKeluar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuGantiUser, Me.mnuKeluarDariProgram})
        Me.mnuKeluar.Name = "mnuKeluar"
        Me.mnuKeluar.Size = New System.Drawing.Size(65, 24)
        Me.mnuKeluar.Text = "Keluar"
        '
        'mnuGantiUser
        '
        Me.mnuGantiUser.Name = "mnuGantiUser"
        Me.mnuGantiUser.Size = New System.Drawing.Size(220, 26)
        Me.mnuGantiUser.Text = "Ganti User"
        '
        'mnuKeluarDariProgram
        '
        Me.mnuKeluarDariProgram.Name = "mnuKeluarDariProgram"
        Me.mnuKeluarDariProgram.Size = New System.Drawing.Size(220, 26)
        Me.mnuKeluarDariProgram.Text = "Keluar dari Aplikasi"
        '
        'Timer1
        '
        '
        'MainFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1284, 825)
        Me.Controls.Add(Me.menuStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.menuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "MainFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main / Retailer Pintar (Cashier) Versi  1.0.0 - Copyright 2021"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents sbJam As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents sbTanggal As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents sbOperator As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel7 As ToolStripStatusLabel
    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents mnuTransaksi As ToolStripMenuItem
    Private WithEvents mnuLaporan As ToolStripMenuItem
    Private WithEvents mnuBantuan As ToolStripMenuItem
    Private WithEvents mnuAbout As ToolStripMenuItem
    Private WithEvents mnuKeluar As ToolStripMenuItem
    Private WithEvents mnuGantiUser As ToolStripMenuItem
    Private WithEvents mnuKeluarDariProgram As ToolStripMenuItem
    Private WithEvents mnuPengaturan As ToolStripMenuItem
    Friend WithEvents PenjualanProdukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenjualanPerKasirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PengaturanAplikasiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
End Class
