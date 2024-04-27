const mongoose = require('mongoose')

// Schema for Budget

const budgetSchema = new mongoose.Schema({
    UserId: String,
    Category: String,
    Amount: Number,
    oldamount: Number
},
    { timestamps: true }
);
module.exports = mongoose.model('Budget', budgetSchema)