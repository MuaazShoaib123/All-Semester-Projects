const mongoose = require('mongoose')

const budgetSchema = new mongoose.Schema({
    UserId : String,
    BudgetCategory : String,
    Amount : Number
},
{timestamps : true}
);
module.exports= mongoose.model('Budget',budgetSchema)