Imports MySql.Data.MySqlClient

Public Class LoginForm

    ' Handles GoToLoginBtn
    Private Sub GoToLoginBtn_Click(sender As Object, e As EventArgs) Handles GoToLoginBtn.Click
        RegisterPanel.Visible = False
        LoginPanel.Visible = True
        FormTitleLabel.Text = "Sign In"

        ClearRegisterTextBoxes()
        ClearLoginTextBoxes()
    End Sub

    Private Sub GoToLoginBtn_MouseHover(sender As Object, e As EventArgs) Handles GoToLoginBtn.MouseHover
        GoToLoginBtn.ForeColor = Color.FromArgb(0, 173, 181)
    End Sub

    Private Sub GoToLoginBtn_MouseLeave(sender As Object, e As EventArgs) Handles GoToLoginBtn.MouseLeave
        GoToLoginBtn.ForeColor = Color.FromArgb(28, 27, 31)
    End Sub

    ' Handles GoToRegisterBtn
    Private Sub GoToRegisterBtn_Click(sender As Object, e As EventArgs) Handles GoToRegisterBtn.Click
        RegisterPanel.Visible = True
        LoginPanel.Visible = False
        FormTitleLabel.Text = "Sign Up"

        ClearRegisterTextBoxes()
        ClearLoginTextBoxes()
    End Sub

    Private Sub GoToRegisterBtn_MouseHover(sender As Object, e As EventArgs) Handles GoToRegisterBtn.MouseHover
        GoToRegisterBtn.ForeColor = Color.FromArgb(0, 173, 181)
    End Sub

    Private Sub GoToRegisterBtn_MouseLeave(sender As Object, e As EventArgs) Handles GoToRegisterBtn.MouseLeave
        GoToRegisterBtn.ForeColor = Color.FromArgb(28, 27, 31)
    End Sub

    ' Register User
    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        If RegisterPasswordTextBox.Text = RegisterCPasswordTextBox.Text Then
            If RegisterPasswordTextBox.Text.Length >= 6 Then
                Try
                    openCon()
                    Using cmd As New MySqlCommand("INSERT INTO user (userName, userPassword) VALUES (@UserName, @UserPassword)", con)

                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@UserName", RegisterNameTextBox.Text)
                        cmd.Parameters.AddWithValue("@UserPassword", RegisterPasswordTextBox.Text)

                        If MsgBox("Do you want to register with these credentials?", MsgBoxStyle.YesNo) = vbYes Then
                            cmd.ExecuteNonQuery()
                            MsgBox("Account Registered")

                            ClearRegisterTextBoxes()
                            ClearLoginTextBoxes()
                        End If
                    End Using
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                Finally
                    con.Close()
                End Try
            Else
                MsgBox("Password must have 6 or more characters. Please try again.")
            End If
        Else
            MsgBox("Passwords do not match. Please try again.")
        End If
    End Sub


    ' Login User
    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Try
            openCon()
            Using cmd As New MySqlCommand("SELECT * FROM user WHERE userName=@UserName AND userPassword=@UserPassword", con)

                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@UserName", LoginNameTextBox.Text)
                cmd.Parameters.AddWithValue("@UserPassword", LoginPasswordTextBox.Text)

                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If

                Using reader As MySqlDataReader = cmd.ExecuteReader
                    If reader.Read() Then
                        MsgBox("Login successful!")

                        ClearRegisterTextBoxes()
                        ClearLoginTextBoxes()

                        Dim MainForm As New MainForm
                        MainForm.Show()
                        Me.Hide()
                    Else
                        MsgBox("Invalid username or password. Please try again.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub ClearRegisterTextBoxes()
        RegisterNameTextBox.Text = ""
        RegisterPasswordTextBox.Text = ""
        RegisterCPasswordTextBox.Text = ""
    End Sub

    Private Sub ClearLoginTextBoxes()
        LoginNameTextBox.Text = ""
        LoginPasswordTextBox.Text = ""
    End Sub

End Class