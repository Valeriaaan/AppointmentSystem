<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductForm
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ProductTitleLabel = New System.Windows.Forms.Label()
        Me.ProductViewPanel = New System.Windows.Forms.Panel()
        Me.ProductDGV = New System.Windows.Forms.DataGridView()
        Me.ProductAddPanel = New System.Windows.Forms.Panel()
        Me.ProductDescTextBox = New System.Windows.Forms.TextBox()
        Me.ProductPriceTextBox = New System.Windows.Forms.TextBox()
        Me.ProductSupplierLabel = New System.Windows.Forms.Label()
        Me.ProductSupplierComboBox = New System.Windows.Forms.ComboBox()
        Me.ProductAddButton = New System.Windows.Forms.Button()
        Me.ProductIDLabel = New System.Windows.Forms.Label()
        Me.ProductIDComboBox = New System.Windows.Forms.ComboBox()
        Me.ProductPriceLabel = New System.Windows.Forms.Label()
        Me.ProductDescLabel = New System.Windows.Forms.Label()
        Me.IngredientNameLabel = New System.Windows.Forms.Label()
        Me.ProductClearButton = New System.Windows.Forms.Button()
        Me.ProductNameTextBox = New System.Windows.Forms.TextBox()
        Me.ProductUpdatePanel = New System.Windows.Forms.Panel()
        Me.UProductDescTextBox = New System.Windows.Forms.TextBox()
        Me.UProductPriceTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UProductSupplierComboBox = New System.Windows.Forms.ComboBox()
        Me.UpdateProductBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UProductIDComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.UClearBtn = New System.Windows.Forms.Button()
        Me.UProductNameTextBox = New System.Windows.Forms.TextBox()
        Me.ProductDeletePanel = New System.Windows.Forms.Panel()
        Me.DProductDescTextBox = New System.Windows.Forms.TextBox()
        Me.DProductPriceTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DProductSupplierComboBox = New System.Windows.Forms.ComboBox()
        Me.DeleteProductBtn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DProductIDComboBox = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DProductNameTextBox = New System.Windows.Forms.TextBox()
        Me.ExportBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.ProductViewPanel.SuspendLayout()
        CType(Me.ProductDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductAddPanel.SuspendLayout()
        Me.ProductUpdatePanel.SuspendLayout()
        Me.ProductDeletePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ProductTitleLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(959, 51)
        Me.Panel1.TabIndex = 7
        '
        'ProductTitleLabel
        '
        Me.ProductTitleLabel.AutoSize = True
        Me.ProductTitleLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ProductTitleLabel.Font = New System.Drawing.Font("Segoe UI Black", 16.0!, System.Drawing.FontStyle.Bold)
        Me.ProductTitleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ProductTitleLabel.Location = New System.Drawing.Point(18, 9)
        Me.ProductTitleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ProductTitleLabel.Name = "ProductTitleLabel"
        Me.ProductTitleLabel.Size = New System.Drawing.Size(135, 37)
        Me.ProductTitleLabel.TabIndex = 14
        Me.ProductTitleLabel.Text = "Products"
        '
        'ProductViewPanel
        '
        Me.ProductViewPanel.BackColor = System.Drawing.SystemColors.Control
        Me.ProductViewPanel.Controls.Add(Me.ExportBtn)
        Me.ProductViewPanel.Controls.Add(Me.ProductDGV)
        Me.ProductViewPanel.Location = New System.Drawing.Point(0, 50)
        Me.ProductViewPanel.Name = "ProductViewPanel"
        Me.ProductViewPanel.Size = New System.Drawing.Size(959, 515)
        Me.ProductViewPanel.TabIndex = 9
        '
        'ProductDGV
        '
        Me.ProductDGV.AllowUserToAddRows = False
        Me.ProductDGV.AllowUserToDeleteRows = False
        Me.ProductDGV.AllowUserToResizeColumns = False
        Me.ProductDGV.AllowUserToResizeRows = False
        Me.ProductDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ProductDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.ProductDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductDGV.Location = New System.Drawing.Point(17, 11)
        Me.ProductDGV.Margin = New System.Windows.Forms.Padding(4)
        Me.ProductDGV.Name = "ProductDGV"
        Me.ProductDGV.ReadOnly = True
        Me.ProductDGV.RowHeadersWidth = 21
        Me.ProductDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProductDGV.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.ProductDGV.RowTemplate.Height = 24
        Me.ProductDGV.Size = New System.Drawing.Size(925, 432)
        Me.ProductDGV.TabIndex = 40
        '
        'ProductAddPanel
        '
        Me.ProductAddPanel.BackColor = System.Drawing.SystemColors.Control
        Me.ProductAddPanel.Controls.Add(Me.ProductDescTextBox)
        Me.ProductAddPanel.Controls.Add(Me.ProductPriceTextBox)
        Me.ProductAddPanel.Controls.Add(Me.ProductSupplierLabel)
        Me.ProductAddPanel.Controls.Add(Me.ProductSupplierComboBox)
        Me.ProductAddPanel.Controls.Add(Me.ProductAddButton)
        Me.ProductAddPanel.Controls.Add(Me.ProductIDLabel)
        Me.ProductAddPanel.Controls.Add(Me.ProductIDComboBox)
        Me.ProductAddPanel.Controls.Add(Me.ProductPriceLabel)
        Me.ProductAddPanel.Controls.Add(Me.ProductDescLabel)
        Me.ProductAddPanel.Controls.Add(Me.IngredientNameLabel)
        Me.ProductAddPanel.Controls.Add(Me.ProductClearButton)
        Me.ProductAddPanel.Controls.Add(Me.ProductNameTextBox)
        Me.ProductAddPanel.Location = New System.Drawing.Point(0, 50)
        Me.ProductAddPanel.Name = "ProductAddPanel"
        Me.ProductAddPanel.Size = New System.Drawing.Size(959, 515)
        Me.ProductAddPanel.TabIndex = 10
        '
        'ProductDescTextBox
        '
        Me.ProductDescTextBox.Location = New System.Drawing.Point(436, 174)
        Me.ProductDescTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ProductDescTextBox.Name = "ProductDescTextBox"
        Me.ProductDescTextBox.Size = New System.Drawing.Size(254, 34)
        Me.ProductDescTextBox.TabIndex = 59
        '
        'ProductPriceTextBox
        '
        Me.ProductPriceTextBox.Location = New System.Drawing.Point(436, 224)
        Me.ProductPriceTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ProductPriceTextBox.Name = "ProductPriceTextBox"
        Me.ProductPriceTextBox.Size = New System.Drawing.Size(254, 34)
        Me.ProductPriceTextBox.TabIndex = 58
        '
        'ProductSupplierLabel
        '
        Me.ProductSupplierLabel.AutoSize = True
        Me.ProductSupplierLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ProductSupplierLabel.Location = New System.Drawing.Point(269, 277)
        Me.ProductSupplierLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ProductSupplierLabel.Name = "ProductSupplierLabel"
        Me.ProductSupplierLabel.Size = New System.Drawing.Size(85, 28)
        Me.ProductSupplierLabel.TabIndex = 57
        Me.ProductSupplierLabel.Text = "Supplier"
        '
        'ProductSupplierComboBox
        '
        Me.ProductSupplierComboBox.FormattingEnabled = True
        Me.ProductSupplierComboBox.Location = New System.Drawing.Point(436, 274)
        Me.ProductSupplierComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ProductSupplierComboBox.Name = "ProductSupplierComboBox"
        Me.ProductSupplierComboBox.Size = New System.Drawing.Size(254, 36)
        Me.ProductSupplierComboBox.TabIndex = 55
        '
        'ProductAddButton
        '
        Me.ProductAddButton.Location = New System.Drawing.Point(274, 339)
        Me.ProductAddButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ProductAddButton.Name = "ProductAddButton"
        Me.ProductAddButton.Size = New System.Drawing.Size(416, 43)
        Me.ProductAddButton.TabIndex = 54
        Me.ProductAddButton.Text = "Add Product"
        Me.ProductAddButton.UseVisualStyleBackColor = True
        '
        'ProductIDLabel
        '
        Me.ProductIDLabel.AutoSize = True
        Me.ProductIDLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ProductIDLabel.Location = New System.Drawing.Point(269, 75)
        Me.ProductIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ProductIDLabel.Name = "ProductIDLabel"
        Me.ProductIDLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ProductIDLabel.Size = New System.Drawing.Size(105, 28)
        Me.ProductIDLabel.TabIndex = 46
        Me.ProductIDLabel.Text = "Product ID"
        '
        'ProductIDComboBox
        '
        Me.ProductIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ProductIDComboBox.Enabled = False
        Me.ProductIDComboBox.FormattingEnabled = True
        Me.ProductIDComboBox.Location = New System.Drawing.Point(436, 72)
        Me.ProductIDComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ProductIDComboBox.Name = "ProductIDComboBox"
        Me.ProductIDComboBox.Size = New System.Drawing.Size(254, 36)
        Me.ProductIDComboBox.TabIndex = 43
        '
        'ProductPriceLabel
        '
        Me.ProductPriceLabel.AutoSize = True
        Me.ProductPriceLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ProductPriceLabel.Location = New System.Drawing.Point(269, 227)
        Me.ProductPriceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ProductPriceLabel.Name = "ProductPriceLabel"
        Me.ProductPriceLabel.Size = New System.Drawing.Size(54, 28)
        Me.ProductPriceLabel.TabIndex = 49
        Me.ProductPriceLabel.Text = "Price"
        '
        'ProductDescLabel
        '
        Me.ProductDescLabel.AutoSize = True
        Me.ProductDescLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ProductDescLabel.Location = New System.Drawing.Point(269, 177)
        Me.ProductDescLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ProductDescLabel.Name = "ProductDescLabel"
        Me.ProductDescLabel.Size = New System.Drawing.Size(112, 28)
        Me.ProductDescLabel.TabIndex = 47
        Me.ProductDescLabel.Text = "Description"
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
        'ProductClearButton
        '
        Me.ProductClearButton.Location = New System.Drawing.Point(274, 400)
        Me.ProductClearButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ProductClearButton.Name = "ProductClearButton"
        Me.ProductClearButton.Size = New System.Drawing.Size(416, 43)
        Me.ProductClearButton.TabIndex = 44
        Me.ProductClearButton.Text = "Clear Form"
        Me.ProductClearButton.UseVisualStyleBackColor = True
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.Location = New System.Drawing.Point(436, 124)
        Me.ProductNameTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.Size = New System.Drawing.Size(254, 34)
        Me.ProductNameTextBox.TabIndex = 42
        '
        'ProductUpdatePanel
        '
        Me.ProductUpdatePanel.BackColor = System.Drawing.SystemColors.Control
        Me.ProductUpdatePanel.Controls.Add(Me.UProductDescTextBox)
        Me.ProductUpdatePanel.Controls.Add(Me.UProductPriceTextBox)
        Me.ProductUpdatePanel.Controls.Add(Me.Label1)
        Me.ProductUpdatePanel.Controls.Add(Me.UProductSupplierComboBox)
        Me.ProductUpdatePanel.Controls.Add(Me.UpdateProductBtn)
        Me.ProductUpdatePanel.Controls.Add(Me.Label2)
        Me.ProductUpdatePanel.Controls.Add(Me.UProductIDComboBox)
        Me.ProductUpdatePanel.Controls.Add(Me.Label3)
        Me.ProductUpdatePanel.Controls.Add(Me.Label4)
        Me.ProductUpdatePanel.Controls.Add(Me.Label5)
        Me.ProductUpdatePanel.Controls.Add(Me.UClearBtn)
        Me.ProductUpdatePanel.Controls.Add(Me.UProductNameTextBox)
        Me.ProductUpdatePanel.Location = New System.Drawing.Point(0, 48)
        Me.ProductUpdatePanel.Name = "ProductUpdatePanel"
        Me.ProductUpdatePanel.Size = New System.Drawing.Size(959, 515)
        Me.ProductUpdatePanel.TabIndex = 11
        '
        'UProductDescTextBox
        '
        Me.UProductDescTextBox.Location = New System.Drawing.Point(436, 174)
        Me.UProductDescTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.UProductDescTextBox.Name = "UProductDescTextBox"
        Me.UProductDescTextBox.Size = New System.Drawing.Size(254, 34)
        Me.UProductDescTextBox.TabIndex = 59
        '
        'UProductPriceTextBox
        '
        Me.UProductPriceTextBox.Location = New System.Drawing.Point(436, 224)
        Me.UProductPriceTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.UProductPriceTextBox.Name = "UProductPriceTextBox"
        Me.UProductPriceTextBox.Size = New System.Drawing.Size(254, 34)
        Me.UProductPriceTextBox.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(269, 277)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 28)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Supplier"
        '
        'UProductSupplierComboBox
        '
        Me.UProductSupplierComboBox.FormattingEnabled = True
        Me.UProductSupplierComboBox.Location = New System.Drawing.Point(436, 274)
        Me.UProductSupplierComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.UProductSupplierComboBox.Name = "UProductSupplierComboBox"
        Me.UProductSupplierComboBox.Size = New System.Drawing.Size(254, 36)
        Me.UProductSupplierComboBox.TabIndex = 55
        '
        'UpdateProductBtn
        '
        Me.UpdateProductBtn.Location = New System.Drawing.Point(274, 339)
        Me.UpdateProductBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.UpdateProductBtn.Name = "UpdateProductBtn"
        Me.UpdateProductBtn.Size = New System.Drawing.Size(416, 43)
        Me.UpdateProductBtn.TabIndex = 54
        Me.UpdateProductBtn.Text = "Update Product"
        Me.UpdateProductBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(269, 75)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(105, 28)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Product ID"
        '
        'UProductIDComboBox
        '
        Me.UProductIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UProductIDComboBox.FormattingEnabled = True
        Me.UProductIDComboBox.Location = New System.Drawing.Point(436, 72)
        Me.UProductIDComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.UProductIDComboBox.Name = "UProductIDComboBox"
        Me.UProductIDComboBox.Size = New System.Drawing.Size(254, 36)
        Me.UProductIDComboBox.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(269, 227)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 28)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(269, 177)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 28)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Description"
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
        'UProductNameTextBox
        '
        Me.UProductNameTextBox.Location = New System.Drawing.Point(436, 124)
        Me.UProductNameTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.UProductNameTextBox.Name = "UProductNameTextBox"
        Me.UProductNameTextBox.Size = New System.Drawing.Size(254, 34)
        Me.UProductNameTextBox.TabIndex = 42
        '
        'ProductDeletePanel
        '
        Me.ProductDeletePanel.BackColor = System.Drawing.SystemColors.Control
        Me.ProductDeletePanel.Controls.Add(Me.DProductDescTextBox)
        Me.ProductDeletePanel.Controls.Add(Me.DProductPriceTextBox)
        Me.ProductDeletePanel.Controls.Add(Me.Label6)
        Me.ProductDeletePanel.Controls.Add(Me.DProductSupplierComboBox)
        Me.ProductDeletePanel.Controls.Add(Me.DeleteProductBtn)
        Me.ProductDeletePanel.Controls.Add(Me.Label7)
        Me.ProductDeletePanel.Controls.Add(Me.DProductIDComboBox)
        Me.ProductDeletePanel.Controls.Add(Me.Label8)
        Me.ProductDeletePanel.Controls.Add(Me.Label9)
        Me.ProductDeletePanel.Controls.Add(Me.Label10)
        Me.ProductDeletePanel.Controls.Add(Me.DProductNameTextBox)
        Me.ProductDeletePanel.Location = New System.Drawing.Point(0, 48)
        Me.ProductDeletePanel.Name = "ProductDeletePanel"
        Me.ProductDeletePanel.Size = New System.Drawing.Size(959, 515)
        Me.ProductDeletePanel.TabIndex = 12
        '
        'DProductDescTextBox
        '
        Me.DProductDescTextBox.Enabled = False
        Me.DProductDescTextBox.Location = New System.Drawing.Point(436, 174)
        Me.DProductDescTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.DProductDescTextBox.Name = "DProductDescTextBox"
        Me.DProductDescTextBox.Size = New System.Drawing.Size(254, 34)
        Me.DProductDescTextBox.TabIndex = 59
        '
        'DProductPriceTextBox
        '
        Me.DProductPriceTextBox.Enabled = False
        Me.DProductPriceTextBox.Location = New System.Drawing.Point(436, 224)
        Me.DProductPriceTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.DProductPriceTextBox.Name = "DProductPriceTextBox"
        Me.DProductPriceTextBox.Size = New System.Drawing.Size(254, 34)
        Me.DProductPriceTextBox.TabIndex = 58
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(269, 277)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 28)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Supplier"
        '
        'DProductSupplierComboBox
        '
        Me.DProductSupplierComboBox.Enabled = False
        Me.DProductSupplierComboBox.FormattingEnabled = True
        Me.DProductSupplierComboBox.Location = New System.Drawing.Point(436, 274)
        Me.DProductSupplierComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DProductSupplierComboBox.Name = "DProductSupplierComboBox"
        Me.DProductSupplierComboBox.Size = New System.Drawing.Size(254, 36)
        Me.DProductSupplierComboBox.TabIndex = 55
        '
        'DeleteProductBtn
        '
        Me.DeleteProductBtn.Location = New System.Drawing.Point(274, 339)
        Me.DeleteProductBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.DeleteProductBtn.Name = "DeleteProductBtn"
        Me.DeleteProductBtn.Size = New System.Drawing.Size(416, 43)
        Me.DeleteProductBtn.TabIndex = 54
        Me.DeleteProductBtn.Text = "Delete Product"
        Me.DeleteProductBtn.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(269, 75)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(105, 28)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Product ID"
        '
        'DProductIDComboBox
        '
        Me.DProductIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DProductIDComboBox.FormattingEnabled = True
        Me.DProductIDComboBox.Location = New System.Drawing.Point(436, 72)
        Me.DProductIDComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DProductIDComboBox.Name = "DProductIDComboBox"
        Me.DProductIDComboBox.Size = New System.Drawing.Size(254, 36)
        Me.DProductIDComboBox.TabIndex = 43
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(269, 227)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 28)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Price"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(269, 177)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 28)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Description"
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
        'DProductNameTextBox
        '
        Me.DProductNameTextBox.Enabled = False
        Me.DProductNameTextBox.Location = New System.Drawing.Point(436, 124)
        Me.DProductNameTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.DProductNameTextBox.Name = "DProductNameTextBox"
        Me.DProductNameTextBox.Size = New System.Drawing.Size(254, 34)
        Me.DProductNameTextBox.TabIndex = 42
        '
        'ExportBtn
        '
        Me.ExportBtn.Location = New System.Drawing.Point(17, 457)
        Me.ExportBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.ExportBtn.Name = "ExportBtn"
        Me.ExportBtn.Size = New System.Drawing.Size(925, 43)
        Me.ExportBtn.TabIndex = 56
        Me.ExportBtn.Text = "Export to Excel"
        Me.ExportBtn.UseVisualStyleBackColor = True
        '
        'ProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 563)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ProductViewPanel)
        Me.Controls.Add(Me.ProductDeletePanel)
        Me.Controls.Add(Me.ProductUpdatePanel)
        Me.Controls.Add(Me.ProductAddPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ProductForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ProductViewPanel.ResumeLayout(False)
        CType(Me.ProductDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductAddPanel.ResumeLayout(False)
        Me.ProductAddPanel.PerformLayout()
        Me.ProductUpdatePanel.ResumeLayout(False)
        Me.ProductUpdatePanel.PerformLayout()
        Me.ProductDeletePanel.ResumeLayout(False)
        Me.ProductDeletePanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ProductTitleLabel As System.Windows.Forms.Label
    Friend WithEvents ProductViewPanel As System.Windows.Forms.Panel
    Friend WithEvents ProductDGV As System.Windows.Forms.DataGridView
    Friend WithEvents ProductAddPanel As System.Windows.Forms.Panel
    Friend WithEvents ProductDescTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProductPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProductSupplierLabel As System.Windows.Forms.Label
    Friend WithEvents ProductSupplierComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ProductAddButton As System.Windows.Forms.Button
    Friend WithEvents ProductIDLabel As System.Windows.Forms.Label
    Friend WithEvents ProductIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ProductPriceLabel As System.Windows.Forms.Label
    Friend WithEvents ProductDescLabel As System.Windows.Forms.Label
    Friend WithEvents IngredientNameLabel As System.Windows.Forms.Label
    Friend WithEvents ProductClearButton As System.Windows.Forms.Button
    Friend WithEvents ProductNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProductUpdatePanel As System.Windows.Forms.Panel
    Friend WithEvents UProductDescTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UpdateProductBtn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents UProductIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents UClearBtn As System.Windows.Forms.Button
    Friend WithEvents UProductNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProductDeletePanel As System.Windows.Forms.Panel
    Friend WithEvents DProductDescTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DProductPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DProductSupplierComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DeleteProductBtn As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DProductIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DProductNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UProductPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UProductSupplierComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ExportBtn As System.Windows.Forms.Button
End Class
