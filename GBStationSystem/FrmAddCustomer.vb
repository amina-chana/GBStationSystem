Public Class FrmAddCustomer

    Public ReadOnly Property CustomerName As String
        Get
            Return TxtCustomerName.Text.Trim()
        End Get
    End Property

    Public ReadOnly Property CustomerPhone As String
        Get
            Return TxtPhone.Text.Trim()
        End Get
    End Property

    Public ReadOnly Property CustomerEmail As String
        Get
            Return TxtEmail.Text.Trim()
        End Get
    End Property

    Public ReadOnly Property CustomerAddress As String
        Get
            Return TxtAddress.Text.Trim()
        End Get
    End Property

    Public Sub LoadCustomer(name As String,
                        phone As String,
                        email As String,
                        address As String)

        TxtCustomerName.Text = name
        TxtPhone.Text = phone
        TxtEmail.Text = email
        TxtAddress.Text = address

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click



        If TxtCustomerName.Text.Trim() = "" Then
            MessageBox.Show("Please enter the customer name.")
            TxtCustomerName.Focus()
            Exit Sub
        End If


        If TxtPhone.Text.Trim().Length <> 10 Then
            MessageBox.Show("Phone number must contain exactly 10 digits.",
                    "Invalid Phone Number",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning)
            TxtPhone.Focus()
            Return
        End If

        If TxtEmail.Text.Trim() <> "" AndAlso
       Not TxtEmail.Text.Contains("@") Then

            MessageBox.Show("Please enter a valid email address.")
            TxtEmail.Focus()
            Exit Sub
        End If


        If TxtAddress.Text.Trim() = "" Then
            MessageBox.Show("Please enter the physical address.")
            TxtAddress.Focus()
            Exit Sub
        End If

        MessageBox.Show("Customer information is valid.",
                    "GBStation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information)

        Me.DialogResult = DialogResult.OK
        Me.Close()

    End Sub

    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPhone.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso
           Not Char.IsControl(e.KeyChar) Then

            e.Handled = True

        End If

    End Sub

End Class