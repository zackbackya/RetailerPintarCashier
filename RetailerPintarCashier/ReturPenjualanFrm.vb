Imports MySqlConnector
Public Class ReturPenjualanFrm
    Private Sub nota_retur()
        Try
            Call koneksi()
            Dim tgl As String = Format(Now, "yyyyMMdd")
            cmd = New MySqlCommand("select nota from tx_penjualan_det where tanggal = SUBDATE(CURDATE(),0) order by nota desc", conn)
            rd_1 = cmd.ExecuteReader
            If rd_1.Read Then
                Dim Isi As String = Val(rd_1.Item(0)) + 1
                txtNotaRetur.Text = Isi
            Else
                txtNotaRetur.Text = tgl & "100"
            End If
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtNotaPenjualan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNotaPenjualan.KeyPress
        Try
            If (e.KeyChar = Chr(13)) Then
                Call koneksi()
                cmd = New MySqlCommand("select count(*) from tx_penjualan_det where tanggal = SUBDATE(CURDATE(),0) and kasir = '" & txtKasir.Text & "' and nota like '%" & txtNotaPenjualan.Text & "%'", conn)
                rd_1 = cmd.ExecuteReader
                rd_1.Read()
                If 1 < rd_1.Item(0) Then
                    AmbilNotaFrm.ShowDialog()
                Else
                    Call koneksi()
                    cmd = New MySqlCommand("select nota from tx_penjualan_det where tanggal = SUBDATE(CURDATE(),0) and kasir = '" & txtKasir.Text & "' and nota like '%" & txtNotaPenjualan.Text & "%'", conn)
                    rd_1 = cmd.ExecuteReader
                    rd_1.Read()
                    txtNotaPenjualan.Text = rd_1.Item(0)
                    tampilData()
                    Call subtotal()
                End If
            End If
        Catch ex As Exception
            For i = 1 To 100

            Next
            MessageBox.Show("Nota penjualan tidak ditemukan !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNotaPenjualan.Text = ""
            txtNotaPenjualan.Select()
        End Try
    End Sub

    Public Sub tampilData()
        Try
            Call koneksi()
            da = New MySqlDataAdapter("select barcode,(select nama_produk from ms_produk where barcode = a.barcode)nama_produk,qty,harga,diskon,sum((harga*qty)-(diskon*qty))sub_total from tx_penjualan_det a where date(tanggal) = SUBDATE(CURDATE(),0) and kasir = '" & txtKasir.Text & "' and nota = '" & txtNotaPenjualan.Text & "' group by barcode,qty,harga,diskon", conn)
            ds = New DataSet
            da.Fill(ds)
            dgReturPenjualan.DataSource = ds.Tables(0)
            dgReturPenjualan.ReadOnly = True
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ReturPenjualanFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call nota_retur()
        Me.KeyPreview = True
        txtNotaPenjualan.Select()
        txtKasir.Text = LoginFrm.txtUsername.Text & " - [" & LoginFrm.cbShift.Text & "]"
    End Sub

    Sub subtotal()
        If dgReturPenjualan.RowCount > 0 Then
            lblKeterangan.Text = "0"
            Dim totaldiskon As Integer = 0
            For index As Integer = 0 To dgReturPenjualan.RowCount - 1
                lblKeterangan.Text += Convert.ToInt32(dgReturPenjualan.Rows(index).Cells(5).Value)
            Next
            lblKeterangan.Text = FormatNumber(lblKeterangan.Text, 0)
        Else
            lblKeterangan.Text = "0"
        End If
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Try
            Dim tgl As String = dtTanggal.Value.ToString("yyyy-MM-dd")
            Dim pay As String = MessageBox.Show("Apakah Anda ingin melakukan retur transaksi ini ?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pay = DialogResult.Yes Then
                Try
                    Call koneksi()
                    cmd = New MySqlConnector.MySqlCommand("update tx_penjualan_det set tipe = 'X' where tanggal = SUBDATE(CURDATE(),0) and kasir = '" & txtKasir.Text & "' and nota = '" & txtNotaPenjualan.Text & "'", conn)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Data Anda berhasil diupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Try
                        Call sale()
                        Me.Dispose()
                    Catch ex As Exception

                    End Try
                Catch ex As Exception
                    MessageBox.Show("Update data gagal, Silahkan cek kembali data Anda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Catch ex As Exception

        End Try
    End Sub

    Sub tx_retur()

    End Sub
End Class