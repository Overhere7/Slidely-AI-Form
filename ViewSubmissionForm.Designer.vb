Imports Microsoft.VisualBasic

Partial Class ViewSubmissionsForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Private WithEvents btnPrevious As Button
    Private WithEvents btnNext As Button
    Private WithEvents lstSubmissions As ListBox
    Private WithEvents lblName As Label
    Private WithEvents lblEmail As Label
    Private WithEvents lblPhone As Label
    Private WithEvents lblGitHub As Label
    Private WithEvents lblStopwatch As Label

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lstSubmissions = New System.Windows.Forms.ListBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblGitHub = New System.Windows.Forms.Label()
        Me.lblStopwatch = New System.Windows.Forms.Label()
        Me.SuspendLayout()

        ' 
        ' btnPrevious
        ' 
        Me.btnPrevious.Location = New System.Drawing.Point(12, 226)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 0
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True

        ' 
        ' btnNext
        ' 
        Me.btnNext.Location = New System.Drawing.Point(93, 226)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True

        ' 
        ' lstSubmissions
        ' 
        Me.lstSubmissions.FormattingEnabled = True
        Me.lstSubmissions.Location = New System.Drawing.Point(12, 12)
        Me.lstSubmissions.Name = "lstSubmissions"
        Me.lstSubmissions.Size = New System.Drawing.Size(156, 199)
        Me.lstSubmissions.TabIndex = 2

        ' 
        ' lblName
        ' 
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(174, 12)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Name"

        ' 
        ' lblEmail
        ' 
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(174, 35)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 4
        Me.lblEmail.Text = "Email"

        ' 
        ' lblPhone
        ' 
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(174, 58)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(41, 13)
        Me.lblPhone.TabIndex = 5
        Me.lblPhone.Text = "Phone"

        ' 
        ' lblGitHub
        ' 
        Me.lblGitHub.AutoSize = True
        Me.lblGitHub.Location = New System.Drawing.Point(174, 81)
        Me.lblGitHub.Name = "lblGitHub"
        Me.lblGitHub.Size = New System.Drawing.Size(47, 13)
        Me.lblGitHub.TabIndex = 6
        Me.lblGitHub.Text = "GitHub"

        ' 
        ' lblStopwatch
        ' 
        Me.lblStopwatch.AutoSize = True
        Me.lblStopwatch.Location = New System.Drawing.Point(174, 104)
        Me.lblStopwatch.Name = "lblStopwatch"
        Me.lblStopwatch.Size = New System.Drawing.Size(58, 13)
        Me.lblStopwatch.TabIndex = 7
        Me.lblStopwatch.Text = "Stopwatch"

        ' 
        ' ViewSubmissionsForm
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblStopwatch)
        Me.Controls.Add(Me.lblGitHub)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lstSubmissions)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Name = "ViewSubmissionsForm"
        Me.Text = "View Submissions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

End Class
