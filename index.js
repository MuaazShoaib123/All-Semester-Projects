const express = require('express');
const app = express();
const port = 3005;
const bodyParser = require('body-parser');
const usersroute = require('./routes/usersroute');
const cors = require('cors');
app.use(cors());


const mongoose = require('mongoose');
mongoose.set('strictQuery', true); // or true 

mongoose.connect('mongodb://127.0.0.1:27017/SEProject-apis', {
  useNewUrlParser: true,
  useUnifiedTopology: true,
});
const db = mongoose.connection;
db.on('error', (err) => {
  console.log('Failed to connect with db');
});
db.once('open', () => {
  console.log('Connected with db');
});

app.use(bodyParser.json())
app.use('/api', usersroute);

app.listen(port, () => {
  console.log(`Server is listening on port ${port}`);
});


