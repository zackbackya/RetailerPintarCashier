<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahCustomerFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TambahCustomerFrm))
        Me.txtNIKCustomer = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rdPerempuan = New System.Windows.Forms.RadioButton()
        Me.rdLakiLaki = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTeleponCustomer = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAlamatCustomer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIdCustomer = New System.Windows.Forms.TextBox()
        Me.txtNamaCustomer = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSelesai = New System.Windows.Forms.Button()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNIKCustomer
        '
        Me.txtNIKCustomer.Location = New System.Drawing.Point(135, 70)
        Me.txtNIKCustomer.MaxLength = 16
        Me.txtNIKCustomer.Name = "txtNIKCustomer"
        Me.txtNIKCustomer.Size = New System.Drawing.Size(290, 20)
        Me.txtNIKCustomer.TabIndex = 74
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(4, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 20)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "NIK"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rdPerempuan
        '
        Me.rdPerempuan.AutoSize = True
        Me.rdPerempuan.Location = New System.Drawing.Point(221, 188)
        Me.rdPerempuan.Name = "rdPerempuan"
        Me.rdPerempuan.Size = New System.Drawing.Size(79, 17)
        Me.rdPerempuan.TabIndex = 78
        Me.rdPerempuan.TabStop = True
        Me.rdPerempuan.Text = "Perempuan"
        Me.rdPerempuan.UseVisualStyleBackColor = True
        '
        'rdLakiLaki
        '
        Me.rdLakiLaki.AutoSize = True
        Me.rdLakiLaki.Location = New System.Drawing.Point(137, 188)
        Me.rdLakiLaki.Name = "rdLakiLaki"
        Me.rdLakiLaki.Size = New System.Drawing.Size(64, 17)
        Me.rdLakiLaki.TabIndex = 77
        Me.rdLakiLaki.TabStop = True
        Me.rdLakiLaki.Text = "Laki-laki"
        Me.rdLakiLaki.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(4, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 20)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Jenis Kelamin"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTeleponCustomer
        '
        Me.txtTeleponCustomer.Location = New System.Drawing.Point(135, 211)
        Me.txtTeleponCustomer.MaxLength = 12
        Me.txtTeleponCustomer.Name = "txtTeleponCustomer"
        Me.txtTeleponCustomer.Size = New System.Drawing.Size(290, 20)
        Me.txtTeleponCustomer.TabIndex = 79
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(4, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 20)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "Telepon"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAlamatCustomer
        '
        Me.txtAlamatCustomer.Location = New System.Drawing.Point(135, 122)
        Me.txtAlamatCustomer.MaxLength = 50
        Me.txtAlamatCustomer.Multiline = True
        Me.txtAlamatCustomer.Name = "txtAlamatCustomer"
        Me.txtAlamatCustomer.Size = New System.Drawing.Size(290, 60)
        Me.txtAlamatCustomer.TabIndex = 76
        Me.txtAlamatCustomer.Text = " "
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(4, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 20)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Alamat Customer"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(4, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 20)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Id Customer"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIdCustomer
        '
        Me.txtIdCustomer.Location = New System.Drawing.Point(135, 44)
        Me.txtIdCustomer.MaxLength = 10
        Me.txtIdCustomer.Name = "txtIdCustomer"
        Me.txtIdCustomer.ReadOnly = True
        Me.txtIdCustomer.Size = New System.Drawing.Size(119, 20)
        Me.txtIdCustomer.TabIndex = 73
        '
        'txtNamaCustomer
        '
        Me.txtNamaCustomer.Location = New System.Drawing.Point(135, 96)
        Me.txtNamaCustomer.MaxLength = 25
        Me.txtNamaCustomer.Name = "txtNamaCustomer"
        Me.txtNamaCustomer.Size = New System.Drawing.Size(290, 20)
        Me.txtNamaCustomer.TabIndex = 75
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(4, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 20)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Nama  Customer"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSimpan
        '
        Me.btnSimpan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSimpan.Location = New System.Drawing.Point(259, 6)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 3
        Me.btnSimpan.Text = "F11 Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnSimpan)
        Me.Panel1.Controls.Add(Me.btnSelesai)
        Me.Panel1.Location = New System.Drawing.Point(4, 240)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(421, 35)
        Me.Panel1.TabIndex = 72
        '
        'btnSelesai
        '
        Me.btnSelesai.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelesai.Location = New System.Drawing.Point(340, 6)
        Me.btnSelesai.Name = "btnSelesai"
        Me.btnSelesai.Size = New System.Drawing.Size(75, 23)
        Me.btnSelesai.TabIndex = 4
        Me.btnSelesai.Text = "Esc Selesai"
        Me.btnSelesai.UseVisualStyleBackColor = True
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(3, 7)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(172, 17)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Tambah Data Customer"
        '
        'pnlHeader
        '
        Me.pnlHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlHeader.Controls.Add(Me.lblHeader)
        Me.pnlHeader.Location = New System.Drawing.Point(4, 3)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(421, 35)
        Me.pnlHeader.TabIndex = 71
        '
        'TambahCustomerFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(428, 277)
        Me.Controls.Add(Me.txtNIKCustomer)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.rdPerempuan)
        Me.Controls.Add(Me.rdLakiLaki)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTeleponCustomer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAlamatCustomer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtIdCustomer)
        Me.Controls.Add(Me.txtNamaCustomer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TambahCustomerFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retailer Pinter (Cashier)"
        Me.Panel1.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNIKCustomer As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents rdPerempuan As RadioButton
    Friend WithEvents rdLakiLaki As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTeleponCustomer As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAlamatCustomer As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIdCustomer As TextBox
    Friend WithEvents txtNamaCustomer As TextBox
    Friend WithEvents Label2 As Label
    Private WithEvents btnSimpan As Button
    Private WithEvents Panel1 As Panel
    Private WithEvents btnSelesai As Button
    Private WithEvents lblHeader As Label
    Private WithEvents pnlHeader As Panel
End Class
