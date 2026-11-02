Public Class FrmLogin
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        Dim username As String = TxtUsername.Text.Trim()

        Dim password As String = TxtPassword.Text

        If username = "" OrElse password = "" Then

            MessageBox.Show(
            "Please enter both username and password.",
            "Missing Information",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        )

            Exit Sub

        End If

        If username = "admin" AndAlso password = "GB123" Then

            MessageBox.Show(
            "Login successful!",
            "GBStation",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )

            'Open the Dashboard
            Dim dashboard As New FrmDashboard()
            dashboard.Show()

            'Hide the Login form
            Me.Hide()

        Else

            MessageBox.Show(
            "Invalid username or password.",
            "Login Failed",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )

            TxtPassword.Clear()
            TxtPassword.Focus()

        End If
    End Sub
End Class