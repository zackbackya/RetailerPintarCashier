Imports MySqlConnector
Public Class AmbilCustomerFrm
    Private Sub AmbilCustomerFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        tampilData()
        Me.KeyPreview = True
    End Sub

    Public Sub tampilData()
        Try
            Call koneksi()
            da = New MySqlDataAdapter("select nik,nama from ms_customer", conn)
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
            PenjualanProdukFrm.txtCustomer.Text = DataGridView1.CurrentRow.Cells(0).Value
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            PenjualanProdukFrm.txtCustomer.Text = DataGridView1.CurrentRow.Cells(0).Value
            Me.Close()
        End If
    End Sub

    Private Sub BtnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Dispose()
    End Sub

    Private Sub TambahPenyesuaianStokFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.F11 Then
            ambil()
        End If
    End Sub

End Class