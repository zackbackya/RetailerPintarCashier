Imports MySqlConnector
Public Class PembayaranFrm
    Dim total_qty As Integer
    Private Sub PembayaranFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call bersih()
        Call hitung_diskon()
        Call hitung_total()
        Call kartu()
        CheckBox1.Checked = False
        txtBayar.Select()
        txtBayar.Focus()
    End Sub

    Sub hitung_total()
        Try
            For index As Integer = 0 To PenjualanProdukFrm.dgPenjualan.RowCount - 1
                txtTotal.Text += Convert.ToInt32(PenjualanProdukFrm.dgPenjualan.Rows(index).Cells(4).Value * PenjualanProdukFrm.dgPenjualan.Rows(index).Cells(2).Value) + PenjualanProdukFrm.dgPenjualan.Rows(index).Cells(5).Value
                total_qty += Convert.ToInt32(PenjualanProdukFrm.dgPenjualan.Rows(index).Cells(2).Value)
            Next
            txtTotal.Text = FormatNumber(txtTotal.Text, 0)
            txtGrandTotal.Text = FormatNumber(PenjualanProdukFrm.lblTotal.Text, 0)
        Catch ex As Exception

        End Try
    End Sub

    Sub hitung_diskon()
        Try
            For index As Integer = 0 To PenjualanProdukFrm.dgPenjualan.RowCount - 1
                txtDiskon.Text += Convert.ToInt32(PenjualanProdukFrm.dgPenjualan.Rows(index).Cells(4).Value * PenjualanProdukFrm.dgPenjualan.Rows(index).Cells(2).Value)
            Next
            txtDiskon.Text = FormatNumber(txtDiskon.Text, 0)
        Catch ex As Exception

        End Try
    End Sub

    Sub kartu()
        Try
            cbKartu.Items.Clear()
            Call koneksi()
            cmd = New MySqlCommand("select nama_kartu from ms_kartu", conn)
            rd_1 = cmd.ExecuteReader
            Do While rd_1.Read
                cbKartu.Items.Add(rd_1.Item(0))
            Loop
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            cbKartu.Enabled = True
            txtNoKartu.Enabled = True
        Else
            cbKartu.Enabled = False
            txtNoKartu.Enabled = False
        End If
    End Sub

    Private Sub txtBayar_TextChanged(sender As Object, e As EventArgs) Handles txtBayar.TextChanged
        Try
            txtKembalian.Text = FormatNumber(txtBayar.Text - txtGrandTotal.Text, 0)
        Catch ex As Exception

        End Try
    End Sub

    Sub bayar()
        Try
            Dim total As Integer = Replace(txtTotal.Text, ",", "")
            If txtBayar.Text >= total Then
                Dim status_bayar As String
                If CheckBox1.Checked = True Then
                    status_bayar = cbKartu.Text
                Else
                    status_bayar = "Tunai"
                End If

                Dim tgl As String = PenjualanProdukFrm.dtTanggal.Value.ToString("yyyy-MM-dd")
                Dim pay As String = MessageBox.Show("Apakah Anda ingin melanjutkan transaksi ini ?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If pay = DialogResult.Yes Then
                    Try
                        Call koneksi()
                        cmd = New MySqlCommand("insert into tx_penjualan_head values ('" & PenjualanProdukFrm.txtNota.Text & "','" & tgl & "','" & MainFrm.ToolStripStatusLabel1.Text & "','" & PenjualanProdukFrm.txtKasir.Text & "','" & status_bayar & "','" & txtNoKartu.Text & "','" & Replace(total_qty, ",", "") & "','" & Replace(txtTotal.Text, ",", "") & "','" & Replace(txtDiskon.Text, ",", "") & "','" & Replace(txtBayar.Text, ",", "") & "','" & Replace(txtKembalian.Text, ",", "") & "')", conn)
                        cmd.ExecuteNonQuery()
                        conn.Close()
                        Try
                            Call koneksi()
                            For i As Integer = 0 To PenjualanProdukFrm.dgPenjualan.Rows.Count - 2 Step +1
                                cmd = New MySqlCommand("insert into tx_penjualan_det(nota,id_toko,tanggal,jam,member,kasir,tipe,barcode,qty,harga,diskon,nota_ref) VALUES ('" & PenjualanProdukFrm.txtNota.Text & "','" & MainFrm.ToolStripStatusLabel1.Text & "','" & tgl & "','" & Format(Now, "HH:mm") & "','" & PenjualanProdukFrm.txtCustomer.Text & "','" & PenjualanProdukFrm.txtKasir.Text & "','N',@barcode,@qty,@harga,@diskon,'')", conn)
                                cmd.Parameters.Add("@barcode", MySqlDbType.VarChar).Value = PenjualanProdukFrm.dgPenjualan.Rows(i).Cells(0).Value.ToString()
                                cmd.Parameters.Add("@qty", MySqlDbType.Int64).Value = PenjualanProdukFrm.dgPenjualan.Rows(i).Cells(2).Value.ToString()
                                cmd.Parameters.Add("@harga", MySqlDbType.Int64).Value = PenjualanProdukFrm.dgPenjualan.Rows(i).Cells(3).Value.ToString()
                                cmd.Parameters.Add("@diskon", MySqlDbType.Int64).Value = PenjualanProdukFrm.dgPenjualan.Rows(i).Cells(4).Value.ToString()
                                cmd.ExecuteNonQuery()
                            Next
                            MessageBox.Show("Data Anda berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Try
                                Call sale()
                                PenjualanProdukFrm.lblKembalian.Text = "Kembalian : " & txtKembalian.Text & ""
                                Me.Dispose()
                            Catch ex As Exception

                            End Try
                        Catch ex As Exception
                            MessageBox.Show("Simpan data pada 'tx_penjualan_det' gagal, Silahkan cek kembali data Anda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    Catch ex As Exception
                        MessageBox.Show("Simpan data pada 'tx_penjualan_head' gagal, Silahkan cek kembali data Anda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            Else
                MessageBox.Show("Maaf jumlah bayar kurang !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtBayar.Text = "0"
                txtBayar.Select()
            End If
        Catch ex As Exception
            MessageBox.Show("Simpan data gagal, Silahkan cek kembali data Anda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub bersih()
        txtTotal.Text = 0
        txtDiskon.Text = 0
        txtGrandTotal.Text = 0
        txtNoKartu.Text = ""
        txtBayar.Text = 0
        txtKembalian.Text = 0
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Call bayar()
    End Sub

    Private Sub txtTotal_GotFocus(sender As Object, e As EventArgs) Handles txtTotal.GotFocus
        txtTotal.BackColor = Color.LightYellow
    End Sub

    Private Sub txtTotal_LostFocus(sender As Object, e As EventArgs) Handles txtTotal.LostFocus
        txtTotal.BackColor = Color.White
    End Sub

    Private Sub txtDiskon_GotFocus(sender As Object, e As EventArgs) Handles txtDiskon.GotFocus
        txtDiskon.BackColor = Color.LightYellow
    End Sub

    Private Sub txtDiskon_LostFocus(sender As Object, e As EventArgs) Handles txtDiskon.LostFocus
        txtDiskon.BackColor = Color.White
    End Sub

    Private Sub txtGrandTotal_GotFocus(sender As Object, e As EventArgs) Handles txtGrandTotal.GotFocus
        txtGrandTotal.BackColor = Color.LightYellow
    End Sub

    Private Sub txtGrandTotal_LostFocus(sender As Object, e As EventArgs) Handles txtGrandTotal.LostFocus
        txtGrandTotal.BackColor = Color.White
    End Sub

    Private Sub txtNoKartu_GotFocus(sender As Object, e As EventArgs) Handles txtNoKartu.GotFocus
        txtNoKartu.BackColor = Color.LightYellow
    End Sub

    Private Sub txtNoKartu_LostFocus(sender As Object, e As EventArgs) Handles txtNoKartu.LostFocus
        txtNoKartu.BackColor = Color.White
    End Sub

    Private Sub txtBayar_GotFocus(sender As Object, e As EventArgs) Handles txtBayar.GotFocus
        txtBayar.BackColor = Color.LightYellow
    End Sub

    Private Sub txtBayar_LostFocus(sender As Object, e As EventArgs) Handles txtBayar.LostFocus
        txtBayar.BackColor = Color.White
    End Sub

    Private Sub txtKembalian_GotFocus(sender As Object, e As EventArgs) Handles txtKembalian.GotFocus
        txtKembalian.BackColor = Color.LightYellow
    End Sub

    Private Sub txtKembalian_LostFocus(sender As Object, e As EventArgs) Handles txtKembalian.LostFocus
        txtKembalian.BackColor = Color.White
    End Sub

    Private Sub BtnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Close()
    End Sub
End Class