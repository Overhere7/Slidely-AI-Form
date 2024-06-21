Public Class Form1
    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewForm As New ViewSubmissionsForm()
        viewForm.Show()
        ' Code to handle View Submissions button click
        MessageBox.Show("View Submissions button clicked")
    End Sub

    Private Sub btnCreateNewSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateNewSubmission.Click
        Dim createSubmissionForm As New FormCreateSubmission()
        createSubmissionForm.ShowDialog()
        ' Code to handle Create New Submission button click
        MessageBox.Show("Create New Submission button clicked")
    End Sub

    ' Override the ProcessCmdKey method to handle keyboard shortcuts
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        ' Check for Ctrl + V shortcut for View Submissions
        If keyData = (Keys.Control Or Keys.V) Then
            btnViewSubmissions.PerformClick()
            Return True
        End If

        ' Check for Ctrl + N shortcut for Create New Submission
        If keyData = (Keys.Control Or Keys.N) Then
            btnCreateNewSubmission.PerformClick()
            Return True
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class