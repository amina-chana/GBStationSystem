Imports System.Data.SqlClient

Public Class FrmProducts


    Private Sub LoadProducts()

        Try
            dgvProducts.Rows.Clear()

            Using conn As SqlConnection = GetConnection()

                conn.Open()

                Dim query As String =
                "SELECT ProductID, ProductName, Category, UnitPrice, Quantity FROM Products"

                Using cmd As New SqlCommand(query, conn)

                    Using reader As SqlDataReader = cmd.ExecuteReader()

                        While reader.Read()

                            dgvProducts.Rows.Add(
                            reader("ProductID").ToString(),
                            reader("ProductName").ToString(),
                            reader("Category").ToString(),
                            Convert.ToDecimal(reader("UnitPrice")).ToString("N2"),
                            reader("Quantity").ToString()
                        )

                        End While

                    End Using

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show("Unable to load products: " & ex.Message,
                        "GBStation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub FrmProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
    End Sub


    Private Function GenerateProductID() As String

        Using conn As SqlConnection = GetConnection()

            conn.Open()

            Dim query As String =
            "SELECT ISNULL(MAX(CAST(SUBSTRING(ProductID, 2, 19) AS INT)), 0) + 1 FROM Products"

            Using cmd As New SqlCommand(query, conn)

                Dim nextNumber As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                Return "P" & nextNumber.ToString("000")

            End Using

        End Using

    End Function

    Private Sub BtnAddProduct_Click(sender As Object, e As EventArgs) Handles BtnAddProduct.Click


        Using addForm As New FrmAddProduct()

            If addForm.ShowDialog() = DialogResult.OK Then

                Try
                    Dim productID As String = GenerateProductID()

                    Using conn As SqlConnection = GetConnection()

                        conn.Open()

                        Dim query As String =
                        "INSERT INTO Products (ProductID, ProductName, Category, UnitPrice, Quantity) " &
                        "VALUES (@id, @name, @category, @price, @quantity)"

                        Using cmd As New SqlCommand(query, conn)

                            cmd.Parameters.AddWithValue("@id", productID)
                            cmd.Parameters.AddWithValue("@name", addForm.EnteredProductName)
                            cmd.Parameters.AddWithValue("@category", addForm.ProductCategory)
                            cmd.Parameters.AddWithValue("@price", addForm.ProductPrice)
                            cmd.Parameters.AddWithValue("@quantity", addForm.ProductQuantity)

                            cmd.ExecuteNonQuery()

                        End Using

                    End Using

                    LoadProducts()

                    MessageBox.Show("Product saved successfully!",
                                "GBStation",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)

                Catch ex As Exception

                    MessageBox.Show("Unable to save product: " & ex.Message,
                                "GBStation",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error)

                End Try

            End If

        End Using

    End Sub

    Private Sub BtnUpdateProduct_Click(sender As Object, e As EventArgs) Handles BtnUpdateProduct.Click

        If dgvProducts.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a product to update.")
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvProducts.SelectedRows(0)

        Dim productID As String = selectedRow.Cells(0).Value.ToString()

        Using editForm As New FrmAddProduct()

            editForm.LoadProduct(
            selectedRow.Cells(1).Value.ToString(),
            selectedRow.Cells(2).Value.ToString(),
            Convert.ToDecimal(selectedRow.Cells(3).Value),
            Convert.ToInt32(selectedRow.Cells(4).Value)
        )

            If editForm.ShowDialog() = DialogResult.OK Then

                Try
                    Using conn As SqlConnection = GetConnection()

                        conn.Open()

                        Dim query As String =
                        "UPDATE Products SET ProductName=@name, Category=@category, " &
                        "UnitPrice=@price, Quantity=@quantity WHERE ProductID=@id"

                        Using cmd As New SqlCommand(query, conn)

                            cmd.Parameters.AddWithValue("@name", editForm.EnteredProductName)
                            cmd.Parameters.AddWithValue("@category", editForm.ProductCategory)
                            cmd.Parameters.AddWithValue("@price", editForm.ProductPrice)
                            cmd.Parameters.AddWithValue("@quantity", editForm.ProductQuantity)
                            cmd.Parameters.AddWithValue("@id", productID)

                            cmd.ExecuteNonQuery()

                        End Using

                    End Using

                    LoadProducts()

                    MessageBox.Show("Product updated successfully!")

                Catch ex As Exception
                    MessageBox.Show("Unable to update product: " & ex.Message)
                End Try

            End If

        End Using

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click

        If dgvProducts.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a product to delete.")
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvProducts.SelectedRows(0)
        Dim productID As String = selectedRow.Cells(0).Value.ToString()

        Dim answer As DialogResult = MessageBox.Show(
        "Are you sure you want to delete this product?",
        "Confirm Delete",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning)

        If answer = DialogResult.Yes Then

            Try
                Using conn As SqlConnection = GetConnection()

                    conn.Open()

                    Dim query As String =
                    "DELETE FROM Products WHERE ProductID=@id"

                    Using cmd As New SqlCommand(query, conn)

                        cmd.Parameters.AddWithValue("@id", productID)
                        cmd.ExecuteNonQuery()

                    End Using

                End Using

                LoadProducts()
                MessageBox.Show("Product deleted successfully!")

            Catch ex As Exception
                MessageBox.Show("Unable to delete product: " & ex.Message)
            End Try

        End If

    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click

        Dim searchValue As String = TxtSearchProduct.Text.Trim().ToLower()

        For Each row As DataGridViewRow In dgvProducts.Rows

            If Not row.IsNewRow Then

                Dim productID As String = row.Cells(0).Value.ToString().ToLower()
                Dim productName As String = row.Cells(1).Value.ToString().ToLower()
                Dim category As String = row.Cells(2).Value.ToString().ToLower()

                If productID.Contains(searchValue) OrElse
               productName.Contains(searchValue) OrElse
               category.Contains(searchValue) Then

                    row.Visible = True

                Else

                    row.Visible = False

                End If

            End If

        Next

    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        TxtSearchProduct.Clear()

        For Each row As DataGridViewRow In dgvProducts.Rows

            If Not row.IsNewRow Then
                row.Visible = True
            End If

        Next
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click

        If dgvProducts.CurrentCell IsNot Nothing AndAlso
           dgvProducts.CurrentCell.Value IsNot Nothing Then

            Clipboard.SetText(dgvProducts.CurrentCell.Value.ToString())
            MessageBox.Show("Copied successfully!")

        Else
            MessageBox.Show("Please select a cell first.")
        End If

    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click

        If Clipboard.ContainsText() Then

            Dim pastedText As String = Clipboard.GetText()

            If dgvProducts.CurrentCell IsNot Nothing AndAlso
               Not dgvProducts.CurrentCell.ReadOnly Then

                dgvProducts.CurrentCell.Value = pastedText
                MessageBox.Show("Text pasted successfully!")

            Else
                MessageBox.Show("Select an editable cell first.")
            End If

        Else
            MessageBox.Show("Clipboard is empty.")
        End If

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class