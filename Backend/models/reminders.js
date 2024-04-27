const mongoose = require('mongoose')

// Schema for Reminder
const reminderSchema = new mongoose.Schema({
    UserId: String,
    Category: String,
    Description: String,
    Date: String,
    Time: String,
    Status: String
},
    { timestamps: true }
);
module.exports = mongoose.model('Reminder', reminderSchema)