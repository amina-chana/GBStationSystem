Imports System.Data.SqlClient
Imports System.Diagnostics
Public Class FrmDashboard

    Public Property LoggedInUser As String = "Admin"
    Private Sub FrmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblWelcome.Text = "Welcome, " & LoggedInUser
        LblProductCount.Text = "0"
        LblCustomerCount.Text = "0"
        LblSalesCount.Text = "ksh 0.00"

        Lblstatus.Text = "Status: Ready"

        LoadProductCount()
        LoadCustomerCount()
        LoadTodaySalesCount()


    End Sub

    Private Sub BtnProducts_Click(sender As Object, e As EventArgs) Handles BtnProducts.Click
        Dim products As New FrmProducts()
        products.ShowDialog()

        LoadProductCount()
    End Sub

    Private Sub BtnCustomers_Click(sender As Object, e As EventArgs) Handles BtnCustomers.Click

        Using customerForm As New FrmCustomer()
            customerForm.ShowDialog()
        End Using

        LoadCustomerCount()

    End Sub

    Private Sub BtnSales_Click(sender As Object, e As EventArgs) Handles BtnSales.Click
        Using salesForm As New FrmSales()
            salesForm.ShowDialog()
        End Using

        LoadTodaySalesCount()

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click

        Using openDialog As New OpenFileDialog()

            openDialog.Title = "Open a File"
            openDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

            If openDialog.ShowDialog() = DialogResult.OK Then

                Process.Start("notepad.exe", openDialog.FileName)

            End If

        End Using

    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click

        MessageBox.Show(
       "GBStation Stationery Supplies System" & vbCrLf &
       "Use the Dashboard menu to manage products, customers and sales.",
       "Edit Information",
       MessageBoxButtons.OK,
       MessageBoxIcon.Information
   )

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        Dim result As DialogResult = MessageBox.Show(
          "Are you sure you want to exit GBStation?",
          "Confirm Exit",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Question
          )

        If result = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub ProductManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductManagementToolStripMenuItem.Click
        FrmProducts.ShowDialog()
    End Sub

    Private Sub CustomerManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerManagementToolStripMenuItem.Click
        FrmCustomer.ShowDialog()
    End Sub

    Private Sub SalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesToolStripMenuItem.Click
        FrmSales.ShowDialog()
    End Sub

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click

        Try
            Using conn As SqlConnection = GetConnection()

                conn.Open()

                Dim query As String =
                    "SELECT COUNT(*) AS TotalSales, " &
                    "ISNULL(SUM(TotalAmount), 0) AS Revenue " &
                    "FROM Sales"

                Using cmd As New SqlCommand(query, conn)

                    Using reader As SqlDataReader = cmd.ExecuteReader()

                        If reader.Read() Then

                            Dim sales As Integer = Convert.ToInt32(reader("TotalSales"))
                            Dim revenue As Decimal = Convert.ToDecimal(reader("Revenue"))

                            MessageBox.Show(
                                "GBSTATION SALES REPORT" & vbCrLf &
                                "------------------------------" & vbCrLf &
                                "Total Sales: " & sales & vbCrLf &
                                "Total Revenue: KSh " & revenue.ToString("N2"),
                                "Sales Report",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            )

                        End If

                    End Using

                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Unable to generate report: " & ex.Message)
        End Try

    End Sub

    Private Sub BtnReports_Click(sender As Object, e As EventArgs) Handles BtnReports.Click

        ReportToolStripMenuItem.PerformClick()
    End Sub

    Private Sub BtnSettings_Click(sender As Object, e As EventArgs) Handles BtnSettings.Click

        Dim choice As String = InputBox(
        "Choose a setting:" & vbCrLf &
        "1. Change Dashboard Background" & vbCrLf &
        "2. Change Dashboard Font",
        "GBStation Settings"
    )

        If choice = "1" Then

            Using colorDialog As New ColorDialog()

                If colorDialog.ShowDialog() = DialogResult.OK Then
                    Me.BackColor = colorDialog.Color
                End If

            End Using

        ElseIf choice = "2" Then

            Using fontDialog As New FontDialog()

                fontDialog.Font = Me.Font

                If fontDialog.ShowDialog() = DialogResult.OK Then
                    Me.Font = fontDialog.Font
                End If

            End Using

        ElseIf choice <> "" Then

            MessageBox.Show("Invalid selection. Choose 1 or 2.")

        End If


    End Sub

    Private Sub SettingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingToolStripMenuItem.Click
        BtnSettings.PerformClick()
    End Sub

    Private Sub AboutGBStationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutGBStationToolStripMenuItem.Click

        MessageBox.Show(
        "GBStation Stationery Supplies System" & vbCrLf &
        "Version 1.0" & vbCrLf &
        "Developed using VB.NET and SQL Server." & vbCrLf &
        "Purpose: Manage products, customers and sales.",
        "About GBStation",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information
    )

    End Sub

    Private Sub UserGuideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserGuideToolStripMenuItem.Click

        MessageBox.Show(
            "GBSTATION USER GUIDE" & vbCrLf & vbCrLf &
            "1. Login using your account." & vbCrLf &
            "2. Use Product Management to add, update and delete products." & vbCrLf &
            "3. Use Customer Management to manage customers." & vbCrLf &
            "4. Use Sales to record customer purchases." & vbCrLf &
            "5. Use Report to view sales summaries." & vbCrLf &
            "6. Use Settings to customize the dashboard." & vbCrLf &
            "7. Use Logout to leave the system.",
            "User Guide",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )

    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles Btnlogout.Click

        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to logout?",
            "Confirm Logout",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result = DialogResult.Yes Then

            FrmLogin.Show()
            Me.Close()

        End If

    End Sub

    Private Sub LoadProductCount()

        Try
            Using conn As SqlConnection = GetConnection()

                conn.Open()

                Dim query As String = "SELECT COUNT(*) FROM Products"

                Using cmd As New SqlCommand(query, conn)

                    Dim productCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    LblProductCount.Text = productCount.ToString()

                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Unable to load product count: " & ex.Message)
        End Try

    End Sub


    Private Sub LoadCustomerCount()
        Try
            Using conn As SqlConnection = GetConnection()
                conn.Open()

                Dim query As String = "SELECT COUNT(*) FROM Customers"

                Using cmd As New SqlCommand(query, conn)
                    Dim customerCount As Integer =
                        Convert.ToInt32(cmd.ExecuteScalar())

                    LblCustomerCount.Text = customerCount.ToString()
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Unable to load customer count: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadTodaySalesCount()
        Try
            Using conn As SqlConnection = GetConnection()
                conn.Open()

                Dim query As String =
                    "SELECT COUNT(*) FROM Sales WHERE CAST(SaleDate AS DATE) = CAST(GETDATE() AS DATE)"

                Using cmd As New SqlCommand(query, conn)
                    Dim saleCount As Integer =
                        Convert.ToInt32(cmd.ExecuteScalar())

                    LblSalesCount.Text = saleCount.ToString()
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Unable to load today's sales count: " & ex.Message)
        End Try
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click

        Dim result As DialogResult =
        MessageBox.Show("Do you want to register a new product?",
                        "New Product",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Using frm As New FrmAddProduct()
                frm.ShowDialog()
            End Using
        End If

    End Sub

End Class