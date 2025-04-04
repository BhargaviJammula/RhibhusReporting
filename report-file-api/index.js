const express = require('express');
const app = express();

const PORT = 6001;

const cors = require('cors');

// Enable CORS for all requests
app.use(cors());

// Sample file URLs
const fileURLs = {
    1: "https://rhibhhus-ca.s3.ap-south-1.amazonaws.com/employees.json",
    2: "https://rhibhhus-ca.s3.ap-south-1.amazonaws.com/employees-13.json",
    3: "https://rhibhhus-ca.s3.ap-south-1.amazonaws.com/employees-19.json"
};

app.get('/', (req, res) => {
    res.send('Hello World!')
  })

// GET route to return file URL based on type
app.get('/get-file/:filetype', (req, res) => {
    const fileType = req.params.filetype ? req.params.filetype.toLowerCase() : null;

    if (!fileType) {
        return res.status(400).json({ error: "Filetype is required!" });
    }

    const url = fileURLs[fileType];

    if (!url) {
        return res.status(404).json({ error: "Filetype not supported!" });
    }

    res.json({ fileType, url });
});

app.listen(PORT, () => {
    console.log(`Server is running at http://localhost:${PORT}`);
});
