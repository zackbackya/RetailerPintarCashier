<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PenjualanProdukFrm
    Inherits System.Windows.Forms.Form

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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtTanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNota = New System.Windows.Forms.TextBox()
        Me.txtCustomer = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtKasir = New System.Windows.Forms.TextBox()
        Me.dgPenjualan = New System.Windows.Forms.DataGridView()
        Me.barcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_produk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.diskon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sub_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblKeterangan = New System.Windows.Forms.Label()
        Me.lblKembalian = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlHeader.Controls.Add(Me.lblTotal)
        Me.pnlHeader.Location = New System.Drawing.Point(3, 3)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(968, 72)
        Me.pnlHeader.TabIndex = 114
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Khaki
        Me.lblTotal.Location = New System.Drawing.Point(3, -1)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(960, 71)
        Me.lblTotal.TabIndex = 127
        Me.lblTotal.Text = "0"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(4, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 20)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "Tanggal"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(401, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 20)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = "Kasir"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(401, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 20)
        Me.Label3.TabIndex = 133
        Me.Label3.Text = "Customer"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtTanggal
        '
        Me.dtTanggal.Enabled = False
        Me.dtTanggal.Location = New System.Drawing.Point(135, 29)
        Me.dtTanggal.Name = "dtTanggal"
        Me.dtTanggal.Size = New System.Drawing.Size(260, 20)
        Me.dtTanggal.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(4, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 19)
        Me.Label9.TabIndex = 136
        Me.Label9.Text = "Nota"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNota
        '
        Me.txtNota.BackColor = System.Drawing.Color.White
        Me.txtNota.Location = New System.Drawing.Point(135, 3)
        Me.txtNota.MaxLength = 12
        Me.txtNota.Name = "txtNota"
        Me.txtNota.ReadOnly = True
        Me.txtNota.Size = New System.Drawing.Size(260, 20)
        Me.txtNota.TabIndex = 1
        '
        'txtCustomer
        '
        Me.txtCustomer.BackColor = System.Drawing.Color.White
        Me.txtCustomer.Location = New System.Drawing.Point(532, 3)
        Me.txtCustomer.MaxLength = 10
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(431, 20)
        Me.txtCustomer.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.OldLace
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtKasir)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtCustomer)
        Me.Panel1.Controls.Add(Me.txtNota)
        Me.Panel1.Controls.Add(Me.dtTanggal)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(3, 115)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(968, 55)
        Me.Panel1.TabIndex = 138
        '
        'txtKasir
        '
        Me.txtKasir.BackColor = System.Drawing.Color.White
        Me.txtKasir.Location = New System.Drawing.Point(532, 29)
        Me.txtKasir.MaxLength = 10
        Me.txtKasir.Name = "txtKasir"
        Me.txtKasir.ReadOnly = True
        Me.txtKasir.Size = New System.Drawing.Size(260, 20)
        Me.txtKasir.TabIndex = 4
        '
        'dgPenjualan
        '
        Me.dgPenjualan.AllowUserToDeleteRows = False
        Me.dgPenjualan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgPenjualan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgPenjualan.BackgroundColor = System.Drawing.Color.White
        Me.dgPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPenjualan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.barcode, Me.nama_produk, Me.jumlah, Me.harga, Me.diskon, Me.sub_total})
        Me.dgPenjualan.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgPenjualan.Location = New System.Drawing.Point(3, 176)
        Me.dgPenjualan.Name = "dgPenjualan"
        Me.dgPenjualan.Size = New System.Drawing.Size(968, 350)
        Me.dgPenjualan.TabIndex = 5
        '
        'barcode
        '
        Me.barcode.FillWeight = 70.0!
        Me.barcode.HeaderText = "Barcode"
        Me.barcode.Name = "barcode"
        '
        'nama_produk
        '
        Me.nama_produk.FillWeight = 220.0!
        Me.nama_produk.HeaderText = "Nama Produk"
        Me.nama_produk.Name = "nama_produk"
        Me.nama_produk.ReadOnly = True
        '
        'jumlah
        '
        Me.jumlah.FillWeight = 30.0!
        Me.jumlah.HeaderText = "Jumlah"
        Me.jumlah.Name = "jumlah"
        '
        'harga
        '
        Me.harga.FillWeight = 50.0!
        Me.harga.HeaderText = "Harga"
        Me.harga.Name = "harga"
        Me.harga.ReadOnly = True
        '
        'diskon
        '
        Me.diskon.FillWeight = 50.0!
        Me.diskon.HeaderText = "Diskon"
        Me.diskon.Name = "diskon"
        '
        'sub_total
        '
        Me.sub_total.FillWeight = 70.0!
        Me.sub_total.HeaderText = "Sub Total"
        Me.sub_total.Name = "sub_total"
        Me.sub_total.ReadOnly = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(3, 566)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(968, 35)
        Me.Panel2.TabIndex = 140
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Khaki
        Me.Label4.Location = New System.Drawing.Point(3, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(956, 23)
        Me.Label4.TabIndex = 141
        Me.Label4.Text = "F4 : Customer Baru | F5 : Hapus Item | F6 : Cari Customer | F7 : Cek Nota Terakhi" &
    "r | F8 : Bayar | F9 : Pembatalan | F10 : Retur | Esc : Keluar"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblKeterangan
        '
        Me.lblKeterangan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblKeterangan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKeterangan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKeterangan.ForeColor = System.Drawing.Color.Red
        Me.lblKeterangan.Location = New System.Drawing.Point(3, 78)
        Me.lblKeterangan.Name = "lblKeterangan"
        Me.lblKeterangan.Size = New System.Drawing.Size(968, 34)
        Me.lblKeterangan.TabIndex = 142
        Me.lblKeterangan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblKembalian
        '
        Me.lblKembalian.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblKembalian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKembalian.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKembalian.ForeColor = System.Drawing.Color.Red
        Me.lblKembalian.Location = New System.Drawing.Point(3, 529)
        Me.lblKembalian.Name = "lblKembalian"
        Me.lblKembalian.Size = New System.Drawing.Size(968, 34)
        Me.lblKembalian.TabIndex = 143
        Me.lblKembalian.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PenjualanProdukFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(975, 604)
        Me.Controls.Add(Me.lblKembalian)
        Me.Controls.Add(Me.lblKeterangan)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.dgPenjualan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PenjualanProdukFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PenjualanProdukFrm"
        Me.pnlHeader.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pnlHeader As Panel
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtTanggal As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNota As TextBox
    Friend WithEvents txtCustomer As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtKasir As TextBox
    Friend WithEvents dgPenjualan As DataGridView
    Private WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents lblKeterangan As Label
    Friend WithEvents barcode As DataGridViewTextBoxColumn
    Friend WithEvents nama_produk As DataGridViewTextBoxColumn
    Friend WithEvents jumlah As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents diskon As DataGridViewTextBoxColumn
    Friend WithEvents sub_total As DataGridViewTextBoxColumn
    Friend WithEvents lblKembalian As Label
End Class
