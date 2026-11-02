Imports System.Data.SqlClient
Imports System.IO

Public Class FrmSales
    Private Sub FrmSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TxtSaleID.Text = "SLS-" & DateTime.Now.ToString("yyyyMMdd") & "-001"

        dtpSaleDate.Value = DateTime.Now

        cmbPaymentMethod.Items.Clear()
        cmbPaymentMethod.Items.Add("Cash")
        cmbPaymentMethod.Items.Add("M-Pesa")
        cmbPaymentMethod.Items.Add("Bank Transfer")
        cmbPaymentMethod.SelectedIndex = 0

        LoadCustomers()
        LoadProducts()

    End Sub


    Private Sub LoadCustomers()

        Try
            Using conn As SqlConnection = GetConnection()

                conn.Open()

                Dim query As String =
                    "SELECT CustomerID, CustomerName FROM Customers ORDER BY CustomerName"

                Using adapter As New SqlDataAdapter(query, conn)

                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    cmbCustomer.DataSource = dt
                    cmbCustomer.DisplayMember = "CustomerName"
                    cmbCustomer.ValueMember = "CustomerID"
                    cmbCustomer.SelectedIndex = -1

                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Unable to load customers: " & ex.Message)
        End Try

    End Sub


    Private Sub LoadProducts()

        Try
            Using conn As SqlConnection = GetConnection()

                conn.Open()

                Dim query As String =
                    "SELECT ProductID, ProductName FROM Products WHERE Quantity > 0 ORDER BY ProductName"

                Using adapter As New SqlDataAdapter(query, conn)

                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    cmbProduct.DataSource = dt
                    cmbProduct.DisplayMember = "ProductName"
                    cmbProduct.ValueMember = "ProductID"
                    cmbProduct.SelectedIndex = -1

                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Unable to load products: " & ex.Message)
        End Try

    End Sub

    Private Sub cmbProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbProduct.SelectedIndexChanged

        If CmbProduct.SelectedIndex = -1 OrElse CmbProduct.SelectedValue Is Nothing Then
            Return
        End If

        If Not TypeOf CmbProduct.SelectedValue Is String Then
            Return
        End If

        Try
            Using conn As SqlConnection = GetConnection()

                conn.Open()

                Dim query As String =
                    "SELECT UnitPrice, Quantity FROM Products WHERE ProductID=@id"

                Using cmd As New SqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@id", CmbProduct.SelectedValue.ToString())

                    Using reader As SqlDataReader = cmd.ExecuteReader()

                        If reader.Read() Then

                            TxtUnitPrice.Text = Convert.ToDecimal(reader("UnitPrice")).ToString("N2")

                            TxtStockAvailable.Text = reader("Quantity").ToString()

                        End If

                    End Using

                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Unable to retrieve product details: " & ex.Message)
        End Try

    End Sub

    Private Sub BtnAddToSale_Click(sender As Object, e As EventArgs) Handles BtnAddToSales.Click

        If CmbProduct.SelectedIndex = -1 Then
            MessageBox.Show("Please select a product.")
            Return
        End If

        Dim quantity As Integer = Convert.ToInt32(nudQuantity.Value)
        Dim availableStock As Integer = Convert.ToInt32(TxtStockAvailable.Text)

        If quantity <= 0 Then
            MessageBox.Show("Enter a valid quantity.")
            Return
        End If

        If quantity > availableStock Then
            MessageBox.Show("Not enough stock available.")
            Return
        End If

        Dim productID As String = CmbProduct.SelectedValue.ToString()
        Dim productName As String = CmbProduct.Text
        Dim unitPrice As Decimal = Convert.ToDecimal(TxtUnitPrice.Text)
        Dim subtotal As Decimal = unitPrice * quantity

        'Check whether the product is already in the sale
        For Each row As DataGridViewRow In dgvSaleItems.Rows

            If Not row.IsNewRow AndAlso row.Cells(0).Value.ToString() = productID Then

                Dim existingQuantity As Integer = Convert.ToInt32(row.Cells(3).Value)

                If existingQuantity + quantity > availableStock Then
                    MessageBox.Show("The requested quantity exceeds available stock.")
                    Return
                End If

                row.Cells(3).Value = existingQuantity + quantity

                row.Cells(4).Value = unitPrice * (existingQuantity + quantity)

                UpdateSaleTotal()
                Return

            End If

        Next

        dgvSaleItems.Rows.Add(
            productID,
            productName,
            unitPrice,
            quantity,
            subtotal
        )

        UpdateSaleTotal()

        MessageBox.Show("Product added to sale.")

    End Sub


    Private Sub UpdateSaleTotal()

        Dim total As Decimal = 0

        For Each row As DataGridViewRow In dgvSaleItems.Rows

            If Not row.IsNewRow Then
                total += Convert.ToDecimal(row.Cells(4).Value)
            End If

        Next

        TxtTotalSales.Text = "KSh " & total.ToString("N2")

    End Sub

    Private Sub btnRemoveItem_Click(sender As Object, e As EventArgs) Handles BtnRemoveItem.Click

        If dgvSaleItems.CurrentRow Is Nothing Then
            MessageBox.Show("Please select an item to remove.")
            Return
        End If

        dgvSaleItems.Rows.Remove(dgvSaleItems.CurrentRow)

        UpdateSaleTotal()

    End Sub

    Private Sub btnClearSale_Click(sender As Object, e As EventArgs) Handles BtnClearSale.Click

        If dgvSaleItems.Rows.Count = 0 Then
            MessageBox.Show("There are no items to clear.")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to clear this sale?",
            "Confirm",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result = DialogResult.Yes Then

            dgvSaleItems.Rows.Clear()

            UpdateSaleTotal()

        End If

    End Sub

    Private Sub btnCompleteSale_Click(sender As Object, e As EventArgs) Handles BtnCompleteSale.Click

        If cmbCustomer.SelectedIndex = -1 Then
            MessageBox.Show("Please select a customer.")
            Return
        End If

        If cmbPaymentMethod.SelectedIndex = -1 Then
            MessageBox.Show("Please select a payment method.")
            Return
        End If

        If dgvSaleItems.Rows.Count = 0 Then
            MessageBox.Show("Please add products to the sale.")
            Return
        End If

        Dim total As Decimal = 0

        For Each row As DataGridViewRow In dgvSaleItems.Rows
            If Not row.IsNewRow Then
                total += Convert.ToDecimal(row.Cells(4).Value)
            End If
        Next

        Dim customerID As String = cmbCustomer.SelectedValue.ToString()
        Dim paymentMethod As String = cmbPaymentMethod.Text

        Try
            Using conn As SqlConnection = GetConnection()

                conn.Open()

                Using transaction As SqlTransaction = conn.BeginTransaction()

                    Try
                        'Save the main sale record
                        Dim saleQuery As String =
                            "INSERT INTO Sales (SaleDate, CustomerID, PaymentMethod, TotalAmount) " &
                            "VALUES (@date, @customer, @payment, @total); " &
                            "SELECT CAST(SCOPE_IDENTITY() AS INT);"

                        Dim saleID As Integer

                        Using cmd As New SqlCommand(saleQuery, conn, transaction)

                            cmd.Parameters.AddWithValue("@date", dtpSaleDate.Value)
                            cmd.Parameters.AddWithValue("@customer", customerID)
                            cmd.Parameters.AddWithValue("@payment", paymentMethod)
                            cmd.Parameters.AddWithValue("@total", total)

                            saleID = Convert.ToInt32(cmd.ExecuteScalar())

                        End Using

                        'Save sale items and reduce stock
                        For Each row As DataGridViewRow In dgvSaleItems.Rows

                            If Not row.IsNewRow Then

                                Dim productID As String = row.Cells(0).Value.ToString()
                                Dim unitPrice As Decimal = Convert.ToDecimal(row.Cells(2).Value)
                                Dim quantity As Integer = Convert.ToInt32(row.Cells(3).Value)
                                Dim subtotal As Decimal = Convert.ToDecimal(row.Cells(4).Value)

                                'Reduce stock only if enough stock remains
                                Dim stockQuery As String =
                                    "UPDATE Products SET Quantity = Quantity - @quantity " &
                                    "WHERE ProductID = @id AND Quantity >= @quantity"

                                Using stockCmd As New SqlCommand(stockQuery, conn, transaction)

                                    stockCmd.Parameters.AddWithValue("@quantity", quantity)
                                    stockCmd.Parameters.AddWithValue("@id", productID)

                                    If stockCmd.ExecuteNonQuery() = 0 Then
                                        Throw New Exception("Insufficient stock for product: " & productID)
                                    End If

                                End Using

                                'Save individual sale item
                                Dim itemQuery As String =
                                    "INSERT INTO SaleItems (SaleID, ProductID, Quantity, UnitPrice, LineTotal) " &
                                    "VALUES (@saleID, @productID, @quantity, @price, @subtotal)"

                                Using itemCmd As New SqlCommand(itemQuery, conn, transaction)

                                    itemCmd.Parameters.AddWithValue("@saleID", saleID)
                                    itemCmd.Parameters.AddWithValue("@productID", productID)
                                    itemCmd.Parameters.AddWithValue("@quantity", quantity)
                                    itemCmd.Parameters.AddWithValue("@price", unitPrice)
                                    itemCmd.Parameters.AddWithValue("@subtotal", subtotal)

                                    itemCmd.ExecuteNonQuery()

                                End Using

                            End If

                        Next

                        transaction.Commit()
                        GenerateReceipt(saleID)

                        MessageBox.Show(
                            "Sale completed successfully!" & vbCrLf &
                            "Sale ID: SLS-" & saleID.ToString("00000") & vbCrLf &
                            "Total: KSh " & total.ToString("N2"),
                            "GBStation",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        )

                    Catch
                        transaction.Rollback()
                        Throw
                    End Try

                End Using

            End Using

            'Clear the completed sale
            dgvSaleItems.Rows.Clear()
            UpdateSaleTotal()

            'Refresh available products and stock
            LoadProducts()

            TxtUnitPrice.Clear()
            TxtStockAvailable.Clear()
            nudQuantity.Value = 1

        Catch ex As Exception

            MessageBox.Show(
                "Unable to complete sale: " & ex.Message,
                "GBStation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    Private Sub GenerateReceipt(saleID As Integer)

        Dim receipt As New System.Text.StringBuilder()

        receipt.AppendLine("       GBSTATION STATIONERY SUPPLIES")
        receipt.AppendLine("==========================================")
        receipt.AppendLine("             SALES RECEIPT")
        receipt.AppendLine("------------------------------------------")
        receipt.AppendLine("Receipt No: SLS-" & saleID.ToString("00000"))
        receipt.AppendLine("Date: " & dtpSaleDate.Value.ToString("dd/MM/yyyy HH:mm"))
        receipt.AppendLine("Customer: " & cmbCustomer.Text)
        receipt.AppendLine("Payment: " & cmbPaymentMethod.Text)
        receipt.AppendLine("------------------------------------------")
        receipt.AppendLine("Product       Qty    Price       Total")
        receipt.AppendLine("------------------------------------------")

        For Each row As DataGridViewRow In dgvSaleItems.Rows

            If Not row.IsNewRow Then

                receipt.AppendLine(
                    row.Cells(1).Value.ToString() & "   " &
                    row.Cells(3).Value.ToString() & "   " &
                    Convert.ToDecimal(row.Cells(2).Value).ToString("N2") & "   " &
                    Convert.ToDecimal(row.Cells(4).Value).ToString("N2")
                )

            End If

        Next

        receipt.AppendLine("------------------------------------------")
        receipt.AppendLine(TxtTotalSales.Text)
        receipt.AppendLine("==========================================")
        receipt.AppendLine("       THANK YOU FOR SHOPPING WITH US!")
        receipt.AppendLine("==========================================")

        Using saveDialog As New SaveFileDialog()

            saveDialog.Title = "Save Sales Receipt"
            saveDialog.Filter = "Text Receipt (*.txt)|*.txt"
            saveDialog.FileName = "Receipt_SLS-" & saleID.ToString("00000") & ".txt"

            If saveDialog.ShowDialog() = DialogResult.OK Then

                File.WriteAllText(saveDialog.FileName, receipt.ToString())

                MessageBox.Show("Receipt saved successfully!")

            End If

        End Using

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

End Class