<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupplierForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SupplierTitleLabel = New System.Windows.Forms.Label()
        Me.SupplierDeletePanel = New System.Windows.Forms.Panel()
        Me.DSupplierEmailTextBox = New System.Windows.Forms.TextBox()
        Me.DeleteSupplierBtn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DSupplierIDComboBox = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DSupplierNameTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierViewPanel = New System.Windows.Forms.Panel()
        Me.ExportBtn = New System.Windows.Forms.Button()
        Me.SupplierDGV = New System.Windows.Forms.DataGridView()
        Me.SupplierUpdatePanel = New System.Windows.Forms.Panel()
        Me.USupplierEmailTextBox = New System.Windows.Forms.TextBox()
        Me.UpdateSupplierBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.USupplierIDComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.UClearBtn = New System.Windows.Forms.Button()
        Me.USupplierNameTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierAddPanel = New System.Windows.Forms.Panel()
        Me.ASupplierEmailTextBox = New System.Windows.Forms.TextBox()
        Me.AddSupplierBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ASupplierIDComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AClearBtn = New System.Windows.Forms.Button()
        Me.ASupplierNameTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SupplierDeletePanel.SuspendLayout()
        Me.SupplierViewPanel.SuspendLayout()
        CType(Me.SupplierDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SupplierUpdatePanel.SuspendLayout()
        Me.SupplierAddPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.SupplierTitleLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(959, 51)
        Me.Panel1.TabIndex = 8
        '
        'SupplierTitleLabel
        '
        Me.SupplierTitleLabel.AutoSize = True
        Me.SupplierTitleLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.SupplierTitleLabel.Font = New System.Drawing.Font("Segoe UI Black", 16.0!, System.Drawing.FontStyle.Bold)
        Me.SupplierTitleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.SupplierTitleLabel.Location = New System.Drawing.Point(18, 9)
        Me.SupplierTitleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SupplierTitleLabel.Name = "SupplierTitleLabel"
        Me.SupplierTitleLabel.Size = New System.Drawing.Size(139, 37)
        Me.SupplierTitleLabel.TabIndex = 14
        Me.SupplierTitleLabel.Text = "Suppliers"
        '
        'SupplierDeletePanel
        '
        Me.SupplierDeletePanel.BackColor = System.Drawing.SystemColors.Control
        Me.SupplierDeletePanel.Controls.Add(Me.DSupplierEmailTextBox)
        Me.SupplierDeletePanel.Controls.Add(Me.DeleteSupplierBtn)
        Me.SupplierDeletePanel.Controls.Add(Me.Label7)
        Me.SupplierDeletePanel.Controls.Add(Me.DSupplierIDComboBox)
        Me.SupplierDeletePanel.Controls.Add(Me.Label9)
        Me.SupplierDeletePanel.Controls.Add(Me.Label10)
        Me.SupplierDeletePanel.Controls.Add(Me.DSupplierNameTextBox)
        Me.SupplierDeletePanel.Location = New System.Drawing.Point(0, 51)
        Me.SupplierDeletePanel.Name = "SupplierDeletePanel"
        Me.SupplierDeletePanel.Size = New System.Drawing.Size(925, 432)
        Me.SupplierDeletePanel.TabIndex = 13
        '
        'DSupplierEmailTextBox
        '
        Me.DSupplierEmailTextBox.Enabled = False
        Me.DSupplierEmailTextBox.Location = New System.Drawing.Point(436, 260)
        Me.DSupplierEmailTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.DSupplierEmailTextBox.Name = "DSupplierEmailTextBox"
        Me.DSupplierEmailTextBox.Size = New System.Drawing.Size(254, 34)
        Me.DSupplierEmailTextBox.TabIndex = 59
        '
        'DeleteSupplierBtn
        '
        Me.DeleteSupplierBtn.Location = New System.Drawing.Point(274, 313)
        Me.DeleteSupplierBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.DeleteSupplierBtn.Name = "DeleteSupplierBtn"
        Me.DeleteSupplierBtn.Size = New System.Drawing.Size(416, 43)
        Me.DeleteSupplierBtn.TabIndex = 54
        Me.DeleteSupplierBtn.Text = "Delete Supplier"
        Me.DeleteSupplierBtn.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(269, 161)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(109, 28)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Supplier ID"
        '
        'DSupplierIDComboBox
        '
        Me.DSupplierIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DSupplierIDComboBox.FormattingEnabled = True
        Me.DSupplierIDComboBox.Location = New System.Drawing.Point(436, 158)
        Me.DSupplierIDComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DSupplierIDComboBox.Name = "DSupplierIDComboBox"
        Me.DSupplierIDComboBox.Size = New System.Drawing.Size(254, 36)
        Me.DSupplierIDComboBox.TabIndex = 43
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(269, 263)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 28)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Email"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(269, 213)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 28)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Name"
        '
        'DSupplierNameTextBox
        '
        Me.DSupplierNameTextBox.Enabled = False
        Me.DSupplierNameTextBox.Location = New System.Drawing.Point(436, 210)
        Me.DSupplierNameTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.DSupplierNameTextBox.Name = "DSupplierNameTextBox"
        Me.DSupplierNameTextBox.Size = New System.Drawing.Size(254, 34)
        Me.DSupplierNameTextBox.TabIndex = 42
        '
        'SupplierViewPanel
        '
        Me.SupplierViewPanel.BackColor = System.Drawing.SystemColors.Control
        Me.SupplierViewPanel.Controls.Add(Me.ExportBtn)
        Me.SupplierViewPanel.Controls.Add(Me.SupplierDGV)
        Me.SupplierViewPanel.Location = New System.Drawing.Point(0, 49)
        Me.SupplierViewPanel.Name = "SupplierViewPanel"
        Me.SupplierViewPanel.Size = New System.Drawing.Size(959, 515)
        Me.SupplierViewPanel.TabIndex = 14
        '
        'ExportBtn
        '
        Me.ExportBtn.Location = New System.Drawing.Point(17, 458)
        Me.ExportBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.ExportBtn.Name = "ExportBtn"
        Me.ExportBtn.Size = New System.Drawing.Size(925, 43)
        Me.ExportBtn.TabIndex = 57
        Me.ExportBtn.Text = "Export to Excel"
        Me.ExportBtn.UseVisualStyleBackColor = True
        '
        'SupplierDGV
        '
        Me.SupplierDGV.AllowUserToAddRows = False
        Me.SupplierDGV.AllowUserToDeleteRows = False
        Me.SupplierDGV.AllowUserToResizeColumns = False
        Me.SupplierDGV.AllowUserToResizeRows = False
        Me.SupplierDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SupplierDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.SupplierDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SupplierDGV.Location = New System.Drawing.Point(17, 11)
        Me.SupplierDGV.Margin = New System.Windows.Forms.Padding(4)
        Me.SupplierDGV.Name = "SupplierDGV"
        Me.SupplierDGV.ReadOnly = True
        Me.SupplierDGV.RowHeadersWidth = 21
        Me.SupplierDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SupplierDGV.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.SupplierDGV.RowTemplate.Height = 24
        Me.SupplierDGV.Size = New System.Drawing.Size(925, 432)
        Me.SupplierDGV.TabIndex = 40
        '
        'SupplierUpdatePanel
        '
        Me.SupplierUpdatePanel.BackColor = System.Drawing.SystemColors.Control
        Me.SupplierUpdatePanel.Controls.Add(Me.USupplierEmailTextBox)
        Me.SupplierUpdatePanel.Controls.Add(Me.UpdateSupplierBtn)
        Me.SupplierUpdatePanel.Controls.Add(Me.Label2)
        Me.SupplierUpdatePanel.Controls.Add(Me.USupplierIDComboBox)
        Me.SupplierUpdatePanel.Controls.Add(Me.Label4)
        Me.SupplierUpdatePanel.Controls.Add(Me.Label5)
        Me.SupplierUpdatePanel.Controls.Add(Me.UClearBtn)
        Me.SupplierUpdatePanel.Controls.Add(Me.USupplierNameTextBox)
        Me.SupplierUpdatePanel.Location = New System.Drawing.Point(0, 51)
        Me.SupplierUpdatePanel.Name = "SupplierUpdatePanel"
        Me.SupplierUpdatePanel.Size = New System.Drawing.Size(959, 515)
        Me.SupplierUpdatePanel.TabIndex = 15
        '
        'USupplierEmailTextBox
        '
        Me.USupplierEmailTextBox.Location = New System.Drawing.Point(436, 229)
        Me.USupplierEmailTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.USupplierEmailTextBox.Name = "USupplierEmailTextBox"
        Me.USupplierEmailTextBox.Size = New System.Drawing.Size(254, 34)
        Me.USupplierEmailTextBox.TabIndex = 59
        '
        'UpdateSupplierBtn
        '
        Me.UpdateSupplierBtn.Location = New System.Drawing.Point(274, 284)
        Me.UpdateSupplierBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.UpdateSupplierBtn.Name = "UpdateSupplierBtn"
        Me.UpdateSupplierBtn.Size = New System.Drawing.Size(416, 43)
        Me.UpdateSupplierBtn.TabIndex = 54
        Me.UpdateSupplierBtn.Text = "Update Supplier "
        Me.UpdateSupplierBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(269, 130)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(109, 28)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Supplier ID"
        '
        'USupplierIDComboBox
        '
        Me.USupplierIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.USupplierIDComboBox.FormattingEnabled = True
        Me.USupplierIDComboBox.Location = New System.Drawing.Point(436, 127)
        Me.USupplierIDComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.USupplierIDComboBox.Name = "USupplierIDComboBox"
        Me.USupplierIDComboBox.Size = New System.Drawing.Size(254, 36)
        Me.USupplierIDComboBox.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(269, 232)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 28)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(269, 182)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 28)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Name"
        '
        'UClearBtn
        '
        Me.UClearBtn.Location = New System.Drawing.Point(274, 345)
        Me.UClearBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.UClearBtn.Name = "UClearBtn"
        Me.UClearBtn.Size = New System.Drawing.Size(416, 43)
        Me.UClearBtn.TabIndex = 44
        Me.UClearBtn.Text = "Clear Form"
        Me.UClearBtn.UseVisualStyleBackColor = True
        '
        'USupplierNameTextBox
        '
        Me.USupplierNameTextBox.Location = New System.Drawing.Point(436, 179)
        Me.USupplierNameTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.USupplierNameTextBox.Name = "USupplierNameTextBox"
        Me.USupplierNameTextBox.Size = New System.Drawing.Size(254, 34)
        Me.USupplierNameTextBox.TabIndex = 42
        '
        'SupplierAddPanel
        '
        Me.SupplierAddPanel.BackColor = System.Drawing.SystemColors.Control
        Me.SupplierAddPanel.Controls.Add(Me.ASupplierEmailTextBox)
        Me.SupplierAddPanel.Controls.Add(Me.AddSupplierBtn)
        Me.SupplierAddPanel.Controls.Add(Me.Label1)
        Me.SupplierAddPanel.Controls.Add(Me.ASupplierIDComboBox)
        Me.SupplierAddPanel.Controls.Add(Me.Label3)
        Me.SupplierAddPanel.Controls.Add(Me.Label6)
        Me.SupplierAddPanel.Controls.Add(Me.AClearBtn)
        Me.SupplierAddPanel.Controls.Add(Me.ASupplierNameTextBox)
        Me.SupplierAddPanel.Location = New System.Drawing.Point(0, 50)
        Me.SupplierAddPanel.Name = "SupplierAddPanel"
        Me.SupplierAddPanel.Size = New System.Drawing.Size(959, 515)
        Me.SupplierAddPanel.TabIndex = 16
        '
        'ASupplierEmailTextBox
        '
        Me.ASupplierEmailTextBox.Location = New System.Drawing.Point(436, 229)
        Me.ASupplierEmailTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ASupplierEmailTextBox.Name = "ASupplierEmailTextBox"
        Me.ASupplierEmailTextBox.Size = New System.Drawing.Size(254, 34)
        Me.ASupplierEmailTextBox.TabIndex = 59
        '
        'AddSupplierBtn
        '
        Me.AddSupplierBtn.Location = New System.Drawing.Point(274, 284)
        Me.AddSupplierBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.AddSupplierBtn.Name = "AddSupplierBtn"
        Me.AddSupplierBtn.Size = New System.Drawing.Size(416, 43)
        Me.AddSupplierBtn.TabIndex = 54
        Me.AddSupplierBtn.Text = "Add Supplier "
        Me.AddSupplierBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(269, 130)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(109, 28)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Supplier ID"
        '
        'ASupplierIDComboBox
        '
        Me.ASupplierIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ASupplierIDComboBox.Enabled = False
        Me.ASupplierIDComboBox.FormattingEnabled = True
        Me.ASupplierIDComboBox.Location = New System.Drawing.Point(436, 127)
        Me.ASupplierIDComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ASupplierIDComboBox.Name = "ASupplierIDComboBox"
        Me.ASupplierIDComboBox.Size = New System.Drawing.Size(254, 36)
        Me.ASupplierIDComboBox.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(269, 232)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 28)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(269, 182)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 28)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Name"
        '
        'AClearBtn
        '
        Me.AClearBtn.Location = New System.Drawing.Point(274, 345)
        Me.AClearBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.AClearBtn.Name = "AClearBtn"
        Me.AClearBtn.Size = New System.Drawing.Size(416, 43)
        Me.AClearBtn.TabIndex = 44
        Me.AClearBtn.Text = "Clear Form"
        Me.AClearBtn.UseVisualStyleBackColor = True
        '
        'ASupplierNameTextBox
        '
        Me.ASupplierNameTextBox.Location = New System.Drawing.Point(436, 179)
        Me.ASupplierNameTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ASupplierNameTextBox.Name = "ASupplierNameTextBox"
        Me.ASupplierNameTextBox.Size = New System.Drawing.Size(254, 34)
        Me.ASupplierNameTextBox.TabIndex = 42
        '
        'SupplierForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 563)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SupplierUpdatePanel)
        Me.Controls.Add(Me.SupplierDeletePanel)
        Me.Controls.Add(Me.SupplierViewPanel)
        Me.Controls.Add(Me.SupplierAddPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "SupplierForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SupplierDeletePanel.ResumeLayout(False)
        Me.SupplierDeletePanel.PerformLayout()
        Me.SupplierViewPanel.ResumeLayout(False)
        CType(Me.SupplierDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SupplierUpdatePanel.ResumeLayout(False)
        Me.SupplierUpdatePanel.PerformLayout()
        Me.SupplierAddPanel.ResumeLayout(False)
        Me.SupplierAddPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SupplierTitleLabel As System.Windows.Forms.Label
    Friend WithEvents SupplierDeletePanel As System.Windows.Forms.Panel
    Friend WithEvents DSupplierEmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DeleteSupplierBtn As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DSupplierIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DSupplierNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SupplierViewPanel As System.Windows.Forms.Panel
    Friend WithEvents SupplierDGV As System.Windows.Forms.DataGridView
    Friend WithEvents SupplierUpdatePanel As System.Windows.Forms.Panel
    Friend WithEvents USupplierEmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UpdateSupplierBtn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents USupplierIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents UClearBtn As System.Windows.Forms.Button
    Friend WithEvents USupplierNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SupplierAddPanel As System.Windows.Forms.Panel
    Friend WithEvents ASupplierEmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddSupplierBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ASupplierIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents AClearBtn As System.Windows.Forms.Button
    Friend WithEvents ASupplierNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExportBtn As System.Windows.Forms.Button
End Class
