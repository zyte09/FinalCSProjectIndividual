<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mainform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mainform))
        btn_logout = New Button()
        ID_label = New Label()
        ID_text = New TextBox()
        name_label = New Label()
        name_text = New TextBox()
        surname_label = New Label()
        surname_text = New TextBox()
        age_label = New Label()
        age_text = New TextBox()
        btn_save = New Button()
        btn_update = New Button()
        btn_delete = New Button()
        cmb_name = New ComboBox()
        ListBox1 = New ListBox()
        DataGridView1 = New DataGridView()
        btn_loadtable = New Button()
        search_txt = New TextBox()
        rd_male = New RadioButton()
        rd_female = New RadioButton()
        dtp_dob = New DateTimePicker()
        dob_label = New Label()
        user_input = New Panel()
        rd_other = New RadioButton()
        buttons = New Panel()
        Panel1 = New Panel()
        btn_loadchart = New Button()
        Chart1 = New DataVisualization.Charting.Chart()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        user_input.SuspendLayout()
        buttons.SuspendLayout()
        Panel1.SuspendLayout()
        CType(Chart1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btn_logout
        ' 
        btn_logout.BackColor = Color.FromArgb(CByte(86), CByte(102), CByte(216))
        btn_logout.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(13), CByte(20))
        btn_logout.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(48), CByte(73))
        btn_logout.FlatStyle = FlatStyle.Flat
        btn_logout.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_logout.ForeColor = Color.White
        btn_logout.Location = New Point(142, 85)
        btn_logout.Name = "btn_logout"
        btn_logout.Size = New Size(106, 51)
        btn_logout.TabIndex = 0
        btn_logout.Text = "Logout"
        btn_logout.UseVisualStyleBackColor = False
        ' 
        ' ID_label
        ' 
        ID_label.AutoSize = True
        ID_label.Font = New Font("Segoe UI", 12F)
        ID_label.ForeColor = Color.White
        ID_label.Location = New Point(24, 35)
        ID_label.Name = "ID_label"
        ID_label.Size = New Size(31, 28)
        ID_label.TabIndex = 1
        ID_label.Text = "ID"
        ' 
        ' ID_text
        ' 
        ID_text.BorderStyle = BorderStyle.FixedSingle
        ID_text.Font = New Font("Segoe UI", 12F)
        ID_text.Location = New Point(130, 35)
        ID_text.Name = "ID_text"
        ID_text.PlaceholderText = "1"
        ID_text.Size = New Size(259, 34)
        ID_text.TabIndex = 2
        ' 
        ' name_label
        ' 
        name_label.AutoSize = True
        name_label.Font = New Font("Segoe UI", 12F)
        name_label.ForeColor = Color.White
        name_label.Location = New Point(24, 94)
        name_label.Name = "name_label"
        name_label.Size = New Size(102, 28)
        name_label.TabIndex = 1
        name_label.Text = "First name"
        ' 
        ' name_text
        ' 
        name_text.BorderStyle = BorderStyle.FixedSingle
        name_text.Font = New Font("Segoe UI", 12F)
        name_text.Location = New Point(130, 93)
        name_text.Name = "name_text"
        name_text.PlaceholderText = "John"
        name_text.Size = New Size(259, 34)
        name_text.TabIndex = 2
        ' 
        ' surname_label
        ' 
        surname_label.AutoSize = True
        surname_label.Font = New Font("Segoe UI", 12F)
        surname_label.ForeColor = Color.White
        surname_label.Location = New Point(24, 153)
        surname_label.Name = "surname_label"
        surname_label.Size = New Size(99, 28)
        surname_label.TabIndex = 1
        surname_label.Text = "Last name"
        ' 
        ' surname_text
        ' 
        surname_text.BorderStyle = BorderStyle.FixedSingle
        surname_text.Font = New Font("Segoe UI", 12F)
        surname_text.Location = New Point(130, 151)
        surname_text.Name = "surname_text"
        surname_text.PlaceholderText = "Smith"
        surname_text.Size = New Size(259, 34)
        surname_text.TabIndex = 2
        ' 
        ' age_label
        ' 
        age_label.AutoSize = True
        age_label.Font = New Font("Segoe UI", 12F)
        age_label.ForeColor = Color.White
        age_label.Location = New Point(24, 212)
        age_label.Name = "age_label"
        age_label.Size = New Size(47, 28)
        age_label.TabIndex = 1
        age_label.Text = "Age"
        ' 
        ' age_text
        ' 
        age_text.BorderStyle = BorderStyle.FixedSingle
        age_text.Font = New Font("Segoe UI", 12F)
        age_text.Location = New Point(130, 209)
        age_text.Name = "age_text"
        age_text.PlaceholderText = "25"
        age_text.Size = New Size(259, 34)
        age_text.TabIndex = 2
        ' 
        ' btn_save
        ' 
        btn_save.BackColor = Color.FromArgb(CByte(86), CByte(102), CByte(216))
        btn_save.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(13), CByte(20))
        btn_save.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(48), CByte(73))
        btn_save.FlatStyle = FlatStyle.Flat
        btn_save.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_save.ForeColor = Color.White
        btn_save.Location = New Point(16, 17)
        btn_save.Name = "btn_save"
        btn_save.Size = New Size(106, 51)
        btn_save.TabIndex = 0
        btn_save.Text = "Save"
        btn_save.UseVisualStyleBackColor = False
        ' 
        ' btn_update
        ' 
        btn_update.BackColor = Color.FromArgb(CByte(86), CByte(102), CByte(216))
        btn_update.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(13), CByte(20))
        btn_update.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(48), CByte(73))
        btn_update.FlatStyle = FlatStyle.Flat
        btn_update.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_update.ForeColor = Color.White
        btn_update.Location = New Point(142, 17)
        btn_update.Name = "btn_update"
        btn_update.Size = New Size(106, 51)
        btn_update.TabIndex = 0
        btn_update.Text = "Update"
        btn_update.UseVisualStyleBackColor = False
        ' 
        ' btn_delete
        ' 
        btn_delete.BackColor = Color.FromArgb(CByte(86), CByte(102), CByte(216))
        btn_delete.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(13), CByte(20))
        btn_delete.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(48), CByte(73))
        btn_delete.FlatStyle = FlatStyle.Flat
        btn_delete.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_delete.ForeColor = Color.White
        btn_delete.Location = New Point(16, 85)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(106, 51)
        btn_delete.TabIndex = 3
        btn_delete.Text = "Delete"
        btn_delete.UseVisualStyleBackColor = False
        ' 
        ' cmb_name
        ' 
        cmb_name.Font = New Font("Segoe UI", 12F)
        cmb_name.FormattingEnabled = True
        cmb_name.Location = New Point(24, 253)
        cmb_name.Name = "cmb_name"
        cmb_name.Size = New Size(249, 36)
        cmb_name.TabIndex = 4
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(24, 320)
        ListBox1.Name = "ListBox1"
        ListBox1.ScrollAlwaysVisible = True
        ListBox1.Size = New Size(249, 44)
        ListBox1.TabIndex = 5
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.Window
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(24, 21)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(413, 134)
        DataGridView1.TabIndex = 6
        ' 
        ' btn_loadtable
        ' 
        btn_loadtable.BackColor = Color.White
        btn_loadtable.FlatStyle = FlatStyle.Popup
        btn_loadtable.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_loadtable.Location = New Point(297, 174)
        btn_loadtable.Name = "btn_loadtable"
        btn_loadtable.Size = New Size(140, 51)
        btn_loadtable.TabIndex = 7
        btn_loadtable.Text = "Load Table"
        btn_loadtable.UseVisualStyleBackColor = False
        ' 
        ' search_txt
        ' 
        search_txt.Font = New Font("Segoe UI", 12F)
        search_txt.Location = New Point(24, 174)
        search_txt.Name = "search_txt"
        search_txt.PlaceholderText = "Search"
        search_txt.Size = New Size(249, 34)
        search_txt.TabIndex = 8
        ' 
        ' rd_male
        ' 
        rd_male.AutoSize = True
        rd_male.Font = New Font("Segoe UI", 12F)
        rd_male.ForeColor = Color.White
        rd_male.Location = New Point(24, 267)
        rd_male.Name = "rd_male"
        rd_male.Size = New Size(76, 32)
        rd_male.TabIndex = 9
        rd_male.TabStop = True
        rd_male.Text = "Male"
        rd_male.UseVisualStyleBackColor = True
        ' 
        ' rd_female
        ' 
        rd_female.AutoSize = True
        rd_female.Font = New Font("Segoe UI", 12F)
        rd_female.ForeColor = Color.White
        rd_female.Location = New Point(126, 267)
        rd_female.Name = "rd_female"
        rd_female.Size = New Size(95, 32)
        rd_female.TabIndex = 10
        rd_female.TabStop = True
        rd_female.Text = "Female"
        rd_female.UseVisualStyleBackColor = True
        ' 
        ' dtp_dob
        ' 
        dtp_dob.CalendarFont = New Font("Segoe UI", 12F)
        dtp_dob.CustomFormat = "yyyy-MM-dd"
        dtp_dob.Format = DateTimePickerFormat.Custom
        dtp_dob.Location = New Point(153, 331)
        dtp_dob.Name = "dtp_dob"
        dtp_dob.Size = New Size(236, 27)
        dtp_dob.TabIndex = 11
        ' 
        ' dob_label
        ' 
        dob_label.AutoSize = True
        dob_label.Font = New Font("Segoe UI", 12F)
        dob_label.ForeColor = Color.White
        dob_label.Location = New Point(24, 329)
        dob_label.Name = "dob_label"
        dob_label.Size = New Size(123, 28)
        dob_label.TabIndex = 12
        dob_label.Text = "Date of birth"
        ' 
        ' user_input
        ' 
        user_input.BackColor = Color.FromArgb(CByte(0), CByte(48), CByte(73))
        user_input.BorderStyle = BorderStyle.Fixed3D
        user_input.Controls.Add(rd_other)
        user_input.Controls.Add(ID_label)
        user_input.Controls.Add(dob_label)
        user_input.Controls.Add(ID_text)
        user_input.Controls.Add(dtp_dob)
        user_input.Controls.Add(name_label)
        user_input.Controls.Add(rd_female)
        user_input.Controls.Add(name_text)
        user_input.Controls.Add(rd_male)
        user_input.Controls.Add(surname_label)
        user_input.Controls.Add(surname_text)
        user_input.Controls.Add(age_label)
        user_input.Controls.Add(age_text)
        user_input.Location = New Point(25, 172)
        user_input.Name = "user_input"
        user_input.Size = New Size(416, 403)
        user_input.TabIndex = 13
        ' 
        ' rd_other
        ' 
        rd_other.AutoSize = True
        rd_other.Font = New Font("Segoe UI", 12F)
        rd_other.ForeColor = Color.White
        rd_other.Location = New Point(247, 267)
        rd_other.Name = "rd_other"
        rd_other.Size = New Size(83, 32)
        rd_other.TabIndex = 13
        rd_other.TabStop = True
        rd_other.Text = "Other"
        rd_other.UseVisualStyleBackColor = True
        ' 
        ' buttons
        ' 
        buttons.BackColor = Color.FromArgb(CByte(200), CByte(200), CByte(255))
        buttons.Controls.Add(btn_update)
        buttons.Controls.Add(btn_logout)
        buttons.Controls.Add(btn_save)
        buttons.Controls.Add(btn_delete)
        buttons.Location = New Point(590, 599)
        buttons.Name = "buttons"
        buttons.Size = New Size(267, 148)
        buttons.TabIndex = 14
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(48), CByte(73))
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(btn_loadtable)
        Panel1.Controls.Add(cmb_name)
        Panel1.Controls.Add(ListBox1)
        Panel1.Controls.Add(search_txt)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Location = New Point(466, 172)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(461, 403)
        Panel1.TabIndex = 15
        ' 
        ' btn_loadchart
        ' 
        btn_loadchart.BackColor = Color.White
        btn_loadchart.FlatStyle = FlatStyle.Popup
        btn_loadchart.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_loadchart.Location = New Point(1178, 553)
        btn_loadchart.Name = "btn_loadchart"
        btn_loadchart.Size = New Size(140, 51)
        btn_loadchart.TabIndex = 16
        btn_loadchart.Text = "Load Chart"
        btn_loadchart.UseVisualStyleBackColor = False
        ' 
        ' Chart1
        ' 
        ChartArea1.Name = "ChartArea1"
        Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Chart1.Legends.Add(Legend1)
        Chart1.Location = New Point(958, 172)
        Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "ID_VS_AGE"
        Chart1.Series.Add(Series1)
        Chart1.Size = New Size(583, 375)
        Chart1.TabIndex = 17
        Chart1.Text = "Chart1"
        ' 
        ' Mainform
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(1553, 747)
        Controls.Add(Chart1)
        Controls.Add(btn_loadchart)
        Controls.Add(buttons)
        Controls.Add(Panel1)
        Controls.Add(user_input)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.Fixed3D
        MaximizeBox = False
        Name = "Mainform"
        StartPosition = FormStartPosition.CenterScreen
        Text = " "
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        user_input.ResumeLayout(False)
        user_input.PerformLayout()
        buttons.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(Chart1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btn_logout As Button
    Friend WithEvents ID_label As Label
    Friend WithEvents ID_text As TextBox
    Friend WithEvents name_label As Label
    Friend WithEvents name_text As TextBox
    Friend WithEvents surname_label As Label
    Friend WithEvents surname_text As TextBox
    Friend WithEvents age_label As Label
    Friend WithEvents age_text As TextBox
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents cmb_name As ComboBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_loadtable As Button
    Friend WithEvents search_txt As TextBox
    Friend WithEvents rd_male As RadioButton
    Friend WithEvents rd_female As RadioButton
    Friend WithEvents dtp_dob As DateTimePicker
    Friend WithEvents dob_label As Label
    Friend WithEvents user_input As Panel
    Friend WithEvents buttons As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rd_other As RadioButton
    Friend WithEvents btn_loadchart As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
End Class
