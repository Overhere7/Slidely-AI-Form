const express = require('express');
const bodyParser = require('body-parser');
const fs = require('fs-extra');
const path = require('path');

const app = express();
const PORT = 3000;
const DB_PATH = path.join(__dirname, 'db.json');

app.use(bodyParser.json());

app.get('/ping', (req, res) => {
    res.json(true);
});

app.post('/submit', (req, res) => {
    const submission = req.body;
    fs.readJson(DB_PATH)
        .then(data => {
            data.push(submission);
            return fs.writeJson(DB_PATH, data);
        })
        .then(() => res.status(201).json({ message: 'Submission saved!' }))
        .catch(err => res.status(500).json({ error: err.message }));
});

app.get('/read', (req, res) => {
    const index = parseInt(req.query.index as string, 10);
    fs.readJson(DB_PATH)
        .then(data => res.json(data[index]))
        .catch(err => res.status(500).json({ error: err.message }));
});

app.listen(PORT, () => {
    console.log(`Server is running on http://localhost:${PORT}`);
});
