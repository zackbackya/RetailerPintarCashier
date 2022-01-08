Imports MySqlConnector
Public Class LoginFrm

    Dim rolename As String
    Private Sub LoginFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtUsername.Select()
        cbShift.Text = "Shift - 1"
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Call login()
    End Sub

    Private Sub txtUsername_GotFocus(sender As Object, e As EventArgs) Handles txtUsername.GotFocus
        txtUsername.BackColor = Color.LightYellow
    End Sub

    Private Sub txtUsername_LostFocus(sender As Object, e As EventArgs) Handles txtUsername.LostFocus
        txtUsername.BackColor = Color.White
    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        txtPassword.BackColor = Color.LightYellow
    End Sub

    Private Sub txtPassword_LostFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        txtPassword.BackColor = Color.White
    End Sub

    Private Sub txtServer_GotFocus(sender As Object, e As EventArgs) Handles txtServer.GotFocus
        txtServer.BackColor = Color.LightYellow
    End Sub

    Private Sub txtServer_LostFocus(sender As Object, e As EventArgs) Handles txtServer.LostFocus
        txtServer.BackColor = Color.White
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Dispose()
    End Sub

    Sub master()
        Try
            Dim tgl As Date = Date.Today
            Call koneksi()
            cmd = New MySqlCommand("select * from ms_produk where aktif = 'T' and id_produk not in (select id_produk from tx_stok where date(tanggal) = SUBDATE(CURDATE(),0))", conn)
            rd_1 = cmd.ExecuteReader
            rd_1.Read()
            If rd_1.HasRows = True Then
                Call koneksi()
                cmd = New MySqlCommand("select id_produk,nama_produk,harga_beli,harga_jual,stok from ms_produk where aktif = 'T' and id_produk not in (select id_produk from tx_stok where date(tanggal) = SUBDATE(CURDATE(),0))", conn)
                rd_2 = cmd.ExecuteReader
                While rd_2.Read()
                    Call koneksi()
                    cmd = New MySqlCommand("insert into tx_stok values ('" & Format(tgl, "yyyy-MM-dd") & "','" & rd_2.Item(0) & "','" & rd_2.Item(1) & "','" & rd_2.Item(2) & "','" & rd_2.Item(3) & "','" & rd_2.Item(4) & "','0','0','0','0','0','" & rd_2.Item(4) & "')", conn)
                    cmd.ExecuteNonQuery()
                    receipt()
                    sale()
                    koreksi()
                End While
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub login()
        Try
            If txtUsername.Text = "" Or txtPassword.Text = "" Then
                MessageBox.Show("Kesalahan, Silahkan mengisi Username dan Password Anda", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                Call koneksi()
                Dim str As String
                str = "select * from ms_user where username = '" & txtUsername.Text & "' and password = '" & txtPassword.Text & "'"
                cmd = New MySqlCommand(str, conn)
                rd_1 = cmd.ExecuteReader
                rd_1.Read()
                RoleName = rd_1.Item(2)
                If rd_1.HasRows = True Then
                    MessageBox.Show("Login berhasil, Selamat datang " & txtUsername.Text & " ( " & RoleName & " ) !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'update ms_user SET last_login = now() where username = '" & txtUsername.Text & "'


                    Call koneksi()
                    cmd = New MySqlCommand("update ms_user SET last_login = now() where username = '" & txtUsername.Text & "'", conn)
                    cmd.ExecuteNonQuery()

                    Me.Hide()
                    master()
                    s.Show()
                Else
                    MessageBox.Show("Password dan Username Anda salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Password dan Username Anda salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsername.ResetText()
            txtPassword.ResetText()
        End Try
    End Sub
End Class