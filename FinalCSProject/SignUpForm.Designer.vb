<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUpForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignUpForm))
        btn_sign = New Button()
        txtbox_password = New TextBox()
        txtbox_username = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        btn_cancel = New Button()
        SuspendLayout()
        ' 
        ' btn_sign
        ' 
        btn_sign.BackColor = Color.FromArgb(CByte(86), CByte(102), CByte(216))
        btn_sign.Cursor = Cursors.Hand
        btn_sign.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(48), CByte(73))
        btn_sign.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(106), CByte(122), CByte(236))
        btn_sign.FlatStyle = FlatStyle.Flat
        btn_sign.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_sign.ForeColor = Color.White
        btn_sign.Location = New Point(226, 466)
        btn_sign.Name = "btn_sign"
        btn_sign.Size = New Size(365, 41)
        btn_sign.TabIndex = 11
        btn_sign.Text = "Sign Up"
        btn_sign.UseVisualStyleBackColor = False
        ' 
        ' txtbox_password
        ' 
        txtbox_password.Cursor = Cursors.IBeam
        txtbox_password.Font = New Font("Segoe UI", 11F)
        txtbox_password.Location = New Point(226, 405)
        txtbox_password.Name = "txtbox_password"
        txtbox_password.PasswordChar = "•"c
        txtbox_password.Size = New Size(365, 32)
        txtbox_password.TabIndex = 10
        ' 
        ' txtbox_username
        ' 
        txtbox_username.Cursor = Cursors.IBeam
        txtbox_username.Font = New Font("Segoe UI", 11F)
        txtbox_username.Location = New Point(226, 309)
        txtbox_username.Name = "txtbox_username"
        txtbox_username.Size = New Size(365, 32)
        txtbox_username.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Heebo", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(226, 357)
        Label2.Name = "Label2"
        Label2.Size = New Size(124, 34)
        Label2.TabIndex = 8
        Label2.Text = "Password:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Heebo", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(226, 261)
        Label1.Name = "Label1"
        Label1.Size = New Size(126, 34)
        Label1.TabIndex = 7
        Label1.Text = "Username:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 28.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(299, 174)
        Label3.Name = "Label3"
        Label3.Size = New Size(192, 62)
        Label3.TabIndex = 12
        Label3.Text = "Sign Up"
        ' 
        ' btn_cancel
        ' 
        btn_cancel.BackColor = Color.FromArgb(CByte(0), CByte(48), CByte(73))
        btn_cancel.Cursor = Cursors.Hand
        btn_cancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(48), CByte(73))
        btn_cancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(106), CByte(122), CByte(236))
        btn_cancel.FlatStyle = FlatStyle.Flat
        btn_cancel.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_cancel.ForeColor = Color.White
        btn_cancel.Location = New Point(226, 519)
        btn_cancel.Name = "btn_cancel"
        btn_cancel.Size = New Size(365, 41)
        btn_cancel.TabIndex = 13
        btn_cancel.Text = "Cancel"
        btn_cancel.UseVisualStyleBackColor = False
        ' 
        ' SignUpForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1262, 673)
        Controls.Add(btn_cancel)
        Controls.Add(Label3)
        Controls.Add(btn_sign)
        Controls.Add(txtbox_password)
        Controls.Add(txtbox_username)
        Controls.Add(Label2)
        Controls.Add(Label1)
        MaximizeBox = False
        Name = "SignUpForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sign Up"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_sign As Button
    Friend WithEvents txtbox_password As TextBox
    Friend WithEvents txtbox_username As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_cancel As Button
End Class
