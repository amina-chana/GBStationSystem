<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VeiwToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutGBStationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserGuideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PnlHeader = New System.Windows.Forms.Panel()
        Me.LblWelcome = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.Pnlsidebar = New System.Windows.Forms.Panel()
        Me.BtnSettings = New System.Windows.Forms.Button()
        Me.Btnlogout = New System.Windows.Forms.Button()
        Me.BtnReports = New System.Windows.Forms.Button()
        Me.BtnSales = New System.Windows.Forms.Button()
        Me.BtnCustomers = New System.Windows.Forms.Button()
        Me.BtnProducts = New System.Windows.Forms.Button()
        Me.BtnDashboard = New System.Windows.Forms.Button()
        Me.LblMenuTitle = New System.Windows.Forms.Label()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.PicBanner = New System.Windows.Forms.PictureBox()
        Me.PnlSalesCard = New System.Windows.Forms.Panel()
        Me.LblSalesCount = New System.Windows.Forms.Label()
        Me.LblSalesHaeding = New System.Windows.Forms.Label()
        Me.PnlCustomerCard = New System.Windows.Forms.Panel()
        Me.LblCustomerCount = New System.Windows.Forms.Label()
        Me.LblCustomerHeading = New System.Windows.Forms.Label()
        Me.PnlProductCard = New System.Windows.Forms.Panel()
        Me.LblProductCount = New System.Windows.Forms.Label()
        Me.LblProductheading = New System.Windows.Forms.Label()
        Me.LblDashboardtitle = New System.Windows.Forms.Label()
        Me.StatusMain = New System.Windows.Forms.StatusStrip()
        Me.Lblstatus = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.PnlHeader.SuspendLayout()
        Me.Pnlsidebar.SuspendLayout()
        Me.PnlMain.SuspendLayout()
        CType(Me.PicBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlSalesCard.SuspendLayout()
        Me.PnlCustomerCard.SuspendLayout()
        Me.PnlProductCard.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.VeiwToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(12, 4, 0, 4)
        Me.MenuStrip1.Size = New System.Drawing.Size(1067, 37)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.EditToolStripMenuItem, Me.ExitToolStripMenuItem, Me.NewToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(158, 34)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'VeiwToolStripMenuItem
        '
        Me.VeiwToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductManagementToolStripMenuItem, Me.CustomerManagementToolStripMenuItem, Me.SalesToolStripMenuItem, Me.ReportToolStripMenuItem, Me.SettingToolStripMenuItem})
        Me.VeiwToolStripMenuItem.Name = "VeiwToolStripMenuItem"
        Me.VeiwToolStripMenuItem.Size = New System.Drawing.Size(64, 29)
        Me.VeiwToolStripMenuItem.Text = "Veiw"
        '
        'ProductManagementToolStripMenuItem
        '
        Me.ProductManagementToolStripMenuItem.Name = "ProductManagementToolStripMenuItem"
        Me.ProductManagementToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ProductManagementToolStripMenuItem.Size = New System.Drawing.Size(347, 34)
        Me.ProductManagementToolStripMenuItem.Text = "Product Management"
        '
        'CustomerManagementToolStripMenuItem
        '
        Me.CustomerManagementToolStripMenuItem.Name = "CustomerManagementToolStripMenuItem"
        Me.CustomerManagementToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.CustomerManagementToolStripMenuItem.Size = New System.Drawing.Size(368, 34)
        Me.CustomerManagementToolStripMenuItem.Text = "Customer Management"
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(368, 34)
        Me.SalesToolStripMenuItem.Text = "Sales"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(368, 34)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(301, 34)
        Me.SettingToolStripMenuItem.Text = "Setting"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutGBStationToolStripMenuItem, Me.UserGuideToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutGBStationToolStripMenuItem
        '
        Me.AboutGBStationToolStripMenuItem.Name = "AboutGBStationToolStripMenuItem"
        Me.AboutGBStationToolStripMenuItem.Size = New System.Drawing.Size(246, 34)
        Me.AboutGBStationToolStripMenuItem.Text = "About GBStation"
        '
        'UserGuideToolStripMenuItem
        '
        Me.UserGuideToolStripMenuItem.Name = "UserGuideToolStripMenuItem"
        Me.UserGuideToolStripMenuItem.Size = New System.Drawing.Size(246, 34)
        Me.UserGuideToolStripMenuItem.Text = "User Guide"
        '
        'PnlHeader
        '
        Me.PnlHeader.BackColor = System.Drawing.Color.White
        Me.PnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlHeader.Controls.Add(Me.LblWelcome)
        Me.PnlHeader.Controls.Add(Me.lbltitle)
        Me.PnlHeader.Location = New System.Drawing.Point(0, 41)
        Me.PnlHeader.Margin = New System.Windows.Forms.Padding(4)
        Me.PnlHeader.Name = "PnlHeader"
        Me.PnlHeader.Size = New System.Drawing.Size(1066, 54)
        Me.PnlHeader.TabIndex = 1
        '
        'LblWelcome
        '
        Me.LblWelcome.BackColor = System.Drawing.Color.ForestGreen
        Me.LblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWelcome.ForeColor = System.Drawing.Color.White
        Me.LblWelcome.Location = New System.Drawing.Point(809, -1)
        Me.LblWelcome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblWelcome.Name = "LblWelcome"
        Me.LblWelcome.Size = New System.Drawing.Size(257, 53)
        Me.LblWelcome.TabIndex = 1
        Me.LblWelcome.Text = "Welcome, Admin"
        Me.LblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltitle
        '
        Me.lbltitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.ForestGreen
        Me.lbltitle.Location = New System.Drawing.Point(32, 11)
        Me.lbltitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(475, 33)
        Me.lbltitle.TabIndex = 0
        Me.lbltitle.Text = "GBStation Stationery Supplies"
        '
        'Pnlsidebar
        '
        Me.Pnlsidebar.BackColor = System.Drawing.Color.White
        Me.Pnlsidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnlsidebar.Controls.Add(Me.BtnSettings)
        Me.Pnlsidebar.Controls.Add(Me.Btnlogout)
        Me.Pnlsidebar.Controls.Add(Me.BtnReports)
        Me.Pnlsidebar.Controls.Add(Me.BtnSales)
        Me.Pnlsidebar.Controls.Add(Me.BtnCustomers)
        Me.Pnlsidebar.Controls.Add(Me.BtnProducts)
        Me.Pnlsidebar.Controls.Add(Me.BtnDashboard)
        Me.Pnlsidebar.Controls.Add(Me.LblMenuTitle)
        Me.Pnlsidebar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Pnlsidebar.Location = New System.Drawing.Point(0, 95)
        Me.Pnlsidebar.Margin = New System.Windows.Forms.Padding(4)
        Me.Pnlsidebar.Name = "Pnlsidebar"
        Me.Pnlsidebar.Size = New System.Drawing.Size(259, 431)
        Me.Pnlsidebar.TabIndex = 2
        '
        'BtnSettings
        '
        Me.BtnSettings.Location = New System.Drawing.Point(12, 314)
        Me.BtnSettings.Name = "BtnSettings"
        Me.BtnSettings.Size = New System.Drawing.Size(227, 45)
        Me.BtnSettings.TabIndex = 8
        Me.BtnSettings.Text = "Settings"
        Me.ToolTip1.SetToolTip(Me.BtnSettings, "Change dashboard appearance")
        Me.BtnSettings.UseVisualStyleBackColor = True
        '
        'Btnlogout
        '
        Me.Btnlogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnlogout.Location = New System.Drawing.Point(9, 366)
        Me.Btnlogout.Margin = New System.Windows.Forms.Padding(4)
        Me.Btnlogout.Name = "Btnlogout"
        Me.Btnlogout.Size = New System.Drawing.Size(227, 45)
        Me.Btnlogout.TabIndex = 7
        Me.Btnlogout.Text = "Logout"
        Me.ToolTip1.SetToolTip(Me.Btnlogout, "Log out of GBStation")
        Me.Btnlogout.UseVisualStyleBackColor = True
        '
        'BtnReports
        '
        Me.BtnReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReports.Location = New System.Drawing.Point(12, 262)
        Me.BtnReports.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnReports.Name = "BtnReports"
        Me.BtnReports.Size = New System.Drawing.Size(227, 45)
        Me.BtnReports.TabIndex = 5
        Me.BtnReports.Text = "Reports"
        Me.ToolTip1.SetToolTip(Me.BtnReports, "View sales and revenue reports")
        Me.BtnReports.UseVisualStyleBackColor = True
        '
        'BtnSales
        '
        Me.BtnSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSales.Location = New System.Drawing.Point(9, 209)
        Me.BtnSales.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSales.Name = "BtnSales"
        Me.BtnSales.Size = New System.Drawing.Size(227, 45)
        Me.BtnSales.TabIndex = 4
        Me.BtnSales.Text = "Sales"
        Me.ToolTip1.SetToolTip(Me.BtnSales, "Record a new customer sale")
        Me.BtnSales.UseVisualStyleBackColor = True
        '
        'BtnCustomers
        '
        Me.BtnCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCustomers.Location = New System.Drawing.Point(12, 156)
        Me.BtnCustomers.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCustomers.Name = "BtnCustomers"
        Me.BtnCustomers.Size = New System.Drawing.Size(227, 45)
        Me.BtnCustomers.TabIndex = 3
        Me.BtnCustomers.Text = "Customers "
        Me.ToolTip1.SetToolTip(Me.BtnCustomers, "View and manage customer records")
        Me.BtnCustomers.UseVisualStyleBackColor = True
        '
        'BtnProducts
        '
        Me.BtnProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProducts.Location = New System.Drawing.Point(12, 103)
        Me.BtnProducts.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnProducts.Name = "BtnProducts"
        Me.BtnProducts.Size = New System.Drawing.Size(227, 45)
        Me.BtnProducts.TabIndex = 2
        Me.BtnProducts.Text = "Products"
        Me.ToolTip1.SetToolTip(Me.BtnProducts, "Manage stationery products and stock" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.BtnProducts.UseVisualStyleBackColor = True
        '
        'BtnDashboard
        '
        Me.BtnDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDashboard.ForeColor = System.Drawing.Color.White
        Me.BtnDashboard.Location = New System.Drawing.Point(12, 56)
        Me.BtnDashboard.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDashboard.Name = "BtnDashboard"
        Me.BtnDashboard.Size = New System.Drawing.Size(227, 45)
        Me.BtnDashboard.TabIndex = 1
        Me.BtnDashboard.Text = "Dashboard"
        Me.BtnDashboard.UseVisualStyleBackColor = False
        '
        'LblMenuTitle
        '
        Me.LblMenuTitle.BackColor = System.Drawing.Color.ForestGreen
        Me.LblMenuTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMenuTitle.ForeColor = System.Drawing.Color.White
        Me.LblMenuTitle.Location = New System.Drawing.Point(4, 0)
        Me.LblMenuTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblMenuTitle.Name = "LblMenuTitle"
        Me.LblMenuTitle.Size = New System.Drawing.Size(254, 52)
        Me.LblMenuTitle.TabIndex = 0
        Me.LblMenuTitle.Text = "Dashboard Menu"
        Me.LblMenuTitle.Visible = False
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.PicBanner)
        Me.PnlMain.Controls.Add(Me.PnlSalesCard)
        Me.PnlMain.Controls.Add(Me.PnlCustomerCard)
        Me.PnlMain.Controls.Add(Me.PnlProductCard)
        Me.PnlMain.Controls.Add(Me.LblDashboardtitle)
        Me.PnlMain.ForeColor = System.Drawing.Color.Black
        Me.PnlMain.Location = New System.Drawing.Point(257, 95)
        Me.PnlMain.Margin = New System.Windows.Forms.Padding(4)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(809, 431)
        Me.PnlMain.TabIndex = 3
        '
        'PicBanner
        '
        Me.PicBanner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PicBanner.Image = Global.GBStationSystem.My.Resources.Resources._5421d86b_6aa3_4bd6_b057_44d603551f5e
        Me.PicBanner.Location = New System.Drawing.Point(4, 227)
        Me.PicBanner.Name = "PicBanner"
        Me.PicBanner.Size = New System.Drawing.Size(800, 203)
        Me.PicBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicBanner.TabIndex = 4
        Me.PicBanner.TabStop = False
        '
        'PnlSalesCard
        '
        Me.PnlSalesCard.BackColor = System.Drawing.Color.Azure
        Me.PnlSalesCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlSalesCard.Controls.Add(Me.LblSalesCount)
        Me.PnlSalesCard.Controls.Add(Me.LblSalesHaeding)
        Me.PnlSalesCard.Location = New System.Drawing.Point(545, 88)
        Me.PnlSalesCard.Margin = New System.Windows.Forms.Padding(4)
        Me.PnlSalesCard.Name = "PnlSalesCard"
        Me.PnlSalesCard.Size = New System.Drawing.Size(220, 119)
        Me.PnlSalesCard.TabIndex = 3
        '
        'LblSalesCount
        '
        Me.LblSalesCount.AutoSize = True
        Me.LblSalesCount.Location = New System.Drawing.Point(60, 69)
        Me.LblSalesCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSalesCount.Name = "LblSalesCount"
        Me.LblSalesCount.Size = New System.Drawing.Size(90, 25)
        Me.LblSalesCount.TabIndex = 1
        Me.LblSalesCount.Text = "Ksh 0.00"
        '
        'LblSalesHaeding
        '
        Me.LblSalesHaeding.AutoSize = True
        Me.LblSalesHaeding.Location = New System.Drawing.Point(38, 23)
        Me.LblSalesHaeding.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSalesHaeding.Name = "LblSalesHaeding"
        Me.LblSalesHaeding.Size = New System.Drawing.Size(137, 25)
        Me.LblSalesHaeding.TabIndex = 0
        Me.LblSalesHaeding.Text = "Today's Sales"
        '
        'PnlCustomerCard
        '
        Me.PnlCustomerCard.BackColor = System.Drawing.Color.GhostWhite
        Me.PnlCustomerCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlCustomerCard.Controls.Add(Me.LblCustomerCount)
        Me.PnlCustomerCard.Controls.Add(Me.LblCustomerHeading)
        Me.PnlCustomerCard.Location = New System.Drawing.Point(292, 88)
        Me.PnlCustomerCard.Margin = New System.Windows.Forms.Padding(4)
        Me.PnlCustomerCard.Name = "PnlCustomerCard"
        Me.PnlCustomerCard.Size = New System.Drawing.Size(220, 119)
        Me.PnlCustomerCard.TabIndex = 2
        '
        'LblCustomerCount
        '
        Me.LblCustomerCount.AutoSize = True
        Me.LblCustomerCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCustomerCount.Location = New System.Drawing.Point(69, 67)
        Me.LblCustomerCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCustomerCount.Name = "LblCustomerCount"
        Me.LblCustomerCount.Size = New System.Drawing.Size(23, 25)
        Me.LblCustomerCount.TabIndex = 1
        Me.LblCustomerCount.Text = "0"
        '
        'LblCustomerHeading
        '
        Me.LblCustomerHeading.AutoSize = True
        Me.LblCustomerHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCustomerHeading.ForeColor = System.Drawing.Color.Black
        Me.LblCustomerHeading.Location = New System.Drawing.Point(37, 24)
        Me.LblCustomerHeading.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCustomerHeading.Name = "LblCustomerHeading"
        Me.LblCustomerHeading.Size = New System.Drawing.Size(156, 25)
        Me.LblCustomerHeading.TabIndex = 0
        Me.LblCustomerHeading.Text = "Total Customers"
        '
        'PnlProductCard
        '
        Me.PnlProductCard.BackColor = System.Drawing.Color.Honeydew
        Me.PnlProductCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlProductCard.Controls.Add(Me.LblProductCount)
        Me.PnlProductCard.Controls.Add(Me.LblProductheading)
        Me.PnlProductCard.Location = New System.Drawing.Point(40, 88)
        Me.PnlProductCard.Margin = New System.Windows.Forms.Padding(4)
        Me.PnlProductCard.Name = "PnlProductCard"
        Me.PnlProductCard.Size = New System.Drawing.Size(220, 119)
        Me.PnlProductCard.TabIndex = 1
        '
        'LblProductCount
        '
        Me.LblProductCount.AutoSize = True
        Me.LblProductCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProductCount.ForeColor = System.Drawing.Color.Black
        Me.LblProductCount.Location = New System.Drawing.Point(76, 67)
        Me.LblProductCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblProductCount.Name = "LblProductCount"
        Me.LblProductCount.Size = New System.Drawing.Size(24, 26)
        Me.LblProductCount.TabIndex = 1
        Me.LblProductCount.Text = "0"
        '
        'LblProductheading
        '
        Me.LblProductheading.AutoSize = True
        Me.LblProductheading.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProductheading.ForeColor = System.Drawing.Color.Black
        Me.LblProductheading.Location = New System.Drawing.Point(33, 23)
        Me.LblProductheading.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblProductheading.Name = "LblProductheading"
        Me.LblProductheading.Size = New System.Drawing.Size(151, 26)
        Me.LblProductheading.TabIndex = 0
        Me.LblProductheading.Text = "Total Products"
        '
        'LblDashboardtitle
        '
        Me.LblDashboardtitle.BackColor = System.Drawing.Color.ForestGreen
        Me.LblDashboardtitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblDashboardtitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDashboardtitle.ForeColor = System.Drawing.Color.White
        Me.LblDashboardtitle.Location = New System.Drawing.Point(0, 0)
        Me.LblDashboardtitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDashboardtitle.Name = "LblDashboardtitle"
        Me.LblDashboardtitle.Size = New System.Drawing.Size(807, 52)
        Me.LblDashboardtitle.TabIndex = 0
        Me.LblDashboardtitle.Text = "GBSTATION DASHBOARD"
        Me.LblDashboardtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatusMain
        '
        Me.StatusMain.AutoSize = False
        Me.StatusMain.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusMain.Location = New System.Drawing.Point(0, 519)
        Me.StatusMain.Name = "StatusMain"
        Me.StatusMain.Size = New System.Drawing.Size(1067, 43)
        Me.StatusMain.TabIndex = 4
        Me.StatusMain.Text = "Status: Ready"
        '
        'Lblstatus
        '
        Me.Lblstatus.AutoSize = True
        Me.Lblstatus.Location = New System.Drawing.Point(23, 530)
        Me.Lblstatus.Name = "Lblstatus"
        Me.Lblstatus.Size = New System.Drawing.Size(135, 25)
        Me.Lblstatus.TabIndex = 5
        Me.Lblstatus.Text = "Status: Ready"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'FrmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 562)
        Me.Controls.Add(Me.Lblstatus)
        Me.Controls.Add(Me.StatusMain)
        Me.Controls.Add(Me.PnlMain)
        Me.Controls.Add(Me.Pnlsidebar)
        Me.Controls.Add(Me.PnlHeader)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GBStation Dashboard"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PnlHeader.ResumeLayout(False)
        Me.Pnlsidebar.ResumeLayout(False)
        Me.PnlMain.ResumeLayout(False)
        CType(Me.PicBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlSalesCard.ResumeLayout(False)
        Me.PnlSalesCard.PerformLayout()
        Me.PnlCustomerCard.ResumeLayout(False)
        Me.PnlCustomerCard.PerformLayout()
        Me.PnlProductCard.ResumeLayout(False)
        Me.PnlProductCard.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VeiwToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutGBStationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserGuideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PnlHeader As Panel
    Friend WithEvents lbltitle As Label
    Friend WithEvents LblWelcome As Label
    Friend WithEvents Pnlsidebar As Panel
    Friend WithEvents LblMenuTitle As Label
    Friend WithEvents BtnReports As Button
    Friend WithEvents BtnSales As Button
    Friend WithEvents BtnCustomers As Button
    Friend WithEvents BtnProducts As Button
    Friend WithEvents BtnDashboard As Button
    Friend WithEvents Btnlogout As Button
    Friend WithEvents PnlMain As Panel
    Friend WithEvents LblDashboardtitle As Label
    Friend WithEvents PnlSalesCard As Panel
    Friend WithEvents LblSalesCount As Label
    Friend WithEvents LblSalesHaeding As Label
    Friend WithEvents PnlCustomerCard As Panel
    Friend WithEvents LblCustomerCount As Label
    Friend WithEvents LblCustomerHeading As Label
    Friend WithEvents PnlProductCard As Panel
    Friend WithEvents LblProductCount As Label
    Friend WithEvents LblProductheading As Label
    Friend WithEvents PicBanner As PictureBox
    Friend WithEvents StatusMain As StatusStrip
    Friend WithEvents Lblstatus As Label
    Friend WithEvents BtnSettings As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
End Class
