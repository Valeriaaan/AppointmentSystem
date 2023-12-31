<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppointmentForm
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
        Me.AppointmentTitleLabel = New System.Windows.Forms.Label()
        Me.SetAppointmentPanel = New System.Windows.Forms.Panel()
        Me.SCustomerIDComboBox = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SAppointmentDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SEmployeeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SCustomerPhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.SCustomerAddressTextBox = New System.Windows.Forms.TextBox()
        Me.SetAppointmentBtn = New System.Windows.Forms.Button()
        Me.ProductPriceLabel = New System.Windows.Forms.Label()
        Me.ProductDescLabel = New System.Windows.Forms.Label()
        Me.IngredientNameLabel = New System.Windows.Forms.Label()
        Me.SClearBtn = New System.Windows.Forms.Button()
        Me.SCustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.UpdateAppointmentPanel = New System.Windows.Forms.Panel()
        Me.UCustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.UAppointmentIDComboBox = New System.Windows.Forms.ComboBox()
        Me.UAppointmentDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UEmployeeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.UCustomerPhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.UCustomerAddressTextBox = New System.Windows.Forms.TextBox()
        Me.UpdateAppointmentBtn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.UClearBtn = New System.Windows.Forms.Button()
        Me.CancelAppointmentPanel = New System.Windows.Forms.Panel()
        Me.CEmployeeTextBox = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.CCustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.CAppointmentDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CAppointmentIDComboBox = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CCustomerPhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.CCustomerAddressTextBox = New System.Windows.Forms.TextBox()
        Me.CancelAppointmentBtn = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.UCustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SetAppointmentPanel.SuspendLayout()
        Me.UpdateAppointmentPanel.SuspendLayout()
        Me.CancelAppointmentPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.AppointmentTitleLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(959, 51)
        Me.Panel1.TabIndex = 10
        '
        'AppointmentTitleLabel
        '
        Me.AppointmentTitleLabel.AutoSize = True
        Me.AppointmentTitleLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.AppointmentTitleLabel.Font = New System.Drawing.Font("Segoe UI Black", 16.0!, System.Drawing.FontStyle.Bold)
        Me.AppointmentTitleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.AppointmentTitleLabel.Location = New System.Drawing.Point(18, 9)
        Me.AppointmentTitleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AppointmentTitleLabel.Name = "AppointmentTitleLabel"
        Me.AppointmentTitleLabel.Size = New System.Drawing.Size(193, 37)
        Me.AppointmentTitleLabel.TabIndex = 14
        Me.AppointmentTitleLabel.Text = "Appointment"
        '
        'SetAppointmentPanel
        '
        Me.SetAppointmentPanel.AutoScroll = True
        Me.SetAppointmentPanel.BackColor = System.Drawing.SystemColors.Control
        Me.SetAppointmentPanel.Controls.Add(Me.SCustomerIDComboBox)
        Me.SetAppointmentPanel.Controls.Add(Me.Panel2)
        Me.SetAppointmentPanel.Controls.Add(Me.SAppointmentDatePicker)
        Me.SetAppointmentPanel.Controls.Add(Me.Label16)
        Me.SetAppointmentPanel.Controls.Add(Me.Label17)
        Me.SetAppointmentPanel.Controls.Add(Me.Label4)
        Me.SetAppointmentPanel.Controls.Add(Me.SEmployeeComboBox)
        Me.SetAppointmentPanel.Controls.Add(Me.Label1)
        Me.SetAppointmentPanel.Controls.Add(Me.Label2)
        Me.SetAppointmentPanel.Controls.Add(Me.SCustomerPhoneNumberTextBox)
        Me.SetAppointmentPanel.Controls.Add(Me.SCustomerAddressTextBox)
        Me.SetAppointmentPanel.Controls.Add(Me.SetAppointmentBtn)
        Me.SetAppointmentPanel.Controls.Add(Me.ProductPriceLabel)
        Me.SetAppointmentPanel.Controls.Add(Me.ProductDescLabel)
        Me.SetAppointmentPanel.Controls.Add(Me.IngredientNameLabel)
        Me.SetAppointmentPanel.Controls.Add(Me.SClearBtn)
        Me.SetAppointmentPanel.Controls.Add(Me.SCustomerNameTextBox)
        Me.SetAppointmentPanel.Location = New System.Drawing.Point(0, 51)
        Me.SetAppointmentPanel.Name = "SetAppointmentPanel"
        Me.SetAppointmentPanel.Size = New System.Drawing.Size(959, 515)
        Me.SetAppointmentPanel.TabIndex = 12
        '
        'SCustomerIDComboBox
        '
        Me.SCustomerIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SCustomerIDComboBox.Enabled = False
        Me.SCustomerIDComboBox.FormattingEnabled = True
        Me.SCustomerIDComboBox.Location = New System.Drawing.Point(436, 38)
        Me.SCustomerIDComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SCustomerIDComboBox.Name = "SCustomerIDComboBox"
        Me.SCustomerIDComboBox.Size = New System.Drawing.Size(254, 36)
        Me.SCustomerIDComboBox.TabIndex = 84
        Me.SCustomerIDComboBox.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 587)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(938, 45)
        Me.Panel2.TabIndex = 83
        '
        'SAppointmentDatePicker
        '
        Me.SAppointmentDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.SAppointmentDatePicker.Location = New System.Drawing.Point(436, 296)
        Me.SAppointmentDatePicker.Name = "SAppointmentDatePicker"
        Me.SAppointmentDatePicker.Size = New System.Drawing.Size(254, 34)
        Me.SAppointmentDatePicker.TabIndex = 82
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(208, 254)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(200, 28)
        Me.Label16.TabIndex = 81
        Me.Label16.Text = "Appointment Details"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(269, 301)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 28)
        Me.Label17.TabIndex = 80
        Me.Label17.Text = "Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(269, 422)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(155, 28)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Employee Name"
        '
        'SEmployeeComboBox
        '
        Me.SEmployeeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SEmployeeComboBox.FormattingEnabled = True
        Me.SEmployeeComboBox.Location = New System.Drawing.Point(436, 419)
        Me.SEmployeeComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SEmployeeComboBox.Name = "SEmployeeComboBox"
        Me.SEmployeeComboBox.Size = New System.Drawing.Size(254, 36)
        Me.SEmployeeComboBox.TabIndex = 76
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(208, 362)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 28)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Assigned Employee"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(208, 41)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 28)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Customer Info"
        '
        'SCustomerPhoneNumberTextBox
        '
        Me.SCustomerPhoneNumberTextBox.Location = New System.Drawing.Point(436, 131)
        Me.SCustomerPhoneNumberTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.SCustomerPhoneNumberTextBox.Name = "SCustomerPhoneNumberTextBox"
        Me.SCustomerPhoneNumberTextBox.Size = New System.Drawing.Size(254, 34)
        Me.SCustomerPhoneNumberTextBox.TabIndex = 59
        '
        'SCustomerAddressTextBox
        '
        Me.SCustomerAddressTextBox.Location = New System.Drawing.Point(436, 185)
        Me.SCustomerAddressTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.SCustomerAddressTextBox.Name = "SCustomerAddressTextBox"
        Me.SCustomerAddressTextBox.Size = New System.Drawing.Size(254, 34)
        Me.SCustomerAddressTextBox.TabIndex = 58
        '
        'SetAppointmentBtn
        '
        Me.SetAppointmentBtn.Location = New System.Drawing.Point(274, 488)
        Me.SetAppointmentBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.SetAppointmentBtn.Name = "SetAppointmentBtn"
        Me.SetAppointmentBtn.Size = New System.Drawing.Size(416, 43)
        Me.SetAppointmentBtn.TabIndex = 54
        Me.SetAppointmentBtn.Text = "Set Appointment"
        Me.SetAppointmentBtn.UseVisualStyleBackColor = True
        '
        'ProductPriceLabel
        '
        Me.ProductPriceLabel.AutoSize = True
        Me.ProductPriceLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ProductPriceLabel.Location = New System.Drawing.Point(269, 188)
        Me.ProductPriceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ProductPriceLabel.Name = "ProductPriceLabel"
        Me.ProductPriceLabel.Size = New System.Drawing.Size(82, 28)
        Me.ProductPriceLabel.TabIndex = 49
        Me.ProductPriceLabel.Text = "Address"
        '
        'ProductDescLabel
        '
        Me.ProductDescLabel.AutoSize = True
        Me.ProductDescLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ProductDescLabel.Location = New System.Drawing.Point(269, 138)
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
        Me.IngredientNameLabel.Location = New System.Drawing.Point(269, 88)
        Me.IngredientNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IngredientNameLabel.Name = "IngredientNameLabel"
        Me.IngredientNameLabel.Size = New System.Drawing.Size(64, 28)
        Me.IngredientNameLabel.TabIndex = 45
        Me.IngredientNameLabel.Text = "Name"
        '
        'SClearBtn
        '
        Me.SClearBtn.Location = New System.Drawing.Point(274, 544)
        Me.SClearBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.SClearBtn.Name = "SClearBtn"
        Me.SClearBtn.Size = New System.Drawing.Size(416, 43)
        Me.SClearBtn.TabIndex = 44
        Me.SClearBtn.Text = "Clear Form"
        Me.SClearBtn.UseVisualStyleBackColor = True
        '
        'SCustomerNameTextBox
        '
        Me.SCustomerNameTextBox.Location = New System.Drawing.Point(436, 85)
        Me.SCustomerNameTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.SCustomerNameTextBox.Name = "SCustomerNameTextBox"
        Me.SCustomerNameTextBox.Size = New System.Drawing.Size(254, 34)
        Me.SCustomerNameTextBox.TabIndex = 42
        '
        'UpdateAppointmentPanel
        '
        Me.UpdateAppointmentPanel.AutoScroll = True
        Me.UpdateAppointmentPanel.BackColor = System.Drawing.SystemColors.Control
        Me.UpdateAppointmentPanel.Controls.Add(Me.UCustomerIDTextBox)
        Me.UpdateAppointmentPanel.Controls.Add(Me.UCustomerNameTextBox)
        Me.UpdateAppointmentPanel.Controls.Add(Me.Label23)
        Me.UpdateAppointmentPanel.Controls.Add(Me.UAppointmentIDComboBox)
        Me.UpdateAppointmentPanel.Controls.Add(Me.UAppointmentDatePicker)
        Me.UpdateAppointmentPanel.Controls.Add(Me.Label20)
        Me.UpdateAppointmentPanel.Controls.Add(Me.Label21)
        Me.UpdateAppointmentPanel.Controls.Add(Me.Panel4)
        Me.UpdateAppointmentPanel.Controls.Add(Me.Label3)
        Me.UpdateAppointmentPanel.Controls.Add(Me.UEmployeeComboBox)
        Me.UpdateAppointmentPanel.Controls.Add(Me.Label5)
        Me.UpdateAppointmentPanel.Controls.Add(Me.Label6)
        Me.UpdateAppointmentPanel.Controls.Add(Me.UCustomerPhoneNumberTextBox)
        Me.UpdateAppointmentPanel.Controls.Add(Me.UCustomerAddressTextBox)
        Me.UpdateAppointmentPanel.Controls.Add(Me.UpdateAppointmentBtn)
        Me.UpdateAppointmentPanel.Controls.Add(Me.Label7)
        Me.UpdateAppointmentPanel.Controls.Add(Me.Label8)
        Me.UpdateAppointmentPanel.Controls.Add(Me.Label9)
        Me.UpdateAppointmentPanel.Controls.Add(Me.UClearBtn)
        Me.UpdateAppointmentPanel.Location = New System.Drawing.Point(0, 51)
        Me.UpdateAppointmentPanel.Name = "UpdateAppointmentPanel"
        Me.UpdateAppointmentPanel.Size = New System.Drawing.Size(959, 515)
        Me.UpdateAppointmentPanel.TabIndex = 13
        '
        'UCustomerNameTextBox
        '
        Me.UCustomerNameTextBox.Location = New System.Drawing.Point(436, 251)
        Me.UCustomerNameTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.UCustomerNameTextBox.Name = "UCustomerNameTextBox"
        Me.UCustomerNameTextBox.Size = New System.Drawing.Size(254, 34)
        Me.UCustomerNameTextBox.TabIndex = 92
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(269, 91)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(153, 28)
        Me.Label23.TabIndex = 91
        Me.Label23.Text = "Appointment ID"
        '
        'UAppointmentIDComboBox
        '
        Me.UAppointmentIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UAppointmentIDComboBox.FormattingEnabled = True
        Me.UAppointmentIDComboBox.Location = New System.Drawing.Point(436, 88)
        Me.UAppointmentIDComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.UAppointmentIDComboBox.Name = "UAppointmentIDComboBox"
        Me.UAppointmentIDComboBox.Size = New System.Drawing.Size(254, 36)
        Me.UAppointmentIDComboBox.TabIndex = 90
        '
        'UAppointmentDatePicker
        '
        Me.UAppointmentDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.UAppointmentDatePicker.Location = New System.Drawing.Point(436, 141)
        Me.UAppointmentDatePicker.Name = "UAppointmentDatePicker"
        Me.UAppointmentDatePicker.Size = New System.Drawing.Size(254, 34)
        Me.UAppointmentDatePicker.TabIndex = 87
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(208, 44)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(200, 28)
        Me.Label20.TabIndex = 86
        Me.Label20.Text = "Appointment Details"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(269, 146)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(53, 28)
        Me.Label21.TabIndex = 85
        Me.Label21.Text = "Date"
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 639)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(938, 45)
        Me.Panel4.TabIndex = 84
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(269, 474)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(122, 28)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Employee ID"
        '
        'UEmployeeComboBox
        '
        Me.UEmployeeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UEmployeeComboBox.FormattingEnabled = True
        Me.UEmployeeComboBox.Location = New System.Drawing.Point(436, 471)
        Me.UEmployeeComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.UEmployeeComboBox.Name = "UEmployeeComboBox"
        Me.UEmployeeComboBox.Size = New System.Drawing.Size(254, 36)
        Me.UEmployeeComboBox.TabIndex = 76
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(208, 414)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(190, 28)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Assigned Employee"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(208, 207)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 28)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Customer Info"
        '
        'UCustomerPhoneNumberTextBox
        '
        Me.UCustomerPhoneNumberTextBox.Location = New System.Drawing.Point(436, 301)
        Me.UCustomerPhoneNumberTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.UCustomerPhoneNumberTextBox.Name = "UCustomerPhoneNumberTextBox"
        Me.UCustomerPhoneNumberTextBox.Size = New System.Drawing.Size(254, 34)
        Me.UCustomerPhoneNumberTextBox.TabIndex = 59
        '
        'UCustomerAddressTextBox
        '
        Me.UCustomerAddressTextBox.Location = New System.Drawing.Point(436, 351)
        Me.UCustomerAddressTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.UCustomerAddressTextBox.Name = "UCustomerAddressTextBox"
        Me.UCustomerAddressTextBox.Size = New System.Drawing.Size(254, 34)
        Me.UCustomerAddressTextBox.TabIndex = 58
        '
        'UpdateAppointmentBtn
        '
        Me.UpdateAppointmentBtn.Location = New System.Drawing.Point(274, 540)
        Me.UpdateAppointmentBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.UpdateAppointmentBtn.Name = "UpdateAppointmentBtn"
        Me.UpdateAppointmentBtn.Size = New System.Drawing.Size(416, 43)
        Me.UpdateAppointmentBtn.TabIndex = 54
        Me.UpdateAppointmentBtn.Text = "Update Appointment"
        Me.UpdateAppointmentBtn.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(269, 354)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 28)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(269, 304)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 28)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Phone Number"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(269, 254)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 28)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Name"
        '
        'UClearBtn
        '
        Me.UClearBtn.Location = New System.Drawing.Point(274, 596)
        Me.UClearBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.UClearBtn.Name = "UClearBtn"
        Me.UClearBtn.Size = New System.Drawing.Size(416, 43)
        Me.UClearBtn.TabIndex = 44
        Me.UClearBtn.Text = "Clear Form"
        Me.UClearBtn.UseVisualStyleBackColor = True
        '
        'CancelAppointmentPanel
        '
        Me.CancelAppointmentPanel.AutoScroll = True
        Me.CancelAppointmentPanel.BackColor = System.Drawing.SystemColors.Control
        Me.CancelAppointmentPanel.Controls.Add(Me.CEmployeeTextBox)
        Me.CancelAppointmentPanel.Controls.Add(Me.Label22)
        Me.CancelAppointmentPanel.Controls.Add(Me.CCustomerNameTextBox)
        Me.CancelAppointmentPanel.Controls.Add(Me.CAppointmentDatePicker)
        Me.CancelAppointmentPanel.Controls.Add(Me.Label18)
        Me.CancelAppointmentPanel.Controls.Add(Me.Label19)
        Me.CancelAppointmentPanel.Controls.Add(Me.Panel3)
        Me.CancelAppointmentPanel.Controls.Add(Me.CAppointmentIDComboBox)
        Me.CancelAppointmentPanel.Controls.Add(Me.Label10)
        Me.CancelAppointmentPanel.Controls.Add(Me.Label11)
        Me.CancelAppointmentPanel.Controls.Add(Me.Label12)
        Me.CancelAppointmentPanel.Controls.Add(Me.CCustomerPhoneNumberTextBox)
        Me.CancelAppointmentPanel.Controls.Add(Me.CCustomerAddressTextBox)
        Me.CancelAppointmentPanel.Controls.Add(Me.CancelAppointmentBtn)
        Me.CancelAppointmentPanel.Controls.Add(Me.Label13)
        Me.CancelAppointmentPanel.Controls.Add(Me.Label14)
        Me.CancelAppointmentPanel.Controls.Add(Me.Label15)
        Me.CancelAppointmentPanel.Location = New System.Drawing.Point(0, 51)
        Me.CancelAppointmentPanel.Name = "CancelAppointmentPanel"
        Me.CancelAppointmentPanel.Size = New System.Drawing.Size(959, 515)
        Me.CancelAppointmentPanel.TabIndex = 14
        '
        'CEmployeeTextBox
        '
        Me.CEmployeeTextBox.Enabled = False
        Me.CEmployeeTextBox.Location = New System.Drawing.Point(436, 506)
        Me.CEmployeeTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.CEmployeeTextBox.Name = "CEmployeeTextBox"
        Me.CEmployeeTextBox.Size = New System.Drawing.Size(254, 34)
        Me.CEmployeeTextBox.TabIndex = 90
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(269, 113)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(153, 28)
        Me.Label22.TabIndex = 89
        Me.Label22.Text = "Appointment ID"
        '
        'CCustomerNameTextBox
        '
        Me.CCustomerNameTextBox.Enabled = False
        Me.CCustomerNameTextBox.Location = New System.Drawing.Point(436, 273)
        Me.CCustomerNameTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.CCustomerNameTextBox.Name = "CCustomerNameTextBox"
        Me.CCustomerNameTextBox.Size = New System.Drawing.Size(254, 34)
        Me.CCustomerNameTextBox.TabIndex = 88
        '
        'CAppointmentDatePicker
        '
        Me.CAppointmentDatePicker.Enabled = False
        Me.CAppointmentDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.CAppointmentDatePicker.Location = New System.Drawing.Point(436, 159)
        Me.CAppointmentDatePicker.Name = "CAppointmentDatePicker"
        Me.CAppointmentDatePicker.Size = New System.Drawing.Size(254, 34)
        Me.CAppointmentDatePicker.TabIndex = 87
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(208, 57)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(200, 28)
        Me.Label18.TabIndex = 86
        Me.Label18.Text = "Appointment Details"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(269, 164)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(53, 28)
        Me.Label19.TabIndex = 85
        Me.Label19.Text = "Date"
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 618)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(938, 45)
        Me.Panel3.TabIndex = 84
        '
        'CAppointmentIDComboBox
        '
        Me.CAppointmentIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CAppointmentIDComboBox.FormattingEnabled = True
        Me.CAppointmentIDComboBox.Location = New System.Drawing.Point(436, 110)
        Me.CAppointmentIDComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CAppointmentIDComboBox.Name = "CAppointmentIDComboBox"
        Me.CAppointmentIDComboBox.Size = New System.Drawing.Size(254, 36)
        Me.CAppointmentIDComboBox.TabIndex = 79
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(269, 509)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(155, 28)
        Me.Label10.TabIndex = 78
        Me.Label10.Text = "Employee Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(208, 449)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(190, 28)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "Assigned Employee"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(208, 229)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(143, 28)
        Me.Label12.TabIndex = 73
        Me.Label12.Text = "Customer Info"
        '
        'CCustomerPhoneNumberTextBox
        '
        Me.CCustomerPhoneNumberTextBox.Enabled = False
        Me.CCustomerPhoneNumberTextBox.Location = New System.Drawing.Point(436, 319)
        Me.CCustomerPhoneNumberTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.CCustomerPhoneNumberTextBox.Name = "CCustomerPhoneNumberTextBox"
        Me.CCustomerPhoneNumberTextBox.Size = New System.Drawing.Size(254, 34)
        Me.CCustomerPhoneNumberTextBox.TabIndex = 59
        '
        'CCustomerAddressTextBox
        '
        Me.CCustomerAddressTextBox.Enabled = False
        Me.CCustomerAddressTextBox.Location = New System.Drawing.Point(436, 373)
        Me.CCustomerAddressTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.CCustomerAddressTextBox.Name = "CCustomerAddressTextBox"
        Me.CCustomerAddressTextBox.Size = New System.Drawing.Size(254, 34)
        Me.CCustomerAddressTextBox.TabIndex = 58
        '
        'CancelAppointmentBtn
        '
        Me.CancelAppointmentBtn.Location = New System.Drawing.Point(274, 575)
        Me.CancelAppointmentBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.CancelAppointmentBtn.Name = "CancelAppointmentBtn"
        Me.CancelAppointmentBtn.Size = New System.Drawing.Size(416, 43)
        Me.CancelAppointmentBtn.TabIndex = 54
        Me.CancelAppointmentBtn.Text = "Cancel Appointment"
        Me.CancelAppointmentBtn.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(269, 376)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 28)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "Address"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(269, 326)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(144, 28)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "Phone Number"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(269, 276)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 28)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "Name"
        '
        'UCustomerIDTextBox
        '
        Me.UCustomerIDTextBox.Enabled = False
        Me.UCustomerIDTextBox.Location = New System.Drawing.Point(436, 205)
        Me.UCustomerIDTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.UCustomerIDTextBox.Name = "UCustomerIDTextBox"
        Me.UCustomerIDTextBox.Size = New System.Drawing.Size(254, 34)
        Me.UCustomerIDTextBox.TabIndex = 94
        Me.UCustomerIDTextBox.Visible = False
        '
        'AppointmentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 563)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UpdateAppointmentPanel)
        Me.Controls.Add(Me.SetAppointmentPanel)
        Me.Controls.Add(Me.CancelAppointmentPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "AppointmentForm"
        Me.Text = "AppointmentForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SetAppointmentPanel.ResumeLayout(False)
        Me.SetAppointmentPanel.PerformLayout()
        Me.UpdateAppointmentPanel.ResumeLayout(False)
        Me.UpdateAppointmentPanel.PerformLayout()
        Me.CancelAppointmentPanel.ResumeLayout(False)
        Me.CancelAppointmentPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents AppointmentTitleLabel As System.Windows.Forms.Label
    Friend WithEvents SetAppointmentPanel As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SEmployeeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SCustomerPhoneNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SCustomerAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SetAppointmentBtn As System.Windows.Forms.Button
    Friend WithEvents ProductPriceLabel As System.Windows.Forms.Label
    Friend WithEvents ProductDescLabel As System.Windows.Forms.Label
    Friend WithEvents IngredientNameLabel As System.Windows.Forms.Label
    Friend WithEvents SClearBtn As System.Windows.Forms.Button
    Friend WithEvents SCustomerNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UpdateAppointmentPanel As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents UEmployeeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents UCustomerPhoneNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UCustomerAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UpdateAppointmentBtn As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents UClearBtn As System.Windows.Forms.Button
    Friend WithEvents CancelAppointmentPanel As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CCustomerPhoneNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CCustomerAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CancelAppointmentBtn As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents CAppointmentIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents SAppointmentDatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents UAppointmentDatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents CAppointmentDatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents SCustomerIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CCustomerNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents CEmployeeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents UAppointmentIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents UCustomerNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UCustomerIDTextBox As System.Windows.Forms.TextBox
End Class
