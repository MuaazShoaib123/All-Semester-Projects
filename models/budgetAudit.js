const mongoose = require('mongoose');

const budgetAuditSchema = new mongoose.Schema({
    UserId: String,
    Category: String,
    Amount: Number,
    Action: String, // 'create', 'update', or 'delete'
    Timestamp: { type: Date, default: Date.now }
});

module.exports = mongoose.model('BudgetAudit', budgetAuditSchema);