Imports MySqlConnector
Public Class AmbilNotaFrm
    Private Sub AmbilNotaFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        tampilData()
        Me.KeyPreview = True
    End Sub

    Public Sub tampilData()
        Try
            Call koneksi()
            da = New MySqlDataAdapter("select tanggal,nota from tx_penjualan_head where date(tanggal) = SUBDATE(CURDATE(),0) and nota not in (select nota from tx_penjualan_det where date(tanggal) = SUBDATE(CURDATE(),0) and tipe = 'X') and kasir = '" & PenjualanProdukFrm.txtKasir.Text & "'", conn)
            ds = New DataSet
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.ReadOnly = True
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ambil()
    End Sub

    Sub ambil()
        Try
            ReturPenjualanFrm.txtNotaPenjualan.Text = DataGridView1.CurrentRow.Cells(1).Value
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            ReturPenjualanFrm.txtNotaPenjualan.Text = DataGridView1.CurrentRow.Cells(1).Value
            Me.Close()
        End If
    End Sub

    Private Sub BtnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Dispose()
    End Sub

    Private Sub AmbilNotaFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.F11 Then
            ambil()
        End If
    End Sub
End Class