Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TransactionAccordionPanel.Visible = False
        ProductAccordionPanel.Visible = False
        SupplierAccordionPanel.Visible = False
        EmployeeAccordionPanel.Visible = False
    End Sub

    ' Main Side Navigation Buttons

    Private Sub DashboardBtn_Click(sender As Object, e As EventArgs) Handles DashboardBtn.Click
        With DashboardForm
            .TopLevel = False
            ContentPanel.Controls.Add(DashboardForm)

            .DisplayNumberInDashboard("appointment", .AppointmentsAvailableLabel)
            .DisplayNumberInDashboard("customer", .NumberOfCustomersLabel)
            .DisplayNumberInDashboard("supplier", .NumberOfSuppliersLabel)
            .DisplayNumberInDashboard("employee", .NumberOfEmployeesLabel)

            .DisplayAppointmentTable()
            .DisplayCustomerTable()

            .BringToFront()
            .Show()
        End With

        TransactionAccordionPanel.Visible = False
        ProductAccordionPanel.Visible = False
        SupplierAccordionPanel.Visible = False
        EmployeeAccordionPanel.Visible = False
    End Sub

    Private Sub TransactionBtn_Click(sender As Object, e As EventArgs) Handles TransactionBtn.Click
        If TransactionAccordionPanel.Visible = False Then
            TransactionAccordionPanel.Visible = True
        Else
            TransactionAccordionPanel.Visible = False
        End If
        ProductAccordionPanel.Visible = False
        SupplierAccordionPanel.Visible = False
        EmployeeAccordionPanel.Visible = False
    End Sub

    Private Sub ProductBtn_Click(sender As Object, e As EventArgs) Handles ProductBtn.Click
        If ProductAccordionPanel.Visible = False Then
            ProductAccordionPanel.Visible = True
        Else
            ProductAccordionPanel.Visible = False
        End If
        TransactionAccordionPanel.Visible = False
        SupplierAccordionPanel.Visible = False
        EmployeeAccordionPanel.Visible = False
    End Sub

    Private Sub SupplierBtn_Click(sender As Object, e As EventArgs) Handles SupplierBtn.Click
        If SupplierAccordionPanel.Visible = False Then
            SupplierAccordionPanel.Visible = True
        Else
            SupplierAccordionPanel.Visible = False
        End If
        TransactionAccordionPanel.Visible = False
        ProductAccordionPanel.Visible = False
        EmployeeAccordionPanel.Visible = False
    End Sub

    Private Sub EmployeeBtn_Click(sender As Object, e As EventArgs) Handles EmployeeBtn.Click
        If EmployeeAccordionPanel.Visible = False Then
            EmployeeAccordionPanel.Visible = True
        Else
            EmployeeAccordionPanel.Visible = False
        End If
        TransactionAccordionPanel.Visible = False
        ProductAccordionPanel.Visible = False
        SupplierAccordionPanel.Visible = False
    End Sub

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Dim loginForm As New LoginForm()

        Me.Close()
        loginForm.Show()
    End Sub

    ' Transaction Navigation Buttons

    Private Sub TransactionAppointmentBtn_Click(sender As Object, e As EventArgs) Handles TransactionAppointmentBtn.Click
        With AppointmentForm
            .TopLevel = False
            ContentPanel.Controls.Add(AppointmentForm)

            .SetAppointmentPanel.Visible = True
            .UpdateAppointmentPanel.Visible = False
            .CancelAppointmentPanel.Visible = False

            .SDisplayNextCustomerID()
            .SDisplayEmployeeName()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub TransactionDeliveryBtn_Click(sender As Object, e As EventArgs) Handles TransactionDeliveryBtn.Click
        With AppointmentForm
            .TopLevel = False
            ContentPanel.Controls.Add(AppointmentForm)

            .SetAppointmentPanel.Visible = False
            .UpdateAppointmentPanel.Visible = True
            .CancelAppointmentPanel.Visible = False

            .UDisplayAppointmentID()
            .UDisplayEmployeeID()
            .UClearTextboxes()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub TransactionPurchaseBtn_Click(sender As Object, e As EventArgs) Handles TransactionPurchaseBtn.Click
        With AppointmentForm
            .TopLevel = False
            ContentPanel.Controls.Add(AppointmentForm)

            .SetAppointmentPanel.Visible = False
            .UpdateAppointmentPanel.Visible = False
            .CancelAppointmentPanel.Visible = True

            .DDisplayAppointmentID()
            .BringToFront()
            .Show()
        End With
    End Sub

    ' Product Navigation Buttons
    Private Sub ProductViewBtn_Click(sender As Object, e As EventArgs) Handles ProductViewBtn.Click
        With ProductForm
            .TopLevel = False
            ContentPanel.Controls.Add(ProductForm)

            .ProductViewPanel.Visible = True
            .ProductAddPanel.Visible = False
            .ProductUpdatePanel.Visible = False
            .ProductDeletePanel.Visible = False

            .DisplayProductTable()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub ProductAddBtn_Click(sender As Object, e As EventArgs) Handles ProductAddBtn.Click
        With ProductForm
            .TopLevel = False
            ContentPanel.Controls.Add(ProductForm)

            .ProductViewPanel.Visible = False
            .ProductAddPanel.Visible = True
            .ProductUpdatePanel.Visible = False
            .ProductDeletePanel.Visible = False

            .DisplayProductSupplierName()
            .DisplayNextProductID()
            .ClearAddTextboxes()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub ProductUpdateBtn_Click(sender As Object, e As EventArgs) Handles ProductUpdateBtn.Click
        With ProductForm
            .TopLevel = False
            ContentPanel.Controls.Add(ProductForm)

            .ProductViewPanel.Visible = False
            .ProductAddPanel.Visible = False
            .ProductUpdatePanel.Visible = True
            .ProductDeletePanel.Visible = False

            .UDisplayProductSupplierName()
            .UDisplayProductID()
            .UClearTextboxes()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub ProductDeleteBtn_Click(sender As Object, e As EventArgs) Handles ProductDeleteBtn.Click
        With ProductForm
            .TopLevel = False
            ContentPanel.Controls.Add(ProductForm)

            .ProductViewPanel.Visible = False
            .ProductAddPanel.Visible = False
            .ProductUpdatePanel.Visible = False
            .ProductDeletePanel.Visible = True

            .DDisplayProductID()
            .BringToFront()
            .Show()
        End With
    End Sub

    ' Supplier Navigation Buttons
    Private Sub SuppliersViewBtn_Click(sender As Object, e As EventArgs) Handles SuppliersViewBtn.Click
        With SupplierForm
            .TopLevel = False
            ContentPanel.Controls.Add(SupplierForm)

            .SupplierViewPanel.Visible = True
            .SupplierAddPanel.Visible = False
            .SupplierUpdatePanel.Visible = False
            .SupplierDeletePanel.Visible = False

            .DisplaySupplierTable()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub SuppliersAddBtn_Click(sender As Object, e As EventArgs) Handles SuppliersAddBtn.Click
        With SupplierForm
            .TopLevel = False
            ContentPanel.Controls.Add(SupplierForm)

            .SupplierViewPanel.Visible = False
            .SupplierAddPanel.Visible = True
            .SupplierUpdatePanel.Visible = False
            .SupplierDeletePanel.Visible = False

            .DisplayNextSupplierID()
            .AClearTextboxes()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub SuppliersUpdateBtn_Click(sender As Object, e As EventArgs) Handles SuppliersUpdateBtn.Click
        With SupplierForm
            .TopLevel = False
            ContentPanel.Controls.Add(SupplierForm)

            .SupplierViewPanel.Visible = False
            .SupplierAddPanel.Visible = False
            .SupplierUpdatePanel.Visible = True
            .SupplierDeletePanel.Visible = False

            .UDisplaySupplierID()
            .UClearTextboxes()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub SuppliersDeleteBtn_Click(sender As Object, e As EventArgs) Handles SuppliersDeleteBtn.Click
        With SupplierForm
            .TopLevel = False
            ContentPanel.Controls.Add(SupplierForm)

            .SupplierViewPanel.Visible = False
            .SupplierAddPanel.Visible = False
            .SupplierUpdatePanel.Visible = False
            .SupplierDeletePanel.Visible = True

            .DDisplaySupplierID()
            .BringToFront()
            .Show()
        End With
    End Sub

    ' Employee Navigation Buttons

    Private Sub EmployeeViewBtn_Click(sender As Object, e As EventArgs) Handles EmployeeViewBtn.Click
        With EmployeeForm
            .TopLevel = False
            ContentPanel.Controls.Add(EmployeeForm)

            .EmployeeViewPanel.Visible = True
            .EmployeeAddPanel.Visible = False
            .EmployeeUpdatePanel.Visible = False
            .EmployeeDeletePanel.Visible = False

            .DisplayEmployeeTable()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub EmployeeAddBtn_Click(sender As Object, e As EventArgs) Handles EmployeeAddBtn.Click
        With EmployeeForm
            .TopLevel = False
            ContentPanel.Controls.Add(EmployeeForm)

            .EmployeeViewPanel.Visible = False
            .EmployeeAddPanel.Visible = True
            .EmployeeUpdatePanel.Visible = False
            .EmployeeDeletePanel.Visible = False

            .DisplayNextSupplierID()
            .AClearTextboxes()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub EmployeeUpdateBtn_Click(sender As Object, e As EventArgs) Handles EmployeeUpdateBtn.Click
        With EmployeeForm
            .TopLevel = False
            ContentPanel.Controls.Add(EmployeeForm)

            .EmployeeViewPanel.Visible = False
            .EmployeeAddPanel.Visible = False
            .EmployeeUpdatePanel.Visible = True
            .EmployeeDeletePanel.Visible = False

            .UDisplaySupplierID()
            .UClearTextboxes()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub EmployeeDeleteBtn_Click(sender As Object, e As EventArgs) Handles EmployeeDeleteBtn.Click
        With EmployeeForm
            .TopLevel = False
            ContentPanel.Controls.Add(EmployeeForm)

            .EmployeeViewPanel.Visible = False
            .EmployeeAddPanel.Visible = False
            .EmployeeUpdatePanel.Visible = False
            .EmployeeDeletePanel.Visible = True

            .DDisplayEmployeeID()
            .BringToFront()
            .Show()
        End With
    End Sub

End Class
