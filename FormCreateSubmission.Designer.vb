<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCreateSubmission
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblGithub = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtGithub = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()

        ' 
        ' lblName
        ' 
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 15)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        ' 
        ' lblEmail
        ' 
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(12, 41)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 1
        Me.lblEmail.Text = "Email:"
        ' 
        ' lblPhone
        ' 
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(12, 67)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(78, 13)
        Me.lblPhone.TabIndex = 2
        Me.lblPhone.Text = "Phone Number:"
        ' 
        ' lblGithub
        ' 
        Me.lblGithub.AutoSize = True
        Me.lblGithub.Location = New System.Drawing.Point(12, 93)
        Me.lblGithub.Name = "lblGithub"
        Me.lblGithub.Size = New System.Drawing.Size(65, 13)
        Me.lblGithub.TabIndex = 3
        Me.lblGithub.Text = "GitHub Link:"
        ' 
        ' txtName
        ' 
        Me.txtName.ForeColor = System.Drawing.Color.Gray
        Me.txtName.Location = New System.Drawing.Point(96, 12)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(176, 20)
        Me.txtName.TabIndex = 4
        Me.txtName.Text = "Name"
        ' 
        ' txtEmail
        ' 
        Me.txtEmail.ForeColor = System.Drawing.Color.Gray
        Me.txtEmail.Location = New System.Drawing.Point(96, 38)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(176, 20)
        Me.txtEmail.TabIndex = 5
        Me.txtEmail.Text = "Email"
        ' 
        ' txtPhone
        ' 
        Me.txtPhone.ForeColor = System.Drawing.Color.Gray
        Me.txtPhone.Location = New System.Drawing.Point(96, 64)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(176, 20)
        Me.txtPhone.TabIndex = 6
        Me.txtPhone.Text = "Phone Number"
        ' 
        ' txtGithub
        ' 
        Me.txtGithub.ForeColor = System.Drawing.Color.Gray
        Me.txtGithub.Location = New System.Drawing.Point(96, 90)
        Me.txtGithub.Name = "txtGithub"
        Me.txtGithub.Size = New System.Drawing.Size(176, 20)
        Me.txtGithub.TabIndex = 7
        Me.txtGithub.Text = "GitHub Link"
        ' 
        ' btnSubmit
        ' 
        Me.btnSubmit.Location = New System.Drawing.Point(96, 116)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(176, 23)
        Me.btnSubmit.TabIndex = 8
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' FormCreateSubmission
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 151)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtGithub)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblGithub)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblName)
        Me.Name = "FormCreateSubmission"
        Me.Text = "Create New Submission"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblName As System.Windows.Forms.Label
    Private WithEvents lblEmail As System.Windows.Forms.Label
    Private WithEvents lblPhone As System.Windows.Forms.Label
    Private WithEvents lblGithub As System.Windows.Forms.Label
    Private WithEvents txtName As System.Windows.Forms.TextBox
    Private WithEvents txtEmail As System.Windows.Forms.TextBox
    Private WithEvents txtPhone As System.Windows.Forms.TextBox
    Private WithEvents txtGithub As System.Windows.Forms.TextBox
    Private WithEvents btnSubmit As System.Windows.Forms.Button
End Class
