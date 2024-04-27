const mongoose = require('mongoose')

// Schema for Users
const usersSchema = new mongoose.Schema({
    FirstName: String,
    LastName: String,
    DOB: String,
    Email: String,
    Password: String

},
    { timestamps: true }
);
module.exports = mongoose.model('Users', usersSchema)