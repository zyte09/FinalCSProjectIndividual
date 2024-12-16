Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Markup
Imports MySql.Data.MySqlClient

Public Class Mainform
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable
    Dim gender As String

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        LoginForm.Show()
        Me.Hide()
        Close()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=FinalCSProject"
        Dim READER As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "INSERT INTO data (ID, name, surname, age, gender, dob) " &
            "VALUES('" & ID_text.Text & "', '" & name_text.Text & "', '" & surname_text.Text & "', '" & age_text.Text & "', '" & gender & "', '" & dtp_dob.Text & "')"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader
            MsgBox("Data saved successfully!")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        load_table()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=FinalCSProject"
        Dim READER As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "UPDATE data SET ID = '" & ID_text.Text & "', name = '" & name_text.Text & "', surname = '" & surname_text.Text & "', age = '" & age_text.Text & "' WHERE ID = '" & ID_text.Text & "'"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader
            MsgBox("Data updated successfully!")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        load_table()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=FinalCSProject"
        Try
            conn.Open()
            Dim Query As String
            Query = "DELETE FROM data WHERE ID = '" & ID_text.Text & "'"
            COMMAND = New MySqlCommand(Query, conn)
            MsgBox("Data deleted successfully!")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        load_table()
    End Sub

    Private Sub Mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_table()
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=FinalCSProject"
        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT * FROM data"
            COMMAND = New MySqlCommand(Query, conn)
            Dim READER As MySqlDataReader = COMMAND.ExecuteReader
            While READER.Read
                Dim sName = READER.GetString("name")
                cmb_name.Items.Add(sName)
                ListBox1.Items.Add(sName)
            End While
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub cmb_name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_name.SelectedIndexChanged
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=FinalCSProject"
        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT * FROM data WHERE name='" & cmb_name.Text & "'"
            COMMAND = New MySqlCommand(Query, conn)
            Dim READER As MySqlDataReader = COMMAND.ExecuteReader
            While READER.Read
                ID_text.Text = READER.GetInt32("ID")
                name_text.Text = READER.GetString("name")
                surname_text.Text = READER.GetString("surname")
                age_text.Text = READER.GetInt32("age")

            End While
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=FinalCSProject"
        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT * FROM data WHERE name='" & ListBox1.Text & "'"
            COMMAND = New MySqlCommand(Query, conn)
            Dim READER As MySqlDataReader = COMMAND.ExecuteReader
            While READER.Read
                ID_text.Text = READER.GetInt32("ID")
                name_text.Text = READER.GetString("name")
                surname_text.Text = READER.GetString("surname")
                age_text.Text = READER.GetInt32("age")

            End While
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub load_table()
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=FinalCSProject"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource
        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT id AS 'Employee ID',name AS 'First Name',surname AS 'Last Name',age AS 'Age' FROM data"
            COMMAND = New MySqlCommand(Query, conn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub btn_loadtable_Click(sender As Object, e As EventArgs) Handles btn_loadtable.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=FinalCSProject"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT id,name,surname,age FROM data"
            COMMAND = New MySqlCommand(Query, conn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DataGridView1.SelectedRows(0)

            If DataGridView1.Columns.Contains("Employee ID") Then
                ID_text.Text = row.Cells("Employee ID").Value.ToString()
            Else
                ID_text.Text = "default_id"
            End If

            If DataGridView1.Columns.Contains("First Name") Then
                name_text.Text = row.Cells("First Name").Value.ToString()
            Else
                name_text.Text = "default_name"
            End If

            If DataGridView1.Columns.Contains("Last Name") Then
                surname_text.Text = row.Cells("Last Name").Value.ToString()
            Else
                surname_text.Text = "default_surname"
            End If

            If DataGridView1.Columns.Contains("Age") Then
                age_text.Text = row.Cells("Age").Value.ToString()
            Else
                age_text.Text = "default_age"
            End If
        End If
    End Sub

    Private Sub search_txt_TextChanged(sender As Object, e As EventArgs) Handles search_txt.TextChanged
        Dim filter As String = String.Empty
        Dim searchValue As String = search_txt.Text

        If dbDataSet.Columns.Contains("First Name") Then
            filter &= String.Format("[First Name] LIKE '%{0}%'", searchValue)
        End If

        If dbDataSet.Columns.Contains("Last Name") Then
            If Not String.IsNullOrEmpty(filter) Then
                filter &= " OR "
            End If
            filter &= String.Format("[Last Name] LIKE '%{0}%'", searchValue)
        End If

        If dbDataSet.Columns.Contains("Age") Then
            If Not String.IsNullOrEmpty(filter) Then
                filter &= " OR "
            End If
            filter &= String.Format("CONVERT([Age], 'System.String') LIKE '%{0}%'", searchValue)
        End If

        If dbDataSet.Columns.Contains("Employee ID") Then
            If Not String.IsNullOrEmpty(filter) Then
                filter &= " OR "
            End If
            filter &= String.Format("CONVERT([Employee ID], 'System.String') LIKE '%{0}%'", searchValue)
        End If

        If Not String.IsNullOrEmpty(filter) Then
            Dim DV As New DataView(dbDataSet)
            DV.RowFilter = filter
            DataGridView1.DataSource = DV
        Else
            MessageBox.Show("No searchable columns found.")
        End If
    End Sub

    Private Sub Mainform_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you really want to close the application?", "Exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub

    Private Sub rd_male_CheckedChanged(sender As Object, e As EventArgs) Handles rd_male.CheckedChanged
        gender = "Male"
    End Sub

    Private Sub rd_female_CheckedChanged(sender As Object, e As EventArgs) Handles rd_female.CheckedChanged
        gender = "Female"
    End Sub

    Private Sub rd_other_CheckedChanged(sender As Object, e As EventArgs) Handles rd_other.CheckedChanged
        gender = "Other"
    End Sub

    Private Sub btn_loadchart_Click(sender As Object, e As EventArgs) Handles btn_loadchart.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=FinalCSProject"
        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT ID, age FROM data"
            COMMAND = New MySqlCommand(Query, conn)
            Dim READER As MySqlDataReader = COMMAND.ExecuteReader

            Chart1.Series.Clear()
            Dim series As New Series("ID_VS_AGE")

            While READER.Read
                series.Points.AddXY(READER.GetInt32("ID"), READER.GetInt32("age"))
            End While

            Chart1.Series.Add(series)
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class