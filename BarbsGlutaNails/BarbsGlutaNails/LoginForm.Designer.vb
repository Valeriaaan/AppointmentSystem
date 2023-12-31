<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.FormTitleLabel = New System.Windows.Forms.Label()
        Me.RegisterNameTextBox = New System.Windows.Forms.TextBox()
        Me.RegisterPasswordLabel = New System.Windows.Forms.Label()
        Me.RegisterPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.RegisterCPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.RegisterButton = New System.Windows.Forms.Button()
        Me.RegisterUsernameLabel = New System.Windows.Forms.Label()
        Me.RegisterCPasswordLabel = New System.Windows.Forms.Label()
        Me.RegisterPanel = New System.Windows.Forms.Panel()
        Me.GoToLoginBtn = New System.Windows.Forms.Label()
        Me.LoginPanel = New System.Windows.Forms.Panel()
        Me.GoToRegisterBtn = New System.Windows.Forms.Label()
        Me.LoginBtn = New System.Windows.Forms.Button()
        Me.LoginNameLabel = New System.Windows.Forms.Label()
        Me.LoginPasswordLabel = New System.Windows.Forms.Label()
        Me.LoginPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.LoginNameTextBox = New System.Windows.Forms.TextBox()
        Me.Panel3.SuspendLayout()
        Me.RegisterPanel.SuspendLayout()
        Me.LoginPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Panel3.Controls.Add(Me.FormTitleLabel)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(411, 80)
        Me.Panel3.TabIndex = 21
        '
        'FormTitleLabel
        '
        Me.FormTitleLabel.AutoSize = True
        Me.FormTitleLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.FormTitleLabel.Font = New System.Drawing.Font("Segoe UI Black", 16.0!, System.Drawing.FontStyle.Bold)
        Me.FormTitleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.FormTitleLabel.Location = New System.Drawing.Point(151, 22)
        Me.FormTitleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FormTitleLabel.Name = "FormTitleLabel"
        Me.FormTitleLabel.Size = New System.Drawing.Size(108, 37)
        Me.FormTitleLabel.TabIndex = 35
        Me.FormTitleLabel.Text = "Sign In"
        '
        'RegisterNameTextBox
        '
        Me.RegisterNameTextBox.Location = New System.Drawing.Point(81, 122)
        Me.RegisterNameTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.RegisterNameTextBox.Name = "RegisterNameTextBox"
        Me.RegisterNameTextBox.Size = New System.Drawing.Size(254, 34)
        Me.RegisterNameTextBox.TabIndex = 24
        '
        'RegisterPasswordLabel
        '
        Me.RegisterPasswordLabel.AutoSize = True
        Me.RegisterPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.RegisterPasswordLabel.Location = New System.Drawing.Point(76, 162)
        Me.RegisterPasswordLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RegisterPasswordLabel.Name = "RegisterPasswordLabel"
        Me.RegisterPasswordLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RegisterPasswordLabel.Size = New System.Drawing.Size(93, 28)
        Me.RegisterPasswordLabel.TabIndex = 28
        Me.RegisterPasswordLabel.Text = "Password"
        '
        'RegisterPasswordTextBox
        '
        Me.RegisterPasswordTextBox.Location = New System.Drawing.Point(81, 196)
        Me.RegisterPasswordTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.RegisterPasswordTextBox.Name = "RegisterPasswordTextBox"
        Me.RegisterPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.RegisterPasswordTextBox.Size = New System.Drawing.Size(254, 34)
        Me.RegisterPasswordTextBox.TabIndex = 29
        '
        'RegisterCPasswordTextBox
        '
        Me.RegisterCPasswordTextBox.Location = New System.Drawing.Point(81, 270)
        Me.RegisterCPasswordTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.RegisterCPasswordTextBox.Name = "RegisterCPasswordTextBox"
        Me.RegisterCPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.RegisterCPasswordTextBox.Size = New System.Drawing.Size(254, 34)
        Me.RegisterCPasswordTextBox.TabIndex = 30
        '
        'RegisterButton
        '
        Me.RegisterButton.Location = New System.Drawing.Point(37, 341)
        Me.RegisterButton.Margin = New System.Windows.Forms.Padding(4)
        Me.RegisterButton.Name = "RegisterButton"
        Me.RegisterButton.Size = New System.Drawing.Size(337, 43)
        Me.RegisterButton.TabIndex = 31
        Me.RegisterButton.Text = "Register"
        Me.RegisterButton.UseVisualStyleBackColor = True
        '
        'RegisterUsernameLabel
        '
        Me.RegisterUsernameLabel.AutoSize = True
        Me.RegisterUsernameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.RegisterUsernameLabel.Location = New System.Drawing.Point(76, 88)
        Me.RegisterUsernameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RegisterUsernameLabel.Name = "RegisterUsernameLabel"
        Me.RegisterUsernameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RegisterUsernameLabel.Size = New System.Drawing.Size(99, 28)
        Me.RegisterUsernameLabel.TabIndex = 32
        Me.RegisterUsernameLabel.Text = "Username"
        '
        'RegisterCPasswordLabel
        '
        Me.RegisterCPasswordLabel.AutoSize = True
        Me.RegisterCPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.RegisterCPasswordLabel.Location = New System.Drawing.Point(76, 236)
        Me.RegisterCPasswordLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RegisterCPasswordLabel.Name = "RegisterCPasswordLabel"
        Me.RegisterCPasswordLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RegisterCPasswordLabel.Size = New System.Drawing.Size(168, 28)
        Me.RegisterCPasswordLabel.TabIndex = 33
        Me.RegisterCPasswordLabel.Text = "Confirm Password"
        '
        'RegisterPanel
        '
        Me.RegisterPanel.BackColor = System.Drawing.SystemColors.Control
        Me.RegisterPanel.Controls.Add(Me.GoToLoginBtn)
        Me.RegisterPanel.Controls.Add(Me.RegisterCPasswordLabel)
        Me.RegisterPanel.Controls.Add(Me.RegisterUsernameLabel)
        Me.RegisterPanel.Controls.Add(Me.RegisterButton)
        Me.RegisterPanel.Controls.Add(Me.RegisterCPasswordTextBox)
        Me.RegisterPanel.Controls.Add(Me.RegisterPasswordTextBox)
        Me.RegisterPanel.Controls.Add(Me.RegisterPasswordLabel)
        Me.RegisterPanel.Controls.Add(Me.RegisterNameTextBox)
        Me.RegisterPanel.Location = New System.Drawing.Point(0, 80)
        Me.RegisterPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.RegisterPanel.Name = "RegisterPanel"
        Me.RegisterPanel.Size = New System.Drawing.Size(411, 528)
        Me.RegisterPanel.TabIndex = 22
        '
        'GoToLoginBtn
        '
        Me.GoToLoginBtn.AutoSize = True
        Me.GoToLoginBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.GoToLoginBtn.Location = New System.Drawing.Point(68, 423)
        Me.GoToLoginBtn.Name = "GoToLoginBtn"
        Me.GoToLoginBtn.Size = New System.Drawing.Size(351, 28)
        Me.GoToLoginBtn.TabIndex = 34
        Me.GoToLoginBtn.Text = "Already have an account? Sign In Here!"
        '
        'LoginPanel
        '
        Me.LoginPanel.BackColor = System.Drawing.SystemColors.Control
        Me.LoginPanel.Controls.Add(Me.GoToRegisterBtn)
        Me.LoginPanel.Controls.Add(Me.LoginBtn)
        Me.LoginPanel.Controls.Add(Me.LoginNameLabel)
        Me.LoginPanel.Controls.Add(Me.LoginPasswordLabel)
        Me.LoginPanel.Controls.Add(Me.LoginPasswordTextBox)
        Me.LoginPanel.Controls.Add(Me.LoginNameTextBox)
        Me.LoginPanel.Cursor = System.Windows.Forms.Cursors.Default
        Me.LoginPanel.Location = New System.Drawing.Point(0, 80)
        Me.LoginPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.LoginPanel.Name = "LoginPanel"
        Me.LoginPanel.Size = New System.Drawing.Size(411, 528)
        Me.LoginPanel.TabIndex = 37
        '
        'GoToRegisterBtn
        '
        Me.GoToRegisterBtn.AutoSize = True
        Me.GoToRegisterBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.GoToRegisterBtn.Location = New System.Drawing.Point(68, 348)
        Me.GoToRegisterBtn.Name = "GoToRegisterBtn"
        Me.GoToRegisterBtn.Size = New System.Drawing.Size(343, 28)
        Me.GoToRegisterBtn.TabIndex = 40
        Me.GoToRegisterBtn.Text = "Don't have an account? Sign Up Here!"
        '
        'LoginBtn
        '
        Me.LoginBtn.Location = New System.Drawing.Point(37, 270)
        Me.LoginBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(337, 43)
        Me.LoginBtn.TabIndex = 39
        Me.LoginBtn.Text = "Login"
        Me.LoginBtn.UseVisualStyleBackColor = True
        '
        'LoginNameLabel
        '
        Me.LoginNameLabel.AutoSize = True
        Me.LoginNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.LoginNameLabel.Location = New System.Drawing.Point(76, 88)
        Me.LoginNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LoginNameLabel.Name = "LoginNameLabel"
        Me.LoginNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LoginNameLabel.Size = New System.Drawing.Size(99, 28)
        Me.LoginNameLabel.TabIndex = 38
        Me.LoginNameLabel.Text = "Username"
        '
        'LoginPasswordLabel
        '
        Me.LoginPasswordLabel.AutoSize = True
        Me.LoginPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.LoginPasswordLabel.Location = New System.Drawing.Point(82, 162)
        Me.LoginPasswordLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LoginPasswordLabel.Name = "LoginPasswordLabel"
        Me.LoginPasswordLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LoginPasswordLabel.Size = New System.Drawing.Size(93, 28)
        Me.LoginPasswordLabel.TabIndex = 37
        Me.LoginPasswordLabel.Text = "Password"
        '
        'LoginPasswordTextBox
        '
        Me.LoginPasswordTextBox.Location = New System.Drawing.Point(81, 196)
        Me.LoginPasswordTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.LoginPasswordTextBox.Name = "LoginPasswordTextBox"
        Me.LoginPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.LoginPasswordTextBox.Size = New System.Drawing.Size(254, 34)
        Me.LoginPasswordTextBox.TabIndex = 36
        '
        'LoginNameTextBox
        '
        Me.LoginNameTextBox.Location = New System.Drawing.Point(81, 122)
        Me.LoginNameTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.LoginNameTextBox.Name = "LoginNameTextBox"
        Me.LoginNameTextBox.Size = New System.Drawing.Size(254, 34)
        Me.LoginNameTextBox.TabIndex = 35
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 608)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.LoginPanel)
        Me.Controls.Add(Me.RegisterPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.RegisterPanel.ResumeLayout(False)
        Me.RegisterPanel.PerformLayout()
        Me.LoginPanel.ResumeLayout(False)
        Me.LoginPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents FormTitleLabel As System.Windows.Forms.Label
    Friend WithEvents RegisterNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RegisterPasswordLabel As System.Windows.Forms.Label
    Friend WithEvents RegisterPasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RegisterCPasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RegisterButton As System.Windows.Forms.Button
    Friend WithEvents RegisterUsernameLabel As System.Windows.Forms.Label
    Friend WithEvents RegisterCPasswordLabel As System.Windows.Forms.Label
    Friend WithEvents RegisterPanel As System.Windows.Forms.Panel
    Friend WithEvents GoToLoginBtn As System.Windows.Forms.Label
    Friend WithEvents LoginPanel As System.Windows.Forms.Panel
    Friend WithEvents GoToRegisterBtn As System.Windows.Forms.Label
    Friend WithEvents LoginBtn As System.Windows.Forms.Button
    Friend WithEvents LoginNameLabel As System.Windows.Forms.Label
    Friend WithEvents LoginPasswordLabel As System.Windows.Forms.Label
    Friend WithEvents LoginPasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LoginNameTextBox As System.Windows.Forms.TextBox
End Class
