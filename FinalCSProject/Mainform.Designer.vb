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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
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
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btn_logout
        ' 
        btn_logout.FlatStyle = FlatStyle.Popup
        btn_logout.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_logout.Location = New Point(428, 384)
        btn_logout.Name = "btn_logout"
        btn_logout.Size = New Size(106, 51)
        btn_logout.TabIndex = 0
        btn_logout.Text = "Logout"
        btn_logout.UseVisualStyleBackColor = True
        ' 
        ' ID_label
        ' 
        ID_label.AutoSize = True
        ID_label.Font = New Font("Segoe UI", 12F)
        ID_label.Location = New Point(12, 23)
        ID_label.Name = "ID_label"
        ID_label.Size = New Size(31, 28)
        ID_label.TabIndex = 1
        ID_label.Text = "ID"
        ' 
        ' ID_text
        ' 
        ID_text.Font = New Font("Segoe UI", 12F)
        ID_text.Location = New Point(121, 20)
        ID_text.Name = "ID_text"
        ID_text.Size = New Size(154, 34)
        ID_text.TabIndex = 2
        ' 
        ' name_label
        ' 
        name_label.AutoSize = True
        name_label.Font = New Font("Segoe UI", 12F)
        name_label.Location = New Point(12, 79)
        name_label.Name = "name_label"
        name_label.Size = New Size(64, 28)
        name_label.TabIndex = 1
        name_label.Text = "Name"
        ' 
        ' name_text
        ' 
        name_text.Font = New Font("Segoe UI", 12F)
        name_text.Location = New Point(121, 76)
        name_text.Name = "name_text"
        name_text.Size = New Size(154, 34)
        name_text.TabIndex = 2
        ' 
        ' surname_label
        ' 
        surname_label.AutoSize = True
        surname_label.Font = New Font("Segoe UI", 12F)
        surname_label.Location = New Point(12, 147)
        surname_label.Name = "surname_label"
        surname_label.Size = New Size(89, 28)
        surname_label.TabIndex = 1
        surname_label.Text = "Surname"
        ' 
        ' surname_text
        ' 
        surname_text.Font = New Font("Segoe UI", 12F)
        surname_text.Location = New Point(121, 144)
        surname_text.Name = "surname_text"
        surname_text.Size = New Size(154, 34)
        surname_text.TabIndex = 2
        ' 
        ' age_label
        ' 
        age_label.AutoSize = True
        age_label.Font = New Font("Segoe UI", 12F)
        age_label.Location = New Point(12, 206)
        age_label.Name = "age_label"
        age_label.Size = New Size(47, 28)
        age_label.TabIndex = 1
        age_label.Text = "Age"
        ' 
        ' age_text
        ' 
        age_text.Font = New Font("Segoe UI", 12F)
        age_text.Location = New Point(121, 203)
        age_text.Name = "age_text"
        age_text.Size = New Size(154, 34)
        age_text.TabIndex = 2
        ' 
        ' btn_save
        ' 
        btn_save.FlatStyle = FlatStyle.Popup
        btn_save.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_save.Location = New Point(302, 316)
        btn_save.Name = "btn_save"
        btn_save.Size = New Size(106, 51)
        btn_save.TabIndex = 0
        btn_save.Text = "Save"
        btn_save.UseVisualStyleBackColor = True
        ' 
        ' btn_update
        ' 
        btn_update.FlatStyle = FlatStyle.Popup
        btn_update.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_update.Location = New Point(428, 316)
        btn_update.Name = "btn_update"
        btn_update.Size = New Size(106, 51)
        btn_update.TabIndex = 0
        btn_update.Text = "Update"
        btn_update.UseVisualStyleBackColor = True
        ' 
        ' btn_delete
        ' 
        btn_delete.FlatStyle = FlatStyle.Popup
        btn_delete.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_delete.Location = New Point(302, 384)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(106, 51)
        btn_delete.TabIndex = 3
        btn_delete.Text = "Delete"
        btn_delete.UseVisualStyleBackColor = True
        ' 
        ' cmb_name
        ' 
        cmb_name.Font = New Font("Segoe UI", 12F)
        cmb_name.FormattingEnabled = True
        cmb_name.Location = New Point(293, 20)
        cmb_name.Name = "cmb_name"
        cmb_name.Size = New Size(225, 36)
        cmb_name.TabIndex = 4
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(539, 20)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(249, 44)
        ListBox1.TabIndex = 5
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(302, 72)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(471, 134)
        DataGridView1.TabIndex = 6
        ' 
        ' btn_loadtable
        ' 
        btn_loadtable.FlatStyle = FlatStyle.Popup
        btn_loadtable.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_loadtable.Location = New Point(302, 226)
        btn_loadtable.Name = "btn_loadtable"
        btn_loadtable.Size = New Size(140, 51)
        btn_loadtable.TabIndex = 7
        btn_loadtable.Text = "Load Table"
        btn_loadtable.UseVisualStyleBackColor = True
        ' 
        ' search_txt
        ' 
        search_txt.Font = New Font("Segoe UI", 12F)
        search_txt.Location = New Point(469, 234)
        search_txt.Name = "search_txt"
        search_txt.Size = New Size(194, 34)
        search_txt.TabIndex = 8
        ' 
        ' rd_male
        ' 
        rd_male.AutoSize = True
        rd_male.Font = New Font("Segoe UI", 12F)
        rd_male.Location = New Point(39, 266)
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
        rd_female.Location = New Point(138, 266)
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
        dtp_dob.Location = New Point(93, 316)
        dtp_dob.Name = "dtp_dob"
        dtp_dob.Size = New Size(158, 27)
        dtp_dob.TabIndex = 11
        ' 
        ' dob_label
        ' 
        dob_label.AutoSize = True
        dob_label.Font = New Font("Segoe UI", 12F)
        dob_label.Location = New Point(12, 314)
        dob_label.Name = "dob_label"
        dob_label.Size = New Size(47, 28)
        dob_label.TabIndex = 12
        dob_label.Text = "Age"
        ' 
        ' Mainform
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dob_label)
        Controls.Add(dtp_dob)
        Controls.Add(rd_female)
        Controls.Add(rd_male)
        Controls.Add(search_txt)
        Controls.Add(btn_loadtable)
        Controls.Add(DataGridView1)
        Controls.Add(ListBox1)
        Controls.Add(cmb_name)
        Controls.Add(btn_delete)
        Controls.Add(age_text)
        Controls.Add(age_label)
        Controls.Add(surname_text)
        Controls.Add(surname_label)
        Controls.Add(name_text)
        Controls.Add(name_label)
        Controls.Add(ID_text)
        Controls.Add(ID_label)
        Controls.Add(btn_update)
        Controls.Add(btn_save)
        Controls.Add(btn_logout)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "Mainform"
        Text = "Mainform"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
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
End Class
