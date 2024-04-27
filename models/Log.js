const mongoose = require('mongoose');

const logSchema = new mongoose.Schema({
  TableName: String,
  functionName: String,
  exceptionMessage: String,
  createdAt: { type: Date, default: Date.now },
});

module.exports = mongoose.model('Logs', logSchema);