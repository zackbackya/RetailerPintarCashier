Public Class TambahCustomerFrm


    Private Sub tambahData()
        Call koneksi()
        Try

            Dim jenis_kelamin As String
            If rdLakiLaki.Checked = True Then
                jenis_kelamin = "L"
            ElseIf rdPerempuan.Checked = True Then
                jenis_kelamin = "P"
            End If

            str = "insert into ms_Customer values ('" & txtIdCustomer.Text & "','" & txtNIKCustomer.Text & "','" & txtNamaCustomer.Text & "','" & txtAlamatCustomer.Text & "','" & jenis_kelamin & "','" & txtTeleponCustomer.Text & "')"
            cmd = New MySqlConnector.MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Anda berhasil ditambah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Dispose()

        Catch ex As Exception
            MessageBox.Show("Tambah data gagal, Silahkan cek kembali data Anda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TambahCustomerFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call GenTempID()
        txtNamaCustomer.Focus()
        Me.KeyPreview = True
    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub TambahCustomerFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Public Sub GenTempID()
        Dim idjam As String = Format(Now(), "HHmmss")
        txtIdCustomer.Text = "CT-" + idjam
    End Sub


    Private Sub btnSimpan_Click_1(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Call tambahData()
    End Sub

    Private Sub btnSelesai_Click_1(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Dispose()
    End Sub


    Private Sub txtAlamatCustomer_GotFocus(sender As Object, e As EventArgs) Handles txtAlamatCustomer.GotFocus
        txtAlamatCustomer.BackColor = Color.LightYellow
    End Sub

    Private Sub txtAlamatCustomer_LostFocus(sender As Object, e As EventArgs) Handles txtAlamatCustomer.LostFocus
        txtAlamatCustomer.BackColor = Color.White
    End Sub

    Private Sub txtNamaCustomer_GotFocus(sender As Object, e As EventArgs) Handles txtNamaCustomer.GotFocus
        txtNamaCustomer.BackColor = Color.LightYellow
    End Sub

    Private Sub txtNamaCustomere_LostFocus(sender As Object, e As EventArgs) Handles txtNamaCustomer.LostFocus
        txtNamaCustomer.BackColor = Color.White
    End Sub

    Private Sub txtNIKCustomer_GotFocus(sender As Object, e As EventArgs) Handles txtNIKCustomer.GotFocus
        txtNIKCustomer.BackColor = Color.LightYellow
    End Sub

    Private Sub txtNIKCustomer_LostFocus(sender As Object, e As EventArgs) Handles txtNIKCustomer.LostFocus
        txtNIKCustomer.BackColor = Color.White
    End Sub

    Private Sub txtTeleponCustomer_GotFocus(sender As Object, e As EventArgs) Handles txtTeleponCustomer.GotFocus
        txtTeleponCustomer.BackColor = Color.LightYellow
    End Sub

    Private Sub txtTeleponCustomer_LostFocus(sender As Object, e As EventArgs) Handles txtTeleponCustomer.LostFocus
        txtTeleponCustomer.BackColor = Color.White
    End Sub
End Class