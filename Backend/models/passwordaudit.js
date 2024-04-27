const mongoose = require('mongoose');
// Schema for Password Audit
const passwordAuditSchema = new mongoose.Schema({
    UserId: String,
    oldPassowrd: String,
    Action: String, // 'create', 'update', or 'delete'
    Timestamp: { type: Date, default: Date.now }
});

module.exports = mongoose.model('PasswordAudit', passwordAuditSchema);