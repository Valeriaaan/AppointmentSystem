<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.IngredientTitleLabel = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CustomerDGV = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.NumberOfEmployeesLabel = New System.Windows.Forms.Label()
        Me.NumberOfEmpasloyeesLabel = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.NumberOfSuppliersLabel = New System.Windows.Forms.Label()
        Me.NumberOfasdSuppliersLabel = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.NumberOfCustomersLabel = New System.Windows.Forms.Label()
        Me.asd = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.AppointmentsAvailableLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GenerateReportBtn = New System.Windows.Forms.Button()
        Me.AppointmentDGV = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        CType(Me.CustomerDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.AppointmentDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.IngredientTitleLabel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(959, 51)
        Me.Panel2.TabIndex = 10
        '
        'IngredientTitleLabel
        '
        Me.IngredientTitleLabel.AutoSize = True
        Me.IngredientTitleLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.IngredientTitleLabel.Font = New System.Drawing.Font("Segoe UI Black", 16.0!, System.Drawing.FontStyle.Bold)
        Me.IngredientTitleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.IngredientTitleLabel.Location = New System.Drawing.Point(18, 9)
        Me.IngredientTitleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IngredientTitleLabel.Name = "IngredientTitleLabel"
        Me.IngredientTitleLabel.Size = New System.Drawing.Size(160, 37)
        Me.IngredientTitleLabel.TabIndex = 14
        Me.IngredientTitleLabel.Text = "Dashboard"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(483, 179)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(161, 28)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "List of Customers"
        '
        'CustomerDGV
        '
        Me.CustomerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerDGV.Location = New System.Drawing.Point(488, 210)
        Me.CustomerDGV.Name = "CustomerDGV"
        Me.CustomerDGV.RowTemplate.Height = 24
        Me.CustomerDGV.Size = New System.Drawing.Size(439, 278)
        Me.CustomerDGV.TabIndex = 19
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Location = New System.Drawing.Point(16, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(927, 111)
        Me.Panel1.TabIndex = 17
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel6.Controls.Add(Me.NumberOfEmployeesLabel)
        Me.Panel6.Controls.Add(Me.NumberOfEmpasloyeesLabel)
        Me.Panel6.Location = New System.Drawing.Point(701, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(210, 100)
        Me.Panel6.TabIndex = 2
        '
        'NumberOfEmployeesLabel
        '
        Me.NumberOfEmployeesLabel.AutoSize = True
        Me.NumberOfEmployeesLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.NumberOfEmployeesLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfEmployeesLabel.Location = New System.Drawing.Point(0, 0)
        Me.NumberOfEmployeesLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.NumberOfEmployeesLabel.Name = "NumberOfEmployeesLabel"
        Me.NumberOfEmployeesLabel.Padding = New System.Windows.Forms.Padding(8)
        Me.NumberOfEmployeesLabel.Size = New System.Drawing.Size(65, 75)
        Me.NumberOfEmployeesLabel.TabIndex = 2
        Me.NumberOfEmployeesLabel.Text = "0"
        '
        'NumberOfEmpasloyeesLabel
        '
        Me.NumberOfEmpasloyeesLabel.AutoSize = True
        Me.NumberOfEmpasloyeesLabel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.NumberOfEmpasloyeesLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfEmpasloyeesLabel.Location = New System.Drawing.Point(0, 69)
        Me.NumberOfEmpasloyeesLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.NumberOfEmpasloyeesLabel.Name = "NumberOfEmpasloyeesLabel"
        Me.NumberOfEmpasloyeesLabel.Padding = New System.Windows.Forms.Padding(8, 0, 8, 8)
        Me.NumberOfEmpasloyeesLabel.Size = New System.Drawing.Size(195, 31)
        Me.NumberOfEmpasloyeesLabel.TabIndex = 1
        Me.NumberOfEmpasloyeesLabel.Text = "Number of Employees"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel4.Controls.Add(Me.NumberOfSuppliersLabel)
        Me.Panel4.Controls.Add(Me.NumberOfasdSuppliersLabel)
        Me.Panel4.Location = New System.Drawing.Point(472, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(210, 100)
        Me.Panel4.TabIndex = 2
        '
        'NumberOfSuppliersLabel
        '
        Me.NumberOfSuppliersLabel.AutoSize = True
        Me.NumberOfSuppliersLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.NumberOfSuppliersLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfSuppliersLabel.Location = New System.Drawing.Point(0, 0)
        Me.NumberOfSuppliersLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.NumberOfSuppliersLabel.Name = "NumberOfSuppliersLabel"
        Me.NumberOfSuppliersLabel.Padding = New System.Windows.Forms.Padding(8)
        Me.NumberOfSuppliersLabel.Size = New System.Drawing.Size(65, 75)
        Me.NumberOfSuppliersLabel.TabIndex = 2
        Me.NumberOfSuppliersLabel.Text = "0"
        '
        'NumberOfasdSuppliersLabel
        '
        Me.NumberOfasdSuppliersLabel.AutoSize = True
        Me.NumberOfasdSuppliersLabel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.NumberOfasdSuppliersLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfasdSuppliersLabel.Location = New System.Drawing.Point(0, 69)
        Me.NumberOfasdSuppliersLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.NumberOfasdSuppliersLabel.Name = "NumberOfasdSuppliersLabel"
        Me.NumberOfasdSuppliersLabel.Padding = New System.Windows.Forms.Padding(8, 0, 8, 8)
        Me.NumberOfasdSuppliersLabel.Size = New System.Drawing.Size(183, 31)
        Me.NumberOfasdSuppliersLabel.TabIndex = 1
        Me.NumberOfasdSuppliersLabel.Text = "Number of Suppliers"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel3.Controls.Add(Me.NumberOfCustomersLabel)
        Me.Panel3.Controls.Add(Me.asd)
        Me.Panel3.Location = New System.Drawing.Point(243, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(210, 100)
        Me.Panel3.TabIndex = 2
        '
        'NumberOfCustomersLabel
        '
        Me.NumberOfCustomersLabel.AutoSize = True
        Me.NumberOfCustomersLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.NumberOfCustomersLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfCustomersLabel.Location = New System.Drawing.Point(0, 0)
        Me.NumberOfCustomersLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.NumberOfCustomersLabel.Name = "NumberOfCustomersLabel"
        Me.NumberOfCustomersLabel.Padding = New System.Windows.Forms.Padding(8)
        Me.NumberOfCustomersLabel.Size = New System.Drawing.Size(65, 75)
        Me.NumberOfCustomersLabel.TabIndex = 2
        Me.NumberOfCustomersLabel.Text = "0"
        '
        'asd
        '
        Me.asd.AutoSize = True
        Me.asd.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.asd.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.asd.Location = New System.Drawing.Point(0, 69)
        Me.asd.Margin = New System.Windows.Forms.Padding(0)
        Me.asd.Name = "asd"
        Me.asd.Padding = New System.Windows.Forms.Padding(8, 0, 8, 8)
        Me.asd.Size = New System.Drawing.Size(195, 31)
        Me.asd.TabIndex = 1
        Me.asd.Text = "Number of Customers"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel5.Controls.Add(Me.AppointmentsAvailableLabel)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Location = New System.Drawing.Point(14, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(210, 100)
        Me.Panel5.TabIndex = 1
        '
        'AppointmentsAvailableLabel
        '
        Me.AppointmentsAvailableLabel.AutoSize = True
        Me.AppointmentsAvailableLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.AppointmentsAvailableLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppointmentsAvailableLabel.Location = New System.Drawing.Point(0, 0)
        Me.AppointmentsAvailableLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.AppointmentsAvailableLabel.Name = "AppointmentsAvailableLabel"
        Me.AppointmentsAvailableLabel.Padding = New System.Windows.Forms.Padding(8)
        Me.AppointmentsAvailableLabel.Size = New System.Drawing.Size(65, 75)
        Me.AppointmentsAvailableLabel.TabIndex = 1
        Me.AppointmentsAvailableLabel.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 69)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(8, 0, 8, 8)
        Me.Label1.Size = New System.Drawing.Size(207, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Appointments Available"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(25, 179)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(200, 28)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Recent Appointments"
        '
        'GenerateReportBtn
        '
        Me.GenerateReportBtn.Location = New System.Drawing.Point(30, 504)
        Me.GenerateReportBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.GenerateReportBtn.Name = "GenerateReportBtn"
        Me.GenerateReportBtn.Size = New System.Drawing.Size(897, 43)
        Me.GenerateReportBtn.TabIndex = 40
        Me.GenerateReportBtn.Text = "Generate Report"
        Me.GenerateReportBtn.UseVisualStyleBackColor = True
        '
        'AppointmentDGV
        '
        Me.AppointmentDGV.AllowUserToAddRows = False
        Me.AppointmentDGV.AllowUserToDeleteRows = False
        Me.AppointmentDGV.AllowUserToResizeColumns = False
        Me.AppointmentDGV.AllowUserToResizeRows = False
        Me.AppointmentDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AppointmentDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.AppointmentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AppointmentDGV.Location = New System.Drawing.Point(411, 314)
        Me.AppointmentDGV.Margin = New System.Windows.Forms.Padding(4)
        Me.AppointmentDGV.Name = "AppointmentDGV"
        Me.AppointmentDGV.ReadOnly = True
        Me.AppointmentDGV.RowHeadersWidth = 21
        Me.AppointmentDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AppointmentDGV.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.AppointmentDGV.RowTemplate.Height = 24
        Me.AppointmentDGV.Size = New System.Drawing.Size(516, 221)
        Me.AppointmentDGV.TabIndex = 41
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 563)
        Me.ControlBox = False
        Me.Controls.Add(Me.AppointmentDGV)
        Me.Controls.Add(Me.GenerateReportBtn)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CustomerDGV)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "DashboardForm"
        Me.Text = "DashboardForm"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.CustomerDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.AppointmentDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents IngredientTitleLabel As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CustomerDGV As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents NumberOfEmployeesLabel As System.Windows.Forms.Label
    Friend WithEvents NumberOfEmpasloyeesLabel As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents NumberOfSuppliersLabel As System.Windows.Forms.Label
    Friend WithEvents NumberOfasdSuppliersLabel As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents NumberOfCustomersLabel As System.Windows.Forms.Label
    Friend WithEvents asd As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents AppointmentsAvailableLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GenerateReportBtn As System.Windows.Forms.Button
    Friend WithEvents AppointmentDGV As System.Windows.Forms.DataGridView
End Class
