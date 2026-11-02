<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProducts
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PnlHeader = New System.Windows.Forms.Panel()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.grpSearch = New System.Windows.Forms.GroupBox()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.TxtSearchProduct = New System.Windows.Forms.TextBox()
        Me.LblSearch = New System.Windows.Forms.Label()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.colProductID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnAddProduct = New System.Windows.Forms.Button()
        Me.BtnUpdateProduct = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.CmsProducts = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PnlHeader.SuspendLayout()
        Me.grpSearch.SuspendLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CmsProducts.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlHeader
        '
        Me.PnlHeader.BackColor = System.Drawing.Color.ForestGreen
        Me.PnlHeader.Controls.Add(Me.LblTitle)
        Me.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlHeader.ForeColor = System.Drawing.Color.White
        Me.PnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.PnlHeader.Margin = New System.Windows.Forms.Padding(4)
        Me.PnlHeader.Name = "PnlHeader"
        Me.PnlHeader.Size = New System.Drawing.Size(1067, 64)
        Me.PnlHeader.TabIndex = 0
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Location = New System.Drawing.Point(188, 11)
        Me.LblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(432, 37)
        Me.LblTitle.TabIndex = 0
        Me.LblTitle.Text = "PRODUCT MANAGEMENT"
        '
        'grpSearch
        '
        Me.grpSearch.Controls.Add(Me.BtnRefresh)
        Me.grpSearch.Controls.Add(Me.BtnSearch)
        Me.grpSearch.Controls.Add(Me.TxtSearchProduct)
        Me.grpSearch.Controls.Add(Me.LblSearch)
        Me.grpSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearch.Location = New System.Drawing.Point(13, 128)
        Me.grpSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Padding = New System.Windows.Forms.Padding(4)
        Me.grpSearch.Size = New System.Drawing.Size(1051, 88)
        Me.grpSearch.TabIndex = 1
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "Search Products"
        '
        'BtnRefresh
        '
        Me.BtnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnRefresh.ForeColor = System.Drawing.Color.White
        Me.BtnRefresh.Location = New System.Drawing.Point(876, 26)
        Me.BtnRefresh.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(143, 42)
        Me.BtnRefresh.TabIndex = 3
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.UseVisualStyleBackColor = False
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.ForeColor = System.Drawing.Color.White
        Me.BtnSearch.Location = New System.Drawing.Point(687, 26)
        Me.BtnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(143, 42)
        Me.BtnSearch.TabIndex = 2
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'TxtSearchProduct
        '
        Me.TxtSearchProduct.Location = New System.Drawing.Point(198, 38)
        Me.TxtSearchProduct.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSearchProduct.Name = "TxtSearchProduct"
        Me.TxtSearchProduct.Size = New System.Drawing.Size(388, 30)
        Me.TxtSearchProduct.TabIndex = 1
        '
        'LblSearch
        '
        Me.LblSearch.AutoSize = True
        Me.LblSearch.Location = New System.Drawing.Point(8, 41)
        Me.LblSearch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSearch.Name = "LblSearch"
        Me.LblSearch.Size = New System.Drawing.Size(158, 25)
        Me.LblSearch.TabIndex = 0
        Me.LblSearch.Text = "Search Product: "
        '
        'dgvProducts
        '
        Me.dgvProducts.AllowUserToAddRows = False
        Me.dgvProducts.AllowUserToDeleteRows = False
        Me.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProducts.BackgroundColor = System.Drawing.Color.White
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colProductID, Me.colProductName, Me.ColCategory, Me.ColPrice, Me.ColQuantity})
        Me.dgvProducts.Location = New System.Drawing.Point(17, 212)
        Me.dgvProducts.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvProducts.MultiSelect = False
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.ReadOnly = True
        Me.dgvProducts.RowHeadersVisible = False
        Me.dgvProducts.RowHeadersWidth = 62
        Me.dgvProducts.RowTemplate.Height = 28
        Me.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProducts.Size = New System.Drawing.Size(1033, 237)
        Me.dgvProducts.TabIndex = 2
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
        'ColCategory
        '
        Me.ColCategory.HeaderText = "Category"
        Me.ColCategory.MinimumWidth = 8
        Me.ColCategory.Name = "ColCategory"
        Me.ColCategory.ReadOnly = True
        '
        'ColPrice
        '
        Me.ColPrice.HeaderText = "Unit Price(Ksh)"
        Me.ColPrice.MinimumWidth = 8
        Me.ColPrice.Name = "ColPrice"
        Me.ColPrice.ReadOnly = True
        '
        'ColQuantity
        '
        Me.ColQuantity.HeaderText = "Quantity"
        Me.ColQuantity.MinimumWidth = 8
        Me.ColQuantity.Name = "ColQuantity"
        Me.ColQuantity.ReadOnly = True
        '
        'BtnAddProduct
        '
        Me.BtnAddProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnAddProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddProduct.ForeColor = System.Drawing.Color.White
        Me.BtnAddProduct.Location = New System.Drawing.Point(17, 468)
        Me.BtnAddProduct.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAddProduct.Name = "BtnAddProduct"
        Me.BtnAddProduct.Size = New System.Drawing.Size(213, 50)
        Me.BtnAddProduct.TabIndex = 3
        Me.BtnAddProduct.Text = "Add Product"
        Me.BtnAddProduct.UseVisualStyleBackColor = False
        '
        'BtnUpdateProduct
        '
        Me.BtnUpdateProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnUpdateProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateProduct.ForeColor = System.Drawing.Color.White
        Me.BtnUpdateProduct.Location = New System.Drawing.Point(272, 468)
        Me.BtnUpdateProduct.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnUpdateProduct.Name = "BtnUpdateProduct"
        Me.BtnUpdateProduct.Size = New System.Drawing.Size(213, 50)
        Me.BtnUpdateProduct.TabIndex = 4
        Me.BtnUpdateProduct.Text = "Update Product"
        Me.BtnUpdateProduct.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.Red
        Me.BtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.White
        Me.BtnDelete.Location = New System.Drawing.Point(551, 468)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(213, 50)
        Me.BtnDelete.TabIndex = 5
        Me.BtnDelete.Text = "Delete Product"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Gray
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Location = New System.Drawing.Point(804, 468)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(213, 50)
        Me.BtnClose.TabIndex = 6
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'CmsProducts
        '
        Me.CmsProducts.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.CmsProducts.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem})
        Me.CmsProducts.Name = "CmsProducts"
        Me.CmsProducts.Size = New System.Drawing.Size(127, 68)
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(126, 32)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(126, 32)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'FrmProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 562)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdateProduct)
        Me.Controls.Add(Me.BtnAddProduct)
        Me.Controls.Add(Me.dgvProducts)
        Me.Controls.Add(Me.grpSearch)
        Me.Controls.Add(Me.PnlHeader)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmProducts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GBStation Product Management"
        Me.PnlHeader.ResumeLayout(False)
        Me.PnlHeader.PerformLayout()
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CmsProducts.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlHeader As Panel
    Friend WithEvents LblTitle As Label
    Friend WithEvents grpSearch As GroupBox
    Friend WithEvents BtnSearch As Button
    Friend WithEvents TxtSearchProduct As TextBox
    Friend WithEvents LblSearch As Label
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents colProductID As DataGridViewTextBoxColumn
    Friend WithEvents colProductName As DataGridViewTextBoxColumn
    Friend WithEvents ColCategory As DataGridViewTextBoxColumn
    Friend WithEvents ColPrice As DataGridViewTextBoxColumn
    Friend WithEvents ColQuantity As DataGridViewTextBoxColumn
    Friend WithEvents BtnAddProduct As Button
    Friend WithEvents BtnUpdateProduct As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents CmsProducts As ContextMenuStrip
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
End Class
