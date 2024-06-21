<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        btnViewSubmissions = New Button()
        btnCreateNewSubmission = New Button()
        SuspendLayout()
        ' 
        ' btnViewSubmissions
        ' 
        btnViewSubmissions.Location = New Point(20, 23)
        btnViewSubmissions.Margin = New Padding(5, 6, 5, 6)
        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Size = New Size(333, 96)
        btnViewSubmissions.TabIndex = 0
        btnViewSubmissions.Text = "View Submissions"
        btnViewSubmissions.UseVisualStyleBackColor = True
        ' 
        ' btnCreateNewSubmission
        ' 
        btnCreateNewSubmission.Location = New Point(20, 131)
        btnCreateNewSubmission.Margin = New Padding(5, 6, 5, 6)
        btnCreateNewSubmission.Name = "btnCreateNewSubmission"
        btnCreateNewSubmission.Size = New Size(333, 96)
        btnCreateNewSubmission.TabIndex = 1
        btnCreateNewSubmission.Text = "Create New Submission"
        btnCreateNewSubmission.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(473, 502)
        Controls.Add(btnViewSubmissions)
        Controls.Add(btnCreateNewSubmission)
        Margin = New Padding(5, 6, 5, 6)
        Name = "Form1"
        Text = "Form Application"
        ResumeLayout(False)
    End Sub

    Private WithEvents btnViewSubmissions As System.Windows.Forms.Button
    Private WithEvents btnCreateNewSubmission As System.Windows.Forms.Button
End Class
