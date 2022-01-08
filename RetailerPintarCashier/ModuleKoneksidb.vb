Imports MySqlConnector

Module ModuleKoneksidb

    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public rd_1, rd_2 As MySqlDataReader
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public dt As DataTable
    Public bs As BindingSource
    Public str As String

    Sub koneksi()
        Try
            Dim str As String = "Server=localhost;user id=root;password=;database=db_pbos"
            conn = New MySqlConnection(str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("Kesalahan, Database tidak tersedia", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
        End Try
    End Sub


End Module
