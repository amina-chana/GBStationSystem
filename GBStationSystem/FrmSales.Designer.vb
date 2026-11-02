<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSales
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblHeading = New System.Windows.Forms.Label()
        Me.grpSaleDetail = New System.Windows.Forms.GroupBox()
        Me.cmbPaymentMethod = New System.Windows.Forms.ComboBox()
        Me.cmbCustomer = New System.Windows.Forms.ComboBox()
        Me.dtpSaleDate = New System.Windows.Forms.DateTimePicker()
        Me.TxtSaleID = New System.Windows.Forms.TextBox()
        Me.LblPaymentMethod = New System.Windows.Forms.Label()
        Me.LblCustomer = New System.Windows.Forms.Label()
        Me.LblSaleDate = New System.Windows.Forms.Label()
        Me.LblSaleID = New System.Windows.Forms.Label()
        Me.grpAddProduct = New System.Windows.Forms.GroupBox()
        Me.BtnAddToSales = New System.Windows.Forms.Button()
        Me.TxtStockAvailable = New System.Windows.Forms.TextBox()
        Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.TxtUnitPrice = New System.Windows.Forms.TextBox()
        Me.CmbProduct = New System.Windows.Forms.ComboBox()
        Me.LblStockAvailable = New System.Windows.Forms.Label()
        Me.LblQuantity = New System.Windows.Forms.Label()
        Me.LblUnitPrice = New System.Windows.Forms.Label()
        Me.LblProduct = New System.Windows.Forms.Label()
        Me.dgvSaleItems = New System.Windows.Forms.DataGridView()
        Me.colItemNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colProductID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpSalesSummary = New System.Windows.Forms.GroupBox()
        Me.TxtTotalSales = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnRemoveItem = New System.Windows.Forms.Button()
        Me.BtnClearSale = New System.Windows.Forms.Button()
        Me.BtnCompleteSale = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LblSalesStatus = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.grpSaleDetail.SuspendLayout()
        Me.grpAddProduct.SuspendLayout()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSaleItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSalesSummary.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.ForestGreen
        Me.Panel1.Controls.Add(Me.LblHeading)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(-1, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1069, 54)
        Me.Panel1.TabIndex = 0
        '
        'LblHeading
        '
        Me.LblHeading.AutoSize = True
        Me.LblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeading.Location = New System.Drawing.Point(95, 10)
        Me.LblHeading.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblHeading.Name = "LblHeading"
        Me.LblHeading.Size = New System.Drawing.Size(541, 37)
        Me.LblHeading.TabIndex = 0
        Me.LblHeading.Text = "GBStation SALES MANAGEMENT"
        '
        'grpSaleDetail
        '
        Me.grpSaleDetail.Controls.Add(Me.cmbPaymentMethod)
        Me.grpSaleDetail.Controls.Add(Me.cmbCustomer)
        Me.grpSaleDetail.Controls.Add(Me.dtpSaleDate)
        Me.grpSaleDetail.Controls.Add(Me.TxtSaleID)
        Me.grpSaleDetail.Controls.Add(Me.LblPaymentMethod)
        Me.grpSaleDetail.Controls.Add(Me.LblCustomer)
        Me.grpSaleDetail.Controls.Add(Me.LblSaleDate)
        Me.grpSaleDetail.Controls.Add(Me.LblSaleID)
        Me.grpSaleDetail.Location = New System.Drawing.Point(13, 63)
        Me.grpSaleDetail.Margin = New System.Windows.Forms.Padding(4)
        Me.grpSaleDetail.Name = "grpSaleDetail"
        Me.grpSaleDetail.Padding = New System.Windows.Forms.Padding(4)
        Me.grpSaleDetail.Size = New System.Drawing.Size(445, 200)
        Me.grpSaleDetail.TabIndex = 1
        Me.grpSaleDetail.TabStop = False
        Me.grpSaleDetail.Text = "Sales Details"
        '
        'cmbPaymentMethod
        '
        Me.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPaymentMethod.FormattingEnabled = True
        Me.cmbPaymentMethod.Location = New System.Drawing.Point(192, 151)
        Me.cmbPaymentMethod.Name = "cmbPaymentMethod"
        Me.cmbPaymentMethod.Size = New System.Drawing.Size(221, 33)
        Me.cmbPaymentMethod.TabIndex = 7
        '
        'cmbCustomer
        '
        Me.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCustomer.FormattingEnabled = True
        Me.cmbCustomer.Location = New System.Drawing.Point(192, 111)
        Me.cmbCustomer.Name = "cmbCustomer"
        Me.cmbCustomer.Size = New System.Drawing.Size(221, 33)
        Me.cmbCustomer.TabIndex = 6
        '
        'dtpSaleDate
        '
        Me.dtpSaleDate.Location = New System.Drawing.Point(192, 75)
        Me.dtpSaleDate.Name = "dtpSaleDate"
        Me.dtpSaleDate.Size = New System.Drawing.Size(221, 30)
        Me.dtpSaleDate.TabIndex = 5
        '
        'TxtSaleID
        '
        Me.TxtSaleID.BackColor = System.Drawing.Color.White
        Me.TxtSaleID.Location = New System.Drawing.Point(192, 38)
        Me.TxtSaleID.Name = "TxtSaleID"
        Me.TxtSaleID.ReadOnly = True
        Me.TxtSaleID.Size = New System.Drawing.Size(221, 30)
        Me.TxtSaleID.TabIndex = 4
        '
        'LblPaymentMethod
        '
        Me.LblPaymentMethod.AutoSize = True
        Me.LblPaymentMethod.Location = New System.Drawing.Point(16, 154)
        Me.LblPaymentMethod.Name = "LblPaymentMethod"
        Me.LblPaymentMethod.Size = New System.Drawing.Size(160, 25)
        Me.LblPaymentMethod.TabIndex = 3
        Me.LblPaymentMethod.Text = "Payment Method"
        '
        'LblCustomer
        '
        Me.LblCustomer.AutoSize = True
        Me.LblCustomer.Location = New System.Drawing.Point(16, 114)
        Me.LblCustomer.Name = "LblCustomer"
        Me.LblCustomer.Size = New System.Drawing.Size(97, 25)
        Me.LblCustomer.TabIndex = 2
        Me.LblCustomer.Text = "Customer"
        '
        'LblSaleDate
        '
        Me.LblSaleDate.AutoSize = True
        Me.LblSaleDate.Location = New System.Drawing.Point(16, 80)
        Me.LblSaleDate.Name = "LblSaleDate"
        Me.LblSaleDate.Size = New System.Drawing.Size(98, 25)
        Me.LblSaleDate.TabIndex = 1
        Me.LblSaleDate.Text = "Sale Date"
        '
        'LblSaleID
        '
        Me.LblSaleID.AutoSize = True
        Me.LblSaleID.Location = New System.Drawing.Point(16, 41)
        Me.LblSaleID.Name = "LblSaleID"
        Me.LblSaleID.Size = New System.Drawing.Size(76, 25)
        Me.LblSaleID.TabIndex = 0
        Me.LblSaleID.Text = "Sale ID"
        '
        'grpAddProduct
        '
        Me.grpAddProduct.Controls.Add(Me.BtnAddToSales)
        Me.grpAddProduct.Controls.Add(Me.TxtStockAvailable)
        Me.grpAddProduct.Controls.Add(Me.nudQuantity)
        Me.grpAddProduct.Controls.Add(Me.TxtUnitPrice)
        Me.grpAddProduct.Controls.Add(Me.CmbProduct)
        Me.grpAddProduct.Controls.Add(Me.LblStockAvailable)
        Me.grpAddProduct.Controls.Add(Me.LblQuantity)
        Me.grpAddProduct.Controls.Add(Me.LblUnitPrice)
        Me.grpAddProduct.Controls.Add(Me.LblProduct)
        Me.grpAddProduct.Location = New System.Drawing.Point(480, 63)
        Me.grpAddProduct.Name = "grpAddProduct"
        Me.grpAddProduct.Size = New System.Drawing.Size(556, 200)
        Me.grpAddProduct.TabIndex = 2
        Me.grpAddProduct.TabStop = False
        Me.grpAddProduct.Text = "Add Product"
        '
        'BtnAddToSales
        '
        Me.BtnAddToSales.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnAddToSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddToSales.ForeColor = System.Drawing.Color.White
        Me.BtnAddToSales.Location = New System.Drawing.Point(417, 101)
        Me.BtnAddToSales.Name = "BtnAddToSales"
        Me.BtnAddToSales.Size = New System.Drawing.Size(116, 78)
        Me.BtnAddToSales.TabIndex = 8
        Me.BtnAddToSales.Text = "Add To Sales"
        Me.BtnAddToSales.UseVisualStyleBackColor = False
        '
        'TxtStockAvailable
        '
        Me.TxtStockAvailable.BackColor = System.Drawing.Color.White
        Me.TxtStockAvailable.Location = New System.Drawing.Point(207, 154)
        Me.TxtStockAvailable.Name = "TxtStockAvailable"
        Me.TxtStockAvailable.ReadOnly = True
        Me.TxtStockAvailable.Size = New System.Drawing.Size(155, 30)
        Me.TxtStockAvailable.TabIndex = 7
        '
        'nudQuantity
        '
        Me.nudQuantity.Location = New System.Drawing.Point(207, 117)
        Me.nudQuantity.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudQuantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(155, 30)
        Me.nudQuantity.TabIndex = 6
        Me.nudQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'TxtUnitPrice
        '
        Me.TxtUnitPrice.BackColor = System.Drawing.Color.White
        Me.TxtUnitPrice.Location = New System.Drawing.Point(207, 77)
        Me.TxtUnitPrice.Name = "TxtUnitPrice"
        Me.TxtUnitPrice.ReadOnly = True
        Me.TxtUnitPrice.Size = New System.Drawing.Size(155, 30)
        Me.TxtUnitPrice.TabIndex = 5
        '
        'CmbProduct
        '
        Me.CmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbProduct.FormattingEnabled = True
        Me.CmbProduct.Location = New System.Drawing.Point(207, 36)
        Me.CmbProduct.Name = "CmbProduct"
        Me.CmbProduct.Size = New System.Drawing.Size(229, 33)
        Me.CmbProduct.TabIndex = 4
        '
        'LblStockAvailable
        '
        Me.LblStockAvailable.AutoSize = True
        Me.LblStockAvailable.Location = New System.Drawing.Point(21, 157)
        Me.LblStockAvailable.Name = "LblStockAvailable"
        Me.LblStockAvailable.Size = New System.Drawing.Size(147, 25)
        Me.LblStockAvailable.TabIndex = 3
        Me.LblStockAvailable.Text = "Stock Available"
        '
        'LblQuantity
        '
        Me.LblQuantity.AutoSize = True
        Me.LblQuantity.Location = New System.Drawing.Point(21, 114)
        Me.LblQuantity.Name = "LblQuantity"
        Me.LblQuantity.Size = New System.Drawing.Size(85, 25)
        Me.LblQuantity.TabIndex = 2
        Me.LblQuantity.Text = "Quantity"
        '
        'LblUnitPrice
        '
        Me.LblUnitPrice.AutoSize = True
        Me.LblUnitPrice.Location = New System.Drawing.Point(21, 80)
        Me.LblUnitPrice.Name = "LblUnitPrice"
        Me.LblUnitPrice.Size = New System.Drawing.Size(95, 25)
        Me.LblUnitPrice.TabIndex = 1
        Me.LblUnitPrice.Text = "Unit Price"
        '
        'LblProduct
        '
        Me.LblProduct.AutoSize = True
        Me.LblProduct.Location = New System.Drawing.Point(21, 41)
        Me.LblProduct.Name = "LblProduct"
        Me.LblProduct.Size = New System.Drawing.Size(139, 25)
        Me.LblProduct.TabIndex = 0
        Me.LblProduct.Text = "Select Product"
        '
        'dgvSaleItems
        '
        Me.dgvSaleItems.AllowUserToAddRows = False
        Me.dgvSaleItems.AllowUserToDeleteRows = False
        Me.dgvSaleItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSaleItems.BackgroundColor = System.Drawing.Color.White
        Me.dgvSaleItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSaleItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colItemNo, Me.colProductID, Me.colProductName, Me.colQuantity, Me.colUnitPrice, Me.colTotal})
        Me.dgvSaleItems.Location = New System.Drawing.Point(12, 269)
        Me.dgvSaleItems.MultiSelect = False
        Me.dgvSaleItems.Name = "dgvSaleItems"
        Me.dgvSaleItems.ReadOnly = True
        Me.dgvSaleItems.RowHeadersVisible = False
        Me.dgvSaleItems.RowHeadersWidth = 62
        Me.dgvSaleItems.RowTemplate.Height = 28
        Me.dgvSaleItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSaleItems.Size = New System.Drawing.Size(1032, 162)
        Me.dgvSaleItems.TabIndex = 3
        '
        'colItemNo
        '
        Me.colItemNo.HeaderText = "Item No."
        Me.colItemNo.MinimumWidth = 8
        Me.colItemNo.Name = "colItemNo"
        Me.colItemNo.ReadOnly = True
        '
        'colProductID
        '
        Me.colProductID.HeaderText = "Product ID"
        Me.colProductID.MinimumWidth = 8
        Me.colProductID.Name = "colProductID"
        Me.colProductID.ReadOnly = True
        '
        'colProductName
        '
        Me.colProductName.HeaderText = "Product Name"
        Me.colProductName.MinimumWidth = 8
        Me.colProductName.Name = "colProductName"
        Me.colProductName.ReadOnly = True
        '
        'colQuantity
        '
        Me.colQuantity.HeaderText = "Quantity"
        Me.colQuantity.MinimumWidth = 8
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.ReadOnly = True
        '
        'colUnitPrice
        '
        Me.colUnitPrice.HeaderText = "Unit Price(Ksh)"
        Me.colUnitPrice.MinimumWidth = 8
        Me.colUnitPrice.Name = "colUnitPrice"
        Me.colUnitPrice.ReadOnly = True
        '
        'colTotal
        '
        Me.colTotal.HeaderText = "Total(Ksh)"
        Me.colTotal.MinimumWidth = 8
        Me.colTotal.Name = "colTotal"
        Me.colTotal.ReadOnly = True
        '
        'grpSalesSummary
        '
        Me.grpSalesSummary.Controls.Add(Me.TxtTotalSales)
        Me.grpSalesSummary.Controls.Add(Me.Label1)
        Me.grpSalesSummary.Location = New System.Drawing.Point(13, 446)
        Me.grpSalesSummary.Name = "grpSalesSummary"
        Me.grpSalesSummary.Size = New System.Drawing.Size(349, 83)
        Me.grpSalesSummary.TabIndex = 4
        Me.grpSalesSummary.TabStop = False
        Me.grpSalesSummary.Text = "Sales Summary"
        '
        'TxtTotalSales
        '
        Me.TxtTotalSales.BackColor = System.Drawing.Color.Honeydew
        Me.TxtTotalSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalSales.ForeColor = System.Drawing.Color.Green
        Me.TxtTotalSales.Location = New System.Drawing.Point(192, 37)
        Me.TxtTotalSales.Name = "TxtTotalSales"
        Me.TxtTotalSales.Size = New System.Drawing.Size(140, 30)
        Me.TxtTotalSales.TabIndex = 1
        Me.TxtTotalSales.Text = "KSH O.OO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TOTAL SALES:"
        '
        'BtnRemoveItem
        '
        Me.BtnRemoveItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRemoveItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemoveItem.ForeColor = System.Drawing.Color.White
        Me.BtnRemoveItem.Location = New System.Drawing.Point(411, 466)
        Me.BtnRemoveItem.Name = "BtnRemoveItem"
        Me.BtnRemoveItem.Size = New System.Drawing.Size(130, 60)
        Me.BtnRemoveItem.TabIndex = 5
        Me.BtnRemoveItem.Text = "Remove Item"
        Me.BtnRemoveItem.UseVisualStyleBackColor = False
        '
        'BtnClearSale
        '
        Me.BtnClearSale.BackColor = System.Drawing.Color.Silver
        Me.BtnClearSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClearSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClearSale.ForeColor = System.Drawing.Color.White
        Me.BtnClearSale.Location = New System.Drawing.Point(573, 466)
        Me.BtnClearSale.Name = "BtnClearSale"
        Me.BtnClearSale.Size = New System.Drawing.Size(130, 60)
        Me.BtnClearSale.TabIndex = 6
        Me.BtnClearSale.Text = "Clear Sale"
        Me.BtnClearSale.UseVisualStyleBackColor = False
        '
        'BtnCompleteSale
        '
        Me.BtnCompleteSale.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCompleteSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCompleteSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCompleteSale.ForeColor = System.Drawing.Color.White
        Me.BtnCompleteSale.Location = New System.Drawing.Point(751, 468)
        Me.BtnCompleteSale.Name = "BtnCompleteSale"
        Me.BtnCompleteSale.Size = New System.Drawing.Size(130, 60)
        Me.BtnCompleteSale.TabIndex = 7
        Me.BtnCompleteSale.Text = "Complete Sale"
        Me.BtnCompleteSale.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Gray
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Location = New System.Drawing.Point(914, 466)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(130, 60)
        Me.BtnClose.TabIndex = 8
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 568)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1067, 22)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LblSalesStatus
        '
        Me.LblSalesStatus.AutoSize = True
        Me.LblSalesStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblSalesStatus.Location = New System.Drawing.Point(34, 540)
        Me.LblSalesStatus.Name = "LblSalesStatus"
        Me.LblSalesStatus.Size = New System.Drawing.Size(68, 25)
        Me.LblSalesStatus.TabIndex = 10
        Me.LblSalesStatus.Text = "Ready"
        '
        'FrmSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 590)
        Me.Controls.Add(Me.LblSalesStatus)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnCompleteSale)
        Me.Controls.Add(Me.BtnClearSale)
        Me.Controls.Add(Me.BtnRemoveItem)
        Me.Controls.Add(Me.grpSalesSummary)
        Me.Controls.Add(Me.dgvSaleItems)
        Me.Controls.Add(Me.grpAddProduct)
        Me.Controls.Add(Me.grpSaleDetail)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FrmSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Management"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grpSaleDetail.ResumeLayout(False)
        Me.grpSaleDetail.PerformLayout()
        Me.grpAddProduct.ResumeLayout(False)
        Me.grpAddProduct.PerformLayout()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSaleItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSalesSummary.ResumeLayout(False)
        Me.grpSalesSummary.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblHeading As Label
    Friend WithEvents grpSaleDetail As GroupBox
    Friend WithEvents LblPaymentMethod As Label
    Friend WithEvents LblCustomer As Label
    Friend WithEvents LblSaleDate As Label
    Friend WithEvents LblSaleID As Label
    Friend WithEvents cmbPaymentMethod As ComboBox
    Friend WithEvents cmbCustomer As ComboBox
    Friend WithEvents dtpSaleDate As DateTimePicker
    Friend WithEvents TxtSaleID As TextBox
    Friend WithEvents grpAddProduct As GroupBox
    Friend WithEvents LblStockAvailable As Label
    Friend WithEvents LblQuantity As Label
    Friend WithEvents LblUnitPrice As Label
    Friend WithEvents LblProduct As Label
    Friend WithEvents TxtStockAvailable As TextBox
    Friend WithEvents nudQuantity As NumericUpDown
    Friend WithEvents TxtUnitPrice As TextBox
    Friend WithEvents CmbProduct As ComboBox
    Friend WithEvents BtnAddToSales As Button
    Friend WithEvents dgvSaleItems As DataGridView
    Friend WithEvents colItemNo As DataGridViewTextBoxColumn
    Friend WithEvents colProductID As DataGridViewTextBoxColumn
    Friend WithEvents colProductName As DataGridViewTextBoxColumn
    Friend WithEvents colQuantity As DataGridViewTextBoxColumn
    Friend WithEvents colUnitPrice As DataGridViewTextBoxColumn
    Friend WithEvents colTotal As DataGridViewTextBoxColumn
    Friend WithEvents grpSalesSummary As GroupBox
    Friend WithEvents TxtTotalSales As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnRemoveItem As Button
    Friend WithEvents BtnClearSale As Button
    Friend WithEvents BtnCompleteSale As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents LblSalesStatus As Label
End Class
