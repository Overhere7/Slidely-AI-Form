Imports Microsoft.VisualBasic

Imports System.Net.Http
Imports Newtonsoft.Json
Imports System.Net

Public Class ViewSubmissionsForm
    Private submissions As List(Of Submission)
    Private currentIndex As Integer = 0

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSubmissions()
        DisplaySubmission()
    End Sub

    Private Sub LoadSubmissions()
        Dim client As New WebClient()
        Try
            Dim json As String = client.DownloadString("http://localhost:3000/read?index=0")
            submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(json)
            For Each submission As Submission In submissions
                lstSubmissions.Items.Add(submission.Name)
            Next
        Catch ex As Exception
            MessageBox.Show("Failed to load submissions: " & ex.Message)
        End Try
    End Sub

    Private Sub DisplaySubmission()
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            Dim submission As Submission = submissions(currentIndex)
            lblName.Text = "Name: " & submission.Name
            lblEmail.Text = "Email: " & submission.Email
            lblPhone.Text = "Phone: " & submission.Phone
            lblGitHub.Text = "GitHub: " & submission.GitHubLink
            lblStopwatch.Text = "Stopwatch: " & submission.StopwatchTime
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission()
        End If
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = Keys.Control + Keys.V Then
            btnNext.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
End Class

Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GitHubLink As String
    Public Property StopwatchTime As String
End Class