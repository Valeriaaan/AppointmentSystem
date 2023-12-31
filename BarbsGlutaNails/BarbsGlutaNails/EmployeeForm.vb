Imports Microsoft.Office.Interop
Public Class EmployeeForm
    Dim exFile As Excel.Application
    Dim ProductTable As New DataTable
    Dim row As Integer

    ' View Panel
    Sub DisplayEmployeeTable()
        Dim EmployeeTable As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT employeeID as 'ID', employeeName as 'Name', employeePhoneNum as 'Phone Number', employeeJobTitle as 'Job Title', employeeAddress as 'Address' FROM employee"
            adapter.SelectCommand = cmd
            EmployeeTable.Clear()

            adapter.Fill(EmployeeTable)
            EmployeeDGV.DataSource = EmployeeTable

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ExportBtn_Click(sender As Object, e As EventArgs) Handles ExportBtn.Click
        Try
            exFile = New Excel.Application

            Dim workbook As Excel.Workbook = exFile.Workbooks.Open("C:\Users\Acer\OneDrive\Documents\Visual Studio 2013\Projects\BarbsGlutaNails\employee.xlsx")

            Dim worksheet As Excel.Worksheet = DirectCast(workbook.Sheets(1), Excel.Worksheet)

            For colIndex As Integer = 1 To EmployeeDGV.Columns.Count
                worksheet.Cells(4, colIndex).Value = EmployeeDGV.Columns(colIndex - 1).HeaderText
            Next

            row = 2
            For rowIndex As Integer = 0 To EmployeeDGV.Rows.Count - 1
                For colIndex As Integer = 1 To EmployeeDGV.Columns.Count
                    worksheet.Cells(row, colIndex).Value = EmployeeDGV.Rows(rowIndex).Cells(colIndex - 1).Value.ToString()
                Next
                row += 1
            Next

            exFile.Visible = True

            exFile = Nothing
            workbook = Nothing
            worksheet = Nothing

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    ' View Panel End

    ' Add Panel
    Sub AClearTextboxes()
        AEmployeeNameTextBox.Clear()
        AEmployeePhoneNumberTextBox.Clear()
        AEmployeeJobTitleTextBox.Clear()
        AEmployeeAddressTextBox.Clear()
    End Sub

    Sub DisplayNextSupplierID()
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT MAX(employeeID) FROM employee"
            Dim result As Object = cmd.ExecuteScalar()

            If result Is DBNull.Value Then
                AEmployeeIDComboBox.Items.Add("1")
                AEmployeeIDComboBox.Text = "1"
            Else
                Dim finalId As Integer = CInt(result) + 1

                ' Add the incremented final id value to the SupplierIDComboBox items
                AEmployeeIDComboBox.Items.Add(finalId.ToString())

                ' Set the SupplierIDComboBox text to the incremented final id value
                AEmployeeIDComboBox.Text = finalId.ToString()
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub AddEmployeeBtn_Click(sender As Object, e As EventArgs) Handles AddEmployeeBtn.Click
        If String.IsNullOrWhiteSpace(AEmployeeNameTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(AEmployeePhoneNumberTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(AEmployeeJobTitleTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(AEmployeeAddressTextBox.Text) Then

            MsgBox("Please fill in all the required fields.")
            Return
        End If

        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO employee (employeeName, employeePhoneNum, employeeJobTitle, employeeAddress) VALUES (@AEmployeeName, @AEmployeePhoneNumber, @AEmployeeJobTitle, @AEmployeeAddress)"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@AEmployeeName", AEmployeeNameTextBox.Text)
            cmd.Parameters.AddWithValue("@AEmployeePhoneNumber", AEmployeePhoneNumberTextBox.Text)
            cmd.Parameters.AddWithValue("@AEmployeeJobTitle", AEmployeeJobTitleTextBox.Text)
            cmd.Parameters.AddWithValue("@AEmployeeAddress", AEmployeeAddressTextBox.Text)

            If MsgBox("Do you want to save this employee?", MsgBoxStyle.YesNo) = vbYes Then
                cmd.ExecuteNonQuery()
                MsgBox("New Employee Added!")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

        AClearTextboxes()
        DisplayNextSupplierID()
    End Sub

    Private Sub AClearBtn_Click(sender As Object, e As EventArgs) Handles AClearBtn.Click
        AClearTextboxes()
    End Sub

    Private Sub AEmployeePhoneNumberTextBox_TextChanged(sender As Object, e As EventArgs) Handles AEmployeePhoneNumberTextBox.TextChanged
        If AEmployeePhoneNumberTextBox.TextLength > 11 Then
            AEmployeePhoneNumberTextBox.Text = AEmployeePhoneNumberTextBox.Text.Substring(0, 11) ' Truncate the text to 11 characters
            AEmployeePhoneNumberTextBox.SelectionStart = 11 ' Move the cursor to the end of the text
        End If
    End Sub

    Private Sub AEmployeePhoneNumberTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AEmployeePhoneNumberTextBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) AndAlso Not e.KeyChar = ChrW(Keys.Delete) Then
            e.Handled = True ' Ignore the key press
        End If
    End Sub

    Private Sub AEmployeePhoneNumberTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles AEmployeePhoneNumberTextBox.KeyDown
        If Not Char.IsDigit(ChrW(e.KeyCode)) AndAlso Not e.KeyCode = Keys.Back AndAlso Not e.KeyCode = Keys.Delete Then
            e.SuppressKeyPress = True ' Ignore the key press
        End If
    End Sub
    ' Add Panel End

    ' Update Panel
    Sub UClearTextboxes()
        UEmployeeNameTextBox.Clear()
        UEmployeePhoneNumberTextBox.Clear()
        UEmployeeJobTitleTextBox.Clear()
        UEmployeeAddressTextBox.Clear()
    End Sub

    Sub UDisplaySupplierID()
        Dim t1 As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM employee"
            adapter.SelectCommand = cmd
            adapter.Fill(t1)
            UEmployeeIDComboBox.DataSource = t1
            UEmployeeIDComboBox.DisplayMember = "employeeID"
            UEmployeeIDComboBox.ValueMember = "employeeID"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub UEmployeeIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UEmployeeIDComboBox.SelectedIndexChanged
        If UEmployeeIDComboBox.SelectedIndex > -1 Then
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM employee WHERE employeeID = '" & UEmployeeIDComboBox.Text & "'"

                If con.State = ConnectionState.Closed Then
                    con.Open()
                ElseIf con.State = ConnectionState.Open Then
                    ' Connection is already open, do nothing
                End If

                reader = cmd.ExecuteReader()

                If reader.Read() Then
                    UEmployeeNameTextBox.Text = reader.GetString("employeeName")
                    UEmployeePhoneNumberTextBox.Text = reader.GetString("employeePhoneNum")
                    UEmployeeJobTitleTextBox.Text = reader.GetString("employeeJobTitle")
                    UEmployeeAddressTextBox.Text = reader.GetString("employeeAddress")
                End If
                reader.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub UpdateEmployeeBtn_Click(sender As Object, e As EventArgs) Handles UpdateEmployeeBtn.Click
        If String.IsNullOrWhiteSpace(UEmployeeNameTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(UEmployeePhoneNumberTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(UEmployeeJobTitleTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(UEmployeeAddressTextBox.Text) Then

            MsgBox("Please fill in all the required fields.")
            Return
        End If

        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE employee SET employeeName = @UEmployeeName, employeePhoneNum = @UEmployeePhoneNumber, employeeJobTitle = @UEmployeeJobTitle, employeeAddress = @UEmployeeAddress WHERE employeeID = @UEmployeeID"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@UEmployeeName", UEmployeeNameTextBox.Text)
            cmd.Parameters.AddWithValue("@UEmployeePhoneNumber", UEmployeePhoneNumberTextBox.Text)
            cmd.Parameters.AddWithValue("@UEmployeeJobTitle", UEmployeeJobTitleTextBox.Text)
            cmd.Parameters.AddWithValue("@UEmployeeAddress", UEmployeeAddressTextBox.Text)
            cmd.Parameters.AddWithValue("@UEmployeeID", UEmployeeIDComboBox.SelectedValue)

            If MsgBox("Are you sure you want to update this record?", MsgBoxStyle.YesNo) = vbYes Then
                cmd.ExecuteNonQuery()
                MsgBox("Record Has Been Updated.")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

        UClearTextboxes()
        UDisplaySupplierID()
    End Sub

    Private Sub UClearBtn_Click(sender As Object, e As EventArgs) Handles UClearBtn.Click
        UClearTextboxes()
    End Sub

    Private Sub UEmployeePhoneNumberTextBox_TextChanged(sender As Object, e As EventArgs) Handles UEmployeePhoneNumberTextBox.TextChanged
        If UEmployeePhoneNumberTextBox.TextLength > 11 Then
            UEmployeePhoneNumberTextBox.Text = UEmployeePhoneNumberTextBox.Text.Substring(0, 11) ' Truncate the text to 11 characters
            UEmployeePhoneNumberTextBox.SelectionStart = 11 ' Move the cursor to the end of the text
        End If
    End Sub

    Private Sub UEmployeePhoneNumberTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles UEmployeePhoneNumberTextBox.KeyDown
        If Not Char.IsDigit(ChrW(e.KeyCode)) AndAlso Not e.KeyCode = Keys.Back AndAlso Not e.KeyCode = Keys.Delete Then
            e.SuppressKeyPress = True ' Ignore the key press
        End If
    End Sub

    Private Sub UEmployeePhoneNumberTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UEmployeePhoneNumberTextBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) AndAlso Not e.KeyChar = ChrW(Keys.Delete) Then
            e.Handled = True ' Ignore the key press
        End If
    End Sub

    ' Update Panel End

    ' Delete Panel
    Sub DDisplayEmployeeID()
        Dim t4 As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM employee"
            adapter.SelectCommand = cmd
            adapter.Fill(t4)
            DEmployeeIDComboBox.DataSource = t4
            DEmployeeIDComboBox.DisplayMember = "employeeID"
            DEmployeeIDComboBox.ValueMember = "employeeID"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DEmployeeIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DEmployeeIDComboBox.SelectedIndexChanged
        If DEmployeeIDComboBox.SelectedIndex > -1 Then
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM employee WHERE employeeID = '" & DEmployeeIDComboBox.Text & "'"

                If con.State = ConnectionState.Closed Then
                    con.Open()
                ElseIf con.State = ConnectionState.Open Then
                    ' Connection is already open, do nothing
                End If

                reader = cmd.ExecuteReader()

                If reader.Read() Then
                    DEmployeeNameTextBox.Text = reader.GetString("employeeName")
                    DEmployeePhoneNumberTextBox.Text = reader.GetString("employeePhoneNum")
                    DEmployeeJobTitleTextBox.Text = reader.GetString("employeeJobTitle")
                    DEmployeeAddressTextBox.Text = reader.GetString("employeeAddress")
                End If
                reader.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub DeleteEmployeeBtn_Click(sender As Object, e As EventArgs) Handles DeleteEmployeeBtn.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM employee WHERE employeeID = @DEmployeeID"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@DEmployeeID", DEmployeeIDComboBox.Text)

            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = vbYes Then
                cmd.ExecuteNonQuery()
                MsgBox("Record Has Been Deleted.")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

        DDisplayEmployeeID()
    End Sub
    ' Delete Panel End

End Class