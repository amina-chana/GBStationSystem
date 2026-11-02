<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCustomer
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
        Me.PnlHeader = New System.Windows.Forms.Panel()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.grpSearchCustomer = New System.Windows.Forms.GroupBox()
        Me.TxtSearchCustomer = New System.Windows.Forms.TextBox()
        Me.lblSearchCustomer = New System.Windows.Forms.Label()
        Me.BtnSearchCustomer = New System.Windows.Forms.Button()
        Me.BtnRefreshCustomer = New System.Windows.Forms.Button()
        Me.dgvCustomers = New System.Windows.Forms.DataGridView()
        Me.colCustomerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCustomerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnAddCustomer = New System.Windows.Forms.Button()
        Me.BtnUpdateCustomer = New System.Windows.Forms.Button()
        Me.BtnDeleteCustomer = New System.Windows.Forms.Button()
        Me.BtnCloseCustomer = New System.Windows.Forms.Button()
        Me.PnlHeader.SuspendLayout()
        Me.grpSearchCustomer.SuspendLayout()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlHeader
        '
        Me.PnlHeader.BackColor = System.Drawing.Color.ForestGreen
        Me.PnlHeader.Controls.Add(Me.LblTitle)
        Me.PnlHeader.ForeColor = System.Drawing.Color.White
        Me.PnlHeader.Location = New System.Drawing.Point(3, 1)
        Me.PnlHeader.Margin = New System.Windows.Forms.Padding(4)
        Me.PnlHeader.Name = "PnlHeader"
        Me.PnlHeader.Size = New System.Drawing.Size(1065, 67)
        Me.PnlHeader.TabIndex = 0
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(86, 18)
        Me.LblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(628, 37)
        Me.LblTitle.TabIndex = 0
        Me.LblTitle.Text = "GBStations - CUSTOMER MANAGEMENT"
        '
        'grpSearchCustomer
        '
        Me.grpSearchCustomer.Controls.Add(Me.TxtSearchCustomer)
        Me.grpSearchCustomer.Controls.Add(Me.lblSearchCustomer)
        Me.grpSearchCustomer.Controls.Add(Me.BtnSearchCustomer)
        Me.grpSearchCustomer.Controls.Add(Me.BtnRefreshCustomer)
        Me.grpSearchCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearchCustomer.Location = New System.Drawing.Point(3, 76)
        Me.grpSearchCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.grpSearchCustomer.Name = "grpSearchCustomer"
        Me.grpSearchCustomer.Padding = New System.Windows.Forms.Padding(4)
        Me.grpSearchCustomer.Size = New System.Drawing.Size(1075, 80)
        Me.grpSearchCustomer.TabIndex = 1
        Me.grpSearchCustomer.TabStop = False
        Me.grpSearchCustomer.Text = "Search Customers"
        '
        'TxtSearchCustomer
        '
        Me.TxtSearchCustomer.Location = New System.Drawing.Point(200, 38)
        Me.TxtSearchCustomer.Name = "TxtSearchCustomer"
        Me.TxtSearchCustomer.Size = New System.Drawing.Size(375, 30)
        Me.TxtSearchCustomer.TabIndex = 3
        '
        'lblSearchCustomer
        '
        Me.lblSearchCustomer.AutoSize = True
        Me.lblSearchCustomer.Location = New System.Drawing.Point(8, 38)
        Me.lblSearchCustomer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSearchCustomer.Name = "lblSearchCustomer"
        Me.lblSearchCustomer.Size = New System.Drawing.Size(171, 25)
        Me.lblSearchCustomer.TabIndex = 2
        Me.lblSearchCustomer.Text = "Search Customer:"
        '
        'BtnSearchCustomer
        '
        Me.BtnSearchCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearchCustomer.ForeColor = System.Drawing.Color.White
        Me.BtnSearchCustomer.Location = New System.Drawing.Point(652, 27)
        Me.BtnSearchCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSearchCustomer.Name = "BtnSearchCustomer"
        Me.BtnSearchCustomer.Size = New System.Drawing.Size(160, 40)
        Me.BtnSearchCustomer.TabIndex = 1
        Me.BtnSearchCustomer.Text = "Search"
        Me.BtnSearchCustomer.UseVisualStyleBackColor = False
        '
        'BtnRefreshCustomer
        '
        Me.BtnRefreshCustomer.BackColor = System.Drawing.Color.Blue
        Me.BtnRefreshCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefreshCustomer.ForeColor = System.Drawing.Color.White
        Me.BtnRefreshCustomer.Location = New System.Drawing.Point(854, 27)
        Me.BtnRefreshCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnRefreshCustomer.Name = "BtnRefreshCustomer"
        Me.BtnRefreshCustomer.Size = New System.Drawing.Size(160, 40)
        Me.BtnRefreshCustomer.TabIndex = 0
        Me.BtnRefreshCustomer.Text = "Refresh"
        Me.BtnRefreshCustomer.UseVisualStyleBackColor = False
        '
        'dgvCustomers
        '
        Me.dgvCustomers.AllowUserToAddRows = False
        Me.dgvCustomers.AllowUserToDeleteRows = False
        Me.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCustomers.BackgroundColor = System.Drawing.Color.White
        Me.dgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCustomerID, Me.ColCustomerName, Me.ColPhone, Me.ColEmail, Me.ColAddress})
        Me.dgvCustomers.Location = New System.Drawing.Point(3, 164)
        Me.dgvCustomers.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvCustomers.MultiSelect = False
        Me.dgvCustomers.Name = "dgvCustomers"
        Me.dgvCustomers.ReadOnly = True
        Me.dgvCustomers.RowHeadersVisible = False
        Me.dgvCustomers.RowHeadersWidth = 62
        Me.dgvCustomers.RowTemplate.Height = 28
        Me.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCustomers.Size = New System.Drawing.Size(1065, 263)
        Me.dgvCustomers.TabIndex = 2
        '
        'colCustomerID
        '
        Me.colCustomerID.HeaderText = "Customer ID"
        Me.colCustomerID.MinimumWidth = 8
        Me.colCustomerID.Name = "colCustomerID"
        Me.colCustomerID.ReadOnly = True
        Me.colCustomerID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColCustomerName
        '
        Me.ColCustomerName.HeaderText = "CustomerName"
        Me.ColCustomerName.MinimumWidth = 8
        Me.ColCustomerName.Name = "ColCustomerName"
        Me.ColCustomerName.ReadOnly = True
        Me.ColCustomerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColPhone
        '
        Me.ColPhone.HeaderText = "Phone Number"
        Me.ColPhone.MinimumWidth = 8
        Me.ColPhone.Name = "ColPhone"
        Me.ColPhone.ReadOnly = True
        Me.ColPhone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColEmail
        '
        Me.ColEmail.HeaderText = "EmailAddress"
        Me.ColEmail.MinimumWidth = 8
        Me.ColEmail.Name = "ColEmail"
        Me.ColEmail.ReadOnly = True
        Me.ColEmail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColAddress
        '
        Me.ColAddress.HeaderText = "Address"
        Me.ColAddress.MinimumWidth = 8
        Me.ColAddress.Name = "ColAddress"
        Me.ColAddress.ReadOnly = True
        Me.ColAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'BtnAddCustomer
        '
        Me.BtnAddCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddCustomer.ForeColor = System.Drawing.Color.White
        Me.BtnAddCustomer.Location = New System.Drawing.Point(13, 461)
        Me.BtnAddCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAddCustomer.Name = "BtnAddCustomer"
        Me.BtnAddCustomer.Size = New System.Drawing.Size(200, 50)
        Me.BtnAddCustomer.TabIndex = 3
        Me.BtnAddCustomer.Text = "Add Customer"
        Me.BtnAddCustomer.UseVisualStyleBackColor = False
        '
        'BtnUpdateCustomer
        '
        Me.BtnUpdateCustomer.BackColor = System.Drawing.Color.Blue
        Me.BtnUpdateCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdateCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateCustomer.ForeColor = System.Drawing.Color.White
        Me.BtnUpdateCustomer.Location = New System.Drawing.Point(296, 460)
        Me.BtnUpdateCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnUpdateCustomer.Name = "BtnUpdateCustomer"
        Me.BtnUpdateCustomer.Size = New System.Drawing.Size(200, 50)
        Me.BtnUpdateCustomer.TabIndex = 4
        Me.BtnUpdateCustomer.Text = "Update Customer"
        Me.BtnUpdateCustomer.UseVisualStyleBackColor = False
        '
        'BtnDeleteCustomer
        '
        Me.BtnDeleteCustomer.BackColor = System.Drawing.Color.Red
        Me.BtnDeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDeleteCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteCustomer.ForeColor = System.Drawing.Color.White
        Me.BtnDeleteCustomer.Location = New System.Drawing.Point(569, 461)
        Me.BtnDeleteCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDeleteCustomer.Name = "BtnDeleteCustomer"
        Me.BtnDeleteCustomer.Size = New System.Drawing.Size(200, 50)
        Me.BtnDeleteCustomer.TabIndex = 5
        Me.BtnDeleteCustomer.Text = "Delete"
        Me.BtnDeleteCustomer.UseVisualStyleBackColor = False
        '
        'BtnCloseCustomer
        '
        Me.BtnCloseCustomer.BackColor = System.Drawing.Color.Gray
        Me.BtnCloseCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCloseCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCloseCustomer.ForeColor = System.Drawing.Color.White
        Me.BtnCloseCustomer.Location = New System.Drawing.Point(812, 461)
        Me.BtnCloseCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCloseCustomer.Name = "BtnCloseCustomer"
        Me.BtnCloseCustomer.Size = New System.Drawing.Size(200, 50)
        Me.BtnCloseCustomer.TabIndex = 6
        Me.BtnCloseCustomer.Text = "Close"
        Me.BtnCloseCustomer.UseVisualStyleBackColor = False
        '
        'FrmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 562)
        Me.Controls.Add(Me.BtnCloseCustomer)
        Me.Controls.Add(Me.grpSearchCustomer)
        Me.Controls.Add(Me.BtnDeleteCustomer)
        Me.Controls.Add(Me.BtnUpdateCustomer)
        Me.Controls.Add(Me.BtnAddCustomer)
        Me.Controls.Add(Me.dgvCustomers)
        Me.Controls.Add(Me.PnlHeader)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FrmCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Management"
        Me.PnlHeader.ResumeLayout(False)
        Me.PnlHeader.PerformLayout()
        Me.grpSearchCustomer.ResumeLayout(False)
        Me.grpSearchCustomer.PerformLayout()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlHeader As Panel
    Friend WithEvents grpSearchCustomer As GroupBox
    Friend WithEvents LblTitle As Label
    Friend WithEvents lblSearchCustomer As Label
    Friend WithEvents BtnSearchCustomer As Button
    Friend WithEvents BtnRefreshCustomer As Button
    Friend WithEvents dgvCustomers As DataGridView
    Friend WithEvents BtnAddCustomer As Button
    Friend WithEvents BtnUpdateCustomer As Button
    Friend WithEvents BtnDeleteCustomer As Button
    Friend WithEvents BtnCloseCustomer As Button
    Friend WithEvents colCustomerID As DataGridViewTextBoxColumn
    Friend WithEvents ColCustomerName As DataGridViewTextBoxColumn
    Friend WithEvents ColPhone As DataGridViewTextBoxColumn
    Friend WithEvents ColEmail As DataGridViewTextBoxColumn
    Friend WithEvents ColAddress As DataGridViewTextBoxColumn
    Friend WithEvents TxtSearchCustomer As TextBox
End Class
