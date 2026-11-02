Public Class FrmAddProduct

    Public ReadOnly Property EnteredProductName As String
        Get
            Return TxtProductName.Text.Trim()
        End Get
    End Property

    Public ReadOnly Property ProductCategory As String
        Get
            Return CmbCategory.Text
        End Get
    End Property

    Public ReadOnly Property ProductPrice As Decimal
        Get
            Return Decimal.Parse(TxtUnitPrice.Text)
        End Get
    End Property

    Public ReadOnly Property ProductQuantity As Integer
        Get
            Return Integer.Parse(TxtQuantity.Text)
        End Get
    End Property

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If TxtProductName.Text.Trim() = "" Then
            MessageBox.Show("Please enter the product name.",
                            "Missing Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            TxtProductName.Focus()
            Return
        End If

        If CmbCategory.SelectedIndex = -1 Then
            MessageBox.Show("Please select a product category.",
                            "Missing Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            CmbCategory.Focus()
            Return
        End If

        Dim price As Decimal

        If Not Decimal.TryParse(TxtUnitPrice.Text, price) OrElse price <= 0 Then
            MessageBox.Show("Please enter a valid price greater than zero.",
                            "Invalid Price",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            TxtUnitPrice.Focus()
            Return
        End If


        Dim quantity As Integer

        If Not Integer.TryParse(TxtQuantity.Text, quantity) OrElse quantity < 0 Then
            MessageBox.Show("Please enter a valid quantity of zero or more.",
                            "Invalid Quantity",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            TxtQuantity.Focus()
            Return
        End If

        MessageBox.Show("Product details are valid!",
                        "Validation Successful",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

        Me.DialogResult = DialogResult.OK
        Me.Close()


    End Sub

    Public Sub LoadProduct(name As String, category As String,
                       price As Decimal, quantity As Integer)

        TxtProductName.Text = name
        CmbCategory.Text = category
        txtUnitPrice.Text = price.ToString()
        TxtQuantity.Text = quantity.ToString()

    End Sub

End Class