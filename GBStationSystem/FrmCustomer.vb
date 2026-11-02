Imports System.Data.SqlClient

Public Class FrmCustomer

    Private Sub LoadCustomers()

        dgvCustomers.Rows.Clear()

        Try
            Using conn As SqlConnection = GetConnection()

                conn.Open()

                Dim query As String =
                "SELECT CustomerID, CustomerName, Phone, Email, Address FROM Customers"

                Using cmd As New SqlCommand(query, conn)

                    Using reader As SqlDataReader = cmd.ExecuteReader()

                        While reader.Read()

                            dgvCustomers.Rows.Add(
                            reader("CustomerID").ToString(),
                            reader("CustomerName").ToString(),
                            reader("Phone").ToString(),
                            reader("Email").ToString(),
                            reader("Address").ToString()
                        )

                        End While

                    End Using

                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Unable to load customers: " & ex.Message)
        End Try

    End Sub

    Private Sub FrmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomers()
    End Sub

    Private Function GenerateCustomerID() As String

        Using conn As SqlConnection = GetConnection()

            conn.Open()

            Dim query As String =
            "SELECT ISNULL(MAX(CAST(SUBSTRING(CustomerID, 2, 19) AS INT)), 0) + 1 FROM Customers"

            Using cmd As New SqlCommand(query, conn)

                Dim nextNumber As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                Return "C" & nextNumber.ToString("000")

            End Using

        End Using

    End Function


    Private Sub BtnAddCustomer_Click(sender As Object, e As EventArgs) Handles BtnAddCustomer.Click

        Using addForm As New FrmAddCustomer()

            If addForm.ShowDialog() = DialogResult.OK Then

                Try
                    Dim customerID As String = GenerateCustomerID()

                    Using conn As SqlConnection = GetConnection()

                        conn.Open()

                        Dim query As String =
                        "INSERT INTO Customers (CustomerID, CustomerName, Phone, Email, Address) " &
                        "VALUES (@id, @name, @phone, @email, @address)"

                        Using cmd As New SqlCommand(query, conn)

                            cmd.Parameters.AddWithValue("@id", customerID)
                            cmd.Parameters.AddWithValue("@name", addForm.CustomerName)
                            cmd.Parameters.AddWithValue("@phone", addForm.CustomerPhone)
                            cmd.Parameters.AddWithValue("@email", addForm.CustomerEmail)
                            cmd.Parameters.AddWithValue("@address", addForm.CustomerAddress)

                            cmd.ExecuteNonQuery()

                        End Using

                    End Using

                    LoadCustomers()

                    MessageBox.Show("Customer saved successfully!",
                                "GBStation",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)

                Catch ex As Exception

                    MessageBox.Show("Unable to save customer: " & ex.Message)

                End Try

            End If

        End Using

    End Sub

    Private Sub BtnUpdateCustomer_Click(sender As Object, e As EventArgs) Handles BtnUpdateCustomer.Click

        If dgvCustomers.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a customer to update.")
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvCustomers.CurrentRow
        Dim customerID As String = selectedRow.Cells(0).Value.ToString()

        Using editForm As New FrmAddCustomer()

            editForm.LoadCustomer(
            selectedRow.Cells(1).Value.ToString(),
            selectedRow.Cells(2).Value.ToString(),
            selectedRow.Cells(3).Value.ToString(),
            selectedRow.Cells(4).Value.ToString()
        )

            If editForm.ShowDialog() = DialogResult.OK Then

                Try
                    Using conn As SqlConnection = GetConnection()

                        conn.Open()

                        Dim query As String =
                        "UPDATE Customers SET CustomerName=@name, Phone=@phone, " &
                        "Email=@email, Address=@address WHERE CustomerID=@id"

                        Using cmd As New SqlCommand(query, conn)

                            cmd.Parameters.AddWithValue("@name", editForm.CustomerName)
                            cmd.Parameters.AddWithValue("@phone", editForm.CustomerPhone)
                            cmd.Parameters.AddWithValue("@email", editForm.CustomerEmail)
                            cmd.Parameters.AddWithValue("@address", editForm.CustomerAddress)
                            cmd.Parameters.AddWithValue("@id", customerID)

                            cmd.ExecuteNonQuery()

                        End Using

                    End Using

                    LoadCustomers()

                    MessageBox.Show("Customer updated successfully!")

                Catch ex As Exception
                    MessageBox.Show("Unable to update customer: " & ex.Message)
                End Try

            End If

        End Using

    End Sub

    Private Sub BtnDeleteCustomer_Click(sender As Object, e As EventArgs) Handles BtnDeleteCustomer.Click

        If dgvCustomers.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a customer to delete.")
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvCustomers.CurrentRow
        Dim customerID As String = selectedRow.Cells(0).Value.ToString()

        Dim result As DialogResult = MessageBox.Show(
        "Are you sure you want to delete this customer?",
        "Confirm Deletion",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning
    )

        If result = DialogResult.Yes Then

            Try
                Using conn As SqlConnection = GetConnection()

                    conn.Open()

                    Dim query As String =
                    "DELETE FROM Customers WHERE CustomerID=@id"

                    Using cmd As New SqlCommand(query, conn)

                        cmd.Parameters.AddWithValue("@id", customerID)
                        cmd.ExecuteNonQuery()

                    End Using

                End Using

                LoadCustomers()

                MessageBox.Show("Customer deleted successfully.",
                            "GBStation",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Unable to delete customer: " & ex.Message)
            End Try

        End If

    End Sub

    Private Sub BtnSearchCustomer_Click(sender As Object, e As EventArgs) Handles BtnSearchCustomer.Click
        Dim searchText As String = TxtSearchCustomer.Text.Trim().ToLower()

        If searchText = "" Then
            MessageBox.Show("Please enter a customer ID, name, or phone number.",
                            "GBStation",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Exit Sub
        End If

        For Each row As DataGridViewRow In dgvCustomers.Rows

            If Not row.IsNewRow Then

                Dim customerID As String = row.Cells(0).Value.ToString().ToLower()
                Dim customerName As String = row.Cells(1).Value.ToString().ToLower()
                Dim phone As String = row.Cells(2).Value.ToString().ToLower()

                If customerID.Contains(searchText) OrElse
                   customerName.Contains(searchText) OrElse
                   phone.Contains(searchText) Then

                    row.Visible = True
                Else
                    row.Visible = False
                End If

            End If

        Next
    End Sub

    Private Sub BtnRefreshCustomer_Click(sender As Object, e As EventArgs) Handles BtnRefreshCustomer.Click
        TxtSearchCustomer.Clear()

        For Each row As DataGridViewRow In dgvCustomers.Rows
            If Not row.IsNewRow Then
                row.Visible = True
            End If
        Next
    End Sub

    Private Sub BtnCloseCustomer_Click(sender As Object, e As EventArgs) Handles BtnCloseCustomer.Click
        Me.Close()
    End Sub
End Class