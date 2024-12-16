<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        btn_connect = New Button()
        Label1 = New Label()
        Label2 = New Label()
        txtbox_username = New TextBox()
        txtbox_password = New TextBox()
        btn_login = New Button()
        btn_signup = New Button()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' btn_connect
        ' 
        btn_connect.BackColor = Color.FromArgb(CByte(0), CByte(48), CByte(73))
        btn_connect.Cursor = Cursors.Hand
        btn_connect.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(48), CByte(73))
        btn_connect.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(106), CByte(122), CByte(236))
        btn_connect.FlatStyle = FlatStyle.Flat
        btn_connect.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_connect.ForeColor = Color.White
        btn_connect.Location = New Point(231, 521)
        btn_connect.Name = "btn_connect"
        btn_connect.Size = New Size(365, 41)
        btn_connect.TabIndex = 0
        btn_connect.Text = "Connection"
        btn_connect.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Heebo", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(231, 242)
        Label1.Name = "Label1"
        Label1.Size = New Size(126, 34)
        Label1.TabIndex = 1
        Label1.Text = "Username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Heebo", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(231, 322)
        Label2.Name = "Label2"
        Label2.Size = New Size(124, 34)
        Label2.TabIndex = 2
        Label2.Text = "Password:"
        ' 
        ' txtbox_username
        ' 
        txtbox_username.Cursor = Cursors.IBeam
        txtbox_username.Font = New Font("Segoe UI", 11F)
        txtbox_username.Location = New Point(231, 282)
        txtbox_username.Name = "txtbox_username"
        txtbox_username.Size = New Size(365, 32)
        txtbox_username.TabIndex = 3
        ' 
        ' txtbox_password
        ' 
        txtbox_password.Cursor = Cursors.IBeam
        txtbox_password.Font = New Font("Segoe UI", 11F)
        txtbox_password.Location = New Point(231, 362)
        txtbox_password.Name = "txtbox_password"
        txtbox_password.PasswordChar = "•"c
        txtbox_password.Size = New Size(365, 32)
        txtbox_password.TabIndex = 4
        ' 
        ' btn_login
        ' 
        btn_login.BackColor = Color.FromArgb(CByte(86), CByte(102), CByte(216))
        btn_login.Cursor = Cursors.Hand
        btn_login.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(48), CByte(73))
        btn_login.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(106), CByte(122), CByte(236))
        btn_login.FlatStyle = FlatStyle.Flat
        btn_login.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_login.ForeColor = Color.White
        btn_login.Location = New Point(231, 415)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(365, 42)
        btn_login.TabIndex = 5
        btn_login.Text = "Login"
        btn_login.UseVisualStyleBackColor = False
        ' 
        ' btn_signup
        ' 
        btn_signup.BackColor = Color.FromArgb(CByte(86), CByte(102), CByte(216))
        btn_signup.Cursor = Cursors.Hand
        btn_signup.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(48), CByte(73))
        btn_signup.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(106), CByte(122), CByte(236))
        btn_signup.FlatStyle = FlatStyle.Flat
        btn_signup.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_signup.ForeColor = Color.White
        btn_signup.Location = New Point(231, 468)
        btn_signup.Name = "btn_signup"
        btn_signup.Size = New Size(365, 42)
        btn_signup.TabIndex = 6
        btn_signup.Text = "Sign Up"
        btn_signup.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 28.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(323, 156)
        Label3.Name = "Label3"
        Label3.Size = New Size(144, 62)
        Label3.TabIndex = 13
        Label3.Text = "Login"
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1262, 673)
        Controls.Add(Label3)
        Controls.Add(btn_signup)
        Controls.Add(btn_login)
        Controls.Add(txtbox_password)
        Controls.Add(txtbox_username)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btn_connect)
        MaximizeBox = False
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_connect As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbox_username As TextBox
    Friend WithEvents txtbox_password As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents btn_signup As Button
    Friend WithEvents Label3 As Label

End Class
