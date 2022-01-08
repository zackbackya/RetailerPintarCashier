Imports MySqlConnector
Public Class PenjualanProdukFrm
    Private Sub nota()
        Try
            Call koneksi()
            Dim tgl As String = Format(Now, "yyyyMMdd")
            cmd = New MySqlCommand("select nota from tx_penjualan_det where tanggal = SUBDATE(CURDATE(),0) order by nota desc", conn)
            rd_1 = cmd.ExecuteReader
            If rd_1.Read Then
                Dim Isi As String = Val(rd_1.Item(0)) + 1
                txtNota.Text = Isi
            Else
                txtNota.Text = tgl & "100"
            End If
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtCustomer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCustomer.KeyPress
        Try
            If (e.KeyChar = Chr(13)) Then
                Call koneksi()
                cmd = New MySqlCommand("select count(*) from ms_customer where (nik like '%" & txtCustomer.Text & "%' or nama like '%" & txtCustomer.Text & "%')", conn)
                rd_1 = cmd.ExecuteReader
                rd_1.Read()
                If 1 < rd_1.Item(0) Then
                    AmbilCustomerFrm.ShowDialog()
                Else
                    Call koneksi()
                    cmd = New MySqlCommand("select nik from ms_customer where (nik like '%" & txtCustomer.Text & "%' or nama like '%" & txtCustomer.Text & "%')", conn)
                    rd_1 = cmd.ExecuteReader
                    rd_1.Read()
                    txtCustomer.Text = rd_1.Item(0)
                End If
            End If
        Catch ex As Exception
            For i = 1 To 100

            Next
            lblKeterangan.Text = "Data customer tidak ditemukan !"
            txtCustomer.Text = ""
            txtCustomer.Select()
        End Try
    End Sub

    Private Sub PenjualanProdukFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call nota()
        Me.KeyPreview = True
        dgPenjualan.Focus()
        dgPenjualan.CurrentCell = dgPenjualan.Rows(0).Cells(0)
        txtKasir.Text = LoginFrm.txtUsername.Text & " - [" & LoginFrm.cbShift.Text & "]"
    End Sub

    Sub bersih()
        txtCustomer.Text = ""
        lblTotal.Text = "0"
        dgPenjualan.Rows.Clear()
    End Sub

    Private Sub dgPenjualan_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgPenjualan.CellEndEdit
        Try
            If e.ColumnIndex = 0 Then
                Dim i As Integer = 0
                Call koneksi()
                cmd = New MySqlCommand("select barcode,nama_produk,nama_pendek,harga_jual,stok from ms_produk where barcode = '" & dgPenjualan.Rows(e.RowIndex).Cells(0).Value & "'", conn)
                rd_1 = cmd.ExecuteReader
                rd_1.Read()
                If rd_1.HasRows Then
                    For barisatas As Integer = 0 To dgPenjualan.RowCount - 1
                        For barisbawah As Integer = barisatas + 1 To dgPenjualan.RowCount - 1
                            If dgPenjualan.Rows(barisbawah).Cells(0).Value = dgPenjualan.Rows(barisatas).Cells(0).Value Then
                                dgPenjualan.Rows(barisatas).Cells(1).Value = dgPenjualan.Rows(barisatas).Cells(1).Value
                                dgPenjualan.Rows(barisatas).Cells(3).Value = dgPenjualan.Rows(barisatas).Cells(3).Value
                                'asumsi penjualan minimal jumlah barang 1 (satu)
                                'jadi ketika ngetik nama barang di kolom nama barang
                                dgPenjualan.Rows(barisatas).Cells(2).Value = dgPenjualan.Rows(barisatas).Cells(2).Value + 1
                                dgPenjualan.Rows(barisatas).Cells(4).Value = dgPenjualan.Rows(barisatas).Cells(4).Value
                                dgPenjualan.Rows(barisatas).Cells(5).Value = (dgPenjualan.Rows(barisatas).Cells(2).Value * dgPenjualan.Rows(barisatas).Cells(3).Value) - (dgPenjualan.Rows(barisatas).Cells(2).Value * dgPenjualan.Rows(barisatas).Cells(4).Value)
                                dgPenjualan.Rows.RemoveAt(barisbawah)
                                dgPenjualan.CurrentCell = dgPenjualan.Rows(barisbawah).Cells(0)
                                Call subtotal()
                                Exit Sub
                            Else
                                dgPenjualan.Rows(e.RowIndex).Cells(0).Value = rd_1.Item(0)
                                dgPenjualan.Rows(e.RowIndex).Cells(1).Value = rd_1.Item(1)
                                dgPenjualan.Rows(e.RowIndex).Cells(3).Value = rd_1.Item(3)
                                dgPenjualan.Rows(e.RowIndex).Cells(2).Value = 1
                                dgPenjualan.Rows(e.RowIndex).Cells(4).Value = 0
                                dgPenjualan.Rows(e.RowIndex).Cells(5).Value = (dgPenjualan.Rows(e.RowIndex).Cells(2).Value * dgPenjualan.Rows(e.RowIndex).Cells(3).Value) - (dgPenjualan.Rows(e.RowIndex).Cells(2).Value * dgPenjualan.Rows(e.RowIndex).Cells(4).Value)
                                Call subtotal()
                            End If
                        Next
                    Next
                Else
                    For i = 1 To 100
                        lblKeterangan.Text = "Barcode tidak ditemukan !"
                    Next
                    dgPenjualan.Rows.Remove(dgPenjualan.CurrentRow)
                End If
            ElseIf e.ColumnIndex = 2 Then
                Call koneksi()
                cmd = New MySqlCommand("select barcode,nama_produk,nama_pendek,harga_jual,stok from ms_produk where (barcode = '" & dgPenjualan.Rows(e.RowIndex).Cells(0).Value & "' or nama_produk like '%" & dgPenjualan.Rows(e.RowIndex).Cells(0).Value & "%')", conn)
                rd_1 = cmd.ExecuteReader
                rd_1.Read()
                If rd_1.HasRows Then
                    dgPenjualan.Rows(e.RowIndex).Cells(5).Value = (dgPenjualan.Rows(e.RowIndex).Cells(2).Value * dgPenjualan.Rows(e.RowIndex).Cells(3).Value)
                    Call subtotal()
                End If
            ElseIf e.ColumnIndex = 4 Then
                If dgPenjualan.Rows(e.RowIndex).Cells(0).Value <> "" Then
                    dgPenjualan.Rows(e.RowIndex).Cells(5).Value = (dgPenjualan.Rows(e.RowIndex).Cells(2).Value * dgPenjualan.Rows(e.RowIndex).Cells(3).Value) - (dgPenjualan.Rows(e.RowIndex).Cells(2).Value * dgPenjualan.Rows(e.RowIndex).Cells(4).Value)
                    Call subtotal()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Sub subtotal()
        If dgPenjualan.RowCount > 1 Then
            lblKeterangan.Text = ""
            lblKembalian.Text = ""
            lblTotal.Text = "0"
            Dim totaldiskon As Integer = 0
            For index As Integer = 0 To dgPenjualan.RowCount - 1
                lblTotal.Text += Convert.ToInt32(dgPenjualan.Rows(index).Cells(5).Value)
            Next
            lblTotal.Text = FormatNumber(lblTotal.Text, 0)
        Else
            lblTotal.Text = "0"
        End If
    End Sub

    Private Sub PenjualanProdukFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If dgPenjualan.RowCount > 1 Then
                lblKeterangan.Text = "Sudah ada transaksi, Form tidak bisa ditutup !"
            Else
                Me.Dispose()
            End If
        ElseIf e.KeyCode = Keys.F4 Then
            TambahCustomerFrm.ShowDialog()
        ElseIf e.KeyCode = Keys.F5 Then
            dgPenjualan.Rows.RemoveAt(dgPenjualan.CurrentRow.Index)
        ElseIf e.KeyCode = Keys.F6 Then
            AmbilCustomerFrm.ShowDialog()
        ElseIf e.KeyCode = Keys.F7 Then

        ElseIf e.KeyCode = Keys.F8 Then
            Call bayar()
        ElseIf e.KeyCode = Keys.F9 Then
            Dim x As Object = MessageBox.Show("Apakah Anda ingin membatalkan transaksi saat ini ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If x = Windows.Forms.DialogResult.Yes Then
                dgPenjualan.Rows.Clear()
                lblTotal.Text = "0"
                txtCustomer.Text = ""
                lblKeterangan.Text = ""
            End If
        ElseIf e.KeyCode = Keys.F10 Then
            ReturPenjualanFrm.ShowDialog()
        End If
    End Sub

    Sub bayar()
        Try
            PembayaranFrm.ShowDialog()
            Call nota()
            Call bersih()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtNota_GotFocus(sender As Object, e As EventArgs) Handles txtNota.GotFocus
        txtNota.BackColor = Color.LightYellow
    End Sub

    Private Sub txtNota_LostFocus(sender As Object, e As EventArgs) Handles txtNota.LostFocus
        txtKasir.BackColor = Color.White
    End Sub

    Private Sub txtKasir_GotFocus(sender As Object, e As EventArgs) Handles txtKasir.GotFocus
        txtKasir.BackColor = Color.LightYellow
    End Sub

    Private Sub txtKasir_LostFocus(sender As Object, e As EventArgs) Handles txtKasir.LostFocus
        txtKasir.BackColor = Color.White
    End Sub
    Private Sub txtCustomer_GotFocus(sender As Object, e As EventArgs) Handles txtCustomer.GotFocus
        txtCustomer.BackColor = Color.LightYellow
    End Sub

    Private Sub txtCustomer_LostFocus(sender As Object, e As EventArgs) Handles txtCustomer.LostFocus
        txtCustomer.BackColor = Color.White
    End Sub
End Class