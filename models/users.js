const mongoose = require('mongoose')

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