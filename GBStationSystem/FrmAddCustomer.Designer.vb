<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddCustomer
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblCustomerName = New System.Windows.Forms.Label()
        Me.LblPhoneNumber = New System.Windows.Forms.Label()
        Me.LblEmailAddress = New System.Windows.Forms.Label()
        Me.LblAddress = New System.Windows.Forms.Label()
        Me.TxtCustomerName = New System.Windows.Forms.TextBox()
        Me.TxtPhone = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label1.Location = New System.Drawing.Point(239, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ADD CUSTOMER"
        '
        'LblCustomerName
        '
        Me.LblCustomerName.AutoSize = True
        Me.LblCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCustomerName.Location = New System.Drawing.Point(152, 102)
        Me.LblCustomerName.Name = "LblCustomerName"
        Me.LblCustomerName.Size = New System.Drawing.Size(154, 25)
        Me.LblCustomerName.TabIndex = 1
        Me.LblCustomerName.Text = "Customer Name"
        '
        'LblPhoneNumber
        '
        Me.LblPhoneNumber.AutoSize = True
        Me.LblPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPhoneNumber.Location = New System.Drawing.Point(152, 149)
        Me.LblPhoneNumber.Name = "LblPhoneNumber"
        Me.LblPhoneNumber.Size = New System.Drawing.Size(143, 25)
        Me.LblPhoneNumber.TabIndex = 2
        Me.LblPhoneNumber.Text = "Phone Number"
        '
        'LblEmailAddress
        '
        Me.LblEmailAddress.AutoSize = True
        Me.LblEmailAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmailAddress.Location = New System.Drawing.Point(152, 197)
        Me.LblEmailAddress.Name = "LblEmailAddress"
        Me.LblEmailAddress.Size = New System.Drawing.Size(138, 25)
        Me.LblEmailAddress.TabIndex = 3
        Me.LblEmailAddress.Text = "Email Address"
        '
        'LblAddress
        '
        Me.LblAddress.AutoSize = True
        Me.LblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAddress.Location = New System.Drawing.Point(152, 245)
        Me.LblAddress.Name = "LblAddress"
        Me.LblAddress.Size = New System.Drawing.Size(85, 25)
        Me.LblAddress.TabIndex = 4
        Me.LblAddress.Text = "Address"
        '
        'TxtCustomerName
        '
        Me.TxtCustomerName.Location = New System.Drawing.Point(361, 103)
        Me.TxtCustomerName.Multiline = True
        Me.TxtCustomerName.Name = "TxtCustomerName"
        Me.TxtCustomerName.Size = New System.Drawing.Size(259, 26)
        Me.TxtCustomerName.TabIndex = 5
        '
        'TxtPhone
        '
        Me.TxtPhone.Location = New System.Drawing.Point(361, 148)
        Me.TxtPhone.Multiline = True
        Me.TxtPhone.Name = "TxtPhone"
        Me.TxtPhone.Size = New System.Drawing.Size(259, 26)
        Me.TxtPhone.TabIndex = 6
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(361, 198)
        Me.TxtEmail.Multiline = True
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(259, 26)
        Me.TxtEmail.TabIndex = 7
        '
        'TxtAddress
        '
        Me.TxtAddress.Location = New System.Drawing.Point(361, 246)
        Me.TxtAddress.Multiline = True
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(259, 26)
        Me.TxtAddress.TabIndex = 8
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Location = New System.Drawing.Point(176, 308)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(143, 48)
        Me.BtnSave.TabIndex = 9
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Location = New System.Drawing.Point(452, 308)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(146, 48)
        Me.BtnCancel.TabIndex = 10
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'FrmAddCustomer
        '
        Me.AcceptButton = Me.BtnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TxtAddress)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtPhone)
        Me.Controls.Add(Me.TxtCustomerName)
        Me.Controls.Add(Me.LblAddress)
        Me.Controls.Add(Me.LblEmailAddress)
        Me.Controls.Add(Me.LblPhoneNumber)
        Me.Controls.Add(Me.LblCustomerName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmAddCustomer"
        Me.Text = "FrmAddCustomer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LblCustomerName As Label
    Friend WithEvents LblPhoneNumber As Label
    Friend WithEvents LblEmailAddress As Label
    Friend WithEvents LblAddress As Label
    Friend WithEvents TxtCustomerName As TextBox
    Friend WithEvents TxtPhone As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnCancel As Button
End Class
