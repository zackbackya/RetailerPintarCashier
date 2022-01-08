Public Class s
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.ClassStyle = param.ClassStyle Or &H200
            Return param
        End Get
    End Property

    Private Sub txtSaldoAwal_GotFocus(sender As Object, e As EventArgs) Handles txtSaldoAwal.GotFocus
        txtSaldoAwal.BackColor = Color.LightYellow
    End Sub

    Private Sub txtSaldoAwal_LostFocus(sender As Object, e As EventArgs) Handles txtSaldoAwal.LostFocus
        txtSaldoAwal.BackColor = Color.White
    End Sub

    Private Sub txtUsername_GotFocus(sender As Object, e As EventArgs) Handles txtUsername.GotFocus
        txtUsername.BackColor = Color.LightYellow
    End Sub

    Private Sub txtUsername_LostFocus(sender As Object, e As EventArgs) Handles txtUsername.LostFocus
        txtUsername.BackColor = Color.White
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Hide()
        MainFrm.Show()
    End Sub

    Private Sub s_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtUsername.Text = LoginFrm.txtUsername.Text
        txtSaldoAwal.Select()
    End Sub
End Class