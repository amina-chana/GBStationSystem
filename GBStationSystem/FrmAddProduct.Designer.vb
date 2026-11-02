<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddProduct
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
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LblProductName = New System.Windows.Forms.Label()
        Me.LblCategory = New System.Windows.Forms.Label()
        Me.Lblprice = New System.Windows.Forms.Label()
        Me.TxtProductName = New System.Windows.Forms.TextBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.LblQuantity = New System.Windows.Forms.Label()
        Me.TxtUnitPrice = New System.Windows.Forms.TextBox()
        Me.TxtQuantity = New System.Windows.Forms.TextBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.CmbCategory = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.Green
        Me.LblTitle.Location = New System.Drawing.Point(195, 32)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(262, 37)
        Me.LblTitle.TabIndex = 0
        Me.LblTitle.Text = "ADD PRODUCT"
        '
        'LblProductName
        '
        Me.LblProductName.AutoSize = True
        Me.LblProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProductName.Location = New System.Drawing.Point(106, 110)
        Me.LblProductName.Name = "LblProductName"
        Me.LblProductName.Size = New System.Drawing.Size(142, 25)
        Me.LblProductName.TabIndex = 1
        Me.LblProductName.Text = "Product Name:"
        '
        'LblCategory
        '
        Me.LblCategory.AutoSize = True
        Me.LblCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCategory.Location = New System.Drawing.Point(106, 155)
        Me.LblCategory.Name = "LblCategory"
        Me.LblCategory.Size = New System.Drawing.Size(98, 25)
        Me.LblCategory.TabIndex = 2
        Me.LblCategory.Text = "Category:"
        '
        'Lblprice
        '
        Me.Lblprice.AutoSize = True
        Me.Lblprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblprice.Location = New System.Drawing.Point(106, 207)
        Me.Lblprice.Name = "Lblprice"
        Me.Lblprice.Size = New System.Drawing.Size(150, 25)
        Me.Lblprice.TabIndex = 3
        Me.Lblprice.Text = "Unit Price(Ksh):"
        '
        'TxtProductName
        '
        Me.TxtProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProductName.Location = New System.Drawing.Point(291, 109)
        Me.TxtProductName.Name = "TxtProductName"
        Me.TxtProductName.Size = New System.Drawing.Size(232, 30)
        Me.TxtProductName.TabIndex = 4
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.Location = New System.Drawing.Point(131, 332)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(140, 45)
        Me.BtnAdd.TabIndex = 6
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'LblQuantity
        '
        Me.LblQuantity.AutoSize = True
        Me.LblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQuantity.Location = New System.Drawing.Point(106, 252)
        Me.LblQuantity.Name = "LblQuantity"
        Me.LblQuantity.Size = New System.Drawing.Size(91, 25)
        Me.LblQuantity.TabIndex = 7
        Me.LblQuantity.Text = "Quantity:"
        '
        'TxtUnitPrice
        '
        Me.TxtUnitPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUnitPrice.Location = New System.Drawing.Point(291, 208)
        Me.TxtUnitPrice.Name = "TxtUnitPrice"
        Me.TxtUnitPrice.Size = New System.Drawing.Size(232, 30)
        Me.TxtUnitPrice.TabIndex = 8
        '
        'TxtQuantity
        '
        Me.TxtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQuantity.Location = New System.Drawing.Point(291, 261)
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.Size = New System.Drawing.Size(232, 30)
        Me.TxtQuantity.TabIndex = 9
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Location = New System.Drawing.Point(358, 332)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(140, 45)
        Me.BtnCancel.TabIndex = 10
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'CmbCategory
        '
        Me.CmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCategory.FormattingEnabled = True
        Me.CmbCategory.Items.AddRange(New Object() {"Books", "Pens", "Paper", "Accessories", "Others"})
        Me.CmbCategory.Location = New System.Drawing.Point(291, 155)
        Me.CmbCategory.Name = "CmbCategory"
        Me.CmbCategory.Size = New System.Drawing.Size(232, 33)
        Me.CmbCategory.TabIndex = 11
        '
        'FrmAddProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 450)
        Me.Controls.Add(Me.CmbCategory)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.TxtQuantity)
        Me.Controls.Add(Me.TxtUnitPrice)
        Me.Controls.Add(Me.LblQuantity)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.TxtProductName)
        Me.Controls.Add(Me.Lblprice)
        Me.Controls.Add(Me.LblCategory)
        Me.Controls.Add(Me.LblProductName)
        Me.Controls.Add(Me.LblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAddProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Product"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitle As Label
    Friend WithEvents LblProductName As Label
    Friend WithEvents LblCategory As Label
    Friend WithEvents Lblprice As Label
    Friend WithEvents TxtProductName As TextBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents LblQuantity As Label
    Friend WithEvents TxtUnitPrice As TextBox
    Friend WithEvents TxtQuantity As TextBox
    Friend WithEvents BtnCancel As Button
    Friend WithEvents CmbCategory As ComboBox
End Class
