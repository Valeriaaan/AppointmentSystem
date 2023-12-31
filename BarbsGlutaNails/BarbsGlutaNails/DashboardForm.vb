Imports System.Runtime.InteropServices

Public Class DashboardForm
    Dim exFile As Object
    Dim ReportTable As New DataTable
    Dim row As Integer

    Private Sub GenerateReportBtn_Click(sender As Object, e As EventArgs) Handles GenerateReportBtn.Click

        Try
            ' Create a new Excel application using late binding
            Dim exFile As Object = CreateObject("Excel.Application")

            ' Open the existing Excel workbook
            Dim workbook As Object = exFile.Workbooks.Open("C:\Users\Acer\OneDrive\Documents\Visual Studio 2013\Projects\BarbsGlutaNails\product.xlsx")

            ' Get the first worksheet in the workbook
            Dim worksheet As Object = DirectCast(workbook.Sheets(1), Object)

            ' Set the header row in the Excel worksheet
            For colIndex As Integer = 1 To AppointmentDGV.Columns.Count
                worksheet.Cells(4, colIndex).Value = AppointmentDGV.Columns(colIndex - 1).HeaderText
            Next

            ' Populate the Excel worksheet with data from the DataGridView
            row = 5
            For rowIndex As Integer = 0 To AppointmentDGV.Rows.Count - 1
                For colIndex As Integer = 1 To AppointmentDGV.Columns.Count
                    worksheet.Cells(row, colIndex).Value = AppointmentDGV.Rows(rowIndex).Cells(colIndex - 1).Value.ToString()
                Next
                row += 1
            Next

            ' Set the date in the Excel worksheet
            worksheet.Cells(2, 1) = "Date: " & FormatDateTime(Now(), DateFormat.LongDate)

            ' Make the Excel application visible to the user
            exFile.Visible = True

            ' Release Excel objects to free up resources
            Marshal.ReleaseComObject(worksheet)
            Marshal.ReleaseComObject(workbook)
            Marshal.ReleaseComObject(exFile)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayNumberInDashboard("appointment", AppointmentsAvailableLabel)
        DisplayNumberInDashboard("customer", NumberOfCustomersLabel)
        DisplayNumberInDashboard("supplier", NumberOfSuppliersLabel)
        DisplayNumberInDashboard("employee", NumberOfEmployeesLabel)

        DisplayAppointmentTable()
        DisplayCustomerTable()
    End Sub

    Sub DisplayAppointmentTable()
        Dim RecentDeliveryTable As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT appointmentID as 'ID', customerID as 'Customer', employeeID as 'Employee', date as 'Date' FROM appointment"
            adapter.SelectCommand = cmd
            RecentDeliveryTable.Clear()

            adapter.Fill(RecentDeliveryTable)
            AppointmentDGV.DataSource = RecentDeliveryTable

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub DisplayCustomerTable()
        Dim RecentPurchasesTable As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT customerID as 'ID', customerName as 'Name', customerPhoneNum as 'Phone Number', customerAddress as 'Address' FROM customer"
            adapter.SelectCommand = cmd
            RecentPurchasesTable.Clear()

            adapter.Fill(RecentPurchasesTable)
            CustomerDGV.DataSource = RecentPurchasesTable

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub DisplayNumberInDashboard(TableName, LabelName)
        Dim count As Integer = 0
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT COUNT(*) FROM " & TableName
            count = Convert.ToInt32(cmd.ExecuteScalar())

            If count > 0 Then
                LabelName.Text = count.ToString()
            Else
                LabelName.Text = "0"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


End Class