Imports System.Drawing
Imports System.Windows.Forms

Public Class FormCreateSubmission
    Inherits Form

    Private WithEvents nameLabel As Label
    Private WithEvents emailLabel As Label
    Private WithEvents phoneLabel As Label
    Private WithEvents githubLabel As Label

    Private WithEvents nameTextBox As TextBox
    Private WithEvents emailTextBox As TextBox
    Private WithEvents phoneTextBox As TextBox
    Private WithEvents githubTextBox As TextBox

    Private WithEvents submitButton As Button

    Public Sub New()
        ' Initialize form
        Me.Text = "Create New Submission"
        Me.Size = New Size(400, 300)

        ' Initialize labels
        nameLabel = New Label()
        emailLabel = New Label()
        phoneLabel = New Label()
        githubLabel = New Label()

        ' Initialize textboxes
        nameTextBox = New TextBox()
        emailTextBox = New TextBox()
        phoneTextBox = New TextBox()
        githubTextBox = New TextBox()

        ' Initialize button
        submitButton = New Button()

        ' Set label properties
        nameLabel.Text = "Name:"
        nameLabel.Location = New Point(20, 20)
        nameLabel.AutoSize = True

        emailLabel.Text = "Email:"
        emailLabel.Location = New Point(20, 60)
        emailLabel.AutoSize = True

        phoneLabel.Text = "Phone Number:"
        phoneLabel.Location = New Point(20, 100)
        phoneLabel.AutoSize = True

        githubLabel.Text = "GitHub Link:"
        githubLabel.Location = New Point(20, 140)
        githubLabel.AutoSize = True

        ' Set TextBox properties
        nameTextBox.Name = "nameTextBox"
        nameTextBox.Location = New Point(150, 20)
        nameTextBox.Width = 200
        nameTextBox.ForeColor = Color.Gray
        nameTextBox.Text = "Name"

        emailTextBox.Name = "emailTextBox"
        emailTextBox.Location = New Point(150, 60)
        emailTextBox.Width = 200
        emailTextBox.ForeColor = Color.Gray
        emailTextBox.Text = "Email"

        phoneTextBox.Name = "phoneTextBox"
        phoneTextBox.Location = New Point(150, 100)
        phoneTextBox.Width = 200
        phoneTextBox.ForeColor = Color.Gray
        phoneTextBox.Text = "Phone Number"

        githubTextBox.Name = "githubTextBox"
        githubTextBox.Location = New Point(150, 140)
        githubTextBox.Width = 200
        githubTextBox.ForeColor = Color.Gray
        githubTextBox.Text = "GitHub Link"

        ' Set Button properties
        submitButton.Text = "Submit"
        submitButton.Location = New Point(150, 180)
        submitButton.Width = 200

        ' Add controls to the form
        Me.Controls.Add(nameLabel)
        Me.Controls.Add(emailLabel)
        Me.Controls.Add(phoneLabel)
        Me.Controls.Add(githubLabel)
        Me.Controls.Add(nameTextBox)
        Me.Controls.Add(emailTextBox)
        Me.Controls.Add(phoneTextBox)
        Me.Controls.Add(githubTextBox)
        Me.Controls.Add(submitButton)

        ' Attach event handlers
        AddHandler nameTextBox.Enter, AddressOf RemovePlaceholder
        AddHandler emailTextBox.Enter, AddressOf RemovePlaceholder
        AddHandler phoneTextBox.Enter, AddressOf RemovePlaceholder
        AddHandler githubTextBox.Enter, AddressOf RemovePlaceholder

        AddHandler nameTextBox.Leave, AddressOf SetPlaceholder
        AddHandler emailTextBox.Leave, AddressOf SetPlaceholder
        AddHandler phoneTextBox.Leave, AddressOf SetPlaceholder
        AddHandler githubTextBox.Leave, AddressOf SetPlaceholder

        AddHandler submitButton.Click, AddressOf btnSubmit_Click
    End Sub

    ' Event handler to remove placeholder text
    Private Sub RemovePlaceholder(sender As Object, e As EventArgs)
        Dim textBox As TextBox = TryCast(sender, TextBox)
        If textBox IsNot Nothing AndAlso textBox.ForeColor = Color.Gray Then
            textBox.Text = ""
            textBox.ForeColor = Color.Black
        End If
    End Sub

    ' Event handler to set placeholder text
    Private Sub SetPlaceholder(sender As Object, e As EventArgs)
        Dim textBox As TextBox = TryCast(sender, TextBox)
        If textBox IsNot Nothing AndAlso String.IsNullOrWhiteSpace(textBox.Text) Then
            Select Case textBox.Name
                Case "nameTextBox"
                    textBox.Text = "Name"
                Case "emailTextBox"
                    textBox.Text = "Email"
                Case "phoneTextBox"
                    textBox.Text = "Phone Number"
                Case "githubTextBox"
                    textBox.Text = "GitHub Link"
            End Select
            textBox.ForeColor = Color.Gray
        End If
    End Sub

    ' Event handler for the Submit button click
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs)
        ' Here you can add your code to handle the form submission
        MessageBox.Show("Form Submitted Successfully")
    End Sub

    ' Form Load event to set initial placeholders and attach handlers
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        ' Set initial placeholders
        SetPlaceholder(nameTextBox, EventArgs.Empty)
        SetPlaceholder(emailTextBox, EventArgs.Empty)
        SetPlaceholder(phoneTextBox, EventArgs.Empty)
        SetPlaceholder(githubTextBox, EventArgs.Empty)
    End Sub
End Class
