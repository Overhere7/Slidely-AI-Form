# Windows Forms App with TypeScript Backend
![WhatsApp Image 2024-06-21 at 10 32 33 PM](https://github.com/Overhere7/Slidely-AI-Form/assets/110075716/1b360bc1-9124-4b22-8f9c-d8cba47958b3)

![WhatsApp Image 2024-06-21 at 10 32 09 PM](https://github.com/Overhere7/Slidely-AI-Form/assets/110075716/4eb3bf10-7109-455b-8128-7cde9b246837)


## Project Description

This project is a Windows Desktop Application built using Visual Studio and Visual Basic, along with a backend server implemented using TypeScript and Express.js. The application mimics the functionality of Google Forms, allowing users to create and view submissions.

## Desktop App Description

### Features

- **Main Form**:
  - Two buttons: "View Submissions" and "Create New Submission".
  - Keyboard shortcuts: 
    - `Ctrl + V` to open the View Submissions form.
    - `Ctrl + N` to open the Create New Submission form.

- **View Submissions Form**:
  - Displays form submissions one by one.
  - Two buttons: "Previous" and "Next" to navigate through submissions.

- **Create New Submission Form**:
  - Editable fields for Name, Email, Phone Number, and GitHub repo link.
  - Stopwatch functionality with resume and pause capabilities (does not reset on pause).
  - Submit button to send details to the backend.
  - Keyboard shortcut: `Ctrl + S` to submit the form.


## Backend Server Description

The backend server handles API calls for saving and retrieving submissions, using a JSON file (`db.json`) as a database.

### Endpoints

- **GET /ping**: Always returns `true`.
- **POST /submit**: Accepts parameters `name`, `email`, `phone`, `github_link`, and `stopwatch_time`. Saves the submission to the database.
- **GET /read**: Accepts a query parameter `index` (0-based index) to retrieve the corresponding submission from the database.

### JSON Structure

The `db.json` file is used to store submissions in a structured format. The exact structure is up to the developer to define based on the application needs.

## Getting Started

### Prerequisites

- Visual Studio (for Windows Desktop Application)
- Node.js and npm (for backend server)
- TypeScript

### Setup Instructions

#### Backend Server

1. **Install Dependencies:**

   ```bash
   npm install express body-parser fs-extra @types/express @types/body-parser @types/node typescript ts-node

