const mongoose = require('mongoose');

const expenseAuditSchema = new mongoose.Schema({
    UserId: String,
    Category: String,
    Description: String,
    Amount: Number,
    Action: String, // 'create', 'update', or 'delete'
    Timestamp: { type: Date, default: Date.now }
});

module.exports = mongoose.model('ExpenseAudit', expenseAuditSchema);