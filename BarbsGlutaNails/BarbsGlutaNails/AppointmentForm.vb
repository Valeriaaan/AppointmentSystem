Public Class AppointmentForm

    ' Set Panel
    Sub SClearTextboxes()
        SCustomerNameTextBox.Clear()
        SCustomerPhoneNumberTextBox.Clear()
        SCustomerAddressTextBox.Clear()
    End Sub

    Sub SDisplayNextCustomerID()
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT MAX(customerID) FROM customer"
            Dim result As Object = cmd.ExecuteScalar()

            If result Is DBNull.Value Then
                SCustomerIDComboBox.Items.Add("1")
                SCustomerIDComboBox.Text = "1"
            Else
                Dim finalId As Integer = CInt(result) + 1

                ' Add the incremented final id value to the SupplierIDComboBox items
                SCustomerIDComboBox.Items.Add(finalId.ToString())

                ' Set the SupplierIDComboBox text to the incremented final id value
                SCustomerIDComboBox.Text = finalId.ToString()
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub SDisplayEmployeeName()
        Dim t2 As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM employee"
            adapter.SelectCommand = cmd
            adapter.Fill(t2)

            SEmployeeComboBox.DataSource = t2
            SEmployeeComboBox.DisplayMember = "employeeName"
            SEmployeeComboBox.ValueMember = "employeeID"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub SetAppointmentBtn_Click(sender As Object, e As EventArgs) Handles SetAppointmentBtn.Click
        If String.IsNullOrWhiteSpace(SCustomerNameTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(SCustomerAddressTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(SCustomerPhoneNumberTextBox.Text) Then

            MsgBox("Please fill in all the required fields.")
            Return
        End If

        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO customer (customerName, customerPhoneNum, customerAddress) VALUES (@SCustomerName, @SCustomerPhoneNumber, @SCustomerAddress)"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@SCustomerName", SCustomerNameTextBox.Text)
            cmd.Parameters.AddWithValue("@SCustomerPhoneNumber", SCustomerPhoneNumberTextBox.Text)
            cmd.Parameters.AddWithValue("@SCustomerAddress", SCustomerAddressTextBox.Text)

            If MsgBox("Do you want to set this appointment?", MsgBoxStyle.YesNo) = vbYes Then
                cmd.ExecuteNonQuery()

                cmd.CommandText = "INSERT INTO appointment (customerID, employeeID, date) VALUES (@SCustomerID, @SEmployeeID, @SDate)"

                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@SCustomerID", SCustomerIDComboBox.Text)
                cmd.Parameters.AddWithValue("@SEmployeeID", SEmployeeComboBox.SelectedValue)
                cmd.Parameters.AddWithValue("@SDate", SAppointmentDatePicker.Text)

                cmd.ExecuteNonQuery()

                MsgBox("New appointment has been set!")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

        SClearTextboxes()
        SDisplayEmployeeName()
        SDisplayNextCustomerID()
    End Sub

    Private Sub SClearBtn_Click(sender As Object, e As EventArgs) Handles SClearBtn.Click
        SClearTextboxes()
    End Sub

    Private Sub SCustomerPhoneNumberTextBox_TextChanged(sender As Object, e As EventArgs) Handles SCustomerPhoneNumberTextBox.TextChanged
        If SCustomerPhoneNumberTextBox.TextLength > 11 Then
            SCustomerPhoneNumberTextBox.Text = SCustomerPhoneNumberTextBox.Text.Substring(0, 11) ' Truncate the text to 11 characters
            SCustomerPhoneNumberTextBox.SelectionStart = 11 ' Move the cursor to the end of the text
        End If
    End Sub

    Private Sub SCustomerPhoneNumberTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SCustomerPhoneNumberTextBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) AndAlso Not e.KeyChar = ChrW(Keys.Delete) Then
            e.Handled = True ' Ignore the key press
        End If
    End Sub

    Private Sub SCustomerPhoneNumberTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles SCustomerPhoneNumberTextBox.KeyDown
        If Not Char.IsDigit(ChrW(e.KeyCode)) AndAlso Not e.KeyCode = Keys.Back AndAlso Not e.KeyCode = Keys.Delete Then
            e.SuppressKeyPress = True ' Ignore the key press
        End If
    End Sub
    'Set Panel End

    ' Update Panel
    Sub UClearTextboxes()
        UCustomerNameTextBox.Clear()
        UCustomerPhoneNumberTextBox.Clear()
        UCustomerAddressTextBox.Clear()
    End Sub

    Sub UDisplayAppointmentID()
        Dim t3 As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM appointment"
            adapter.SelectCommand = cmd
            adapter.Fill(t3)
            UAppointmentIDComboBox.DataSource = t3
            UAppointmentIDComboBox.DisplayMember = "appointmentID"
            UAppointmentIDComboBox.ValueMember = "appointmentID"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub UDisplayEmployeeID()
        Dim t1 As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM employee"
            adapter.SelectCommand = cmd
            adapter.Fill(t1)
            UEmployeeComboBox.DataSource = t1
            UEmployeeComboBox.DisplayMember = "employeeName"
            UEmployeeComboBox.ValueMember = "employeeID"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub UAppointmentIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UAppointmentIDComboBox.SelectedIndexChanged
        If UAppointmentIDComboBox.SelectedIndex > -1 Then
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT appointment.*, employee.employeeName AS UEmployeeName, customer.customerName AS UCustomerName, customer.customerPhoneNum AS UCustomerPhoneNum, customer.customerAddress AS UCustomerAddress FROM appointment " &
                                  "INNER JOIN employee ON appointment.employeeID = employee.employeeID " &
                                  "INNER JOIN customer ON appointment.customerID = customer.customerID " &
                                  "WHERE appointment.appointmentID = '" & UAppointmentIDComboBox.Text & "'"

                If con.State = ConnectionState.Closed Then
                    con.Open()
                ElseIf con.State = ConnectionState.Open Then
                    ' Connection is already open, do nothing
                End If

                reader = cmd.ExecuteReader()

                If reader.Read() Then
                    UAppointmentDatePicker.Text = reader.GetString("date")
                    UCustomerIDTextBox.Text = reader.GetString("customerID")
                    UEmployeeComboBox.SelectedValue = reader.GetString("employeeID")

                    Dim UcustomerName As String = reader.GetString("UCustomerName")
                    Dim UcustomerPhoneNum As String = reader.GetString("UCustomerPhoneNum")
                    Dim UcustomerAddress As String = reader.GetString("UCustomerAddress")

                    UCustomerNameTextBox.Text = UcustomerName
                    UCustomerPhoneNumberTextBox.Text = UcustomerPhoneNum
                    UCustomerAddressTextBox.Text = UcustomerAddress
                Else

                End If

                reader.Close()

            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub UpdateAppointmentBtn_Click(sender As Object, e As EventArgs) Handles UpdateAppointmentBtn.Click
        If String.IsNullOrWhiteSpace(UCustomerNameTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(UCustomerAddressTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(UCustomerPhoneNumberTextBox.Text) Then

            MsgBox("Please fill in all the required fields.")
            Return
        End If

        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE customer SET customerName = @UCustomerName, customerPhoneNum = @UCustomerPhoneNumber, customerAddress = @UCustomerAddress WHERE customerID = @UCustomerID"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@UCustomerName", UCustomerNameTextBox.Text)
            cmd.Parameters.AddWithValue("@UCustomerPhoneNumber", UCustomerPhoneNumberTextBox.Text)
            cmd.Parameters.AddWithValue("@UCustomerAddress", UCustomerAddressTextBox.Text)
            cmd.Parameters.AddWithValue("@UCustomerID", UCustomerIDTextBox.Text)

            If MsgBox("Do you want to Update this appointment?", MsgBoxStyle.YesNo) = vbYes Then
                cmd.ExecuteNonQuery()

                cmd.CommandText = "UPDATE appointment SET date = @UDate, employeeID = @UemployeeID WHERE appointmentID = @UAppointmentID"

                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@UDate", UAppointmentDatePicker.Text)
                cmd.Parameters.AddWithValue("@UemployeeID", UEmployeeComboBox.SelectedValue)
                cmd.Parameters.AddWithValue("@UAppointmentID", UAppointmentIDComboBox.SelectedValue)

                cmd.ExecuteNonQuery()

                MsgBox("Appointment has been updated!")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

        UClearTextboxes()
        UDisplayEmployeeID()
        UDisplayAppointmentID()
    End Sub

    Private Sub UClearBtn_Click(sender As Object, e As EventArgs) Handles UClearBtn.Click
        UClearTextboxes()
    End Sub

    Private Sub UCustomerPhoneNumberTextBox_TextChanged(sender As Object, e As EventArgs) Handles UCustomerPhoneNumberTextBox.TextChanged
        If UCustomerPhoneNumberTextBox.TextLength > 11 Then
            UCustomerPhoneNumberTextBox.Text = UCustomerPhoneNumberTextBox.Text.Substring(0, 11) ' Truncate the text to 11 characters
            UCustomerPhoneNumberTextBox.SelectionStart = 11 ' Move the cursor to the end of the text
        End If
    End Sub

    Private Sub UCustomerPhoneNumberTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UCustomerPhoneNumberTextBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) AndAlso Not e.KeyChar = ChrW(Keys.Delete) Then
            e.Handled = True ' Ignore the key press
        End If
    End Sub

    Private Sub UCustomerPhoneNumberTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles UCustomerPhoneNumberTextBox.KeyDown
        If Not Char.IsDigit(ChrW(e.KeyCode)) AndAlso Not e.KeyCode = Keys.Back AndAlso Not e.KeyCode = Keys.Delete Then
            e.SuppressKeyPress = True ' Ignore the key press
        End If
    End Sub
    ' Update Panel End

    ' Cancel Panel
    Sub DDisplayAppointmentID()
        Dim t4 As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM appointment"
            adapter.SelectCommand = cmd
            adapter.Fill(t4)
            CAppointmentIDComboBox.DataSource = t4
            CAppointmentIDComboBox.DisplayMember = "appointmentID"
            CAppointmentIDComboBox.ValueMember = "appointmentID"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub CAppointmentIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CAppointmentIDComboBox.SelectedIndexChanged
        If CAppointmentIDComboBox.SelectedIndex > -1 Then
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT appointment.*, employee.employeeName AS EmployeeName, customer.customerName AS CustomerName, customer.customerPhoneNum AS CustomerPhoneNum, customer.customerAddress AS CustomerAddress FROM appointment " &
                                  "INNER JOIN employee ON appointment.employeeID = employee.employeeID " &
                                  "INNER JOIN customer ON appointment.customerID = customer.customerID " &
                                  "WHERE appointment.appointmentID = '" & CAppointmentIDComboBox.Text & "'"

                If con.State = ConnectionState.Closed Then
                    con.Open()
                ElseIf con.State = ConnectionState.Open Then
                    ' Connection is already open, do nothing
                End If

                reader = cmd.ExecuteReader()

                If reader.Read() Then
                    CAppointmentDatePicker.Text = reader.GetString("date")
                    Dim employeeName As String = reader.GetString("EmployeeName")
                    Dim customerName As String = reader.GetString("CustomerName")
                    Dim customerPhoneNum As String = reader.GetString("CustomerPhoneNum")
                    Dim customerAddress As String = reader.GetString("CustomerAddress")

                    CEmployeeTextBox.Text = employeeName
                    CCustomerNameTextBox.Text = customerName
                    CCustomerPhoneNumberTextBox.Text = customerPhoneNum
                    CCustomerAddressTextBox.Text = customerAddress
                Else

                End If

                reader.Close()

            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub CancelAppointmentBtn_Click(sender As Object, e As EventArgs) Handles CancelAppointmentBtn.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM appointment WHERE appointmentID = @appointmentID"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@appointmentID", CAppointmentIDComboBox.Text)

            If MsgBox("Are you sure you want to cancel this appointment?", MsgBoxStyle.YesNo) = vbYes Then
                cmd.ExecuteNonQuery()
                MsgBox("Appointment Cancelled!")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

        DDisplayAppointmentID()
    End Sub

    ' Cancel Panel End

End Class