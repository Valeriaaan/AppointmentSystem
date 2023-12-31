<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeForm
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EmployeeTitleLabel = New System.Windows.Forms.Label()
        Me.EmployeeViewPanel = New System.Windows.Forms.Panel()
        Me.ExportBtn = New System.Windows.Forms.Button()
        Me.EmployeeDGV = New System.Windows.Forms.DataGridView()
        Me.EmployeeAddPanel = New System.Windows.Forms.Panel()
        Me.AEmployeeAddressTextBox = New System.Windows.Forms.TextBox()
        Me.AEmployeePhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.AEmployeeJobTitleTextBox = New System.Windows.Forms.TextBox()
        Me.ProductSupplierLabel = New System.Windows.Forms.Label()
        Me.AddEmployeeBtn = New System.Windows.Forms.Button()
        Me.ProductIDLabel = New System.Windows.Forms.Label()
        Me.AEmployeeIDComboBox = New System.Windows.Forms.ComboBox()
        Me.ProductPriceLabel = New System.Windows.Forms.Label()
        Me.ProductDescLabel = New System.Windows.Forms.Label()
        Me.IngredientNameLabel = New System.Windows.Forms.Label()
        Me.AClearBtn = New System.Windows.Forms.Button()
        Me.AEmployeeNameTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeUpdatePanel = New System.Windows.Forms.Panel()
        Me.UEmployeeAddressTextBox = New System.Windows.Forms.TextBox()
        Me.UEmployeePhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.UEmployeeJobTitleTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UpdateEmployeeBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UEmployeeIDComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.UClearBtn = New System.Windows.Forms.Button()
        Me.UEmployeeNameTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeDeletePanel = New System.Windows.Forms.Panel()
        Me.DEmployeeAddressTextBox = New System.Windows.Forms.TextBox()
        Me.DEmployeePhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.DEmployeeJobTitleTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DeleteEmployeeBtn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DEmployeeIDComboBox = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DEmployeeNameTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.EmployeeViewPanel.SuspendLayout()
        CType(Me.EmployeeDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmployeeAddPanel.SuspendLayout()
        Me.EmployeeUpdatePanel.SuspendLayout()
        Me.EmployeeDeletePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.EmployeeTitleLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(959, 51)
        Me.Panel1.TabIndex = 9
        '
        'EmployeeTitleLabel
        '
        Me.EmployeeTitleLabel.AutoSize = True
        Me.EmployeeTitleLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.EmployeeTitleLabel.Font = New System.Drawing.Font("Segoe UI Black", 16.0!, System.Drawing.FontStyle.Bold)
        Me.EmployeeTitleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.EmployeeTitleLabel.Location = New System.Drawing.Point(18, 9)
        Me.EmployeeTitleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmployeeTitleLabel.Name = "EmployeeTitleLabel"
        Me.EmployeeTitleLabel.Size = New System.Drawing.Size(159, 37)
        Me.EmployeeTitleLabel.TabIndex = 14
        Me.EmployeeTitleLabel.Text = "Employees"
        '
        'EmployeeViewPanel
        '
        Me.EmployeeViewPanel.BackColor = System.Drawing.SystemColors.Control
        Me.EmployeeViewPanel.Controls.Add(Me.ExportBtn)
        Me.EmployeeViewPanel.Controls.Add(Me.EmployeeDGV)
        Me.EmployeeViewPanel.Location = New System.Drawing.Point(0, 51)
        Me.EmployeeViewPanel.Name = "EmployeeViewPanel"
        Me.EmployeeViewPanel.Size = New System.Drawing.Size(959, 515)
        Me.EmployeeViewPanel.TabIndex = 10
        '
        'ExportBtn
        '
        Me.ExportBtn.Location = New System.Drawing.Point(17, 456)
        Me.ExportBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.ExportBtn.Name = "ExportBtn"
        Me.ExportBtn.Size = New System.Drawing.Size(925, 43)
        Me.ExportBtn.TabIndex = 55
        Me.ExportBtn.Text = "Export to Excel"
        Me.ExportBtn.UseVisualStyleBackColor = True
        '
        'EmployeeDGV
        '
        Me.EmployeeDGV.AllowUserToAddRows = False
        Me.EmployeeDGV.AllowUserToDeleteRows = False
        Me.EmployeeDGV.AllowUserToResizeColumns = False
        Me.EmployeeDGV.AllowUserToResizeRows = False
        Me.EmployeeDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.EmployeeDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.EmployeeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmployeeDGV.Location = New System.Drawing.Point(17, 11)
        Me.EmployeeDGV.Margin = New System.Windows.Forms.Padding(4)
        Me.EmployeeDGV.Name = "EmployeeDGV"
        Me.EmployeeDGV.ReadOnly = True
        Me.EmployeeDGV.RowHeadersWidth = 21
        Me.EmployeeDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EmployeeDGV.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.EmployeeDGV.RowTemplate.Height = 24
        Me.EmployeeDGV.Size = New System.Drawing.Size(925, 432)
        Me.EmployeeDGV.TabIndex = 40
        '
        'EmployeeAddPanel
        '
        Me.EmployeeAddPanel.BackColor = System.Drawing.SystemColors.Control
        Me.EmployeeAddPanel.Controls.Add(Me.AEmployeeAddressTextBox)
        Me.EmployeeAddPanel.Controls.Add(Me.AEmployeePhoneNumberTextBox)
        Me.EmployeeAddPanel.Controls.Add(Me.AEmployeeJobTitleTextBox)
        Me.EmployeeAddPanel.Controls.Add(Me.ProductSupplierLabel)
        Me.EmployeeAddPanel.Controls.Add(Me.AddEmployeeBtn)
        Me.EmployeeAddPanel.Controls.Add(Me.ProductIDLabel)
        Me.EmployeeAddPanel.Controls.Add(Me.AEmployeeIDComboBox)
        Me.EmployeeAddPanel.Controls.Add(Me.ProductPriceLabel)
        Me.EmployeeAddPanel.Controls.Add(Me.ProductDescLabel)
        Me.EmployeeAddPanel.Controls.Add(Me.IngredientNameLabel)
        Me.EmployeeAddPanel.Controls.Add(Me.AClearBtn)
        Me.EmployeeAddPanel.Controls.Add(Me.AEmployeeNameTextBox)
        Me.EmployeeAddPanel.Location = New System.Drawing.Point(0, 51)
        Me.EmployeeAddPanel.Name = "EmployeeAddPanel"
        Me.EmployeeAddPanel.Size = New System.Drawing.Size(959, 515)
        Me.EmployeeAddPanel.TabIndex = 11
        '
        'AEmployeeAddressTextBox
        '
        Me.AEmployeeAddressTextBox.Location = New System.Drawing.Point(436, 274)
        Me.AEmployeeAddressTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.AEmployeeAddressTextBox.Name = "AEmployeeAddressTextBox"
        Me.AEmployeeAddressTextBox.Size = New System.Drawing.Size(254, 34)
        Me.AEmployeeAddressTextBox.TabIndex = 60
        '
        'AEmployeePhoneNumberTextBox
        '
        Me.AEmployeePhoneNumberTextBox.Location = New System.Drawing.Point(436, 170)
        Me.AEmployeePhoneNumberTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.AEmployeePhoneNumberTextBox.Name = "AEmployeePhoneNumberTextBox"
        Me.AEmployeePhoneNumberTextBox.Size = New System.Drawing.Size(254, 34)
        Me.AEmployeePhoneNumberTextBox.TabIndex = 59
        '
        'AEmployeeJobTitleTextBox
        '
        Me.AEmployeeJobTitleTextBox.Location = New System.Drawing.Point(436, 224)
        Me.AEmployeeJobTitleTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.AEmployeeJobTitleTextBox.Name = "AEmployeeJobTitleTextBox"
        Me.AEmployeeJobTitleTextBox.Size = New System.Drawing.Size(254, 34)
        Me.AEmployeeJobTitleTextBox.TabIndex = 58
        '
        'ProductSupplierLabel
        '
        Me.ProductSupplierLabel.AutoSize = True
        Me.ProductSupplierLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ProductSupplierLabel.Location = New System.Drawing.Point(269, 277)
        Me.ProductSupplierLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ProductSupplierLabel.Name = "ProductSupplierLabel"
        Me.ProductSupplierLabel.Size = New System.Drawing.Size(82, 28)
        Me.ProductSupplierLabel.TabIndex = 57
        Me.ProductSupplierLabel.Text = "Address"
        '
        'AddEmployeeBtn
        '
        Me.AddEmployeeBtn.Location = New System.Drawing.Point(274, 339)
        Me.AddEmployeeBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.AddEmployeeBtn.Name = "AddEmployeeBtn"
        Me.AddEmployeeBtn.Size = New System.Drawing.Size(416, 43)
        Me.AddEmployeeBtn.TabIndex = 54
        Me.AddEmployeeBtn.Text = "Add Employee"
        Me.AddEmployeeBtn.UseVisualStyleBackColor = True
        '
        'ProductIDLabel
        '
        Me.ProductIDLabel.AutoSize = True
        Me.ProductIDLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ProductIDLabel.Location = New System.Drawing.Point(269, 75)
        Me.ProductIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ProductIDLabel.Name = "ProductIDLabel"
        Me.ProductIDLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ProductIDLabel.Size = New System.Drawing.Size(122, 28)
        Me.ProductIDLabel.TabIndex = 46
        Me.ProductIDLabel.Text = "Employee ID"
        '
        'AEmployeeIDComboBox
        '
        Me.AEmployeeIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AEmployeeIDComboBox.Enabled = False
        Me.AEmployeeIDComboBox.FormattingEnabled = True
        Me.AEmployeeIDComboBox.Location = New System.Drawing.Point(436, 72)
        Me.AEmployeeIDComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AEmployeeIDComboBox.Name = "AEmployeeIDComboBox"
        Me.AEmployeeIDComboBox.Size = New System.Drawing.Size(254, 36)
        Me.AEmployeeIDComboBox.TabIndex = 43
        '
        'ProductPriceLabel
        '
        Me.ProductPriceLabel.AutoSize = True
        Me.ProductPriceLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ProductPriceLabel.Location = New System.Drawing.Point(269, 227)
        Me.ProductPriceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ProductPriceLabel.Name = "ProductPriceLabel"
        Me.ProductPriceLabel.Size = New System.Drawing.Size(85, 28)
        Me.ProductPriceLabel.TabIndex = 49
        Me.ProductPriceLabel.Text = "Job Title"
        '
        'ProductDescLabel
        '
        Me.ProductDescLabel.AutoSize = True
        Me.ProductDescLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ProductDescLabel.Location = New System.Drawing.Point(269, 177)
        Me.ProductDescLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ProductDescLabel.Name = "ProductDescLabel"
        Me.ProductDescLabel.Size = New System.Drawing.Size(144, 28)
        Me.ProductDescLabel.TabIndex = 47
        Me.ProductDescLabel.Text = "Phone Number"
        '
        'IngredientNameLabel
        '
        Me.IngredientNameLabel.AutoSize = True
        Me.IngredientNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.IngredientNameLabel.Location = New System.Drawing.Point(269, 127)
        Me.IngredientNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IngredientNameLabel.Name = "IngredientNameLabel"
        Me.IngredientNameLabel.Size = New System.Drawing.Size(64, 28)
        Me.IngredientNameLabel.TabIndex = 45
        Me.IngredientNameLabel.Text = "Name"
        '
        'AClearBtn
        '
        Me.AClearBtn.Location = New System.Drawing.Point(274, 400)
        Me.AClearBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.AClearBtn.Name = "AClearBtn"
        Me.AClearBtn.Size = New System.Drawing.Size(416, 43)
        Me.AClearBtn.TabIndex = 44
        Me.AClearBtn.Text = "Clear Form"
        Me.AClearBtn.UseVisualStyleBackColor = True
        '
        'AEmployeeNameTextBox
        '
        Me.AEmployeeNameTextBox.Location = New System.Drawing.Point(436, 124)
        Me.AEmployeeNameTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.AEmployeeNameTextBox.Name = "AEmployeeNameTextBox"
        Me.AEmployeeNameTextBox.Size = New System.Drawing.Size(254, 34)
        Me.AEmployeeNameTextBox.TabIndex = 42
        '
        'EmployeeUpdatePanel
        '
        Me.EmployeeUpdatePanel.BackColor = System.Drawing.SystemColors.Control
        Me.EmployeeUpdatePanel.Controls.Add(Me.UEmployeeAddressTextBox)
        Me.EmployeeUpdatePanel.Controls.Add(Me.UEmployeePhoneNumberTextBox)
        Me.EmployeeUpdatePanel.Controls.Add(Me.UEmployeeJobTitleTextBox)
        Me.EmployeeUpdatePanel.Controls.Add(Me.Label1)
        Me.EmployeeUpdatePanel.Controls.Add(Me.UpdateEmployeeBtn)
        Me.EmployeeUpdatePanel.Controls.Add(Me.Label2)
        Me.EmployeeUpdatePanel.Controls.Add(Me.UEmployeeIDComboBox)
        Me.EmployeeUpdatePanel.Controls.Add(Me.Label3)
        Me.EmployeeUpdatePanel.Controls.Add(Me.Label4)
        Me.EmployeeUpdatePanel.Controls.Add(Me.Label5)
        Me.EmployeeUpdatePanel.Controls.Add(Me.UClearBtn)
        Me.EmployeeUpdatePanel.Controls.Add(Me.UEmployeeNameTextBox)
        Me.EmployeeUpdatePanel.Location = New System.Drawing.Point(0, 51)
        Me.EmployeeUpdatePanel.Name = "EmployeeUpdatePanel"
        Me.EmployeeUpdatePanel.Size = New System.Drawing.Size(959, 515)
        Me.EmployeeUpdatePanel.TabIndex = 12
        '
        'UEmployeeAddressTextBox
        '
        Me.UEmployeeAddressTextBox.Location = New System.Drawing.Point(436, 274)
        Me.UEmployeeAddressTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.UEmployeeAddressTextBox.Name = "UEmployeeAddressTextBox"
        Me.UEmployeeAddressTextBox.Size = New System.Drawing.Size(254, 34)
        Me.UEmployeeAddressTextBox.TabIndex = 60
        '
        'UEmployeePhoneNumberTextBox
        '
        Me.UEmployeePhoneNumberTextBox.Location = New System.Drawing.Point(436, 170)
        Me.UEmployeePhoneNumberTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.UEmployeePhoneNumberTextBox.Name = "UEmployeePhoneNumberTextBox"
        Me.UEmployeePhoneNumberTextBox.Size = New System.Drawing.Size(254, 34)
        Me.UEmployeePhoneNumberTextBox.TabIndex = 59
        '
        'UEmployeeJobTitleTextBox
        '
        Me.UEmployeeJobTitleTextBox.Location = New System.Drawing.Point(436, 224)
        Me.UEmployeeJobTitleTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.UEmployeeJobTitleTextBox.Name = "UEmployeeJobTitleTextBox"
        Me.UEmployeeJobTitleTextBox.Size = New System.Drawing.Size(254, 34)
        Me.UEmployeeJobTitleTextBox.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(269, 277)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 28)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Address"
        '
        'UpdateEmployeeBtn
        '
        Me.UpdateEmployeeBtn.Location = New System.Drawing.Point(274, 339)
        Me.UpdateEmployeeBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.UpdateEmployeeBtn.Name = "UpdateEmployeeBtn"
        Me.UpdateEmployeeBtn.Size = New System.Drawing.Size(416, 43)
        Me.UpdateEmployeeBtn.TabIndex = 54
        Me.UpdateEmployeeBtn.Text = "Update Employee"
        Me.UpdateEmployeeBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(269, 75)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(122, 28)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Employee ID"
        '
        'UEmployeeIDComboBox
        '
        Me.UEmployeeIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UEmployeeIDComboBox.FormattingEnabled = True
        Me.UEmployeeIDComboBox.Location = New System.Drawing.Point(436, 72)
        Me.UEmployeeIDComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.UEmployeeIDComboBox.Name = "UEmployeeIDComboBox"
        Me.UEmployeeIDComboBox.Size = New System.Drawing.Size(254, 36)
        Me.UEmployeeIDComboBox.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(269, 227)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 28)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Job Title"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(269, 177)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 28)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Phone Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(269, 127)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 28)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Name"
        '
        'UClearBtn
        '
        Me.UClearBtn.Location = New System.Drawing.Point(274, 400)
        Me.UClearBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.UClearBtn.Name = "UClearBtn"
        Me.UClearBtn.Size = New System.Drawing.Size(416, 43)
        Me.UClearBtn.TabIndex = 44
        Me.UClearBtn.Text = "Clear Form"
        Me.UClearBtn.UseVisualStyleBackColor = True
        '
        'UEmployeeNameTextBox
        '
        Me.UEmployeeNameTextBox.Location = New System.Drawing.Point(436, 124)
        Me.UEmployeeNameTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.UEmployeeNameTextBox.Name = "UEmployeeNameTextBox"
        Me.UEmployeeNameTextBox.Size = New System.Drawing.Size(254, 34)
        Me.UEmployeeNameTextBox.TabIndex = 42
        '
        'EmployeeDeletePanel
        '
        Me.EmployeeDeletePanel.BackColor = System.Drawing.SystemColors.Control
        Me.EmployeeDeletePanel.Controls.Add(Me.DEmployeeAddressTextBox)
        Me.EmployeeDeletePanel.Controls.Add(Me.DEmployeePhoneNumberTextBox)
        Me.EmployeeDeletePanel.Controls.Add(Me.DEmployeeJobTitleTextBox)
        Me.EmployeeDeletePanel.Controls.Add(Me.Label6)
        Me.EmployeeDeletePanel.Controls.Add(Me.DeleteEmployeeBtn)
        Me.EmployeeDeletePanel.Controls.Add(Me.Label7)
        Me.EmployeeDeletePanel.Controls.Add(Me.DEmployeeIDComboBox)
        Me.EmployeeDeletePanel.Controls.Add(Me.Label8)
        Me.EmployeeDeletePanel.Controls.Add(Me.Label9)
        Me.EmployeeDeletePanel.Controls.Add(Me.Label10)
        Me.EmployeeDeletePanel.Controls.Add(Me.DEmployeeNameTextBox)
        Me.EmployeeDeletePanel.Location = New System.Drawing.Point(0, 51)
        Me.EmployeeDeletePanel.Name = "EmployeeDeletePanel"
        Me.EmployeeDeletePanel.Size = New System.Drawing.Size(959, 515)
        Me.EmployeeDeletePanel.TabIndex = 13
        '
        'DEmployeeAddressTextBox
        '
        Me.DEmployeeAddressTextBox.Enabled = False
        Me.DEmployeeAddressTextBox.Location = New System.Drawing.Point(436, 274)
        Me.DEmployeeAddressTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.DEmployeeAddressTextBox.Name = "DEmployeeAddressTextBox"
        Me.DEmployeeAddressTextBox.Size = New System.Drawing.Size(254, 34)
        Me.DEmployeeAddressTextBox.TabIndex = 60
        '
        'DEmployeePhoneNumberTextBox
        '
        Me.DEmployeePhoneNumberTextBox.Enabled = False
        Me.DEmployeePhoneNumberTextBox.Location = New System.Drawing.Point(436, 170)
        Me.DEmployeePhoneNumberTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.DEmployeePhoneNumberTextBox.Name = "DEmployeePhoneNumberTextBox"
        Me.DEmployeePhoneNumberTextBox.Size = New System.Drawing.Size(254, 34)
        Me.DEmployeePhoneNumberTextBox.TabIndex = 59
        '
        'DEmployeeJobTitleTextBox
        '
        Me.DEmployeeJobTitleTextBox.Enabled = False
        Me.DEmployeeJobTitleTextBox.Location = New System.Drawing.Point(436, 224)
        Me.DEmployeeJobTitleTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.DEmployeeJobTitleTextBox.Name = "DEmployeeJobTitleTextBox"
        Me.DEmployeeJobTitleTextBox.Size = New System.Drawing.Size(254, 34)
        Me.DEmployeeJobTitleTextBox.TabIndex = 58
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(269, 277)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 28)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Address"
        '
        'DeleteEmployeeBtn
        '
        Me.DeleteEmployeeBtn.Location = New System.Drawing.Point(274, 339)
        Me.DeleteEmployeeBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.DeleteEmployeeBtn.Name = "DeleteEmployeeBtn"
        Me.DeleteEmployeeBtn.Size = New System.Drawing.Size(416, 43)
        Me.DeleteEmployeeBtn.TabIndex = 54
        Me.DeleteEmployeeBtn.Text = "Delete Employee"
        Me.DeleteEmployeeBtn.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(269, 75)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(122, 28)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Employee ID"
        '
        'DEmployeeIDComboBox
        '
        Me.DEmployeeIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DEmployeeIDComboBox.FormattingEnabled = True
        Me.DEmployeeIDComboBox.Location = New System.Drawing.Point(436, 72)
        Me.DEmployeeIDComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DEmployeeIDComboBox.Name = "DEmployeeIDComboBox"
        Me.DEmployeeIDComboBox.Size = New System.Drawing.Size(254, 36)
        Me.DEmployeeIDComboBox.TabIndex = 43
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(269, 227)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 28)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Job Title"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(269, 177)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(144, 28)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Phone Number"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(269, 127)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 28)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Name"
        '
        'DEmployeeNameTextBox
        '
        Me.DEmployeeNameTextBox.Enabled = False
        Me.DEmployeeNameTextBox.Location = New System.Drawing.Point(436, 124)
        Me.DEmployeeNameTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.DEmployeeNameTextBox.Name = "DEmployeeNameTextBox"
        Me.DEmployeeNameTextBox.Size = New System.Drawing.Size(254, 34)
        Me.DEmployeeNameTextBox.TabIndex = 42
        '
        'EmployeeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 563)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.EmployeeUpdatePanel)
        Me.Controls.Add(Me.EmployeeAddPanel)
        Me.Controls.Add(Me.EmployeeViewPanel)
        Me.Controls.Add(Me.EmployeeDeletePanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "EmployeeForm"
        Me.Text = "EmployeeForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.EmployeeViewPanel.ResumeLayout(False)
        CType(Me.EmployeeDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmployeeAddPanel.ResumeLayout(False)
        Me.EmployeeAddPanel.PerformLayout()
        Me.EmployeeUpdatePanel.ResumeLayout(False)
        Me.EmployeeUpdatePanel.PerformLayout()
        Me.EmployeeDeletePanel.ResumeLayout(False)
        Me.EmployeeDeletePanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents EmployeeTitleLabel As System.Windows.Forms.Label
    Friend WithEvents EmployeeViewPanel As System.Windows.Forms.Panel
    Friend WithEvents EmployeeDGV As System.Windows.Forms.DataGridView
    Friend WithEvents EmployeeAddPanel As System.Windows.Forms.Panel
    Friend WithEvents AEmployeeAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AEmployeePhoneNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AEmployeeJobTitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProductSupplierLabel As System.Windows.Forms.Label
    Friend WithEvents AddEmployeeBtn As System.Windows.Forms.Button
    Friend WithEvents ProductIDLabel As System.Windows.Forms.Label
    Friend WithEvents AEmployeeIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ProductPriceLabel As System.Windows.Forms.Label
    Friend WithEvents ProductDescLabel As System.Windows.Forms.Label
    Friend WithEvents IngredientNameLabel As System.Windows.Forms.Label
    Friend WithEvents AClearBtn As System.Windows.Forms.Button
    Friend WithEvents AEmployeeNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmployeeUpdatePanel As System.Windows.Forms.Panel
    Friend WithEvents UEmployeeAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UEmployeePhoneNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UEmployeeJobTitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UpdateEmployeeBtn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents UEmployeeIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents UClearBtn As System.Windows.Forms.Button
    Friend WithEvents UEmployeeNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmployeeDeletePanel As System.Windows.Forms.Panel
    Friend WithEvents DEmployeeAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DEmployeePhoneNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DEmployeeJobTitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DeleteEmployeeBtn As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DEmployeeIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DEmployeeNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExportBtn As System.Windows.Forms.Button
End Class
