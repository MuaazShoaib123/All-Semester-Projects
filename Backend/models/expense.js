const mongoose = require('mongoose')
// Schema for Expenses
const expenseSchema = new mongoose.Schema({
    UserId: String,
    Category: String,
    Description: String,
    Amount: Number
},
    { timestamps: true }
);
module.exports = mongoose.model('Expense', expenseSchema)