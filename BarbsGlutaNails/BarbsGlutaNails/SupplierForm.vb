Imports Microsoft.Office.Interop

Public Class SupplierForm
    Dim exFile As Excel.Application
    Dim ProductTable As New DataTable
    Dim row As Integer

    ' View Panel
    Sub DisplaySupplierTable()
        Dim SupplierTable As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT supplierID as 'ID', supplierName as 'Name', supplierEmail as 'Email' FROM supplier"
            adapter.SelectCommand = cmd
            SupplierTable.Clear()

            adapter.Fill(SupplierTable)
            SupplierDGV.DataSource = SupplierTable

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ExportBtn_Click(sender As Object, e As EventArgs) Handles ExportBtn.Click
        Try
            exFile = New Excel.Application

            Dim workbook As Excel.Workbook = exFile.Workbooks.Open("C:\Users\Acer\OneDrive\Documents\Visual Studio 2013\Projects\BarbsGlutaNails\supplier.xlsx")

            Dim worksheet As Excel.Worksheet = DirectCast(workbook.Sheets(1), Excel.Worksheet)

            For colIndex As Integer = 1 To SupplierDGV.Columns.Count
                worksheet.Cells(4, colIndex).Value = SupplierDGV.Columns(colIndex - 1).HeaderText
            Next

            row = 2
            For rowIndex As Integer = 0 To SupplierDGV.Rows.Count - 1
                For colIndex As Integer = 1 To SupplierDGV.Columns.Count
                    worksheet.Cells(row, colIndex).Value = SupplierDGV.Rows(rowIndex).Cells(colIndex - 1).Value.ToString()
                Next
                row += 1
            Next

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
        ASupplierNameTextBox.Clear()
        ASupplierEmailTextBox.Clear()
    End Sub

    Sub DisplayNextSupplierID()
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT MAX(supplierID) FROM supplier"
            Dim result As Object = cmd.ExecuteScalar()

            If result Is DBNull.Value Then
                ASupplierIDComboBox.Items.Add("1")
                ASupplierIDComboBox.Text = "1"
            Else
                Dim finalId As Integer = CInt(result) + 1

                ' Add the incremented final id value to the SupplierIDComboBox items
                ASupplierIDComboBox.Items.Add(finalId.ToString())

                ' Set the SupplierIDComboBox text to the incremented final id value
                ASupplierIDComboBox.Text = finalId.ToString()
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub AddSupplierBtn_Click(sender As Object, e As EventArgs) Handles AddSupplierBtn.Click
        If String.IsNullOrWhiteSpace(ASupplierNameTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(ASupplierEmailTextBox.Text) Then

            MsgBox("Please fill in all the required fields.")
            Return
        End If

        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO supplier (supplierName, supplierEmail) VALUES (@ASupplierName, @ASupplierEmail)"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@ASupplierName", ASupplierNameTextBox.Text)
            cmd.Parameters.AddWithValue("@ASupplierEmail", ASupplierEmailTextBox.Text)

            If MsgBox("Do you want to save this supplier?", MsgBoxStyle.YesNo) = vbYes Then
                cmd.ExecuteNonQuery()
                MsgBox("New Supplier Added!")
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
    ' Add Panel End

    ' Update Panel
    Sub UClearTextboxes()
        USupplierNameTextBox.Clear()
        USupplierEmailTextBox.Clear()
    End Sub

    Sub UDisplaySupplierID()
        Dim t1 As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM supplier"
            adapter.SelectCommand = cmd
            adapter.Fill(t1)
            USupplierIDComboBox.DataSource = t1
            USupplierIDComboBox.DisplayMember = "supplierName"
            USupplierIDComboBox.ValueMember = "supplierID"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub USupplierIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles USupplierIDComboBox.SelectedIndexChanged
        If USupplierIDComboBox.SelectedIndex > -1 Then
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM supplier WHERE supplierID = '" & USupplierIDComboBox.Text & "'"

                If con.State = ConnectionState.Closed Then
                    con.Open()
                ElseIf con.State = ConnectionState.Open Then
                    ' Connection is already open, do nothing
                End If

                reader = cmd.ExecuteReader()

                If reader.Read() Then
                    USupplierNameTextBox.Text = reader.GetString("supplierName")
                    USupplierEmailTextBox.Text = reader.GetString("supplierEmail")
                End If
                reader.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub UpdateSupplierBtn_Click(sender As Object, e As EventArgs) Handles UpdateSupplierBtn.Click
        If String.IsNullOrWhiteSpace(USupplierNameTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(USupplierEmailTextBox.Text) Then

            MsgBox("Please fill in all the required fields.")
            Return
        End If

        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE supplier SET supplierName = @USupplierName, supplierEmail = @USupplierEmail WHERE supplierID = @USupplierID"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@USupplierName", USupplierNameTextBox.Text)
            cmd.Parameters.AddWithValue("@USupplierEmail", USupplierEmailTextBox.Text)
            cmd.Parameters.AddWithValue("@USupplierID", USupplierIDComboBox.SelectedValue)

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
    ' Update Panel End


    ' Delete Panel
    Sub DDisplaySupplierID()
        Dim t4 As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM supplier"
            adapter.SelectCommand = cmd
            adapter.Fill(t4)
            DSupplierIDComboBox.DataSource = t4
            DSupplierIDComboBox.DisplayMember = "supplierID"
            DSupplierIDComboBox.ValueMember = "supplierID"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DSupplierIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DSupplierIDComboBox.SelectedIndexChanged
        If DSupplierIDComboBox.SelectedIndex > -1 Then
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM supplier WHERE supplierID = '" & DSupplierIDComboBox.Text & "'"

                If con.State = ConnectionState.Closed Then
                    con.Open()
                ElseIf con.State = ConnectionState.Open Then
                    ' Connection is already open, do nothing
                End If

                reader = cmd.ExecuteReader()

                If reader.Read() Then
                    DSupplierNameTextBox.Text = reader.GetString("supplierName")
                    DSupplierEmailTextBox.Text = reader.GetString("supplierEmail")
                End If
                reader.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub DeleteSupplierBtn_Click(sender As Object, e As EventArgs) Handles DeleteSupplierBtn.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM supplier WHERE supplierID = @DSupplierID"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@DSupplierID", DSupplierIDComboBox.Text)

            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = vbYes Then
                cmd.ExecuteNonQuery()
                MsgBox("Record Has Been Deleted.")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

        DDisplaySupplierID()
    End Sub
    ' Delete Panel End

    Private Sub SupplierUpdatePanel_Paint(sender As Object, e As PaintEventArgs) Handles SupplierUpdatePanel.Paint

    End Sub
End Class