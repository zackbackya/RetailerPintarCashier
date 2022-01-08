Imports MySqlConnector
Module ModuleHitung
    Sub sale()
        Try
            Call koneksi()
            cmd = New MySqlCommand("select (select id_produk from ms_produk where barcode = a.barcode)id_produk,sum(qty) from tx_penjualan_det a where date(tanggal) = SUBDATE(CURDATE(), 0) and tipe = 'N' group by id_produk", conn)
            rd_1 = cmd.ExecuteReader
            While rd_1.Read()
                Call koneksi()
                cmd = New MySqlCommand("update tx_stok set sale = '" & rd_1.Item(1) & "' where date(tanggal) = SUBDATE(CURDATE(), 0) and id_produk = '" & rd_1.Item(0) & "'", conn)
                cmd.ExecuteNonQuery()
                conn.Close()
            End While
            conn.Close()
            Call s_akhir()
            Call selisih()
        Catch ex As Exception

        End Try
    End Sub
    Sub retur()
        Try
            Call koneksi()
            cmd = New MySqlCommand("", conn)
            rd_1 = cmd.ExecuteReader
            While rd_1.Read()
                Call koneksi()
                cmd = New MySqlCommand("update tx_stok set retur = '" & rd_1.Item(1) & "' where date(tanggal) = SUBDATE(CURDATE(), 0) and id_produk = '" & rd_1.Item(0) & "'", conn)
                cmd.ExecuteNonQuery()
                conn.Close()
            End While
            conn.Close()
            Call s_akhir()
        Catch ex As Exception

        End Try
    End Sub
    Sub receipt()
        Try
            Call koneksi()
            cmd = New MySqlCommand("select id_produk,sum(qty) from tx_pembelian_produk where date(tanggal) = SUBDATE(CURDATE(), 0) group by id_produk", conn)
            rd_1 = cmd.ExecuteReader
            While rd_1.Read()
                Call koneksi()
                cmd = New MySqlCommand("update tx_stok set receipt = '" & rd_1.Item(1) & "' where date(tanggal) = SUBDATE(CURDATE(), 0) and id_produk = '" & rd_1.Item(0) & "'", conn)
                cmd.ExecuteNonQuery()
                conn.Close()
            End While
            conn.Close()
            Call s_akhir()
            Call selisih()
        Catch ex As Exception

        End Try
    End Sub
    Sub koreksi()
        Try
            Call koneksi()
            cmd = New MySqlCommand("select barcode,sum(qty) from trx_koreksi where date(tanggal) = SUBDATE(CURDATE(), 0) group by barcode", conn)
            rd_1 = cmd.ExecuteReader
            While rd_1.Read()
                Call koneksi()
                cmd = New MySqlCommand("update trx_stok set q_koreksi = '" & rd_1.Item(1) & "' where date(tanggal) = SUBDATE(CURDATE(), 0) and barcode = '" & rd_1.Item(0) & "'", conn)
                cmd.ExecuteNonQuery()
            End While
            Call s_akhir()
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub
    Sub s_akhir()
        Try
            Call koneksi()
            cmd = New MySqlCommand("select id_produk,sum(stok_awal+receipt)-(sale+retur)+(koreksi)stok_akhir from tx_stok where date(tanggal) = SUBDATE(CURDATE(), 0) group by id_produk", conn)
            rd_1 = cmd.ExecuteReader
            While rd_1.Read()
                Call koneksi()
                cmd = New MySqlCommand("update tx_stok set stok_akhir = '" & rd_1.Item(1) & "' where date(tanggal) = SUBDATE(CURDATE(), 0) and id_produk = '" & rd_1.Item(0) & "'", conn)
                cmd.ExecuteNonQuery()
                cmd = New MySqlCommand("update ms_produk set stok = '" & rd_1.Item(1) & "' where id_produk = '" & rd_1.Item(0) & "'", conn)
                cmd.ExecuteNonQuery()
                conn.Close()
            End While
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Sub selisih()
        Try
            Call koneksi()
            cmd = New MySqlCommand("select id_produk,sum(COALESCE((stok_awal+receipt),0)-COALESCE((sale+stok_akhir),0))selisih from tx_stok where date(tanggal) = SUBDATE(CURDATE(), 0) group by id_produk", conn)
            rd_1 = cmd.ExecuteReader
            While rd_1.Read()
                Call koneksi()
                cmd = New MySqlCommand("update tx_stok set selisih = '" & rd_1.Item(1) & "' where date(tanggal) = SUBDATE(CURDATE(), 0) and id_produk = '" & rd_1.Item(0) & "'", conn)
                cmd.ExecuteNonQuery()
                conn.Close()
            End While
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

    'HITUNG ALL
    Sub sale_all()
        Try
            Call koneksi()
            cmd = New MySqlCommand("", conn)
            rd_1 = cmd.ExecuteReader
            While rd_1.Read()
                Call koneksi()
                cmd = New MySqlCommand("update trx_stok set q_sale = '" & rd_1.Item(1) & "',net_sales = '" & rd_1.Item(2) & "' where date(tanggal) = SUBDATE(CURDATE(), 0) and barcode = '" & rd_1.Item(0) & "'", conn)
                cmd.ExecuteNonQuery()
                conn.Close()
            End While
            conn.Close()
            Call s_akhir_all()
        Catch ex As Exception

        End Try
    End Sub
    Sub retur_all()
        Try
            Call koneksi()
            cmd = New MySqlCommand("", conn)
            rd_1 = cmd.ExecuteReader
            While rd_1.Read()
                Call koneksi()
                cmd = New MySqlCommand("update trx_stok set q_retur = '" & rd_1(1) & "' where date(tanggal) = SUBDATE(CURDATE(), 0) and barcode = '" & rd_1.Item(0) & "'", conn)
                cmd.ExecuteNonQuery()
                conn.Close()
            End While
            conn.Close()
            Call s_akhir_all()
        Catch ex As Exception

        End Try
    End Sub
    Sub receipt_all()
        Try
            Call koneksi()
            cmd = New MySqlCommand("select id_produk,sum(qty),tanggal from tx_pembelian_produk group by tanggal,id_produk", conn)
            rd_1 = cmd.ExecuteReader
            While rd_1.Read()
                Call koneksi()
                cmd = New MySqlCommand("update tx_stok set receipt = '" & rd_1.Item(1) & "' where date(tanggal) = '" & Format(rd_1.Item(2), "yyyy-MM-dd") & "' and id_produk = '" & rd_1.Item(0) & "'", conn)
                cmd.ExecuteNonQuery()
                conn.Close()
            End While
            conn.Close()
            Call s_akhir_all()
            Call selisih_all()
        Catch ex As Exception

        End Try
    End Sub
    Sub koreksi_all()
        Try
            Call koneksi()
            cmd = New MySqlCommand("", conn)
            rd_1 = cmd.ExecuteReader
            While rd_1.Read()
                Call koneksi()
                cmd = New MySqlCommand("update trx_stok set q_koreksi = '" & rd_1.Item(1) & "' where date(tanggal) = '" & Format(rd_1.Item(2), "yyyy-MM-dd") & "' and id_produk = '" & rd_1.Item(0) & "'", conn)
                cmd.ExecuteNonQuery()
                conn.Close()
            End While
            conn.Close()
            Call s_akhir_all()
        Catch ex As Exception

        End Try
    End Sub
    Sub s_akhir_all()
        Try
            Call koneksi()
            cmd = New MySqlCommand("select id_produk,sum(stok_awal+receipt)-(sale+retur)+(koreksi)stok_akhir,tanggal from tx_stok group by tanggal,id_produk", conn)
            rd_1 = cmd.ExecuteReader
            While rd_1.Read()
                Call koneksi()
                cmd = New MySqlCommand("update tx_stok set stok_akhir = '" & rd_1.Item(1) & "' where date(tanggal) = '" & Format(rd_1.Item(2), "yyyy-MM-dd") & "'  and id_produk = '" & rd_1.Item(0) & "'", conn)
                cmd.ExecuteNonQuery()
                cmd = New MySqlCommand("update ms_produk set stok = '" & rd_1.Item(1) & "' where id_produk = '" & rd_1.Item(0) & "'", conn)
                cmd.ExecuteNonQuery()
                conn.Close()
            End While
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Sub selisih_all()
        Try
            Call koneksi()
            cmd = New MySqlCommand("select id_produk,sum(COALESCE((stok_awal+receipt),0)-COALESCE((sale+stok_akhir),0))selisih,tanggal from tx_stok group by tanggal,id_produk", conn)
            rd_1 = cmd.ExecuteReader
            While rd_1.Read()
                Call koneksi()
                cmd = New MySqlCommand("update tx_stok set selisih = '" & rd_1.Item(1) & "' where date(tanggal) = '" & Format(rd_1.Item(2), "yyyy-MM-dd") & "'  and id_produk = '" & rd_1.Item(0) & "'", conn)
                cmd.ExecuteNonQuery()
                conn.Close()
            End While
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

End Module
