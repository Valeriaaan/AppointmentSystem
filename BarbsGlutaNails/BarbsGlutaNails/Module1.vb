Imports MySql.Data.MySqlClient
Module Module1
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public adapter As New MySqlDataAdapter
    Public reader As MySqlDataReader
    Public data As New DataSet
    Public t As New DataTable

    Sub openCon()
        Try
            con.ConnectionString = "server=localhost;username=root;password=;database=barbs_glutanails_db"
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
        Catch ex As Exception
            MsgBox("Error connecting to the database: " & ex.Message)
        End Try
    End Sub


    Sub CheckAllTextBoxes(ComponentName, FormName)
        Dim allFilled As Boolean = True
        For Each ctrl As Control In FormName.Controls
            If TypeOf ctrl Is TextBox Then
                If ctrl.Text = "" Then
                    allFilled = False
                    Exit For
                End If
            End If
        Next
        ComponentName.Enabled = allFilled
    End Sub

End Module
