const mongoose = require('mongoose');

// Schema for Reminder Audit
const reminderAuditSchema = new mongoose.Schema({
    UserId: String,
    Title: String,
    Description: String,
    Date: String,
    Status: String,
    Action: String, // 'create', 'update', or 'delete'
    Timestamp: { type: Date, default: Date.now }
});

module.exports = mongoose.model('ReminderAudit', reminderAuditSchema);
