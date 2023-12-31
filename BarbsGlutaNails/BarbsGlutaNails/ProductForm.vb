Imports Microsoft.Office.Interop

Public Class ProductForm
    Dim exFile As Excel.Application
    Dim ProductTable As New DataTable
    Dim row As Integer

    ' View Panel
    Sub DisplayProductTable()
        Dim ProductTable As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT p.productID as 'ID', p.productName as 'Name', p.productDescription as 'Description', p.productPrice as 'Price', s.supplierName as 'Supplier' FROM product p JOIN supplier s ON p.supplierID = s.supplierID"
            adapter.SelectCommand = cmd
            ProductTable.Clear()

            adapter.Fill(ProductTable)
            ProductDGV.DataSource = ProductTable

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ExportBtn_Click(sender As Object, e As EventArgs) Handles ExportBtn.Click
        Try
            exFile = New Excel.Application

            Dim workbook As Excel.Workbook = exFile.Workbooks.Open("C:\Users\Acer\OneDrive\Documents\Visual Studio 2013\Projects\BarbsGlutaNails\product.xlsx")

            Dim worksheet As Excel.Worksheet = DirectCast(workbook.Sheets(1), Excel.Worksheet)

            For colIndex As Integer = 1 To ProductDGV.Columns.Count
                worksheet.Cells(4, colIndex).Value = ProductDGV.Columns(colIndex - 1).HeaderText
            Next

            row = 2
            For rowIndex As Integer = 0 To ProductDGV.Rows.Count - 1
                For colIndex As Integer = 1 To ProductDGV.Columns.Count
                    worksheet.Cells(row, colIndex).Value = ProductDGV.Rows(rowIndex).Cells(colIndex - 1).Value.ToString()
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
    Sub ClearAddTextboxes()
        ProductNameTextBox.Clear()
        ProductPriceTextBox.Clear()
        ProductDescTextBox.Clear()
    End Sub
    Private Sub ProductClearButton_Click(sender As Object, e As EventArgs) Handles ProductClearButton.Click
        ClearAddTextboxes()
    End Sub

    Sub DisplayProductSupplierName()
        Dim t2 As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM supplier"
            adapter.SelectCommand = cmd
            adapter.Fill(t2)

            ProductSupplierComboBox.DataSource = t2
            ProductSupplierComboBox.DisplayMember = "supplierName"
            ProductSupplierComboBox.ValueMember = "supplierID"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub DisplayNextProductID()
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT MAX(productID) FROM product"
            Dim result As Object = cmd.ExecuteScalar()

            If result Is DBNull.Value Then
                ProductIDComboBox.Items.Add("1")
                ProductIDComboBox.Text = "1"
            Else
                Dim finalId As Integer = CInt(result) + 1

                ' Add the incremented final id value to the SupplierIDComboBox items
                ProductIDComboBox.Items.Add(finalId.ToString())

                ' Set the SupplierIDComboBox text to the incremented final id value
                ProductIDComboBox.Text = finalId.ToString()
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ProductAddButton_Click(sender As Object, e As EventArgs) Handles ProductAddButton.Click
        If String.IsNullOrWhiteSpace(ProductNameTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(ProductDescTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(ProductPriceTextBox.Text) OrElse
           ProductSupplierComboBox.SelectedValue Is Nothing Then

            MsgBox("Please fill in all the required fields.")
            Return
        End If

        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO product (productName, productDescription, productPrice, supplierID) VALUES (@AProductName, @AProductDesc, @AProductPrice, @ASupplierID)"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@AProductName", ProductNameTextBox.Text)
            cmd.Parameters.AddWithValue("@AProductDesc", ProductDescTextBox.Text)
            cmd.Parameters.AddWithValue("@AProductPrice", ProductPriceTextBox.Text)
            cmd.Parameters.AddWithValue("@ASupplierID", ProductSupplierComboBox.SelectedValue)

            If MsgBox("Do you want to save this product?", MsgBoxStyle.YesNo) = vbYes Then
                cmd.ExecuteNonQuery()
                MsgBox("New Product Added!")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

        ClearAddTextboxes()
        UDisplayProductID()
        DisplayProductSupplierName()
    End Sub

    Private Sub ProductPriceTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ProductPriceTextBox.KeyPress
        ' Allow only digits, decimal separator, backspace and delete keys
        If (Not Char.IsDigit(e.KeyChar)) AndAlso (e.KeyChar <> ".") AndAlso (e.KeyChar <> ",") AndAlso (e.KeyChar <> ChrW(Keys.Back)) AndAlso (e.KeyChar <> ChrW(Keys.Delete)) Then
            e.Handled = True ' Ignore the keypress
        End If

        ' Allow only one decimal separator
        If (e.KeyChar = ".") OrElse (e.KeyChar = ",") Then
            If ProductPriceTextBox.Text.Contains(".") OrElse ProductPriceTextBox.Text.Contains(",") Then
                e.Handled = True ' Ignore the keypress
            End If
        End If
    End Sub
    ' Add Panel End

    ' Update Panel
    Sub UClearTextboxes()
        UProductNameTextBox.Clear()
        UProductPriceTextBox.Clear()
        UProductDescTextBox.Clear()
    End Sub

    Sub UDisplayProductSupplierName()
        Dim t3 As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM supplier"
            adapter.SelectCommand = cmd
            adapter.Fill(t3)

            UProductSupplierComboBox.DataSource = t3
            UProductSupplierComboBox.DisplayMember = "supplierName"
            UProductSupplierComboBox.ValueMember = "supplierID"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub UDisplayProductID()
        Dim t1 As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM product"
            adapter.SelectCommand = cmd
            adapter.Fill(t1)
            UProductIDComboBox.DataSource = t1
            UProductIDComboBox.DisplayMember = "productID"
            UProductIDComboBox.ValueMember = "productID"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub UProductIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UProductIDComboBox.SelectedIndexChanged
        If UProductIDComboBox.SelectedIndex > -1 Then
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT p.*, s.supplierName " &
                              "FROM product p " &
                              "JOIN supplier s ON p.supplierID = s.supplierID " &
                              "WHERE p.productID = '" & UProductIDComboBox.Text & "'"

                If con.State = ConnectionState.Closed Then
                    con.Open()
                ElseIf con.State = ConnectionState.Open Then
                    ' Connection is already open, do nothing
                End If

                reader = cmd.ExecuteReader()

                If reader.Read() Then
                    UProductNameTextBox.Text = reader.GetString("productName")
                    UProductDescTextBox.Text = reader.GetString("productDescription")
                    UProductPriceTextBox.Text = reader.GetString("productPrice")
                    UProductSupplierComboBox.Text = reader.GetString("supplierName")
                End If
                reader.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub UpdateProductBtn_Click(sender As Object, e As EventArgs) Handles UpdateProductBtn.Click
        If String.IsNullOrWhiteSpace(UProductNameTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(UProductDescTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(UProductPriceTextBox.Text) OrElse
           ProductSupplierComboBox.SelectedValue Is Nothing Then

            MsgBox("Please fill in all the required fields.")
            Return
        End If

        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE product SET productName = @UProductName, productDescription = @UProductDescription, productPrice = @UProductPrice, supplierID = @USupplierID WHERE productID = @UProductID"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@UProductName", UProductNameTextBox.Text)
            cmd.Parameters.AddWithValue("@UProductDescription", UProductDescTextBox.Text)
            cmd.Parameters.AddWithValue("@UProductPrice", UProductPriceTextBox.Text)
            cmd.Parameters.AddWithValue("@USupplierID", UProductSupplierComboBox.SelectedValue)
            cmd.Parameters.AddWithValue("@UProductID", UProductIDComboBox.SelectedValue)

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
        UDisplayProductID()
        UDisplayProductSupplierName()
    End Sub

    Private Sub UClearBtn_Click(sender As Object, e As EventArgs) Handles UClearBtn.Click
        UClearTextboxes()
    End Sub

    Private Sub UProductPriceTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UProductPriceTextBox.KeyPress
        ' Allow only digits, decimal separator, backspace and delete keys
        If (Not Char.IsDigit(e.KeyChar)) AndAlso (e.KeyChar <> ".") AndAlso (e.KeyChar <> ",") AndAlso (e.KeyChar <> ChrW(Keys.Back)) AndAlso (e.KeyChar <> ChrW(Keys.Delete)) Then
            e.Handled = True ' Ignore the keypress
        End If

        ' Allow only one decimal separator
        If (e.KeyChar = ".") OrElse (e.KeyChar = ",") Then
            If UProductPriceTextBox.Text.Contains(".") OrElse UProductPriceTextBox.Text.Contains(",") Then
                e.Handled = True ' Ignore the keypress
            End If
        End If
    End Sub
    ' Update Panel End

    ' Delete Panel
    Sub DDisplayProductID()
        Dim t4 As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM product"
            adapter.SelectCommand = cmd
            adapter.Fill(t4)
            DProductIDComboBox.DataSource = t4
            DProductIDComboBox.DisplayMember = "productID"
            DProductIDComboBox.ValueMember = "productID"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DProductIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DProductIDComboBox.SelectedIndexChanged
        If DProductIDComboBox.SelectedIndex > -1 Then
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT p.*, s.supplierName " &
                              "FROM product p " &
                              "JOIN supplier s ON p.supplierID = s.supplierID " &
                              "WHERE p.productID = '" & DProductIDComboBox.Text & "'"

                If con.State = ConnectionState.Closed Then
                    con.Open()
                ElseIf con.State = ConnectionState.Open Then
                    ' Connection is already open, do nothing
                End If

                reader = cmd.ExecuteReader()

                If reader.Read() Then
                    DProductNameTextBox.Text = reader.GetString("productName")
                    DProductDescTextBox.Text = reader.GetString("productDescription")
                    DProductPriceTextBox.Text = reader.GetString("productPrice")
                    DProductSupplierComboBox.Text = reader.GetString("supplierName")
                End If
                reader.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub DeleteProductBtn_Click(sender As Object, e As EventArgs) Handles DeleteProductBtn.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM product WHERE productID = @DProductID"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@DProductID", DProductIDComboBox.Text)

            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = vbYes Then
                cmd.ExecuteNonQuery()
                MsgBox("Record Has Been Deleted.")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

        DDisplayProductID()
    End Sub

    ' Delete Panel End

End Class