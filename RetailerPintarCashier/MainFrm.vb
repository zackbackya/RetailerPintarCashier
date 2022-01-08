Public Class MainFrm
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.ClassStyle = param.ClassStyle Or &H200
            Return param
        End Get
    End Property

    Sub toko()
        Try
            Dim filecontents As String = System.IO.File.ReadAllText(Application.StartupPath.ToString & "\Store.ini")
            Dim lines() As String
            Dim itung As Integer
            filecontents = filecontents.Replace(ControlChars.CrLf, ControlChars.Lf)
            lines = filecontents.Split(New Char() {ControlChars.Lf, ControlChars.Cr})
            itung = 1
            Dim isi As String = lines(itung)

            ToolStripStatusLabel1.Text = isi
        Catch ex As Exception
            MessageBox.Show("Store.ini belum disetting !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me.WindowState = FormWindowState.Maximized
            HomeFrm.MdiParent = Me
            HomeFrm.Dock = DockStyle.Fill
            HomeFrm.Show()
            HomeFrm.Focus()
            s.Close()
            toko()

            sbOperator.Text = LoginFrm.txtUsername.Text
            Timer1.Start()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub MnuGantiUser_Click(sender As Object, e As EventArgs) Handles mnuGantiUser.Click
        Dim quit As String = MessageBox.Show("Apakah proses ingin dilanjutkan?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If quit = DialogResult.Yes Then
            If PenjualanProdukFrm.dgPenjualan.RowCount > 1 Then
                PenjualanProdukFrm.lblKeterangan.Text = "Sudah ada transaksi, Form tidak bisa ditutup !"
            Else
                Me.Dispose()
                LoginFrm.Show()
                LoginFrm.txtUsername.Text = ""
                LoginFrm.txtPassword.Text = ""
                LoginFrm.txtServer.Text = ""
                LoginFrm.txtUsername.Select()
            End If
        ElseIf quit = DialogResult.No Then

        End If
    End Sub

    Private Sub MnuKeluarDariProgram_Click(sender As Object, e As EventArgs) Handles mnuKeluarDariProgram.Click
        Dim quit As String = MessageBox.Show("Apakah proses ingin dilanjutkan?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If quit = DialogResult.Yes Then
            If PenjualanProdukFrm.dgPenjualan.RowCount > 1 Then
                PenjualanProdukFrm.lblKeterangan.Text = "Sudah ada transaksi, Form tidak bisa ditutup !"
            Else
                Me.Dispose()
                LoginFrm.Close()
            End If
        ElseIf quit = DialogResult.No Then

        End If
    End Sub

    Private Sub PenjualanProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanProdukToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Maximized
        PenjualanProdukFrm.MdiParent = Me
        PenjualanProdukFrm.Dock = DockStyle.Fill
        PenjualanProdukFrm.Show()
        PenjualanProdukFrm.Focus()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        sbJam.Text = DateTime.Now.ToString("hh:mm:ss tt")
        sbTanggal.Text = DateString
    End Sub

    Private Sub PenjualanPerKasirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanPerKasirToolStripMenuItem.Click

    End Sub

    Private Sub PengaturanAplikasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengaturanAplikasiToolStripMenuItem.Click

    End Sub
End Class
