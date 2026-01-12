Public Class FormLogin
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show(
                "Username dan password harus diisi!",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            If String.IsNullOrWhiteSpace(username) Then
                txtUsername.Focus()
            Else
                txtPassword.Focus()
            End If
            Return
        End If

        If username.Equals(DefaultUsername, StringComparison.OrdinalIgnoreCase) AndAlso
           password = DefaultPassword Then
            Dim frmKasir As New FormKasir()
            frmKasir.Show()
            Me.Close()
        Else
            MessageBox.Show(
                "Username atau password salah!" & vbCrLf & vbCrLf &
                "Silakan coba lagi.",
                "Kesalahan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
            txtPassword.Focus()
        End If
    End Sub

End Class
