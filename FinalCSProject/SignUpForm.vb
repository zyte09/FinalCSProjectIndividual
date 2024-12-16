Imports MySql.Data.MySqlClient

Public Class SignUpForm
    Private Sub btn_sign_Click(sender As Object, e As EventArgs) Handles btn_sign.Click
        Dim username As String = txtbox_username.Text
        Dim password As String = txtbox_password.Text

        Dim conn As New MySqlConnection("server=127.0.0.1;userid=root;password='';database=FinalCSProject")
        Try
            conn.Open()
            Dim query As String = "INSERT INTO data (name, surname, age, username, password, Gender, DOB) VALUES ('default_name', 'default_surname', 0, @username, @password, 'Other', '2000-01-01')"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Sign-up successful!")
            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        LoginForm.Show()
        Me.Close()
    End Sub

    Private Sub SignUpForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        LoginForm.Show()
    End Sub
End Class
